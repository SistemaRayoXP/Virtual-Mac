Option Strict Off
Option Explicit On
Friend Class frmSplash
    Inherits System.Windows.Forms.Form

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
    End Sub
End Class