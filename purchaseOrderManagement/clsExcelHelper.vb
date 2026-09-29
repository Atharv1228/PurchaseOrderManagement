Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel


''' All Excel Interop work lives here: importing supplier/item lists
''' from a workbook, and exporting a single purchase order to one.
Public Class clsExcelHelper


    ''' Reads a sheet with columns Name | Phone | Email (row 1 = header)
    ''' and returns the rows as a DataTable matching the Suppliers grid.

    Public Function ImportSuppliers(filePath As String) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("SupplierID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Phone", GetType(String))
        dt.Columns.Add("Email", GetType(String))

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open(filePath)

            ' workbook can hold both a "Suppliers" and an "Items" sheet -
            ' find the right one by NAME instead of assuming it's sheet #1.
            sheet = GetSheetByName(workbook, "Suppliers")
            If sheet Is Nothing Then
                Throw New Exception("This workbook has no sheet named 'Suppliers'.")
            End If

            Dim lastRow As Integer = sheet.Cells(sheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row

            For rowIndex As Integer = 2 To lastRow   ' row 1 is the header, skip it
                Dim name As String = CStr(sheet.Cells(rowIndex, 1).Value)
                If String.IsNullOrWhiteSpace(name) Then Continue For

                Dim phone As String = CStr(sheet.Cells(rowIndex, 2).Value)
                Dim email As String = CStr(sheet.Cells(rowIndex, 3).Value)

                dt.Rows.Add(0, name, phone, email)   ' 0 = new row, not yet in the database
            Next

        Finally
            If workbook IsNot Nothing Then workbook.Close(False)
            excelApp.Quit()
            ReleaseObject(sheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try

        Return dt
    End Function

    ''' Reads a sheet with columns Code | Description | UOM | Rate (row 1 = header)
    ''' and returns the rows as a DataTable matching the Items grid.

    Public Function ImportItems(filePath As String) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ItemID", GetType(Integer))
        dt.Columns.Add("ItemCode", GetType(String))
        dt.Columns.Add("Description", GetType(String))
        dt.Columns.Add("UOM", GetType(String))
        dt.Columns.Add("Rate", GetType(Decimal))

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open(filePath)

            ' Look up the "Items" sheet by name (same workbook also has a "Suppliers" sheet).
            sheet = GetSheetByName(workbook, "Items")
            If sheet Is Nothing Then
                Throw New Exception("This workbook has no sheet named 'Items'.")
            End If

            Dim lastRow As Integer = sheet.Cells(sheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row

            For rowIndex As Integer = 2 To lastRow
                Dim code As String = CStr(sheet.Cells(rowIndex, 1).Value)
                If String.IsNullOrWhiteSpace(code) Then Continue For

                Dim description As String = CStr(sheet.Cells(rowIndex, 2).Value)
                Dim uom As String = CStr(sheet.Cells(rowIndex, 3).Value)
                Dim rate As Decimal = Convert.ToDecimal(If(sheet.Cells(rowIndex, 4).Value, 0))

                dt.Rows.Add(0, code, description, uom, rate)
            Next

        Finally
            If workbook IsNot Nothing Then workbook.Close(False)
            excelApp.Quit()
            ReleaseObject(sheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try

        Return dt
    End Function

    ''' Writes one purchase order (header + line items) to a new Excel file at savePath.
    Public Sub ExportPO(poNumber As String, poDate As Date, supplierName As String,
                         deliveryDate As Date, taxPercent As Decimal, totalAmount As Decimal,
                         details As DataTable, savePath As String)

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim sheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        Try
            sheet.Cells(1, 1) = "Purchase Order: " & poNumber
            sheet.Cells(2, 1) = "Date: " & poDate.ToString("dd-MMM-yyyy")
            sheet.Cells(3, 1) = "Supplier: " & supplierName
            sheet.Cells(4, 1) = "Delivery Date: " & deliveryDate.ToString("dd-MMM-yyyy")

            ' Line item header row
            sheet.Cells(6, 1) = "Item"
            sheet.Cells(6, 2) = "UOM"
            sheet.Cells(6, 3) = "Qty"
            sheet.Cells(6, 4) = "Rate"
            sheet.Cells(6, 5) = "Amount"

            Dim r As Integer = 7
            For Each row As DataRow In details.Rows
                sheet.Cells(r, 1) = row("Item").ToString()
                sheet.Cells(r, 2) = row("UOM").ToString()
                sheet.Cells(r, 3) = row("Qty")
                sheet.Cells(r, 4) = row("Rate")
                sheet.Cells(r, 5) = row("Amount")
                r += 1
            Next

            sheet.Cells(r + 1, 4) = "Tax (" & taxPercent & "%)"
            sheet.Cells(r + 2, 4) = "Grand Total"
            sheet.Cells(r + 2, 5) = totalAmount

            workbook.SaveAs(savePath)

        Finally
            workbook.Close(False)
            excelApp.Quit()
            ReleaseObject(sheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try
    End Sub

    ''' <summary>Finds a worksheet by its tab name (e.g. "Suppliers" or "Items"). Returns Nothing if not found.</summary>
    Private Function GetSheetByName(workbook As Excel.Workbook, sheetName As String) As Excel.Worksheet
        For Each s As Excel.Worksheet In workbook.Sheets
            If String.Equals(s.Name, sheetName, StringComparison.OrdinalIgnoreCase) Then
                Return s
            End If
        Next
        Return Nothing
    End Function

    ''' Releases a COM object so Excel doesn't stay running in the background after we're done.
    Private Sub ReleaseObject(obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            End If
        Catch
            ' nothing to do if it's already released
        End Try
    End Sub

End Class
