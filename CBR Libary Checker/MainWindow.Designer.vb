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
        Me.TabPlane = New System.Windows.Forms.CustomTabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FileManager_Button = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1526, 28)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabPlane
        '
        '
        '
        '
        Me.TabPlane.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.TabPlane.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark
        Me.TabPlane.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabPlane.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray
        Me.TabPlane.DisplayStyleProvider.FocusTrack = True
        Me.TabPlane.DisplayStyleProvider.HotTrack = True
        Me.TabPlane.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TabPlane.DisplayStyleProvider.Opacity = 1.0!
        Me.TabPlane.DisplayStyleProvider.Overlap = 0
        Me.TabPlane.DisplayStyleProvider.Padding = New System.Drawing.Point(6, 3)
        Me.TabPlane.DisplayStyleProvider.Radius = 2
        Me.TabPlane.DisplayStyleProvider.ShowTabCloser = False
        Me.TabPlane.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText
        Me.TabPlane.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark
        Me.TabPlane.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText
        Me.TabPlane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPlane.HotTrack = True
        Me.TabPlane.Location = New System.Drawing.Point(0, 78)
        Me.TabPlane.Name = "TabPlane"
        Me.TabPlane.SelectedIndex = 0
        Me.TabPlane.Size = New System.Drawing.Size(1526, 860)
        Me.TabPlane.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileManager_Button})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1526, 50)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FileManager_Button
        '
        Me.FileManager_Button.ForeColor = System.Drawing.Color.Lime
        Me.FileManager_Button.Image = CType(resources.GetObject("FileManager_Button.Image"), System.Drawing.Image)
        Me.FileManager_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileManager_Button.Name = "FileManager_Button"
        Me.FileManager_Button.Size = New System.Drawing.Size(238, 47)
        Me.FileManager_Button.Text = "Comic File Download Manager"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1526, 938)
        Me.Controls.Add(Me.TabPlane)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "MainWindow"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPlane As CustomTabControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileManager_Button As ToolStripButton
End Class
