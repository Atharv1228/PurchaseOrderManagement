Imports System.Data

Public Class ucReports

    Private objPO As New clsPurchaseOrders()
    Private objSuppliers As New clsSuppliers()
    Private dtReport As New DataTable()

    Private Sub ucReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplierFilter()
    End Sub

    ''' <summary>Fills the supplier filter combo with all suppliers plus an "All Suppliers" option.</summary>
    Private Sub LoadSupplierFilter()
        Dim dt As DataTable = objSuppliers.GetAllSuppliers()

        ' Add an "All Suppliers" row at the top with SupplierID = 0
        Dim allRow As DataRow = dt.NewRow()
        allRow("SupplierID") = 0
        allRow("Name") = "All Suppliers"
        dt.Rows.InsertAt(allRow, 0)

        cmbSupplierReportPo.DataSource = dt
        cmbSupplierReportPo.DisplayMember = "Name"
        cmbSupplierReportPo.ValueMember = "SupplierID"
        cmbSupplierReportPo.SelectedIndex = 0
    End Sub

    ''' <summary>Pulls the report data for the chosen date range/supplier into dgvReport.</summary>
    Private Sub btnReportPreview_Click(sender As Object, e As EventArgs) Handles btnReportPreview.Click
        Dim fromDate, toDate As Date

        If Not Date.TryParse(txtFromDate.Text, fromDate) OrElse Not Date.TryParse(txtToDate.Text, toDate) Then
            MessageBox.Show("Please enter valid From and To dates.")
            Return
        End If

        Dim supplierID As Integer = CInt(cmbSupplierReportPo.SelectedValue)

        dtReport = objPO.GetReportData(fromDate, toDate, supplierID)
        dgvReport.DataSource = dtReport

        modStatus.SetStatus(dtReport.Rows.Count & " line item(s) found.")
    End Sub

    ''' <summary>Lets the user choose where to save, then exports the last preview as a PDF.</summary>
    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        If dtReport.Rows.Count = 0 Then
            MessageBox.Show("Click Preview first to load a report.")
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "PDF Files|*.pdf"
            sfd.FileName = "PO_Report_" & Date.Today.ToString("yyyyMMdd") & ".pdf"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim objReport As New clsReportHelper()
                objReport.ExportReportToPDF(dtReport, sfd.FileName)
                modStatus.SetStatus("Report saved as PDF.")
            End If
        End Using
    End Sub

End Class
