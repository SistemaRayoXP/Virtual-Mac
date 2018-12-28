Public Class frmHelp
    Public InitialUrl As String = ""
    Public Sub SetInitialLocation(ByVal NewUrl As String)
        InitialUrl = NewUrl
    End Sub

    Private Sub frmHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If InitialUrl <> "" Then
            HelpRenderer.Navigate(InitialUrl)
        Else
            HelpRenderer.Navigate("http://emaculation.com/doku.php")
        End If
    End Sub

    Private Sub GoHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoHome.Click
        HelpRenderer.Navigate("http://emaculation.com/doku.php")
    End Sub

    Private Sub GoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBack.Click
        If HelpRenderer.CanGoBack = True Then
            HelpRenderer.GoBack()
        Else
            GoBack.Enabled = False
        End If
    End Sub

    Private Sub GoForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoForward.Click
        If HelpRenderer.CanGoForward = True Then
            HelpRenderer.GoForward()
        Else
            GoForward.Enabled = False
        End If
    End Sub

    Private Sub HelpRenderer_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles HelpRenderer.DocumentCompleted
        If HelpRenderer.CanGoBack = True Then
            GoBack.Enabled = True
        Else
            GoBack.Enabled = False
        End If
        If HelpRenderer.CanGoForward = True Then
            GoForward.Enabled = True
        Else
            GoForward.Enabled = False
        End If
    End Sub

    Private Sub SearchBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.GotFocus
        SearchBox.ForeColor = System.Windows.Forms.Control.DefaultForeColor
        If SearchBox.Text = "Search..." Then
            SearchBox.Text = ""
        End If
    End Sub

    Private Sub SearchBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.LostFocus
        If SearchBox.Text = "" Then
            SearchBox.Text = "Search..."
        End If
        SearchBox.ForeColor = Color.Gray
    End Sub

    Private Sub SearchBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyDown
        e.Handled = True
        If e.KeyData = Keys.Return Then
            SearchStart_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub SearchBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SearchBox.KeyPress
        If Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub SearchBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyUp
        e.Handled = True
    End Sub

    Private Sub SearchBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.TextChanged
        If SearchBox.Text <> "" Then
            SearchStart.Enabled = True
        ElseIf SearchBox.Text = "Search..." Then
            SearchStart.Enabled = False
        Else
            SearchStart.Enabled = False
        End If
    End Sub

    Private Sub SearchStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStart.Click
        Dim SearchTerm As String = SearchBox.Text
        Dim SearchUrl As String = "https://www.emaculation.com/doku.php/mac_emulation?do=search&q="
        HelpRenderer.Navigate(SearchUrl + SearchTerm)
    End Sub

    Private Sub frmHelp_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        HelpRenderer.Height = Me.ClientSize.Height - NavigationBar.Height
    End Sub
End Class