<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPurchaseOrderManagement_Title = New System.Windows.Forms.Label()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPurchaseOrders = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlStatus.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.White
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 745)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1336, 37)
        Me.pnlStatus.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(57, 22)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.Panel3)
        Me.pnlHeader.Controls.Add(Me.lblPurchaseOrderManagement_Title)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1336, 70)
        Me.pnlHeader.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(265, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 460)
        Me.Panel3.TabIndex = 3
        '
        'lblPurchaseOrderManagement_Title
        '
        Me.lblPurchaseOrderManagement_Title.AutoSize = True
        Me.lblPurchaseOrderManagement_Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaseOrderManagement_Title.Location = New System.Drawing.Point(15, 22)
        Me.lblPurchaseOrderManagement_Title.Name = "lblPurchaseOrderManagement_Title"
        Me.lblPurchaseOrderManagement_Title.Size = New System.Drawing.Size(367, 32)
        Me.lblPurchaseOrderManagement_Title.TabIndex = 0
        Me.lblPurchaseOrderManagement_Title.Text = "Purchase Order Management"
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlNavigation.Controls.Add(Me.btnReports)
        Me.pnlNavigation.Controls.Add(Me.btnPurchaseOrders)
        Me.pnlNavigation.Controls.Add(Me.btnItems)
        Me.pnlNavigation.Controls.Add(Me.btnSuppliers)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 70)
        Me.pnlNavigation.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(265, 675)
        Me.pnlNavigation.TabIndex = 2
        '
        'btnReports
        '
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(0, 148)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(265, 53)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnPurchaseOrders
        '
        Me.btnPurchaseOrders.FlatAppearance.BorderSize = 0
        Me.btnPurchaseOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchaseOrders.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseOrders.ForeColor = System.Drawing.Color.White
        Me.btnPurchaseOrders.Location = New System.Drawing.Point(0, 98)
        Me.btnPurchaseOrders.Name = "btnPurchaseOrders"
        Me.btnPurchaseOrders.Size = New System.Drawing.Size(265, 53)
        Me.btnPurchaseOrders.TabIndex = 0
        Me.btnPurchaseOrders.Text = "Purchase Orders"
        Me.btnPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseOrders.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.FlatAppearance.BorderSize = 0
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.Color.White
        Me.btnItems.Location = New System.Drawing.Point(0, 49)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(265, 53)
        Me.btnItems.TabIndex = 0
        Me.btnItems.Text = "Items"
        Me.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSuppliers.FlatAppearance.BorderSize = 0
        Me.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnSuppliers.Location = New System.Drawing.Point(0, 0)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(265, 53)
        Me.btnSuppliers.TabIndex = 0
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.UseVisualStyleBackColor = False
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlContent.Location = New System.Drawing.Point(265, 70)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1071, 675)
        Me.pnlContent.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 782)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlStatus As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents lblPurchaseOrderManagement_Title As Label
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnPurchaseOrders As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlContent As Panel
End Class
