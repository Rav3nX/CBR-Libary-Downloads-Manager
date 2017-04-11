Imports System.IO

Public Class LibaryViewer
    Private Sub LibaryViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Dir As String In Directory.GetDirectories(My.Settings.LibaryFolder)
            Dim newnode As New TreeNode
            newnode.Name = Dir
            newnode.Text = Dir
            TreeView1.Nodes.Add(newnode)

        Next

        For i As Integer = 1 To 100
            LibaryPlane.Controls.Add(New LibaryItem)

        Next
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class