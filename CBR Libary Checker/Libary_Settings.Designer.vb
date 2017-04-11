<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libary_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libary_Settings))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.closetab = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LibaryRootPath_TextBox = New System.Windows.Forms.TextBox()
        Me.LibaryRoot_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closetab})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(554, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'closetab
        '
        Me.closetab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.closetab.ForeColor = System.Drawing.Color.Lime
        Me.closetab.Image = CType(resources.GetObject("closetab.Image"), System.Drawing.Image)
        Me.closetab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closetab.Name = "closetab"
        Me.closetab.Size = New System.Drawing.Size(62, 22)
        Me.closetab.Text = "Close Tab"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comic Libary Root Folder Location:"
        '
        'LibaryRootPath_TextBox
        '
        Me.LibaryRootPath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CBR_Libary_Checker.My.MySettings.Default, "LibaryFolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LibaryRootPath_TextBox.Location = New System.Drawing.Point(29, 70)
        Me.LibaryRootPath_TextBox.Name = "LibaryRootPath_TextBox"
        Me.LibaryRootPath_TextBox.Size = New System.Drawing.Size(380, 20)
        Me.LibaryRootPath_TextBox.TabIndex = 2
        Me.LibaryRootPath_TextBox.Text = Global.CBR_Libary_Checker.My.MySettings.Default.LibaryFolder
        '
        'LibaryRoot_LinkLabel
        '
        Me.LibaryRoot_LinkLabel.AutoSize = True
        Me.LibaryRoot_LinkLabel.Location = New System.Drawing.Point(314, 93)
        Me.LibaryRoot_LinkLabel.Name = "LibaryRoot_LinkLabel"
        Me.LibaryRoot_LinkLabel.Size = New System.Drawing.Size(95, 13)
        Me.LibaryRoot_LinkLabel.TabIndex = 3
        Me.LibaryRoot_LinkLabel.TabStop = True
        Me.LibaryRoot_LinkLabel.Text = "Browse for folder..."
        '
        'Libary_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 276)
        Me.Controls.Add(Me.LibaryRoot_LinkLabel)
        Me.Controls.Add(Me.LibaryRootPath_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Libary_Settings"
        Me.Text = "Libary_Settings"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents closetab As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents LibaryRootPath_TextBox As TextBox
    Friend WithEvents LibaryRoot_LinkLabel As LinkLabel
End Class
