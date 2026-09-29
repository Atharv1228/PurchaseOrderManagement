Imports frmMain.class
Imports System.Data
Public Class ucPurchaseOrders
    'Private newPO As New ucNewPO()
    'Private Sub btnAddNewPO_Click(sender As Object, e As EventArgs) Handles btnAddNewPO.Click, btnSavePOToDB.Click

    '    Dim _frmMain As frmMain = CType(Me.FindForm(), frmMain)   'Me.FindForm() finds the form that already contains the UserControl .
    '    _frmMain.LoadScreen(newPO)
    'End Sub


    Private dt As New DataTable()
    Private objPO As New clsPurchaseOrders()

    Private Sub ucPurchaseOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    ''' <summary>Reloads the PO summary grid from the database.</summary>
    Private Sub LoadGrid()
        dt = objPO.GetAllPOs()
        dgvPurchaseOrder.DataSource = dt
        dgvPurchaseOrder.Columns("POID").Visible = False   ' internal ID only

        ' Only Date and Delivery can be hand-edited in the grid.
        ' PO Number, Supplier and Total are set by the New PO screen and shouldn't be typed over here.
        dgvPurchaseOrder.Columns("PO Number").ReadOnly = True
        dgvPurchaseOrder.Columns("Supplier").ReadOnly = True
        dgvPurchaseOrder.Columns("Total(Rs.)").ReadOnly = True
    End Sub

    ''' <summary>Re-reads the grid from the database - call this after coming back from New PO.</summary>
    Public Sub RefreshGrid()
        LoadGrid()
    End Sub

    ''' <summary>Opens a blank New PO screen. Uses your existing LoadScreen navigation.</summary>
    Private Sub btnAddNewPO_Click(sender As Object, e As EventArgs) Handles btnAddNewPO.Click
        Dim newPO As New ucNewPO()
        Dim _frmMain As frmMain = CType(Me.FindForm(), frmMain)
        _frmMain.LoadScreen(newPO)
    End Sub

    ''' <summary>Exports the selected purchase order to an Excel workbook.</summary>
    Private Sub btnExportPO_Click(sender As Object, e As EventArgs) Handles btnExportPO.Click
        If dgvPurchaseOrder.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a purchase order first.")
            Return
        End If

        Dim row As DataRow = CType(dgvPurchaseOrder.SelectedRows(0).DataBoundItem, DataRowView).Row
        Dim poID As Integer = CInt(row("POID"))

        Dim header As DataRow = objPO.GetPOHeader(poID)
        Dim details As DataTable = objPO.GetPODetails(poID)

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Files|*.xlsx"
            sfd.FileName = header("PONumber").ToString() & ".xlsx"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim objExcel As New clsExcelHelper()
                objExcel.ExportPO(
                    header("PONumber").ToString(),
                    CDate(header("PODate")),
                    row("Supplier").ToString(),
                    CDate(header("DeliveryDate")),
                    CDec(header("TaxPercent")),
                    CDec(header("TotalAmount")),
                    details,
                    sfd.FileName)

                modStatus.SetStatus("Purchase order exported to Excel.")
            End If
        End Using
    End Sub

    ''' <summary>Opens the selected PO in the New PO screen, pre-filled, for editing.</summary>
    Private Sub btnEditPo_Click(sender As Object, e As EventArgs) Handles btnEditPo.Click
        If dgvPurchaseOrder.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a purchase order first.")
            Return
        End If

        Dim row As DataRow = CType(dgvPurchaseOrder.SelectedRows(0).DataBoundItem, DataRowView).Row
        Dim poID As Integer = CInt(row("POID"))

        Dim editPO As New ucNewPO()
        editPO.LoadForEdit(poID)   ' fills the screen with this PO's existing data

        Dim _frmMain As frmMain = CType(Me.FindForm(), frmMain)
        _frmMain.LoadScreen(editPO)
    End Sub

    ''' <summary>Deletes the selected purchase order (and its line items) after confirmation.</summary>
    Private Sub btnDeletePo_Click(sender As Object, e As EventArgs) Handles btnDeletePo.Click
        If dgvPurchaseOrder.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a purchase order first.")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Delete the selected purchase order?",
                                                        "Confirm Delete", MessageBoxButtons.YesNo)
        If confirm <> DialogResult.Yes Then Return

        Dim row As DataRow = CType(dgvPurchaseOrder.SelectedRows(0).DataBoundItem, DataRowView).Row
        objPO.DeletePO(CInt(row("POID")))

        LoadGrid()
        modStatus.SetStatus("Purchase order deleted.")
    End Sub

    ''' <summary>
    ''' Saves any direct edits made in the grid (Date / Delivery Date) back to the database.
    ''' For full edits (items, supplier, tax) use the Edit button instead, which opens the New PO screen.
    ''' NOTE: make sure this button's Click event is wired ONLY to btnSavePOToDB - not also to
    ''' btnAddNewPO's handler, or clicking Save will open a blank New PO screen instead of saving.
    ''' </summary>
    Private Sub btnSavePOToDB_Click(sender As Object, e As EventArgs) Handles btnSavePOToDB.Click
        Try
            For Each row As DataRow In dt.Rows
                If row.RowState = DataRowState.Modified Then
                    objPO.UpdatePOHeaderDates(CInt(row("POID")), CDate(row("Date")), CDate(row("Delivery")))
                End If
            Next
            dt.AcceptChanges()
            modStatus.SetStatus("Purchase orders updated.")
        Catch ex As Exception
            modStatus.SetStatus("Error saving: " & ex.Message)
        End Try
    End Sub
End Class
