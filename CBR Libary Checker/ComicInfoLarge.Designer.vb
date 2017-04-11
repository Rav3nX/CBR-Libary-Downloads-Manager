<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComicInfoLarge
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FileNameLabel = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.MiscLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 118)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FileNameLabel
        '
        Me.FileNameLabel.Location = New System.Drawing.Point(135, 3)
        Me.FileNameLabel.Name = "FileNameLabel"
        Me.FileNameLabel.Size = New System.Drawing.Size(449, 43)
        Me.FileNameLabel.TabIndex = 1
        Me.FileNameLabel.Text = "Label1"
        '
        'LocationLabel
        '
        Me.LocationLabel.Location = New System.Drawing.Point(135, 46)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(449, 30)
        Me.LocationLabel.TabIndex = 2
        Me.LocationLabel.Text = "Label2"
        '
        'MiscLabel
        '
        Me.MiscLabel.AutoSize = True
        Me.MiscLabel.Location = New System.Drawing.Point(138, 94)
        Me.MiscLabel.Name = "MiscLabel"
        Me.MiscLabel.Size = New System.Drawing.Size(0, 13)
        Me.MiscLabel.TabIndex = 3
        '
        'ComicInfoLarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.MiscLabel)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.FileNameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ComicInfoLarge"
        Me.Size = New System.Drawing.Size(585, 124)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FileNameLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents MiscLabel As Label
End Class
