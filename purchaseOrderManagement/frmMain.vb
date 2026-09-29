Public Class frmMain

    Private suppliers As New ucSuppliers()
    Private Items As New ucItems()
    Private purchaseOrders As New ucPurchaseOrders()

    Private reports As New ucReports()



    Public Sub LoadScreen(screen As UserControl)

        pnlContent.Controls.Clear()

        screen.Dock = DockStyle.Fill

        pnlContent.Controls.Add(screen)


    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        modStatus.StatusLabel = lblStatus



        LoadScreen(suppliers)

    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click

        LoadScreen(suppliers)

    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click

        LoadScreen(Items)

    End Sub


    Private Sub btnPurchaseOrders_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrders.Click
        purchaseOrders.RefreshGrid()
        LoadScreen(purchaseOrders)

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        LoadScreen(reports)

    End Sub



End Class



