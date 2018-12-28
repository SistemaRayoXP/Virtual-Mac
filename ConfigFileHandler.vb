Module ConfigFileHandler
    Public Sub Create(ByVal Emulator As String, ByVal Path As String, ByVal ConfigArray() As String)
        Dim ConfigFile As String = ""
        Dim ConfigType As String = ""
        Dim DiskSize As String = ""
        Dim DiskPath As String = ""
        Dim RAM As Integer
        Dim MacName As String = ""
        Dim MacPath As String = ""

        GoTo SkipNew

        If Path = "" Then
            Path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & ConfigArray(0)
        End If

        If ConfigArray(1) = True Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Tools\qemu-img.exe") Then
                Shell(My.Application.Info.DirectoryPath & "\Tools\qemu-img.exe create -f raw -o size=" & DiskSize & "M " & Chr(34) & DiskPath & Chr(34))
            End If
        End If
        GoTo EmulatorSection

SkipNew:


EmulatorSection:
        Select Case Emulator
            Case "vMac"
                ConfigType = "vMac"
                ConfigFile = DiskPath & vbCrLf
                ConfigFile = ConfigFile & RAM & vbCrLf
                ConfigFile = ConfigFile & My.Settings.vMacROM & vbCrLf
            Case "SheepShaver"
                ConfigType = "SheepShaver"
                ConfigFile = FormatLine("disk", DiskPath)
                ConfigFile = ConfigFile & FormatLine("extfs", "")
                ConfigFile = ConfigFile & FormatLine("screen", "win/800/600")
                ConfigFile = ConfigFile & FormatLine("windowmodes", "2")
                ConfigFile = ConfigFile & FormatLine("screenmodes", "62")
                ConfigFile = ConfigFile & FormatLine("seriala", "FILE")
                ConfigFile = ConfigFile & FormatLine("serialb", "COM2")
                ConfigFile = ConfigFile & FormatLine("rom", My.Settings.SheepShaverROM)
                ConfigFile = ConfigFile & FormatLine("bootdrive", "0")
                ConfigFile = ConfigFile & FormatLine("bootdriver", "0")
                ConfigFile = ConfigFile & FormatLine("ramsize", (RAM * 1024) * 1024)
                ConfigFile = ConfigFile & FormatLine("frameskip", "0")
                ConfigFile = ConfigFile & FormatLine("gfxaccel", "true")
                ConfigFile = ConfigFile & FormatLine("nocdrom", "false")
                ConfigFile = ConfigFile & FormatLine("nonet", "false")
                ConfigFile = ConfigFile & FormatLine("nosound", "false")
                ConfigFile = ConfigFile & FormatLine("nogui", "false")
                ConfigFile = ConfigFile & FormatLine("noclipconversion", "false")
                ConfigFile = ConfigFile & FormatLine("ignoresegv", "true")
                ConfigFile = ConfigFile & FormatLine("ignoreillegal", "false")
                ConfigFile = ConfigFile & FormatLine("jit", "true")
                ConfigFile = ConfigFile & FormatLine("jit68k", "false")
                ConfigFile = ConfigFile & FormatLine("keyboardtype", "5")
                ConfigFile = ConfigFile & FormatLine("ether", "slirp")
                ConfigFile = ConfigFile & FormatLine("keycodes", "false")
                ConfigFile = ConfigFile & FormatLine("keycodefile", My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\BasiliskII_keycodes")
                ConfigFile = ConfigFile & FormatLine("mousewheelmode", "1")
                ConfigFile = ConfigFile & FormatLine("mousewheellines", "3")
                ConfigFile = ConfigFile & FormatLine("ignoresegv", "true")
                ConfigFile = ConfigFile & FormatLine("idlewait", "true")
                ConfigFile = ConfigFile & FormatLine("keycodes", "true")
                ConfigFile = ConfigFile & FormatLine("keycodefile", My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\BasiliskII_keycodes")
                ConfigFile = ConfigFile & FormatLine("mousewheelmode", "1")
                ConfigFile = ConfigFile & FormatLine("mousewheellines", "3")
                ConfigFile = ConfigFile & FormatLine("enableextfs", "false")
                ConfigFile = ConfigFile & FormatLine("debugextfs", "false")
                ConfigFile = ConfigFile & FormatLine("extdrives", "CDEFGHIJKLMNOPQRSTUVWXYZ")
                ConfigFile = ConfigFile & FormatLine("pollmedia", "true")
                ConfigFile = ConfigFile & FormatLine("etherpermanentaddress", "True")
                ConfigFile = ConfigFile & FormatLine("ethermulticastmode", "0")
                ConfigFile = ConfigFile & FormatLine("routerenabled", "false")
                ConfigFile = ConfigFile & FormatLine("ftp_port_list", "21")
                ConfigFile = ConfigFile & FormatLine("portfile0", My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\Com1.txt")
                ConfigFile = ConfigFile & FormatLine("portfile1", My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\Com2.txt")
            Case "BII"
                ConfigType = "BII"
                ConfigFile = FormatLine("disk", DiskPath)
                ConfigFile = ConfigFile & FormatLine("extfs", "")
                ConfigFile = ConfigFile & FormatLine("screen", "win/800/600")
                ConfigFile = ConfigFile & FormatLine("seriala", "FILE")
                ConfigFile = ConfigFile & FormatLine("serialb", "COM2")
                ConfigFile = ConfigFile & FormatLine("ether", "slirp")
                ConfigFile = ConfigFile & FormatLine("udptunnel", "false")
                ConfigFile = ConfigFile & FormatLine("udpport", "6066")
                ConfigFile = ConfigFile & FormatLine("rom", My.Settings.BasiliskROM)
                ConfigFile = ConfigFile & FormatLine("bootdrive", 0)
                ConfigFile = ConfigFile & FormatLine("bootdriver", 0)
                ConfigFile = ConfigFile & FormatLine("ramsize", (RAM * 1024) * 1024)
                ConfigFile = ConfigFile & FormatLine("frameskip", 1)
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
                ConfigFile = ConfigFile & FormatLine("keycodefile", My.Application.Info.DirectoryPath & "\Emulators\BasiliskII\BasiliskII_keycodes")
                ConfigFile = ConfigFile & FormatLine("mousewheelmode", "1")
                ConfigFile = ConfigFile & FormatLine("mousewheellines", "3")
                ConfigFile = ConfigFile & FormatLine("ignoresegv", "true")
                ConfigFile = ConfigFile & FormatLine("idlewait", "true")
                ConfigFile = ConfigFile & FormatLine("enableextfs", "false")
                ConfigFile = ConfigFile & FormatLine("debugextfs", "false")
                ConfigFile = ConfigFile & FormatLine("extdrives", "CDEFGHIJKLMNOPQRSTUVWXYZ")
                ConfigFile = ConfigFile & FormatLine("pollmedia", "true")
                ConfigFile = ConfigFile & FormatLine("etherpermanentaddress", "true")
                ConfigFile = ConfigFile & FormatLine("ethermulticastmode", 0)
                ConfigFile = ConfigFile & FormatLine("routerenabled", "false")
                ConfigFile = ConfigFile & FormatLine("ftp_port_list", 21)
                ConfigFile = ConfigFile & FormatLine("portfile0", My.Application.Info.DirectoryPath & "\Emulators\BasiliskII\COM1.txt")
                ConfigFile = ConfigFile & FormatLine("portfile1", My.Application.Info.DirectoryPath & "\Emulators\BasiliskII\COM2.txt")
            Case "QEMU"
                ConfigType = "QEMU"
                ConfigFile = "qemu-system-ppc.exe -L pc-bios -boot d -m " & RAM & " -M mac99 -prom-env " & Chr(34) & "auto-boot?=true" & Chr(34) & " -prom-env " & Chr(34) & "boot-args=-v" & Chr(34) & " -prom-env " & Chr(34) & "vga-ndrv?=true" & Chr(34) & " -drive file=MacOS9.2.iso,format=raw,media=cdrom -drive file=MacOS9.2.img,format=raw,media=disk -sdl -netdev user,id=network01 -device sungem,netdev=network01 "
            Case "Unknown"
                MsgBox("Could not detect the emulator of this file. Maybe the file syntax is wrong?")
                Exit Sub
        End Select

CreateFiles:
        If My.Computer.FileSystem.DirectoryExists(System.IO.Path.GetDirectoryName(MacName)) = False Then
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Path))
            Write(ConfigFile, Path)
        Else
            MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(MacPath & "(Dup)"))
            Write(ConfigFile, MacPath)
        End If
        With frmMain.VMList.Items.Add(MacName)
            .SubItems.Add(MacPath)
            .SubItems.Add(ConfigType)
            .StateImageIndex = 0
        End With
        frmMain.SaveSettings()
    End Sub

    Public Function FormatLine(ByVal Line1 As String, ByVal Line2 As String) As String
        Dim Formatted As String = Line1 & " " & Line2 & vbCrLf
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
                    My.Computer.FileSystem.DirectoryExists(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                Else
                    MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder + "\" + File + "(2)")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("vMac")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "vMac"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.DirectoryExists(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                Else
                    MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder + "\" + File + "(2)")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("vMac")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "BII"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.DirectoryExists(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                Else
                    MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder + "\" + File + "(2)")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("BII")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "SheepShaver"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.DirectoryExists(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                Else
                    MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder + "\" + File + "(2)")
                End If
                With frmMain.VMList.Items.Add(VMFile)
                    .SubItems.Add(VMPath)
                    .SubItems.Add("SheepShaver")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "PearPC"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.DirectoryExists(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                Else
                    MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder + "\" + File + "(2)")
                End If
                With frmMain.VMList.Items.Add(VMName)
                    .SubItems.Add(VMFile)
                    .SubItems.Add("PearPC")
                    .StateImageIndex = 0
                End With
                frmMain.SaveSettings()

            Case "QEMUBatch"
                If My.Computer.FileSystem.DirectoryExists(VMPath) = False Then
                    My.Computer.FileSystem.DirectoryExists(VMPath)
                    My.Computer.FileSystem.CopyFile(File, VMPath + "\" + VMName + ".mcf")
                Else
                    MsgBox("This folder already exists. Creating a duplicate.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder + "\" + File + "(2)")
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