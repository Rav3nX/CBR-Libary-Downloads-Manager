Imports System.IO

Public Class LibaryViewer

    Public Sub New()
        InitializeComponent()
        PopulateTreeView()

    End Sub 'New

    Private Sub LibaryViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        For i As Integer = 1 To 100
            LibaryPlane.Controls.Add(New LibaryItem)

        Next
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub
    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode

        Dim info As New DirectoryInfo(My.Settings.LibaryFolder)
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            TreeView1.Nodes.Add(rootNode)
        End If

    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo,
        ByVal nodeToAddTo As TreeNode)

        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs
            Try
                aNode = New TreeNode(subDir.Name, 0, 0)
                aNode.Tag = subDir
                aNode.ImageKey = "folder"
                subSubDirs = subDir.GetDirectories()
                If subSubDirs.Length <> 0 Then
                    GetDirectories(subSubDirs, aNode)
                End If
                nodeToAddTo.Nodes.Add(aNode)
            Catch ex As Exception
            End Try

        Next subDir

    End Sub
    Private Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick

        Dim newSelected As TreeNode = e.Node
        ListView1.Items.Clear()
        Dim nodeDirInfo As DirectoryInfo = CType(newSelected.Tag, DirectoryInfo)
        Dim subItems() As ListViewItem.ListViewSubItem
        Dim item As ListViewItem = Nothing

        Dim dir As DirectoryInfo
        For Each dir In nodeDirInfo.GetDirectories()
            item = New ListViewItem(dir.Name, 0)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "Directory"),
                New ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next dir

        Dim file As FileInfo
        For Each file In nodeDirInfo.GetFiles() ' List view items
            item = New ListViewItem(file.Name, 1)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "File"),
                New ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next file
        LibaryPlane.Controls.Clear()

        For Each file In nodeDirInfo.GetFiles() ' comic info items
            Dim new_item As New LibaryItem
            new_item.Label1.Text = file.Name
            LibaryPlane.Controls.Add(new_item)

        Next file

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Sub TreeView1_AfterSelect_1(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class