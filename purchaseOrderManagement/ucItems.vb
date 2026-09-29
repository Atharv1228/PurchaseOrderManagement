Imports System.Data
Imports System.Drawing

Public Class ucItems

    Private dt As New DataTable()
    Private objItems As New clsItems()

    Private Sub ucItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUOMList()
        LoadGrid()
    End Sub

    ''' <summary>Fills the UOM dropdown with the fixed list of units.</summary>
    Private Sub LoadUOMList()
        cmbUOMItems.Items.Clear()
        cmbUOMItems.Items.AddRange({"Nos", "Kg", "Gm", "Ltr", "Mtr", "Ft", "Box", "Set", "Pkt", "Roll", "Dozen", "Pair"})
    End Sub

    Private Sub LoadGrid()
        dt = objItems.GetAllItems()
        gdvItemDetails.DataSource = dt
        gdvItemDetails.Columns("ItemID").Visible = False

        ' Explicit colors so selection is actually visible under VS's dark theme.
        gdvItemDetails.DefaultCellStyle.BackColor = Color.White
        gdvItemDetails.DefaultCellStyle.ForeColor = Color.Black
        gdvItemDetails.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
        gdvItemDetails.DefaultCellStyle.SelectionForeColor = Color.White
        gdvItemDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        gdvItemDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        gdvItemDetails.EnableHeadersVisualStyles = False
    End Sub

    'Adds a new row to the grid only - not saved to the DB until "Save" is clicked.
    Private Sub btnAddItems_Click(sender As Object, e As EventArgs) Handles btnAddItems.Click
        If String.IsNullOrWhiteSpace(txtItemCodeItems.Text) Then
            MessageBox.Show("Please enter an item code.")
            Return
        End If

        Dim rate As Decimal
        If Not Decimal.TryParse(txtRateItems.Text, rate) Then
            MessageBox.Show("Please enter a valid rate.")
            Return
        End If

        dt.Rows.Add(0, txtItemCodeItems.Text, txtDescriptionItems.Text, cmbUOMItems.Text, rate)
        ClearFields()
    End Sub

    'Updates the row currently selected in the grid with the values in the fields.
    Private Sub btnUpdateItems_Click(sender As Object, e As EventArgs) Handles btnUpdateItems.Click
        If gdvItemDetails.SelectedRows.Count = 0 Then
            MessageBox.Show("Select an item from the grid first.")
            Return
        End If

        Dim rate As Decimal
        If Not Decimal.TryParse(txtRateItems.Text, rate) Then
            MessageBox.Show("Please enter a valid rate.")
            Return
        End If

        Dim row As DataRow = CType(gdvItemDetails.SelectedRows(0).DataBoundItem, DataRowView).Row
        row("ItemCode") = txtItemCodeItems.Text
        row("Description") = txtDescriptionItems.Text
        row("UOM") = cmbUOMItems.Text
        row("Rate") = rate
        ClearFields()
    End Sub

    ''' <summary>Deletes the selected item immediately - from the DB (if it has an ID) and from the grid.</summary>
    Private Sub btnDeleteItems_Click(sender As Object, e As EventArgs) Handles btnDeleteItems.Click
        If gdvItemDetails.SelectedRows.Count = 0 Then
            MessageBox.Show("Select an item from the grid first.")
            Return
        End If

        Dim row As DataRow = CType(gdvItemDetails.SelectedRows(0).DataBoundItem, DataRowView).Row
        Dim id As Integer = CInt(row("ItemID"))

        If id > 0 Then
            objItems.DeleteItem(id)
        End If

        row.Delete()
        ClearFields()
        modStatus.SetStatus("Item deleted.")
    End Sub

    Private Sub btnClearItems_Click(sender As Object, e As EventArgs) Handles btnClearItems.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtItemCodeItems.Clear()
        txtDescriptionItems.Clear()
        cmbUOMItems.SelectedIndex = -1
        txtRateItems.Clear()
    End Sub

    'When a grid row is clicked, load its values into the fields for editing.
    Private Sub gdvItemDetails_SelectionChanged(sender As Object, e As EventArgs) Handles gdvItemDetails.SelectionChanged
        If gdvItemDetails.SelectedRows.Count = 0 Then Return

        ' Selecting the blank "new row" placeholder fires this with no bound data yet - guard against that.
        Dim boundItem As Object = gdvItemDetails.SelectedRows(0).DataBoundItem
        If boundItem Is Nothing Then Return

        Dim row As DataRow = CType(boundItem, DataRowView).Row
        txtItemCodeItems.Text = row("ItemCode").ToString()
        txtDescriptionItems.Text = row("Description").ToString()
        cmbUOMItems.Text = row("UOM").ToString()
        txtRateItems.Text = row("Rate").ToString()
    End Sub

    ''Lets the user pick an Excel file and merges its rows into the grid.
    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Excel Files|*.xlsx;*.xls"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim objExcel As New clsExcelHelper()
                    Dim importedRows As DataTable = objExcel.ImportItems(ofd.FileName)

                    For Each r As DataRow In importedRows.Rows
                        dt.Rows.Add(r.ItemArray)
                    Next

                    modStatus.SetStatus(importedRows.Rows.Count & " item(s) imported. Click Save to store them.")
                Catch ex As Exception
                    MessageBox.Show("Could not import: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ''' <summary>Pushes every row currently in the grid into the database (insert new, update existing).</summary>
    Private Sub btnSaveToItemDB_Click(sender As Object, e As EventArgs) Handles btnSaveToItemDB.Click
        Try
            objItems.SaveAll(dt)
            modStatus.SetStatus("Items saved successfully.")
        Catch ex As Exception
            modStatus.SetStatus("Error saving items: " & ex.Message)
        End Try
    End Sub

End Class
