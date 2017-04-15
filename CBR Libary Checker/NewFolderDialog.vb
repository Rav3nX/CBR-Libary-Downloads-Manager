Public Class NewFolderDialog
    Private Sub NewFolderDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewFolder_Name.Focus()

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class