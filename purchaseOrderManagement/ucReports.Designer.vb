<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReports
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
        Me.cmbSupplierReportPo = New System.Windows.Forms.ComboBox()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.txtToDate = New System.Windows.Forms.TextBox()
        Me.txtFromDate = New System.Windows.Forms.TextBox()
        Me.btnReportPreview = New System.Windows.Forms.Button()
        Me.btnClearItems = New System.Windows.Forms.Button()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSupplierReportPo
        '
        Me.cmbSupplierReportPo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbSupplierReportPo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplierReportPo.ForeColor = System.Drawing.Color.Black
        Me.cmbSupplierReportPo.FormattingEnabled = True
        Me.cmbSupplierReportPo.ItemHeight = 25
        Me.cmbSupplierReportPo.Location = New System.Drawing.Point(719, 39)
        Me.cmbSupplierReportPo.Name = "cmbSupplierReportPo"
        Me.cmbSupplierReportPo.Size = New System.Drawing.Size(308, 33)
        Me.cmbSupplierReportPo.TabIndex = 7
        '
        'lblUOM
        '
        Me.lblUOM.AutoSize = True
        Me.lblUOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.lblUOM.Location = New System.Drawing.Point(716, 19)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(60, 17)
        Me.lblUOM.TabIndex = 6
        Me.lblUOM.Text = "Supplier"
        '
        'txtToDate
        '
        Me.txtToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtToDate.ForeColor = System.Drawing.Color.Black
        Me.txtToDate.Location = New System.Drawing.Point(377, 37)
        Me.txtToDate.Multiline = True
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(308, 35)
        Me.txtToDate.TabIndex = 5
        '
        'txtFromDate
        '
        Me.txtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFromDate.ForeColor = System.Drawing.Color.Black
        Me.txtFromDate.Location = New System.Drawing.Point(33, 37)
        Me.txtFromDate.Multiline = True
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(308, 35)
        Me.txtFromDate.TabIndex = 5
        '
        'btnReportPreview
        '
        Me.btnReportPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnReportPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportPreview.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportPreview.ForeColor = System.Drawing.Color.White
        Me.btnReportPreview.Location = New System.Drawing.Point(33, 89)
        Me.btnReportPreview.Name = "btnReportPreview"
        Me.btnReportPreview.Size = New System.Drawing.Size(124, 38)
        Me.btnReportPreview.TabIndex = 8
        Me.btnReportPreview.Text = "Preview"
        Me.btnReportPreview.UseVisualStyleBackColor = False
        '
        'btnClearItems
        '
        Me.btnClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearItems.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnClearItems.Location = New System.Drawing.Point(172, 89)
        Me.btnClearItems.Name = "btnClearItems"
        Me.btnClearItems.Size = New System.Drawing.Size(124, 38)
        Me.btnClearItems.TabIndex = 9
        Me.btnClearItems.Text = "Clear"
        Me.btnClearItems.UseVisualStyleBackColor = True
        '
        'btnPrintReport
        '
        Me.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReport.Font = New System.Drawing.Font("Times New Roman", 10.2!)
        Me.btnPrintReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPrintReport.Location = New System.Drawing.Point(172, 89)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(124, 38)
        Me.btnPrintReport.TabIndex = 9
        Me.btnPrintReport.Text = "Print"
        Me.btnPrintReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(377, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvReport.Location = New System.Drawing.Point(0, 154)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.Size = New System.Drawing.Size(1071, 523)
        Me.dgvReport.TabIndex = 10
        '
        'ucReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.btnClearItems)
        Me.Controls.Add(Me.btnReportPreview)
        Me.Controls.Add(Me.cmbSupplierReportPo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUOM)
        Me.Controls.Add(Me.txtFromDate)
        Me.Controls.Add(Me.txtToDate)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ucReports"
        Me.Size = New System.Drawing.Size(1071, 677)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbSupplierReportPo As ComboBox
    Friend WithEvents lblUOM As Label
    Friend WithEvents txtToDate As TextBox
    Friend WithEvents txtFromDate As TextBox
    Friend WithEvents btnReportPreview As Button
    Friend WithEvents btnClearItems As Button
    Friend WithEvents btnPrintReport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvReport As DataGridView
End Class
