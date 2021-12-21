Public Class frmMain
    Public Sub LoadSettings()
        Dim VMNames() As String = Split(My.Settings.VMNames, ",")
        Dim VMRoutes() As String = Split(My.Settings.VMRoutes, ",")
        Dim VMIcons() As String = Split(My.Settings.VMIcons, ",")
        Dim VMTypes() As String = Split(My.Settings.VMType, ",")

        If Microsoft.VisualBasic.Command = "/debug" Then
            Me.mnuFileDebug.Visible = True
        Else
            Me.mnuFileDebug.Visible = False
        End If

        If VMNames.Length > 1 Then
            For x As Integer = 0 To VMNames.Length - 2
                If VMIcons(x) = -1 Or VMIcons(x) = "" Then
                    VMIcons(x) = 0
                End If
                With VMList.Items.Add(VMNames(x))
                    .StateImageIndex = 0
                    .SubItems.Add(VMRoutes(x))
                    .SubItems.Add(VMTypes(x))
                End With
            Next
        End If
    End Sub

    Public Sub SaveSettings()
        Dim VMNames As String = ""
        Dim VMIcons As String = ""
        Dim VMRoutes As String = ""
        Dim VMTypes As String = ""
        Dim CustomIcons As String = ""

        For x As Integer = 0 To VMList.Items.Count - 1
            If VMList.Items(x).StateImageIndex = -1 Then
                VMList.Items(x).StateImageIndex = 0
            End If
        Next

        For x As Integer = 0 To VMList.Items.Count - 1
            VMNames = VMNames & VMList.Items(x).Text & ","
            VMIcons = VMIcons & VMList.Items(x).StateImageIndex & ","
            VMRoutes = VMRoutes & VMList.Items(x).SubItems(1).Text & ","
            VMTypes = VMTypes & VMList.Items(x).SubItems(2).Text & ","
        Next

        My.Settings.VMNames = VMNames
        My.Settings.VMIcons = VMIcons
        My.Settings.VMRoutes = VMRoutes
        My.Settings.VMType = VMTypes
        My.Settings.Save()

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
    End Sub

    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        GetSysInfo()
        VirtualMacTray.Visible = True
        LoadSettings()
    End Sub

    Private Sub frmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        SaveSettings()

        If Me.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then
            SaveSetting(My.Application.Info.Title, "Settings", "MainLeft", CStr(VB6.PixelsToTwipsX(Me.Left)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainTop", CStr(VB6.PixelsToTwipsY(Me.Top)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainWidth", CStr(VB6.PixelsToTwipsX(Me.Width)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainHeight", CStr(VB6.PixelsToTwipsY(Me.Height)))
        End If

    End Sub

    Public Sub StartEmulation(ByVal ConfigPath As String)
        Dim Reader As New System.IO.StreamReader(ConfigPath, True)
        Dim Line As String
        Dim Lines As New ArrayList

        Do
            Line = Reader.ReadLine()
            If Not Line Is Nothing Then
                Lines.Add(Line)
            End If
        Loop Until Line Is Nothing
        Reader.Close()

        If My.Settings.TestWindow = True Then
            frmVirtualMacintosh.Show()
            Exit Sub
        End If

        Select Case VMList.FocusedItem.SubItems(2).Text
            Case "vMac"
                If My.Computer.FileSystem.FileExists(My.Settings.vMacPath) = True Then
                    frmVirtualMacintosh.Text = VMList.Items(VMList.FocusedItem.Index).Text & " - Virtual Mac"
                    Shell(My.Settings.vMacPath & " " & Chr(34) & Lines(0) & Chr(34), AppWinStyle.NormalFocus)
                End If
            Case "BII"
                If My.Computer.FileSystem.FileExists(My.Settings.BasiliskPath) = True Then
                    Shell(My.Settings.BasiliskPath & " " & Chr(34) & VMList.FocusedItem.SubItems(1).Text & Chr(34), AppWinStyle.NormalFocus)
                End If
            Case "SheepShaver"
                If My.Computer.FileSystem.FileExists(My.Settings.SheepShaverPath) = True Then
                    Shell(My.Settings.SheepShaverPath & " " & Chr(34) & VMList.FocusedItem.SubItems(1).Text & Chr(34), AppWinStyle.NormalFocus)
                End If
            Case "PearPC"
                If My.Computer.FileSystem.FileExists(My.Settings.PearPCPath) = True Then
                    MsgBox("cmd.exe /k " & My.Settings.PearPCPath & " " & Chr(34) & VMList.FocusedItem.SubItems(1).Text & Chr(34))
                    Shell("cmd.exe /k " & My.Settings.PearPCPath & " " & Chr(34) & VMList.FocusedItem.SubItems(1).Text & Chr(34), AppWinStyle.NormalFocus)
                End If
            Case "QEMU"
                If My.Computer.FileSystem.FileExists(My.Settings.QEMUPath) = True Then
                    Shell(My.Settings.QEMUPath & " " & Lines(0), AppWinStyle.NormalFocus)
                End If
        End Select

    End Sub

    Public Sub EnableButtons()

        mnuActionStart.Enabled = True
        'mnuActionPause.Enabled = True
        'mnuActionRestart.Enabled = True

        mnuActionRemove.Enabled = True
        mnuActionSettings.Enabled = True

        'mnuActionProperties.Enabled = True

        ButtonSettings.Enabled = True
        ButtonRemove.Enabled = True
        ButtonStart.Enabled = True

    End Sub

    Public Sub RemoveSelectedMac()

        'Declarations
        Dim Selection As Boolean
        Dim Answer As Short

        'Checks that you have a machine selected
        If VMList.FocusedItem.Index <> -1 Then
            Selection = True
        End If

        'Asks you if you really want to delete the machine
        If Selection = True Then
            Answer = MsgBox("Are you sure you want to remove ''" & VMList.Items(VMList.FocusedItem.Index).Text & "'' Mac from the Virtual Mac Console?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Virtual Mac")

            'If you don't want that old Mac Plus, this
            'is where it's deleted and recycled (Maybe)
            If Answer = 6 Then
                'Let's ask if user wants to keep files
                If MsgBox("Do you want to delete the associated files? This will delete ALL the files in the folder ''" & VMList.FocusedItem.Text & "''", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete files") = MsgBoxResult.Yes Then
                    'If user needs disk space...
                    My.Computer.FileSystem.DeleteDirectory(System.IO.Path.GetDirectoryName(VMList.FocusedItem.SubItems(1).Text), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    VMList.Items.RemoveAt(VMList.FocusedItem.Index)
                    DisableButtons() 'Disable the buttons
                Else
                    'If user just gets annoyed with the item but wants the files...
                    VMList.Items.RemoveAt(VMList.FocusedItem.Index)
                    DisableButtons() 'Disable the buttons
                End If
            End If
        End If

    End Sub

    Private Sub NewMac_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButtonNewM.Click
        frmNewMac.Show()
    End Sub

    Private Sub Remove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButtonRemove.Click
        RemoveSelectedMac()
    End Sub

    Private Sub Settings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButtonSettings.Click
        OpenSettings()
    End Sub

    Private Sub Start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButtonStart.Click
        StartEmulation(VMList.FocusedItem.SubItems(1).Text)
    End Sub

    Public Sub DisableButtons()

        mnuActionStart.Enabled = False
        mnuActionPause.Enabled = False
        mnuActionRestart.Enabled = False
        mnuActionRemove.Enabled = False
        mnuActionSettings.Enabled = False
        mnuActionProperties.Enabled = False
        ButtonSettings.Enabled = False
        ButtonRemove.Enabled = False
        ButtonStart.Enabled = False

    End Sub

    Public Sub UnloadAll()

        If frmVirtualMacintosh.Visible = True Then
            frmVirtualMacintosh.Close()
        End If

        If frmOptions.Visible = True Then
            frmOptions.Close()
        End If

        If frmSettingsSheepVM.Visible = True Then
            frmSettingsSheepVM.Close()
        End If

        If frmNewMac.Visible = True Then
            frmNewMac.Close()
        End If

        'If frmNewDisk.Visible = True Then
        'frmNewDisk.Close()
        'End If

        Me.Close()

        End

    End Sub

    Private Sub IconNewMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayNewMac.Click
        frmNewMac.Show()
        frmNewMac.Focus()
    End Sub

    Private Sub IconNewDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayNewDisk.Click
        'frmNewDisk.Show()
    End Sub

    Private Sub IconOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayOptions.Click
        frmOptions.Show()
    End Sub

    Private Sub IconExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayExit.Click
        frmVirtualMacintosh.Close()
        frmNewMac.Close()
        'frmNewDisk.Close()
        frmSplash.Close()
        frmSettingsSheepVM.Close()
        frmOptions.Close()
        frmAbout.Close()
        Me.Close()
    End Sub

    Private Sub TrayShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayShow.Click
        Me.Visible = True
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        Me.BringToFront()
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            Me.Visible = False
        End If
        Me.Width = 371
    End Sub

    Private Sub VirtualMacTray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VirtualMacTray.MouseDoubleClick
        Me.Visible = True
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        Me.BringToFront()
    End Sub

    Private Sub VMList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VMList.Click
        EnableButtons()
    End Sub

    Private Sub ChangeIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewIcon.Click
        Dim User As Integer = MacIcons.Images.Count
        Dim Picture As System.Drawing.Image

        Browser.Filter = "Picture files(*.jpg;*.png;*.bmp;*.ico)|*.jpg;*.png;*.bmp;*.ico|All files (*.*)|*.*"
        Browser.ShowDialog()

        If Not Browser.FileName = "" Then
            Picture = Image.FromFile(Browser.FileName)
            MacIcons.Images.Add(User, Picture)
            VMList.FocusedItem.StateImageIndex = User
        End If
    End Sub

    Private Sub mnuFileOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOptions.Click
        frmOptions.Show()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub mnuFileDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileDebug.Click
        frmDebug.Show()
    End Sub

    Private Sub mnuFileNewMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNewMac.Click
        frmNewMac.Show()
    End Sub

    Private Sub mnuFileNewDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNewDisk.Click
        frmNewDisk.Show()
    End Sub

    Private Sub VMList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles VMList.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            Dim x As String = CType(e.Data.GetData(DataFormats.FileDrop, True), String())(0)
            ConfigFileHandler.CreateFromFile(DetectEmulator, x, InputBox("Write the name for the new Mac", "Creating new Mac from a file"))
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpCrash.Click
        'This instruction is WRONG purposedly, it's for crashing the program. This will be used for handling crashes
        Dim x() As String = Split("crashing,instruction", ",")
        MsgBox(x(3))
    End Sub

    Private Sub VMList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles VMList.DragEnter
        e.Effect = e.AllowedEffect And DragDropEffects.Copy
    End Sub

    Public Function DetectEmulator() As String
        Dim Emulator As String = "Unknown"
        Dim EmulatorDialog As New Form
        Dim OKButton As New Button
        Dim CancelButton As New Button
        Dim EmulatorTypes As New ComboBox

        EmulatorTypes.Items.Add("Basilisk II preferences file")
        EmulatorTypes.Items.Add("SheepShaver preferences file")
        EmulatorTypes.Items.Add("PearPC config file")
        EmulatorTypes.Items.Add("QEMU Batch")
        EmulatorTypes.SelectedIndex = 0
        EmulatorTypes.DropDownStyle = ComboBoxStyle.DropDownList

        EmulatorDialog.Width = 400
        EmulatorDialog.Height = 160
        EmulatorDialog.FormBorderStyle = Forms.FormBorderStyle.FixedDialog
        EmulatorDialog.Controls.Add(OKButton)
        EmulatorDialog.Controls.Add(CancelButton)
        EmulatorDialog.Controls.Add(EmulatorTypes)

        EmulatorTypes.Left = (EmulatorDialog.Width / 2) - (EmulatorTypes.Width / 2)
        EmulatorTypes.Top = 40
        OKButton.Top = EmulatorDialog.Height - OKButton.Height - 30
        OKButton.Left = EmulatorDialog.Width - OKButton.Width - CancelButton.Width - 20
        CancelButton.Top = EmulatorDialog.Height - CancelButton.Height - 30
        CancelButton.Left = EmulatorDialog.Width - CancelButton.Width - 20

        EmulatorDialog.ShowDialog()

        Select Case EmulatorTypes.SelectedIndex
            Case 0
                Emulator = "vMac"
            Case 1
                Emulator = "BII"
            Case 2
                Emulator = "ShhepShaver"
            Case 3
                Emulator = "PearPC"
            Case 4
                Emulator = "QEMU"
        End Select

        Return Emulator
    End Function

    Public Sub OpenSettings()
        Select Case VMList.FocusedItem.SubItems(2).Text
            Case "vMac"
                '    frmSettingsPearPCVM.Text = Replace(frmSettingsPearPCVM.Text, "%s", VMList.FocusedItem.Text)
                '    frmSettingsPearPCVM.LoadSettingsFrom(VMList.FocusedItem.SubItems(1).Text)
                '    frmSettingsPearPCVM.Show()
            Case "BII"
                frmSettingsBasiliskVM.Text = Replace(frmSettingsBasiliskVM.Text, "%s", VMList.FocusedItem.Text)
                frmSettingsBasiliskVM.LoadSettingsFrom(VMList.FocusedItem.Index)
                frmSettingsBasiliskVM.Show()
            Case "SheepShaver"
                frmSettingsSheepVM.Text = Replace(frmSettingsSheepVM.Text, "%s", VMList.FocusedItem.Text)
                frmSettingsSheepVM.LoadSettingsFrom(VMList.FocusedItem.Index)
                frmSettingsSheepVM.Show()
            Case "QEMU"
                frmSettingsQemuVM.Text = Replace(frmSettingsSheepVM.Text, "%s", VMList.FocusedItem.Text)
                'frmSettingsQemuVM.LoadSettingsFrom(VMList.FocusedItem.Index)
                frmSettingsQemuVM.Show()
            Case "PearPC"
                frmSettingsPearPCVM.Text = Replace(frmSettingsSheepVM.Text, "%s", VMList.FocusedItem.Text)
                frmSettingsPearPCVM.LoadSettingsFrom(VMList.FocusedItem.Index)
                frmSettingsPearPCVM.Show()
        End Select
    End Sub

    Private Sub mnuActionSettings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuActionSettings.Click
        OpenSettings()
    End Sub

    Private Sub mnuHelpContents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpContents.Click
        frmHelp.Show()
    End Sub

    Private Sub mnuHelpOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpOnline.Click
        Process.Start("https://edsonarmando.000webhostapp.com/personal/virtualmac/")
    End Sub
End Class