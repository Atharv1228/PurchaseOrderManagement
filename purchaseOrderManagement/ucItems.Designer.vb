<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItems
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
        Me.gdvItemDetails = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbUOMItems = New System.Windows.Forms.ComboBox()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnDeleteItems = New System.Windows.Forms.Button()
        Me.btnUpdateItems = New System.Windows.Forms.Button()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.btnClearItems = New System.Windows.Forms.Button()
        Me.btnAddItems = New System.Windows.Forms.Button()
        Me.txtRateItems = New System.Windows.Forms.TextBox()
        Me.txtDescriptionItems = New System.Windows.Forms.TextBox()
        Me.txtItemCodeItems = New System.Windows.Forms.TextBox()
        Me.lblItemDetails = New System.Windows.Forms.Label()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.btnSaveToItemDB = New System.Windows.Forms.Button()
        CType(Me.gdvItemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gdvItemDetails
        '
        Me.gdvItemDetails.AllowUserToResizeColumns = False
        Me.gdvItemDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.gdvItemDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gdvItemDetails.BackgroundColor = System.Drawing.Color.White
        Me.gdvItemDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdvItemDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gdvItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdvItemDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.gdvItemDetails.GridColor = System.Drawing.Color.White
        Me.gdvItemDetails.Location = New System.Drawing.Point(19, 67)
        Me.gdvItemDetails.Name = "gdvItemDetails"
        Me.gdvItemDetails.RowTemplate.Height = 24
        Me.gdvItemDetails.Size = New System.Drawing.Size(710, 278)
        Me.gdvItemDetails.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmbUOMItems)
        Me.Panel1.Controls.Add(Me.lblUOM)
        Me.Panel1.Controls.Add(Me.lblRate)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.btnDeleteItems)
        Me.Panel1.Controls.Add(Me.btnUpdateItems)
        Me.Panel1.Controls.Add(Me.lblItemCode)
        Me.Panel1.Controls.Add(Me.btnClearItems)
        Me.Panel1.Controls.Add(Me.btnAddItems)
        Me.Panel1.Controls.Add(Me.txtRateItems)
        Me.Panel1.Controls.Add(Me.txtDescriptionItems)
        Me.Panel1.Controls.Add(Me.txtItemCodeItems)
        Me.Panel1.Controls.Add(Me.lblItemDetails)
        Me.Panel1.Location = New System.Drawing.Point(752, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 414)
        Me.Panel1.TabIndex = 2
        '
        'cmbUOMItems
        '
        Me.cmbUOMItems.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbUOMItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUOMItems.ForeColor = System.Drawing.Color.Black
        Me.cmbUOMItems.FormattingEnabled = True
        Me.cmbUOMItems.ItemHeight = 25
        Me.cmbUOMItems.Items.AddRange(New Object() {"Nos", "Kg ", "Gm ", "Ltr ", "Mtr ", "Ft ", "Box ", "Set ", "Pkt ", "Roll ", "Dozen ", "Pair"})
        Me.cmbUOMItems.Location = New System.Drawing.Point(9, 245)
        Me.cmbUOMItems.Name = "cmbUOMItems"
        Me.cmbUOMItems.Size = New System.Drawing.Size(124, 33)
        Me.cmbUOMItems.TabIndex = 4
        '
        'lblUOM
        '
        Me.lblUOM.AutoSize = True
        Me.lblUOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblUOM.Location = New System.Drawing.Point(6, 223)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(40, 17)
        Me.lblUOM.TabIndex = 3
        Me.lblUOM.Text = "UOM"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblRate.Location = New System.Drawing.Point(154, 223)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(38, 17)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rate"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(6, 139)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description"
        '
        'btnDeleteItems
        '
        Me.btnDeleteItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItems.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnDeleteItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDeleteItems.Location = New System.Drawing.Point(157, 348)
        Me.btnDeleteItems.Name = "btnDeleteItems"
        Me.btnDeleteItems.Size = New System.Drawing.Size(124, 30)
        Me.btnDeleteItems.TabIndex = 2
        Me.btnDeleteItems.Text = "Delete"
        Me.btnDeleteItems.UseVisualStyleBackColor = True
        '
        'btnUpdateItems
        '
        Me.btnUpdateItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUpdateItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateItems.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnUpdateItems.ForeColor = System.Drawing.Color.White
        Me.btnUpdateItems.Location = New System.Drawing.Point(9, 348)
        Me.btnUpdateItems.Name = "btnUpdateItems"
        Me.btnUpdateItems.Size = New System.Drawing.Size(124, 30)
        Me.btnUpdateItems.TabIndex = 2
        Me.btnUpdateItems.Text = "Update"
        Me.btnUpdateItems.UseVisualStyleBackColor = False
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblItemCode.Location = New System.Drawing.Point(6, 62)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(71, 17)
        Me.lblItemCode.TabIndex = 3
        Me.lblItemCode.Text = "Item Code"
        '
        'btnClearItems
        '
        Me.btnClearItems.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearItems.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnClearItems.ForeColor = System.Drawing.Color.Black
        Me.btnClearItems.Location = New System.Drawing.Point(157, 312)
        Me.btnClearItems.Name = "btnClearItems"
        Me.btnClearItems.Size = New System.Drawing.Size(124, 30)
        Me.btnClearItems.TabIndex = 2
        Me.btnClearItems.Text = "Clear"
        Me.btnClearItems.UseVisualStyleBackColor = True
        '
        'btnAddItems
        '
        Me.btnAddItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItems.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItems.ForeColor = System.Drawing.Color.White
        Me.btnAddItems.Location = New System.Drawing.Point(9, 312)
        Me.btnAddItems.Name = "btnAddItems"
        Me.btnAddItems.Size = New System.Drawing.Size(124, 30)
        Me.btnAddItems.TabIndex = 2
        Me.btnAddItems.Text = "Add"
        Me.btnAddItems.UseVisualStyleBackColor = False
        '
        'txtRateItems
        '
        Me.txtRateItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRateItems.ForeColor = System.Drawing.Color.Black
        Me.txtRateItems.Location = New System.Drawing.Point(157, 243)
        Me.txtRateItems.Multiline = True
        Me.txtRateItems.Name = "txtRateItems"
        Me.txtRateItems.Size = New System.Drawing.Size(124, 35)
        Me.txtRateItems.TabIndex = 1
        '
        'txtDescriptionItems
        '
        Me.txtDescriptionItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescriptionItems.ForeColor = System.Drawing.Color.Black
        Me.txtDescriptionItems.Location = New System.Drawing.Point(9, 159)
        Me.txtDescriptionItems.Multiline = True
        Me.txtDescriptionItems.Name = "txtDescriptionItems"
        Me.txtDescriptionItems.Size = New System.Drawing.Size(272, 35)
        Me.txtDescriptionItems.TabIndex = 1
        '
        'txtItemCodeItems
        '
        Me.txtItemCodeItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCodeItems.ForeColor = System.Drawing.Color.Black
        Me.txtItemCodeItems.Location = New System.Drawing.Point(9, 82)
        Me.txtItemCodeItems.Multiline = True
        Me.txtItemCodeItems.Name = "txtItemCodeItems"
        Me.txtItemCodeItems.Size = New System.Drawing.Size(272, 35)
        Me.txtItemCodeItems.TabIndex = 1
        '
        'lblItemDetails
        '
        Me.lblItemDetails.AutoSize = True
        Me.lblItemDetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDetails.Location = New System.Drawing.Point(3, 9)
        Me.lblItemDetails.Name = "lblItemDetails"
        Me.lblItemDetails.Size = New System.Drawing.Size(106, 22)
        Me.lblItemDetails.TabIndex = 0
        Me.lblItemDetails.Text = "Item Details"
        '
        'btnImportExcel
        '
        Me.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportExcel.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnImportExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnImportExcel.Location = New System.Drawing.Point(19, 31)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(122, 30)
        Me.btnImportExcel.TabIndex = 10
        Me.btnImportExcel.Text = "Import Excel"
        Me.btnImportExcel.UseVisualStyleBackColor = True
        '
        'btnSaveToItemDB
        '
        Me.btnSaveToItemDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveToItemDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveToItemDB.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToItemDB.ForeColor = System.Drawing.Color.White
        Me.btnSaveToItemDB.Location = New System.Drawing.Point(605, 351)
        Me.btnSaveToItemDB.Name = "btnSaveToItemDB"
        Me.btnSaveToItemDB.Size = New System.Drawing.Size(124, 30)
        Me.btnSaveToItemDB.TabIndex = 2
        Me.btnSaveToItemDB.Text = "Save"
        Me.btnSaveToItemDB.UseVisualStyleBackColor = False
        '
        'ucItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.btnImportExcel)
        Me.Controls.Add(Me.gdvItemDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSaveToItemDB)
        Me.Name = "ucItems"
        Me.Size = New System.Drawing.Size(1071, 677)
        CType(Me.gdvItemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gdvItemDetails As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblItemCode As Label
    Friend WithEvents btnClearItems As Button
    Friend WithEvents btnDeleteItems As Button
    Friend WithEvents btnUpdateItems As Button
    Friend WithEvents btnAddItems As Button
    Friend WithEvents txtRateItems As TextBox
    Friend WithEvents txtDescriptionItems As TextBox
    Friend WithEvents txtItemCodeItems As TextBox
    Friend WithEvents lblItemDetails As Label
    Friend WithEvents cmbUOMItems As ComboBox
    Friend WithEvents lblUOM As Label
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents btnSaveToItemDB As Button
End Class
