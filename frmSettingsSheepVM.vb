Imports System.IO

Friend Class frmSettingsSheepVM
    Inherits System.Windows.Forms.Form
    Public ConfigFilePath As String
    Public VMName As String
    Public SelectedItem As Integer
    Public Sub LoadSettingsFrom(Item As Integer)
        ConfigFilePath = frmMain.VMList.Items.Item(Item).SubItems(1).Text
        VMName = frmMain.VMList.Items.Item(Item).Text
        SelectedItem = Item
    End Sub

    Public Sub Settings()

        Dim Reader As New StreamReader(ConfigFilePath)
        Dim ConfigValues As New ArrayList()
        Dim strContainer As String = ""

        MacName.Text = frmMain.VMList.Items.Item(SelectedItem).Text

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

            If ConfigValues(x).ToString.Substring(0, 5) = "extfs" Then

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

            If ConfigValues(x).ToString.Length > 7 Then
                If ConfigValues(x).ToString.Substring(0, 7) = "screen " Then
                    Dim a As String = ConfigValues(x).ToString.Substring(7)
                    Dim b() As String = Split(a, "/")
                    Dim FoundX As Boolean = False
                    Dim FoundY As Boolean = False

                    Select Case b(0)
                        Case "win"
                            MediaMode.SelectedIndex = 0
                        Case "dga"
                            MediaMode.SelectedIndex = 1
                    End Select

                    For c As Integer = 0 To MediaResY.Items.Count - 1
                        If FoundX = True And FoundY = True Then
                            Exit For
                        End If

                        If InStr(MediaResX.Items.Item(c).ToString, b(1)) <> 0 Then
                            MediaResX.SelectedIndex = c
                            FoundX = True
                        ElseIf c = MediaResX.Items.Count - 1 And FoundX = False Then
                            MediaResX.Items.Add(b(1))
                            MediaResX.SelectedIndex = MediaResX.Items.Count - 1
                        End If

                        If InStr(MediaResY.Items.Item(c).ToString, b(2)) <> 0 Then
                            MediaResY.SelectedIndex = c
                            FoundY = True
                        ElseIf c = MediaResY.Items.Count - 1 And FoundY = False Then
                            MediaResY.Items.Add(b(2))
                            MediaResY.SelectedIndex = MediaResY.Items.Count - 1
                        End If
                    Next
                End If
            End If

            If InStr(ConfigValues(x), "windowsmodes") <> 0 Then

            End If

            If InStr(ConfigValues(x), "screenmodes") <> 0 Then

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

            If ConfigValues(x).ToString.Substring(0, 3) = "rom" Then
                MiscROM.Text = ConfigValues(x).ToString.Substring(4)
            End If

            If InStr(ConfigValues(x), "bootdrive") <> 0 Then
                Dim bd As Integer = ConfigValues(x).ToString.Substring(10)
                If bd <= DriveList.Items.Count Then
                    DriveList.Items.Item(bd).SubItems.Item(2).Text = "*"
                End If
            End If

            If InStr(ConfigValues(x), "bootdriver") <> 0 Then
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
                        MediaRefresh.SelectedIndex = 0
                    Case "8"
                        MediaRefresh.SelectedIndex = 1
                    Case "6"
                        MediaRefresh.SelectedIndex = 2
                    Case "4"
                        MediaRefresh.SelectedIndex = 3
                    Case "2"
                        MediaRefresh.SelectedIndex = 4
                    Case "1"
                        MediaRefresh.SelectedIndex = 5
                End Select
            End If

            If InStr(ConfigValues(x), "gfxaccel") <> 0 Then
                If ConfigValues(x).ToString.Substring(9) = "true" Then
                    MediaEnableQuickDraw.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "nocdrom") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "false"
                        MediaEnableCD.Checked = True
                    Case "true"
                        MediaEnableCD.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "nonet") <> 0 Then
                If ConfigValues(x).ToString.Substring(6) = "true" Then
                    NetEnable.Checked = False
                End If
            End If

            If InStr(ConfigValues(x), "nosound") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(8)
                    Case "false"
                        MediaEnableSound.Checked = True
                    Case "true"
                        MediaEnableSound.Checked = False
                End Select
            End If

            If InStr(ConfigValues(x), "nogui") <> 0 Then
                If ConfigValues(x).ToString.Substring(6) = "true" Then
                    MiscEnableGUI.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "noclipconversion") <> 0 Then
                If ConfigValues(x).ToString.Substring(17, 4) = "true" Then
                    MiscClipConv.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "ignoresegv") <> 0 Then
                If ConfigValues(x).ToString.Substring(11) = "true" Then
                    MiscIgnoreSegv.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "ignoreillegal") <> 0 Then
                If ConfigValues(x).ToString.Substring(14) = "true" Then
                    MiscIgnoreIllegal.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "jit") <> 0 Then
                If ConfigValues(x).ToString.Substring(4) = "true" Then
                    JITEnable.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "jit68k") <> 0 Then
                If ConfigValues(x).ToString.Substring(7) = "true" Then
                    JIT68kEnable.Checked = True
                End If
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

            If InStr(ConfigValues(x), "ether") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(6)
                    Case "slirp"
                        NetType.SelectedIndex = 0
                    Case "router"
                        NetType.SelectedIndex = 1
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

            If InStr(ConfigValues(x), "keycodefile") <> 0 Then
                InputKeyCodesPath.Text = ConfigValues(x).ToString.Substring(13)
            End If

            If InStr(ConfigValues(x), "mousewheelmode") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(15, 1)
                    Case "0"
                        InputMouseWheelMode.SelectedIndex = 0
                    Case "1"
                        InputMouseWheelMode.SelectedIndex = 1
                End Select
            End If

            If InStr(ConfigValues(x), "mousewheellines") <> 0 Then
                Dim Number As Integer = ConfigValues(x).ToString.Substring(15)
                InputMouseWheelLines.Value = Number
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

            If InStr(ConfigValues(x), "etherguid") <> 0 Then

            End If

            If InStr(ConfigValues(x), "etherpermanentaddress") <> 0 Then
                If ConfigValues(x).ToString.Substring(22) = "true" Then
                    NetPermPhysicalAddress.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "etherfakeaddress") <> 0 Then
                NetFakeAddress.Text = ConfigValues(x).ToString.Substring(17)
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

            If InStr(ConfigValues(x), "tcp_port") <> 0 Then
                NetServerPorts.Text = ConfigValues(x).ToString.Substring(9)
            End If

            If InStr(ConfigValues(x), "ftp_port_list") <> 0 Then
                NetFTPPorts.Text = ConfigValues(x).ToString.Substring(14)
            End If

            If InStr(ConfigValues(x), "portfile0") <> 0 Then
                SerialAFilePath.Text = ConfigValues(x).ToString.Substring(10)
            End If

            If InStr(ConfigValues(x), "portfile1") <> 0 Then
                SerialBFilePath.Text = ConfigValues(x).ToString.Substring(10)
            End If

            EMCEditor.Items.Add(ConfigValues(x))
        Next

    End Sub

    Public Sub SaveSettings()
        Dim ConfigFile As String = ""

        'Set the Text of the TextBox as the Mac name
        'frmMain.VMList.Items.Item(VMName).Text = MacName.Text

        'Recollect data
        For x As Integer = 0 To DriveList.Items.Count - 1
            Select Case DriveList.Items.Item(x).SubItems(1).Text
                Case "CD"
                    ConfigFile = ConfigFile & "cdrom " & DriveList.Items.Item(x).Text & vbCrLf
                Case "Disk"
                    ConfigFile = ConfigFile & "disk " & DriveList.Items.Item(x).Text & vbCrLf
                Case "Floppy"
                    ConfigFile = ConfigFile & "floppy " & DriveList.Items.Item(x).Text & vbCrLf
            End Select
            If DriveList.Items.Item(x).SubItems(2).Text = "*" Then
                ConfigFile = ConfigFile & "bootdrive " & x & vbCrLf
            End If
        Next

        ConfigFile = ConfigFile & "screen "
        If MediaMode.SelectedIndex = 0 Then
            ConfigFile = ConfigFile & "win/"
        Else
            ConfigFile = ConfigFile & "dga/"
        End If
        ConfigFile = ConfigFile & MediaResX.SelectedItem.ToString & "/"
        ConfigFile = ConfigFile & MediaResY.SelectedItem.ToString & vbCrLf

        If SerialA.SelectedItem.ToString <> "None" Then
            Select Case SerialA.SelectedIndex
                Case 0
                    ConfigFile = ConfigFile & "seriala COM1" & vbCrLf
                Case 1
                    ConfigFile = ConfigFile & "seriala COM2" & vbCrLf
                Case 2
                    ConfigFile = ConfigFile & "seriala COM3" & vbCrLf
                Case 3
                    ConfigFile = ConfigFile & "seriala COM4" & vbCrLf
                Case 4
                    ConfigFile = ConfigFile & "seriala COM5" & vbCrLf
                Case 5
                    ConfigFile = ConfigFile & "seriala COM6" & vbCrLf
                Case 6
                    ConfigFile = ConfigFile & "seriala LPT1" & vbCrLf
                Case 7
                    ConfigFile = ConfigFile & "seriala LP2" & vbCrLf
                Case 8
                    ConfigFile = ConfigFile & "seriala LPT3" & vbCrLf
                Case 9
                    ConfigFile = ConfigFile & "seriala LPT4" & vbCrLf
                Case 10
                    ConfigFile = ConfigFile & "seriala LPT5" & vbCrLf
                Case 11
                    ConfigFile = ConfigFile & "seriala LPT6" & vbCrLf
                Case 12
                    If SerialAFilePath.Text <> "" Then
                        ConfigFile = ConfigFile & "seriala FILE" & vbCrLf
                        ConfigFile = ConfigFile & "portfile0 " & SerialAFilePath.Text & vbCrLf
                    End If
            End Select
        End If

        If SerialB.SelectedItem.ToString <> "None" Then
            Select Case SerialB.SelectedIndex
                Case 0
                    ConfigFile = ConfigFile & "serialb COM1" & vbCrLf
                Case 1
                    ConfigFile = ConfigFile & "serialb COM2" & vbCrLf
                Case 2
                    ConfigFile = ConfigFile & "serialb COM3" & vbCrLf
                Case 3
                    ConfigFile = ConfigFile & "serialb COM4" & vbCrLf
                Case 4
                    ConfigFile = ConfigFile & "serialb COM5" & vbCrLf
                Case 5
                    ConfigFile = ConfigFile & "serialb COM6" & vbCrLf
                Case 6
                    ConfigFile = ConfigFile & "serialb LPT1" & vbCrLf
                Case 7
                    ConfigFile = ConfigFile & "serialb LP2" & vbCrLf
                Case 8
                    ConfigFile = ConfigFile & "serialb LPT3" & vbCrLf
                Case 9
                    ConfigFile = ConfigFile & "serialb LPT4" & vbCrLf
                Case 10
                    ConfigFile = ConfigFile & "serialb LPT5" & vbCrLf
                Case 11
                    ConfigFile = ConfigFile & "serialb LPT6" & vbCrLf
                Case 12
                    If SerialBFilePath.Text <> "" Then
                        ConfigFile = ConfigFile & "serialb FILE" & vbCrLf
                        ConfigFile = ConfigFile & "portfile1 " & SerialBFilePath.Text & vbCrLf
                    End If
            End Select
        End If

        ConfigFile = ConfigFile & "rom " & MiscROM.Text & vbCrLf

        If DriveBootDisk.Checked = True Then
            ConfigFile = ConfigFile & "bootdriver 0" & vbCrLf
        Else
            ConfigFile = ConfigFile & "bootdriver -62" & vbCrLf
        End If

        ConfigFile = ConfigFile & "ramsize " & (MemoryBox.Text * 1024) * 1024 & vbCrLf

        Select Case MediaRefresh.SelectedIndex
            Case  0
                ConfigFile = ConfigFile & "frameskip 12" & vbCrLf
            Case 1
                ConfigFile = ConfigFile & "frameskip 8" & vbCrLf
            Case  2
                ConfigFile = ConfigFile & "frameskip 6" & vbCrLf
            Case 3
                ConfigFile = ConfigFile & "frameskip 4" & vbCrLf
            Case 4
                ConfigFile = ConfigFile & "frameskip 2" & vbCrLf
            Case 5
                ConfigFile = ConfigFile & "frameskip 1" & vbCrLf
        End Select

        If MediaEnableQuickDraw.Checked = True Then
            ConfigFile = ConfigFile & "gfxaccel true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "gfxaccel false" & vbCrLf
        End If

        If MediaEnableCD.Checked = True Then
            ConfigFile = ConfigFile & "nocdrom false" & vbCrLf
        Else
            ConfigFile = ConfigFile & "nocdrom true" & vbCrLf
        End If

        If MediaEnableSound.Checked = True Then
            ConfigFile = ConfigFile & "nosound false" & vbCrLf
        Else
            ConfigFile = ConfigFile & "nosound true" & vbCrLf
        End If

        If NetEnable.Checked = True Then
            ConfigFile = ConfigFile & "nonet false" & vbCrLf
        Else
            ConfigFile = ConfigFile & "nonet true" & vbCrLf
        End If

        If MiscEnableGUI.Checked = True Then
            ConfigFile = ConfigFile & "nogui false" & vbCrLf
        Else
            ConfigFile = ConfigFile & "nogui true" & vbCrLf
        End If

        If MiscClipConv.Checked = True Then
            ConfigFile = ConfigFile & "noclipconversion false" & vbCrLf
        Else
            ConfigFile = ConfigFile & "noclipconversion true" & vbCrLf
        End If

        If MiscIgnoreSegv.Checked = True Then
            ConfigFile = ConfigFile & "ignoresegv true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "ignoresegv false" & vbCrLf
        End If

        If MiscIgnoreIllegal.Checked = True Then
            ConfigFile = ConfigFile & "ignoreillegal true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "ignoreillegal false" & vbCrLf
        End If

        If JITEnable.Checked = True Then
            ConfigFile = ConfigFile & "jit true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "jit false" & vbCrLf
        End If

        If JIT68kEnable.Checked = True Then
            ConfigFile = ConfigFile & "jit68k true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "jit68k false" & vbCrLf
        End If

        Select Case InputEmuKbdType.SelectedIndex
            Case 0
                ConfigFile = ConfigFile & "keyboardtype 5" & vbCrLf
            Case 1
                ConfigFile = ConfigFile & "keyboardtype 11" & vbCrLf
            Case 2
                ConfigFile = ConfigFile & "keyboardtype 13" & vbCrLf
        End Select

        Select Case NetType.SelectedIndex
            Case 0
                ConfigFile = ConfigFile & "ether slirp" & vbCrLf
            Case 1
                ConfigFile = ConfigFile & "ether router" & vbCrLf
        End Select

        If InputKeycodesEnable.Checked = True Then
            ConfigFile = ConfigFile & "keycodes true" & vbCrLf
            ConfigFile = ConfigFile & "keycodesfile " & InputKeyCodesPath.Text & vbCrLf
        End If

        Select Case InputMouseWheelMode.SelectedIndex = 0
            Case 0
                ConfigFile = ConfigFile & "mousewheelmode 0" & vbCrLf
            Case 1
                ConfigFile = ConfigFile & "mousewheelmode 1" & vbCrLf
                ConfigFile = ConfigFile & "mousewheellines " & InputMouseWheelLines.Value & vbCrLf
        End Select

        If ExtFSEnable.Checked = True Then
            ConfigFile = ConfigFile & "enableextfs true" & vbCrLf
            ConfigFile = ConfigFile & "extfsdrives "
            For x As Integer = 0 To ExtFSDrives.Items.Count
                If ExtFSDrives.CheckedIndices.Contains(x) = True Then
                    ConfigFile = ConfigFile & ExtFSDrives.Items.Item(x).ToString()
                End If
            Next
            ConfigFile = ConfigFile & vbCrLf
        Else
            ConfigFile = ConfigFile & "enableextfs false" & vbCrLf
        End If

        If JITDebugExtFS.Checked = True Then
            ConfigFile = ConfigFile & "debugextfs true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "debugextfs false" & vbCrLf
        End If

        If DrivePollMedia.Checked = True Then
            ConfigFile = ConfigFile & "pollmedia true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "pollmedia false" & vbCrLf
        End If

        If NetPermPhysicalAddress.Checked = True Then
            ConfigFile = ConfigFile & "etherpermanentaddress true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "etherpermanentaddress false" & vbCrLf
        End If

        If NetFakeAddress.Text <> "" Then
            ConfigFile = ConfigFile & "etherfakeaddress " & NetFakeAddress.Text & vbCrLf
        End If

        If NetMulticastMode.Text <> "" Then
            ConfigFile = ConfigFile & "ethermulticast " & NetMulticastMode.Text & vbCrLf
        End If

        If NetRouterEnabled.Checked = True Then
            ConfigFile = ConfigFile & "routerenabled true" & vbCrLf
        Else
            ConfigFile = ConfigFile & "routerenabled false" & vbCrLf
        End If

        If NetFTPPorts.Text <> "" Then
            ConfigFile = ConfigFile & "ftp_port_list " & NetFTPPorts.Text & vbCrLf
        End If

        If NetFTPPorts.Text <> "" Then
            ConfigFile = ConfigFile & "tcp_port " & NetServerPorts.Text & vbCrLf
        End If

        ConfigFile = ConfigFile & "portfile0 " & SerialAFilePath.Text & vbCrLf
        ConfigFile = ConfigFile & "portfile1 " & SerialBFilePath.Text & vbCrLf

        MsgBox(ConfigFile)

        ConfigFileHandler.Write(ConfigFile, ConfigFilePath)

    End Sub

    Private Sub SwitchPages(ByVal NewPage As System.Windows.Forms.GroupBox)
        MacNameFrame.Visible = False
        IconFrame.Visible = False
        MemoryFrame.Visible = False
        DriveFrame.Visible = False
        NetworkFrame.Visible = False
        MediaFrame.Visible = False
        InputFrame.Visible = False
        SerialFrame.Visible = False
        ExtFSFrame.Visible = False
        MiscFrame.Visible = False
        JITFrame.Visible = False
        EMCFrame.Visible = False

        NewPage.Visible = True
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close() 'Saves nothing and closes the dialog
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'Save the config file and/or update the item in the console and leave
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub frmSettingsSheepVM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up some things
        InitializeData()
        'Load the config file into the respective groups
        Settings()
    End Sub

    Public Sub InitializeData()
        'Quite self explanatory, it gets the RAM in the host, divides it into MBs and sets the maximum values for the RAM controls
        Dim HostRAM As Long = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024
        MemoryTracker.Maximum = HostRAM
        MemoryTracker.TickFrequency = HostRAM / 20

        Me.Text = "Settings for " & frmMain.VMList.Items.Item(SelectedItem).Text

        MediaRefresh.SelectedIndex = MediaRefresh.Items.Count - 1

        'Code used to load icons
        For x As Integer = 0 To frmMain.MacIcons.Images.Count - 1
            Icons.Images.Add(frmMain.MacIcons.Images.Item(x).ToString, frmMain.MacIcons.Images.Item(x))
            With IconList.Items.Add(x)
                .ImageIndex = x
            End With
        Next

    End Sub

    Private Sub IconAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconAdd.Click
        'If the user did choose a valid file, then execute the code
        If Browser.ShowDialog() = Forms.DialogResult.OK Then
            Dim ImgName As String = System.IO.Path.GetFileNameWithoutExtension(Browser.FileName) 'Get the Name without extension for the pic name
            Dim Img As System.Drawing.Image = Image.FromFile(Browser.FileName)      'Set a variable for the pic assign to it the image selected
            frmMain.MacIcons.Images.Add(ImgName, Img)       'Add the icon to the console ImageList, so it can be shown with this dialog closed
            My.Settings.x = My.Settings.x & Browser.FileName & ","      'Add the icon to the settings, so the icon can be loaded after closing and reopening the program
            IconList.Items.Add(ImgName, Icons.Images.Count - 1)     'Add the icon to the form's ImageList
            Icons.Images.Add(ImgName, Img)      'Add the icon to the form's ListView
            IconList.Items.Item(Icons.Images.Count - 1).Focused = True      'Focus the item, so the user sees it has been added
        End If
    End Sub

    Private Sub MemoryTracker_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles MemoryTracker.Scroll
        'Set the same value in both Slider and NumericUpDown
        MemoryBox.Text = MemoryTracker.Value
    End Sub

    Private Sub OptionList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptionList.SelectedIndexChanged
        'If the selected index changes (The user selects another "tab"), switch the tab visible
        Select Case OptionList.FocusedItem.Index
            Case 0
                SwitchPages(MacNameFrame)
            Case 1
                SwitchPages(IconFrame)
            Case 2
                SwitchPages(MemoryFrame)
            Case 3
                SwitchPages(DriveFrame)
            Case 4
                SwitchPages(NetworkFrame)
            Case 5
                SwitchPages(MediaFrame)
            Case 6
                SwitchPages(InputFrame)
            Case 7
                SwitchPages(SerialFrame)
            Case 8
                SwitchPages(ExtFSFrame)
            Case 9
                SwitchPages(MiscFrame)
            Case 10
                SwitchPages(JITFrame)
            Case 11
                SwitchPages(EMCFrame)
        End Select
    End Sub

    Private Sub ScrResCust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaResCust.CheckedChanged
        'If the user marks the checkbox of "Custom resolution", make visible the CustomResolution controls
        If MediaResCust.Checked = True Then
            MediaResX.Visible = True
            MediaResY.Visible = True
        Else
            MediaResX.Visible = False
            MediaResY.Visible = False
        End If
    End Sub

    Private Sub NetType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetType.SelectedIndexChanged
        If NetType.SelectedIndex = 1 Then
            NetRouterConfig.Enabled = True
        Else
            NetRouterConfig.Enabled = False
        End If
    End Sub

    Private Sub SerialA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerialA.SelectedIndexChanged
        If SerialA.SelectedIndex = 12 Then
            SerialAFilePath.Enabled = True
            SerialAFileBrowse.Enabled = True
        Else
            SerialAFilePath.Enabled = False
            SerialAFileBrowse.Enabled = False
        End If
    End Sub

    Private Sub SerialB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerialB.SelectedIndexChanged
        If SerialB.SelectedIndex = 12 Then
            SerialBFilePath.Enabled = True
            SerialBFileBrowse.Enabled = True
        Else
            SerialBFileBrowse.Enabled = False
            SerialBFilePath.Enabled = False
        End If
    End Sub

    Private Sub EMCEditor_ItemActivate(sender As Object, e As System.EventArgs) Handles EMCEditor.ItemActivate
        EMCEditor.FocusedItem.BeginEdit()
    End Sub

    Private Sub MiscROMBrowse_Click(sender As System.Object, e As System.EventArgs) Handles MiscROMBrowse.Click
        If Browser.ShowDialog = Forms.DialogResult.OK Then
            MiscROM.Text = Browser.FileName
        End If
    End Sub

    Private Sub NetEnable_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NetEnable.CheckedChanged
        If NetEnable.Checked = True Then
            NetContainer.Enabled = True
        Else
            NetContainer.Enabled = False
        End If
    End Sub

    Private Sub NetFakeAddress_GotFocus(sender As Object, e As System.EventArgs) Handles NetFakeAddress.GotFocus
        If NetFakeAddress.Text = "No phisical address set." Then
            NetFakeAddress.ForeColor = Color.Black
            NetFakeAddress.Text = ""
        End If
    End Sub

    Private Sub NetFakeAddress_LostFocus(sender As Object, e As System.EventArgs) Handles NetFakeAddress.LostFocus
        If NetFakeAddress.Text = "" Then
            NetFakeAddress.ForeColor = Color.Gray
            NetFakeAddress.Text = "No phisical address set."
        End If
    End Sub

    Private Sub MemoryBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles MemoryBox.TextChanged
        MemoryTracker.Value = MemoryBox.Text
    End Sub

    Private Sub ExtFSEnable_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ExtFSEnable.CheckedChanged
        If ExtFSEnable.Checked Then
            ExtFSDrives.Visible = True
        Else
            ExtFSDrives.Visible = False
        End If
    End Sub

    Private Sub InputKeycodesEnable_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles InputKeycodesEnable.CheckedChanged
        If InputKeycodesEnable.Checked Then
            InputKeyCodesPathPanel.Enabled = True
        Else
            InputKeyCodesPathPanel.Enabled = False
        End If
    End Sub
End Class