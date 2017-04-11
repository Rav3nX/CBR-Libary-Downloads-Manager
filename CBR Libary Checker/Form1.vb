Option Strict Off

Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Threading



Public Class Form1
    Private Source_DS As New ComicInfoDB
    Private Libary_DS As New ComicInfoDB
    Private FilesTread As Thread
    Private LibaryThread As Thread
    Private CopyThread As Thread
    Private HashThread As Thread
    Private CopyProg As Thread


    Private Source_Progress_Maximum As Integer = 100
    Private Libary_Progress_Maximum As Integer = 100


    Private HideDupes As Boolean = True
    Private SourceLoaded As Boolean = False
    Private LibaryLoaded As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LibaryList_DGV.DefaultCellStyle = SourceLibary_DGV.DefaultCellStyle
        LibaryList_DGV.AlternatingRowsDefaultCellStyle = SourceLibary_DGV.AlternatingRowsDefaultCellStyle

        Dim Favorites() As String = Split(My.Settings.Favorites, ";")
        For Each FavSingle As String In Favorites
            ListBox1.Items.Add(FavSingle)
        Next

    End Sub

    Private Sub LoadSource_Click(sender As Object, e As EventArgs) Handles LoadSource_Button.Click

        'FilesTread = New Thread(AddressOf LoadSourceFiles)
        'FilesTread.IsBackground = True
        'FilesTread.Start()
        LoadSourceFiles()

    End Sub

    Private Sub enable_DupeCheck()
        If SourceLoaded And LibaryLoaded Then
            CheckUnique_Button.Enabled = True
        Else
            CheckUnique_Button.Enabled = False
        End If
    End Sub
    Private Sub UpdateSourceProgressBar(ByVal New_Value As String)
        If Me.InvokeRequired Then
            Dim args() As String = {New_Value}
            Me.Invoke(New Action(Of String)(AddressOf UpdateSourceProgressBar), args)
            Return
        End If
        SourceLibary_ProgressBar.Maximum = Source_Progress_Maximum
        SourceLibary_ProgressBar.Value = CInt(New_Value)
    End Sub
    Private Sub UpdateStatusText(ByVal New_Value As String)
        If Me.InvokeRequired Then
            Dim args() As String = {New_Value}
            Me.Invoke(New Action(Of String)(AddressOf UpdateStatusText), args)
            Return
        End If
        status.Text = New_Value
    End Sub


    Private Sub LoadSourceFiles()
        'Try
        status.Text = " Scanning Source Directory....please wait."
        Dim directory As String = SourcePath_TextBox.Text


        Dim Source_FileNames() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)

        'Thread Safe Progress Bar Updating
        Source_Progress_Maximum = Source_FileNames.Count
        UpdateSourceProgressBar(0)
        'Thread Safe status update
        UpdateStatusText(" Loading " & Source_FileNames.Count & " files from source folder.....Please Wait....")

        Dim cnt As Integer

        For Each filename As String In Source_FileNames
            cnt += 1
            UpdateSourceProgressBar(cnt)
            'SourceLibary_ProgressBar.Value = cnt

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

                    ' Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(filename)
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

                    End If
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try
        Next
        UpdateStatusText("Loaded " & Source_FileNames.Count & " Files from " & directory)

        SourceLoaded = True
        enable_DupeCheck()
        refreshdgv()
        'Catch ex As Exception
        'MsgBox("Error! :   " & ex.Message)
        'End Try
    End Sub
    Private Sub refreshdgv()
        'SourceLibary_DGV.Refresh()

    End Sub


    Private Sub UpdateLibaryProgressBar(ByVal New_Value As String)
        If Me.InvokeRequired Then
            Dim args() As String = {New_Value}
            Me.Invoke(New Action(Of String)(AddressOf UpdateLibaryProgressBar), args)
            Return
        End If
        MainLibary_ProgressBar.Maximum = Libary_Progress_Maximum
        MainLibary_ProgressBar.Value = CInt(New_Value)
    End Sub

    Private Sub LoadLibary_Button_Click(sender As Object, e As EventArgs) Handles LoadLibary_Button.Click
        'LibaryThread = New Thread(AddressOf LoadLibary)
        'LibaryThread.IsBackground = True
        'LibaryThread.Start()
        LoadLibary()
    End Sub

    Private Sub LoadLibary()
        Dim directory As String = My.Settings.LibaryFolder
        UpdateStatusText("Scanning Libary....Please Wait.")

        Dim libstr() As String = IO.Directory.GetFiles(directory, "*.cb*", IO.SearchOption.AllDirectories)
        Libary_Progress_Maximum = libstr.Count

        UpdateLibaryProgressBar(0)
        UpdateStatusText(" Loading " & libstr.Count & " files from libary.....Please Wait....")

        Dim cnt As Integer
        For Each filename As String In libstr
            cnt += 1
            UpdateLibaryProgressBar(cnt)

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

                ComicInfoDB.LIBARY_DB.Rows.Add(newrow)

                'LibaryList_DGV.Rows.Add(IO.Path.GetFileName(filename), filename, IO.Path.GetExtension(filename), IO.Path.GetDirectoryName(filename), filesizestr)
            Catch ex As Exception
            End Try
        Next
        ' status.Text = "Getting Hashes for files in libary"
        LibaryLoaded = True
        UpdateStatusText("Done loading Libary.")
        enable_DupeCheck()
    End Sub





    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Options_Panel.Paint
        SourceLibary_DGV.DefaultCellStyle.Font = My.Settings.DGVFont
        LibaryList_DGV.DefaultCellStyle.Font = My.Settings.DGVFont

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Set_Font_Button.Click
        Dim FntSel As New FontDialog
        If FntSel.ShowDialog = DialogResult.OK Then
            My.Settings.DGVFont = FntSel.Font
            SourceLibary_DGV.DefaultCellStyle.Font = My.Settings.DGVFont
            LibaryList_DGV.DefaultCellStyle.Font = My.Settings.DGVFont
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
        If LibaryList_DGV.SelectedRows.Count > 0 Then
            Process.Start(LibaryList_DGV.SelectedRows.Item(0).Cells.Item("FilePathDataGridViewTextBoxColumn1").Value.ToString)
        End If
    End Sub

    Private Sub OpenSource_Libary_Click(sender As Object, e As EventArgs) Handles OpenSource_Libary.Click
        If SourceLibary_DGV.SelectedRows.Count > 0 Then
            Process.Start(SourceLibary_DGV.SelectedRows.Item(0).Cells.Item("FilePathDataGridViewTextBoxColumn").Value.ToString)
        End If
    End Sub


#Region "Source View Menu Items"
    Private Sub HideDupes_Click(sender As Object, e As EventArgs) Handles HideDupes_CHKButton.Click
        If HideDupes_CHKButton.Checked Then
            For Each row As DataGridViewRow In SourceLibary_DGV.Rows
                If Not (IsDBNull(row.Cells("InLibary").Value)) Then
                    If row.Cells("InLibary").Value.ToString = "IN LIBARY" Then
                        row.Visible = False
                    End If
                End If

            Next
        Else
            For Each row As DataGridViewRow In SourceLibary_DGV.Rows
                row.Visible = True
            Next
        End If
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
        If LibaryList_DGV.Rows.Count > 0 Then
            status.Text = "Generating Hashes for files"
            MainLibary_ProgressBar.Maximum = LibaryList_DGV.Rows.Count
            MainLibary_ProgressBar.Value = 0

            For Each row As DataGridViewRow In LibaryList_DGV.Rows
                status.Text = "Generating Hashes for files, " & row.Index & " Hashes of " & LibaryList_DGV.Rows.Count & " Calculated."
                Dim filename As String = row.Cells.Item("Libary_FullFileName").Value.ToString
                Dim hash As String = md5_hash(filename)
                row.Cells.Item("Libary_FileHash").Value = hash
                MainLibary_ProgressBar.Value = row.Index + 1
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




