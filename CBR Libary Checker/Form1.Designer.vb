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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SOURCELDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComicInfoDB = New CBR_Libary_Checker.ComicInfoDB()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Copy_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.DGVsSplitContainer = New System.Windows.Forms.SplitContainer()
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
        Me.CheckUnique_Button = New System.Windows.Forms.ToolStripButton()
        Me.ClearSource_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GetSourceHashes_Button = New System.Windows.Forms.ToolStripButton()
        Me.CopySelected_Button = New System.Windows.Forms.ToolStripButton()
        Me.Selection_Label = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DestinationFolder_TextBox = New System.Windows.Forms.TextBox()
        Me.UnsortedPathBRSR_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LibraryList_DGV = New System.Windows.Forms.DataGridView()
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
        Me.MainLibrary_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.OpenDest_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearLibary_Button = New System.Windows.Forms.ToolStripButton()
        Me.GetLibaryHashes_Button = New System.Windows.Forms.ToolStripButton()
        Me.Main_SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FolderTreeViewToolStrip = New System.Windows.Forms.ToolStrip()
        Me.RefreshFolderList_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewFolder_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SourcePath_ComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.BrowseSource_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToFave_Button = New System.Windows.Forms.ToolStripButton()
        Me.NodeContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetThisFolderAsCopyDestinationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoadThisFolderInLibraryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ListView_ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SOURCELDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVsSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVsSplitContainer.Panel1.SuspendLayout()
        Me.DGVsSplitContainer.Panel2.SuspendLayout()
        Me.DGVsSplitContainer.SuspendLayout()
        CType(Me.SourceLibary_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SourceToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LibraryList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.Main_SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_SplitContainer.Panel1.SuspendLayout()
        Me.Main_SplitContainer.Panel2.SuspendLayout()
        Me.Main_SplitContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FolderTreeViewToolStrip.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.NodeContextMenuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status, Me.ToolStripStatusLabel1, Me.status2, Me.ToolStripStatusLabel2, Me.Copy_ProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1150)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1849, 29)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(346, 24)
        Me.status.Text = "Josh Cronin. 2017. CBR Libary Downloads Manager."
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 24)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'status2
        '
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(0, 24)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(94, 24)
        Me.ToolStripStatusLabel2.Text = "Copy Status: "
        '
        'Copy_ProgressBar
        '
        Me.Copy_ProgressBar.Name = "Copy_ProgressBar"
        Me.Copy_ProgressBar.Size = New System.Drawing.Size(251, 23)
        '
        'DGVsSplitContainer
        '
        Me.DGVsSplitContainer.BackColor = System.Drawing.Color.DimGray
        Me.DGVsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVsSplitContainer.Location = New System.Drawing.Point(0, 35)
        Me.DGVsSplitContainer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGVsSplitContainer.Name = "DGVsSplitContainer"
        Me.DGVsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'DGVsSplitContainer.Panel1
        '
        Me.DGVsSplitContainer.Panel1.Controls.Add(Me.SourceLibary_DGV)
        Me.DGVsSplitContainer.Panel1.Controls.Add(Me.SourceToolStrip)
        Me.DGVsSplitContainer.Panel1.Controls.Add(Me.Panel1)
        '
        'DGVsSplitContainer.Panel2
        '
        Me.DGVsSplitContainer.Panel2.Controls.Add(Me.LibraryList_DGV)
        Me.DGVsSplitContainer.Panel2.Controls.Add(Me.ToolStrip2)
        Me.DGVsSplitContainer.Size = New System.Drawing.Size(1421, 1088)
        Me.DGVsSplitContainer.SplitterDistance = 501
        Me.DGVsSplitContainer.SplitterWidth = 11
        Me.DGVsSplitContainer.TabIndex = 6
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
        Me.SourceLibary_DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceLibary_DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SourceLibary_DGV.Location = New System.Drawing.Point(0, 72)
        Me.SourceLibary_DGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SourceLibary_DGV.Name = "SourceLibary_DGV"
        Me.SourceLibary_DGV.ReadOnly = True
        Me.SourceLibary_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SourceLibary_DGV.Size = New System.Drawing.Size(1421, 384)
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
        'SourceToolStrip
        '
        Me.SourceToolStrip.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SourceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadSource_Button, Me.SourceLibary_ProgressBar, Me.Scan_Options_ToolStripSplitButton, Me.OpenSource_Libary, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator2, Me.CheckUnique_Button, Me.ClearSource_Button, Me.ToolStripSeparator3, Me.GetSourceHashes_Button, Me.CopySelected_Button, Me.Selection_Label})
        Me.SourceToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.SourceToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SourceToolStrip.Name = "SourceToolStrip"
        Me.SourceToolStrip.Padding = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.SourceToolStrip.Size = New System.Drawing.Size(1421, 72)
        Me.SourceToolStrip.TabIndex = 1
        Me.SourceToolStrip.Text = "ToolStrip3"
        '
        'LoadSource_Button
        '
        Me.LoadSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadSource_Button.Name = "LoadSource_Button"
        Me.LoadSource_Button.Size = New System.Drawing.Size(149, 24)
        Me.LoadSource_Button.Text = "Load Source Libary"
        '
        'SourceLibary_ProgressBar
        '
        Me.SourceLibary_ProgressBar.Name = "SourceLibary_ProgressBar"
        Me.SourceLibary_ProgressBar.Size = New System.Drawing.Size(200, 27)
        '
        'Scan_Options_ToolStripSplitButton
        '
        Me.Scan_Options_ToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HidePartial_Check, Me.HideUnwanted_Check, Me.ToolStripMenuItem3, Me.GetHashesOnScanToolStripMenuItem})
        Me.Scan_Options_ToolStripSplitButton.Image = CType(resources.GetObject("Scan_Options_ToolStripSplitButton.Image"), System.Drawing.Image)
        Me.Scan_Options_ToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Scan_Options_ToolStripSplitButton.Name = "Scan_Options_ToolStripSplitButton"
        Me.Scan_Options_ToolStripSplitButton.Size = New System.Drawing.Size(128, 24)
        Me.Scan_Options_ToolStripSplitButton.Text = "Scan Options"
        '
        'HidePartial_Check
        '
        Me.HidePartial_Check.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HidePartial
        Me.HidePartial_Check.CheckOnClick = True
        Me.HidePartial_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HidePartial_Check.Name = "HidePartial_Check"
        Me.HidePartial_Check.Size = New System.Drawing.Size(278, 26)
        Me.HidePartial_Check.Text = "Hide QTorrent Partial Files (.qb!)"
        '
        'HideUnwanted_Check
        '
        Me.HideUnwanted_Check.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HideUnwanted
        Me.HideUnwanted_Check.CheckOnClick = True
        Me.HideUnwanted_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HideUnwanted_Check.Name = "HideUnwanted_Check"
        Me.HideUnwanted_Check.Size = New System.Drawing.Size(278, 26)
        Me.HideUnwanted_Check.Text = "Hide Qtorrent .Unwanted Files"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(275, 6)
        '
        'GetHashesOnScanToolStripMenuItem
        '
        Me.GetHashesOnScanToolStripMenuItem.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.Source_GetHashes
        Me.GetHashesOnScanToolStripMenuItem.CheckOnClick = True
        Me.GetHashesOnScanToolStripMenuItem.Name = "GetHashesOnScanToolStripMenuItem"
        Me.GetHashesOnScanToolStripMenuItem.Size = New System.Drawing.Size(278, 26)
        Me.GetHashesOnScanToolStripMenuItem.Text = "Get Hashes on Scan"
        '
        'OpenSource_Libary
        '
        Me.OpenSource_Libary.Image = Global.CBR_Libary_Checker.My.Resources.Resources.download
        Me.OpenSource_Libary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenSource_Libary.Name = "OpenSource_Libary"
        Me.OpenSource_Libary.Size = New System.Drawing.Size(202, 24)
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
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'HideDupes_CHKButton
        '
        Me.HideDupes_CHKButton.Name = "HideDupes_CHKButton"
        Me.HideDupes_CHKButton.Size = New System.Drawing.Size(279, 26)
        Me.HideDupes_CHKButton.Text = "Hide Files Already in Main Libary"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(276, 6)
        '
        'ColumnsToolStripMenuItem
        '
        Me.ColumnsToolStripMenuItem.Name = "ColumnsToolStripMenuItem"
        Me.ColumnsToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.ColumnsToolStripMenuItem.Text = "Columns:"
        '
        'FullFilePathToolStripMenuItem
        '
        Me.FullFilePathToolStripMenuItem.Checked = True
        Me.FullFilePathToolStripMenuItem.CheckOnClick = True
        Me.FullFilePathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FullFilePathToolStripMenuItem.Enabled = False
        Me.FullFilePathToolStripMenuItem.Name = "FullFilePathToolStripMenuItem"
        Me.FullFilePathToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.FullFilePathToolStripMenuItem.Text = "Full File Path"
        '
        'FileNameToolStripMenuItem
        '
        Me.FileNameToolStripMenuItem.Checked = True
        Me.FileNameToolStripMenuItem.CheckOnClick = True
        Me.FileNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileNameToolStripMenuItem.Enabled = False
        Me.FileNameToolStripMenuItem.Name = "FileNameToolStripMenuItem"
        Me.FileNameToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.FileNameToolStripMenuItem.Text = "File Name"
        '
        'FileTypeToolStripMenuItem
        '
        Me.FileTypeToolStripMenuItem.Checked = True
        Me.FileTypeToolStripMenuItem.CheckOnClick = True
        Me.FileTypeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileTypeToolStripMenuItem.Enabled = False
        Me.FileTypeToolStripMenuItem.Name = "FileTypeToolStripMenuItem"
        Me.FileTypeToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.FileTypeToolStripMenuItem.Text = "File Type"
        '
        'UnwantedQtorrentToolStripMenuItem
        '
        Me.UnwantedQtorrentToolStripMenuItem.Checked = True
        Me.UnwantedQtorrentToolStripMenuItem.CheckOnClick = True
        Me.UnwantedQtorrentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UnwantedQtorrentToolStripMenuItem.Enabled = False
        Me.UnwantedQtorrentToolStripMenuItem.Name = "UnwantedQtorrentToolStripMenuItem"
        Me.UnwantedQtorrentToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.UnwantedQtorrentToolStripMenuItem.Text = "Unwanted (Qtorrent)"
        '
        'FolderPathToolStripMenuItem
        '
        Me.FolderPathToolStripMenuItem.Checked = True
        Me.FolderPathToolStripMenuItem.CheckOnClick = True
        Me.FolderPathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FolderPathToolStripMenuItem.Enabled = False
        Me.FolderPathToolStripMenuItem.Name = "FolderPathToolStripMenuItem"
        Me.FolderPathToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.FolderPathToolStripMenuItem.Text = "Folder Path"
        '
        'DateCreatedToolStripMenuItem
        '
        Me.DateCreatedToolStripMenuItem.Checked = True
        Me.DateCreatedToolStripMenuItem.CheckOnClick = True
        Me.DateCreatedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DateCreatedToolStripMenuItem.Enabled = False
        Me.DateCreatedToolStripMenuItem.Name = "DateCreatedToolStripMenuItem"
        Me.DateCreatedToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.DateCreatedToolStripMenuItem.Text = "Date Created"
        '
        'FileSizeMbToolStripMenuItem
        '
        Me.FileSizeMbToolStripMenuItem.Checked = True
        Me.FileSizeMbToolStripMenuItem.CheckOnClick = True
        Me.FileSizeMbToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileSizeMbToolStripMenuItem.Enabled = False
        Me.FileSizeMbToolStripMenuItem.Name = "FileSizeMbToolStripMenuItem"
        Me.FileSizeMbToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.FileSizeMbToolStripMenuItem.Text = "File Size (Mb)"
        '
        'InLibaryToolStripMenuItem
        '
        Me.InLibaryToolStripMenuItem.Checked = True
        Me.InLibaryToolStripMenuItem.CheckOnClick = True
        Me.InLibaryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InLibaryToolStripMenuItem.Enabled = False
        Me.InLibaryToolStripMenuItem.Name = "InLibaryToolStripMenuItem"
        Me.InLibaryToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.InLibaryToolStripMenuItem.Text = "In Libary"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(276, 6)
        '
        'Set_Font_Button
        '
        Me.Set_Font_Button.Name = "Set_Font_Button"
        Me.Set_Font_Button.Size = New System.Drawing.Size(279, 26)
        Me.Set_Font_Button.Text = "Set File Lists Font"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'CheckUnique_Button
        '
        Me.CheckUnique_Button.Enabled = False
        Me.CheckUnique_Button.ForeColor = System.Drawing.Color.Blue
        Me.CheckUnique_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.compare_balance_512
        Me.CheckUnique_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckUnique_Button.Name = "CheckUnique_Button"
        Me.CheckUnique_Button.Size = New System.Drawing.Size(246, 24)
        Me.CheckUnique_Button.Text = "Check Source items exist in Library"
        '
        'ClearSource_Button
        '
        Me.ClearSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ClearSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearSource_Button.Name = "ClearSource_Button"
        Me.ClearSource_Button.Size = New System.Drawing.Size(87, 24)
        Me.ClearSource_Button.Text = "Clear List"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'GetSourceHashes_Button
        '
        Me.GetSourceHashes_Button.Enabled = False
        Me.GetSourceHashes_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.hash_512
        Me.GetSourceHashes_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetSourceHashes_Button.Name = "GetSourceHashes_Button"
        Me.GetSourceHashes_Button.Size = New System.Drawing.Size(102, 24)
        Me.GetSourceHashes_Button.Text = "Get Hashes"
        '
        'CopySelected_Button
        '
        Me.CopySelected_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.copy_icon__3
        Me.CopySelected_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopySelected_Button.Name = "CopySelected_Button"
        Me.CopySelected_Button.Size = New System.Drawing.Size(179, 24)
        Me.CopySelected_Button.Text = "Copy Selected To Libary"
        '
        'Selection_Label
        '
        Me.Selection_Label.Name = "Selection_Label"
        Me.Selection_Label.Size = New System.Drawing.Size(104, 18)
        Me.Selection_Label.Text = "None Selected."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DestinationFolder_TextBox)
        Me.Panel1.Controls.Add(Me.UnsortedPathBRSR_LinkLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 456)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1421, 45)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Copy Destination :"
        '
        'DestinationFolder_TextBox
        '
        Me.DestinationFolder_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DestinationFolder_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "unsortedfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DestinationFolder_TextBox.Location = New System.Drawing.Point(196, 9)
        Me.DestinationFolder_TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DestinationFolder_TextBox.Name = "DestinationFolder_TextBox"
        Me.DestinationFolder_TextBox.Size = New System.Drawing.Size(1073, 26)
        Me.DestinationFolder_TextBox.TabIndex = 8
        Me.DestinationFolder_TextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.unsortedfolder
        '
        'UnsortedPathBRSR_LinkLabel
        '
        Me.UnsortedPathBRSR_LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnsortedPathBRSR_LinkLabel.AutoSize = True
        Me.UnsortedPathBRSR_LinkLabel.Location = New System.Drawing.Point(1281, 9)
        Me.UnsortedPathBRSR_LinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UnsortedPathBRSR_LinkLabel.Name = "UnsortedPathBRSR_LinkLabel"
        Me.UnsortedPathBRSR_LinkLabel.Size = New System.Drawing.Size(128, 18)
        Me.UnsortedPathBRSR_LinkLabel.TabIndex = 25
        Me.UnsortedPathBRSR_LinkLabel.TabStop = True
        Me.UnsortedPathBRSR_LinkLabel.Text = "Browse for folder..."
        '
        'LibraryList_DGV
        '
        Me.LibraryList_DGV.AllowUserToAddRows = False
        Me.LibraryList_DGV.AutoGenerateColumns = False
        Me.LibraryList_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.LibraryList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibraryList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileIDDataGridViewTextBoxColumn1, Me.FileNameDataGridViewTextBoxColumn1, Me.FullFileNameDataGridViewTextBoxColumn1, Me.FileTypeDataGridViewTextBoxColumn1, Me.FilePathDataGridViewTextBoxColumn1, Me.PathRelRootDataGridViewTextBoxColumn1, Me.DateCreatedDataGridViewTextBoxColumn1, Me.FileSizeDataGridViewTextBoxColumn1, Me.SHA1HashDataGridViewTextBoxColumn1, Me.UniqueStatusDataGridViewTextBoxColumn1, Me.CopyStatusDataGridViewTextBoxColumn1})
        Me.LibraryList_DGV.DataSource = Me.LIBARYDBBindingSource
        Me.LibraryList_DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibraryList_DGV.Location = New System.Drawing.Point(0, 48)
        Me.LibraryList_DGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LibraryList_DGV.Name = "LibraryList_DGV"
        Me.LibraryList_DGV.RowTemplate.Height = 24
        Me.LibraryList_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibraryList_DGV.Size = New System.Drawing.Size(1421, 528)
        Me.LibraryList_DGV.TabIndex = 4
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
        DataGridViewCellStyle3.Format = "0.00"" Mb"""
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FileSizeDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.ToolStrip2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadLibary_Button, Me.MainLibrary_ProgressBar, Me.OpenDest_ToolStripButton, Me.ClearLibary_Button, Me.GetLibaryHashes_Button})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.ToolStrip2.Size = New System.Drawing.Size(1421, 48)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'LoadLibary_Button
        '
        Me.LoadLibary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadLibary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadLibary_Button.Name = "LoadLibary_Button"
        Me.LoadLibary_Button.Size = New System.Drawing.Size(136, 24)
        Me.LoadLibary_Button.Text = "Load Main Libary"
        '
        'MainLibrary_ProgressBar
        '
        Me.MainLibrary_ProgressBar.Name = "MainLibrary_ProgressBar"
        Me.MainLibrary_ProgressBar.Size = New System.Drawing.Size(200, 27)
        '
        'OpenDest_ToolStripButton
        '
        Me.OpenDest_ToolStripButton.Image = Global.CBR_Libary_Checker.My.Resources.Resources.download
        Me.OpenDest_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenDest_ToolStripButton.Name = "OpenDest_ToolStripButton"
        Me.OpenDest_ToolStripButton.Size = New System.Drawing.Size(202, 24)
        Me.OpenDest_ToolStripButton.Text = "View Selected in Explorer..."
        '
        'ClearLibary_Button
        '
        Me.ClearLibary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ClearLibary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearLibary_Button.Name = "ClearLibary_Button"
        Me.ClearLibary_Button.Size = New System.Drawing.Size(87, 24)
        Me.ClearLibary_Button.Text = "Clear List"
        '
        'GetLibaryHashes_Button
        '
        Me.GetLibaryHashes_Button.Enabled = False
        Me.GetLibaryHashes_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.hash_512
        Me.GetLibaryHashes_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetLibaryHashes_Button.Name = "GetLibaryHashes_Button"
        Me.GetLibaryHashes_Button.Size = New System.Drawing.Size(102, 24)
        Me.GetLibaryHashes_Button.Text = "Get Hashes"
        '
        'Main_SplitContainer
        '
        Me.Main_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main_SplitContainer.Location = New System.Drawing.Point(0, 27)
        Me.Main_SplitContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Main_SplitContainer.Name = "Main_SplitContainer"
        '
        'Main_SplitContainer.Panel1
        '
        Me.Main_SplitContainer.Panel1.Controls.Add(Me.TreeView1)
        Me.Main_SplitContainer.Panel1.Controls.Add(Me.Panel2)
        Me.Main_SplitContainer.Panel1.Controls.Add(Me.FolderTreeViewToolStrip)
        '
        'Main_SplitContainer.Panel2
        '
        Me.Main_SplitContainer.Panel2.Controls.Add(Me.DGVsSplitContainer)
        Me.Main_SplitContainer.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Main_SplitContainer.Size = New System.Drawing.Size(1849, 1123)
        Me.Main_SplitContainer.SplitterDistance = 416
        Me.Main_SplitContainer.SplitterWidth = 12
        Me.Main_SplitContainer.TabIndex = 9
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.ItemHeight = 22
        Me.TreeView1.Location = New System.Drawing.Point(0, 48)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 5
        Me.TreeView1.Size = New System.Drawing.Size(416, 844)
        Me.TreeView1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Dominicanjoker-Comic-Publisher-Folder-Avatar.ico")
        Me.ImageList1.Images.SetKeyName(1, "Dominicanjoker-Comic-Publisher-Folder-Dark-Horse-v2.ico")
        Me.ImageList1.Images.SetKeyName(2, "Dominicanjoker-Comic-Publisher-Folder-DC-Comics.ico")
        Me.ImageList1.Images.SetKeyName(3, "Dominicanjoker-Comic-Publisher-Folder-Image-Comics-v2.ico")
        Me.ImageList1.Images.SetKeyName(4, "Dominicanjoker-Comic-Publisher-Folder-Marvel (1).ico")
        Me.ImageList1.Images.SetKeyName(5, "folder")
        Me.ImageList1.Images.SetKeyName(6, "Dominicanjoker-Comic-Publisher-Folder-Valiant.ico")
        Me.ImageList1.Images.SetKeyName(7, "Dominicanjoker-Comic-Publisher-Folder-Vertigo.ico")
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 892)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 231)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(108, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 210)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FolderTreeViewToolStrip
        '
        Me.FolderTreeViewToolStrip.AutoSize = False
        Me.FolderTreeViewToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FolderTreeViewToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshFolderList_Button, Me.ToolStripSeparator4, Me.NewFolder_Button, Me.ToolStripSeparator6, Me.ToolStripButton3})
        Me.FolderTreeViewToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FolderTreeViewToolStrip.Name = "FolderTreeViewToolStrip"
        Me.FolderTreeViewToolStrip.Size = New System.Drawing.Size(416, 48)
        Me.FolderTreeViewToolStrip.TabIndex = 0
        Me.FolderTreeViewToolStrip.Text = "ToolStrip3"
        '
        'RefreshFolderList_Button
        '
        Me.RefreshFolderList_Button.AutoSize = False
        Me.RefreshFolderList_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshFolderList_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.refresh
        Me.RefreshFolderList_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshFolderList_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshFolderList_Button.Name = "RefreshFolderList_Button"
        Me.RefreshFolderList_Button.Size = New System.Drawing.Size(35, 37)
        Me.RefreshFolderList_Button.Text = "Refresh List"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        'NewFolder_Button
        '
        Me.NewFolder_Button.AutoSize = False
        Me.NewFolder_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewFolder_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Creative_Freedom_Shimmer_Folder_New
        Me.NewFolder_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewFolder_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewFolder_Button.Name = "NewFolder_Button"
        Me.NewFolder_Button.Size = New System.Drawing.Size(42, 42)
        Me.NewFolder_Button.Text = "New Folder"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Settings_L_icon
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(45, 45)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.backgg
        Me.ToolStrip3.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.SourcePath_ComboBox, Me.BrowseSource_Button, Me.ToolStripSeparator5, Me.AddToFave_Button})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1421, 35)
        Me.ToolStrip3.TabIndex = 23
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(135, 32)
        Me.ToolStripLabel1.Text = "Source Search Path:"
        '
        'SourcePath_ComboBox
        '
        Me.SourcePath_ComboBox.AutoSize = False
        Me.SourcePath_ComboBox.Name = "SourcePath_ComboBox"
        Me.SourcePath_ComboBox.Size = New System.Drawing.Size(400, 28)
        Me.SourcePath_ComboBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.torrentfolder
        '
        'BrowseSource_Button
        '
        Me.BrowseSource_Button.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BrowseSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Icons8_Windows_8_Files_View_File
        Me.BrowseSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseSource_Button.Name = "BrowseSource_Button"
        Me.BrowseSource_Button.Size = New System.Drawing.Size(147, 32)
        Me.BrowseSource_Button.Text = "Browse Folders...."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 35)
        '
        'AddToFave_Button
        '
        Me.AddToFave_Button.ForeColor = System.Drawing.Color.DarkGreen
        Me.AddToFave_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources._041_favor_add
        Me.AddToFave_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToFave_Button.Name = "AddToFave_Button"
        Me.AddToFave_Button.Size = New System.Drawing.Size(136, 32)
        Me.AddToFave_Button.Text = "Add To Favorites"
        '
        'NodeContextMenuStrip
        '
        Me.NodeContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NodeContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetThisFolderAsCopyDestinationToolStripMenuItem, Me.ToolStripMenuItem4, Me.LoadThisFolderInLibraryListToolStripMenuItem})
        Me.NodeContextMenuStrip.Name = "ContextMenuStrip1"
        Me.NodeContextMenuStrip.Size = New System.Drawing.Size(316, 62)
        '
        'SetThisFolderAsCopyDestinationToolStripMenuItem
        '
        Me.SetThisFolderAsCopyDestinationToolStripMenuItem.Name = "SetThisFolderAsCopyDestinationToolStripMenuItem"
        Me.SetThisFolderAsCopyDestinationToolStripMenuItem.Size = New System.Drawing.Size(315, 26)
        Me.SetThisFolderAsCopyDestinationToolStripMenuItem.Text = "Set  this folder as copy destination."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(312, 6)
        '
        'LoadThisFolderInLibraryListToolStripMenuItem
        '
        Me.LoadThisFolderInLibraryListToolStripMenuItem.Name = "LoadThisFolderInLibraryListToolStripMenuItem"
        Me.LoadThisFolderInLibraryListToolStripMenuItem.Size = New System.Drawing.Size(315, 26)
        Me.LoadThisFolderInLibraryListToolStripMenuItem.Text = "Load this folder in Library List"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ListView_ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1849, 27)
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripButton1.Text = "Close Tab"
        '
        'ListView_ToolStripSplitButton1
        '
        Me.ListView_ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ListView_ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.ListView_ToolStripSplitButton1.ForeColor = System.Drawing.Color.Yellow
        Me.ListView_ToolStripSplitButton1.Image = CType(resources.GetObject("ListView_ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ListView_ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ListView_ToolStripSplitButton1.Name = "ListView_ToolStripSplitButton1"
        Me.ListView_ToolStripSplitButton1.Size = New System.Drawing.Size(151, 24)
        Me.ListView_ToolStripSplitButton1.Text = "List View Direction"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.CheckOnClick = True
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.CheckOnClick = True
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1849, 1179)
        Me.Controls.Add(Me.Main_SplitContainer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SOURCELDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.DGVsSplitContainer.Panel1.ResumeLayout(False)
        Me.DGVsSplitContainer.Panel1.PerformLayout()
        Me.DGVsSplitContainer.Panel2.ResumeLayout(False)
        Me.DGVsSplitContainer.Panel2.PerformLayout()
        CType(Me.DGVsSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVsSplitContainer.ResumeLayout(False)
        CType(Me.SourceLibary_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SourceToolStrip.ResumeLayout(False)
        Me.SourceToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LibraryList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Main_SplitContainer.Panel1.ResumeLayout(False)
        Me.Main_SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.Main_SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_SplitContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FolderTreeViewToolStrip.ResumeLayout(False)
        Me.FolderTreeViewToolStrip.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.NodeContextMenuStrip.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SourceLibary_DGV As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status As ToolStripStatusLabel
    Friend WithEvents DestinationFolder_TextBox As TextBox
    Friend WithEvents DGVsSplitContainer As SplitContainer
    Friend WithEvents SourceToolStrip As ToolStrip
    Friend WithEvents LoadSource_Button As ToolStripButton
    Friend WithEvents SourceLibary_ProgressBar As ToolStripProgressBar
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents LoadLibary_Button As ToolStripButton
    Friend WithEvents MainLibrary_ProgressBar As ToolStripProgressBar
    Friend WithEvents Scan_Options_ToolStripSplitButton As ToolStripSplitButton
    Friend WithEvents HidePartial_Check As ToolStripMenuItem
    Friend WithEvents HideUnwanted_Check As ToolStripMenuItem
    Friend WithEvents OpenSource_Libary As ToolStripButton
    Friend WithEvents OpenDest_ToolStripButton As ToolStripButton
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
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents Set_Font_Button As ToolStripMenuItem
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
    Friend WithEvents LibraryList_DGV As DataGridView
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
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents status2 As ToolStripStatusLabel
    Friend WithEvents CustomGroupBoxMinable1 As CustomGroupBoxMinable
    Friend WithEvents ListView_ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Main_SplitContainer As SplitContainer
    Friend WithEvents FolderTreeViewToolStrip As ToolStrip
    Friend WithEvents RefreshFolderList_Button As ToolStripButton
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents NewFolder_Button As ToolStripButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents CopySelected_Button As ToolStripButton
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Copy_ProgressBar As ToolStripProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NodeContextMenuStrip As ContextMenuStrip
    Friend WithEvents SetThisFolderAsCopyDestinationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents LoadThisFolderInLibraryListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BrowseSource_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SourcePath_ComboBox As ToolStripComboBox
    Friend WithEvents AddToFave_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
