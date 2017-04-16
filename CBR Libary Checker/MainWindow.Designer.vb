<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibarySettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPlane = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FileManager_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ComicInfoDB1 = New CBR_Libary_Checker.ComicInfoDB()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ComicInfoDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1525, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibarySettingsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'LibarySettingsToolStripMenuItem
        '
        Me.LibarySettingsToolStripMenuItem.Name = "LibarySettingsToolStripMenuItem"
        Me.LibarySettingsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.LibarySettingsToolStripMenuItem.Text = "Libary Settings"
        '
        'TabPlane
        '
        Me.TabPlane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPlane.Location = New System.Drawing.Point(0, 55)
        Me.TabPlane.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPlane.Name = "TabPlane"
        Me.TabPlane.SelectedIndex = 0
        Me.TabPlane.Size = New System.Drawing.Size(1525, 883)
        Me.TabPlane.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileManager_Button, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1525, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FileManager_Button
        '
        Me.FileManager_Button.ForeColor = System.Drawing.Color.Blue
        Me.FileManager_Button.Image = CType(resources.GetObject("FileManager_Button.Image"), System.Drawing.Image)
        Me.FileManager_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileManager_Button.Name = "FileManager_Button"
        Me.FileManager_Button.Size = New System.Drawing.Size(260, 24)
        Me.FileManager_Button.Text = "Comic Library Download Manager"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(122, 24)
        Me.ToolStripButton1.Text = "Libary Viewer"
        '
        'ComicInfoDB1
        '
        Me.ComicInfoDB1.DataSetName = "ComicInfoDB"
        Me.ComicInfoDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1525, 938)
        Me.Controls.Add(Me.TabPlane)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "MainWindow"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ComicInfoDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileManager_Button As ToolStripButton
    Friend WithEvents TabPlane As TabControl
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibarySettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComicInfoDB1 As ComicInfoDB
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
