Public Class Main
    Private Sub FileManager_Button_Click(sender As Object, e As EventArgs) Handles FileManager_Button.Click
        TabFunctions.TAB_OpenNewTabedForm(Me, New Form1)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub LibarySettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibarySettingsToolStripMenuItem.Click
        TabFunctions.TAB_OpenNewTabedForm(Me, New Libary_Settings)

    End Sub
End Class