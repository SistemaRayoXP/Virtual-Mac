Option Strict Off
Option Explicit On
Friend Class frmSplash
    Inherits System.Windows.Forms.Form

    Private Sub frmSplash_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        'This has to be included here too, so that this setting also affects the loading form
        Select Case My.Settings.Lang
            Case "en-US"
                My.Application.ChangeUICulture("en-US")
            Case "es-MX"
                My.Application.ChangeUICulture("es-MX")
            Case "de-DE"
                My.Application.ChangeUICulture("de-DE")
        End Select
    End Sub
End Class