<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPurchaseOrders
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
        Me.btnAddNewPO = New System.Windows.Forms.Button()
        Me.dgvPurchaseOrder = New System.Windows.Forms.DataGridView()
        Me.btnDeletePo = New System.Windows.Forms.Button()
        Me.btnEditPo = New System.Windows.Forms.Button()
        Me.btnExportPO = New System.Windows.Forms.Button()
        Me.btnSavePOToDB = New System.Windows.Forms.Button()
        CType(Me.dgvPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddNewPO
        '
        Me.btnAddNewPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAddNewPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewPO.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewPO.ForeColor = System.Drawing.Color.White
        Me.btnAddNewPO.Location = New System.Drawing.Point(944, 19)
        Me.btnAddNewPO.Name = "btnAddNewPO"
        Me.btnAddNewPO.Size = New System.Drawing.Size(124, 34)
        Me.btnAddNewPO.TabIndex = 3
        Me.btnAddNewPO.Text = "New PO"
        Me.btnAddNewPO.UseVisualStyleBackColor = False
        '
        'dgvPurchaseOrder
        '
        Me.dgvPurchaseOrder.AllowUserToResizeColumns = False
        Me.dgvPurchaseOrder.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPurchaseOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPurchaseOrder.BackgroundColor = System.Drawing.Color.White
        Me.dgvPurchaseOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPurchaseOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchaseOrder.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPurchaseOrder.GridColor = System.Drawing.Color.White
        Me.dgvPurchaseOrder.Location = New System.Drawing.Point(3, 59)
        Me.dgvPurchaseOrder.Name = "dgvPurchaseOrder"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPurchaseOrder.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPurchaseOrder.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPurchaseOrder.RowTemplate.Height = 24
        Me.dgvPurchaseOrder.Size = New System.Drawing.Size(1065, 342)
        Me.dgvPurchaseOrder.TabIndex = 4
        '
        'btnDeletePo
        '
        Me.btnDeletePo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDeletePo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePo.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnDeletePo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDeletePo.Location = New System.Drawing.Point(970, 409)
        Me.btnDeletePo.Name = "btnDeletePo"
        Me.btnDeletePo.Size = New System.Drawing.Size(87, 30)
        Me.btnDeletePo.TabIndex = 7
        Me.btnDeletePo.Text = "Delete"
        Me.btnDeletePo.UseVisualStyleBackColor = True
        '
        'btnEditPo
        '
        Me.btnEditPo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEditPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPo.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnEditPo.ForeColor = System.Drawing.Color.Black
        Me.btnEditPo.Location = New System.Drawing.Point(877, 409)
        Me.btnEditPo.Name = "btnEditPo"
        Me.btnEditPo.Size = New System.Drawing.Size(87, 30)
        Me.btnEditPo.TabIndex = 8
        Me.btnEditPo.Text = "Edit"
        Me.btnEditPo.UseVisualStyleBackColor = True
        '
        'btnExportPO
        '
        Me.btnExportPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportPO.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnExportPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnExportPO.Location = New System.Drawing.Point(749, 409)
        Me.btnExportPO.Name = "btnExportPO"
        Me.btnExportPO.Size = New System.Drawing.Size(122, 30)
        Me.btnExportPO.TabIndex = 10
        Me.btnExportPO.Text = "Export Excel"
        Me.btnExportPO.UseVisualStyleBackColor = True
        '
        'btnSavePOToDB
        '
        Me.btnSavePOToDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnSavePOToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePOToDB.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePOToDB.ForeColor = System.Drawing.Color.White
        Me.btnSavePOToDB.Location = New System.Drawing.Point(619, 409)
        Me.btnSavePOToDB.Name = "btnSavePOToDB"
        Me.btnSavePOToDB.Size = New System.Drawing.Size(124, 30)
        Me.btnSavePOToDB.TabIndex = 3
        Me.btnSavePOToDB.Text = "Save"
        Me.btnSavePOToDB.UseVisualStyleBackColor = False
        '
        'ucPurchaseOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.btnExportPO)
        Me.Controls.Add(Me.btnEditPo)
        Me.Controls.Add(Me.btnDeletePo)
        Me.Controls.Add(Me.dgvPurchaseOrder)
        Me.Controls.Add(Me.btnSavePOToDB)
        Me.Controls.Add(Me.btnAddNewPO)
        Me.Name = "ucPurchaseOrders"
        Me.Size = New System.Drawing.Size(1071, 677)
        CType(Me.dgvPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddNewPO As Button
    Friend WithEvents dgvPurchaseOrder As DataGridView
    Friend WithEvents btnDeletePo As Button
    Friend WithEvents btnEditPo As Button
    Friend WithEvents btnExportPO As Button
    Friend WithEvents btnSavePOToDB As Button
End Class
