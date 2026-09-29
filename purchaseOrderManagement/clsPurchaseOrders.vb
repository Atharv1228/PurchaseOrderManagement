Imports System.Data
Imports System.Data.SqlClient
''' Handles all database work for Purchase Orders (header + line items).

Public Class clsPurchaseOrders

    '''Generates the next PO number in the format PO-YYYY-NNNN.
    Public Function GetNextPONumber() As String
        Dim currentYear As Integer = DateTime.Now.Year
        Dim nextSeq As Integer

        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "SELECT ISNULL(MAX(CAST(RIGHT(PONumber, 4) AS INT)), 0) " &
                                   "FROM PurchaseOrders WHERE PONumber LIKE @Pattern"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Pattern", "PO-" & currentYear & "-%")
                nextSeq = CInt(cmd.ExecuteScalar()) + 1
            End Using
        End Using

        Return $"PO-{currentYear}-{nextSeq:D4}"
    End Function

    ''' <summary>Summary list for dgvPurchaseOrder: PO Number, Date, Supplier, Delivery, Total.</summary>
    Public Function GetAllPOs() As DataTable
        Dim dt As New DataTable()
        Using con As SqlConnection = modDBConnection.GetConnection()
            Dim query As String =
                "SELECT po.POID, po.PONumber AS [PO Number], po.PODate AS [Date], " &
                "s.Name AS [Supplier], po.DeliveryDate AS [Delivery], po.TotalAmount AS [Total(Rs.)] " &
                "FROM PurchaseOrders po " &
                "JOIN Suppliers s ON s.SupplierID = po.SupplierID " &
                "ORDER BY po.POID DESC"
            Using da As New SqlDataAdapter(query, con)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ''' <summary>Full header row for a single PO - used when editing/exporting.</summary>
    Public Function GetPOHeader(poID As Integer) As DataRow
        Dim dt As New DataTable()
        Using con As SqlConnection = modDBConnection.GetConnection()
            Dim query As String = "SELECT * FROM PurchaseOrders WHERE POID=@ID"
            Using da As New SqlDataAdapter(query, con)
                da.SelectCommand.Parameters.AddWithValue("@ID", poID)
                da.Fill(dt)
            End Using
        End Using
        Return If(dt.Rows.Count > 0, dt.Rows(0), Nothing)
    End Function

    ''' <summary>Line items for a single PO - used when editing/exporting.</summary>
    Public Function GetPODetails(poID As Integer) As DataTable
        Dim dt As New DataTable()
        Using con As SqlConnection = modDBConnection.GetConnection()
            Dim query As String =
                "SELECT d.PODetailID, i.ItemCode AS [Item], d.UOM, d.Qty, d.Rate, d.Amount " &
                "FROM PurchaseOrderDetails d " &
                "JOIN Items i ON i.ItemID = d.ItemID " &
                "WHERE d.POID=@ID"
            Using da As New SqlDataAdapter(query, con)
                da.SelectCommand.Parameters.AddWithValue("@ID", poID)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ''' <summary>
    ''' Saves a brand-new Purchase Order (header + all its line items) in one transaction.
    ''' detailsTable columns expected: ItemID, UOM, Qty, Rate, Amount
    ''' </summary>
    Public Sub SaveNewPO(poNumber As String, poDate As Date, supplierID As Integer,
                          deliveryDate As Date, taxPercent As Decimal, totalAmount As Decimal,
                          detailsTable As DataTable)

        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim tran As SqlTransaction = con.BeginTransaction()

            Try
                ' 1. Insert the header, get the new POID back
                Dim poID As Integer
                Dim headerQuery As String =
                    "INSERT INTO PurchaseOrders (PONumber, PODate, SupplierID, DeliveryDate, TaxPercent, TotalAmount) " &
                    "OUTPUT INSERTED.POID " &
                    "VALUES (@PONumber, @PODate, @SupplierID, @DeliveryDate, @Tax, @Total)"

                Using cmd As New SqlCommand(headerQuery, con, tran)
                    cmd.Parameters.AddWithValue("@PONumber", poNumber)
                    cmd.Parameters.AddWithValue("@PODate", poDate)
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID)
                    cmd.Parameters.AddWithValue("@DeliveryDate", deliveryDate)
                    cmd.Parameters.AddWithValue("@Tax", taxPercent)
                    cmd.Parameters.AddWithValue("@Total", totalAmount)
                    poID = CInt(cmd.ExecuteScalar())
                End Using

                ' 2. Insert each line item against that POID
                Dim detailQuery As String =
                    "INSERT INTO PurchaseOrderDetails (POID, ItemID, UOM, Qty, Rate, Amount) " &
                    "VALUES (@POID, @ItemID, @UOM, @Qty, @Rate, @Amount)"

                For Each row As DataRow In detailsTable.Rows
                    Using cmd As New SqlCommand(detailQuery, con, tran)
                        cmd.Parameters.AddWithValue("@POID", poID)
                        cmd.Parameters.AddWithValue("@ItemID", row("ItemID"))
                        cmd.Parameters.AddWithValue("@UOM", row("UOM"))
                        cmd.Parameters.AddWithValue("@Qty", row("Qty"))
                        cmd.Parameters.AddWithValue("@Rate", row("Rate"))
                        cmd.Parameters.AddWithValue("@Amount", row("Amount"))
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                tran.Commit()

            Catch ex As Exception
                tran.Rollback()
                Throw   ' let the caller show the error message
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Updates an existing Purchase Order's header AND replaces all of its line items.
    ''' Used by the Edit flow: old details are deleted, then the current grid is re-inserted.
    ''' </summary>
    Public Sub UpdatePO(poID As Integer, poNumber As String, poDate As Date, supplierID As Integer,
                         deliveryDate As Date, taxPercent As Decimal, totalAmount As Decimal,
                         detailsTable As DataTable)

        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim tran As SqlTransaction = con.BeginTransaction()

            Try
                ' 1. Update the header
                Dim headerQuery As String =
                    "UPDATE PurchaseOrders SET PONumber=@PONumber, PODate=@PODate, SupplierID=@SupplierID, " &
                    "DeliveryDate=@DeliveryDate, TaxPercent=@Tax, TotalAmount=@Total WHERE POID=@POID"

                Using cmd As New SqlCommand(headerQuery, con, tran)
                    cmd.Parameters.AddWithValue("@PONumber", poNumber)
                    cmd.Parameters.AddWithValue("@PODate", poDate)
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID)
                    cmd.Parameters.AddWithValue("@DeliveryDate", deliveryDate)
                    cmd.Parameters.AddWithValue("@Tax", taxPercent)
                    cmd.Parameters.AddWithValue("@Total", totalAmount)
                    cmd.Parameters.AddWithValue("@POID", poID)
                    cmd.ExecuteNonQuery()
                End Using

                ' 2. Wipe the old line items ...
                Using cmd As New SqlCommand("DELETE FROM PurchaseOrderDetails WHERE POID=@POID", con, tran)
                    cmd.Parameters.AddWithValue("@POID", poID)
                    cmd.ExecuteNonQuery()
                End Using

                ' 3. ... and insert the current grid as the new line items
                Dim detailQuery As String =
                    "INSERT INTO PurchaseOrderDetails (POID, ItemID, UOM, Qty, Rate, Amount) " &
                    "VALUES (@POID, @ItemID, @UOM, @Qty, @Rate, @Amount)"

                For Each row As DataRow In detailsTable.Rows
                    Using cmd As New SqlCommand(detailQuery, con, tran)
                        cmd.Parameters.AddWithValue("@POID", poID)
                        cmd.Parameters.AddWithValue("@ItemID", row("ItemID"))
                        cmd.Parameters.AddWithValue("@UOM", row("UOM"))
                        cmd.Parameters.AddWithValue("@Qty", row("Qty"))
                        cmd.Parameters.AddWithValue("@Rate", row("Rate"))
                        cmd.Parameters.AddWithValue("@Amount", row("Amount"))
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                tran.Commit()

            Catch ex As Exception
                tran.Rollback()
                Throw
            End Try
        End Using
    End Sub

    ''' <summary>Updates just the two date fields - used by the inline "Save" button on the PO list screen.</summary>
    Public Sub UpdatePOHeaderDates(poID As Integer, poDate As Date, deliveryDate As Date)
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "UPDATE PurchaseOrders SET PODate=@PODate, DeliveryDate=@Delivery WHERE POID=@ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@PODate", poDate)
                cmd.Parameters.AddWithValue("@Delivery", deliveryDate)
                cmd.Parameters.AddWithValue("@ID", poID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>Deletes a PO header - its line items go too, because of ON DELETE CASCADE.</summary>
    Public Sub DeletePO(poID As Integer)
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "DELETE FROM PurchaseOrders WHERE POID=@ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", poID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Report data between two dates, optionally filtered by supplier.
    ''' supplierID = 0 means "all suppliers". No address column, as requested.
    ''' </summary>
    Public Function GetReportData(fromDate As Date, toDate As Date, supplierID As Integer) As DataTable
        Dim dt As New DataTable()
        Using con As SqlConnection = modDBConnection.GetConnection()
            Dim query As String =
                "SELECT po.PONumber AS [PO Number], po.PODate AS [Date], s.Name AS [Supplier], " &
                "i.ItemCode AS [Item], d.Qty, d.Rate, d.Amount, po.TaxPercent AS [Tax %], po.TotalAmount AS [Grand Total] " &
                "FROM PurchaseOrders po " &
                "JOIN Suppliers s ON s.SupplierID = po.SupplierID " &
                "JOIN PurchaseOrderDetails d ON d.POID = po.POID " &
                "JOIN Items i ON i.ItemID = d.ItemID " &
                "WHERE po.PODate BETWEEN @From AND @To " &
                "AND (@SupplierID = 0 OR po.SupplierID = @SupplierID) " &
                "ORDER BY po.PODate, po.PONumber"
            Using da As New SqlDataAdapter(query, con)
                da.SelectCommand.Parameters.AddWithValue("@From", fromDate)
                da.SelectCommand.Parameters.AddWithValue("@To", toDate)
                da.SelectCommand.Parameters.AddWithValue("@SupplierID", supplierID)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function



End Class
