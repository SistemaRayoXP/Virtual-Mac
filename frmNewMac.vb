Public Class frmNewMac

    Public HostRAM As Long = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024
    Public NameWithoutPath As String

    Public Sub SetFinalData()
        EndMacName.Text = NameWithoutPath
        EndRAM.Text = RAMBox.Text & " MB"
        EndDiskPath.Text = DiskSize.Value & " MB"
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Tools\qemu-img.exe") = False Then
            DiskExisting.Checked = True
            DiskNew.Enabled = False
        End If

        If Welcome.Visible = True And Welcome.Enabled = True Then
            CreateFrame.Enabled = True
            CreateFrame.BringToFront()
            MovePage(Welcome, Wizard)
            CreateNoWizard.Focus()
            cmdBack.Enabled = True
            Exit Sub
        End If

        If Wizard.Visible = True And Wizard.Enabled = True Then
            If CreateFrame.Visible = True And CreateFrame.Enabled = True Then
                If CreateNormal.Checked = True Or CreateNoWizard.Checked = True Then
                    MovePage(CreateFrame, MacNameFrame)
                    MacName.Focus()
                    MacName.SelectAll()
                Else
                    MovePage(CreateFrame, AddFromFileFrame)
                    cmdNext.Enabled = False
                End If
                Exit Sub
            End If

            If AddFromFileFrame.Visible = True And AddFromFileFrame.Enabled = True Then
                cmdNext.Text = "Finish"
                cmdNext.Focus()
                MovePage(Wizard, EndWizard)
                Exit Sub
            End If

            If MacNameFrame.Visible = True And MacNameFrame.Enabled = True Then
                If System.IO.Path.GetFileNameWithoutExtension(MacName.Text) = MacName.Text Then
                    NameWithoutPath = MacName.Text
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder & "\" & NameWithoutPath) = True Then
                    MsgBox("This Mac already exists in ''My Macs\" & NameWithoutPath & "''. Please use a different name, or save the Mac to another location.", MsgBoxStyle.Exclamation)
                    Exit Sub
                Else
                    MovePage(MacNameFrame, HwPresetsFrame)
                    AutoSelectOS()
                End If
                Exit Sub
            End If

            If HwPresetsFrame.Visible = True And HwPresetsFrame.Enabled = True Then
                If CreateNoWizard.Checked = True Then
                    SetFinalData()
                    cmdNext.Text = "Finish"
                    MovePage(Wizard, EndWizard)
                    cmdNext.Focus()
                Else
                    MovePage(HwPresetsFrame, RAMFrame)
                End If
                Exit Sub
            End If

            If RAMFrame.Visible = True And RAMFrame.Enabled = True Then
                MovePage(RAMFrame, DiskFrame)
                GoTo EndOfInstruction
            End If

            If DiskFrame.Visible = True And DiskFrame.Enabled = True Then
                SetFinalData()
                cmdNext.Text = "Finish"
                MovePage(Wizard, EndWizard)
                cmdNext.Focus()
                Exit Sub
            End If
        End If

        If EndWizard.Visible = True And EndWizard.Enabled = True Then
            CreateMac()
            Me.Close()
            Exit Sub
        End If

EndOfInstruction:

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        If Wizard.Visible = True And Wizard.Enabled = True Then
            If CreateFrame.Visible = True And CreateFrame.Enabled = True Then
                cmdBack.Enabled = False
                MovePage(Wizard, Welcome)
                GoTo EndOfInstruction
            End If

            If AddFromFileFrame.Visible = True And AddFromFileFrame.Enabled = True Then
                MovePage(AddFromFileFrame, CreateFrame)
                GoTo EndOfInstruction
            End If

            If MacNameFrame.Visible = True And MacNameFrame.Enabled = True Then
                MovePage(MacNameFrame, CreateFrame)
                GoTo EndOfInstruction
            End If

            If HwPresetsFrame.Visible = True And HwPresetsFrame.Enabled = True Then
                MovePage(HwPresetsFrame, MacNameFrame)
                MacName.Focus()
                MacName.SelectAll()
                GoTo EndOfInstruction
            End If

            If RAMFrame.Visible = True And RAMFrame.Enabled = True Then
                MovePage(RAMFrame, HwPresetsFrame)
                GoTo EndOfInstruction
            End If

            If DiskFrame.Visible = True And DiskFrame.Enabled = True Then
                MovePage(DiskFrame, RAMFrame)
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
        Dim Emulator As String = ""

        If CreateAddExist.Checked = True Then  '//Checking "Add from file" to be checked, so we create from file
            Select Case AddEmulator.SelectedItem.ToString
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
            ConfigFileHandler.CreateFromFile(AddFile.Text, Emulator, AddName.Text)
        ElseIf CreateNormal.Checked = True Or CreateNoWizard.Checked = True Then    '//If any of the Normal is checked, create from file
            Dim UseDisk As String = ""
            If DiskExisting.Checked = True Then
                UseDisk = "Exist"
            ElseIf DiskNone.Checked = True Then
                UseDisk = "None"
            ElseIf DiskNew.Checked = True Then
                UseDisk = "New"
            End If
            Select Case HwEmulator.SelectedIndex
                Case 0
                    Emulator = "vMac"
                Case 1
                    Emulator = "BII"
                Case 2
                    Emulator = "SheepShaver"
                Case 3
                    Emulator = "PearPC"
                Case 4
                    Emulator = "QEMUBatch"
            End Select
            ConfigFileHandler.Create(NameWithoutPath, MacName.Text, Emulator, RAMBox.Text, UseDisk, DiskSize.Value, DiskPath.Text)
        End If
    End Sub

    Public Sub DisableAllPages()
        EndWizard.Enabled = False
        DiskFrame.Enabled = False
        RAMFrame.Enabled = False
        HwPresetsFrame.Enabled = False
        AddFromFileFrame.Enabled = False
        MacNameFrame.Enabled = False
        CreateFrame.Enabled = False
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
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 8
                DiskSize.Value = 100
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", "8")
                HwRAM.Text = 8 & " MB"
                HwDisk.Text = 128 & " MB"
                HwCPU.Text = "Motorola 68000"
            Case "Mac7"
                If HostRAM < 40 Then
                    MsgBox("You have lower memory than the required to run System Software 7. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 16
                DiskSize.Value = 250
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 16)
                HwRAM.Text = 16 & " MB"
                HwDisk.Text = 250 & " MB"
                HwCPU.Text = "Motorola 68040"
            Case "Mac7Pro"
                If HostRAM < 64 Then
                    MsgBox("You have lower memory than the required to run MacOS 7. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 24
                DiskSize.Value = 250
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 24)
                HwRAM.Text = 24 & " MB"
                HwDisk.Text = 250 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Mac8"
                If HostRAM < 128 Then
                    MsgBox("You have lower memory than the required to run MacOS 8. Install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 64
                DiskSize.Value = 500
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 64)
                HwRAM.Text = 64 & " MB"
                HwDisk.Text = 500 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Mac9"
                If HostRAM < 256 Then
                    MsgBox("You have lower memory than the required to run MacOS 9. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 256
                DiskSize.Value = 1024
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 256)
                HwRAM.Text = 256 & " MB"
                HwDisk.Text = 1024 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Mac10"
                If HostRAM < 384 Then
                    MsgBox("You have lower memory than the required to run Mac OS X. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 384
                DiskSize.Value = 3072
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 384)
                HwRAM.Text = 384 & " MB"
                HwDisk.Text = 3072 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Debian"
                If HostRAM < 400 Then
                    MsgBox("You have lower memory than the required to run Debian. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 400
                DiskSize.Value = 4096
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 400)
                HwRAM.Text = 400 & " MB"
                HwDisk.Text = 4096 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Ubuntu"
                If HostRAM < 400 Then
                    MsgBox("You have lower memory than the required to run Ubuntu. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 400
                DiskSize.Value = 6144
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 400)
                HwRAM.Text = 400 & " MB"
                HwDisk.Text = 6144 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Linux"
                If HostRAM < 400 Then
                    MsgBox("You have lower memory than the required to run Linux. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 400
                DiskSize.Value = 4096
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 400)
                HwRAM.Text = 400 & " MB"
                HwDisk.Text = 4096 & " MB"
                HwCPU.Text = "PowerPC G3"
            Case "Other"
                If HostRAM < 256 Then
                    MsgBox("You have lower memory than the required to run Other. Set a lower value for memory, and install an earlier version of MacOS/System Software", MsgBoxStyle.Exclamation, "System Memory Low")
                    RAMBox.Text = RAMSlider.Maximum
                End If
                RAMBox.Text = 256
                DiskSize.Value = 4096
                RAMInfo.Text = Replace(RAMInfo.Text, "%m", 256)
                HwRAM.Text = 256 & " MB"
                HwDisk.Text = 4096 & " MB"
                HwCPU.Text = "PowerPC G3"
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
            HwEmulator.SelectedIndex = 0
            HwOSList.SelectedIndex = 0
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 6")
        If OsFound <> 0 Then
            OS = "Mac6"
            HwEmulator.SelectedIndex = 0
            HwOSList.SelectedIndex = 0
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 7")
        If OsFound <> 0 Then
            OS = "Mac7"
            HwEmulator.SelectedIndex = 0
            HwOSList.SelectedIndex = 1
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 7.")
        If OsFound <> 0 Then
            OS = "Mac75"
            HwEmulator.SelectedIndex = 1
            HwOSList.SelectedIndex = 1
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 8")
        If OsFound <> 0 Then
            OS = "Mac8"
            HwEmulator.SelectedIndex = 2
            HwOSList.SelectedIndex = 1
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 9")
        If OsFound <> 0 Then
            OS = "Mac9"
            HwEmulator.SelectedIndex = 2
            HwOSList.SelectedIndex = 2
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " Classic")
        If OsFound <> 0 Then
            OS = "Mac9"
            HwEmulator.SelectedIndex = 4
            HwOSList.SelectedIndex = 0
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " 10")
        If OsFound <> 0 Then
            OS = "Mac10"
            HwEmulator.SelectedIndex = 3
            HwOSList.SelectedIndex = 0
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, " X")
        If OsFound <> 0 Then
            OS = "Mac10"
            HwEmulator.SelectedIndex = 4
            HwOSList.SelectedIndex = 1
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, "Debian")
        If OsFound <> 0 Then
            OS = "Debian"
            HwEmulator.SelectedIndex = 3
            HwOSList.SelectedIndex = 1
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, "Ubuntu")
        If OsFound <> 0 Then
            OS = "Ubuntu"
            HwEmulator.SelectedIndex = 4
            HwOSList.SelectedIndex = 3
            GoTo OSDetected
        End If

        OsFound = InStr(MacName.Text, "Linux")
        If OsFound <> 0 Then
            OS = "Linux"
            HwEmulator.SelectedIndex = 3
            HwOSList.SelectedIndex = 2
            GoTo OSDetected
        End If
        HwEmulator.SelectedIndex = 4
        HwOSList.SelectedIndex = 0

OSDetected:

        Return OS
    End Function

    Private Sub SaveMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MacNameBrowse.Click
        Save.Filter = "Virtual Mac Configuration File (*.mcf)|*.mcf|All files (*.*)|*.*"
        Save.ShowDialog()
        If Save.FileName <> "" Then
            MacName.Text = Save.FileName
        End If
    End Sub

    Private Sub frmNewMac_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RAMSlider.TickFrequency = HostRAM / 20
        RAMSlider.Maximum = HostRAM
        RAMCustomInvalidSize.Text = Replace(Replace(RAMCustomInvalidSize.Text, "%x", RAMSlider.Maximum), "%n", RAMSlider.Minimum)
        DisableAllPages()
        MovePage(Wizard, Welcome)
        AddEmulator.SelectedIndex = 0
        HwEmulator.SelectedIndex = 0
    End Sub

    Private Sub RAM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAMBox.TextChanged
        If RAMBox.Text = "" Then
            RAMSlider.Value = RAMSlider.Minimum
            cmdNext.Enabled = False
            RAMCustomInvalidSize.Visible = True
        Else
            If RAMBox.Text > RAMSlider.Maximum Then
                RAMSlider.Value = RAMSlider.Maximum
                cmdNext.Enabled = False
                RAMCustomInvalidSize.Visible = True
            Else
                If RAMBox.Text < RAMSlider.Minimum Then
                    RAMSlider.Value = RAMSlider.Minimum
                    cmdNext.Enabled = False
                    RAMCustomInvalidSize.Visible = True
                Else
                    RAMSlider.Value = RAMBox.Text
                    RAMCustomInvalidSize.Visible = False
                    cmdNext.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub RAMSlider_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles RAMSlider.Scroll
        RAMBox.Text = RAMSlider.Value
    End Sub

    Private Sub RAMDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAMDefault.CheckedChanged, RAMCustom.CheckedChanged
        If RAMCustom.Checked = True Then
            RAMControlsPanel.Enabled = True
            RAMControlsPanel.Visible = True
        Else
            RAMControlsPanel.Enabled = False
            RAMControlsPanel.Visible = False
        End If
    End Sub

    Private Sub OSList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HwOSList.SelectedIndexChanged
        Select Case HwOSList.SelectedItem.ToString
            Case "System Software 6"
                DataProgrammer("Mac6")
            Case "System Software 7"
                DataProgrammer("Mac7")
            Case "System Software 7 Pro"
                DataProgrammer("Mac7Pro")
            Case "Mac OS 8"
                DataProgrammer("Mac8")
            Case "Mac OS 9"
                DataProgrammer("Mac9")
            Case "Mac OS X"
                DataProgrammer("Mac10")
            Case "Debian"
                DataProgrammer("Debian")
            Case "Lubuntu"
                DataProgrammer("Ubuntu")
            Case "Other Linux"
                DataProgrammer("Linux")
            Case "Other"
                DataProgrammer("Other")
        End Select
    End Sub

    Private Sub HwEmulator_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HwEmulator.SelectedIndexChanged
        Select Case HwEmulator.SelectedIndex
            Case 0
                HwOSList.Items.Clear()
                HwOSList.Items.Add("System Software 6")
                HwOSList.Items.Add("System Software 7")
                HwOSList.Items.Add("Other")
                HwOSList.SelectedIndex = 0
            Case 1
                HwOSList.Items.Clear()
                HwOSList.Items.Add("System Software 7")
                HwOSList.Items.Add("System Software 7 Pro")
                HwOSList.Items.Add("Mac OS 8")
                HwOSList.Items.Add("Other")
                HwOSList.SelectedIndex = 0
            Case 2
                HwOSList.Items.Clear()
                HwOSList.Items.Add("System Software 7 Pro")
                HwOSList.Items.Add("Mac OS 8")
                HwOSList.Items.Add("Mac OS 9")
                HwOSList.Items.Add("Other")
                HwOSList.SelectedIndex = 0
            Case 3
                HwOSList.Items.Clear()
                HwOSList.Items.Add("Mac OS X")
                HwOSList.Items.Add("Debian")
                HwOSList.Items.Add("Lubuntu")
                HwOSList.Items.Add("Other Linux")
                HwOSList.Items.Add("Other")
                HwOSList.SelectedIndex = 0
            Case 4
                HwOSList.Items.Clear()
                HwOSList.Items.Add("Mac OS 9")
                HwOSList.Items.Add("Mac OS X")
                HwOSList.Items.Add("Debian")
                HwOSList.Items.Add("Lubuntu")
                HwOSList.Items.Add("Other Linux")
                HwOSList.Items.Add("Other")
                HwOSList.SelectedIndex = 0
        End Select
    End Sub

    Private Sub BrowseDiskLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskPathBrowse.Click
        If DiskNew.Checked = True Then
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

    Private Sub MacName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MacName.GotFocus
        MacName.SelectAll()
    End Sub

    Private Sub Disk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskNew.CheckedChanged, DiskExisting.CheckedChanged
        If DiskNew.Checked = True Then
            DiskSizeFrame.Visible = True
        Else
            DiskSizeFrame.Visible = False
        End If
        If DiskNone.Checked = True Then
            DiskPath.Enabled = False
            DiskPathBrowse.Enabled = False
        Else
            DiskPath.Enabled = True
            DiskPathBrowse.Enabled = True
        End If
    End Sub

    Private Sub AEBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFileBrowse.Click
        Open.Filter = "Batch files|*.bat|Basilisk/SheepShaver preferences file|*_prefs|PearPC Config Files|*.cfg|Virtual Mac Mini vMac Configuration File|*.mcf|All files|*.*"
        Select Case AddEmulator.SelectedIndex
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
            AddFile.Text = Open.FileName
        End If
    End Sub

    Private Sub AEName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddName.TextChanged
        If AddName.Text <> "" And AddFile.Text <> "" Then
            cmdNext.Enabled = True
        Else
            cmdNext.Enabled = False
        End If
    End Sub

    Private Sub AEFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFile.TextChanged
        If AddName.Text <> "" And AddFile.Text <> "" Then
            cmdNext.Enabled = True
        Else
            cmdNext.Enabled = False
        End If
    End Sub
End Class