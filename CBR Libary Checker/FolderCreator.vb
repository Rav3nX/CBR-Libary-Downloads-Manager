Imports System.ComponentModel
Imports System.IO


Public Class FolderCreator

    Private WithEvents LoadLibrary_BackgroundWorker As New BackgroundWorker
    Private WithEvents TreeViewFiller_BackgroundWorker As New BackgroundWorker
    Private LibrartFetchedRows As New List(Of ComicInfoDB.LIBARY_DBRow)
    Private LibraryLoaded As Boolean = False

    Private DragMode As String = "MOVE"
    Private FromDrag As Boolean = False
    Private XFER_Mode As String = Nothing
    Private PromptForFolder As Boolean = False

    Private WithEvents XFER_BackgroundWorker As New BackgroundWorker
    Private XFER_Destination As DirectoryInfo = Nothing
    Private FilesToXFER_RowCollection As DataGridViewSelectedRowCollection

    Public Sub New()

        InitializeComponent()
        LoadLibrary_BackgroundWorker.WorkerReportsProgress = True
        LoadLibrary_BackgroundWorker.WorkerSupportsCancellation = False
        XFER_BackgroundWorker.WorkerReportsProgress = True
        XFER_BackgroundWorker.WorkerSupportsCancellation = True
        LibraryList_DGV.DefaultCellStyle.Font = My.Settings.DGVFont

        For Each column As DataGridViewColumn In LibraryList_DGV.Columns
            column.MinimumWidth = 80
        Next

    End Sub


    Private Sub FolderCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Text = "Loading Folders List...."
        TreeViewFiller_BackgroundWorker.RunWorkerAsync()
    End Sub


#Region "Library COLLECTION Tree Node Section"

    Private TreeView_Nodes_Collection As New List(Of TreeNode)

    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode
        Dim info As New DirectoryInfo(My.Settings.LibaryFolder)
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.ImageKey = "bluefolder"
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)


            TreeView1.Nodes.Add(rootNode)

        End If

    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)
        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs
            Try
                aNode = New TreeNode(subDir.Name, 0, 0)
                aNode.Tag = subDir
                aNode.ImageKey = "bluefolder"
                aNode.SelectedImageKey = "redfolder"
                subSubDirs = subDir.GetDirectories()
                If subSubDirs.Length <> 0 Then
                    GetDirectories(subSubDirs, aNode)
                End If
                nodeToAddTo.Nodes.Add(aNode)
            Catch ex As Exception
            End Try
        Next subDir
    End Sub


    Private Sub LoadTreeView_BGW(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles TreeViewFiller_BackgroundWorker.DoWork

        Dim rootNode As TreeNode
        Dim info As New DirectoryInfo(My.Settings.LibaryFolder)
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            TreeView_Nodes_Collection.Add(rootNode)
        End If
    End Sub
    Private Sub LoadTreeView_BGW_RunWorkCompleated(sender As System.Object, e As RunWorkerCompletedEventArgs) Handles TreeViewFiller_BackgroundWorker.RunWorkerCompleted
        TreeView1.Nodes.Clear()
        For Each treenode As TreeNode In TreeView_Nodes_Collection
            TreeView1.Nodes.Add(treenode)
        Next
        TreeView_Nodes_Collection.Clear()
        TreeView1.Nodes.Item(0).Expand()
        status.Text = "Library folders loaded"
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles RefreshFolderList_Button.Click

        If Not (TreeViewFiller_BackgroundWorker.IsBusy) Then TreeViewFiller_BackgroundWorker.RunWorkerAsync()

    End Sub



    Private Sub NewFolder_Click(sender As Object, e As EventArgs) Handles NewFolder_Button.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            Dim SelectedDirectory As DirectoryInfo = CType(TreeView1.SelectedNode.Tag, DirectoryInfo)
            Dim NewFolderDialog As New NewFolderDialog
            If NewFolderDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim NewfolderString As String = SelectedDirectory.FullName & "\" & NewFolderDialog.NewFolder_Name.Text
                    If (Not System.IO.Directory.Exists(NewfolderString)) Then
                        System.IO.Directory.CreateDirectory(NewfolderString)

                        Dim info As New DirectoryInfo(NewfolderString)
                        Dim new_Subnode As TreeNode
                        new_Subnode = New TreeNode(info.Name)
                        new_Subnode.Tag = info
                        TreeView1.SelectedNode.Nodes.Add(new_Subnode)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub




    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        TreeView1.SelectedNode = e.Node
        If e.Button = MouseButtons.Right Then e.Node.ContextMenuStrip = NodeContextMenuStrip
    End Sub

    Private Sub SetThisFolderAsCopyDestinationToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub OpenFolderInExplorer_Click(sender As Object, e As EventArgs) Handles OpenFolderInExplorerToolStripMenuItem.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            Dim DirInfo As DirectoryInfo = CType(TreeView1.SelectedNode.Tag, DirectoryInfo)
            Process.Start(DirInfo.FullName)
        End If
    End Sub


    Private Sub LoadThisFolderInLibraryList_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles LibrarySettings_Button.Click
        Dim librarySetDialog As New LibaryFolderDialog
        If librarySetDialog.ShowDialog = DialogResult.OK Then
            RefreshFolderList_Button.PerformClick()
        End If
    End Sub




#End Region

#Region "Load Library List"

    Private Sub LoadLibary_Click(sender As Object, e As EventArgs) Handles LoadLibrary_Button.Click
        If Not (LoadLibrary_BackgroundWorker.IsBusy) Then
            ComicInfoDB.Clear()
            LIBARYDBBindingSource.SuspendBinding()
            LoadLibrary_BackgroundWorker.RunWorkerAsync()
            LibraryList_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
    End Sub

    Private Sub LoadLirbary_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadLibrary_BackgroundWorker.ProgressChanged
        Dim ProgressReport As New ProgressReport
        ProgressReport = CType(e.UserState, ProgressReport)
        Select Case ProgressReport.ReportType
            Case "start"
                MainLibrary_ProgressBar.Maximum = ProgressReport.Max
                MainLibrary_ProgressBar.Minimum = ProgressReport.Min
                MainLibrary_ProgressBar.Value = ProgressReport.Current
                status.Text = ProgressReport.TextMessage
                'SourceLibary_ProgressBar.Value = e.ProgressPercentage
            Case "update"
                MainLibrary_ProgressBar.Value = ProgressReport.Current
                status.Text = ProgressReport.TextMessage
            Case "finish"
                status.Text = ProgressReport.TextMessage
                MainLibrary_ProgressBar.Value = 0
        End Select
    End Sub

    Private Sub LoadLibrary_RunWorkCompleated(sender As System.Object, e As RunWorkerCompletedEventArgs) Handles LoadLibrary_BackgroundWorker.RunWorkerCompleted
        For Each row As DataRow In LibrartFetchedRows
            ComicInfoDB.LIBARY_DB.Rows.Add(row)
        Next
        LIBARYDBBindingSource.ResumeBinding()
        LibraryList_DGV.Visible = False
        LibraryList_DGV.Visible = True
        LibraryLoaded = True
        LibraryList_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LibraryList_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
    End Sub

    Private Sub LoadLibraryFiles(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles LoadLibrary_BackgroundWorker.DoWork

        LibrartFetchedRows.Clear()
        Dim ProgressReport As New ProgressReport
        Dim directory As String = My.Settings.LibaryFolder
        Dim Library_FileNames() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
        Dim cnt As Integer

        ProgressReport.ReportType = "start" ' UPDATE STATUS BAR AND PROGRESS BAR
        ProgressReport.Min = 0
        ProgressReport.Max = Library_FileNames.Count
        ProgressReport.Current = 0
        ProgressReport.TextMessage = "Found " & Library_FileNames.Count & " files....Begining search"
        LoadLibrary_BackgroundWorker.ReportProgress(0, ProgressReport) 'CALL PROGRESSREPOT

        For Each filename As String In Library_FileNames
            cnt += 1

            Try

                Dim filesize As Double = FileLen(filename)
                Dim filesizestr As Double = Math.Round(filesize / 1000000, 3)
                Dim filedate As Date = IO.File.GetCreationTime(filename)

                Dim newrow As ComicInfoDB.LIBARY_DBRow
                newrow = ComicInfoDB.LIBARY_DB.NewRow
                newrow("FileName") = IO.Path.GetFileName(filename)
                newrow("Full File Name") = filename
                newrow("File Type") = IO.Path.GetExtension(filename)
                newrow("File Path") = IO.Path.GetDirectoryName(filename)
                Dim RelPath As String = IO.Path.GetDirectoryName(filename)
                RelPath = RelPath.Remove(0, directory.Length) & "\"
                newrow("Path Rel Root") = RelPath
                newrow("File Size") = filesizestr
                newrow("Date Created") = filedate.ToString("dd-MMM-yyyy")

                LibrartFetchedRows.Add(newrow)
                'ComicInfoDB.LIBARY_DB.Rows.Add(newrow) ' ADD THE ROW TO THE DATASET

                ProgressReport.Current = cnt
                ProgressReport.ReportType = "update"
                ProgressReport.TextMessage = "Loading Main Library Files. Processed " & cnt & " of " & Library_FileNames.Count & " files."
                LoadLibrary_BackgroundWorker.ReportProgress(0, ProgressReport) 'REPORT THE STATUS OF FILE PROCESSING.

            Catch ex As Exception
            End Try
        Next

        ProgressReport.TextMessage = "Loading Library complete. " & Library_FileNames.Count & " Adding found files to list...."
        ProgressReport.ReportType = "finish"
        LoadLibrary_BackgroundWorker.ReportProgress(0, ProgressReport)
        LibraryLoaded = True
    End Sub
#End Region

#Region "Copy Files Region"



    Private Sub XFERFiles_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles XFER_BackgroundWorker.ProgressChanged
        Dim ProgressReport As New ProgressReport
        ProgressReport = CType(e.UserState, ProgressReport)
        Select Case ProgressReport.ReportType
            Case "start"
                MainLibrary_ProgressBar.Maximum = ProgressReport.Max
                MainLibrary_ProgressBar.Minimum = ProgressReport.Min
                MainLibrary_ProgressBar.Value = ProgressReport.Current
                status.Text = ProgressReport.TextMessage
                'SourceLibary_ProgressBar.Value = e.ProgressPercentage
            Case "update"
                MainLibrary_ProgressBar.Value = ProgressReport.Current
                status.Text = ProgressReport.TextMessage
            Case "finish"
                status.Text = ProgressReport.TextMessage
                MainLibrary_ProgressBar.Value = 0
        End Select
    End Sub

    Private Sub XFERFiles_RunWorkerCompleted(sender As System.Object, e As RunWorkerCompletedEventArgs) Handles XFER_BackgroundWorker.RunWorkerCompleted

    End Sub

    Private Sub XFERFiles_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles XFER_BackgroundWorker.DoWork

        Dim ProgressReport As New ProgressReport
        ProgressReport.ReportType = "start"
        ProgressReport.Min = 0
        ProgressReport.Max = FilesToXFER_RowCollection.Count 'SourceLibary_DGV.SelectedRows.Count
        ProgressReport.Current = 0
        ProgressReport.TextMessage = "Found " & LibraryList_DGV.SelectedRows.Count & " files....Begining copy operation..."
        XFER_BackgroundWorker.ReportProgress(0, ProgressReport)

        Dim cnt As Integer
        For Each row As DataGridViewRow In FilesToXFER_RowCollection 'SourceLibary_DGV.SelectedRows

            cnt += 1

            Dim srcfilename As String = row.Cells.Item("FileName").Value.ToString
            Dim srcfullfilename As String = row.Cells.Item("FullFileNameDataGridViewTextBoxColumn").Value.ToString
            Dim destfilename As String = XFER_Destination.FullName & "\" & srcfilename
            ProgressReport.Current = cnt
            ProgressReport.ReportType = "update"
            ProgressReport.TextMessage = cnt & " Files of " & FilesToXFER_RowCollection.Count & " copied. Current File: " & srcfilename
            XFER_BackgroundWorker.ReportProgress(0, ProgressReport)

            Try
                Dim mode As String = Nothing
                If FromDrag Then
                    mode = DragMode
                Else
                    mode = XFER_Mode
                End If
                If mode = "MOVE" Then
                    My.Computer.FileSystem.MoveFile(srcfullfilename, destfilename)
                    row.Cells.Item("CopyStatusDataGridViewTextBoxColumn").Value = "MOVED"
                ElseIf mode = "COPY" Then
                    My.Computer.FileSystem.CopyFile(srcfullfilename, destfilename)
                    row.Cells.Item("CopyStatusDataGridViewTextBoxColumn").Value = "COPIED"
                End If


            Catch ex As Exception
                row.Cells.Item("CopyStatusDataGridViewTextBoxColumn").Value = "FAILED"
                MsgBox(ex.Message)
            End Try

        Next
        ProgressReport.Current = cnt
        ProgressReport.ReportType = "finish"
        ProgressReport.TextMessage = cnt & " Copy Complete. " & cnt & " Files copied to " & XFER_Destination.FullName
        XFER_BackgroundWorker.ReportProgress(0, ProgressReport)


    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode IsNot Nothing Then
            Dim DirInfo As DirectoryInfo = TryCast(e.Node.Tag, DirectoryInfo)
            If DirInfo IsNot Nothing Then
                FileDestination_Label.Text = DirInfo.FullName
                XFER_Destination = DirInfo
            Else
                XFER_Destination = Nothing
            End If
        End If
    End Sub

    Private Sub EnableDragging_Button_Click(sender As Object, e As EventArgs) Handles EnableDragging_Button.Click

    End Sub


#End Region


#Region " XFER start Region"

#Region "Setup"

    Private Function GetConfirmation(filecount As Integer) As MsgBoxResult
        Return MsgBox("Are you sure you wish to copy these " & filecount & " Comics to the folder : " & vbLf & XFER_Destination.FullName, MsgBoxStyle.YesNo)
    End Function

    Private Sub GetDestination()
        If TreeView1.SelectedNode IsNot Nothing Then
            If PromptForFolder Then
                Dim SelectedDirectory As DirectoryInfo = CType(TreeView1.SelectedNode.Tag, DirectoryInfo)
                Dim NewFolderDialog As New NewFolderDialog
                If NewFolderDialog.ShowDialog() = DialogResult.OK Then
                    Try
                        Dim NewfolderString As String = SelectedDirectory.FullName & "\" & NewFolderDialog.NewFolder_Name.Text
                        If (Not System.IO.Directory.Exists(NewfolderString)) Then
                            System.IO.Directory.CreateDirectory(NewfolderString) 'Make new Dir
                            Dim info As New DirectoryInfo(NewfolderString)
                            Dim new_Subnode As TreeNode
                            new_Subnode = New TreeNode(info.Name)
                            new_Subnode.Tag = info
                            TreeView1.SelectedNode.Nodes.Add(new_Subnode)
                            XFER_Destination = info
                        End If
                    Catch ex As Exception
                        MsgBox("Something went wrong!" & vbLf & ex.Message)
                        XFER_Destination = Nothing
                    End Try
                End If
            Else
                Try
                    XFER_Destination = TryCast(TreeView1.SelectedNode.Tag, DirectoryInfo)
                Catch ex As Exception
                    XFER_Destination = Nothing
                    MsgBox("Something went wrong!" & vbLf & ex.Message)
                End Try
            End If
        End If

    End Sub

#End Region

    Private Sub StartXfer(ByRef rows As DataGridViewSelectedRowCollection)
        If XFER_Destination IsNot Nothing And rows IsNot Nothing Then
            If Not (XFER_BackgroundWorker.IsBusy) Then
                FilesToXFER_RowCollection = rows
                XFER_BackgroundWorker.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Click ' MENU MOVE SELECTED TO NEW FOLDER
        XFER_Mode = "MOVE"
        PromptForFolder = True
        GetDestination()
        FromDrag = False
        StartXfer(LibraryList_DGV.SelectedRows)
    End Sub

    Private Sub CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Click 'MENU COPY SELECTED TO NEW FOLDER
        XFER_Mode = "COPY"
        PromptForFolder = True
        GetDestination()
        FromDrag = False
        StartXfer(LibraryList_DGV.SelectedRows)
    End Sub

    Private Sub MoveSelectedFilesToSelectedFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveSelectedFilesToSelectedFolderToolStripMenuItem.Click ' MENU MOVE SELECTED TO SELECTED FOLDER
        XFER_Mode = "MOVE"
        PromptForFolder = False
        GetDestination()
        FromDrag = False
        StartXfer(LibraryList_DGV.SelectedRows)
    End Sub

    Private Sub CopySelected_Click(sender As Object, e As EventArgs) Handles CopySelected_Button.Click 'MENU COPY SELECTED TO SELECTED FOLDER
        XFER_Mode = "COPY"
        PromptForFolder = False
        GetDestination()
        FromDrag = False
        StartXfer(LibraryList_DGV.SelectedRows)
    End Sub

    Private Sub TreeView1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragDrop ' DROPPED FILE(S) ONTO TREEVIEW 1
        Dim pt As New Point(e.X, e.Y)
        pt = TreeView1.PointToClient(pt)
        Dim node As TreeNode = TreeView1.GetNodeAt(pt)
        If TypeOf e.Data Is DataObject Then ' CHECKS IT IS A DATA OBJECT
            Dim rows As DataGridViewSelectedRowCollection = TryCast(e.Data.GetData(GetType(DataGridViewSelectedRowCollection)), DataGridViewSelectedRowCollection) ' GET THE COLLECTION
            Dim DirInfo As DirectoryInfo = CType(node.Tag, DirectoryInfo)                                                                                                   'GET THE DESTINATION FOLDER
            FromDrag = True

            GetDestination()
            If GetConfirmation(rows.Count) = MsgBoxResult.Yes Then
                StartXfer(rows)
            End If
        End If
    End Sub

#End Region



#Region "Drag and Drop"

    Private Sub SourceLibary_DGV_MouseDown(sender As Object, e As MouseEventArgs) Handles LibraryList_DGV.MouseDown
        If My.Computer.Keyboard.CtrlKeyDown Or EnableDragging_Button.Checked Then
            Dim rows As DataGridViewSelectedRowCollection = Me.LibraryList_DGV.SelectedRows
            Me.LibraryList_DGV.DoDragDrop(rows, DragDropEffects.Copy)
        End If
    End Sub
    Private Sub TreeView1_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragOver
        e.Effect = DragDropEffects.Copy
        Dim pt As New Point(e.X, e.Y)
        pt = TreeView1.PointToClient(pt)
        Dim node As TreeNode = TreeView1.GetNodeAt(pt)
        If Not node Is Nothing Then
            e.Effect = DragDropEffects.Copy
            TreeView1.SelectedNode = node
        End If
    End Sub


    Private Sub DragMode_Move_Button_Click(sender As Object, e As EventArgs) Handles DragMode_Move_Button.Click

        DragMode = "MOVE"
        DragMode_Move_Button.Checked = True
        DragMode_Copy_Button.Checked = False
        UpdateDragLabel()
    End Sub

    Private Sub DragMode_Copy_Button_Click(sender As Object, e As EventArgs) Handles DragMode_Copy_Button.Click

        DragMode = "COPY"
        DragMode_Move_Button.Checked = False
        DragMode_Copy_Button.Checked = True
        UpdateDragLabel()
    End Sub




    Private Sub DragMode_NewFolder_Button_Click(sender As Object, e As EventArgs) Handles DragMode_NewFolder_Button.Click

        PromptForFolder = DragMode_NewFolder_Button.Checked
        UpdateDragLabel()
    End Sub
    Private modeSwitch As Integer = 0

    Private Sub FolderCreator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F2 Then ' Toddle Drag Enabled
            EnableDragging_Button.Checked = Not EnableDragging_Button.Checked

        End If

        If e.KeyCode = Keys.F4 Then
            modeSwitch += 1
            If modeSwitch = 4 Then modeSwitch = 0

            Select Case modeSwitch
                Case 0
                    DragMode = "COPY"
                    'XFER_Mode = "COPY"
                    PromptForFolder = False
                Case 1
                    DragMode = "COPY"
                    ' XFER_Mode = "COPY"
                    PromptForFolder = True
                Case 2
                    DragMode = "MOVE"
                    ' XFER_Mode = "MOVE"
                    PromptForFolder = False
                Case 3
                    DragMode = "MOVE"
                    'XFER_Mode = "MOVE"
                    PromptForFolder = True

            End Select

            UpdateDragLabel()

        End If
    End Sub

    Private Sub UpdateDragLabel()
        Dim str As String
        str = "(F4 to Toggle) Drag Mode: " & DragMode
        If PromptForFolder Then str = str & " - New Folder"
        DragMode_Label.Text = str
    End Sub

    Private Sub EnableDragging_Button_CheckStateChanged(sender As Object, e As EventArgs) Handles EnableDragging_Button.CheckStateChanged
        If EnableDragging_Button.Checked Then
            DragEnabled_Label.Text = "Dragging Enabled"
            DragEnabled_Label.ForeColor = Color.Red

        Else
            DragEnabled_Label.Text = "Dragging Disabled."
            DragEnabled_Label.ForeColor = Color.Green
        End If
    End Sub

    Private Sub DeleteSelectedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedItemsToolStripMenuItem.Click
        If MsgBox("Are you SURE you wish to delete these " & LibraryList_DGV.SelectedRows.Count & " items?", vbYesNo) = vbYes Then
            For Each row As DataGridViewRow In LibraryList_DGV.SelectedRows
                My.Computer.FileSystem.DeleteFile(row.Cells.Item("FullFileNameDataGridViewTextBoxColumn").Value.ToString, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                row.Cells.Item("CopyStatusDataGridViewTextBoxColumn").Value = "DELETED"
            Next
        End If
    End Sub




#End Region




End Class