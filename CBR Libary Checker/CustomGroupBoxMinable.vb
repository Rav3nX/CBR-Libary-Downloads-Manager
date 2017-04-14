Option Strict Off

Imports System.ComponentModel
Imports System.ComponentModel.Design




<Designer("System.Windows.Forms.Design.ParentControlDesigner, 
   System.Design", GetType(IDesigner))>
Public Class CustomGroupBoxMinable


    Public Minimised As Boolean = False
    Public ExpandedHeight As Integer
    Public PanelHeightVal As Integer = 26
    Public Notation_Visible As Boolean = False
    Public Event Expanded_Changed()


    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Overrides Property Text() As String
        Get
            Return HeaderLabel.Text
        End Get
        Set(ByVal Value As String)
            HeaderLabel.Text = Value
        End Set
    End Property

    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Property ISExpandedHeightSiz() As Integer
        Get
            Return ExpandedHeight
        End Get
        Set(ByVal Value As Integer)
            ExpandedHeight = Value
            Me.Height = ExpandedHeight
        End Set
    End Property

    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Property IsMinimised() As Boolean
        Get
            Return Minimised
        End Get
        Set(ByVal Value As Boolean)
            Minimised = Value
            SetState()
        End Set
    End Property

    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Property TitleHeight() As Integer
        Get
            Return PanelHeightVal
        End Get
        Set(ByVal Value As Integer)
            PanelHeightVal = Value
            SetPanelHeight(Value)
        End Set
    End Property
    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Property NotationText() As String
        Get
            Return Nothing 'Notation_Label.Text
        End Get
        Set(ByVal Value As String)
            'Notation_Label.Text = Value
        End Set
    End Property
    <EditorBrowsable(EditorBrowsableState.Always)>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Property NotationVisible() As Boolean
        Get
            Return Nothing 'Notation_Label.Visible
        End Get
        Set(ByVal Value As Boolean)
            ' Notation_Label.Visible = Value
        End Set
    End Property

    Public Sub SetPanelHeight(PanelHeight As Integer)
        PanelHeightVal = PanelHeight
        Panel2.Height = PanelHeightVal
    End Sub





    Private Sub SetState()
        If Minimised Then
            ExpandedHeight = Me.Height
            Me.Height = HeaderLabel.Height
            Label1.Text = "Expand +"
            Label1.ForeColor = Color.Lime
        Else
            Label1.Text = "Shrink +"
            Label1.ForeColor = Color.Salmon
            Me.Height = ExpandedHeight
        End If
    End Sub

    Public Sub Expand()
        Me.Height = ExpandedHeight
    End Sub
    Public Sub Shrink()
        Me.Height = Panel2.Height

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Minimised = Not (Minimised)
        SetState()
        RaiseEvent Expanded_Changed()
    End Sub

    Private Sub CustomGroupBoxMinable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomGroupBoxMinable_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.IsMinimised Then Me.Height = PanelHeightVal
    End Sub
End Class
