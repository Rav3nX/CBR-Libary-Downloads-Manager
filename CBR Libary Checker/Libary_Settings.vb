Public Class Libary_Settings
    Private Sub LibaryRoot_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LibaryRoot_LinkLabel.LinkClicked

        Using Fldlg As New FolderBrowserDialog
            Fldlg.RootFolder = Environment.SpecialFolder.Desktop
            Fldlg.SelectedPath = LibaryRootPath_TextBox.Text
            If Fldlg.ShowDialog = vbOK Then
                LibaryRootPath_TextBox.Text = Fldlg.SelectedPath
            End If
        End Using
    End Sub

    Private Sub closetab_Click(sender As Object, e As EventArgs) Handles closetab.Click
        TabFunctions.CloseME(Me)
    End Sub
End Class