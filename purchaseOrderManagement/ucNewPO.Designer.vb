<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNewPO
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbSupplierNewPo = New System.Windows.Forms.ComboBox()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.txtTaxNewPo = New System.Windows.Forms.TextBox()
        Me.txtDeliveryDateNewPo = New System.Windows.Forms.TextBox()
        Me.txtPoDateNewPo = New System.Windows.Forms.TextBox()
        Me.txtPoNumberNewPo = New System.Windows.Forms.TextBox()
        Me.lblPODetails = New System.Windows.Forms.Label()
        Me.btnAddNewPo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbItemNewPo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmmountNewPo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtyNewPo = New System.Windows.Forms.TextBox()
        Me.txtUOMNewPo = New System.Windows.Forms.TextBox()
        Me.txtRateNewPo = New System.Windows.Forms.TextBox()
        Me.dgvNewPODetailsReview = New System.Windows.Forms.DataGridView()
        Me.btnSaveNewPo = New System.Windows.Forms.Button()
        Me.btnCancleNewPo = New System.Windows.Forms.Button()
        Me.lblReviewAndSave = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvNewPODetailsReview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmbSupplierNewPo)
        Me.Panel1.Controls.Add(Me.lblUOM)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblRate)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblItemCode)
        Me.Panel1.Controls.Add(Me.txtTaxNewPo)
        Me.Panel1.Controls.Add(Me.txtDeliveryDateNewPo)
        Me.Panel1.Controls.Add(Me.txtPoDateNewPo)
        Me.Panel1.Controls.Add(Me.txtPoNumberNewPo)
        Me.Panel1.Controls.Add(Me.lblPODetails)
        Me.Panel1.Location = New System.Drawing.Point(27, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1013, 220)
        Me.Panel1.TabIndex = 3
        '
        'cmbSupplierNewPo
        '
        Me.cmbSupplierNewPo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbSupplierNewPo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplierNewPo.ForeColor = System.Drawing.Color.Black
        Me.cmbSupplierNewPo.FormattingEnabled = True
        Me.cmbSupplierNewPo.ItemHeight = 25
        Me.cmbSupplierNewPo.Location = New System.Drawing.Point(600, 82)
        Me.cmbSupplierNewPo.Name = "cmbSupplierNewPo"
        Me.cmbSupplierNewPo.Size = New System.Drawing.Size(394, 33)
        Me.cmbSupplierNewPo.TabIndex = 4
        '
        'lblUOM
        '
        Me.lblUOM.AutoSize = True
        Me.lblUOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblUOM.Location = New System.Drawing.Point(597, 62)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(60, 17)
        Me.lblUOM.TabIndex = 3
        Me.lblUOM.Text = "Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(314, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tax"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblRate.Location = New System.Drawing.Point(26, 139)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(93, 17)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Delivery Date"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(314, 62)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(59, 17)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Po Date"
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblItemCode.Location = New System.Drawing.Point(26, 62)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(79, 17)
        Me.lblItemCode.TabIndex = 3
        Me.lblItemCode.Text = "Po Number"
        '
        'txtTaxNewPo
        '
        Me.txtTaxNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaxNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtTaxNewPo.Location = New System.Drawing.Point(317, 159)
        Me.txtTaxNewPo.Multiline = True
        Me.txtTaxNewPo.Name = "txtTaxNewPo"
        Me.txtTaxNewPo.Size = New System.Drawing.Size(272, 35)
        Me.txtTaxNewPo.TabIndex = 1
        '
        'txtDeliveryDateNewPo
        '
        Me.txtDeliveryDateNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeliveryDateNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtDeliveryDateNewPo.Location = New System.Drawing.Point(29, 159)
        Me.txtDeliveryDateNewPo.Multiline = True
        Me.txtDeliveryDateNewPo.Name = "txtDeliveryDateNewPo"
        Me.txtDeliveryDateNewPo.Size = New System.Drawing.Size(272, 35)
        Me.txtDeliveryDateNewPo.TabIndex = 1
        '
        'txtPoDateNewPo
        '
        Me.txtPoDateNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoDateNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtPoDateNewPo.Location = New System.Drawing.Point(317, 80)
        Me.txtPoDateNewPo.Multiline = True
        Me.txtPoDateNewPo.Name = "txtPoDateNewPo"
        Me.txtPoDateNewPo.Size = New System.Drawing.Size(272, 35)
        Me.txtPoDateNewPo.TabIndex = 1
        '
        'txtPoNumberNewPo
        '
        Me.txtPoNumberNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoNumberNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtPoNumberNewPo.Location = New System.Drawing.Point(29, 82)
        Me.txtPoNumberNewPo.Multiline = True
        Me.txtPoNumberNewPo.Name = "txtPoNumberNewPo"
        Me.txtPoNumberNewPo.Size = New System.Drawing.Size(272, 35)
        Me.txtPoNumberNewPo.TabIndex = 1
        '
        'lblPODetails
        '
        Me.lblPODetails.AutoSize = True
        Me.lblPODetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPODetails.Location = New System.Drawing.Point(3, 9)
        Me.lblPODetails.Name = "lblPODetails"
        Me.lblPODetails.Size = New System.Drawing.Size(97, 22)
        Me.lblPODetails.TabIndex = 0
        Me.lblPODetails.Text = "PO Details"
        '
        'btnAddNewPo
        '
        Me.btnAddNewPo.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddNewPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewPo.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewPo.ForeColor = System.Drawing.Color.White
        Me.btnAddNewPo.Location = New System.Drawing.Point(870, 65)
        Me.btnAddNewPo.Name = "btnAddNewPo"
        Me.btnAddNewPo.Size = New System.Drawing.Size(124, 38)
        Me.btnAddNewPo.TabIndex = 2
        Me.btnAddNewPo.Text = "Add"
        Me.btnAddNewPo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmbItemNewPo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtAmmountNewPo)
        Me.Panel2.Controls.Add(Me.btnAddNewPo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtQtyNewPo)
        Me.Panel2.Controls.Add(Me.txtUOMNewPo)
        Me.Panel2.Controls.Add(Me.txtRateNewPo)
        Me.Panel2.Location = New System.Drawing.Point(27, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 129)
        Me.Panel2.TabIndex = 4
        '
        'cmbItemNewPo
        '
        Me.cmbItemNewPo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbItemNewPo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemNewPo.ForeColor = System.Drawing.Color.Black
        Me.cmbItemNewPo.FormattingEnabled = True
        Me.cmbItemNewPo.ItemHeight = 25
        Me.cmbItemNewPo.Items.AddRange(New Object() {""})
        Me.cmbItemNewPo.Location = New System.Drawing.Point(6, 70)
        Me.cmbItemNewPo.Name = "cmbItemNewPo"
        Me.cmbItemNewPo.Size = New System.Drawing.Size(219, 33)
        Me.cmbItemNewPo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(255, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "UOM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(716, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(567, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Qty"
        '
        'txtAmmountNewPo
        '
        Me.txtAmmountNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmmountNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtAmmountNewPo.Location = New System.Drawing.Point(719, 65)
        Me.txtAmmountNewPo.Multiline = True
        Me.txtAmmountNewPo.Name = "txtAmmountNewPo"
        Me.txtAmmountNewPo.Size = New System.Drawing.Size(118, 35)
        Me.txtAmmountNewPo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(412, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rate"
        '
        'txtQtyNewPo
        '
        Me.txtQtyNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtyNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtQtyNewPo.Location = New System.Drawing.Point(570, 65)
        Me.txtQtyNewPo.Multiline = True
        Me.txtQtyNewPo.Name = "txtQtyNewPo"
        Me.txtQtyNewPo.Size = New System.Drawing.Size(118, 35)
        Me.txtQtyNewPo.TabIndex = 1
        '
        'txtUOMNewPo
        '
        Me.txtUOMNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUOMNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtUOMNewPo.Location = New System.Drawing.Point(258, 65)
        Me.txtUOMNewPo.Multiline = True
        Me.txtUOMNewPo.Name = "txtUOMNewPo"
        Me.txtUOMNewPo.Size = New System.Drawing.Size(118, 35)
        Me.txtUOMNewPo.TabIndex = 1
        '
        'txtRateNewPo
        '
        Me.txtRateNewPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRateNewPo.ForeColor = System.Drawing.Color.Black
        Me.txtRateNewPo.Location = New System.Drawing.Point(415, 65)
        Me.txtRateNewPo.Multiline = True
        Me.txtRateNewPo.Name = "txtRateNewPo"
        Me.txtRateNewPo.Size = New System.Drawing.Size(118, 35)
        Me.txtRateNewPo.TabIndex = 1
        '
        'dgvNewPODetailsReview
        '
        Me.dgvNewPODetailsReview.AllowUserToResizeColumns = False
        Me.dgvNewPODetailsReview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvNewPODetailsReview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNewPODetailsReview.BackgroundColor = System.Drawing.Color.White
        Me.dgvNewPODetailsReview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNewPODetailsReview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNewPODetailsReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNewPODetailsReview.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNewPODetailsReview.GridColor = System.Drawing.Color.White
        Me.dgvNewPODetailsReview.Location = New System.Drawing.Point(27, 446)
        Me.dgvNewPODetailsReview.Name = "dgvNewPODetailsReview"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNewPODetailsReview.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvNewPODetailsReview.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvNewPODetailsReview.RowTemplate.Height = 24
        Me.dgvNewPODetailsReview.Size = New System.Drawing.Size(1013, 203)
        Me.dgvNewPODetailsReview.TabIndex = 5
        '
        'btnSaveNewPo
        '
        Me.btnSaveNewPo.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveNewPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveNewPo.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNewPo.ForeColor = System.Drawing.Color.White
        Me.btnSaveNewPo.Location = New System.Drawing.Point(27, 671)
        Me.btnSaveNewPo.Name = "btnSaveNewPo"
        Me.btnSaveNewPo.Size = New System.Drawing.Size(124, 38)
        Me.btnSaveNewPo.TabIndex = 2
        Me.btnSaveNewPo.Text = "Save Po"
        Me.btnSaveNewPo.UseVisualStyleBackColor = False
        '
        'btnCancleNewPo
        '
        Me.btnCancleNewPo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancleNewPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancleNewPo.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnCancleNewPo.ForeColor = System.Drawing.Color.Black
        Me.btnCancleNewPo.Location = New System.Drawing.Point(166, 671)
        Me.btnCancleNewPo.Name = "btnCancleNewPo"
        Me.btnCancleNewPo.Size = New System.Drawing.Size(124, 38)
        Me.btnCancleNewPo.TabIndex = 6
        Me.btnCancleNewPo.Text = "Cancle "
        Me.btnCancleNewPo.UseVisualStyleBackColor = True
        '
        'lblReviewAndSave
        '
        Me.lblReviewAndSave.AutoSize = True
        Me.lblReviewAndSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewAndSave.Location = New System.Drawing.Point(30, 421)
        Me.lblReviewAndSave.Name = "lblReviewAndSave"
        Me.lblReviewAndSave.Size = New System.Drawing.Size(154, 22)
        Me.lblReviewAndSave.TabIndex = 0
        Me.lblReviewAndSave.Text = "Review and Save "
        '
        'ucNewPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCancleNewPo)
        Me.Controls.Add(Me.lblReviewAndSave)
        Me.Controls.Add(Me.dgvNewPODetailsReview)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSaveNewPo)
        Me.Name = "ucNewPO"
        Me.Size = New System.Drawing.Size(1071, 712)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvNewPODetailsReview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbSupplierNewPo As ComboBox
    Friend WithEvents lblUOM As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblItemCode As Label
    Friend WithEvents btnAddNewPo As Button
    Friend WithEvents txtDeliveryDateNewPo As TextBox
    Friend WithEvents txtPoDateNewPo As TextBox
    Friend WithEvents txtPoNumberNewPo As TextBox
    Friend WithEvents lblPODetails As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaxNewPo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbItemNewPo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAmmountNewPo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtyNewPo As TextBox
    Friend WithEvents txtUOMNewPo As TextBox
    Friend WithEvents txtRateNewPo As TextBox
    Friend WithEvents dgvNewPODetailsReview As DataGridView
    Friend WithEvents btnSaveNewPo As Button
    Friend WithEvents btnCancleNewPo As Button
    Friend WithEvents lblReviewAndSave As Label
End Class
