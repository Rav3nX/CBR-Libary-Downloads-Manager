<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibaryFolderDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LibraryRootPATH_TextBox = New System.Windows.Forms.TextBox()
        Me.Set_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Browse_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(166, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Library Root Folder:"
        '
        'LibraryRootPATH_TextBox
        '
        Me.LibraryRootPATH_TextBox.Location = New System.Drawing.Point(169, 56)
        Me.LibraryRootPATH_TextBox.Name = "LibraryRootPATH_TextBox"
        Me.LibraryRootPATH_TextBox.Size = New System.Drawing.Size(452, 26)
        Me.LibraryRootPATH_TextBox.TabIndex = 1
        Me.LibraryRootPATH_TextBox.Text = "\\RAVIENSERVER\Comics\Comics"
        '
        'Set_Button
        '
        Me.Set_Button.Location = New System.Drawing.Point(579, 108)
        Me.Set_Button.Name = "Set_Button"
        Me.Set_Button.Size = New System.Drawing.Size(123, 23)
        Me.Set_Button.TabIndex = 2
        Me.Set_Button.Text = "Set"
        Me.Set_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(498, 108)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Browse_Button
        '
        Me.Browse_Button.Location = New System.Drawing.Point(627, 56)
        Me.Browse_Button.Name = "Browse_Button"
        Me.Browse_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse_Button.TabIndex = 4
        Me.Browse_Button.Text = "Browse..."
        Me.Browse_Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CBR_Libary_Checker.My.Resources.Resources.Dark_Horse_v2_icon
        Me.PictureBox1.Location = New System.Drawing.Point(10, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LibaryFolderDialog
        '
        Me.AcceptButton = Me.Set_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(729, 183)
        Me.Controls.Add(Me.Browse_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Set_Button)
        Me.Controls.Add(Me.LibraryRootPATH_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LibaryFolderDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libary Folder Location"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LibraryRootPATH_TextBox As TextBox
    Friend WithEvents Set_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Browse_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
