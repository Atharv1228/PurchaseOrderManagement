<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSuppliers
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClearSuppliers = New System.Windows.Forms.Button()
        Me.btnDeleteSuppliers = New System.Windows.Forms.Button()
        Me.btnUpdateSuppliers = New System.Windows.Forms.Button()
        Me.btnAddSuppliers = New System.Windows.Forms.Button()
        Me.txtEmailSuppliers = New System.Windows.Forms.TextBox()
        Me.txtPhoneSuppliers = New System.Windows.Forms.TextBox()
        Me.txtNameSuppliers = New System.Windows.Forms.TextBox()
        Me.lblSupplierDetails = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSaveToSuppliersDB = New System.Windows.Forms.Button()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClearSuppliers)
        Me.Panel1.Controls.Add(Me.btnDeleteSuppliers)
        Me.Panel1.Controls.Add(Me.btnUpdateSuppliers)
        Me.Panel1.Controls.Add(Me.btnAddSuppliers)
        Me.Panel1.Controls.Add(Me.txtEmailSuppliers)
        Me.Panel1.Controls.Add(Me.txtPhoneSuppliers)
        Me.Panel1.Controls.Add(Me.txtNameSuppliers)
        Me.Panel1.Controls.Add(Me.lblSupplierDetails)
        Me.Panel1.Location = New System.Drawing.Point(748, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 421)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'btnClearSuppliers
        '
        Me.btnClearSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSuppliers.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnClearSuppliers.ForeColor = System.Drawing.Color.Black
        Me.btnClearSuppliers.Location = New System.Drawing.Point(157, 343)
        Me.btnClearSuppliers.Name = "btnClearSuppliers"
        Me.btnClearSuppliers.Size = New System.Drawing.Size(124, 30)
        Me.btnClearSuppliers.TabIndex = 2
        Me.btnClearSuppliers.Text = "Clear"
        Me.btnClearSuppliers.UseVisualStyleBackColor = True
        '
        'btnDeleteSuppliers
        '
        Me.btnDeleteSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDeleteSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSuppliers.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnDeleteSuppliers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDeleteSuppliers.Location = New System.Drawing.Point(9, 343)
        Me.btnDeleteSuppliers.Name = "btnDeleteSuppliers"
        Me.btnDeleteSuppliers.Size = New System.Drawing.Size(124, 30)
        Me.btnDeleteSuppliers.TabIndex = 2
        Me.btnDeleteSuppliers.Text = "Delete"
        Me.btnDeleteSuppliers.UseVisualStyleBackColor = True
        '
        'btnUpdateSuppliers
        '
        Me.btnUpdateSuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUpdateSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSuppliers.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnUpdateSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSuppliers.Location = New System.Drawing.Point(157, 307)
        Me.btnUpdateSuppliers.Name = "btnUpdateSuppliers"
        Me.btnUpdateSuppliers.Size = New System.Drawing.Size(124, 30)
        Me.btnUpdateSuppliers.TabIndex = 2
        Me.btnUpdateSuppliers.Text = "Update"
        Me.btnUpdateSuppliers.UseVisualStyleBackColor = False
        '
        'btnAddSuppliers
        '
        Me.btnAddSuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSuppliers.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnAddSuppliers.Location = New System.Drawing.Point(9, 307)
        Me.btnAddSuppliers.Name = "btnAddSuppliers"
        Me.btnAddSuppliers.Size = New System.Drawing.Size(124, 30)
        Me.btnAddSuppliers.TabIndex = 2
        Me.btnAddSuppliers.Text = "Add"
        Me.btnAddSuppliers.UseVisualStyleBackColor = False
        '
        'txtEmailSuppliers
        '
        Me.txtEmailSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailSuppliers.ForeColor = System.Drawing.Color.Black
        Me.txtEmailSuppliers.Location = New System.Drawing.Point(9, 243)
        Me.txtEmailSuppliers.Multiline = True
        Me.txtEmailSuppliers.Name = "txtEmailSuppliers"
        Me.txtEmailSuppliers.Size = New System.Drawing.Size(272, 35)
        Me.txtEmailSuppliers.TabIndex = 1
        '
        'txtPhoneSuppliers
        '
        Me.txtPhoneSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneSuppliers.ForeColor = System.Drawing.Color.Black
        Me.txtPhoneSuppliers.Location = New System.Drawing.Point(9, 159)
        Me.txtPhoneSuppliers.Multiline = True
        Me.txtPhoneSuppliers.Name = "txtPhoneSuppliers"
        Me.txtPhoneSuppliers.Size = New System.Drawing.Size(272, 35)
        Me.txtPhoneSuppliers.TabIndex = 1
        '
        'txtNameSuppliers
        '
        Me.txtNameSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameSuppliers.ForeColor = System.Drawing.Color.Black
        Me.txtNameSuppliers.Location = New System.Drawing.Point(9, 82)
        Me.txtNameSuppliers.Multiline = True
        Me.txtNameSuppliers.Name = "txtNameSuppliers"
        Me.txtNameSuppliers.Size = New System.Drawing.Size(272, 35)
        Me.txtNameSuppliers.TabIndex = 1
        '
        'lblSupplierDetails
        '
        Me.lblSupplierDetails.AutoSize = True
        Me.lblSupplierDetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierDetails.Location = New System.Drawing.Point(3, 9)
        Me.lblSupplierDetails.Name = "lblSupplierDetails"
        Me.lblSupplierDetails.Size = New System.Drawing.Size(140, 22)
        Me.lblSupplierDetails.TabIndex = 0
        Me.lblSupplierDetails.Text = "Supplier Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(19, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(710, 278)
        Me.DataGridView1.TabIndex = 1
        '
        'btnSaveToSuppliersDB
        '
        Me.btnSaveToSuppliersDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSaveToSuppliersDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveToSuppliersDB.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToSuppliersDB.ForeColor = System.Drawing.Color.White
        Me.btnSaveToSuppliersDB.Location = New System.Drawing.Point(605, 351)
        Me.btnSaveToSuppliersDB.Name = "btnSaveToSuppliersDB"
        Me.btnSaveToSuppliersDB.Size = New System.Drawing.Size(124, 30)
        Me.btnSaveToSuppliersDB.TabIndex = 2
        Me.btnSaveToSuppliersDB.Text = "Save"
        Me.btnSaveToSuppliersDB.UseVisualStyleBackColor = False
        '
        'btnImportExcel
        '
        Me.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportExcel.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnImportExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnImportExcel.Location = New System.Drawing.Point(19, 31)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(122, 30)
        Me.btnImportExcel.TabIndex = 11
        Me.btnImportExcel.Text = "Import Excel"
        Me.btnImportExcel.UseVisualStyleBackColor = True
        '
        'ucSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.btnImportExcel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSaveToSuppliersDB)
        Me.Name = "ucSuppliers"
        Me.Size = New System.Drawing.Size(1071, 677)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddSuppliers As Button
    Friend WithEvents txtEmailSuppliers As TextBox
    Friend WithEvents txtPhoneSuppliers As TextBox
    Friend WithEvents txtNameSuppliers As TextBox
    Friend WithEvents lblSupplierDetails As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearSuppliers As Button
    Friend WithEvents btnDeleteSuppliers As Button
    Friend WithEvents btnUpdateSuppliers As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSaveToSuppliersDB As Button
    Friend WithEvents btnImportExcel As Button
End Class
