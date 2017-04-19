<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolderCreator))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MyLibraryHeader_Panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderTreeViewToolStrip = New System.Windows.Forms.ToolStrip()
        Me.RefreshFolderList_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewFolder_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibrarySettings_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.FileDestination_Label = New System.Windows.Forms.ToolStripLabel()
        Me.DragMode_Label = New System.Windows.Forms.ToolStripLabel()
        Me.DragEnabled_Label = New System.Windows.Forms.ToolStripLabel()
        Me.LibraryList_DGV = New System.Windows.Forms.DataGridView()
        Me.FileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathRelRootDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHA1HashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComicRackADS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBARYDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComicInfoDB = New CBR_Libary_Checker.ComicInfoDB()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LoadLibrary_Button = New System.Windows.Forms.ToolStripButton()
        Me.MainLibrary_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.DragMode_Button = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DragMode_Move_Button = New System.Windows.Forms.ToolStripMenuItem()
        Me.DragMode_Copy_Button = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DragMode_NewFolder_Button = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileActions_GroupButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CopySelected_Button = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MoveSelectedFilesToSelectedFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDragging_Button = New System.Windows.Forms.ToolStripButton()
        Me.NodeContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenFolderInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteSelectedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MyLibraryHeader_Panel.SuspendLayout()
        Me.FolderTreeViewToolStrip.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.LibraryList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.NodeContextMenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MyLibraryHeader_Panel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FolderTreeViewToolStrip)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LibraryList_DGV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(2563, 760)
        Me.SplitContainer1.SplitterDistance = 447
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.ItemHeight = 22
        Me.TreeView1.Location = New System.Drawing.Point(0, 95)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(447, 582)
        Me.TreeView1.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "BLUEFOLDER")
        Me.ImageList1.Images.SetKeyName(1, "REDFOLDER")
        Me.ImageList1.Images.SetKeyName(2, "WHITEFOLDER")
        Me.ImageList1.Images.SetKeyName(3, "Dominicanjoker-Comic-Publisher-Folder-Dark-Horse-v2.ico")
        Me.ImageList1.Images.SetKeyName(4, "Dominicanjoker-Comic-Publisher-Folder-DC-Comics.ico")
        Me.ImageList1.Images.SetKeyName(5, "Dominicanjoker-Comic-Publisher-Folder-Marvel (1).ico")
        Me.ImageList1.Images.SetKeyName(6, "Dominicanjoker-Comic-Publisher-Folder-Valiant.ico")
        Me.ImageList1.Images.SetKeyName(7, "Dominicanjoker-Comic-Publisher-Folder-Vertigo.ico")
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 677)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 83)
        Me.Panel1.TabIndex = 6
        '
        'MyLibraryHeader_Panel
        '
        Me.MyLibraryHeader_Panel.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.backgg
        Me.MyLibraryHeader_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLibraryHeader_Panel.Controls.Add(Me.Label1)
        Me.MyLibraryHeader_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyLibraryHeader_Panel.Location = New System.Drawing.Point(0, 63)
        Me.MyLibraryHeader_Panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyLibraryHeader_Panel.Name = "MyLibraryHeader_Panel"
        Me.MyLibraryHeader_Panel.Size = New System.Drawing.Size(447, 32)
        Me.MyLibraryHeader_Panel.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MY LIBRARY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FolderTreeViewToolStrip
        '
        Me.FolderTreeViewToolStrip.AutoSize = False
        Me.FolderTreeViewToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FolderTreeViewToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshFolderList_Button, Me.ToolStripSeparator4, Me.NewFolder_Button, Me.ToolStripSeparator6, Me.LibrarySettings_Button})
        Me.FolderTreeViewToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FolderTreeViewToolStrip.Name = "FolderTreeViewToolStrip"
        Me.FolderTreeViewToolStrip.Size = New System.Drawing.Size(447, 63)
        Me.FolderTreeViewToolStrip.TabIndex = 3
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
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 63)
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
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 63)
        '
        'LibrarySettings_Button
        '
        Me.LibrarySettings_Button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LibrarySettings_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Settings_L_icon
        Me.LibrarySettings_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LibrarySettings_Button.Name = "LibrarySettings_Button"
        Me.LibrarySettings_Button.Size = New System.Drawing.Size(135, 60)
        Me.LibrarySettings_Button.Text = "Library Settings"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.backgg
        Me.ToolStrip3.Font = New System.Drawing.Font("Candara", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.FileDestination_Label, Me.DragMode_Label, Me.DragEnabled_Label})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 50)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(2112, 26)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(205, 23)
        Me.ToolStripLabel2.Text = "Current Selected Folder:"
        '
        'FileDestination_Label
        '
        Me.FileDestination_Label.Name = "FileDestination_Label"
        Me.FileDestination_Label.Size = New System.Drawing.Size(128, 23)
        Me.FileDestination_Label.Text = "none selected."
        '
        'DragMode_Label
        '
        Me.DragMode_Label.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DragMode_Label.Name = "DragMode_Label"
        Me.DragMode_Label.Size = New System.Drawing.Size(350, 23)
        Me.DragMode_Label.Text = "(F4 to toggle) Drag Mode - None Selected."
        '
        'DragEnabled_Label
        '
        Me.DragEnabled_Label.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DragEnabled_Label.Font = New System.Drawing.Font("Candara", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DragEnabled_Label.ForeColor = System.Drawing.Color.Green
        Me.DragEnabled_Label.Name = "DragEnabled_Label"
        Me.DragEnabled_Label.Size = New System.Drawing.Size(157, 23)
        Me.DragEnabled_Label.Text = "Dragging Disabled"
        '
        'LibraryList_DGV
        '
        Me.LibraryList_DGV.AllowUserToAddRows = False
        Me.LibraryList_DGV.AllowUserToDeleteRows = False
        Me.LibraryList_DGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.LibraryList_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LibraryList_DGV.AutoGenerateColumns = False
        Me.LibraryList_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LibraryList_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.LibraryList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibraryList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileName, Me.PathRelRootDataGridViewTextBoxColumn, Me.CopyStatusDataGridViewTextBoxColumn, Me.FileSizeDataGridViewTextBoxColumn, Me.FileIDDataGridViewTextBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn, Me.FullFileNameDataGridViewTextBoxColumn, Me.FileTypeDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.SHA1HashDataGridViewTextBoxColumn, Me.UniqueStatusDataGridViewTextBoxColumn, Me.ComicRackADS})
        Me.LibraryList_DGV.DataSource = Me.LIBARYDBBindingSource
        Me.LibraryList_DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibraryList_DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LibraryList_DGV.Location = New System.Drawing.Point(0, 76)
        Me.LibraryList_DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.LibraryList_DGV.Name = "LibraryList_DGV"
        Me.LibraryList_DGV.ReadOnly = True
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        Me.LibraryList_DGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.LibraryList_DGV.RowTemplate.Height = 32
        Me.LibraryList_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibraryList_DGV.Size = New System.Drawing.Size(2112, 684)
        Me.LibraryList_DGV.TabIndex = 1
        '
        'FileName
        '
        Me.FileName.DataPropertyName = "FileName"
        Me.FileName.HeaderText = "File Name"
        Me.FileName.MinimumWidth = 200
        Me.FileName.Name = "FileName"
        Me.FileName.ReadOnly = True
        Me.FileName.Width = 200
        '
        'PathRelRootDataGridViewTextBoxColumn
        '
        Me.PathRelRootDataGridViewTextBoxColumn.DataPropertyName = "Path Rel Root"
        Me.PathRelRootDataGridViewTextBoxColumn.HeaderText = "Path Relitive to Library Root"
        Me.PathRelRootDataGridViewTextBoxColumn.MinimumWidth = 180
        Me.PathRelRootDataGridViewTextBoxColumn.Name = "PathRelRootDataGridViewTextBoxColumn"
        Me.PathRelRootDataGridViewTextBoxColumn.ReadOnly = True
        Me.PathRelRootDataGridViewTextBoxColumn.Width = 188
        '
        'CopyStatusDataGridViewTextBoxColumn
        '
        Me.CopyStatusDataGridViewTextBoxColumn.DataPropertyName = "Copy Status"
        Me.CopyStatusDataGridViewTextBoxColumn.HeaderText = "Copy Status"
        Me.CopyStatusDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.CopyStatusDataGridViewTextBoxColumn.Name = "CopyStatusDataGridViewTextBoxColumn"
        Me.CopyStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CopyStatusDataGridViewTextBoxColumn.Width = 114
        '
        'FileSizeDataGridViewTextBoxColumn
        '
        Me.FileSizeDataGridViewTextBoxColumn.DataPropertyName = "File Size"
        DataGridViewCellStyle2.Format = "0.00"" Mb"""
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FileSizeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FileSizeDataGridViewTextBoxColumn.HeaderText = "File Size"
        Me.FileSizeDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.FileSizeDataGridViewTextBoxColumn.Name = "FileSizeDataGridViewTextBoxColumn"
        Me.FileSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FileIDDataGridViewTextBoxColumn
        '
        Me.FileIDDataGridViewTextBoxColumn.DataPropertyName = "File ID"
        Me.FileIDDataGridViewTextBoxColumn.HeaderText = "File ID"
        Me.FileIDDataGridViewTextBoxColumn.Name = "FileIDDataGridViewTextBoxColumn"
        Me.FileIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileIDDataGridViewTextBoxColumn.Visible = False
        Me.FileIDDataGridViewTextBoxColumn.Width = 64
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        Me.DateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateCreatedDataGridViewTextBoxColumn.Visible = False
        Me.DateCreatedDataGridViewTextBoxColumn.Width = 122
        '
        'FullFileNameDataGridViewTextBoxColumn
        '
        Me.FullFileNameDataGridViewTextBoxColumn.DataPropertyName = "Full File Name"
        Me.FullFileNameDataGridViewTextBoxColumn.HeaderText = "Full File Name"
        Me.FullFileNameDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.FullFileNameDataGridViewTextBoxColumn.Name = "FullFileNameDataGridViewTextBoxColumn"
        Me.FullFileNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullFileNameDataGridViewTextBoxColumn.Width = 127
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "File Type"
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "File Type"
        Me.FileTypeDataGridViewTextBoxColumn.MinimumWidth = 75
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        Me.FileTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileTypeDataGridViewTextBoxColumn.Width = 94
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
        'SHA1HashDataGridViewTextBoxColumn
        '
        Me.SHA1HashDataGridViewTextBoxColumn.DataPropertyName = "SHA1 Hash"
        Me.SHA1HashDataGridViewTextBoxColumn.HeaderText = "SHA1 Hash"
        Me.SHA1HashDataGridViewTextBoxColumn.Name = "SHA1HashDataGridViewTextBoxColumn"
        Me.SHA1HashDataGridViewTextBoxColumn.ReadOnly = True
        Me.SHA1HashDataGridViewTextBoxColumn.Visible = False
        Me.SHA1HashDataGridViewTextBoxColumn.Width = 105
        '
        'UniqueStatusDataGridViewTextBoxColumn
        '
        Me.UniqueStatusDataGridViewTextBoxColumn.DataPropertyName = "Unique Status"
        Me.UniqueStatusDataGridViewTextBoxColumn.HeaderText = "Unique Status"
        Me.UniqueStatusDataGridViewTextBoxColumn.Name = "UniqueStatusDataGridViewTextBoxColumn"
        Me.UniqueStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.UniqueStatusDataGridViewTextBoxColumn.Visible = False
        Me.UniqueStatusDataGridViewTextBoxColumn.Width = 128
        '
        'ComicRackADS
        '
        Me.ComicRackADS.DataPropertyName = "ComicRackADS"
        Me.ComicRackADS.HeaderText = "ComicRackADS"
        Me.ComicRackADS.Name = "ComicRackADS"
        Me.ComicRackADS.ReadOnly = True
        Me.ComicRackADS.Visible = False
        Me.ComicRackADS.Width = 148
        '
        'LIBARYDBBindingSource
        '
        Me.LIBARYDBBindingSource.DataMember = "LIBARY_DB"
        Me.LIBARYDBBindingSource.DataSource = Me.ComicInfoDB
        '
        'ComicInfoDB
        '
        Me.ComicInfoDB.DataSetName = "ComicInfoDB"
        Me.ComicInfoDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadLibrary_Button, Me.MainLibrary_ProgressBar, Me.DragMode_Button, Me.FileActions_GroupButton, Me.EnableDragging_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(2112, 50)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LoadLibrary_Button
        '
        Me.LoadLibrary_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Search_Folder_icon
        Me.LoadLibrary_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadLibrary_Button.Name = "LoadLibrary_Button"
        Me.LoadLibrary_Button.Size = New System.Drawing.Size(167, 47)
        Me.LoadLibrary_Button.Text = "Load Library File List"
        '
        'MainLibrary_ProgressBar
        '
        Me.MainLibrary_ProgressBar.Name = "MainLibrary_ProgressBar"
        Me.MainLibrary_ProgressBar.Size = New System.Drawing.Size(225, 47)
        '
        'DragMode_Button
        '
        Me.DragMode_Button.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DragMode_Move_Button, Me.DragMode_Copy_Button, Me.ToolStripMenuItem2, Me.DragMode_NewFolder_Button})
        Me.DragMode_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.copy_icon__3
        Me.DragMode_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DragMode_Button.Name = "DragMode_Button"
        Me.DragMode_Button.Size = New System.Drawing.Size(124, 47)
        Me.DragMode_Button.Text = "Drag Mode"
        '
        'DragMode_Move_Button
        '
        Me.DragMode_Move_Button.CheckOnClick = True
        Me.DragMode_Move_Button.Name = "DragMode_Move_Button"
        Me.DragMode_Move_Button.Size = New System.Drawing.Size(225, 26)
        Me.DragMode_Move_Button.Text = "Drag to Move"
        '
        'DragMode_Copy_Button
        '
        Me.DragMode_Copy_Button.Name = "DragMode_Copy_Button"
        Me.DragMode_Copy_Button.Size = New System.Drawing.Size(225, 26)
        Me.DragMode_Copy_Button.Text = "Drag to Copy"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(222, 6)
        '
        'DragMode_NewFolder_Button
        '
        Me.DragMode_NewFolder_Button.CheckOnClick = True
        Me.DragMode_NewFolder_Button.Name = "DragMode_NewFolder_Button"
        Me.DragMode_NewFolder_Button.Size = New System.Drawing.Size(225, 26)
        Me.DragMode_NewFolder_Button.Text = "Prompt For New Folder"
        '
        'FileActions_GroupButton
        '
        Me.FileActions_GroupButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopySelected_Button, Me.ToolStripMenuItem1, Me.MoveSelectedFilesToSelectedFolderToolStripMenuItem, Me.ToolStripMenuItem3, Me.MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem, Me.CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem, Me.ToolStripMenuItem4, Me.DeleteSelectedItemsToolStripMenuItem})
        Me.FileActions_GroupButton.Image = Global.CBR_Libary_Checker.My.Resources.Resources._2_067
        Me.FileActions_GroupButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileActions_GroupButton.Name = "FileActions_GroupButton"
        Me.FileActions_GroupButton.Size = New System.Drawing.Size(124, 47)
        Me.FileActions_GroupButton.Text = "File Actions"
        '
        'CopySelected_Button
        '
        Me.CopySelected_Button.Name = "CopySelected_Button"
        Me.CopySelected_Button.Size = New System.Drawing.Size(411, 26)
        Me.CopySelected_Button.Text = "Copy Selected Files to Selected Folder"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(408, 6)
        '
        'MoveSelectedFilesToSelectedFolderToolStripMenuItem
        '
        Me.MoveSelectedFilesToSelectedFolderToolStripMenuItem.Name = "MoveSelectedFilesToSelectedFolderToolStripMenuItem"
        Me.MoveSelectedFilesToSelectedFolderToolStripMenuItem.Size = New System.Drawing.Size(411, 26)
        Me.MoveSelectedFilesToSelectedFolderToolStripMenuItem.Text = "Move Selected Files to Selected  Folder"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(408, 6)
        '
        'MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem
        '
        Me.MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Name = "MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem"
        Me.MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Size = New System.Drawing.Size(411, 26)
        Me.MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Text = "Move Selected Files to New Folder In Selected Folder"
        '
        'CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem
        '
        Me.CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Name = "CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem"
        Me.CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Size = New System.Drawing.Size(411, 26)
        Me.CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem.Text = "Copy Selected Files to New Folder In Selected Folder"
        '
        'EnableDragging_Button
        '
        Me.EnableDragging_Button.BackColor = System.Drawing.SystemColors.Control
        Me.EnableDragging_Button.CheckOnClick = True
        Me.EnableDragging_Button.Image = Global.CBR_Libary_Checker.My.Resources.Resources.touch_gestures_tap_drag_move_512
        Me.EnableDragging_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnableDragging_Button.Name = "EnableDragging_Button"
        Me.EnableDragging_Button.Size = New System.Drawing.Size(173, 47)
        Me.EnableDragging_Button.Text = "Enable Dragging (F2)"
        '
        'NodeContextMenuStrip
        '
        Me.NodeContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NodeContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFolderInExplorerToolStripMenuItem})
        Me.NodeContextMenuStrip.Name = "ContextMenuStrip1"
        Me.NodeContextMenuStrip.Size = New System.Drawing.Size(242, 30)
        '
        'OpenFolderInExplorerToolStripMenuItem
        '
        Me.OpenFolderInExplorerToolStripMenuItem.Name = "OpenFolderInExplorerToolStripMenuItem"
        Me.OpenFolderInExplorerToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.OpenFolderInExplorerToolStripMenuItem.Text = "Open Folder In Explorer"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 792)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(2563, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(153, 20)
        Me.status.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip2.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(2563, 32)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ToolStripButton1.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Delete
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(140, 29)
        Me.ToolStripButton1.Text = "Close This Tab"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(120, 29)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(408, 6)
        '
        'DeleteSelectedItemsToolStripMenuItem
        '
        Me.DeleteSelectedItemsToolStripMenuItem.Name = "DeleteSelectedItemsToolStripMenuItem"
        Me.DeleteSelectedItemsToolStripMenuItem.Size = New System.Drawing.Size(411, 26)
        Me.DeleteSelectedItemsToolStripMenuItem.Text = "Delete Selected Items"
        '
        'FolderCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2563, 817)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolderCreator"
        Me.Text = "FolderCreator"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MyLibraryHeader_Panel.ResumeLayout(False)
        Me.FolderTreeViewToolStrip.ResumeLayout(False)
        Me.FolderTreeViewToolStrip.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.LibraryList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBARYDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComicInfoDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.NodeContextMenuStrip.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents FolderTreeViewToolStrip As ToolStrip
    Friend WithEvents RefreshFolderList_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents NewFolder_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents LibrarySettings_Button As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyLibraryHeader_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NodeContextMenuStrip As ContextMenuStrip
    Friend WithEvents OpenFolderInExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LoadLibrary_Button As ToolStripButton
    Friend WithEvents LibraryList_DGV As DataGridView
    Friend WithEvents LIBARYDBBindingSource As BindingSource
    Friend WithEvents ComicInfoDB As ComicInfoDB
    Friend WithEvents MainLibrary_ProgressBar As ToolStripProgressBar
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DragMode_Button As ToolStripDropDownButton
    Friend WithEvents DragMode_Move_Button As ToolStripMenuItem
    Friend WithEvents DragMode_NewFolder_Button As ToolStripMenuItem
    Friend WithEvents EnableDragging_Button As ToolStripButton
    Friend WithEvents FileActions_GroupButton As ToolStripDropDownButton
    Friend WithEvents CopySelected_Button As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents MoveSelectedFilesToSelectedFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DragMode_Copy_Button As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents MoveSelectedFilesToNewFolderInSelectedFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopySelectedFilesToNewFolderInSelectedFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileName As DataGridViewTextBoxColumn
    Friend WithEvents PathRelRootDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CopyStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullFileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHA1HashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniqueStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComicRackADS As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents FileDestination_Label As ToolStripLabel
    Friend WithEvents DragMode_Label As ToolStripLabel
    Friend WithEvents DragEnabled_Label As ToolStripLabel
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents DeleteSelectedItemsToolStripMenuItem As ToolStripMenuItem
End Class
