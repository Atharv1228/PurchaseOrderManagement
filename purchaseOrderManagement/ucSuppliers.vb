Imports System.Data
Imports System.Drawing

Public Class ucSuppliers

    Private dt As New DataTable()
    Private objSuppliers As New clsSuppliers()

    '''Runs when the control first loads - pulls existing suppliers from the DB into the grid.
    Private Sub ucSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    ''' Refreshes the DataGridView from the database.
    Private Sub LoadGrid()
        dt = objSuppliers.GetAllSuppliers()
        DataGridView1.DataSource = dt
        DataGridView1.Columns("SupplierID").Visible = False   ' internal ID, not for the user to see
        ' Blue theme
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 246, 255)
        ' Visual Studio's dark theme can make the default grid colors hard to read -
        ' set them explicitly instead of relying on the theme's defaults.
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
        '  DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.EnableHeadersVisualStyles = False
    End Sub

    ''' Adds a new row to the grid only - not saved to the DB until "Save" is clicked.
    Private Sub btnAddSuppliers_Click(sender As Object, e As EventArgs) Handles btnAddSuppliers.Click
        If String.IsNullOrWhiteSpace(txtNameSuppliers.Text) Then
            MessageBox.Show("Please enter a supplier name.")
            Return
        End If

        dt.Rows.Add(0, txtNameSuppliers.Text, txtPhoneSuppliers.Text, txtEmailSuppliers.Text)
        ClearFields()
    End Sub

    ''' Updates the row currently selected in the grid with the values in the text boxes.
    Private Sub btnUpdateSuppliers_Click(sender As Object, e As EventArgs) Handles btnUpdateSuppliers.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a supplier from the grid first.")
            Return
        End If

        Dim row As DataRow = CType(DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row
        row("Name") = txtNameSuppliers.Text
        row("Phone") = txtPhoneSuppliers.Text
        row("Email") = txtEmailSuppliers.Text
        ClearFields()
    End Sub

    ''' Deletes the selected supplier immediately - from the DB (if it has an ID) and from the grid.
    Private Sub btnDeleteSuppliers_Click(sender As Object, e As EventArgs) Handles btnDeleteSuppliers.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a supplier from the grid first.")
            Return
        End If

        Dim row As DataRow = CType(DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row
        Dim id As Integer = CInt(row("SupplierID"))

        If id > 0 Then
            objSuppliers.DeleteSupplier(id)
        End If

        row.Delete()
        ClearFields()
        modStatus.SetStatus("Supplier deleted.")
    End Sub

    ''' Clears the input fields only - does not touch the grid.
    Private Sub btnClearSuppliers_Click(sender As Object, e As EventArgs) Handles btnClearSuppliers.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtNameSuppliers.Clear()
        txtPhoneSuppliers.Clear()
        txtEmailSuppliers.Clear()
    End Sub

    ''' When a grid row is clicked, load its values into the text boxes for editing.
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count = 0 Then Return

        ' The blank "new row" placeholder at the bottom of the grid has no bound data yet -
        ' selecting it fires this event with a null DataBoundItem, which used to crash here.
        Dim boundItem As Object = DataGridView1.SelectedRows(0).DataBoundItem
        If boundItem Is Nothing Then Return

        Dim row As DataRow = CType(boundItem, DataRowView).Row
        txtNameSuppliers.Text = row("Name").ToString()
        txtPhoneSuppliers.Text = row("Phone").ToString()
        txtEmailSuppliers.Text = row("Email").ToString()
    End Sub

    ''' <summary>Lets the user pick an Excel file and merges its rows into the grid.</summary>
    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Excel Files|*.xlsx;*.xls"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim objExcel As New clsExcelHelper()
                    Dim importedRows As DataTable = objExcel.ImportSuppliers(ofd.FileName)

                    For Each r As DataRow In importedRows.Rows
                        dt.Rows.Add(r.ItemArray)
                    Next

                    modStatus.SetStatus(importedRows.Rows.Count & " supplier(s) imported. Click Save to store them.")
                Catch ex As Exception
                    MessageBox.Show("Could not import: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ''' <summary>Pushes every row currently in the grid into the database (insert new, update existing).</summary>
    Private Sub btnSaveToSuppliersDB_Click(sender As Object, e As EventArgs) Handles btnSaveToSuppliersDB.Click
        Try
            objSuppliers.SaveAll(dt)
            modStatus.SetStatus("Suppliers saved successfully.")
        Catch ex As Exception
            modStatus.SetStatus("Error saving suppliers: " & ex.Message)
        End Try
    End Sub


End Class
