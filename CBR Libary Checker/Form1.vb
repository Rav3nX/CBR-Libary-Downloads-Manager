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
        HideDupes_Button.Text = "Hide Duplicates in Source List"

        Dim Favorites() As String = Split(My.Settings.Favorites, ";")
        For Each FavSingle As String In Favorites
            ListBox1.Items.Add(FavSingle)
        Next

    End Sub

    Private Sub LoadSource_Click(sender As Object, e As EventArgs) Handles LoadSource_Button.Click

        status.Text = " LOADING FILES FROM SOURCE.....Please Wait...."
        FilesTread = New Thread(AddressOf LoadFiles)
        FilesTread.IsBackground = True
        FilesTread.Start()

    End Sub

    Private Sub LoadFiles()
        Try
            Dim directory As String = SourcePath_TextBox.Text
            ProgressBar1.Value = 0

            Dim Source_FileNames() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
            ProgressBar1.Maximum = Source_FileNames.Count
            Dim cnt As Integer

            For Each filename As String In Source_FileNames
                cnt += 1
                ProgressBar1.Value = cnt
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
        Dim directory As String = LibaryPath.Text
        status.Text = "Searching...."
        Dim libstr() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
        ProgressBar2.Maximum = libstr.Count
        Dim cnt As Integer
        For Each filename As String In libstr
            cnt += 1
            ProgressBar2.Value = cnt

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
        HideDupes_Button.Text = "Hide Duplicates in Source List"
        HideDupes_Button.Enabled = True

    End Sub

    Private Sub CopySelected_Click(sender As Object, e As EventArgs) Handles CopySelected.Click
        CopyThread = New Thread(AddressOf CopyWork)
        CopyThread.IsBackground = True
        CopyThread.Start()
    End Sub
    Private Sub CopyWork()
        ProgressBar3.Maximum = FileList.SelectedRows.Count
        Dim cnt As Integer
        For Each row As DataGridViewRow In FileList.SelectedRows
            cnt += 1
            ProgressBar3.Value = cnt

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        FileList.DefaultCellStyle.Font = My.Settings.DGVFont
        LibaryList.DefaultCellStyle.Font = My.Settings.DGVFont

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FntSel As New FontDialog
        If FntSel.ShowDialog = DialogResult.OK Then
            My.Settings.DGVFont = FntSel.Font
            FileList.DefaultCellStyle.Font = My.Settings.DGVFont
            LibaryList.DefaultCellStyle.Font = My.Settings.DGVFont
        End If
    End Sub

    Private Sub FileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FileList.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If FileList.SelectedRows.Count > 0 Then
            Process.Start(FileList.SelectedRows.Item(0).Cells.Item("FilePath").Value.ToString)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If LibaryList.SelectedRows.Count > 0 Then
            Process.Start(LibaryList.SelectedRows.Item(0).Cells.Item("LibaryFilePath").Value.ToString)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ListBox1.Items.Add(SourcePath_TextBox.Text)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Not (IsNothing(ListBox1.SelectedItem)) Then
            SourcePath_TextBox.Text = ListBox1.SelectedItem.ToString
        End If



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Options_Panel.Visible = Not (Options_Panel.Visible)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim favstr As String = ""

        For item As Integer = 0 To ListBox1.Items.Count - 2
            favstr = ListBox1.Items(item).ToString & ";" & favstr
        Next
        favstr = favstr & ListBox1.Items(ListBox1.Items.Count - 1).ToString

        My.Settings.Favorites = favstr
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub HideDupes_Click(sender As Object, e As EventArgs) Handles HideDupes_Button.Click

        If HideDupes Then
            HideDupes_Button.Text = "Show Duplicate Files in Source"
            For Each row As DataGridViewRow In FileList.Rows
                If Not (IsDBNull(row.Cells("InLibary").Value)) Then

                    If row.Cells("InLibary").Value.ToString = "IN LIBARY" Then
                        row.Visible = False
                    End If
                End If

            Next
        Else
            HideDupes_Button.Text = "Hide Duplicate Files in Source"

            For Each row As DataGridViewRow In FileList.Rows
                row.Visible = True
            Next
        End If

        HideDupes = Not (HideDupes)
    End Sub
End Class
