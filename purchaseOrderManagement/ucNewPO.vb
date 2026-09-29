Imports System.Data

Public Class ucNewPO

    Private objPO As New clsPurchaseOrders()
    Private objItems As New clsItems()
    Private objSuppliers As New clsSuppliers()

    ' Working list of line items for the PO currently being built
    Private dtLineItems As New DataTable()

    ' Full items list, kept in memory so we can look up UOM/Rate by ItemID
    Private dtAllItems As New DataTable()

    ' Edit-mode tracking: when editing an existing PO, we update instead of insert
    Private isEditMode As Boolean = False
    Private editingPOID As Integer = 0

    Private Sub ucNewPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isEditMode Then SetupLineItemsTable()   ' edit mode already built this grid in LoadForEdit()
        LoadSuppliers()
        ApplyPendingSupplierIfAny()
        LoadItems()

        ' If LoadForEdit() already ran (called before this control was shown), don't overwrite its work.
        If Not isEditMode Then
            txtPoNumberNewPo.Text = objPO.GetNextPONumber()
            txtPoDateNewPo.Text = Date.Today.ToString("dd-MMM-yyyy")
        End If

        txtPoNumberNewPo.ReadOnly = True
        txtUOMNewPo.ReadOnly = True
        txtRateNewPo.ReadOnly = True
        txtAmmountNewPo.ReadOnly = True
    End Sub

    ''' <summary>Defines the columns of the in-memory grid that becomes the PO's line items.</summary>
    Private Sub SetupLineItemsTable()
        dtLineItems.Columns.Add("ItemID", GetType(Integer))
        dtLineItems.Columns.Add("Item", GetType(String))    ' ItemCode, for display
        dtLineItems.Columns.Add("UOM", GetType(String))
        dtLineItems.Columns.Add("Qty", GetType(Decimal))
        dtLineItems.Columns.Add("Rate", GetType(Decimal))
        dtLineItems.Columns.Add("Amount", GetType(Decimal))
        dgvNewPODetailsReview.DataSource = dtLineItems
    End Sub

    ''' <summary>Fills the Supplier combo with Name (display) / SupplierID (value).</summary>
    Private Sub LoadSuppliers()
        Dim dtSuppliers As DataTable = objSuppliers.GetAllSuppliers()
        cmbSupplierNewPo.DataSource = dtSuppliers
        cmbSupplierNewPo.DisplayMember = "Name"
        cmbSupplierNewPo.ValueMember = "SupplierID"
        If Not isEditMode Then cmbSupplierNewPo.SelectedIndex = -1
    End Sub

    ''' <summary>Fills the Item combo with ItemCode (display) / ItemID (value).</summary>
    Private Sub LoadItems()
        dtAllItems = objItems.GetAllItems()

        cmbItemNewPo.DisplayMember = "ItemCode"
        cmbItemNewPo.ValueMember = "ItemID"
        cmbItemNewPo.DataSource = dtAllItems.Copy()   ' .Copy() keeps our lookup table independent of the combo
        cmbItemNewPo.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' Called by ucPurchaseOrders BEFORE this control is shown, to pre-fill it
    ''' with an existing PO's data so the user can edit and re-save it.
    ''' </summary>
    Public Sub LoadForEdit(poID As Integer)
        isEditMode = True
        editingPOID = poID

        Dim header As DataRow = objPO.GetPOHeader(poID)
        If header Is Nothing Then Return

        txtPoNumberNewPo.Text = header("PONumber").ToString()
        txtPoDateNewPo.Text = CDate(header("PODate")).ToString("dd-MMM-yyyy")
        txtDeliveryDateNewPo.Text = CDate(header("DeliveryDate")).ToString("dd-MMM-yyyy")
        txtTaxNewPo.Text = header("TaxPercent").ToString() & "%"

        ' Supplier combo isn't bound yet at this point (ucNewPO_Load runs after this),
        ' so remember the SupplierID and apply it once LoadSuppliers() has run.
        pendingSupplierID = CInt(header("SupplierID"))

        ' Reload the line items grid with this PO's existing details
        SetupLineItemsTable()
        Dim details As DataTable = objPO.GetPODetails(poID)
        For Each row As DataRow In details.Rows
            ' details table has ItemCode text, not ItemID - look the ID back up
            Dim itemRows() As DataRow = objItems.GetAllItems().Select("ItemCode = '" & row("Item").ToString() & "'")
            Dim itemID As Integer = If(itemRows.Length > 0, CInt(itemRows(0)("ItemID")), 0)

            dtLineItems.Rows.Add(itemID, row("Item"), row("UOM"), row("Qty"), row("Rate"), row("Amount"))
        Next
    End Sub

    Private pendingSupplierID As Integer = -1

    ''' <summary>Applies the supplier remembered by LoadForEdit(), once the combo has data.</summary>
    Private Sub ApplyPendingSupplierIfAny()
        If pendingSupplierID >= 0 Then
            cmbSupplierNewPo.SelectedValue = pendingSupplierID
            pendingSupplierID = -1
        End If
    End Sub

    ''' <summary>When an item is picked, auto-fill its UOM and Rate (both read-only fields).</summary>
    Private Sub cmbItemNewPo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemNewPo.SelectedIndexChanged
        If cmbItemNewPo.SelectedValue Is Nothing Then Return

        Dim itemID As Integer = CInt(cmbItemNewPo.SelectedValue)
        Dim foundRows() As DataRow = dtAllItems.Select("ItemID = " & itemID)

        If foundRows.Length > 0 Then
            txtUOMNewPo.Text = foundRows(0)("UOM").ToString()
            txtRateNewPo.Text = foundRows(0)("Rate").ToString()
        End If

        CalculateAmount()
    End Sub

    ''' <summary>Recalculates Amount = Qty x Rate whenever the quantity changes.</summary>
    Private Sub txtQtyNewPo_TextChanged(sender As Object, e As EventArgs) Handles txtQtyNewPo.TextChanged
        CalculateAmount()
    End Sub

    Private Sub CalculateAmount()
        Dim qty As Decimal
        Dim rate As Decimal

        Decimal.TryParse(txtQtyNewPo.Text, qty)
        Decimal.TryParse(txtRateNewPo.Text, rate)

        txtAmmountNewPo.Text = (qty * rate).ToString("0.00")
    End Sub

    ''' <summary>Automatically appends a "%" to the tax field as the user types a number.</summary>
    Private Sub txtTaxNewPo_TextChanged(sender As Object, e As EventArgs) Handles txtTaxNewPo.TextChanged
        Dim digitsOnly As String = New String(txtTaxNewPo.Text.Where(AddressOf Char.IsDigit).ToArray())
        If digitsOnly = "" Then Return

        RemoveHandler txtTaxNewPo.TextChanged, AddressOf txtTaxNewPo_TextChanged   ' avoid re-triggering while we edit the text
        txtTaxNewPo.Text = digitsOnly & "%"
        txtTaxNewPo.SelectionStart = txtTaxNewPo.Text.Length - 1                    ' keep the cursor before the %
        AddHandler txtTaxNewPo.TextChanged, AddressOf txtTaxNewPo_TextChanged
    End Sub

    ''' <summary>Adds the current item line to the review grid.</summary>
    Private Sub btnAddNewPo_Click(sender As Object, e As EventArgs) Handles btnAddNewPo.Click
        If cmbItemNewPo.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an item.")
            Return
        End If

        Dim qty As Decimal
        If Not Decimal.TryParse(txtQtyNewPo.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        dtLineItems.Rows.Add(
            CInt(cmbItemNewPo.SelectedValue),
            cmbItemNewPo.Text,
            txtUOMNewPo.Text,
            qty,
            Convert.ToDecimal(txtRateNewPo.Text),
            Convert.ToDecimal(txtAmmountNewPo.Text))

        ClearItemFields()
    End Sub

    Private Sub ClearItemFields()
        cmbItemNewPo.SelectedIndex = -1
        txtUOMNewPo.Clear()
        txtRateNewPo.Clear()
        txtQtyNewPo.Clear()
        txtAmmountNewPo.Clear()
    End Sub

    ''' <summary>Saves the PO (header + all line items). Inserts if new, updates if editing.</summary>
    Private Sub btnSaveNewPo_Click(sender As Object, e As EventArgs) Handles btnSaveNewPo.Click
        MessageBox.Show("Save button clicked")
        If cmbSupplierNewPo.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a supplier.")
            Return
        End If

        If dtLineItems.Rows.Count = 0 Then
            MessageBox.Show("Add at least one item before saving.")
            Return
        End If

        Try
            Dim poDate As Date = Date.Parse(txtPoDateNewPo.Text)
            Dim deliveryDate As Date = Date.Parse(txtDeliveryDateNewPo.Text)
            Dim taxPercent As Decimal = Convert.ToDecimal(txtTaxNewPo.Text.Replace("%", ""))

            ' Subtotal = sum of all line amounts, tax applied once on top for the grand total
            Dim subtotal As Decimal = 0
            For Each row As DataRow In dtLineItems.Rows
                subtotal += Convert.ToDecimal(row("Amount"))
            Next
            Dim grandTotal As Decimal = subtotal + (subtotal * taxPercent / 100D)

            If isEditMode Then
                objPO.UpdatePO(
                    editingPOID,
                    txtPoNumberNewPo.Text,
                    poDate,
                    CInt(cmbSupplierNewPo.SelectedValue),
                    deliveryDate,
                    taxPercent,
                    grandTotal,
                    dtLineItems)
                modStatus.SetStatus("Purchase order " & txtPoNumberNewPo.Text & " updated.")
            Else

                objPO.SaveNewPO(
                    txtPoNumberNewPo.Text,
                    poDate,
                    CInt(cmbSupplierNewPo.SelectedValue),
                    deliveryDate,
                    taxPercent,
                    grandTotal,
                    dtLineItems)

                modStatus.SetStatus("Purchase order " & txtPoNumberNewPo.Text & " saved.")
            End If

            ReturnToPOList()

        Catch ex As Exception
            'modStatus.SetStatus("Error saving purchase order: " & ex.Message)
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    ''' <summary>Clears everything and returns to the Purchase Orders list screen.</summary>
    Private Sub btnCancleNewPo_Click(sender As Object, e As EventArgs) Handles btnCancleNewPo.Click
        ReturnToPOList()
    End Sub

    ''' <summary>Switches back to a freshly-loaded Purchase Orders list (so it shows the latest data).</summary>
    Private Sub ReturnToPOList()
        Dim poList As New ucPurchaseOrders()
        Dim _frmMain As frmMain = CType(Me.FindForm(), frmMain)
        _frmMain.LoadScreen(poList)
    End Sub

End Class
