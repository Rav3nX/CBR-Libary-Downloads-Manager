<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyProgDialog
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Progress_Label = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CurrentFileNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 66)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(380, 23)
        Me.ProgressBar.TabIndex = 0
        '
        'Progress_Label
        '
        Me.Progress_Label.Location = New System.Drawing.Point(12, 34)
        Me.Progress_Label.Name = "Progress_Label"
        Me.Progress_Label.Size = New System.Drawing.Size(380, 29)
        Me.Progress_Label.TabIndex = 1
        Me.Progress_Label.Text = "Progress...."
        Me.Progress_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.CBR_Libary_Checker.My.Resources.Resources.BlueSpots
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(404, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(296, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CurrentFileNameLabel
        '
        Me.CurrentFileNameLabel.Location = New System.Drawing.Point(12, 92)
        Me.CurrentFileNameLabel.Name = "CurrentFileNameLabel"
        Me.CurrentFileNameLabel.Size = New System.Drawing.Size(380, 23)
        Me.CurrentFileNameLabel.TabIndex = 4
        Me.CurrentFileNameLabel.Text = "Filename"
        Me.CurrentFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CopyProgDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 149)
        Me.Controls.Add(Me.CurrentFileNameLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Progress_Label)
        Me.Controls.Add(Me.ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CopyProgDialog"
        Me.Text = "Copy Progress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Button1 As Button
    Public WithEvents ProgressBar As ProgressBar
    Public WithEvents Progress_Label As Label
    Public WithEvents CurrentFileNameLabel As Label
End Class
