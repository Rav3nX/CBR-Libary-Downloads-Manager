<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibaryViewer
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.LibaryPlane = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComicInfoDB1 = New CBR_Libary_Checker.ComicInfoDB()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        CType(Me.ComicInfoDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(895, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 505)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(895, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'LibaryPlane
        '
        Me.LibaryPlane.AutoScroll = True
        Me.LibaryPlane.BackColor = System.Drawing.Color.White
        Me.LibaryPlane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibaryPlane.Location = New System.Drawing.Point(246, 25)
        Me.LibaryPlane.Name = "LibaryPlane"
        Me.LibaryPlane.Size = New System.Drawing.Size(649, 480)
        Me.LibaryPlane.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 480)
        Me.Panel1.TabIndex = 3
        '
        'ComicInfoDB1
        '
        Me.ComicInfoDB1.DataSetName = "ComicInfoDB"
        Me.ComicInfoDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(3, 78)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(237, 399)
        Me.TreeView1.TabIndex = 0
        '
        'LibaryViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 530)
        Me.Controls.Add(Me.LibaryPlane)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "LibaryViewer"
        Me.Text = "LibaryViewer"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ComicInfoDB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents LibaryPlane As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComicInfoDB1 As ComicInfoDB
    Friend WithEvents TreeView1 As TreeView
End Class
