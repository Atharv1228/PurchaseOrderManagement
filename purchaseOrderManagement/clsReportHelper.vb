Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel

''' <summary>
''' Builds the PO report and saves it as a PDF.
''' Reuses Excel Interop - Excel can export any worksheet straight to PDF,
''' so we don't need a separate PDF library.
''' </summary>
Public Class clsReportHelper

    Public Sub ExportReportToPDF(reportData As DataTable, savePath As String)

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim sheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        Try
            sheet.Cells(1, 1) = "Purchase Order Report"

            ' Write column headers in bold
            For col As Integer = 0 To reportData.Columns.Count - 1
                sheet.Cells(3, col + 1) = reportData.Columns(col).ColumnName
                CType(sheet.Cells(3, col + 1), Excel.Range).Font.Bold = True
            Next

            ' Write data rows
            For r As Integer = 0 To reportData.Rows.Count - 1
                For c As Integer = 0 To reportData.Columns.Count - 1
                    sheet.Cells(r + 4, c + 1) = reportData.Rows(r)(c).ToString()
                Next
            Next

            sheet.Columns.AutoFit()

            ' Export the worksheet straight to PDF
            sheet.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, savePath)

        Finally
            workbook.Close(False)
            excelApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub

End Class
