Option Strict On



Public Class TabFunctions

#Region "General Tab Page Handling"

    Public Shared Function TAB_OpenNewTabedForm(sender As System.Object, NewForm As System.Windows.Forms.Form, Optional AsTab As Boolean = True) As Form

        If AsTab Then
            Dim NewTab As New TabPage
            NewForm.TopLevel = False
            NewForm.FormBorderStyle = FormBorderStyle.None
            NewForm.Parent = NewTab
            NewForm.Dock = DockStyle.Fill
            NewForm.Visible = True
            NewTab.Text = NewForm.Text
            NewTab.Name = NewForm.Name
            Main.TabPlane.TabPages.Add(NewTab)
            Main.TabPlane.SelectedTab = NewTab
        Else
            NewForm.Show()
        End If
        Return NewForm

    End Function

    Public Shared Sub TAB_OpenTabedUserControl(sender As System.Object, control As Control)
        Dim NewTab As New TabPage
        NewTab.Controls.Add(control)
        control.Dock = DockStyle.Fill
        'ExtensionMethods.DoubleBufferedTab(NewTab, True)
        Main.TabPlane.TabPages.Add(NewTab)
        Main.TabPlane.SelectedTab = NewTab
    End Sub

    Public Shared Sub SetTabText(sender As System.Windows.Forms.Form, TitleText As String)
        Try
            If Not (sender.Parent Is Nothing) Then
                If sender.Parent.GetType() Is GetType(TabPage) Then
                    sender.Parent.Text = TitleText
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Sub CloseME(sender As System.Windows.Forms.Form)
        'Try
        If Not (sender.Parent Is Nothing) Then

            If sender.Parent.GetType() Is GetType(TabPage) Then
                sender.Parent.Dispose()
            Else
                sender.Close()
            End If
        End If

        'Catch ex As Exception
        'End Try
        Try
            sender.Close()
        Catch ex As Exception

        End Try


    End Sub

#End Region

End Class
