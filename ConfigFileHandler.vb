Module ConfigFileHandler
    Public Sub Create(ByVal MacName As String, ByVal Path As String, ByVal Emulator As String, ByVal RAMInMB As Integer, _
                      ByVal UseDisk As String, Optional ByVal DiskSize As Integer = 0, Optional ByVal DiskPath As String = "")
        Dim ConfigFile As String = ""

        If UseDisk = "New" Then
            DiskImageCreator.CreateRawDisk(DiskSize, DiskPath, False)
        End If

EmulatorSection:
        Select Case Emulator
            Case "vMac"
                If UseDisk = "New" Or UseDisk = "Exist" Then
                    ConfigFile = FormatLine("disk", DiskPath)
                End If
                ConfigFile = ConfigFile & My.Settings.vMacROM & vbCrLf
            Case "SheepShaver"
                If UseDisk = "New" Or UseDisk = "Exist" Then
                    ConfigFile = FormatLine("disk", DiskPath)
                End If
                ConfigFile = ConfigFile & FormatLine("extfs", "")
                ConfigFile = ConfigFile & FormatLine("screen", "win/800/600")
                ConfigFile = ConfigFile & FormatLine("windowmodes", "2")
                ConfigFile = ConfigFile & FormatLine("screenmodes", "62")
                ConfigFile = ConfigFile & FormatLine("seriala", "COM1")
                ConfigFile = ConfigFile & FormatLine("serialb", "COM2")
                ConfigFile = ConfigFile & FormatLine("rom", My.Settings.SheepShaverROM)
                ConfigFile = ConfigFile & FormatLine("bootdrive", "0")
                ConfigFile = ConfigFile & FormatLine("bootdriver", "0")
                ConfigFile = ConfigFile & FormatLine("ramsize", (RAMInMB * 1024) * 1024)
                ConfigFile = ConfigFile & FormatLine("frameskip", "0")
                ConfigFile = ConfigFile & FormatLine("gfxaccel", "true")
                ConfigFile = ConfigFile & FormatLine("nocdrom", "false")
                ConfigFile = ConfigFile & FormatLine("nonet", "false")
                ConfigFile = ConfigFile & FormatLine("nosound", "false")
                ConfigFile = ConfigFile & FormatLine("nogui", "false")
                ConfigFile = ConfigFile & FormatLine("noclipconversion", "false")
                ConfigFile = ConfigFile & FormatLine("ignoresegv", "true")
                ConfigFile = ConfigFile & FormatLine("ignoreillegal", "true")
                ConfigFile = ConfigFile & FormatLine("jit", "true")
                ConfigFile = ConfigFile & FormatLine("jit68k", "false")
                ConfigFile = ConfigFile & FormatLine("keyboardtype", "5")
                ConfigFile = ConfigFile & FormatLine("ether", "slirp")
                ConfigFile = ConfigFile & FormatLine("keycodes", "false")
                ConfigFile = ConfigFile & FormatLine("keycodefile", "BasiliskII_keycodes")
                ConfigFile = ConfigFile & FormatLine("mousewheelmode", "1")
                ConfigFile = ConfigFile & FormatLine("mousewheellines", "3")
                ConfigFile = ConfigFile & FormatLine("idlewait", "true")
                ConfigFile = ConfigFile & FormatLine("mousewheelmode", "1")
                ConfigFile = ConfigFile & FormatLine("mousewheellines", "3")
                ConfigFile = ConfigFile & FormatLine("enableextfs", "false")
                ConfigFile = ConfigFile & FormatLine("debugextfs", "false")
                ConfigFile = ConfigFile & FormatLine("extdrives", "CDEFGHIJKLMNOPQRSTUVWXYZ")
                ConfigFile = ConfigFile & FormatLine("pollmedia", "true")
                ConfigFile = ConfigFile & FormatLine("etherpermanentaddress", "true")
                ConfigFile = ConfigFile & FormatLine("routerenabled", "false")
                ConfigFile = ConfigFile & FormatLine("portfile0", My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\Com1.txt")
                ConfigFile = ConfigFile & FormatLine("portfile1", My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\Com2.txt")
            Case "BII"
                If UseDisk = "New" Or UseDisk = "Exist" Then
                    ConfigFile = FormatLine("disk", DiskPath)
                End If
                ConfigFile = ConfigFile & FormatLine("extfs", "")
                ConfigFile = ConfigFile & FormatLine("screen", "win/800/600")
                ConfigFile = ConfigFile & FormatLine("seriala", "COM1")
                ConfigFile = ConfigFile & FormatLine("serialb", "COM2")
                ConfigFile = ConfigFile & FormatLine("ether", "slirp")
                ConfigFile = ConfigFile & FormatLine("udptunnel", "false")
                ConfigFile = ConfigFile & FormatLine("udpport", "6066")
                ConfigFile = ConfigFile & FormatLine("rom", My.Settings.BasiliskROM)
                ConfigFile = ConfigFile & FormatLine("bootdrive", 0)
                ConfigFile = ConfigFile & FormatLine("bootdriver", 0)
                ConfigFile = ConfigFile & FormatLine("ramsize", (RAMInMB * 1024) * 1024)
                ConfigFile = ConfigFile & FormatLine("frameskip", 0)
                ConfigFile = ConfigFile & FormatLine("modelid", 5)
                ConfigFile = ConfigFile & FormatLine("cpu", 4)
                ConfigFile = ConfigFile & FormatLine("fpu", "true")
                ConfigFile = ConfigFile & FormatLine("nocdrom", "false")
                ConfigFile = ConfigFile & FormatLine("nosound", "false")
                ConfigFile = ConfigFile & FormatLine("noclipconversion", "false")
                ConfigFile = ConfigFile & FormatLine("nogui", "false")
                ConfigFile = ConfigFile & FormatLine("jit", "true")
                ConfigFile = ConfigFile & FormatLine("jitfpu", "true")
                ConfigFile = ConfigFile & FormatLine("jitdebug", "true")
                ConfigFile = ConfigFile & FormatLine("jitcachesize", 4096)
                ConfigFile = ConfigFile & FormatLine("jitlazyflush", "true")
                ConfigFile = ConfigFile & FormatLine("jitinline", "true")
                ConfigFile = ConfigFile & FormatLine("keyboardtype", "5")
                ConfigFile = ConfigFile & FormatLine("keycodes", "false")
                ConfigFile = ConfigFile & FormatLine("keycodefile", "BasiliskII_keycodes")
                ConfigFile = ConfigFile & FormatLine("mousewheelmode", "1")
                ConfigFile = ConfigFile & FormatLine("mousewheellines", "3")
                ConfigFile = ConfigFile & FormatLine("ignoresegv", "true")
                ConfigFile = ConfigFile & FormatLine("idlewait", "true")
                ConfigFile = ConfigFile & FormatLine("enableextfs", "false")
                ConfigFile = ConfigFile & FormatLine("debugextfs", "false")
                ConfigFile = ConfigFile & FormatLine("extdrives", "CDEFGHIJKLMNOPQRSTUVWXYZ")
                ConfigFile = ConfigFile & FormatLine("pollmedia", "true")
                ConfigFile = ConfigFile & FormatLine("etherpermanentaddress", "true")
                ConfigFile = ConfigFile & FormatLine("routerenabled", "false")
                ConfigFile = ConfigFile & FormatLine("portfile0", My.Application.Info.DirectoryPath & "COM1.log")
                ConfigFile = ConfigFile & FormatLine("portfile1", My.Application.Info.DirectoryPath & "COM2.log")
            Case "PearPC"
                ConfigFile = FormatLine("ppc_start_resolution =", "800x600x15", True)
                ConfigFile = ConfigFile & FormatLine("ppc_start_full_screen =", 0)
                ConfigFile = ConfigFile & FormatLine("redraw_interval_msec =", 40)
                ConfigFile = ConfigFile & FormatLine("key_compose_dialog =", "F11", True)
                ConfigFile = ConfigFile & FormatLine("key_change_cd_0 =", "none", True)
                ConfigFile = ConfigFile & FormatLine("key_toggle_mouse_grab =", "F12", True)
                ConfigFile = ConfigFile & FormatLine("key_toggle_full_screen =", "Alt+Return", True)
                ConfigFile = ConfigFile & FormatLine("prom_bootmethod =", "select", True)
                ConfigFile = ConfigFile & FormatLine("prom_env_machargs =", "", True)
                ConfigFile = ConfigFile & FormatLine("prom_driver_graphic =", "video.x", True)
                ConfigFile = ConfigFile & FormatLine("page_table_pa =", "104857600")
                ConfigFile = ConfigFile & FormatLine("cpu_pvr =", "0x00088302")
                ConfigFile = ConfigFile & FormatLine("memory_size =", "0x" & RAMInMB / 0.0000256)
                If UseDisk = "New" Or UseDisk = "Exist" Then
                    ConfigFile = ConfigFile & FormatLine("pci_ide0_master_installed =", "1")
                    ConfigFile = ConfigFile & FormatLine("pci_ide0_master_image =", DiskPath, True)
                    ConfigFile = ConfigFile & FormatLine("pci_ide0_master_type =", "hd", True)
                Else
                    ConfigFile = ConfigFile & FormatLine("pci_ide0_master_installed =", "0")
                End If
                ConfigFile = ConfigFile & FormatLine("pci_ide0_slave_installed =", "0")
                ConfigFile = ConfigFile & FormatLine("pci_3c90x_installed =", "0")
                ConfigFile = ConfigFile & FormatLine("pci_3c90x_mac =", "de:ad:ca:fe:12:34", True)
                ConfigFile = ConfigFile & FormatLine("pci_rtl8139_installed =", "0", True)
                ConfigFile = ConfigFile & FormatLine("pci_rtl8139_mac =", "de:ad:ca:fe:12:34", True)
                ConfigFile = ConfigFile & FormatLine("pci_usb_installed =", "1")
                ConfigFile = ConfigFile & FormatLine("pci_serial_installed =", "0")
                ConfigFile = ConfigFile & FormatLine("nvram_file =", "nvram", True)
            Case "QEMU"
                '//Will be used for reference to load and save batches for QEMU
                'ConfigFile = "qemu-system-ppc.exe -L pc-bios -boot d -m " & RAMInMB & " -M mac99 -prom-env " & Chr(34) & _
                '    "auto-boot?=true" & Chr(34) & " -prom-env " & Chr(34) & "boot-args=-v" & Chr(34) & " -prom-env " & Chr(34) & _
                '    "vga-ndrv?=true" & Chr(34) & " -drive file=MacOS9.2.iso,format=raw,media=cdrom " & _
                '    "-drive file=" & Chr(34) & DiskPath & Chr(34) & _
                '    ",format=raw,media=disk -sdl -netdev user,id=network01 -device sungem,netdev=network01 "
                ConfigFile = "qemu-system-ppc.exe -L pc-bios -boot d -m " & RAMInMB & " -M mac99 -prom-env " & Chr(34) & _
                    "auto-boot?=true" & Chr(34) & " -prom-env " & Chr(34) & "boot-args=-v" & Chr(34) & " -prom-env " & Chr(34) & _
                    "vga-ndrv?=true" & Chr(34) & "-drive file=" & Chr(34) & DiskPath & Chr(34) & _
                    ",format=raw,media=disk -sdl -netdev user,id=network01 -device sungem,netdev=network01 "
        End Select

CreateFiles:
        If My.Computer.FileSystem.DirectoryExists(System.IO.Path.GetDirectoryName(MacName)) = False Then 'Verify that the path doesn't exists
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Path))
            Write(ConfigFile, Path)
        Else    'If the path does already exist...
            MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Path & "(1)"))
            Write(ConfigFile, Path)
        End If
        With frmMain.VMList.Items.Add(MacName)  'Add the fresh new Mac to the console
            .SubItems.Add(Path)         'Several SubItems are used to load. This one sets the path tp the config file
            .SubItems.Add(Emulator)     'This one sets the emulator to load properly a file
            .StateImageIndex = 0        'Will be reimplemented. Used for icons
        End With
        frmMain.SaveSettings()
    End Sub

    Public Function FormatLine(ByVal Line1 As String, ByVal Line2 As String, Optional InQuotes As Boolean = False) As String
        Dim Formatted As String = ""
        If InQuotes = False Then
            Formatted = Line1 & " " & Line2 & vbCrLf
        Else
            Formatted = Line1 & " " & Chr(34) & Line2 & Chr(34) & vbCrLf
        End If
        Return Formatted
    End Function

    Public Sub Edit(ByVal ConfigFile As String, ByVal Emulator As String, ByVal Parameters As String)

    End Sub

    Public Sub Convert(ByVal FileToConvert As String, ByVal OldEmulator As String, ByVal NewEmulator As String)

    End Sub

    Public Sub Write(ByVal Text As String, ByVal Route As String)
        Dim Writer As IO.StreamWriter = IO.File.CreateText(Route)
        Writer.Write(Text)
        Writer.Flush()
        Writer.Close()
    End Sub

    Public Sub CreateFromFile(ByVal File As String, ByVal Emulator As String, ByVal VMName As String)
        Dim VMPath As String = My.Settings.DefaultMacFolder + "\" + VMName
        Dim VMFile As String = VMPath + "\" + VMName + ".mcf"

        Select Case Emulator

            Case "vMacBatch"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("vMac")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "vMac"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("vMac")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "BII"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("BII")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "SheepShaver"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("SheepShaver")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "PearPC"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("PearPC")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "QEMUBatch"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.CreateDirectory(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("QEMU")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()
        End Select
    End Sub
End Module