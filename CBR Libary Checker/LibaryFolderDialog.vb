Public Class LibaryFolderDialog
    Private Sub Browse_Button_Click(sender As Object, e As EventArgs) Handles Browse_Button.Click
        Using Fldlg As New FolderBrowserDialog
            Fldlg.RootFolder = Environment.SpecialFolder.Desktop
            Fldlg.SelectedPath = LibraryRootPATH_TextBox.Text
            If Fldlg.ShowDialog = vbOK Then
                LibraryRootPATH_TextBox.Text = Fldlg.SelectedPath
            End If
        End Using
    End Sub

    Private Sub Set_Button_Click(sender As Object, e As EventArgs) Handles Set_Button.Click
        My.Settings.LibaryFolder = LibraryRootPATH_TextBox.Text
        Me.DialogResult = vbOK
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = vbOKCancel
    End Sub

    Private Sub LibaryFolderDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LibraryRootPATH_TextBox.Text = My.Settings.LibaryFolder
    End Sub


End Class