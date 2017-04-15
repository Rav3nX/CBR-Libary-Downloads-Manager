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
        Me.SOURCELDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComicInfoDB = New CBR_Libary_Checker.ComicInfoDB()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
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
        Me.Selection_Label = New System.Windows.Forms.ToolStripLabel()
        Me.GetSourceHashes_Button = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ListView_ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomGroupBoxMinable3 = New CBR_Libary_Checker.CustomGroupBoxMinable()
        Me.Copy_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.CopySelected = New System.Windows.Forms.Button()
        Me.UnsortedPathBRSR_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ShowCopy_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UnsortedFolderTextBox = New System.Windows.Forms.TextBox()
        Me.CustomGroupBoxMinable2 = New CBR_Libary_Checker.CustomGroupBoxMinable()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Source_Browse_LL = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SourcePath_TextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.SOURCELDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SourceLibary_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SourceToolStrip.SuspendLayout()
        CType(Me.LibraryList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.CustomGroupBoxMinable3.SuspendLayout()
        Me.CustomGroupBoxMinable2.SuspendLayout()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status, Me.ToolStripStatusLabel1, Me.status2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1020)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1537, 25)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(346, 20)
        Me.status.Text = "Josh Cronin. 2017. CBR Libary Downloads Manager."
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'status2
        '
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(0, 20)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.DimGray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 326)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.LibraryList_DGV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1537, 694)
        Me.SplitContainer1.SplitterDistance = 324
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 6
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
        Me.SourceLibary_DGV.Location = New System.Drawing.Point(0, 42)
        Me.SourceLibary_DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SourceLibary_DGV.Name = "SourceLibary_DGV"
        Me.SourceLibary_DGV.ReadOnly = True
        Me.SourceLibary_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SourceLibary_DGV.Size = New System.Drawing.Size(1537, 282)
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
        Me.SourceToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SourceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadSource_Button, Me.SourceLibary_ProgressBar, Me.Scan_Options_ToolStripSplitButton, Me.OpenSource_Libary, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator2, Me.CheckUnique_Button, Me.ClearSource_Button, Me.ToolStripSeparator3, Me.Selection_Label, Me.GetSourceHashes_Button})
        Me.SourceToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.SourceToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SourceToolStrip.Name = "SourceToolStrip"
        Me.SourceToolStrip.Padding = New System.Windows.Forms.Padding(7)
        Me.SourceToolStrip.Size = New System.Drawing.Size(1537, 42)
        Me.SourceToolStrip.TabIndex = 1
        Me.SourceToolStrip.Text = "ToolStrip3"
        '
        'LoadSource_Button
        '
        Me.LoadSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadSource_Button.Name = "LoadSource_Button"
        Me.LoadSource_Button.Size = New System.Drawing.Size(159, 24)
        Me.LoadSource_Button.Text = "Load Source Libary"
        '
        'SourceLibary_ProgressBar
        '
        Me.SourceLibary_ProgressBar.Name = "SourceLibary_ProgressBar"
        Me.SourceLibary_ProgressBar.Size = New System.Drawing.Size(200, 25)
        '
        'Scan_Options_ToolStripSplitButton
        '
        Me.Scan_Options_ToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HidePartial_Check, Me.HideUnwanted_Check, Me.ToolStripMenuItem3, Me.GetHashesOnScanToolStripMenuItem})
        Me.Scan_Options_ToolStripSplitButton.Image = CType(resources.GetObject("Scan_Options_ToolStripSplitButton.Image"), System.Drawing.Image)
        Me.Scan_Options_ToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Scan_Options_ToolStripSplitButton.Name = "Scan_Options_ToolStripSplitButton"
        Me.Scan_Options_ToolStripSplitButton.Size = New System.Drawing.Size(135, 24)
        Me.Scan_Options_ToolStripSplitButton.Text = "Scan Options"
        '
        'HidePartial_Check
        '
        Me.HidePartial_Check.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HidePartial
        Me.HidePartial_Check.CheckOnClick = True
        Me.HidePartial_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HidePartial_Check.Name = "HidePartial_Check"
        Me.HidePartial_Check.Size = New System.Drawing.Size(294, 26)
        Me.HidePartial_Check.Text = "Hide QTorrent Partial Files (.qb!)"
        '
        'HideUnwanted_Check
        '
        Me.HideUnwanted_Check.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.HideUnwanted
        Me.HideUnwanted_Check.CheckOnClick = True
        Me.HideUnwanted_Check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HideUnwanted_Check.Name = "HideUnwanted_Check"
        Me.HideUnwanted_Check.Size = New System.Drawing.Size(294, 26)
        Me.HideUnwanted_Check.Text = "Hide Qtorrent .Unwanted Files"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(291, 6)
        '
        'GetHashesOnScanToolStripMenuItem
        '
        Me.GetHashesOnScanToolStripMenuItem.Checked = Global.CBR_Libary_Checker.My.MySettings.Default.Source_GetHashes
        Me.GetHashesOnScanToolStripMenuItem.CheckOnClick = True
        Me.GetHashesOnScanToolStripMenuItem.Name = "GetHashesOnScanToolStripMenuItem"
        Me.GetHashesOnScanToolStripMenuItem.Size = New System.Drawing.Size(294, 26)
        Me.GetHashesOnScanToolStripMenuItem.Text = "Get Hashes on Scan"
        '
        'OpenSource_Libary
        '
        Me.OpenSource_Libary.Image = Global.CBR_Libary_Checker.My.Resources.Resources.download
        Me.OpenSource_Libary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenSource_Libary.Name = "OpenSource_Libary"
        Me.OpenSource_Libary.Size = New System.Drawing.Size(210, 24)
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
        Me.HideDupes_CHKButton.Size = New System.Drawing.Size(301, 26)
        Me.HideDupes_CHKButton.Text = "Hide Files Already in Main Libary"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(298, 6)
        '
        'ColumnsToolStripMenuItem
        '
        Me.ColumnsToolStripMenuItem.Name = "ColumnsToolStripMenuItem"
        Me.ColumnsToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.ColumnsToolStripMenuItem.Text = "Columns:"
        '
        'FullFilePathToolStripMenuItem
        '
        Me.FullFilePathToolStripMenuItem.Checked = True
        Me.FullFilePathToolStripMenuItem.CheckOnClick = True
        Me.FullFilePathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FullFilePathToolStripMenuItem.Name = "FullFilePathToolStripMenuItem"
        Me.FullFilePathToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.FullFilePathToolStripMenuItem.Text = "Full File Path"
        '
        'FileNameToolStripMenuItem
        '
        Me.FileNameToolStripMenuItem.Checked = True
        Me.FileNameToolStripMenuItem.CheckOnClick = True
        Me.FileNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileNameToolStripMenuItem.Name = "FileNameToolStripMenuItem"
        Me.FileNameToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.FileNameToolStripMenuItem.Text = "File Name"
        '
        'FileTypeToolStripMenuItem
        '
        Me.FileTypeToolStripMenuItem.Checked = True
        Me.FileTypeToolStripMenuItem.CheckOnClick = True
        Me.FileTypeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileTypeToolStripMenuItem.Name = "FileTypeToolStripMenuItem"
        Me.FileTypeToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.FileTypeToolStripMenuItem.Text = "File Type"
        '
        'UnwantedQtorrentToolStripMenuItem
        '
        Me.UnwantedQtorrentToolStripMenuItem.Checked = True
        Me.UnwantedQtorrentToolStripMenuItem.CheckOnClick = True
        Me.UnwantedQtorrentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UnwantedQtorrentToolStripMenuItem.Name = "UnwantedQtorrentToolStripMenuItem"
        Me.UnwantedQtorrentToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.UnwantedQtorrentToolStripMenuItem.Text = "Unwanted (Qtorrent)"
        '
        'FolderPathToolStripMenuItem
        '
        Me.FolderPathToolStripMenuItem.Checked = True
        Me.FolderPathToolStripMenuItem.CheckOnClick = True
        Me.FolderPathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FolderPathToolStripMenuItem.Name = "FolderPathToolStripMenuItem"
        Me.FolderPathToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.FolderPathToolStripMenuItem.Text = "Folder Path"
        '
        'DateCreatedToolStripMenuItem
        '
        Me.DateCreatedToolStripMenuItem.Checked = True
        Me.DateCreatedToolStripMenuItem.CheckOnClick = True
        Me.DateCreatedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DateCreatedToolStripMenuItem.Name = "DateCreatedToolStripMenuItem"
        Me.DateCreatedToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.DateCreatedToolStripMenuItem.Text = "Date Created"
        '
        'FileSizeMbToolStripMenuItem
        '
        Me.FileSizeMbToolStripMenuItem.Checked = True
        Me.FileSizeMbToolStripMenuItem.CheckOnClick = True
        Me.FileSizeMbToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileSizeMbToolStripMenuItem.Name = "FileSizeMbToolStripMenuItem"
        Me.FileSizeMbToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.FileSizeMbToolStripMenuItem.Text = "File Size (Mb)"
        '
        'InLibaryToolStripMenuItem
        '
        Me.InLibaryToolStripMenuItem.Checked = True
        Me.InLibaryToolStripMenuItem.CheckOnClick = True
        Me.InLibaryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InLibaryToolStripMenuItem.Name = "InLibaryToolStripMenuItem"
        Me.InLibaryToolStripMenuItem.Size = New System.Drawing.Size(301, 26)
        Me.InLibaryToolStripMenuItem.Text = "In Libary"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(298, 6)
        '
        'Set_Font_Button
        '
        Me.Set_Font_Button.Name = "Set_Font_Button"
        Me.Set_Font_Button.Size = New System.Drawing.Size(301, 26)
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
        Me.CheckUnique_Button.Size = New System.Drawing.Size(260, 24)
        Me.CheckUnique_Button.Text = "Check Source items exist in Library"
        '
        'ClearSource_Button
        '
        Me.ClearSource_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ClearSource_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearSource_Button.Name = "ClearSource_Button"
        Me.ClearSource_Button.Size = New System.Drawing.Size(93, 24)
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
        Me.Selection_Label.Size = New System.Drawing.Size(109, 20)
        Me.Selection_Label.Text = "None Selected."
        '
        'GetSourceHashes_Button
        '
        Me.GetSourceHashes_Button.Enabled = False
        Me.GetSourceHashes_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.hash_512
        Me.GetSourceHashes_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetSourceHashes_Button.Name = "GetSourceHashes_Button"
        Me.GetSourceHashes_Button.Size = New System.Drawing.Size(107, 24)
        Me.GetSourceHashes_Button.Text = "Get Hashes"
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
        Me.LibraryList_DGV.Location = New System.Drawing.Point(0, 42)
        Me.LibraryList_DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LibraryList_DGV.Name = "LibraryList_DGV"
        Me.LibraryList_DGV.RowTemplate.Height = 24
        Me.LibraryList_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibraryList_DGV.Size = New System.Drawing.Size(1537, 318)
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadLibary_Button, Me.MainLibrary_ProgressBar, Me.OpenDest_ToolStripButton, Me.ClearLibary_Button, Me.GetLibaryHashes_Button})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(7)
        Me.ToolStrip2.Size = New System.Drawing.Size(1537, 42)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'LoadLibary_Button
        '
        Me.LoadLibary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadLibary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadLibary_Button.Name = "LoadLibary_Button"
        Me.LoadLibary_Button.Size = New System.Drawing.Size(147, 24)
        Me.LoadLibary_Button.Text = "Load Main Libary"
        '
        'MainLibrary_ProgressBar
        '
        Me.MainLibrary_ProgressBar.Name = "MainLibrary_ProgressBar"
        Me.MainLibrary_ProgressBar.Size = New System.Drawing.Size(200, 25)
        '
        'OpenDest_ToolStripButton
        '
        Me.OpenDest_ToolStripButton.Image = Global.CBR_Libary_Checker.My.Resources.Resources.download
        Me.OpenDest_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenDest_ToolStripButton.Name = "OpenDest_ToolStripButton"
        Me.OpenDest_ToolStripButton.Size = New System.Drawing.Size(210, 24)
        Me.OpenDest_ToolStripButton.Text = "View Selected in Explorer..."
        '
        'ClearLibary_Button
        '
        Me.ClearLibary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ClearLibary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearLibary_Button.Name = "ClearLibary_Button"
        Me.ClearLibary_Button.Size = New System.Drawing.Size(93, 24)
        Me.ClearLibary_Button.Text = "Clear List"
        '
        'GetLibaryHashes_Button
        '
        Me.GetLibaryHashes_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.hash_512
        Me.GetLibaryHashes_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetLibaryHashes_Button.Name = "GetLibaryHashes_Button"
        Me.GetLibaryHashes_Button.Size = New System.Drawing.Size(107, 24)
        Me.GetLibaryHashes_Button.Text = "Get Hashes"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ListView_ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1537, 27)
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
        Me.ListView_ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListView_ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.ListView_ToolStripSplitButton1.Image = CType(resources.GetObject("ListView_ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ListView_ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ListView_ToolStripSplitButton1.Name = "ListView_ToolStripSplitButton1"
        Me.ListView_ToolStripSplitButton1.Size = New System.Drawing.Size(39, 24)
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
        'CustomGroupBoxMinable3
        '
        Me.CustomGroupBoxMinable3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomGroupBoxMinable3.Controls.Add(Me.Copy_ProgressBar)
        Me.CustomGroupBoxMinable3.Controls.Add(Me.CopySelected)
        Me.CustomGroupBoxMinable3.Controls.Add(Me.UnsortedPathBRSR_LinkLabel)
        Me.CustomGroupBoxMinable3.Controls.Add(Me.ShowCopy_CheckBox)
        Me.CustomGroupBoxMinable3.Controls.Add(Me.Label4)
        Me.CustomGroupBoxMinable3.Controls.Add(Me.UnsortedFolderTextBox)
        Me.CustomGroupBoxMinable3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomGroupBoxMinable3.ISExpandedHeightSiz = 0
        Me.CustomGroupBoxMinable3.IsMinimised = False
        Me.CustomGroupBoxMinable3.Location = New System.Drawing.Point(0, 205)
        Me.CustomGroupBoxMinable3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomGroupBoxMinable3.Name = "CustomGroupBoxMinable3"
        Me.CustomGroupBoxMinable3.NotationText = Nothing
        Me.CustomGroupBoxMinable3.NotationVisible = False
        Me.CustomGroupBoxMinable3.Size = New System.Drawing.Size(1537, 121)
        Me.CustomGroupBoxMinable3.TabIndex = 8
        Me.CustomGroupBoxMinable3.Text = "CustomGroupBoxMinable3"
        Me.CustomGroupBoxMinable3.TitleHeight = 26
        '
        'Copy_ProgressBar
        '
        Me.Copy_ProgressBar.Location = New System.Drawing.Point(946, 52)
        Me.Copy_ProgressBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Copy_ProgressBar.Name = "Copy_ProgressBar"
        Me.Copy_ProgressBar.Size = New System.Drawing.Size(229, 23)
        Me.Copy_ProgressBar.TabIndex = 8
        '
        'CopySelected
        '
        Me.CopySelected.Enabled = False
        Me.CopySelected.Location = New System.Drawing.Point(667, 48)
        Me.CopySelected.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CopySelected.Name = "CopySelected"
        Me.CopySelected.Size = New System.Drawing.Size(273, 30)
        Me.CopySelected.TabIndex = 7
        Me.CopySelected.Text = "Copy Selected From Source to Folder"
        Me.CopySelected.UseVisualStyleBackColor = True
        '
        'UnsortedPathBRSR_LinkLabel
        '
        Me.UnsortedPathBRSR_LinkLabel.AutoSize = True
        Me.UnsortedPathBRSR_LinkLabel.Location = New System.Drawing.Point(301, 78)
        Me.UnsortedPathBRSR_LinkLabel.Name = "UnsortedPathBRSR_LinkLabel"
        Me.UnsortedPathBRSR_LinkLabel.Size = New System.Drawing.Size(127, 17)
        Me.UnsortedPathBRSR_LinkLabel.TabIndex = 25
        Me.UnsortedPathBRSR_LinkLabel.TabStop = True
        Me.UnsortedPathBRSR_LinkLabel.Text = "Browse for folder..."
        '
        'ShowCopy_CheckBox
        '
        Me.ShowCopy_CheckBox.AutoSize = True
        Me.ShowCopy_CheckBox.Location = New System.Drawing.Point(443, 54)
        Me.ShowCopy_CheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShowCopy_CheckBox.Name = "ShowCopy_CheckBox"
        Me.ShowCopy_CheckBox.Size = New System.Drawing.Size(200, 21)
        Me.ShowCopy_CheckBox.TabIndex = 26
        Me.ShowCopy_CheckBox.Text = "Show Windows copy dialog"
        Me.ShowCopy_CheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Unsorted (Copy To) Folder Location:"
        '
        'UnsortedFolderTextBox
        '
        Me.UnsortedFolderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "unsortedfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UnsortedFolderTextBox.Location = New System.Drawing.Point(24, 54)
        Me.UnsortedFolderTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UnsortedFolderTextBox.Name = "UnsortedFolderTextBox"
        Me.UnsortedFolderTextBox.Size = New System.Drawing.Size(405, 22)
        Me.UnsortedFolderTextBox.TabIndex = 8
        Me.UnsortedFolderTextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.unsortedfolder
        '
        'CustomGroupBoxMinable2
        '
        Me.CustomGroupBoxMinable2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomGroupBoxMinable2.Controls.Add(Me.LinkLabel3)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.Source_Browse_LL)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.Label1)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.LinkLabel2)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.ListBox1)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.Label2)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.SourcePath_TextBox)
        Me.CustomGroupBoxMinable2.Controls.Add(Me.LinkLabel1)
        Me.CustomGroupBoxMinable2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomGroupBoxMinable2.ISExpandedHeightSiz = 0
        Me.CustomGroupBoxMinable2.IsMinimised = False
        Me.CustomGroupBoxMinable2.Location = New System.Drawing.Point(0, 27)
        Me.CustomGroupBoxMinable2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomGroupBoxMinable2.Name = "CustomGroupBoxMinable2"
        Me.CustomGroupBoxMinable2.NotationText = Nothing
        Me.CustomGroupBoxMinable2.NotationVisible = False
        Me.CustomGroupBoxMinable2.Size = New System.Drawing.Size(1537, 178)
        Me.CustomGroupBoxMinable2.TabIndex = 2
        Me.CustomGroupBoxMinable2.Text = "Library Options"
        Me.CustomGroupBoxMinable2.TitleHeight = 26
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(831, 97)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(123, 17)
        Me.LinkLabel3.TabIndex = 19
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Remove Selected."
        '
        'Source_Browse_LL
        '
        Me.Source_Browse_LL.AutoSize = True
        Me.Source_Browse_LL.Location = New System.Drawing.Point(287, 76)
        Me.Source_Browse_LL.Name = "Source_Browse_LL"
        Me.Source_Browse_LL.Size = New System.Drawing.Size(127, 17)
        Me.Source_Browse_LL.TabIndex = 21
        Me.Source_Browse_LL.TabStop = True
        Me.Source_Browse_LL.Text = "Browse for folder..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "File Source Locations;"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(831, 54)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(183, 17)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Source to selected."
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(434, 50)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(391, 84)
        Me.ListBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Source Folder Search Location:"
        '
        'SourcePath_TextBox
        '
        Me.SourcePath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "torrentfolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SourcePath_TextBox.Location = New System.Drawing.Point(8, 51)
        Me.SourcePath_TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SourcePath_TextBox.Name = "SourcePath_TextBox"
        Me.SourcePath_TextBox.Size = New System.Drawing.Size(405, 22)
        Me.SourcePath_TextBox.TabIndex = 1
        Me.SourcePath_TextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.torrentfolder
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 76)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(173, 17)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add Location to Favorites."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1537, 1045)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CustomGroupBoxMinable3)
        Me.Controls.Add(Me.CustomGroupBoxMinable2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SOURCELDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SourceLibary_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SourceToolStrip.ResumeLayout(False)
        Me.SourceToolStrip.PerformLayout()
        CType(Me.LibraryList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CustomGroupBoxMinable3.ResumeLayout(False)
        Me.CustomGroupBoxMinable3.PerformLayout()
        Me.CustomGroupBoxMinable2.ResumeLayout(False)
        Me.CustomGroupBoxMinable2.PerformLayout()
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
    Friend WithEvents SplitContainer1 As SplitContainer
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
    Friend WithEvents CustomGroupBoxMinable2 As CustomGroupBoxMinable
    Friend WithEvents ListView_ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomGroupBoxMinable3 As CustomGroupBoxMinable
End Class
