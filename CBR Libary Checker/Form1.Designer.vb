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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SourceLibary_DGV = New System.Windows.Forms.DataGridView()
        Me.FileIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathRelRootDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHA1HashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOURCELDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComicInfoDB = New CBR_Libary_Checker.ComicInfoDB()
        Me.Options_Panel = New System.Windows.Forms.Panel()
        Me.Options_FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Source_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Source_Browse_LL = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SourcePath_TextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Destination_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ShowCopy_CheckBox = New System.Windows.Forms.CheckBox()
        Me.UnsortedPathBRSR_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UnsortedFolderTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SourceToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LoadSource_Button = New System.Windows.Forms.ToolStripButton()
        Me.SourceLibary_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Scan_Options_ToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.HidePartial_Check = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideUnwanted_Check = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetHashesOnScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSource_Libary = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HideDupes_CHKButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullFilePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnwantedQtorrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateCreatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSizeMbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InLibaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Set_Font_Button = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetSourceHashes_Button = New System.Windows.Forms.ToolStripButton()
        Me.CheckUnique_Button = New System.Windows.Forms.ToolStripButton()
        Me.ClearSource_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Selection_Label = New System.Windows.Forms.ToolStripLabel()
        Me.LibaryList_DGV = New System.Windows.Forms.DataGridView()
        Me.FileIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullFileNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathRelRootDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreatedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileSizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHA1HashDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBARYDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.LoadLibary_Button = New System.Windows.Forms.ToolStripButton()
        Me.MainLibary_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.OpenDest_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearLibary_Button = New System.Windows.Forms.ToolStripButton()
        Me.GetLibaryHashes_Button = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CopyProgress_Label = New System.Windows.Forms.Label()
        Me.Copy_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.CopySelected = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.SourceLibary_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOURCELDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Options_Panel.SuspendLayout()
        Me.Options_FlowLayoutPanel.SuspendLayout()
        Me.Source_GroupBox.SuspendLayout()
        Me.Destination_GroupBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SourceToolStrip.SuspendLayout()
        CType(Me.LibaryList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SourceLibary_DGV
        '
        Me.SourceLibary_DGV.AllowUserToAddRows = False
        Me.SourceLibary_DGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SourceLibary_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SourceLibary_DGV.AutoGenerateColumns = False
        Me.SourceLibary_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SourceLibary_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SourceLibary_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileIDDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.FullFileNameDataGridViewTextBoxColumn, Me.FileTypeDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.PathRelRootDataGridViewTextBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn, Me.FileSizeDataGridViewTextBoxColumn, Me.SHA1HashDataGridViewTextBoxColumn, Me.UniqueStatusDataGridViewTextBoxColumn, Me.CopyStatusDataGridViewTextBoxColumn})
        Me.SourceLibary_DGV.DataSource = Me.SOURCELDBBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SourceLibary_DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.SourceLibary_DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceLibary_DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SourceLibary_DGV.Location = New System.Drawing.Point(0, 39)
        Me.SourceLibary_DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceLibary_DGV.Name = "SourceLibary_DGV"
        Me.SourceLibary_DGV.ReadOnly = True
        Me.SourceLibary_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SourceLibary_DGV.Size = New System.Drawing.Size(1427, 292)
        Me.SourceLibary_DGV.TabIndex = 0
        '
        'FileIDDataGridViewTextBoxColumn
        '
        Me.FileIDDataGridViewTextBoxColumn.DataPropertyName = "File ID"
        Me.FileIDDataGridViewTextBoxColumn.FillWeight = 79.47787!
        Me.FileIDDataGridViewTextBoxColumn.HeaderText = "File ID"
        Me.FileIDDataGridViewTextBoxColumn.Name = "FileIDDataGridViewTextBoxColumn"
        Me.FileIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileIDDataGridViewTextBoxColumn.Width = 59
        '
        'FileNameDataGridViewTextBoxColumn
        '
        Me.FileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "File Name"
        Me.FileNameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
        Me.FileNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullFileNameDataGridViewTextBoxColumn
        '
        Me.FullFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullFileNameDataGridViewTextBoxColumn.DataPropertyName = "Full File Name"
        Me.FullFileNameDataGridViewTextBoxColumn.HeaderText = "Full File Name"
        Me.FullFileNameDataGridViewTextBoxColumn.Name = "FullFileNameDataGridViewTextBoxColumn"
        Me.FullFileNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "File Type"
        Me.FileTypeDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "File Type"
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        Me.FileTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileTypeDataGridViewTextBoxColumn.Width = 88
        '
        'FilePathDataGridViewTextBoxColumn
        '
        Me.FilePathDataGridViewTextBoxColumn.DataPropertyName = "File Path"
        Me.FilePathDataGridViewTextBoxColumn.HeaderText = "File Path"
        Me.FilePathDataGridViewTextBoxColumn.Name = "FilePathDataGridViewTextBoxColumn"
        Me.FilePathDataGridViewTextBoxColumn.ReadOnly = True
        Me.FilePathDataGridViewTextBoxColumn.Visible = False
        Me.FilePathDataGridViewTextBoxColumn.Width = 92
        '
        'PathRelRootDataGridViewTextBoxColumn
        '
        Me.PathRelRootDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PathRelRootDataGridViewTextBoxColumn.DataPropertyName = "Path Rel Root"
        Me.PathRelRootDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.PathRelRootDataGridViewTextBoxColumn.HeaderText = "Libary Location"
        Me.PathRelRootDataGridViewTextBoxColumn.Name = "PathRelRootDataGridViewTextBoxColumn"
        Me.PathRelRootDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        Me.DateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateCreatedDataGridViewTextBoxColumn.Visible = False
        Me.DateCreatedDataGridViewTextBoxColumn.Width = 111
        '
        'FileSizeDataGridViewTextBoxColumn
        '
        Me.FileSizeDataGridViewTextBoxColumn.DataPropertyName = "File Size"
        DataGridViewCellStyle2.Format = "0.00"" Mb"""
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FileSizeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FileSizeDataGridViewTextBoxColumn.FillWeight = 65.0!
        Me.FileSizeDataGridViewTextBoxColumn.HeaderText = "File Size"
        Me.FileSizeDataGridViewTextBoxColumn.Name = "FileSizeDataGridViewTextBoxColumn"
        Me.FileSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileSizeDataGridViewTextBoxColumn.Width = 83
        '
        'SHA1HashDataGridViewTextBoxColumn
        '
        Me.SHA1HashDataGridViewTextBoxColumn.DataPropertyName = "SHA1 Hash"
        Me.SHA1HashDataGridViewTextBoxColumn.HeaderText = "SHA1 Hash"
        Me.SHA1HashDataGridViewTextBoxColumn.Name = "SHA1HashDataGridViewTextBoxColumn"
        Me.SHA1HashDataGridViewTextBoxColumn.ReadOnly = True
        Me.SHA1HashDataGridViewTextBoxColumn.Width = 101
        '
        'UniqueStatusDataGridViewTextBoxColumn
        '
        Me.UniqueStatusDataGridViewTextBoxColumn.DataPropertyName = "Unique Status"
        Me.UniqueStatusDataGridViewTextBoxColumn.HeaderText = "Unique Status"
        Me.UniqueStatusDataGridViewTextBoxColumn.Name = "UniqueStatusDataGridViewTextBoxColumn"
        Me.UniqueStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.UniqueStatusDataGridViewTextBoxColumn.Width = 116
        '
        'CopyStatusDataGridViewTextBoxColumn
        '
        Me.CopyStatusDataGridViewTextBoxColumn.DataPropertyName = "Copy Status"
        Me.CopyStatusDataGridViewTextBoxColumn.HeaderText = "Copy Status"
        Me.CopyStatusDataGridViewTextBoxColumn.Name = "CopyStatusDataGridViewTextBoxColumn"
        Me.CopyStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CopyStatusDataGridViewTextBoxColumn.Width = 104
        '
        'SOURCELDBBindingSource
        '
        Me.SOURCELDBBindingSource.DataMember = "SOURCEL_DB"
        Me.SOURCELDBBindingSource.DataSource = Me.ComicInfoDB
        '
        'ComicInfoDB
        '
        Me.ComicInfoDB.DataSetName = "ComicInfoDB"
        Me.ComicInfoDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Options_Panel
        '
        Me.Options_Panel.Controls.Add(Me.Options_FlowLayoutPanel)
        Me.Options_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Options_Panel.Location = New System.Drawing.Point(0, 25)
        Me.Options_Panel.Margin = New System.Windows.Forms.Padding(2)
        Me.Options_Panel.Name = "Options_Panel"
        Me.Options_Panel.Size = New System.Drawing.Size(1427, 136)
        Me.Options_Panel.TabIndex = 3
        '
        'Options_FlowLayoutPanel
        '
        Me.Options_FlowLayoutPanel.Controls.Add(Me.Source_GroupBox)
        Me.Options_FlowLayoutPanel.Controls.Add(Me.Destination_GroupBox)
        Me.Options_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Options_FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.Options_FlowLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.Options_FlowLayoutPanel.Name = "Options_FlowLayoutPanel"
        Me.Options_FlowLayoutPanel.Padding = New System.Windows.Forms.Padding(8)
        Me.Options_FlowLayoutPanel.Size = New System.Drawing.Size(1427, 136)
        Me.Options_FlowLayoutPanel.TabIndex = 21
        '
        'Source_GroupBox
        '
        Me.Source_GroupBox.Controls.Add(Me.Source_Browse_LL)
        Me.Source_GroupBox.Controls.Add(Me.Label2)
        Me.Source_GroupBox.Controls.Add(Me.SourcePath_TextBox)
        Me.Source_GroupBox.Controls.Add(Me.LinkLabel3)
        Me.Source_GroupBox.Controls.Add(Me.LinkLabel1)
        Me.Source_GroupBox.Controls.Add(Me.Label1)
        Me.Source_GroupBox.Controls.Add(Me.LinkLabel2)
        Me.Source_GroupBox.Controls.Add(Me.ListBox1)
        Me.Source_GroupBox.Location = New System.Drawing.Point(10, 10)
        Me.Source_GroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Source_GroupBox.Name = "Source_GroupBox"
        Me.Source_GroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.Source_GroupBox.Size = New System.Drawing.Size(629, 122)
        Me.Source_GroupBox.TabIndex = 20
        Me.Source_GroupBox.TabStop = False
        Me.Source_GroupBox.Text = "Source Folder"
        '
        'Source_Browse_LL
        '
        Me.Source_Browse_LL.AutoSize = True
        Me.Source_Browse_LL.Location = New System.Drawing.Point(218, 58)
        Me.Source_Browse_LL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Source_Browse_LL.Name = "Source_Browse_LL"
        Me.Source_Browse_LL.Size = New System.Drawing.Size(95, 13)
        Me.Source_Browse_LL.TabIndex = 21
        Me.Source_Browse_LL.TabStop = True
        Me.Source_Browse_LL.Text = "Browse for folder..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Source Folder Search Location:"
        '
        'SourcePath_TextBox
        '
        Me.SourcePath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "torrentfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SourcePath_TextBox.Location = New System.Drawing.Point(9, 37)
        Me.SourcePath_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SourcePath_TextBox.Name = "SourcePath_TextBox"
        Me.SourcePath_TextBox.Size = New System.Drawing.Size(305, 20)
        Me.SourcePath_TextBox.TabIndex = 1
        Me.SourcePath_TextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.torrentfolder
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(520, 99)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(95, 13)
        Me.LinkLabel3.TabIndex = 19
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Remove Selected."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(7, 58)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add Location to Favorites."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "File Source Locations;"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(462, 14)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(139, 13)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Source to selected."
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(322, 29)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(294, 69)
        Me.ListBox1.TabIndex = 15
        '
        'Destination_GroupBox
        '
        Me.Destination_GroupBox.Controls.Add(Me.ShowCopy_CheckBox)
        Me.Destination_GroupBox.Controls.Add(Me.UnsortedPathBRSR_LinkLabel)
        Me.Destination_GroupBox.Controls.Add(Me.Label4)
        Me.Destination_GroupBox.Controls.Add(Me.UnsortedFolderTextBox)
        Me.Destination_GroupBox.Location = New System.Drawing.Point(643, 10)
        Me.Destination_GroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Destination_GroupBox.Name = "Destination_GroupBox"
        Me.Destination_GroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.Destination_GroupBox.Size = New System.Drawing.Size(345, 122)
        Me.Destination_GroupBox.TabIndex = 21
        Me.Destination_GroupBox.TabStop = False
        Me.Destination_GroupBox.Text = "Destination Libary:"
        '
        'ShowCopy_CheckBox
        '
        Me.ShowCopy_CheckBox.AutoSize = True
        Me.ShowCopy_CheckBox.Location = New System.Drawing.Point(18, 60)
        Me.ShowCopy_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ShowCopy_CheckBox.Name = "ShowCopy_CheckBox"
        Me.ShowCopy_CheckBox.Size = New System.Drawing.Size(157, 17)
        Me.ShowCopy_CheckBox.TabIndex = 26
        Me.ShowCopy_CheckBox.Text = "Show Windows copy dialog"
        Me.ShowCopy_CheckBox.UseVisualStyleBackColor = True
        '
        'UnsortedPathBRSR_LinkLabel
        '
        Me.UnsortedPathBRSR_LinkLabel.AutoSize = True
        Me.UnsortedPathBRSR_LinkLabel.Location = New System.Drawing.Point(227, 57)
        Me.UnsortedPathBRSR_LinkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UnsortedPathBRSR_LinkLabel.Name = "UnsortedPathBRSR_LinkLabel"
        Me.UnsortedPathBRSR_LinkLabel.Size = New System.Drawing.Size(95, 13)
        Me.UnsortedPathBRSR_LinkLabel.TabIndex = 25
        Me.UnsortedPathBRSR_LinkLabel.TabStop = True
        Me.UnsortedPathBRSR_LinkLabel.Text = "Browse for folder..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Unsorted (Copy To) Folder Location:"
        '
        'UnsortedFolderTextBox
        '
        Me.UnsortedFolderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "unsortedfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UnsortedFolderTextBox.Location = New System.Drawing.Point(18, 37)
        Me.UnsortedFolderTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UnsortedFolderTextBox.Name = "UnsortedFolderTextBox"
        Me.UnsortedFolderTextBox.Size = New System.Drawing.Size(305, 20)
        Me.UnsortedFolderTextBox.TabIndex = 8
        Me.UnsortedFolderTextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.unsortedfolder
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 834)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1427, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(277, 17)
        Me.status.Text = "Josh Cronin. 2017. CBR Libary Downloads Manager."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 161)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SourceLibary_DGV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SourceToolStrip)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LibaryList_DGV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1427, 673)
        Me.SplitContainer1.SplitterDistance = 331
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 6
        '
        'SourceToolStrip
        '
        Me.SourceToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SourceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadSource_Button, Me.SourceLibary_ProgressBar, Me.Scan_Options_ToolStripSplitButton, Me.OpenSource_Libary, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator2, Me.GetSourceHashes_Button, Me.CheckUnique_Button, Me.ClearSource_Button, Me.ToolStripSeparator3, Me.Selection_Label})
        Me.SourceToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.SourceToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SourceToolStrip.Name = "SourceToolStrip"
        Me.SourceToolStrip.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SourceToolStrip.Size = New System.Drawing.Size(1427, 39)
        Me.SourceToolStrip.TabIndex = 1
        Me.SourceToolStrip.Text = "ToolStrip3"
        '
        'LoadSource_Button
        '
        Me.LoadSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadSource_Button.Name = "LoadSource_Button"
        Me.LoadSource_Button.Size = New System.Drawing.Size(131, 24)
        Me.LoadSource_Button.Text = "Load Source Libary"
        '
        'SourceLibary_ProgressBar
        '
        Me.SourceLibary_ProgressBar.Name = "SourceLibary_ProgressBar"
        Me.SourceLibary_ProgressBar.Size = New System.Drawing.Size(150, 20)
        '
        'Scan_Options_ToolStripSplitButton
        '
        Me.Scan_Options_ToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HidePartial_Check, Me.HideUnwanted_Check, Me.ToolStripMenuItem3, Me.GetHashesOnScanToolStripMenuItem})
        Me.Scan_Options_ToolStripSplitButton.Image = CType(resources.GetObject("Scan_Options_ToolStripSplitButton.Image"), System.Drawing.Image)
        Me.Scan_Options_ToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Scan_Options_ToolStripSplitButton.Name = "Scan_Options_ToolStripSplitButton"
        Me.Scan_Options_ToolStripSplitButton.Size = New System.Drawing.Size(113, 24)
        Me.Scan_Options_ToolStripSplitButton.Text = "Scan Options"
        '
        'HidePartial_Check
        '
        Me.HidePartial_Check.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HidePartial
        Me.HidePartial_Check.CheckOnClick = True
        Me.HidePartial_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HidePartial_Check.Name = "HidePartial_Check"
        Me.HidePartial_Check.Size = New System.Drawing.Size(241, 22)
        Me.HidePartial_Check.Text = "Hide QTorrent Partial Files (.qb!)"
        '
        'HideUnwanted_Check
        '
        Me.HideUnwanted_Check.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HideUnwanted
        Me.HideUnwanted_Check.CheckOnClick = True
        Me.HideUnwanted_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HideUnwanted_Check.Name = "HideUnwanted_Check"
        Me.HideUnwanted_Check.Size = New System.Drawing.Size(241, 22)
        Me.HideUnwanted_Check.Text = "Hide Qtorrent .Unwanted Files"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(238, 6)
        '
        'GetHashesOnScanToolStripMenuItem
        '
        Me.GetHashesOnScanToolStripMenuItem.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.Source_GetHashes
        Me.GetHashesOnScanToolStripMenuItem.CheckOnClick = True
        Me.GetHashesOnScanToolStripMenuItem.Name = "GetHashesOnScanToolStripMenuItem"
        Me.GetHashesOnScanToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.GetHashesOnScanToolStripMenuItem.Text = "Get Hashes on Scan"
        '
        'OpenSource_Libary
        '
        Me.OpenSource_Libary.Image = Global.CBR_Libary_Checker.My.Resources.Resources.download
        Me.OpenSource_Libary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenSource_Libary.Name = "OpenSource_Libary"
        Me.OpenSource_Libary.Size = New System.Drawing.Size(170, 24)
        Me.OpenSource_Libary.Text = "View Selected in Explorer..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideDupes_CHKButton, Me.ToolStripMenuItem1, Me.ColumnsToolStripMenuItem, Me.FullFilePathToolStripMenuItem, Me.FileNameToolStripMenuItem, Me.FileTypeToolStripMenuItem, Me.UnwantedQtorrentToolStripMenuItem, Me.FolderPathToolStripMenuItem, Me.DateCreatedToolStripMenuItem, Me.FileSizeMbToolStripMenuItem, Me.InLibaryToolStripMenuItem, Me.ToolStripMenuItem2, Me.Set_Font_Button})
        Me.ToolStripDropDownButton1.Image = Global.CBR_Libary_Checker.My.Resources.Resources.eye_24_256
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(33, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'HideDupes_CHKButton
        '
        Me.HideDupes_CHKButton.CheckOnClick = True
        Me.HideDupes_CHKButton.Name = "HideDupes_CHKButton"
        Me.HideDupes_CHKButton.Size = New System.Drawing.Size(246, 22)
        Me.HideDupes_CHKButton.Text = "Hide Files Already in Main Libary"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(243, 6)
        '
        'ColumnsToolStripMenuItem
        '
        Me.ColumnsToolStripMenuItem.Name = "ColumnsToolStripMenuItem"
        Me.ColumnsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ColumnsToolStripMenuItem.Text = "Columns:"
        '
        'FullFilePathToolStripMenuItem
        '
        Me.FullFilePathToolStripMenuItem.Checked = True
        Me.FullFilePathToolStripMenuItem.CheckOnClick = True
        Me.FullFilePathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FullFilePathToolStripMenuItem.Name = "FullFilePathToolStripMenuItem"
        Me.FullFilePathToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.FullFilePathToolStripMenuItem.Text = "Full File Path"
        '
        'FileNameToolStripMenuItem
        '
        Me.FileNameToolStripMenuItem.Checked = True
        Me.FileNameToolStripMenuItem.CheckOnClick = True
        Me.FileNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileNameToolStripMenuItem.Name = "FileNameToolStripMenuItem"
        Me.FileNameToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.FileNameToolStripMenuItem.Text = "File Name"
        '
        'FileTypeToolStripMenuItem
        '
        Me.FileTypeToolStripMenuItem.Checked = True
        Me.FileTypeToolStripMenuItem.CheckOnClick = True
        Me.FileTypeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileTypeToolStripMenuItem.Name = "FileTypeToolStripMenuItem"
        Me.FileTypeToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.FileTypeToolStripMenuItem.Text = "File Type"
        '
        'UnwantedQtorrentToolStripMenuItem
        '
        Me.UnwantedQtorrentToolStripMenuItem.Checked = True
        Me.UnwantedQtorrentToolStripMenuItem.CheckOnClick = True
        Me.UnwantedQtorrentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UnwantedQtorrentToolStripMenuItem.Name = "UnwantedQtorrentToolStripMenuItem"
        Me.UnwantedQtorrentToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.UnwantedQtorrentToolStripMenuItem.Text = "Unwanted (Qtorrent)"
        '
        'FolderPathToolStripMenuItem
        '
        Me.FolderPathToolStripMenuItem.Checked = True
        Me.FolderPathToolStripMenuItem.CheckOnClick = True
        Me.FolderPathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FolderPathToolStripMenuItem.Name = "FolderPathToolStripMenuItem"
        Me.FolderPathToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.FolderPathToolStripMenuItem.Text = "Folder Path"
        '
        'DateCreatedToolStripMenuItem
        '
        Me.DateCreatedToolStripMenuItem.Checked = True
        Me.DateCreatedToolStripMenuItem.CheckOnClick = True
        Me.DateCreatedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DateCreatedToolStripMenuItem.Name = "DateCreatedToolStripMenuItem"
        Me.DateCreatedToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.DateCreatedToolStripMenuItem.Text = "Date Created"
        '
        'FileSizeMbToolStripMenuItem
        '
        Me.FileSizeMbToolStripMenuItem.Checked = True
        Me.FileSizeMbToolStripMenuItem.CheckOnClick = True
        Me.FileSizeMbToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileSizeMbToolStripMenuItem.Name = "FileSizeMbToolStripMenuItem"
        Me.FileSizeMbToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.FileSizeMbToolStripMenuItem.Text = "File Size (Mb)"
        '
        'InLibaryToolStripMenuItem
        '
        Me.InLibaryToolStripMenuItem.Checked = True
        Me.InLibaryToolStripMenuItem.CheckOnClick = True
        Me.InLibaryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InLibaryToolStripMenuItem.Name = "InLibaryToolStripMenuItem"
        Me.InLibaryToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.InLibaryToolStripMenuItem.Text = "In Libary"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(243, 6)
        '
        'Set_Font_Button
        '
        Me.Set_Font_Button.Name = "Set_Font_Button"
        Me.Set_Font_Button.Size = New System.Drawing.Size(246, 22)
        Me.Set_Font_Button.Text = "Set File Lists Font"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'GetSourceHashes_Button
        '
        Me.GetSourceHashes_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.hash_512
        Me.GetSourceHashes_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetSourceHashes_Button.Name = "GetSourceHashes_Button"
        Me.GetSourceHashes_Button.Size = New System.Drawing.Size(90, 24)
        Me.GetSourceHashes_Button.Text = "Get Hashes"
        '
        'CheckUnique_Button
        '
        Me.CheckUnique_Button.Enabled = False
        Me.CheckUnique_Button.ForeColor = System.Drawing.Color.Blue
        Me.CheckUnique_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.compare_balance_512
        Me.CheckUnique_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckUnique_Button.Name = "CheckUnique_Button"
        Me.CheckUnique_Button.Size = New System.Drawing.Size(157, 24)
        Me.CheckUnique_Button.Text = "Check Unique in Source"
        '
        'ClearSource_Button
        '
        Me.ClearSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ClearSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearSource_Button.Name = "ClearSource_Button"
        Me.ClearSource_Button.Size = New System.Drawing.Size(79, 24)
        Me.ClearSource_Button.Text = "Clear List"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'Selection_Label
        '
        Me.Selection_Label.Name = "Selection_Label"
        Me.Selection_Label.Size = New System.Drawing.Size(86, 15)
        Me.Selection_Label.Text = "None Selected."
        '
        'LibaryList_DGV
        '
        Me.LibaryList_DGV.AllowUserToAddRows = False
        Me.LibaryList_DGV.AutoGenerateColumns = False
        Me.LibaryList_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.LibaryList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibaryList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileIDDataGridViewTextBoxColumn1, Me.FileNameDataGridViewTextBoxColumn1, Me.FullFileNameDataGridViewTextBoxColumn1, Me.FileTypeDataGridViewTextBoxColumn1, Me.FilePathDataGridViewTextBoxColumn1, Me.PathRelRootDataGridViewTextBoxColumn1, Me.DateCreatedDataGridViewTextBoxColumn1, Me.FileSizeDataGridViewTextBoxColumn1, Me.SHA1HashDataGridViewTextBoxColumn1, Me.UniqueStatusDataGridViewTextBoxColumn1, Me.CopyStatusDataGridViewTextBoxColumn1})
        Me.LibaryList_DGV.DataSource = Me.LIBARYDBBindingSource
        Me.LibaryList_DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibaryList_DGV.Location = New System.Drawing.Point(0, 68)
        Me.LibaryList_DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.LibaryList_DGV.Name = "LibaryList_DGV"
        Me.LibaryList_DGV.RowTemplate.Height = 24
        Me.LibaryList_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibaryList_DGV.Size = New System.Drawing.Size(1427, 271)
        Me.LibaryList_DGV.TabIndex = 4
        '
        'FileIDDataGridViewTextBoxColumn1
        '
        Me.FileIDDataGridViewTextBoxColumn1.DataPropertyName = "File ID"
        Me.FileIDDataGridViewTextBoxColumn1.HeaderText = "File ID"
        Me.FileIDDataGridViewTextBoxColumn1.Name = "FileIDDataGridViewTextBoxColumn1"
        '
        'FileNameDataGridViewTextBoxColumn1
        '
        Me.FileNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FileNameDataGridViewTextBoxColumn1.DataPropertyName = "File Name"
        Me.FileNameDataGridViewTextBoxColumn1.HeaderText = "File Name"
        Me.FileNameDataGridViewTextBoxColumn1.Name = "FileNameDataGridViewTextBoxColumn1"
        '
        'FullFileNameDataGridViewTextBoxColumn1
        '
        Me.FullFileNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullFileNameDataGridViewTextBoxColumn1.DataPropertyName = "Full File Name"
        Me.FullFileNameDataGridViewTextBoxColumn1.HeaderText = "Full File Name"
        Me.FullFileNameDataGridViewTextBoxColumn1.Name = "FullFileNameDataGridViewTextBoxColumn1"
        '
        'FileTypeDataGridViewTextBoxColumn1
        '
        Me.FileTypeDataGridViewTextBoxColumn1.DataPropertyName = "File Type"
        Me.FileTypeDataGridViewTextBoxColumn1.HeaderText = "File Type"
        Me.FileTypeDataGridViewTextBoxColumn1.Name = "FileTypeDataGridViewTextBoxColumn1"
        '
        'FilePathDataGridViewTextBoxColumn1
        '
        Me.FilePathDataGridViewTextBoxColumn1.DataPropertyName = "File Path"
        Me.FilePathDataGridViewTextBoxColumn1.HeaderText = "File Path"
        Me.FilePathDataGridViewTextBoxColumn1.Name = "FilePathDataGridViewTextBoxColumn1"
        '
        'PathRelRootDataGridViewTextBoxColumn1
        '
        Me.PathRelRootDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PathRelRootDataGridViewTextBoxColumn1.DataPropertyName = "Path Rel Root"
        Me.PathRelRootDataGridViewTextBoxColumn1.HeaderText = "Path Rel Root"
        Me.PathRelRootDataGridViewTextBoxColumn1.Name = "PathRelRootDataGridViewTextBoxColumn1"
        '
        'DateCreatedDataGridViewTextBoxColumn1
        '
        Me.DateCreatedDataGridViewTextBoxColumn1.DataPropertyName = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn1.HeaderText = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn1.Name = "DateCreatedDataGridViewTextBoxColumn1"
        '
        'FileSizeDataGridViewTextBoxColumn1
        '
        Me.FileSizeDataGridViewTextBoxColumn1.DataPropertyName = "File Size"
        DataGridViewCellStyle4.Format = "0.00"" Mb"""
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FileSizeDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.FileSizeDataGridViewTextBoxColumn1.HeaderText = "File Size"
        Me.FileSizeDataGridViewTextBoxColumn1.Name = "FileSizeDataGridViewTextBoxColumn1"
        '
        'SHA1HashDataGridViewTextBoxColumn1
        '
        Me.SHA1HashDataGridViewTextBoxColumn1.DataPropertyName = "SHA1 Hash"
        Me.SHA1HashDataGridViewTextBoxColumn1.HeaderText = "SHA1 Hash"
        Me.SHA1HashDataGridViewTextBoxColumn1.Name = "SHA1HashDataGridViewTextBoxColumn1"
        '
        'UniqueStatusDataGridViewTextBoxColumn1
        '
        Me.UniqueStatusDataGridViewTextBoxColumn1.DataPropertyName = "Unique Status"
        Me.UniqueStatusDataGridViewTextBoxColumn1.HeaderText = "Unique Status"
        Me.UniqueStatusDataGridViewTextBoxColumn1.Name = "UniqueStatusDataGridViewTextBoxColumn1"
        '
        'CopyStatusDataGridViewTextBoxColumn1
        '
        Me.CopyStatusDataGridViewTextBoxColumn1.DataPropertyName = "Copy Status"
        Me.CopyStatusDataGridViewTextBoxColumn1.HeaderText = "Copy Status"
        Me.CopyStatusDataGridViewTextBoxColumn1.Name = "CopyStatusDataGridViewTextBoxColumn1"
        '
        'LIBARYDBBindingSource
        '
        Me.LIBARYDBBindingSource.DataMember = "LIBARY_DB"
        Me.LIBARYDBBindingSource.DataSource = Me.ComicInfoDB
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadLibary_Button, Me.MainLibary_ProgressBar, Me.OpenDest_ToolStripButton, Me.ClearLibary_Button, Me.GetLibaryHashes_Button})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ToolStrip2.Size = New System.Drawing.Size(1427, 39)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'LoadLibary_Button
        '
        Me.LoadLibary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadLibary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadLibary_Button.Name = "LoadLibary_Button"
        Me.LoadLibary_Button.Size = New System.Drawing.Size(122, 24)
        Me.LoadLibary_Button.Text = "Load Main Libary"
        '
        'MainLibary_ProgressBar
        '
        Me.MainLibary_ProgressBar.Name = "MainLibary_ProgressBar"
        Me.MainLibary_ProgressBar.Size = New System.Drawing.Size(150, 20)
        '
        'OpenDest_ToolStripButton
        '
        Me.OpenDest_ToolStripButton.Image = Global.CBR_Libary_Checker.My.Resources.Resources.download
        Me.OpenDest_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenDest_ToolStripButton.Name = "OpenDest_ToolStripButton"
        Me.OpenDest_ToolStripButton.Size = New System.Drawing.Size(170, 24)
        Me.OpenDest_ToolStripButton.Text = "View Selected in Explorer..."
        '
        'ClearLibary_Button
        '
        Me.ClearLibary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ClearLibary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearLibary_Button.Name = "ClearLibary_Button"
        Me.ClearLibary_Button.Size = New System.Drawing.Size(79, 24)
        Me.ClearLibary_Button.Text = "Clear List"
        '
        'GetLibaryHashes_Button
        '
        Me.GetLibaryHashes_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.hash_512
        Me.GetLibaryHashes_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetLibaryHashes_Button.Name = "GetLibaryHashes_Button"
        Me.GetLibaryHashes_Button.Size = New System.Drawing.Size(90, 24)
        Me.GetLibaryHashes_Button.Text = "Get Hashes"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CopyProgress_Label)
        Me.Panel2.Controls.Add(Me.Copy_ProgressBar)
        Me.Panel2.Controls.Add(Me.CopySelected)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1427, 29)
        Me.Panel2.TabIndex = 3
        '
        'CopyProgress_Label
        '
        Me.CopyProgress_Label.AutoSize = True
        Me.CopyProgress_Label.BackColor = System.Drawing.Color.Transparent
        Me.CopyProgress_Label.ForeColor = System.Drawing.Color.Lime
        Me.CopyProgress_Label.Location = New System.Drawing.Point(491, 8)
        Me.CopyProgress_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CopyProgress_Label.Name = "CopyProgress_Label"
        Me.CopyProgress_Label.Size = New System.Drawing.Size(39, 13)
        Me.CopyProgress_Label.TabIndex = 9
        Me.CopyProgress_Label.Text = "Label5"
        Me.CopyProgress_Label.Visible = False
        '
        'Copy_ProgressBar
        '
        Me.Copy_ProgressBar.Location = New System.Drawing.Point(314, 5)
        Me.Copy_ProgressBar.Margin = New System.Windows.Forms.Padding(2)
        Me.Copy_ProgressBar.Name = "Copy_ProgressBar"
        Me.Copy_ProgressBar.Size = New System.Drawing.Size(172, 19)
        Me.Copy_ProgressBar.TabIndex = 8
        '
        'CopySelected
        '
        Me.CopySelected.Enabled = False
        Me.CopySelected.Location = New System.Drawing.Point(105, 2)
        Me.CopySelected.Margin = New System.Windows.Forms.Padding(2)
        Me.CopySelected.Name = "CopySelected"
        Me.CopySelected.Size = New System.Drawing.Size(205, 24)
        Me.CopySelected.TabIndex = 7
        Me.CopySelected.Text = "Copy Selected Comics to unsorted folder"
        Me.CopySelected.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1427, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Close Tab"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 856)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Options_Panel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SourceLibary_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOURCELDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Options_Panel.ResumeLayout(False)
        Me.Options_FlowLayoutPanel.ResumeLayout(False)
        Me.Source_GroupBox.ResumeLayout(False)
        Me.Source_GroupBox.PerformLayout()
        Me.Destination_GroupBox.ResumeLayout(False)
        Me.Destination_GroupBox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SourceToolStrip.ResumeLayout(False)
        Me.SourceToolStrip.PerformLayout()
        CType(Me.LibaryList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SourceLibary_DGV As DataGridView
    Friend WithEvents SourcePath_TextBox As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status As ToolStripStatusLabel
    Friend WithEvents CopySelected As Button
    Friend WithEvents UnsortedFolderTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Options_Panel As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SourceToolStrip As ToolStrip
    Friend WithEvents LoadSource_Button As ToolStripButton
    Friend WithEvents SourceLibary_ProgressBar As ToolStripProgressBar
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents LoadLibary_Button As ToolStripButton
    Friend WithEvents MainLibary_ProgressBar As ToolStripProgressBar
    Friend WithEvents Scan_Options_ToolStripSplitButton As ToolStripSplitButton
    Friend WithEvents HidePartial_Check As ToolStripMenuItem
    Friend WithEvents HideUnwanted_Check As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Options_FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Source_GroupBox As GroupBox
    Friend WithEvents Destination_GroupBox As GroupBox
    Friend WithEvents OpenSource_Libary As ToolStripButton
    Friend WithEvents OpenDest_ToolStripButton As ToolStripButton
    Friend WithEvents Copy_ProgressBar As ProgressBar
    Friend WithEvents Source_Browse_LL As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents HideDupes_CHKButton As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullFilePathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnwantedQtorrentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateCreatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileSizeMbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InLibaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnsortedPathBRSR_LinkLabel As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents Set_Font_Button As ToolStripMenuItem
    Friend WithEvents ShowCopy_CheckBox As CheckBox
    Friend WithEvents CopyProgress_Label As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CheckUnique_Button As ToolStripButton
    Friend WithEvents ClearSource_Button As ToolStripButton
    Friend WithEvents ClearLibary_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Selection_Label As ToolStripLabel
    Friend WithEvents GetLibaryHashes_Button As ToolStripButton
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents GetHashesOnScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetSourceHashes_Button As ToolStripButton
    Friend WithEvents SOURCELDBBindingSource As BindingSource
    Friend WithEvents ComicInfoDB As ComicInfoDB
    Friend WithEvents LIBARYDBBindingSource As BindingSource
    Friend WithEvents LibaryList_DGV As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents FileIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullFileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PathRelRootDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHA1HashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniqueStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CopyStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FullFileNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FileTypeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PathRelRootDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FileSizeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SHA1HashDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UniqueStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CopyStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
