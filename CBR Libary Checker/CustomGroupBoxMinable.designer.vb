<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomGroupBoxMinable
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.Notation_Label = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BackgroundImage = My.Resources.Resources.BlueSpots
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Notation_Label)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.HeaderLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 22)
        Me.Panel2.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Salmon
        Me.Label1.Location = New System.Drawing.Point(311, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Shrink -"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HeaderLabel
        '
        Me.HeaderLabel.BackColor = System.Drawing.Color.Transparent
        Me.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderLabel.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(369, 20)
        Me.HeaderLabel.TabIndex = 42
        Me.HeaderLabel.Text = "Category Certification"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Notation_Label
        '
        Me.Notation_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notation_Label.BackColor = System.Drawing.Color.Transparent
        Me.Notation_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notation_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Notation_Label.Location = New System.Drawing.Point(216, 0)
        Me.Notation_Label.Name = "Notation_Label"
        Me.Notation_Label.Size = New System.Drawing.Size(70, 22)
        Me.Notation_Label.TabIndex = 56
        Me.Notation_Label.Text = "Bkdhskjfhakjdshgf"
        Me.Notation_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Notation_Label.Visible = False
        '
        'CustomGroupBoxMinable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CustomGroupBoxMinable"
        Me.Size = New System.Drawing.Size(371, 246)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents HeaderLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Public WithEvents Notation_Label As Label
End Class
