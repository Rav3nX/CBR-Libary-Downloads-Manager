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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TabFunctions.TAB_OpenNewTabedForm(Me, LibaryViewer)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        TabFunctions.TAB_OpenNewTabedForm(Me, New FolderCreator)
    End Sub
End Class