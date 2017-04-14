Option Strict Off

Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Threading

Public Structure ProgressReport
    Property Min As Integer
    Property Max As Integer
    Property Current As Integer
    Property ReportType As String
    Property TextMessage As String

End Structure

Public Class Form1
    Private Source_DS As New ComicInfoDB
    Private Libary_DS As New ComicInfoDB
    Private FilesTread As Thread
    Private LibaryThread As Thread
    Private CopyThread As Thread
    Private HashThread As Thread
    Private CopyProg As Thread

    Private WithEvents LoadSource_BackgroundWorker As New BackgroundWorker
    Private WithEvents LoadLibrary_BackgroundWorker As New BackgroundWorker


    Private HideDupes As Boolean = True
    Private SourceLoaded As Boolean = False
    Private LibaryLoaded As Boolean = False

    Public Sub New()

        InitializeComponent()
        LoadSource_BackgroundWorker.WorkerReportsProgress = True
        LoadSource_BackgroundWorker.WorkerSupportsCancellation = False
        LoadLibrary_BackgroundWorker.WorkerReportsProgress = True
        LoadLibrary_BackgroundWorker.WorkerSupportsCancellation = False

        For Each column As DataGridViewColumn In SourceLibary_DGV.Columns
            column.MinimumWidth = 110
        Next
        For Each column As DataGridViewColumn In LibraryList_DGV.Columns
            column.MinimumWidth = 110
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LibraryList_DGV.DefaultCellStyle = SourceLibary_DGV.DefaultCellStyle
        LibraryList_DGV.AlternatingRowsDefaultCellStyle = SourceLibary_DGV.AlternatingRowsDefaultCellStyle

        Dim Favorites() As String = Split(My.Settings.Favorites, ";")
        For Each FavSingle As String In Favorites
            ListBox1.Items.Add(FavSingle)
        Next

    End Sub

    Private Sub enable_DupeCheck()
        If SourceLoaded And LibaryLoaded Then
            CheckUnique_Button.Enabled = True
        Else
            CheckUnique_Button.Enabled = False
        End If
    End Sub


#Region "Load Source List"

    Private Sub LoadSource_Click(sender As Object, e As EventArgs) Handles LoadSource_Button.Click
        If Not (LoadSource_BackgroundWorker.IsBusy) Then LoadSource_BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub LoadSource_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadSource_BackgroundWorker.ProgressChanged
        Dim ProgressReport As New ProgressReport
        ProgressReport = CType(e.UserState, ProgressReport)
        Select Case ProgressReport.ReportType
            Case "start"
                SourceLibary_ProgressBar.Maximum = ProgressReport.Max
                SourceLibary_ProgressBar.Minimum = ProgressReport.Min
                SourceLibary_ProgressBar.Value = ProgressReport.Current
                status.Text = ProgressReport.TextMessage
                'SourceLibary_ProgressBar.Value = e.ProgressPercentage
            Case "update"
                SourceLibary_ProgressBar.Value = ProgressReport.Current
                status.Text = ProgressReport.TextMessage
            Case "finish"
                status.Text = ProgressReport.TextMessage
                SourceLibary_ProgressBar.Value = 0
        End Select
    End Sub

    Private Sub LoadSource_RunWorkCompleated(sender As System.Object, e As RunWorkerCompletedEventArgs) Handles LoadSource_BackgroundWorker.RunWorkerCompleted
        SourceLibary_DGV.Visible = False
        SourceLibary_DGV.Visible = True
        SourceLoaded = True
        enable_DupeCheck()
    End Sub

    Private Sub LoadSourceFiles(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles LoadSource_BackgroundWorker.DoWork

        'Dim Worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim ProgressReport As New ProgressReport

        Dim directory As String = SourcePath_TextBox.Text
        Dim Source_FileNames() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
        Dim cnt As Integer
        ProgressReport.ReportType = "start"
        ProgressReport.Min = 0
        ProgressReport.Max = Source_FileNames.Count
        ProgressReport.Current = 0
        ProgressReport.TextMessage = "Found " & Source_FileNames.Count & " files....Begining search"


        LoadSource_BackgroundWorker.ReportProgress(0, ProgressReport)

        For Each filename As String In Source_FileNames
            cnt += 1

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
            Dim hash As String = ""
            If GetHashesOnScanToolStripMenuItem.Checked Then
                hash = md5_hash(filename)
            End If
            Try
                If Not hide Then
                    Dim filedate As Date
                    Try
                        filedate = IO.File.GetCreationTime(filename)
                    Catch ex As Exception
                    End Try
                    Dim filesize As Double = FileLen(filename)
                    Dim filesizestr As Double = Math.Round(filesize / 1000000, 3)

                    If Not (hide) Then
                        Dim newrow As ComicInfoDB.SOURCEL_DBRow
                        newrow = ComicInfoDB.SOURCEL_DB.NewRow
                        newrow("File Name") = IO.Path.GetFileName(filename)
                        newrow("Full File Name") = filename
                        newrow("File Type") = IO.Path.GetExtension(filename)
                        newrow("File Path") = IO.Path.GetDirectoryName(filename)
                        Dim RelPath As String = IO.Path.GetDirectoryName(filename)
                        RelPath = RelPath.Remove(0, directory.Length) & "\"
                        newrow("Path Rel Root") = RelPath
                        newrow("File Size") = filesizestr
                        newrow("Date Created") = filedate.ToString("dd-MMM-yyyy")
                        newrow("SHA1 Hash") = hash
                        'sync
                        ComicInfoDB.SOURCEL_DB.Rows.Add(newrow)

                        ProgressReport.Current = cnt
                        ProgressReport.ReportType = "update"
                        ProgressReport.TextMessage = "Loading Source files. Processed " & cnt & " of " & Source_FileNames.Count & " files."
                        LoadSource_BackgroundWorker.ReportProgress(0, ProgressReport)

                    End If
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try
        Next

        ProgressReport.TextMessage = "Loading Source complete. " & Source_FileNames.Count & " Added to list."
        ProgressReport.ReportType = "finish"
        LoadSource_BackgroundWorker.ReportProgress(0, ProgressReport)

        SourceLoaded = True

    End Sub
#End Region

#Region "Load Library List"

    Private Sub LoadLibary_Click(sender As Object, e As EventArgs) Handles LoadLibary_Button.Click
        If Not (LoadLibrary_BackgroundWorker.IsBusy) Then LoadLibrary_BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub LoadLirbary_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadLibrary_BackgroundWorker.ProgressChanged
        Dim ProgressReport As New ProgressReport
        ProgressReport = CType(e.UserState, ProgressReport)
        Select Case ProgressReport.ReportType
            Case "start"
                MainLibrary_ProgressBar.Maximum = ProgressReport.Max
                MainLibrary_ProgressBar.Minimum = ProgressReport.Min
                MainLibrary_ProgressBar.Value = ProgressReport.Current
                status2.Text = ProgressReport.TextMessage
                'SourceLibary_ProgressBar.Value = e.ProgressPercentage
            Case "update"
                MainLibrary_ProgressBar.Value = ProgressReport.Current
                status2.Text = ProgressReport.TextMessage
            Case "finish"
                status2.Text = ProgressReport.TextMessage
                MainLibrary_ProgressBar.Value = 0
        End Select
    End Sub

    Private Sub LoadLibrary_RunWorkCompleated(sender As System.Object, e As RunWorkerCompletedEventArgs) Handles LoadLibrary_BackgroundWorker.RunWorkerCompleted
        LibraryList_DGV.Visible = False
        LibraryList_DGV.Visible = True
        LibaryLoaded = True
        enable_DupeCheck()
    End Sub

    Private Sub LoadLibraryFiles(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles LoadLibrary_BackgroundWorker.DoWork

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
                Dim hash As String = ""
                If GetHashesOnScanToolStripMenuItem.Checked Then
                    hash = md5_hash(filename)
                End If

                Dim filesize As Double = FileLen(filename)
                Dim filesizestr As Double = Math.Round(filesize / 1000000, 3)
                Dim filedate As Date = IO.File.GetCreationTime(filename)

                Dim newrow As ComicInfoDB.LIBARY_DBRow
                newrow = ComicInfoDB.LIBARY_DB.NewRow
                newrow("File Name") = IO.Path.GetFileName(filename)
                newrow("Full File Name") = filename
                newrow("File Type") = IO.Path.GetExtension(filename)
                newrow("File Path") = IO.Path.GetDirectoryName(filename)
                Dim RelPath As String = IO.Path.GetDirectoryName(filename)
                RelPath = RelPath.Remove(0, directory.Length) & "\"
                newrow("Path Rel Root") = RelPath
                newrow("File Size") = filesizestr
                newrow("Date Created") = filedate.ToString("dd-MMM-yyyy")
                newrow("SHA1 Hash") = hash

                ComicInfoDB.LIBARY_DB.Rows.Add(newrow) ' ADD THE ROW TO THE DATASET

                ProgressReport.Current = cnt
                ProgressReport.ReportType = "update"
                ProgressReport.TextMessage = "Loading Main Library Files. Processed " & cnt & " of " & Library_FileNames.Count & " files."
                LoadLibrary_BackgroundWorker.ReportProgress(0, ProgressReport) 'REPORT THE STATUS OF FILE PROCESSING.

            Catch ex As Exception
            End Try
        Next

        LibaryLoaded = True

    End Sub


#End Region


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        SourceLibary_DGV.DefaultCellStyle.Font = My.Settings.DGVFont
        LibraryList_DGV.DefaultCellStyle.Font = My.Settings.DGVFont

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Set_Font_Button.Click
        Dim FntSel As New FontDialog
        If FntSel.ShowDialog = DialogResult.OK Then
            My.Settings.DGVFont = FntSel.Font
            SourceLibary_DGV.DefaultCellStyle.Font = My.Settings.DGVFont
            LibraryList_DGV.DefaultCellStyle.Font = My.Settings.DGVFont
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

    Private Sub CheckUnique_Button_Click(sender As Object, e As EventArgs) Handles CheckUnique_Button.Click

        For Each row As DataRow In ComicInfoDB.SOURCEL_DB.Rows

            Dim filename As String = row("File Name")

            For Each LibaryRow As DataRow In ComicInfoDB.LIBARY_DB.Rows

                If filename = LibaryRow("File Name") Then
                    row("Unique Status") = "In Libary"
                End If

            Next

        Next

    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

#Region "Folder Browser Dialogs and Link Labels"

    Private Sub Source_Browse_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Source_Browse_LL.LinkClicked
        Using Fldlg As New FolderBrowserDialog
            Fldlg.RootFolder = Environment.SpecialFolder.Desktop
            Fldlg.SelectedPath = SourcePath_TextBox.Text
            If Fldlg.ShowDialog = vbOK Then
                SourcePath_TextBox.Text = Fldlg.SelectedPath
            End If
        End Using

    End Sub



    Private Sub UnsortedPathBRSR_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UnsortedPathBRSR_LinkLabel.LinkClicked
        Using Fldlg As New FolderBrowserDialog
            Fldlg.RootFolder = Environment.SpecialFolder.Desktop
            Fldlg.SelectedPath = UnsortedFolderTextBox.Text
            If Fldlg.ShowDialog = vbOK Then
                UnsortedFolderTextBox.Text = Fldlg.SelectedPath
            End If
        End Using

    End Sub

#End Region


    Private Sub OpenDest_ToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenDest_ToolStripButton.Click
        If LibraryList_DGV.SelectedRows.Count > 0 Then
            Process.Start(LibraryList_DGV.SelectedRows.Item(0).Cells.Item("FilePathDataGridViewTextBoxColumn1").Value.ToString)
        End If
    End Sub

    Private Sub OpenSource_Libary_Click(sender As Object, e As EventArgs) Handles OpenSource_Libary.Click
        If SourceLibary_DGV.SelectedRows.Count > 0 Then
            Process.Start(SourceLibary_DGV.SelectedRows.Item(0).Cells.Item("FilePathDataGridViewTextBoxColumn").Value.ToString)
        End If
    End Sub


#Region "Source View Menu Items"
    Private Sub HideDupes_Click(sender As Object, e As EventArgs) Handles HideDupes_CHKButton.Click

        For i As Integer = ComicInfoDB.SOURCEL_DB.Rows.Count - 1 To 0 Step -1
            If Not (IsDBNull(ComicInfoDB.SOURCEL_DB.Rows.Item(i).Item("Unique Status"))) Then

                If ComicInfoDB.SOURCEL_DB.Rows.Item(i).Item("Unique Status") = "In Libary" Then
                    ComicInfoDB.SOURCEL_DB.Rows.Item(i).Delete()
                End If
            End If
        Next i

        '     For Each row As DataRow In ComicInfoDB.SOURCEL_DB.Rows
        '    If Not (IsDBNull(row("Unique Status"))) Then
        '   If row("Unique Status") = "In Libary" Then
        '  ComicInfoDB.SOURCEL_DB.RemoveSOURCEL_DBRow(row)

        'row.Delete()
        'End If
        'End If
        'Next
        'For Each row As DataGridViewRow In SourceLibary_DGV.Rows
        'If row.Cells("UniqueStatusDataGridViewTextBoxColumn").Value.ToString = "In Libary" Then

        'row.Visible = False
        ' End If
        'End If

        ' Next


    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        TabFunctions.CloseME(Me)
    End Sub


    Private Sub FileList_SelectionChanged(sender As Object, e As EventArgs) Handles SourceLibary_DGV.SelectionChanged
        If IsNothing(SourceLibary_DGV.SelectedRows) Then
            CopySelected.Enabled = False
        ElseIf LibaryLoaded And SourceLoaded Then
            CopySelected.Enabled = True
        End If

        Dim TotalSelectedSize As Double = 0


        If SourceLibary_DGV.SelectedRows IsNot Nothing Then
            For Each row As DataGridViewRow In SourceLibary_DGV.SelectedRows
                Dim RawFileSizeSTR As String
                If Not (IsDBNull(row.Cells.Item("FileSizeDataGridViewTextBoxColumn").Value)) Then
                    RawFileSizeSTR = row.Cells.Item("FileSizeDataGridViewTextBoxColumn").Value.ToString
                    Dim Value As Double
                    If Double.TryParse(RawFileSizeSTR, Value) Then
                        TotalSelectedSize += Value
                    End If
                End If
            Next
            Dim MBDbl As Double = Math.Round((TotalSelectedSize / 1000000), 2)
            Dim MBStr As String = MBDbl.ToString("N", CultureInfo.InvariantCulture) & " Mb."

            'dblValue.ToString("N", CultureInfo.InvariantCulture))

            Selection_Label.Text = SourceLibary_DGV.SelectedRows.Count & " Files selected. (" & MBStr & ")"

        End If
    End Sub

    Private Sub ClearSource_Button_Click(sender As Object, e As EventArgs) Handles ClearSource_Button.Click
        'SourceLibary_DGV.Rows.Clear()
        ComicInfoDB.SOURCEL_DB.Clear()
        SourceLoaded = False
        enable_DupeCheck()
    End Sub

    Private Sub ClearLibary_Button_Click(sender As Object, e As EventArgs) Handles ClearLibary_Button.Click
        'LibaryList_DGV.Rows.Clear()
        ComicInfoDB.LIBARY_DB.Clear()
        LibaryLoaded = False
        enable_DupeCheck()
    End Sub

    Private Sub LinkLabel4_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim FileOpen As New OpenFileDialog
        FileOpen.ShowDialog()

        Dim ds As New DataSet
        ds.ReadXml(FileOpen.FileName)
        For Each datatable As DataTable In ds.Tables
            Console.WriteLine(datatable.TableName)
            'For Each row As DataRow In datatable.Rows

            'Next

        Next
        For Each row As DataRow In ds.Tables.Item("ComicDatabase").Rows
            Console.WriteLine(row.Item(0))
        Next


    End Sub


#End Region

#Region "Crypto and Hash Gen"


    ' Function to obtain the desired hash of a file
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String) As String

        ' We declare the variable : hash
        Dim hash As HashAlgorithm
        If hash_type.ToLower = "md5" Then
            ' Initializes a md5 hash object
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initializes a SHA-1 hash object
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initializes a SHA-256 hash object
            hash = SHA256.Create()
        Else
            MsgBox("Unknown type of hash : " & hash_type, MsgBoxStyle.Critical)
            Return "False"
        End If

        ' We declare a variable to be an array of bytes
        Dim hashValue() As Byte

        ' We create a FileStream for the file passed as a parameter
        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' We position the cursor at the beginning of stream
        fileStream.Position = 0
        ' We calculate the hash of the file
        hashValue = hash.ComputeHash(fileStream)
        ' The array of bytes is converted into hexadecimal before it can be read easily
        Dim hash_hex = PrintByteArray(hashValue)

        ' We close the open file
        fileStream.Close()

        ' The hash is returned
        Return hash_hex

    End Function

    Public Function PrintByteArray(ByVal array() As Byte) As String

        Dim hex_value As String = ""

        ' We traverse the array of bytes
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' We convert each byte in hexadecimal
            hex_value += array(i).ToString("X2")

        Next i

        ' We return the string in lowercase
        Return hex_value.ToLower

    End Function
    Function md5_hash(ByVal file_name As String) As String
        Return hash_generator("md5", file_name)
    End Function

    Function sha_1(ByVal file_name As String) As String
        Return hash_generator("sha1", file_name)
    End Function

    Function sha_256(ByVal file_name As String) As String
        Return hash_generator("sha256", file_name)
    End Function
#End Region

#Region "Hash Generation and Filling"


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles GetLibaryHashes_Button.Click
        GetLibaryHashes_Button.Enabled = False
        GetSourceHashes_Button.Enabled = False

        FilesTread = New Thread(AddressOf GetLibary_Hashes)
        FilesTread.IsBackground = True
        FilesTread.Start()

    End Sub
    Private Sub GetLibary_Hashes()
        If LibraryList_DGV.Rows.Count > 0 Then
            status.Text = "Generating Hashes for files"
            MainLibrary_ProgressBar.Maximum = LibraryList_DGV.Rows.Count
            MainLibrary_ProgressBar.Value = 0

            For Each row As DataGridViewRow In LibraryList_DGV.Rows
                status.Text = "Generating Hashes for files, " & row.Index & " Hashes of " & LibraryList_DGV.Rows.Count & " Calculated."
                Dim filename As String = row.Cells.Item("Libary_FullFileName").Value.ToString
                Dim hash As String = md5_hash(filename)
                row.Cells.Item("Libary_FileHash").Value = hash
                MainLibrary_ProgressBar.Value = row.Index + 1
            Next

            GetLibaryHashes_Button.Enabled = True
            GetSourceHashes_Button.Enabled = True
            status.Text = "Hash Generation Complete."
        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles GetSourceHashes_Button.Click
        GetLibaryHashes_Button.Enabled = False
        GetSourceHashes_Button.Enabled = False

        FilesTread = New Thread(AddressOf GetSource_Hashes)
        FilesTread.IsBackground = True
        FilesTread.Start()

    End Sub
    Private Sub GetSource_Hashes()
        If SourceLibary_DGV.Rows.Count > 0 Then
            status.Text = "Generating Hashes for files"
            SourceLibary_ProgressBar.Maximum = SourceLibary_DGV.Rows.Count
            SourceLibary_ProgressBar.Value = 0

            For Each row As DataGridViewRow In SourceLibary_DGV.Rows
                status.Text = "Generating Hashes for files, " & row.Index & " Hashes of " & SourceLibary_DGV.Rows.Count & " Calculated."
                Dim filename As String = row.Cells.Item("FullFileName").Value.ToString
                Dim hash As String = md5_hash(filename)
                row.Cells.Item("Source_FileHash").Value = hash
                SourceLibary_ProgressBar.Value = row.Index + 1
            Next

            GetLibaryHashes_Button.Enabled = True
            GetSourceHashes_Button.Enabled = True
            status.Text = "Hash Generation Complete."
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TabFunctions.CloseME(Me)
    End Sub

    Private Sub CopySelected_Click(sender As Object, e As EventArgs) Handles CopySelected.Click
        CopyThread = New Thread(AddressOf CopyWork)
        CopyThread.IsBackground = True
        CopyThread.Start()
    End Sub



    Private Sub CopyWork()



        Dim CopyProgress As New CopyProgDialog
        CopyProgress.Show()
        CopyProgress.ProgressBar.Maximum = SourceLibary_DGV.SelectedRows.Count
        'CopyProgress_Label.Visible = True

        CopyProgress.Progress_Label.Text = "Begin Copying " & SourceLibary_DGV.SelectedRows.Count & " Files...."
        'CopyProgress_Label.Visible = False
        Dim cnt As Integer
        For Each row As DataGridViewRow In SourceLibary_DGV.SelectedRows
            cnt += 1
            CopyProgress.ProgressBar.Value = cnt

            'MsgBox(row.Cells.Item("FullFileName").Value.ToString)
            Dim srcfilename As String = row.Cells.Item("FileNameDataGridViewTextBoxColumn").Value.ToString
            Dim srcfullfilename As String = row.Cells.Item("FullFileNameDataGridViewTextBoxColumn").Value.ToString


            Dim destfilename As String = UnsortedFolderTextBox.Text & "\" & srcfilename

            Try
                CopyProgress.CurrentFileNameLabel.Text = srcfilename
                Dim cpyTask As New CopyThread()
                Dim Thread1 As New System.Threading.Thread(AddressOf cpyTask.CopyFile)
                cpyTask.showsysteminfo = ShowCopy_CheckBox.Checked
                cpyTask.srcfullfilename = srcfullfilename
                cpyTask.destfilename = destfilename
                Thread1.Start()
                Thread1.Join()
                If cpyTask.copyok Then
                    CopyProgress.Progress_Label.Text = "Copied " & cnt & " Files of " & SourceLibary_DGV.SelectedRows.Count
                    row.Cells.Item("CopyStatusDataGridViewTextBoxColumn").Value = "COPIED"
                Else
                    row.Cells.Item("CopyStatusDataGridViewTextBoxColumn").Value = "FAILED"
                End If


                CopyProgress.Progress_Label.Text = "Copied " & cnt & " Files of " & SourceLibary_DGV.SelectedRows.Count

            Catch ex As Exception

                MsgBox(ex.Message)
            End Try




        Next
        CopyProgress.Progress_Label.Text = "Copied " & cnt & " Files. Copy Complete"
        CopyProgress.Close()


    End Sub


#End Region
    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        SplitContainer1.Orientation = Orientation.Vertical
        HorizontalToolStripMenuItem.Checked = False
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        SplitContainer1.Orientation = Orientation.Horizontal
        VerticalToolStripMenuItem.Checked = False
    End Sub

    Private Sub SourceToolStrip_ItemClicked(sender As Object, e As EventArgs) Handles SourceToolStrip.SizeChanged

    End Sub

    Private Sub SourceToolStrip_Resize(sender As Object, e As EventArgs) Handles SourceToolStrip.Resize
        If SplitContainer1.Orientation = Orientation.Vertical Then
            ToolStrip2.Height = SourceToolStrip.Height
        End If
    End Sub
End Class

Class CopyThread
    Public srcfullfilename As String
    Public destfilename As String
    Public showsysteminfo As Boolean = False
    Public copyok As Boolean

    Sub CopyFile()
        Try
            If showsysteminfo Then
                My.Computer.FileSystem.CopyFile(srcfullfilename, destfilename, FileIO.UIOption.AllDialogs)
            Else
                My.Computer.FileSystem.CopyFile(srcfullfilename, destfilename)
            End If
            copyok = True
        Catch ex As Exception
            copyok = False
        End Try

    End Sub
End Class




