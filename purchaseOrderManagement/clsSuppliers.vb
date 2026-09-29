Imports System.Data
Imports System.Data.SqlClient


''' Handles all database work for Suppliers.
''' ucSuppliers never talks to SQL directly - it calls these methods.

Public Class clsSuppliers

    ''' Loads every supplier from the database into a DataTable.
    Public Function GetAllSuppliers() As DataTable
        Dim dt As New DataTable()
        Using con As SqlConnection = modDBConnection.GetConnection()
            Dim query As String = "SELECT SupplierID, Name, Phone, Email FROM Suppliers ORDER BY Name"
            Using da As New SqlDataAdapter(query, con)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ''' <summary>Inserts a new supplier and returns its new SupplierID.</summary>
    Public Function InsertSupplier(name As String, phone As String, email As String) As Integer
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "INSERT INTO Suppliers (Name, Phone, Email) " &
                                   "OUTPUT INSERTED.SupplierID VALUES (@Name, @Phone, @Email)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@Email", email)
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    ''' <summary>Updates an existing supplier by SupplierID.</summary>
    Public Sub UpdateSupplier(supplierID As Integer, name As String, phone As String, email As String)
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "UPDATE Suppliers SET Name=@Name, Phone=@Phone, Email=@Email WHERE SupplierID=@ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@ID", supplierID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Deletes a supplier by SupplierID.
    Public Sub DeleteSupplier(supplierID As Integer)
        Using con As SqlConnection = modDBConnection.GetConnection()
            con.Open()
            Dim query As String = "DELETE FROM Suppliers WHERE SupplierID=@ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", supplierID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Saves the whole working grid to the database in one go.
    ''' Rows with SupplierID = 0 are new -> Insert.
    ''' Rows with SupplierID > 0 are existing -> Update.
    ''' Called when the user clicks "Save".
    ''' </summary>
    Public Sub SaveAll(dt As DataTable)
        For Each row As DataRow In dt.Rows
            Dim id As Integer = CInt(row("SupplierID"))
            Dim name As String = row("Name").ToString()
            Dim phone As String = row("Phone").ToString()
            Dim email As String = row("Email").ToString()

            If id = 0 Then
                Dim newID As Integer = InsertSupplier(name, phone, email)
                row("SupplierID") = newID   ' grid now shows the real database ID
            Else
                UpdateSupplier(id, name, phone, email)
            End If
        Next
    End Sub

End Class
