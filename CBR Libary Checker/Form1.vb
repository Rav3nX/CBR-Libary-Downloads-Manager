Option Strict On
Imports System.Runtime.CompilerServices
Imports System.Threading



Public Class Form1

    Private FilesTread As Thread
    Private LibaryThread As Thread
    Private CopyThread As Thread
    Private HideDupes As Boolean = True


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LibaryList.DefaultCellStyle = FileList.DefaultCellStyle
        LibaryList.AlternatingRowsDefaultCellStyle = FileList.AlternatingRowsDefaultCellStyle

        Dim Favorites() As String = Split(My.Settings.Favorites, ";")
        For Each FavSingle As String In Favorites
            ListBox1.Items.Add(FavSingle)
        Next

    End Sub

    Private Sub LoadSource_Click(sender As Object, e As EventArgs) Handles LoadSource_Button.Click


        status.Text = " LOADING FILES FROM SOURCE.....Please Wait...."
        FilesTread = New Thread(AddressOf LoadSourceFiles)
        FilesTread.IsBackground = True
        FilesTread.Start()

    End Sub

    Private Sub LoadSourceFiles()
        Try
            Dim directory As String = SourcePath_TextBox.Text
            SourceLibary_ProgressBar.Value = 0

            Dim Source_FileNames() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
            SourceLibary_ProgressBar.Maximum = Source_FileNames.Count
            Dim cnt As Integer

            For Each filename As String In Source_FileNames
                cnt += 1
                SourceLibary_ProgressBar.Value = cnt
                Dim FirstCharacter As Integer = filename.IndexOf(".unwanted")
                Dim hide As Boolean = False

                If My.Settings.HideUnwanted And Not (FirstCharacter = -1) Then
                    hide = True
                End If
                If IO.Path.GetExtension(filename) = ".!qB" Then
                    hide = True
                End If
                If IO.Path.GetExtension(filename) = ".!ut" Then
                    hide = True
                End If
                Try
                    If Not hide Then
                        Dim filedate As Date = IO.File.GetCreationTime(filename)
                        ' Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(filename)
                        Dim filesize As Double = FileLen(filename)
                        Dim filesizestr As String = Math.Round(filesize / 1000000, 3) & " Mb"

                        If Not (hide) Then
                            FileList.Rows.Add(filename, IO.Path.GetFileName(filename), IO.Path.GetExtension(filename), hide, IO.Path.GetDirectoryName(filename), filedate.ToString("dd-MMM-yyyy"), filesizestr)
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next
            status.Text = "Loaded " & Source_FileNames.Count & " Files from " & directory

        Catch ex As Exception
            MsgBox("Error! : " & ex.Message)
        End Try
    End Sub

    Private Sub LoadLibary_Button_Click(sender As Object, e As EventArgs) Handles LoadLibary_Button.Click
        LibaryThread = New Thread(AddressOf LoadLibary)
        LibaryThread.IsBackground = True
        LibaryThread.Start()
    End Sub

    Private Sub LoadLibary()
        Dim directory As String = LibaryRootPath_TextBox.Text
        status.Text = "Searching...."
        Dim libstr() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
        MainLibary_ProgressBar.Maximum = libstr.Count
        Dim cnt As Integer
        For Each filename As String In libstr
            cnt += 1
            MainLibary_ProgressBar.Value = cnt

            Try
                Dim filesize As Double = FileLen(filename)
                Dim filesizestr As String = Math.Round(filesize / 1000000, 3) & " Mb"
                LibaryList.Rows.Add(filename, IO.Path.GetFileName(filename), IO.Path.GetExtension(filename), IO.Path.GetDirectoryName(filename), filesizestr)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub CheckDuplicate_Click(sender As Object, e As EventArgs) Handles CheckDuplicate_Button.Click
        For Each row As DataGridViewRow In FileList.Rows
            Dim filename = row.Cells.Item(1).Value.ToString
            For Each libaryrow As DataGridViewRow In LibaryList.Rows
                Dim libfilename = libaryrow.Cells.Item(1).Value.ToString
                'Console.WriteLine(filename & " - " & libfilename)
                If filename = libfilename Then
                    row.Cells.Item(7).Value = "IN LIBARY"
                End If
            Next

        Next

    End Sub

    Private Sub CopySelected_Click(sender As Object, e As EventArgs) Handles CopySelected.Click
        CopyThread = New Thread(AddressOf CopyWork)
        CopyThread.IsBackground = True
        CopyThread.Start()
    End Sub
    Private Sub CopyWork()
        Copy_ProgressBar.Maximum = FileList.SelectedRows.Count
        Dim cnt As Integer
        For Each row As DataGridViewRow In FileList.SelectedRows
            cnt += 1
            Copy_ProgressBar.Value = cnt

            'MsgBox(row.Cells.Item("FullFileName").Value.ToString)
            Dim srcfilename As String = row.Cells.Item("filename").Value.ToString
            Dim srcfullfilename As String = row.Cells.Item("FullFileName").Value.ToString


            Dim destfilename As String = UnsortedFolderTextBox.Text & "\" & srcfilename
            Try
                My.Computer.FileSystem.CopyFile(srcfullfilename, destfilename, FileIO.UIOption.AllDialogs)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            row.Cells.Item(7).Value = "COPIED"

            'MsgBox(destfilename)
        Next
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Options_Panel.Paint
        FileList.DefaultCellStyle.Font = My.Settings.DGVFont
        LibaryList.DefaultCellStyle.Font = My.Settings.DGVFont

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Set_Font_Button.Click
        Dim FntSel As New FontDialog
        If FntSel.ShowDialog = DialogResult.OK Then
            My.Settings.DGVFont = FntSel.Font
            FileList.DefaultCellStyle.Font = My.Settings.DGVFont
            LibaryList.DefaultCellStyle.Font = My.Settings.DGVFont
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ListBox1.Items.Add(SourcePath_TextBox.Text)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Not (IsNothing(ListBox1.SelectedItem)) Then
            SourcePath_TextBox.Text = ListBox1.SelectedItem.ToString
        End If



    End Sub



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim favstr As String = ""

        For item As Integer = 0 To ListBox1.Items.Count - 2
            favstr = ListBox1.Items(item).ToString & ";" & favstr
        Next
        favstr = favstr & ListBox1.Items(ListBox1.Items.Count - 1).ToString

        My.Settings.Favorites = favstr
    End Sub



    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

#Region "Folder Browser Dialogs and Link Labels"

    Private Sub Source_Browse_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Source_Browse_LL.LinkClicked
        Dim Fldlg As New FolderBrowserDialog
        If Fldlg.ShowDialog = vbOK Then
            SourcePath_TextBox.Text = Fldlg.SelectedPath
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LibaryPathBRSR_LinkLabel.LinkClicked
        Dim Fldlg As New FolderBrowserDialog
        If Fldlg.ShowDialog = vbOK Then
            LibaryRootPath_TextBox.Text = Fldlg.SelectedPath
        End If
    End Sub

    Private Sub UnsortedPathBRSR_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UnsortedPathBRSR_LinkLabel.LinkClicked
        Dim Fldlg As New FolderBrowserDialog
        If Fldlg.ShowDialog = vbOK Then
            UnsortedFolderTextBox.Text = Fldlg.SelectedPath
        End If
    End Sub

#End Region


    Private Sub OpenDest_ToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenDest_ToolStripButton.Click
        If LibaryList.SelectedRows.Count > 0 Then
            Process.Start(LibaryList.SelectedRows.Item(0).Cells.Item("LibaryFilePath").Value.ToString)
        End If
    End Sub

    Private Sub OpenSource_Libary_Click(sender As Object, e As EventArgs) Handles OpenSource_Libary.Click
        If FileList.SelectedRows.Count > 0 Then
            Process.Start(FileList.SelectedRows.Item(0).Cells.Item("FilePath").Value.ToString)
        End If
    End Sub


#Region "Source View Menu Items"
    Private Sub HideDupes_Click(sender As Object, e As EventArgs) Handles HideDupes_CHKButton.Click
        If HideDupes_CHKButton.Checked Then
            For Each row As DataGridViewRow In FileList.Rows
                If Not (IsDBNull(row.Cells("InLibary").Value)) Then
                    If row.Cells("InLibary").Value.ToString = "IN LIBARY" Then
                        row.Visible = False
                    End If
                End If

            Next
        Else
            For Each row As DataGridViewRow In FileList.Rows
                row.Visible = True
            Next
        End If
    End Sub

    Private Sub FullFilePathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullFilePathToolStripMenuItem.Click
        FilePath.Visible = FullFilePathToolStripMenuItem.Checked

    End Sub

    Private Sub FileNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileNameToolStripMenuItem.Click
        FileName.Visible = FileNameToolStripMenuItem.Checked

    End Sub

    Private Sub FileTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileTypeToolStripMenuItem.Click
        Type.Visible = FileTypeToolStripMenuItem.Checked

    End Sub

    Private Sub UnwantedQtorrentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnwantedQtorrentToolStripMenuItem.Click

    End Sub

    Private Sub FolderPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderPathToolStripMenuItem.Click

    End Sub

    Private Sub DateCreatedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateCreatedToolStripMenuItem.Click

    End Sub

    Private Sub FileSizeMbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileSizeMbToolStripMenuItem.Click

    End Sub

    Private Sub InLibaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InLibaryToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton2.Click

    End Sub

    Private Sub TopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopToolStripMenuItem.Click
        If TopToolStripMenuItem.Checked Then
            LeftToolStripMenuItem.Checked = False
            RightToolStripMenuItem.Checked = False
            Options_Dock()
        End If
    End Sub
    Private Sub Options_Dock()
        If TopToolStripMenuItem.Checked Then
            Options_Panel.Dock = DockStyle.Top
            Options_Panel.Height = 300

        ElseIf LeftToolStripMenuItem.Checked Then
            Options_Panel.Dock = DockStyle.Left
        ElseIf RightToolStripMenuItem.Checked Then
            Options_Panel.Dock = DockStyle.Right

        End If
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        If LeftToolStripMenuItem.Checked Then
            RightToolStripMenuItem.Checked = False
            TopToolStripMenuItem.Checked = False
            Options_Dock()
        End If
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        If RightToolStripMenuItem.Checked Then
            LeftToolStripMenuItem.Checked = False
            TopToolStripMenuItem.Checked = False
            Options_Dock()
        End If
    End Sub




#End Region


End Class
