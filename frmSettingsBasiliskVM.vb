Imports System
Imports System.IO
Imports System.Collections
Public Class frmSettingsBasiliskVM
    Public ConfigFile As String
    Public VMName As String
    Public SelectedItem As Integer
    Public Sub LoadSettingsFrom(Item As Integer)
        ConfigFile = frmMain.VMList.Items.Item(Item).SubItems(1).Text
        VMName = frmMain.VMList.Items.Item(Item).Text
        SelectedItem = Item
    End Sub

    Public Sub Settings()
        
        Dim Reader As New StreamReader(ConfigFile)
        Dim ConfigValues As New ArrayList()
        Dim strContainer As String = ""

        Do
            strContainer = Reader.ReadLine()
            If Not strContainer Is Nothing Then
                ConfigValues.Add(strContainer)
            End If
        Loop Until strContainer Is Nothing
        Reader.Close()

        For x As Integer = 0 To ConfigValues.Count - 1
            If InStr(ConfigValues(x), "disk") <> 0 Then
                With DriveList.Items.Add(ConfigValues(x).ToString.Substring(5))
                    .ImageKey = "Drive"
                    .SubItems.Add("Disk")
                    .SubItems.Add("")
                End With
            End If

            If InStr(ConfigValues(x), "floppy") <> 0 Then
                With DriveList.Items.Add(ConfigValues(x).ToString.Substring(7))
                    .ImageKey = "Floppy"
                    .SubItems.Add("Floppy")
                    .SubItems.Add("")
                End With
            End If

            If ConfigValues(x).ToString.Substring(0, 5) = "cdrom" Then
                With DriveList.Items.Add(ConfigValues(x).ToString.Substring(6))
                    .ImageKey = "Disc"
                    .SubItems.Add("CD")
                    .SubItems.Add("")
                End With
            End If

            If InStr(ConfigValues(x), "screen") <> 0 Then
                Dim a As String = ConfigValues(x).ToString.Substring(7)
                Dim b() As String = Split(a, "/")
                Dim FoundX As Boolean = False
                Dim FoundY As Boolean = False

                Select Case b(0)
                    Case "win"
                        ScrMode.SelectedIndex = 0
                    Case "dga"
                        ScrMode.SelectedIndex = 1
                End Select

                For c As Integer = 0 To ScrResY.Items.Count - 1
                    If FoundX = True And FoundY = True Then
                        Exit For
                    End If

                    If InStr(ScrResX.Items.Item(c).ToString, b(1)) <> 0 Then
                        ScrResX.SelectedIndex = c
                        FoundX = True
                    ElseIf c = ScrResX.Items.Count - 1 And FoundX = False Then
                        ScrResX.Items.Add(b(1))
                        ScrResX.SelectedIndex = ScrResX.Items.Count - 1
                    End If

                    If InStr(ScrResY.Items.Item(c).ToString, b(2)) <> 0 Then
                        ScrResY.SelectedIndex = c
                        FoundY = True
                    ElseIf c = ScrResY.Items.Count - 1 And FoundY = False Then
                        ScrResY.Items.Add(b(2))
                        ScrResY.SelectedIndex = ScrResY.Items.Count - 1
                    End If
                Next
            End If

            If InStr(ConfigValues(x), "seriala") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "COM1"
                        SerialA.SelectedIndex = 0
                    Case "COM2"
                        SerialA.SelectedIndex = 1
                    Case "COM3"
                        SerialA.SelectedIndex = 2
                    Case "COM4"
                        SerialA.SelectedIndex = 3
                    Case "COM5"
                        SerialA.SelectedIndex = 4
                    Case "COM6"
                        SerialA.SelectedIndex = 5
                    Case "LPT1"
                        SerialA.SelectedIndex = 6
                    Case "LPT2"
                        SerialA.SelectedIndex = 7
                    Case "LPT3"
                        SerialA.SelectedIndex = 8
                    Case "LPT4"
                        SerialA.SelectedIndex = 9
                    Case "LPT5"
                        SerialA.SelectedIndex = 10
                    Case "LPT6"
                        SerialA.SelectedIndex = 11
                    Case "FILE"
                        SerialA.SelectedIndex = 12
                End Select
            End If

            If InStr(ConfigValues(x), "serialb") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "COM1"
                        SerialB.SelectedIndex = 0
                    Case "COM2"
                        SerialB.SelectedIndex = 1
                    Case "COM3"
                        SerialB.SelectedIndex = 2
                    Case "COM4"
                        SerialB.SelectedIndex = 3
                    Case "COM5"
                        SerialB.SelectedIndex = 4
                    Case "COM6"
                        SerialB.SelectedIndex = 5
                    Case "LPT1"
                        SerialB.SelectedIndex = 6
                    Case "LPT2"
                        SerialB.SelectedIndex = 7
                    Case "LPT3"
                        SerialB.SelectedIndex = 8
                    Case "LPT4"
                        SerialB.SelectedIndex = 9
                    Case "LPT5"
                        SerialB.SelectedIndex = 10
                    Case "LPT6"
                        SerialB.SelectedIndex = 11
                    Case "FILE"
                        SerialB.SelectedIndex = 12
                End Select
            End If

            If InStr(ConfigValues(x), "ether") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(6)
                    Case "slirp"
                        NetType.SelectedIndex = 0
                    Case "router"
                        NetType.SelectedIndex = 1
                End Select
            End If

            If InStr(ConfigValues(x), "udpport") <> 0 Then
                NetUPDPort.Text = ConfigValues(x).ToString.Substring(8)
            End If

            If InStr(ConfigValues(x), "udptunnel") <> 0 Then
                If ConfigValues(x).ToString.Substring(10) = "true" Then
                    NetEnableUDP.Checked = True
                Else
                    NetEnableUDP.Checked = False
                End If
            End If

            If ConfigValues(x).ToString.Substring(0, 3) = "rom" Then
                MiscROM.Text = ConfigValues(x).ToString.Substring(4)
            End If

            If InStr(ConfigValues(x), "bootdrive") <> 0 Then
                Dim bd As Integer = ConfigValues(x).ToString.Substring(10)
                If bd <= DriveList.Items.Count Then
                    DriveList.Items.Item(bd).SubItems.Item(2).Text = "*"
                End If
            End If

            If InStr(ConfigValues(x), "bootdriver") Then
                Dim BootDriver As Integer = ConfigValues(x).ToString.Substring(11)
                Select Case BootDriver
                    Case 0
                        DriveBootDisk.Checked = True
                    Case -62
                        DriveBootCD.Checked = True
                End Select
            End If

            If InStr(ConfigValues(x), "ramsize") <> 0 Then
                Dim RAMMiB As Long = ConfigValues(x).ToString.Substring(7)
                RAMMiB = (RAMMiB / 1024) / 1024
                MemoryBox.Text = RAMMiB
            End If

            If InStr(ConfigValues(x), "frameskip") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(10)
                    Case "12"
                        ScrRefresh.SelectedIndex = 0
                    Case "8"
                        ScrRefresh.SelectedIndex = 1
                    Case "6"
                        ScrRefresh.SelectedIndex = 2
                    Case "4"
                        ScrRefresh.SelectedIndex = 3
                    Case "2"
                        ScrRefresh.SelectedIndex = 4
                    Case "1"
                        ScrRefresh.SelectedIndex = 5
                End Select
            End If

            If InStr(ConfigValues(x), "modelid") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "5"
                        MiscHwModel.SelectedIndex = 0
                    Case "14"
                        MiscHwModel.SelectedIndex = 1
                End Select
            End If

            If ConfigValues(x).ToString.Substring(0, 3) = "cpu" Then
                Select Case ConfigValues(x).ToString.Substring(4)
                    Case "2"
                        MiscHwCPU.SelectedIndex = 0
                    Case "3"
                        MiscHwCPU.SelectedIndex = 1
                    Case "4"
                        MiscHwCPU.SelectedIndex = 2
                End Select
            End If

            If ConfigValues(x).ToString.Substring(0, 3) = "fpu" Then
                Select Case ConfigValues(x).ToString.Substring(4)
                    Case "true"
                        MiscHwFPU.Checked = True
                    Case "false"
                        MiscHwFPU.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "nocdrom") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "false"
                        MiscHwCD.Checked = True
                    Case "true"
                        MiscHwCD.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "nosound") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "false"
                        MiscHwSound.Checked = True
                    Case "true"
                        MiscHwSound.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "nogui") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(6)
                    Case "false"
                        MiscEnableGUI.Checked = True
                    Case "true"
                        MiscEnableGUI.Checked = False
                End Select
            End If

            If ConfigValues(x).ToString.Substring(0, 3) = "jit" Then
                Select Case ConfigValues(x).ToString.Substring(4)
                    Case "true"
                        JITEnable.Checked = True
                    Case "false"
                        JITEnable.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "jitfpu") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(7)
                    Case "true"
                        JITFPU.Checked = True
                    Case "false"
                        JITFPU.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "jitdebug") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(9)
                    Case "true"
                        JITDebug.Checked = True
                    Case "false"
                        JITDebug.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "jitcachesize") <> 0 Then
                Dim Value As String = ConfigValues(x).ToString.Substring(13)
                Dim Found As Boolean

                For c As Integer = 0 To JITCacheSize.Items.Count - 1
                    If Found = True Then
                        Exit For
                    End If

                    If InStr(JITCacheSize.Items.Item(c).ToString, Value) <> 0 Then
                        JITCacheSize.SelectedIndex = c
                        Found = True
                    ElseIf c = JITCacheSize.Items.Count - 1 And Found = False Then
                        JITCacheSize.Items.Add(Value)
                        JITCacheSize.SelectedIndex = JITCacheSize.Items.Count - 1
                    End If
                Next
            End If

            If InStr(ConfigValues(x), "jitlazyflush") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(13)
                    Case "true"
                        JITLazyFlush.Checked = True
                    Case "false"
                        JITLazyFlush.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "jitinline") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(10)
                    Case "true"
                        JITInLine.Checked = True
                    Case "false"
                        JITInLine.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "keyboardtype") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(13)
                    Case "5"
                        InputEmuKbdType.SelectedIndex = 0
                    Case "6"

                    Case "7"

                    Case "8"

                    Case "9"

                    Case "10"

                    Case "11"
                        InputEmuKbdType.SelectedIndex = 1
                    Case "12"

                    Case "13"
                        InputEmuKbdType.SelectedIndex = 2
                End Select
            End If

            If InStr(ConfigValues(x), "keycodes") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(9)
                    Case "true"
                        InputKeycodesEnable.Checked = True
                    Case "false"
                        InputKeycodesEnable.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "keycodesfile") <> 0 Then
                InputKeyCodesPath.Text = ConfigValues(x).ToString.Substring(13)
            End If

            If InStr(ConfigValues(x), "mousewheelmode") <> 0 Then
                If InStr(ConfigValues(x).ToString.Substring(14), "0") Then
                    InputMouseWheelMode.SelectedIndex = 0
                End If
                If InStr(ConfigValues(x).ToString.Substring(14), "1") Then
                    InputMouseWheelMode.SelectedIndex = 1
                End If
            End If

            If InStr(ConfigValues(x), "mousewheellines") <> 0 Then
                Dim Number As Integer = ConfigValues(x).ToString.Substring(15)
                InputMouseWheelLines.Value = Number
            End If

            If InStr(ConfigValues(x), "ignoresegv") <> 0 Then
                If ConfigValues(x).ToString.Substring(11) = "true" Then
                    MiscIgnoreSegv.Checked = True
                Else
                    MiscIgnoreSegv.Checked = False
                End If
            End If

            If InStr(ConfigValues(x), "idlewait") <> 0 Then
                If ConfigValues(x).ToString.Substring(9) = "true" Then
                    MiscIdleWait.Checked = True
                Else
                    MiscIdleWait.Checked = False
                End If
            End If

            If InStr(ConfigValues(x), "enableextfs") <> 0 Then
                If ConfigValues(x).ToString.Substring(12) = "true" Then
                    ExtFSEnable.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "debugextfs") <> 0 Then
                If ConfigValues(x).ToString.Substring(11) = "true" Then
                    JITDebugExtFS.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "extdrives") <> 0 Then
                Dim StringValue As String = ConfigValues(x).ToString.Substring(10)
                For a As Integer = 0 To StringValue.Length - 1
                    Select Case StringValue.Substring(a, 1)
                        Case "C"
                            ExtFSDrives.SetItemCheckState(0, CheckState.Checked)
                        Case "D"
                            ExtFSDrives.SetItemCheckState(1, CheckState.Checked)
                        Case "E"
                            ExtFSDrives.SetItemCheckState(2, CheckState.Checked)
                        Case "F"
                            ExtFSDrives.SetItemCheckState(3, CheckState.Checked)
                        Case "G"
                            ExtFSDrives.SetItemCheckState(4, CheckState.Checked)
                        Case "H"
                            ExtFSDrives.SetItemCheckState(5, CheckState.Checked)
                        Case "I"
                            ExtFSDrives.SetItemCheckState(6, CheckState.Checked)
                        Case "J"
                            ExtFSDrives.SetItemCheckState(7, CheckState.Checked)
                        Case "K"
                            ExtFSDrives.SetItemCheckState(8, CheckState.Checked)
                        Case "L"
                            ExtFSDrives.SetItemCheckState(9, CheckState.Checked)
                        Case "M"
                            ExtFSDrives.SetItemCheckState(10, CheckState.Checked)
                        Case "N"
                            ExtFSDrives.SetItemCheckState(11, CheckState.Checked)
                        Case "O"
                            ExtFSDrives.SetItemCheckState(12, CheckState.Checked)
                        Case "P"
                            ExtFSDrives.SetItemCheckState(13, CheckState.Checked)
                        Case "Q"
                            ExtFSDrives.SetItemCheckState(14, CheckState.Checked)
                        Case "R"
                            ExtFSDrives.SetItemCheckState(15, CheckState.Checked)
                        Case "S"
                            ExtFSDrives.SetItemCheckState(16, CheckState.Checked)
                        Case "T"
                            ExtFSDrives.SetItemCheckState(17, CheckState.Checked)
                        Case "U"
                            ExtFSDrives.SetItemCheckState(18, CheckState.Checked)
                        Case "V"
                            ExtFSDrives.SetItemCheckState(19, CheckState.Checked)
                        Case "W"
                            ExtFSDrives.SetItemCheckState(20, CheckState.Checked)
                        Case "X"
                            ExtFSDrives.SetItemCheckState(21, CheckState.Checked)
                        Case "Y"
                            ExtFSDrives.SetItemCheckState(22, CheckState.Checked)
                        Case "Z"
                            ExtFSDrives.SetItemCheckState(23, CheckState.Checked)
                    End Select
                Next
            End If

            If InStr(ConfigValues(x), "pollmedia") <> 0 Then
                If ConfigValues(x).ToString.Substring(10) = "true" Then
                    DrivePollMedia.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "etherpermanentaddress") <> 0 Then
                If ConfigValues(x).ToString.Substring(22) = "true" Then
                    NetPermPhysicalAddress.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "ethermulticastmode") <> 0 Then
                NetMulticastMode.Text = ConfigValues(x).ToString.Substring(19)
            End If

            If InStr(ConfigValues(x), "routerenabled") <> 0 Then
                If ConfigValues(x).ToString.Substring(14) = "true" Then
                    NetRouterEnabled.Checked = True
                Else
                    NetRouterEnabled.Checked = False
                End If
            End If

            If InStr(ConfigValues(x), "ftp_port:list") <> 0 Then
                NetFTPPorts.Text = ConfigValues(x).ToString.Substring(14)
            End If

            If InStr(ConfigValues(x), "tcp_port") <> 0 Then
                NetServerPorts.Text = ConfigValues(x).ToString.Substring(9)
            End If

            If InStr(ConfigValues(x), "portfile0") <> 0 Then
                SAFilePath.Text = ConfigValues(x).ToString.Substring(10)
            End If

            If InStr(ConfigValues(x), "portfile1") <> 0 Then
                SBFilePath.Text = ConfigValues(x).ToString.Substring(10)
            End If

            If InStr(ConfigValues(x), "displaycolordepth") <> 0 Then

            End If

            If ConfigValues(x).ToString.Substring(0, 4) = "scsi" Then
                Select Case ConfigValues(x).ToString.Substring(0, 5)
                    Case "scsi0"

                    Case "scsi1"

                    Case "scsi2"

                    Case "scsi3"

                    Case "scsi4"

                    Case "scsi5"

                    Case "scsi6"

                End Select
            End If

            EMCEditor.Items.Add(ConfigValues(x))
        Next
    End Sub

    Private Sub CollectAndSave()
        Dim Options As String = ""

        For x As Integer = 0 To DriveList.Items.Count
            Select Case DriveList.Items.Item(x).SubItems(1).Text
                Case "Disk"
                    Options = Options & vbCrLf & "disk " & DriveList.Items.Item(x).Text
                Case "Floppy"
                    Options = Options & vbCrLf & "floppy " & DriveList.Items.Item(x).Text
                Case "CD"
                    Options = Options & vbCrLf & "cdrom " & DriveList.Items.Item(x).Text
            End Select
        Next

        Select Case ScrMode.SelectedItem.ToString
            Case "Window"
                Options = Options & vbCrLf & "screen win/" & ScrResX.SelectedItem.ToString & "/" & ScrResY.SelectedItem.ToString
            Case "Fullscreen"
                Options = Options & vbCrLf & "screen dga/" & ScrResX.SelectedItem.ToString & "/" & ScrResY.SelectedItem.ToString
        End Select

        'For x As Integer = 0 To EMCEditor.Items.Count - 1
        '    Options = Options & EMCEditor.Items.Item(x).Text & vbCrLf
        'Next
        ConfigFileHandler.Write(Options, ConfigFile)
    End Sub

    Private Sub frmSettingsBasiliskVM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetInitialData()
        Settings()
    End Sub

    Private Sub OptionList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionList.SelectedIndexChanged
        HidePages()
        Select Case OptionList.FocusedItem.Index
            Case 0
                MacNameFrame.Visible = True
            Case 1
                IconFrame.Visible = True
            Case 2
                MemoryFrame.Visible = True
            Case 3
                DriveFrame.Visible = True
            Case 4
                NetworkFrame.Visible = True
            Case 5
                ScreenFrame.Visible = True
            Case 6
                InputFrame.Visible = True
            Case 7
                SerialFrame.Visible = True
            Case 8
                MiscHwFrame.Visible = True
            Case 9
                ExtFSFrame.Visible = True
            Case 10
                MiscFrame.Visible = True
            Case 11
                JITFrame.Visible = True
            Case 12
                EMCFrame.Visible = True
        End Select
    End Sub

    Public Sub HidePages()
        MacNameFrame.Visible = False
        IconFrame.Visible = False
        MemoryFrame.Visible = False
        DriveFrame.Visible = False
        NetworkFrame.Visible = False
        ScreenFrame.Visible = False
        InputFrame.Visible = False
        SerialFrame.Visible = False
        MiscHwFrame.Visible = False
        ExtFSFrame.Visible = False
        MiscFrame.Visible = False
        JITFrame.Visible = False
        EMCFrame.Visible = False
    End Sub

    Public Sub SetInitialData()
        Dim SysMem As Long = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024
        MacName.Text = VMName

        If SysMem < 1024 Then
            MemoryTracker.Maximum = SysMem
        End If
        NetType.SelectedIndex = 0
    End Sub

    Private Sub ScrResCust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrResCust.CheckedChanged
        If ScrResCust.Checked = True Then
            ScrResX.DropDownStyle = ComboBoxStyle.DropDown
            ScrResY.DropDownStyle = ComboBoxStyle.DropDown
        Else
            ScrResX.DropDownStyle = ComboBoxStyle.DropDownList
            ScrResY.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub MemoryBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoryBox.TextChanged
        MemoryTracker.Value = MemoryBox.Text
    End Sub

    Private Sub MemoryTracker_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoryTracker.Scroll
        MemoryBox.Text = MemoryTracker.Value
    End Sub

    Private Sub MiscHwCPU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscHwCPU.SelectedIndexChanged
        If MiscHwCPU.SelectedIndex = 2 Then
            MiscHwFPU.Enabled = False
            MiscHwFPU.Checked = True
        Else
            MiscHwFPU.Enabled = True
        End If
    End Sub

    Private Sub DriveList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveList.SelectedIndexChanged
        If DriveList.FocusedItem.Index <> -1 Then
            ContextSelectedDrive(True)
        Else
            ContextSelectedDrive(False)
        End If
    End Sub

    Public Sub ContextSelectedDrive(ByVal IsSelected As Boolean)
        If IsSelected = True Then
            DriveListContext.Items.Item(3).Enabled = True
            DriveListContext.Items.Item(4).Enabled = True
        Else
            DriveListContext.Items.Item(3).Enabled = False
            DriveListContext.Items.Item(4).Enabled = False
        End If
    End Sub

    Private Sub SetAsBootDriveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveContxSetAsBoot.Click
        For x As Integer = 0 To DriveList.Items.Count - 1
            If DriveList.Items.Item(x).SubItems.Item(2).Text = "*" Then
                DriveList.Items.Item(x).SubItems.Item(2).Text = ""
            End If
        Next
        DriveList.FocusedItem.SubItems.Item(2).Text = "*"
    End Sub

    Private Sub ContextRemoveDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveContxRemoveDrive.Click
        Dim Remove As Integer = MsgBox("Are you sure you want to remove ''" & DriveList.FocusedItem.Text & "'' from the drives list?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Remove drive")
        If Remove = 6 Then
            DriveList.FocusedItem.Remove()
        End If
    End Sub

    Private Sub NetEnableUDP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetEnableUDP.CheckedChanged
        If NetEnableUDP.Checked = False Then
            NetUPDPort.Enabled = False
            NetUPDPortLabel.Enabled = False
        Else
            NetUPDPort.Enabled = True
            NetUPDPortLabel.Enabled = True
        End If
    End Sub

    Private Sub NetType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetType.SelectedIndexChanged
        If NetType.SelectedIndex = 1 Then
            NetRouterConfig.Visible = True
            NetRouterEnabled.Enabled = True
        Else
            NetRouterConfig.Visible = False
            NetRouterEnabled.Enabled = False
        End If
    End Sub

    Private Sub InputEnableKeycodes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputKeycodesEnable.CheckedChanged
        If InputKeycodesEnable.Checked = False Then
            InputKeyCodesPathPanel.Enabled = False
        Else
            InputKeyCodesPathPanel.Enabled = True
        End If
    End Sub

    Private Sub DriveRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveRemove.Click
        Dim Remove As Integer = MsgBox("Are you sure you want to remove ''" & DriveList.FocusedItem.Text & "'' from the drives list?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Remove drive")
        If Remove = 6 Then
            DriveList.FocusedItem.Remove()
        End If
    End Sub

    Private Sub DriveSetBootDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveSetBootDrive.Click
        For x As Integer = 0 To DriveList.Items.Count - 1
            If DriveList.Items.Item(x).SubItems.Item(2).Text = "*" Then
                DriveList.Items.Item(x).SubItems.Item(2).Text = ""
            End If
        Next
        DriveList.FocusedItem.SubItems.Item(2).Text = "*"
    End Sub

    Private Sub ExtFSEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtFSEnable.CheckedChanged
        If ExtFSEnable.Checked = True Then
            ExtFSDrivesLabel.Visible = True
            ExtFSDrives.Visible = True
        Else
            ExtFSDrivesLabel.Visible = False
            ExtFSDrives.Visible = False
        End If
    End Sub

    Private Sub EMCEditor_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles EMCEditor.ItemActivate
        EMCEditor.FocusedItem.BeginEdit()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        CollectAndSave()
        Me.Close()
    End Sub
End Class
