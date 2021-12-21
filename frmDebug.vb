Public Class frmDebug
    Public ConsoleInput As String
    Private Sub frmDebug_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowHelp()
        ShowPrompt()
        ConsoleIO.SelectionStart = ConsoleIO.TextLength
    End Sub

    Private Sub frmDebug_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ConsoleIO.Width = Me.Width - 3
        ConsoleIO.Height = Me.Height - 23
    End Sub

    Public Sub ClearConfig()
        My.Settings.VMRoutes = ""
        My.Settings.VMIcons = ""
        My.Settings.VMNames = ""
        My.Settings.VMType = ""
        My.Settings.vMacROM = ""
        My.Settings.BasiliskROM = ""
        My.Settings.SheepShaverROM = ""
        My.Settings.x = ""
        My.Settings.DefaultMacFolder = ""
        My.Settings.Save()
        ConsoleIO.Text = ConsoleIO.Text & vbCrLf & vbCrLf & "App configuration cleared." & vbCrLf
    End Sub

    Public Sub ShowPrompt()
        ConsoleIO.Text = ConsoleIO.Text & vbCrLf & "Debug prompt\> "
        ConsoleIO.SelectionStart = ConsoleIO.TextLength
    End Sub

    Public Sub ShowConfig()
        Dim TextToShow As String = ""
        TextToShow = "Mini vMac ROM = " & My.Settings.vMacROM
        TextToShow = TextToShow & vbCrLf & "Basilisk ROM = " & My.Settings.BasiliskROM
        TextToShow = TextToShow & vbCrLf & "SheepShaver ROM = " & My.Settings.SheepShaverROM
        TextToShow = TextToShow & vbCrLf & "Mac VM Folders = " & My.Settings.DefaultMacFolder
        TextToShow = TextToShow & vbCrLf & "User Defined Icons = " & My.Settings.x
        TextToShow = TextToShow & vbCrLf & "Vm Icons = " & My.Settings.VMIcons
        TextToShow = TextToShow & vbCrLf & "VM Names = " & My.Settings.VMNames
        TextToShow = TextToShow & vbCrLf & "VM Types (Subitem2) = " & My.Settings.VMType
        TextToShow = TextToShow & vbCrLf & "VM Routes (Subitem1) = " & My.Settings.VMRoutes
        ConsoleIO.Text = ConsoleIO.Text & vbCrLf & TextToShow & vbCrLf
    End Sub

    Public Sub ShowHelp()
        ConsoleIO.Text = ConsoleIO.Text & vbCrLf & "Avaible commands are" & vbCrLf & vbCrLf & "show_config          Shows the current values of the configuration" & vbCrLf & "clear_config          Clears all the config values" & vbCrLf & "help          Shows this help" & vbCrLf & "cls          Clears the screen" & vbCrLf
    End Sub

    Private Sub ConsoleIO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ConsoleIO.KeyDown
        If e.KeyData = Keys.Back Then
            If ConsoleInput <> "" Then
                ConsoleInput.Remove(ConsoleInput.Length - 1, 1)
                ConsoleIO.Text.Remove(ConsoleIO.TextLength - 1, 1)
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConsoleIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ConsoleIO.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) = True Then
            ConsoleInput = ConsoleInput & e.KeyChar.ToString
            ConsoleIO.SelectionStart = ConsoleIO.TextLength
        End If
    End Sub

    Private Sub ConsoleIO_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ConsoleIO.KeyUp
        If e.KeyData = Keys.Return Then
            e.Handled = True
            Select Case ConsoleInput
                Case "clear_config"
                    ClearConfig()
                Case "show_config"
                    ShowConfig()
                Case "help"
                    ShowHelp()
                Case "cls"
                    ClearScreen()
                Case "show_console"
                    frmMain.Show()
            End Select

EndCheck:
            ConsoleInput = ""
            ShowPrompt()
        End If
        If e.KeyData = Keys.Back Then
            e.Handled = True
            ConsoleInput = Mid(ConsoleInput, 1, ConsoleInput.Length - 1)
        End If
    End Sub

    Public Sub ClearScreen()
        ConsoleIO.Text = " "
    End Sub

    Private Sub MenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
End Class