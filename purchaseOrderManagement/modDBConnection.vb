Imports System.Data.SqlClient


''' Central place for the database connection string.
''' Every class module asks this module for a connection
''' instead of building its own connection string.

Module modDBConnection


    Private ReadOnly ConnString As String =
        "Data Source=MECH\SQLEXPRESS;Initial Catalog=PurchaseOrderDB;Integrated Security=True"


    ''' Returns a fresh, unopened SqlConnection.
    ''' Callers are responsible for opening/closing it (so i used a Using blocks at callers).

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnString)
    End Function

End Module
