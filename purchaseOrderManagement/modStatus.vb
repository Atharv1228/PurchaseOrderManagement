Imports System.Windows.Forms


''' Lets any screen (UserControl) write a message to frmMain's status label
''' without needing a direct reference to frmMain.
''' frmMain sets StatusLabel once, in its Load event:
'''     modStatus.StatusLabel = lblStatus

Public Module modStatus

    Public StatusLabel As Label

    ''' Writes a message to the main form's status bar, if one has been set.
    Public Sub SetStatus(message As String)

        If StatusLabel IsNot Nothing Then
            StatusLabel.Text = message
            StatusLabel.Update()
            StatusLabel.Refresh()
            Application.DoEvents()
        End If

    End Sub

End Module
