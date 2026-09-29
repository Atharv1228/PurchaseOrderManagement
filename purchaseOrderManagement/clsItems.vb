Imports System.Data
Imports System.Data.SqlClient


' Handles all database work for Items.

Public Class clsItems

    ''' <summary>Loads every item from the database into a DataTable.</summary>
    Public Function GetAllItems() As DataTable
        Dim dt As New DataTable()
        Using con As SqlConnection = modDBConnection.GetConnection()
            Dim query As String = "SELECT ItemID, ItemCode, Description, UOM, Rate FROM Items ORDER BY ItemCode"
            Using da As New SqlDataAdapter(query, con)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ''' <summary>Inserts a new item and returns its new ItemID.</summary>
    Public Function InsertItem(code As String, description As String, uom As String, rate As Decimal) As Integer
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "INSERT INTO Items (ItemCode, Description, UOM, Rate) " &
                                   "OUTPUT INSERTED.ItemID VALUES (@Code, @Desc, @UOM, @Rate)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Code", code)
                cmd.Parameters.AddWithValue("@Desc", description)
                cmd.Parameters.AddWithValue("@UOM", uom)
                cmd.Parameters.AddWithValue("@Rate", rate)
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    ''' <summary>Updates an existing item by ItemID.</summary>
    Public Sub UpdateItem(itemID As Integer, code As String, description As String, uom As String, rate As Decimal)
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "UPDATE Items SET ItemCode=@Code, Description=@Desc, UOM=@UOM, Rate=@Rate WHERE ItemID=@ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Code", code)
                cmd.Parameters.AddWithValue("@Desc", description)
                cmd.Parameters.AddWithValue("@UOM", uom)
                cmd.Parameters.AddWithValue("@Rate", rate)
                cmd.Parameters.AddWithValue("@ID", itemID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>Deletes an item by ItemID.</summary>
    Public Sub DeleteItem(itemID As Integer)
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "DELETE FROM Items WHERE ItemID=@ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", itemID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>Insert new / update existing rows from the working grid (same pattern as clsSuppliers.SaveAll).</summary>
    Public Sub SaveAll(dt As DataTable)
        For Each row As DataRow In dt.Rows
            Dim id As Integer = CInt(row("ItemID"))
            Dim code As String = row("ItemCode").ToString()
            Dim desc As String = row("Description").ToString()
            Dim uom As String = row("UOM").ToString()
            Dim rate As Decimal = If(IsDBNull(row("Rate")), 0D, Convert.ToDecimal(row("Rate")))

            If id = 0 Then
                Dim newID As Integer = InsertItem(code, desc, uom, rate)
                row("ItemID") = newID
            Else
                UpdateItem(id, code, desc, uom, rate)
            End If
        Next
    End Sub

End Class
