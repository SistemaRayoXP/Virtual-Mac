Imports System.IO
Imports System.Globalization
Imports System.Threading
Public Class frmSettingsPearPCVM
    Public ConfigFile As String
    Public VMName As String
    Public SelectedItem As Integer
    Public Sub LoadSettingsFrom(Item As Integer)
        ConfigFile = frmMain.VMList.Items.Item(Item).SubItems(1).Text
        VMName = frmMain.VMList.Items.Item(Item).Text
        SelectedItem = Item
    End Sub

    Private Sub Settings()
        Dim Reader As New StreamReader(ConfigFile)
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
            ConfigValues(x) = Replace(ConfigValues(x), Chr(34).ToString, "")
            If InStr(ConfigValues(x), "ppc_start_resolution = ") <> 0 Then
                Dim a As String = ConfigValues(x).ToString.Substring(23)
                Dim b() As String = Split(a, "x")
                Dim FoundX As Boolean = False
                Dim FoundY As Boolean = False

                For c As Integer = 0 To DisplayResY.Items.Count - 1
                    If FoundX = True And FoundY = True Then
                        Exit For
                    End If

                    If InStr(DisplayResX.Items.Item(c).ToString, b(0)) <> 0 Then
                        DisplayResX.SelectedIndex = c
                        FoundX = True
                    ElseIf c = DisplayResX.Items.Count - 1 And FoundX = False Then
                        DisplayResX.Items.Add(b(0))
                        DisplayResX.SelectedIndex = DisplayResX.Items.Count - 1
                    End If

                    If InStr(DisplayResY.Items.Item(c).ToString, b(1)) <> 0 Then
                        DisplayResY.SelectedIndex = c
                        FoundY = True
                    ElseIf c = DisplayResY.Items.Count - 1 And FoundY = False Then
                        DisplayResY.Items.Add(b(1))
                        DisplayResY.SelectedIndex = DisplayResY.Items.Count - 1
                    End If

                    If b.Length > 2 Then
                        'If InStr(b(2), "@") <> 0 Then
                        '    If b(2).Substring(InStr(b(2), "@"), 2) <= DisplayFrequency.Maximum Then
                        '        DisplayFrequency.Value = b(2).Substring(InStr(b(2), "@"))
                        '        Select Case b(2).Substring(0, 2)
                        '            Case "15"
                        '                DisplayColourDepth.SelectedIndex = 0
                        '            Case "32"
                        '                DisplayColourDepth.SelectedIndex = 1
                        '            Case Else
                        '                DisplayColourDepth.SelectedIndex = 0
                        '        End Select
                        '    End If
                        'Else
                        Select Case b(2).Substring(0, 2)
                            Case "15"
                                DisplayColourDepth.SelectedIndex = 0
                            Case "32"
                                DisplayColourDepth.SelectedIndex = 1
                            Case Else
                                DisplayColourDepth.SelectedIndex = 0
                        End Select
                        'End If
                    End If
                Next
            End If

            If InStr(ConfigValues(x), "ppc_start_full_screen = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(24) <> 0 Then
                    DisplayFullscreenStart.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "redraw_interval_msec = ") <> 0 Then
                DisplayRedrawLabel.Text = ConfigValues(x).ToString.Substring(23)
            End If

            If InStr(ConfigValues(x), "key_compose_dialog = ") <> 0 Then
                BoardComposeDialogKey.Text = ConfigValues(x).ToString.Substring(21)
            End If

            If InStr(ConfigValues(x), "key_change_cd_0 = ") <> 0 Then
                BoardChangeCDKey.Text = ConfigValues(x).ToString.Substring(18)
            End If

            If InStr(ConfigValues(x), "key_toggle_mouse_grab = ") <> 0 Then
                BoardMouseGrabKey.Text = ConfigValues(x).ToString.Substring(24)
            End If

            If InStr(ConfigValues(x), "key_toggle_full_screen = ") <> 0 Then
                DisplayFullscreenKey.Text = ConfigValues(x).ToString.Substring(25)
            End If

            If InStr(ConfigValues(x), "prom_bootmethod = ") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(18)
                    Case "auto"
                        MiscBootModeAuto.Checked = True
                    Case "select"
                        MiscBootModeSelect.Checked = True
                    Case "force"
                        MiscBootModeForce.Checked = True
                End Select
            End If

            If InStr(ConfigValues(x), "prom_loadfile = ") <> 0 Then
                MiscPROMFile.Text = ConfigValues(x).ToString.Substring(16)
            End If

            If InStr(ConfigValues(x), "prom_env_bootpath = ") <> 0 Then
                MiscPROMBootPath.Text = ConfigValues(x).ToString.Substring(20)
            End If

            If InStr(ConfigValues(x), "prom_env_bootargs = ") <> 0 Then
                MiscPROMBootArgs.Text = ConfigValues(x).ToString.Substring(20)
            End If

            If InStr(ConfigValues(x), "prom_env_machargs = ") <> 0 Then
                MiscMachArguments.Text = ConfigValues(x).ToString.Substring(20)
            End If

            If InStr(ConfigValues(x), "prom_driver_graphic = ") <> 0 Then
                DisplayDriver.Text = ConfigValues(x).ToString.Substring(22)
            End If

            If InStr(ConfigValues(x), "page_table_pa = ") <> 0 Then
                MiscPageTable.Text = ConfigValues(x).ToString.Substring(16)
            End If

            If InStr(ConfigValues(x), "cpu_pvr = ") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(10)
                    Case "0x00088302"
                        BoardProcessorG3.Checked = True
                    Case "0x000c0201"
                        BoardProcessorG4.Checked = True
                End Select
            End If

            If InStr(ConfigValues(x), "memory_size = ") <> 0 Then
                Dim MemorySize As UInteger = Replace(ConfigValues(x).ToString.Substring(14), "0x", "")
                MemorySize = MemorySize * 0.0000256
                If MemorySize < BoardRAMSlider.Maximum Then
                    BoardRAMSlider.Value = MemorySize
                End If
            End If

            If InStr(ConfigValues(x), "pci_ide0_master_installed = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(28) <> 0 Then
                    DriveMasterEnabled.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "pci_ide0_master_image = ") <> 0 Then
                DriveMasterPath.Text = ConfigValues(x).ToString.Substring(24)
            End If

            If InStr(ConfigValues(x), "pci_ide0_master_type = ") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(23)
                    Case "hd"
                        DriveMasterType.SelectedIndex = 0
                    Case "cdrom"
                        DriveMasterType.SelectedIndex = 1
                    Case "nativecdrom"
                        DriveMasterType.SelectedIndex = 2
                End Select
            End If

            If InStr(ConfigValues(x), "pci_ide0_slave_installed = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(27) <> 0 Then
                    DriveSlaveEnabled.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "pci_ide0_slave_image = ") <> 0 Then
                DriveSlavePath.Text = ConfigValues(x).ToString.Substring(23)
            End If

            If InStr(ConfigValues(x), "pci_ide0_slave_type = ") <> 0 Then
                Select Case ConfigValues(x).ToString.Substring(22)
                    Case "hd"
                        DriveSlaveType.SelectedIndex = 0
                    Case "cdrom"
                        DriveSlaveType.SelectedIndex = 1
                    Case "nativecdrom"
                        DriveSlaveType.SelectedIndex = 2
                End Select
            End If

            If InStr(ConfigValues(x), "pci_3c90x_installed = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(22) <> 0 Then
                    Net3c90xEnable.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "pci_3c90x_mac = ") <> 0 Then
                Dim PhAddr() As String = Split(ConfigValues(x).ToString.Substring(16), ":")
                For y As Integer = 0 To PhAddr.Length - 1
                    Select Case y
                        Case 0
                            Net3c90Mac1.Text = PhAddr(y)
                        Case 1
                            Net3c90Mac2.Text = PhAddr(y)
                        Case 2
                            Net3c90Mac3.Text = PhAddr(y)
                        Case 3
                            Net3c90Mac4.Text = PhAddr(y)
                        Case 4
                            Net3c90Mac5.Text = PhAddr(y)
                        Case 5
                            Net3c90Mac6.Text = PhAddr(y)
                    End Select
                Next
            End If

            If InStr(ConfigValues(x), "pci_rtl8139_installed = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(24) <> 0 Then
                    Net8139Enable.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "pci_rtl8139_mac = ") <> 0 Then
                Dim PhAddr() As String = Split(ConfigValues(x).ToString.Substring(18), ":")
                For y As Integer = 0 To PhAddr.Length - 1
                    Select Case y
                        Case 0
                            Net8139Mac1.Text = PhAddr(y)
                        Case 1
                            Net8139Mac2.Text = PhAddr(y)
                        Case 2
                            Net8139Mac3.Text = PhAddr(y)
                        Case 3
                            Net8139Mac4.Text = PhAddr(y)
                        Case 4
                            Net8139Mac5.Text = PhAddr(y)
                        Case 5
                            Net8139Mac6.Text = PhAddr(y)
                    End Select
                Next
            End If

            If InStr(ConfigValues(x), "pci_usb_installed = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(20) <> 0 Then
                    BoardUSBEnable.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "pci_serial_installed = ") <> 0 Then
                If ConfigValues(x).ToString.Substring(23) <> 0 Then
                    BoardSerialEnable.Checked = True
                End If
            End If

            If InStr(ConfigValues(x), "nvram_file = ") <> 0 Then
                MiscNVRAMFile.Text = ConfigValues(x).ToString.Substring(13)
            End If
        Next
    End Sub

    Private Sub SaveSettings()
        On Error GoTo ErrorHandler
        If VerifyData() = True Then
            MsgBox("Incomplete data, please fill all the required fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim Config As String = ""
        Dim DataArray() As String = Split(GetData(), ",")

        'Formatting the text with a function, which returns
        'the text formatted as the documentation says
        Config = FormatLine("ppc_start_resolution = ", DataArray(0), False)     'Emulator Resolution
        Config = Config & FormatLine("ppc_start_full_screen = ", DataArray(1), True)     'Full screen (Enabled or disabled)
        Config = Config & FormatLine("redraw_interval_msec = ", DataArray(2), True)     'Image redraw time
        If DataArray(3) <> "" Then
            Config = Config & FormatLine("key_compose_dialog = ", DataArray(3), False)        'Compose dialog key
        End If
        If DataArray(4) <> "" Then
            Config = Config & FormatLine("key_change_cd_0 = ", DataArray(4), False)      'Change CD Key
        End If
        If DataArray(5) <> "" Then
            Config = Config & FormatLine("key_toggle_mouse_grab = ", DataArray(5), False)        'Release/Capture mouse key
        End If
        If DataArray(6) <> "" Then
            Config = Config & FormatLine("key_toggle_full_screen = ", DataArray(6), False)        'Toggle Fullscreen/Windowed modes key
        End If
        Config = Config & FormatLine("prom_bootmethod = ", DataArray(7), False)        'Boot mode (Auto, select or force)
        If DataArray(7) = "force" Then
            Config = Config & FormatLine("prom_loadfile = ", DataArray(8), False)        'PROM file (File to load in case BootMethod = Force)
            Config = Config & FormatLine("prom_env_bootpath = ", DataArray(9), False)        'PROM Booth Path (Directory where PROM/PearPC boots)(Used with PROMFile)
            Config = Config & FormatLine("prom_env_bootargs = ", DataArray(10), False)        'Boot Arguments
        End If
        Config = Config & FormatLine("prom_env_machargs = ", DataArray(11), False)        'Mach Arguments
        Config = Config & FormatLine("prom_driver_graphic = ", DataArray(12), False)      'Graphic driver (video.x is recommended OS X)
        Config = Config & FormatLine("page_table_pa = ", DataArray(13), True)       'Initial page table(Don't change)
        Config = Config & FormatLine("cpu_pvr = ", DataArray(14), True)     'Processor Version Register (To emulate G3 or G4)
        Config = Config & FormatLine("memory_size = ", DataArray(15), True)     'Memory size (must be >= 64 MiB)
        Config = Config & FormatLine("pci_ide0_master_installed = ", DataArray(16), True)       'Master drive Installed (Yes or No , 1 or 0)
        Config = Config & FormatLine("pci_ide0_master_image = ", DataArray(17), False)      'Route to the Master drive image
        Config = Config & FormatLine("pci_ide0_master_type = ", DataArray(18), False)        'Master Drive Type(Hard disk or CD-ROM)
        Config = Config & FormatLine("pci_ide0_slave_installed = ", DataArray(19), True)     'Slave drive Installed (Yes or No , 1 or 0)
        Config = Config & FormatLine("pci_ide0_slave_image = ", DataArray(20), False)        'Route to the Slave drive image
        Config = Config & FormatLine("pci_ide0_slave_type = ", DataArray(21), False)      'Slave Drive Type(Hard disk or CD-ROM)
        Config = Config & FormatLine("pci_3c90x_installed = ", DataArray(22), True)       'Network card 3c90x Installed (Yes or No)
        Config = Config & FormatLine("pci_3c90x_mac = ", DataArray(23), False)      'MAC of this card (3c90x)
        Config = Config & FormatLine("pci_rtl8139_installed = ", DataArray(24), True)       'Network card RTL8139 installed (Yes or No)
        Config = Config & FormatLine("pci_rtl8139_mac = ", DataArray(25), False)      'MAC of this card (RTL8139)
        Config = Config & FormatLine("pci_usb_installed = ", DataArray(26), True)     'PCI USB capability installed (Yes or No)
        Config = Config & FormatLine("pci_serial_installed = ", DataArray(27), True)       'PCI Serial port installed installed (Yes or No)(For debugging only)
        Config = Config & FormatLine("nvram_file = ", DataArray(28), False)      'NVRAM file route

        If SaveConfigFile.FileName <> "" Then
            ConfigFileHandler.Write(Config, ConfigFile)
        End If

        frmMain.VMList.Items(SelectedItem).Text = MacName.Text

ErrorHandler:

        If Err.Number <> 0 Then
            MsgBox(Err.Description)
        End If
    End Sub

    Private Function GetData() As String
        Dim Data As String = ""

        Dim Resolution As String = DisplayResX.SelectedItem.ToString & "x" & DisplayResY.SelectedItem.ToString & "x" & DisplayColourDepth.SelectedItem.ToString & "@" & DisplayFrequency.Value
        Dim FullScreen As Long
        Dim RedrawTime As Long = Me.DisplayRedrawLabel.Text
        Dim ComposeDialogKey As String = Me.BoardComposeDialogKey.Text
        Dim ChangeCDKey As String = Me.BoardChangeCDKey.Text
        Dim ReleaseMouse As String = BoardMouseGrabKey.Text
        Dim SwitchFullScreen As String = DisplayFullscreenKey.Text
        Dim BootMode As String = "auto"
        Dim PROMFile As String = Me.MiscPROMFile.Text
        Dim PROMBootPath As String = Me.MiscPROMBootPath.Text
        Dim BootArgs As String = MiscPROMBootArgs.Text
        Dim MachArgs As String = MiscMachArguments.Text
        Dim GraphicDriver As String = Me.DisplayDriver.Text
        Dim PageTable As String = Me.MiscPageTable.Text
        Dim CPUPvr As String = "0x00088302"
        Dim Memory As String = "0x" & (BoardRAM.Text / 0.0000256)
        Dim MasterInstalled As Long = 0
        Dim MasterImage As String = DriveMasterPath.Text
        Dim MasterType As String = "hd"
        Dim SlaveInstalled As Long = 0
        Dim SlaveImage As String = DriveSlavePath.Text
        Dim SlaveType As String = "cdrom"
        Dim Net3c90xInstalled As Long
        Dim Net3c90xMac As String = Net3c90Mac1.Text & ":" & Net3c90Mac2.Text & ":" & Net3c90Mac3.Text & ":" & Net3c90Mac4.Text & ":" & Net3c90Mac5.Text & ":" & Net3c90Mac6.Text
        Dim NetRTL8139Installed As Long
        Dim NetRTL8139Mac As String = Net8139Mac1.Text & ":" & Net8139Mac2.Text & ":" & Net8139Mac3.Text & ":" & Net8139Mac4.Text & ":" & Net8139Mac5.Text & ":" & Net8139Mac6.Text
        Dim USBInstalled As Long = 0
        Dim SerialInstalled As Long = 0
        Dim NVRAMFile As String = Me.MiscNVRAMFile.Text

        If DisplayFullscreenStart.Checked = True Then
            FullScreen = 1
        End If

        If MiscBootModeAuto.Checked = True Then
            BootMode = "auto"
        End If
        If MiscBootModeSelect.Checked = True Then
            BootMode = "select"
        End If
        If MiscBootModeForce.Checked = True Then
            BootMode = "force"
        End If

        If BoardProcessorG3.Checked = True Then
            CPUPvr = "0x00088302"
        ElseIf BoardProcessorG4.Checked = True Then
            CPUPvr = "0x000c0201"
        End If

        If DriveMasterEnabled.Checked = True Then
            MasterInstalled = 1
        End If

        Select Case DriveMasterType.SelectedIndex
            Case 0
                MasterType = "hd"
            Case 1
                MasterType = "cdrom"
            Case 2
                MasterType = "nativecdrom"
        End Select

        If DriveSlaveEnabled.Checked = True Then
            SlaveInstalled = 1
        End If

        Select Case DriveSlaveType.SelectedIndex
            Case 0
                SlaveType = "hd"
            Case 1
                SlaveType = "cdrom"
            Case 2
                SlaveType = "nativecdrom"
        End Select

        If Net3c90xEnable.Checked = True Then
            Net3c90xInstalled = 1
        End If

        If Net8139Enable.Checked = True Then
            NetRTL8139Installed = 1
        End If

        If BoardUSBEnable.Checked = True Then
            USBInstalled = 1
        End If

        If BoardSerialEnable.Checked = True Then
            SerialInstalled = 1
        End If

        Data = Resolution & "," & FullScreen & "," & RedrawTime & "," & ComposeDialogKey & "," & ChangeCDKey & "," & _
            ReleaseMouse & "," & SwitchFullScreen & "," & BootMode & "," & PROMFile & "," & PROMBootPath & "," & _
            BootArgs & "," & MachArgs & "," & GraphicDriver & "," & PageTable & "," & CPUPvr & "," & Memory & "," & _
            MasterInstalled & "," & MasterImage & "," & MasterType & "," & SlaveInstalled & "," & SlaveImage & "," & _
            SlaveType & "," & Net3c90xInstalled & "," & Net3c90xMac & "," & NetRTL8139Installed & "," & _
            NetRTL8139Mac & "," & USBInstalled & "," & SerialInstalled & "," & NVRAMFile

        Return Data

    End Function

    Private Function VerifyData() As Boolean

        Dim Incomplete As Boolean = False

        If DriveMasterEnabled.Checked = True Then
            If DriveMasterPath.Text = "" Then
                Incomplete = True
            End If
        End If

        If DriveSlaveEnabled.Checked = True Then
            If DriveSlavePath.Text = "" Then
                Incomplete = True
            End If
        End If

        If Net3c90xEnable.Checked = True Then
            If Net3c90Mac1.Text = "" Then
                Incomplete = True
            End If
            If Net3c90Mac2.Text = "" Then
                Incomplete = True
            End If
            If Net3c90Mac3.Text = "" Then
                Incomplete = True
            End If
            If Net3c90Mac4.Text = "" Then
                Incomplete = True
            End If
            If Net3c90Mac5.Text = "" Then
                Incomplete = True
            End If
            If Net3c90Mac6.Text = "" Then
                Incomplete = True
            End If
        End If

        If Net8139Enable.Checked = True Then
            If Net8139Mac1.Text = "" Then
                Incomplete = True
            End If
            If Net8139Mac2.Text = "" Then
                Incomplete = True
            End If
            If Net8139Mac3.Text = "" Then
                Incomplete = True
            End If
            If Net8139Mac4.Text = "" Then
                Incomplete = True
            End If
            If Net8139Mac5.Text = "" Then
                Incomplete = True
            End If
            If Net8139Mac6.Text = "" Then
                Incomplete = True
            End If
        End If

        If DisplayDriver.Text = "" Then
            Incomplete = True
        End If

        If MiscNVRAMFile.Text = "" Then
            Incomplete = True
        End If

        Return Incomplete

    End Function

    Private Function FormatLine(ByVal Config As String, ByVal Value As String, ByVal NoQuotes As Boolean) As String
        Dim NewLine As String

        If NoQuotes = True Then
            NewLine = Config & Value & vbCrLf
        Else
            NewLine = Config & Chr(34) & Value & Chr(34) & vbCrLf
        End If

EndFunction:
        Return NewLine

    End Function

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close() 'Saves nothing and closes the dialog
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'Save the config file and/or update the item in the console and leave
        SaveSettings()
        Me.Close()
    End Sub


    Private Sub OptionList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles OptionList.SelectedIndexChanged
        Select Case OptionList.FocusedItem.Index
            Case 0
                SwitchPages(MacNameFrame)
            Case 1
                SwitchPages(IconFrame)
            Case 2
                SwitchPages(BoardFrame)
            Case 3
                SwitchPages(DriveFrame)
            Case 4
                SwitchPages(NetworkFrame)
            Case 5
                SwitchPages(DisplayFrame)
            Case 6
                SwitchPages(MiscFrame)
            Case 7

        End Select
    End Sub

    Private Sub SwitchPages(NewPage As System.Windows.Forms.GroupBox)
        MacNameFrame.Visible = False
        IconFrame.Visible = False
        BoardFrame.Visible = False
        DriveFrame.Visible = False
        NetworkFrame.Visible = False
        DisplayFrame.Visible = False
        MiscFrame.Visible = False

        NewPage.Visible = True
    End Sub

    Private Sub frmSettingsPearPCVM_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        InitializeData()
        Settings()

    End Sub

    Private Sub InitializeData()
        Dim HostMemory As Long = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024
        BoardRAMSlider.Maximum = HostMemory
        BoardRAMSlider.TickFrequency = HostMemory / 20

        Me.Text = "Settings for " & frmMain.VMList.Items.Item(SelectedItem).Text
    End Sub

    Private Sub BoardRAMSlider_ValueChanged(sender As Object, e As System.EventArgs) Handles BoardRAMSlider.ValueChanged
        BoardRAM.Text = BoardRAMSlider.Value
    End Sub

    Private Sub BoardRAM_TextChanged(sender As Object, e As System.EventArgs) Handles BoardRAM.TextChanged
        BoardRAMSlider.Value = BoardRAM.Text
    End Sub

    Private Sub DriveMasterEnabled_CheckedChanged(sender As Object, e As System.EventArgs) Handles DriveMasterEnabled.CheckedChanged
        If DriveMasterEnabled.Checked Then
            DriveMasterPath.Enabled = True
            DriveMasterPathLabel.Enabled = True
            DriveMasterBrowse.Enabled = True
            DriveMasterType.Enabled = True
            DriveMasterTypeLabel.Enabled = True
        Else
            DriveMasterPath.Enabled = False
            DriveMasterPathLabel.Enabled = False
            DriveMasterBrowse.Enabled = False
            DriveMasterType.Enabled = False
            DriveMasterTypeLabel.Enabled = False
        End If
    End Sub

    Private Sub DriveSlaveEnabled_CheckedChanged(sender As Object, e As System.EventArgs) Handles DriveSlaveEnabled.CheckedChanged
        If DriveSlaveEnabled.Checked Then
            DriveSlavePath.Enabled = True
            DriveSlavePathLabel.Enabled = True
            DriveSlaveBrowse.Enabled = True
            DriveSlaveType.Enabled = True
            DriveSlaveTypeLabel.Enabled = True
        Else
            DriveSlavePath.Enabled = False
            DriveSlavePathLabel.Enabled = False
            DriveSlaveBrowse.Enabled = False
            DriveSlaveType.Enabled = False
            DriveSlaveTypeLabel.Enabled = False
        End If
    End Sub

    Private Sub MiscBootModeForce_CheckedChanged(sender As Object, e As System.EventArgs) Handles MiscBootModeForce.CheckedChanged
        If MiscBootModeForce.Checked = True Then
            MiscPROMFile.Enabled = True
            MiscPROMFileLabel.Enabled = True
            MiscPROMFileBrowse.Enabled = True
            MiscPROMBootPath.Enabled = True
            MiscPROMBootPathLabel.Enabled = True
            MiscPROMBootPathBrowse.Enabled = True
            MiscPROMBootArgs.Enabled = True
            MiscPROMBootArgsLabel.Enabled = True
        Else
            MiscPROMFile.Enabled = False
            MiscPROMFileLabel.Enabled = False
            MiscPROMFileBrowse.Enabled = False
            MiscPROMBootPath.Enabled = False
            MiscPROMBootPathLabel.Enabled = False
            MiscPROMBootPathBrowse.Enabled = False
            MiscPROMBootArgs.Enabled = False
            MiscPROMBootArgsLabel.Enabled = False
        End If
    End Sub

    Private Sub Net8139Enable_CheckedChanged(sender As Object, e As System.EventArgs) Handles Net8139Enable.CheckedChanged
        If Net8139Enable.Checked = True Then
            Net8139MacLabel.Enabled = True
            Net8139Mac1.Enabled = True
            Net8139Mac2.Enabled = True
            Net8139Mac3.Enabled = True
            Net8139Mac4.Enabled = True
            Net8139Mac5.Enabled = True
            Net8139Mac6.Enabled = True
        Else
            Net8139MacLabel.Enabled = False
            Net8139Mac1.Enabled = False
            Net8139Mac2.Enabled = False
            Net8139Mac3.Enabled = False
            Net8139Mac4.Enabled = False
            Net8139Mac5.Enabled = False
            Net8139Mac6.Enabled = False
        End If
    End Sub

    Private Sub Net3c90xEnable_CheckedChanged(sender As Object, e As System.EventArgs) Handles Net3c90xEnable.CheckedChanged
        If Net3c90xEnable.Checked = True Then
            Net3c90MacLabel.Enabled = True
            Net3c90Mac1.Enabled = True
            Net3c90Mac2.Enabled = True
            Net3c90Mac3.Enabled = True
            Net3c90Mac4.Enabled = True
            Net3c90Mac5.Enabled = True
            Net3c90Mac6.Enabled = True
        Else
            Net3c90MacLabel.Enabled = False
            Net3c90Mac1.Enabled = False
            Net3c90Mac2.Enabled = False
            Net3c90Mac3.Enabled = False
            Net3c90Mac4.Enabled = False
            Net3c90Mac5.Enabled = False
            Net3c90Mac6.Enabled = False
        End If
    End Sub

    Private Sub BoardMouseGrabKey_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles BoardMouseGrabKey.KeyDown, BoardChangeCDKey.KeyDown, BoardComposeDialogKey.KeyDown, DisplayFullscreenKey.KeyDown
        Dim KeyStrokes As String = ""

        If e.Modifiers = Keys.Control Then
            KeyStrokes = KeyStrokes & "CTRL"
        ElseIf e.Modifiers = Keys.Alt Then
            e.Handled = True
            KeyStrokes = KeyStrokes & "ALT"
        ElseIf e.Modifiers = Keys.Shift Then
            KeyStrokes = KeyStrokes & "SHIFT"
        ElseIf e.Modifiers = Keys.Alt + Keys.Control Then
            KeyStrokes = KeyStrokes & "CTRL + ALT"
        ElseIf e.Modifiers = Keys.Shift + Keys.Control Then
            KeyStrokes = KeyStrokes & "CTRL + SHIFT"
        ElseIf e.Modifiers = Keys.Alt + Keys.Shift Then
            KeyStrokes = KeyStrokes & "SHIFT + ALT"
        ElseIf e.Modifiers = Keys.Shift + Keys.Alt + Keys.Control Then
            KeyStrokes = KeyStrokes & "CTRL + SHIFT + ALT"
        ElseIf e.Modifiers = Keys.Control + Keys.Delete Then
            KeyStrokes = ""
            GoTo SetKey
        ElseIf e.Modifiers = Keys.None Then
            e.Handled = True
        Else
            KeyStrokes = KeyStrokes & e.Modifiers.ToString
        End If

        If e.KeyCode <> Keys.ControlKey And e.KeyCode <> Keys.Menu And e.KeyCode <> Keys.ShiftKey And e.Modifiers <> Keys.None Then
            KeyStrokes = KeyStrokes & " + " & e.KeyCode.ToString
        End If

SetKey:
        sender.Text = KeyStrokes

    End Sub

    Private Sub DriveMasterBrowse_Click(sender As System.Object, e As System.EventArgs) Handles DriveMasterBrowse.Click
        If FileBrowserDialog.ShowDialog = Forms.DialogResult.OK Then
            DriveMasterPath.Text = FileBrowserDialog.FileName
        End If
    End Sub

    Private Sub DriveSlaveBrowse_Click(sender As System.Object, e As System.EventArgs) Handles DriveSlaveBrowse.Click
        If FileBrowserDialog.ShowDialog = Forms.DialogResult.OK Then
            DriveSlavePath.Text = FileBrowserDialog.FileName
        End If
    End Sub

    Private Sub DisplayDriverBrowse_Click(sender As System.Object, e As System.EventArgs) Handles DisplayDriverBrowse.Click
        If FileBrowserDialog.ShowDialog = Forms.DialogResult.OK Then
            DisplayDriver.Text = FileBrowserDialog.FileName
        End If
    End Sub

    Private Sub MiscPROMFileBrowse_Click(sender As System.Object, e As System.EventArgs) Handles MiscPROMFileBrowse.Click
        If FileBrowserDialog.ShowDialog = Forms.DialogResult.OK Then
            MiscPROMFile.Text = FileBrowserDialog.FileName
        End If
    End Sub

    Private Sub MiscPROMBootPathBrowse_Click(sender As System.Object, e As System.EventArgs) Handles MiscPROMBootPathBrowse.Click
        If SelectDrive.ShowDialog = Forms.DialogResult.OK Then
            MiscPROMBootPath.Text = SelectDrive.SelectedPath
        End If
    End Sub

    Private Sub MiscNVRAMFileBrowse_Click(sender As System.Object, e As System.EventArgs) Handles MiscNVRAMFileBrowse.Click
        If FileBrowserDialog.ShowDialog = Forms.DialogResult.OK Then
            MiscNVRAMFile.Text = FileBrowserDialog.FileName
        End If
    End Sub
End Class