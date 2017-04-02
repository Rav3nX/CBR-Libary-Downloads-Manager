<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FileList = New System.Windows.Forms.DataGridView()
        Me.FullFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unwanted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filesize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InLibary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadSource_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HideDupes_Button = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UnsortedFolderTextBox = New System.Windows.Forms.TextBox()
        Me.CopySelected = New System.Windows.Forms.Button()
        Me.CheckDuplicate_Button = New System.Windows.Forms.Button()
        Me.LibaryPath = New System.Windows.Forms.TextBox()
        Me.LoadLibary_Button = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SourcePath_TextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LibaryList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibaryFilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filesizelibary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.fileslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Options_Panel = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.LibaryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Options_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileList
        '
        Me.FileList.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.FileList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FileList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullFileName, Me.FileName, Me.Type, Me.unwanted, Me.FilePath, Me.DateCreated, Me.filesize, Me.InLibary})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FileList.DefaultCellStyle = DataGridViewCellStyle2
        Me.FileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileList.GridColor = System.Drawing.Color.White
        Me.FileList.Location = New System.Drawing.Point(0, 0)
        Me.FileList.Name = "FileList"
        Me.FileList.ReadOnly = True
        Me.FileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FileList.Size = New System.Drawing.Size(743, 533)
        Me.FileList.TabIndex = 0
        '
        'FullFileName
        '
        Me.FullFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullFileName.HeaderText = "Full File Path"
        Me.FullFileName.Name = "FullFileName"
        Me.FullFileName.ReadOnly = True
        '
        'FileName
        '
        Me.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FileName.HeaderText = "FileName"
        Me.FileName.Name = "FileName"
        Me.FileName.ReadOnly = True
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Type.FillWeight = 60.0!
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'unwanted
        '
        Me.unwanted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.unwanted.HeaderText = "Unwanted"
        Me.unwanted.Name = "unwanted"
        Me.unwanted.ReadOnly = True
        '
        'FilePath
        '
        Me.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FilePath.HeaderText = "File Path"
        Me.FilePath.Name = "FilePath"
        Me.FilePath.ReadOnly = True
        '
        'DateCreated
        '
        Me.DateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateCreated.FillWeight = 80.0!
        Me.DateCreated.HeaderText = "Date Created"
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.ReadOnly = True
        '
        'filesize
        '
        Me.filesize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.filesize.FillWeight = 70.0!
        Me.filesize.HeaderText = "FileSize"
        Me.filesize.Name = "filesize"
        Me.filesize.ReadOnly = True
        '
        'InLibary
        '
        Me.InLibary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InLibary.FillWeight = 80.0!
        Me.InLibary.HeaderText = "In Libary"
        Me.InLibary.Name = "InLibary"
        Me.InLibary.ReadOnly = True
        '
        'LoadSource_Button
        '
        Me.LoadSource_Button.Location = New System.Drawing.Point(21, 14)
        Me.LoadSource_Button.Name = "LoadSource_Button"
        Me.LoadSource_Button.Size = New System.Drawing.Size(179, 23)
        Me.LoadSource_Button.TabIndex = 2
        Me.LoadSource_Button.Text = "Load Source Folder"
        Me.LoadSource_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.HideDupes_Button)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.ProgressBar3)
        Me.Panel1.Controls.Add(Me.ProgressBar2)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.UnsortedFolderTextBox)
        Me.Panel1.Controls.Add(Me.CopySelected)
        Me.Panel1.Controls.Add(Me.CheckDuplicate_Button)
        Me.Panel1.Controls.Add(Me.LibaryPath)
        Me.Panel1.Controls.Add(Me.LoadLibary_Button)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.LoadSource_Button)
        Me.Panel1.Controls.Add(Me.SourcePath_TextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1637, 189)
        Me.Panel1.TabIndex = 3
        '
        'HideDupes_Button
        '
        Me.HideDupes_Button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.HideDupes_Button.Location = New System.Drawing.Point(626, 151)
        Me.HideDupes_Button.Name = "HideDupes_Button"
        Me.HideDupes_Button.Size = New System.Drawing.Size(232, 23)
        Me.HideDupes_Button.TabIndex = 17
        Me.HideDupes_Button.Text = "Hide Duplicates In Source"
        Me.HideDupes_Button.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(170, 160)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(177, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Show Options"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(485, 47)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(173, 17)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add Location to Favorites."
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar3.Location = New System.Drawing.Point(232, 98)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(272, 23)
        Me.ProgressBar3.TabIndex = 14
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.Location = New System.Drawing.Point(1349, 14)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(272, 23)
        Me.ProgressBar2.TabIndex = 13
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(206, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(272, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(1346, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Open Selected"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Open Selected"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'UnsortedFolderTextBox
        '
        Me.UnsortedFolderTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UnsortedFolderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "unsortedfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UnsortedFolderTextBox.Location = New System.Drawing.Point(21, 127)
        Me.UnsortedFolderTextBox.Name = "UnsortedFolderTextBox"
        Me.UnsortedFolderTextBox.Size = New System.Drawing.Size(393, 22)
        Me.UnsortedFolderTextBox.TabIndex = 8
        Me.UnsortedFolderTextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.unsortedfolder
        '
        'CopySelected
        '
        Me.CopySelected.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CopySelected.Location = New System.Drawing.Point(21, 98)
        Me.CopySelected.Name = "CopySelected"
        Me.CopySelected.Size = New System.Drawing.Size(205, 23)
        Me.CopySelected.TabIndex = 7
        Me.CopySelected.Text = "Copy Selected Comics To:"
        Me.CopySelected.UseVisualStyleBackColor = True
        '
        'CheckDuplicate_Button
        '
        Me.CheckDuplicate_Button.Location = New System.Drawing.Point(677, 98)
        Me.CheckDuplicate_Button.Name = "CheckDuplicate_Button"
        Me.CheckDuplicate_Button.Size = New System.Drawing.Size(139, 46)
        Me.CheckDuplicate_Button.TabIndex = 6
        Me.CheckDuplicate_Button.Text = "Check Unique"
        Me.CheckDuplicate_Button.UseVisualStyleBackColor = True
        '
        'LibaryPath
        '
        Me.LibaryPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibaryPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "LibaryFolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LibaryPath.Location = New System.Drawing.Point(1138, 43)
        Me.LibaryPath.Name = "LibaryPath"
        Me.LibaryPath.Size = New System.Drawing.Size(483, 22)
        Me.LibaryPath.TabIndex = 5
        Me.LibaryPath.Text = Global.CBR_Libary_Checker.My.MySettings.Default.LibaryFolder
        '
        'LoadLibary_Button
        '
        Me.LoadLibary_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadLibary_Button.Location = New System.Drawing.Point(1138, 14)
        Me.LoadLibary_Button.Name = "LoadLibary_Button"
        Me.LoadLibary_Button.Size = New System.Drawing.Size(205, 23)
        Me.LoadLibary_Button.TabIndex = 4
        Me.LoadLibary_Button.Text = "Load Libary Folder"
        Me.LoadLibary_Button.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HideUnwanted
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CBR_Libary_Checker.My.MySettings.Default, "HideUnwanted", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(21, 71)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(296, 21)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Hide Fiiles in .Unwanted Folders (qtorrent)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SourcePath_TextBox
        '
        Me.SourcePath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "torrentfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SourcePath_TextBox.Location = New System.Drawing.Point(21, 43)
        Me.SourcePath_TextBox.Name = "SourcePath_TextBox"
        Me.SourcePath_TextBox.Size = New System.Drawing.Size(457, 22)
        Me.SourcePath_TextBox.TabIndex = 1
        Me.SourcePath_TextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.torrentfolder
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(775, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Set Font"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 426)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FileList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LibaryList)
        Me.SplitContainer1.Size = New System.Drawing.Size(1637, 533)
        Me.SplitContainer1.SplitterDistance = 743
        Me.SplitContainer1.TabIndex = 4
        '
        'LibaryList
        '
        Me.LibaryList.AllowUserToAddRows = False
        Me.LibaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibaryList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.LibaryFilePath, Me.filesizelibary})
        Me.LibaryList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibaryList.Location = New System.Drawing.Point(0, 0)
        Me.LibaryList.Name = "LibaryList"
        Me.LibaryList.ReadOnly = True
        Me.LibaryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibaryList.Size = New System.Drawing.Size(890, 533)
        Me.LibaryList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Full File Path"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "FileName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'LibaryFilePath
        '
        Me.LibaryFilePath.HeaderText = "File Path"
        Me.LibaryFilePath.Name = "LibaryFilePath"
        Me.LibaryFilePath.ReadOnly = True
        '
        'filesizelibary
        '
        Me.filesizelibary.HeaderText = "FileSize"
        Me.filesizelibary.Name = "filesizelibary"
        Me.filesizelibary.ReadOnly = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status, Me.fileslabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 959)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1637, 25)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(153, 20)
        Me.status.Text = "ToolStripStatusLabel1"
        '
        'fileslabel
        '
        Me.fileslabel.Name = "fileslabel"
        Me.fileslabel.Size = New System.Drawing.Size(153, 20)
        Me.fileslabel.Text = "ToolStripStatusLabel1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(21, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(748, 164)
        Me.ListBox1.TabIndex = 15
        '
        'Options_Panel
        '
        Me.Options_Panel.Controls.Add(Me.LinkLabel3)
        Me.Options_Panel.Controls.Add(Me.Button8)
        Me.Options_Panel.Controls.Add(Me.LinkLabel2)
        Me.Options_Panel.Controls.Add(Me.Label1)
        Me.Options_Panel.Controls.Add(Me.ListBox1)
        Me.Options_Panel.Controls.Add(Me.Button4)
        Me.Options_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Options_Panel.Location = New System.Drawing.Point(0, 189)
        Me.Options_Panel.Name = "Options_Panel"
        Me.Options_Panel.Size = New System.Drawing.Size(1637, 237)
        Me.Options_Panel.TabIndex = 6
        Me.Options_Panel.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(775, 34)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(123, 17)
        Me.LinkLabel3.TabIndex = 19
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Remove Selected."
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(778, 103)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(185, 23)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Save Favorites"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(208, 11)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(183, 17)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Source to selected."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "File Source Locations;"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1637, 984)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Options_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.LibaryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Options_Panel.ResumeLayout(False)
        Me.Options_Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileList As DataGridView
    Friend WithEvents SourcePath_TextBox As TextBox
    Friend WithEvents LoadSource_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status As ToolStripStatusLabel
    Friend WithEvents fileslabel As ToolStripStatusLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LoadLibary_Button As Button
    Friend WithEvents LibaryList As DataGridView
    Friend WithEvents LibaryPath As TextBox
    Friend WithEvents CheckDuplicate_Button As Button
    Friend WithEvents CopySelected As Button
    Friend WithEvents UnsortedFolderTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents FullFileName As DataGridViewTextBoxColumn
    Friend WithEvents FileName As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents unwanted As DataGridViewTextBoxColumn
    Friend WithEvents FilePath As DataGridViewTextBoxColumn
    Friend WithEvents DateCreated As DataGridViewTextBoxColumn
    Friend WithEvents filesize As DataGridViewTextBoxColumn
    Friend WithEvents InLibary As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LibaryFilePath As DataGridViewTextBoxColumn
    Friend WithEvents filesizelibary As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Options_Panel As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents HideDupes_Button As Button
End Class
