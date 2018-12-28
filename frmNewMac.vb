Public Class frmNewMac

    Public HostRAM As Long = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024
    Public NameWithoutPath As String

    Public Sub SetFinalData()
        MachineName.Text = NameWithoutPath
        MachineMemory.Text = RAM.Text & " MB"
        MachineDisk.Text = DiskSize.Value & " MB"
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Tools\qemu-img.exe") = False Then
            ExistingDisk.Checked = True
            NewDisk.Enabled = False
        End If

        If Welcome.Visible = True And Welcome.Enabled = True Then
            SelectType.Enabled = True
            SelectType.BringToFront()
            MovePage(Welcome, Wizard)
            DontUseWizard.Focus()
            cmdBack.Enabled = True
            GoTo EndOfInstruction
        End If

        If Wizard.Visible = True And Wizard.Enabled = True Then
            If SelectType.Visible = True And SelectType.Enabled = True Then
                If UseWizard.Checked = True Or DontUseWizard.Checked = True Then
                    MovePage(SelectType, CreateNew)
                    MacName.Focus()
                    MacName.SelectAll()
                Else
                    MovePage(SelectType, AddExisting)
                    cmdNext.Enabled = False
                End If
                GoTo EndOfInstruction
            End If

            If AddExisting.Visible = True And AddExisting.Enabled = True Then
                MovePage(Wizard, EndWizard)
                GoTo EndOfInstruction
            End If

            If CreateNew.Visible = True And CreateNew.Enabled = True Then
                If System.IO.Path.GetFileNameWithoutExtension(MacName.Text) = MacName.Text Then
                    NameWithoutPath = MacName.Text
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder & "\" & NameWithoutPath) = True Then
                    MsgBox("This Mac already exists in ''My Macs\" & NameWithoutPath & "''. Please use a different name, or save the Mac to another location.", MsgBoxStyle.Exclamation)
                    Exit Sub
                Else
                    AutoSelectOS()
                    MovePage(CreateNew, HwPresets)
                End If
                GoTo EndOfInstruction
            End If

            If HwPresets.Visible = True And HwPresets.Enabled = True Then
                If DontUseWizard.Checked = True Then
                    SetFinalData()
                    cmdNext.Text = "Finish"
                    MovePage(Wizard, EndWizard)
                    cmdNext.Focus()
                Else
                    MovePage(HwPresets, AssignRAM)
                End If
                GoTo EndOfInstruction
            End If

            If AssignRAM.Visible = True And AssignRAM.Enabled = True Then
                MovePage(AssignRAM, SelectDisk)
                GoTo EndOfInstruction
            End If

            If SelectDisk.Visible = True And SelectDisk.Enabled = True Then
                SetFinalData()
                cmdNext.Text = "Finish"
                MovePage(Wizard, EndWizard)
                cmdNext.Focus()
                GoTo EndOfInstruction
            End If
        End If

        If EndWizard.Visible = True And EndWizard.Enabled = True Then
            CreateMac()
            Me.Close()
            GoTo EndOfInstruction
        End If

EndOfInstruction:

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        If Wizard.Visible = True And Wizard.Enabled = True Then
            If SelectType.Visible = True And SelectType.Enabled = True Then
                cmdBack.Enabled = False
                MovePage(Wizard, Welcome)
                GoTo EndOfInstruction
            End If

            If AddExisting.Visible = True And AddExisting.Enabled = True Then
                MovePage(AddExisting, SelectType)
                GoTo EndOfInstruction
            End If

            If CreateNew.Visible = True And CreateNew.Enabled = True Then
                MovePage(CreateNew, SelectType)
                GoTo EndOfInstruction
            End If

            If HwPresets.Visible = True And HwPresets.Enabled = True Then
                MovePage(HwPresets, CreateNew)
                MacName.Focus()
                MacName.SelectAll()
                GoTo EndOfInstruction
            End If

            If AssignRAM.Visible = True And AssignRAM.Enabled = True Then
                MovePage(AssignRAM, HwPresets)
                GoTo EndOfInstruction
            End If

            If SelectDisk.Visible = True And SelectDisk.Enabled = True Then
                MovePage(SelectDisk, AssignRAM)
                GoTo EndOfInstruction
            End If
        End If

        If EndWizard.Visible = True And EndWizard.Enabled = True Then
            cmdNext.Text = "Next >"
            MovePage(EndWizard, Wizard)
        GoTo EndOfInstruction
        End If

EndOfInstruction:

    End Sub

    Public Sub CreateMac()
        Dim CreateDisk As Boolean
        Dim UD As Boolean 'UD stands for UseDisk, just that the object already exists, so I need an acronym
        Dim Emulator As String = ""
        Dim Configs() As String

        If NewDisk.Checked = True Then
            CreateDisk = True
        Else
            CreateDisk = False
        End If

        If NoDisk.Checked = True Then
            UD = False
        End If

        If AddFromFile.Checked = True Then  '//Checking the RadioButton "Add from file" to be checked, so we create from file
            Select Case AEEmulatorType.SelectedItem.ToString
                Case "Mini vMac Batch"
                    Emulator = "vMacBatch"
                Case "Virtual Mac MvM File"
                    Emulator = "vMac"
                Case "Basilisk"
                    Emulator = "BII"
                Case "SheepShaver"
                    Emulator = "SheepShaver"
                Case "PearPC"
                    Emulator = "PearPC"
                Case "QEMU Windows Batch"
                    Emulator = "QEMUBatch"
            End Select
            ConfigFileHandler.CreateFromFile(AEFile.Text, Emulator, AEName.Text)
        ElseIf UseWizard.Checked = True Or DontUseWizard.Checked = True Then
            Select Case OSList.SelectedIndex
                Case 0
                    Emulator = "vMac"
                Case 1, 2
                    Emulator = "BII"
                Case 3, 4
                    Emulator = "SheepShaver"
                Case 5, 6, 7, 8, 9
                    Emulator = "QEMU"
            End Select
            ConfigFileHandler.Create(Emulator, MacName.Text, Configs)
        End If
    End Sub

    Public Sub DisableAllPages()
        EndWizard.Enabled = False
        SelectDisk.Enabled = False
        AssignRAM.Enabled = False
        HwPresets.Enabled = False
        AddExisting.Enabled = False
        CreateNew.Enabled = False
        SelectType.Enabled = False
        Wizard.Enabled = False
        Welcome.Enabled = False
    End Sub

    Public Sub MovePage(ByVal CurrentTab As System.Windows.Forms.Panel, ByVal NewTab As System.Windows.Forms.Panel)
        NewTab.Enabled = True
        NewTab.BringToFront()
        CurrentTab.Enabled = False
    End Sub

    Public Sub DataProgrammer(ByVal OSType As String)

        Select Case OSType
            Case "Mac6"
                If HostRAM < 8 Then
                    MsgBox("You have lower memory than the required to run System Software 6. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "Insufficient Memory")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 8
                DiskSize.Value = 100
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", "8")
                DefMem.Text = 8 & " MB"
                DefDisk.Text = 128 & " MB"
                DefCPU.Text = "Motorola 68000"
            Case "Mac7"
                If HostRAM < 40 Then
                    MsgBox("You have lower memory than the required to run System Software 7. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 16
                DiskSize.Value = 250
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 16)
                DefMem.Text = 16 & " MB"
                DefDisk.Text = 250 & " MB"
                DefCPU.Text = "Motorola 68040"
            Case "Mac7Pro"
                If HostRAM < 64 Then
                    MsgBox("You have lower memory than the required to run  MacOS 7. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 24
                DiskSize.Value = 250
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 24)
                DefMem.Text = 24 & " MB"
                DefDisk.Text = 250 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Mac8"
                If HostRAM < 128 Then
                    MsgBox("You have lower memory than the required to run MacOS 8. Install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 64
                DiskSize.Value = 500
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 64)
                DefMem.Text = 64 & " MB"
                DefDisk.Text = 500 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Mac9"
                If HostRAM < 256 Then
                    MsgBox("You have lower memory than the required to run MacOS 9. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 256
                DiskSize.Value = 1024
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 256)
                DefMem.Text = 256 & " MB"
                DefDisk.Text = 1024 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Mac10"
                If HostRAM < 384 Then
                    MsgBox("You have lower memory than the required to run Mac OS X. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 384
                DiskSize.Value = 3072
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 384)
                DefMem.Text = 384 & " MB"
                DefDisk.Text = 3072 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Debian"
                If HostRAM < 400 Then
                    MsgBox("You have lower memory than the required to run Debian. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 400
                DiskSize.Value = 4096
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 400)
                DefMem.Text = 400 & " MB"
                DefDisk.Text = 4096 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Ubuntu"
                If HostRAM < 400 Then
                    MsgBox("You have lower memory than the required to run Ubuntu. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 400
                DiskSize.Value = 6144
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 400)
                DefMem.Text = 400 & " MB"
                DefDisk.Text = 6144 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Linux"
                If HostRAM < 400 Then
                    MsgBox("You have lower memory than the required to run Linux. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 400
                DiskSize.Value = 4096
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 400)
                DefMem.Text = 400 & " MB"
                DefDisk.Text = 4096 & " MB"
                DefCPU.Text = "PowerPC G3"
            Case "Other"
                If HostRAM < 256 Then
                    MsgBox("You have lower memory than the required to run Other. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAM.Text = RAMSlider.Maximum
                End If
                RAM.Text = 256
                DiskSize.Value = 4096
                RecommendedRAM.Text = Replace(RecommendedRAM.Text, "%m", 256)
                DefMem.Text = 256 & " MB"
                DefDisk.Text = 4096 & " MB"
                DefCPU.Text = "PowerPC G3"
        End Select

        'Place in cmdNext.Click code area
        MacName.Text = My.Settings.DefaultMacFolder & "\" & NameWithoutPath & "\" & NameWithoutPath & ".mcf"
        DiskPath.Text = My.Settings.DefaultMacFolder & "\" & NameWithoutPath & "\" & NameWithoutPath & ".dsk"
    End Sub

    Public Function AutoSelectOS() As String
        Dim OS As String = "Other"
        Dim OsFound As Long

        OsFound = InStr(MacName.Text, "System Software")
        If OsFound <> 0 Then
            OS = "Mac6"
            OSList.SelectedIndex = 0
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 6")
        If OsFound <> 0 Then
            OS = "Mac6"
            OSList.SelectedIndex = 0
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 7")
        If OsFound <> 0 Then
            OS = "Mac7"
            OSList.SelectedIndex = 1
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 7.")
        If OsFound <> 0 Then
            OS = "Mac75"
            OSList.SelectedIndex = 2
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 8")
        If OsFound <> 0 Then
            OS = "Mac8"
            OSList.SelectedIndex = 3
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 9")
        If OsFound <> 0 Then
            OS = "Mac9"
            OSList.SelectedIndex = 4
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " Classic")
        If OsFound <> 0 Then
            OS = "Mac9"
            OSList.SelectedIndex = 4
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 10")
        If OsFound <> 0 Then
            OS = "Mac10"
            OSList.SelectedIndex = 5
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " X")
        If OsFound <> 0 Then
            OS = "Mac10"
            OSList.SelectedIndex = 5
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, "Debian")
        If OsFound <> 0 Then
            OS = "Debian"
            OSList.SelectedIndex = 6
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, "Ubuntu")
        If OsFound <> 0 Then
            OS = "Ubuntu"
            OSList.SelectedIndex = 7
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, "Linux")
        If OsFound <> 0 Then
            OS = "Linux"
            OSList.SelectedIndex = 8
            GoTo OSDetected
        End If

        OSList.SelectedIndex = 9

OSDetected:

        Return OS
    End Function

    Private Sub SaveMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMac.Click
        Save.Filter = "Virtual Mac Configuration File (*.mcf)|*.mcf|All files (*.*)|*.*"
        Save.ShowDialog()
        If Save.FileName <> "" Then
            MacName.Text = Save.FileName
        End If
    End Sub

    Private Sub frmNewMac_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RAMSlider.TickFrequency = HostRAM / 20
        RAMSlider.Maximum = HostRAM
        WarningInvalidSize.Text = Replace(Replace(WarningInvalidSize.Text, "%x", RAMSlider.Maximum), "%n", RAMSlider.Minimum)
        DisableAllPages()
        MovePage(Wizard, Welcome)
        AEEmulatorType.SelectedIndex = 0
        OSList.SelectedIndex = 0
    End Sub

    Private Sub RAM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAM.TextChanged
        If RAM.Text = "" Then
            RAMSlider.Value = RAMSlider.Minimum
            cmdNext.Enabled = False
            WarningInvalidSize.Visible = True
        Else
            If RAM.Text > RAMSlider.Maximum Then
                RAMSlider.Value = RAMSlider.Maximum
                cmdNext.Enabled = False
                WarningInvalidSize.Visible = True
            Else
                If RAM.Text < RAMSlider.Minimum Then
                    RAMSlider.Value = RAMSlider.Minimum
                    cmdNext.Enabled = False
                    WarningInvalidSize.Visible = True
                Else
                    RAMSlider.Value = RAM.Text
                    WarningInvalidSize.Visible = False
                    cmdNext.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub RAMSlider_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles RAMSlider.Scroll
        RAM.Text = RAMSlider.Value
    End Sub

    Private Sub RAM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultRAM.CheckedChanged, CustomRAM.CheckedChanged
        If CustomRAM.Checked = True Then
            CustomRAMContainer.Enabled = True
            CustomRAMContainer.Visible = True
        Else
            CustomRAMContainer.Enabled = False
            CustomRAMContainer.Visible = False
        End If
    End Sub

    Private Sub OSList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSList.SelectedIndexChanged
        Select Case OSList.SelectedIndex
            Case 0
                DataProgrammer("Mac6")
            Case 1
                DataProgrammer("Mac7")
            Case 2
                DataProgrammer("Mac7Pro")
            Case 3
                DataProgrammer("Mac8")
            Case 4
                DataProgrammer("Mac9")
            Case 5
                DataProgrammer("Mac10")
            Case 6
                DataProgrammer("Debian")
            Case 7
                DataProgrammer("Ubuntu")
            Case 8
                DataProgrammer("Linux")
            Case 9
                DataProgrammer("Other")
        End Select
    End Sub

    Private Sub BrowseDiskLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseDiskLocation.Click
        If NewDisk.Checked = True Then
            Save.Filter = "Disk files (*.dsk)|*.dsk|Disk Image Files (*.img)|*.img|All files (*.*)|*.*"
            Save.ShowDialog()
            If Save.FileName <> "" Then
                DiskPath.Text = Save.FileName
            End If
        Else
            Open.Filter = "Disk files (*.dsk)|*.dsk|Disk Image Files (*.img)|*.img|All files (*.*)|*.*"
            Open.ShowDialog()
            If Open.FileName <> "" Then
                DiskPath.Text = Open.FileName
            End If
        End If
    End Sub

    Private Sub MacName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MacName.Click
        MacName.SelectAll()
    End Sub

    Private Sub MacName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MacName.GotFocus
        MacName.SelectAll()
    End Sub

    Private Sub Disk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDisk.CheckedChanged, ExistingDisk.CheckedChanged
        If NewDisk.Checked = True Then
            DiskTools.Visible = True
        Else
            DiskTools.Visible = False
        End If
        If NoDisk.Checked = True Then
            DiskPath.Enabled = False
            BrowseDiskLocation.Enabled = False
        Else
            DiskPath.Enabled = True
            BrowseDiskLocation.Enabled = True
        End If
    End Sub

    Private Sub AEBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AEBrowseFile.Click
        Open.Filter = "Batch files|*.bat|Basilisk/SheepShaver preferences file|*_prefs|PearPC Config Files|*.cfg|Virtual Mac Mini vMac Configuration File|*.mcf|All files|*.*"
        Select Case AEEmulatorType.SelectedIndex
            Case 0
                Open.FilterIndex = 0
            Case 1
                Open.FilterIndex = 3
            Case 2
                Open.FilterIndex = 1
            Case 3
                Open.FilterIndex = 1
            Case 4
                Open.FilterIndex = 2
            Case 5
                Open.FilterIndex = 0
            Case Else
                Open.FilterIndex = 4
        End Select
        Open.ShowDialog()
        If Open.FileName <> "" Then
            AEFile.Text = Open.FileName
        End If
    End Sub

    Private Sub AEName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AEName.TextChanged
        If AEName.Text <> "" And AEFile.Text <> "" Then
            cmdNext.Enabled = True
        Else
            cmdNext.Enabled = False
        End If
    End Sub

    Private Sub AEFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AEFile.TextChanged
        If AEName.Text <> "" And AEFile.Text <> "" Then
            cmdNext.Enabled = True
        Else
            cmdNext.Enabled = False
        End If
    End Sub
End Class