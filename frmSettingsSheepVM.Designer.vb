<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSettingsSheepVM
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ControlInfo As System.Windows.Forms.ToolTip
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingsSheepVM))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Name", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Icon", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Memory")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Drives", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Network", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Display and multimedia", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mouse and keyboard")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Serial ports")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("External FileSystem")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Miscelaneous")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("JIT and debugging")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Manually Config File")
        Me.ControlInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.NetFakeAddressLabel = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.Browser = New System.Windows.Forms.OpenFileDialog()
        Me.DriveListContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextAddDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextAddCD = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextAddFloppy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextSetAsBoot = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextRemoveDrive = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupContainer = New System.Windows.Forms.Panel()
        Me.MacNameFrame = New System.Windows.Forms.GroupBox()
        Me.MacName = New System.Windows.Forms.TextBox()
        Me.MacNameLabel = New System.Windows.Forms.Label()
        Me.IconFrame = New System.Windows.Forms.GroupBox()
        Me.IconAdd = New System.Windows.Forms.Button()
        Me.IconList = New System.Windows.Forms.ListView()
        Me.IconInfo = New System.Windows.Forms.Label()
        Me.MemoryFrame = New System.Windows.Forms.GroupBox()
        Me.MemoryBoxMBLabel = New System.Windows.Forms.Label()
        Me.MemoryBoxLabel = New System.Windows.Forms.Label()
        Me.MemoryBox = New System.Windows.Forms.TextBox()
        Me.MemoryTracker = New System.Windows.Forms.TrackBar()
        Me.DriveFrame = New System.Windows.Forms.GroupBox()
        Me.DrivePollMedia = New System.Windows.Forms.CheckBox()
        Me.DriveBootCD = New System.Windows.Forms.RadioButton()
        Me.DriveBootDisk = New System.Windows.Forms.RadioButton()
        Me.DriveSetBootDrive = New System.Windows.Forms.Button()
        Me.DriveRemove = New System.Windows.Forms.Button()
        Me.DriveAddFloppy = New System.Windows.Forms.Button()
        Me.DriveAddCD = New System.Windows.Forms.Button()
        Me.DriveAddDisk = New System.Windows.Forms.Button()
        Me.DriveList = New System.Windows.Forms.ListView()
        Me.DriveLCPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveLCType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveLCBootMark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NetworkFrame = New System.Windows.Forms.GroupBox()
        Me.NetEnable = New System.Windows.Forms.CheckBox()
        Me.NetContainer = New System.Windows.Forms.Panel()
        Me.NetMulticastModeLabel = New System.Windows.Forms.Label()
        Me.NetMulticastMode = New System.Windows.Forms.TextBox()
        Me.NetTypeLabel = New System.Windows.Forms.Label()
        Me.NetFakeAddress = New System.Windows.Forms.TextBox()
        Me.NetPermPhysicalAddress = New System.Windows.Forms.CheckBox()
        Me.NetRouterEnabled = New System.Windows.Forms.CheckBox()
        Me.NetEnableUDP = New System.Windows.Forms.CheckBox()
        Me.NetType = New System.Windows.Forms.ComboBox()
        Me.NetUPDPortLabel = New System.Windows.Forms.Label()
        Me.NetRouterConfig = New System.Windows.Forms.Panel()
        Me.NetServerPortsLabel = New System.Windows.Forms.Label()
        Me.NetFTPPortsLabel = New System.Windows.Forms.Label()
        Me.NetServerPorts = New System.Windows.Forms.TextBox()
        Me.NetFTPPorts = New System.Windows.Forms.TextBox()
        Me.NetUPDPort = New System.Windows.Forms.TextBox()
        Me.MediaFrame = New System.Windows.Forms.GroupBox()
        Me.MediaEnableSound = New System.Windows.Forms.CheckBox()
        Me.MediaEnableCD = New System.Windows.Forms.CheckBox()
        Me.MediaEnableQuickDraw = New System.Windows.Forms.CheckBox()
        Me.MediaModeLabel = New System.Windows.Forms.Label()
        Me.MediaMode = New System.Windows.Forms.ComboBox()
        Me.MediaRefreshLabel = New System.Windows.Forms.Label()
        Me.MediaRefresh = New System.Windows.Forms.ComboBox()
        Me.MediaResLabel = New System.Windows.Forms.Label()
        Me.MediaResCust = New System.Windows.Forms.CheckBox()
        Me.MediaResY = New System.Windows.Forms.ComboBox()
        Me.MediaResX = New System.Windows.Forms.ComboBox()
        Me.InputFrame = New System.Windows.Forms.GroupBox()
        Me.InputMouseWheelLines = New System.Windows.Forms.NumericUpDown()
        Me.InputMouseWheelMode = New System.Windows.Forms.ComboBox()
        Me.InputMouseWheelModeLabel = New System.Windows.Forms.Label()
        Me.InputKeyCodesPathPanel = New System.Windows.Forms.Panel()
        Me.InputKeyCodesPathLabel = New System.Windows.Forms.Label()
        Me.InputKeyCodesPath = New System.Windows.Forms.TextBox()
        Me.InputKeycodesEnable = New System.Windows.Forms.CheckBox()
        Me.InputEmuKbdType = New System.Windows.Forms.ComboBox()
        Me.InputEmuKbdTypeLabel = New System.Windows.Forms.Label()
        Me.SerialFrame = New System.Windows.Forms.GroupBox()
        Me.SerialBFilePath = New System.Windows.Forms.TextBox()
        Me.SerialBFileBrowse = New System.Windows.Forms.Button()
        Me.SerialAFilePath = New System.Windows.Forms.TextBox()
        Me.SerialAFileBrowse = New System.Windows.Forms.Button()
        Me.SerialBLabel = New System.Windows.Forms.Label()
        Me.SerialALabel = New System.Windows.Forms.Label()
        Me.SerialB = New System.Windows.Forms.ComboBox()
        Me.SerialA = New System.Windows.Forms.ComboBox()
        Me.ExtFSFrame = New System.Windows.Forms.GroupBox()
        Me.ExtFSDrivesLabel = New System.Windows.Forms.Label()
        Me.ExtFSDrives = New System.Windows.Forms.CheckedListBox()
        Me.ExtFSEnable = New System.Windows.Forms.CheckBox()
        Me.MiscFrame = New System.Windows.Forms.GroupBox()
        Me.MiscIgnoreIllegal = New System.Windows.Forms.CheckBox()
        Me.MiscClipConv = New System.Windows.Forms.CheckBox()
        Me.MiscIdle = New System.Windows.Forms.CheckBox()
        Me.MiscIgnoreSegv = New System.Windows.Forms.CheckBox()
        Me.MiscEnableGUI = New System.Windows.Forms.CheckBox()
        Me.MiscROM = New System.Windows.Forms.TextBox()
        Me.MiscROMBrowse = New System.Windows.Forms.Button()
        Me.MiscROMLabel = New System.Windows.Forms.Label()
        Me.JITFrame = New System.Windows.Forms.GroupBox()
        Me.JITEnable = New System.Windows.Forms.CheckBox()
        Me.JIT68kEnable = New System.Windows.Forms.CheckBox()
        Me.JITDebugExtFS = New System.Windows.Forms.CheckBox()
        Me.EMCFrame = New System.Windows.Forms.GroupBox()
        Me.EMCEditor = New System.Windows.Forms.ListView()
        Me.EMCKeywordValueColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OptionList = New System.Windows.Forms.ListView()
        Me.Options = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DriveListContext.SuspendLayout()
        Me.GroupContainer.SuspendLayout()
        Me.MacNameFrame.SuspendLayout()
        Me.IconFrame.SuspendLayout()
        Me.MemoryFrame.SuspendLayout()
        CType(Me.MemoryTracker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DriveFrame.SuspendLayout()
        Me.NetworkFrame.SuspendLayout()
        Me.NetContainer.SuspendLayout()
        Me.NetRouterConfig.SuspendLayout()
        Me.MediaFrame.SuspendLayout()
        Me.InputFrame.SuspendLayout()
        CType(Me.InputMouseWheelLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputKeyCodesPathPanel.SuspendLayout()
        Me.SerialFrame.SuspendLayout()
        Me.ExtFSFrame.SuspendLayout()
        Me.MiscFrame.SuspendLayout()
        Me.JITFrame.SuspendLayout()
        Me.EMCFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'NetFakeAddressLabel
        '
        Me.NetFakeAddressLabel.AutoSize = True
        Me.NetFakeAddressLabel.Location = New System.Drawing.Point(7, 193)
        Me.NetFakeAddressLabel.Name = "NetFakeAddressLabel"
        Me.NetFakeAddressLabel.Size = New System.Drawing.Size(90, 13)
        Me.NetFakeAddressLabel.TabIndex = 7
        Me.NetFakeAddressLabel.Text = "Physical address:"
        Me.ControlInfo.SetToolTip(Me.NetFakeAddressLabel, "This is an optional, physical adapter address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to provide for your Mac. If set, t" & _
        "his value will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "override the default physical ethernet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "address of this Mac.")
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(665, 367)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 22)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(585, 367)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 22)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Icons
        '
        Me.Icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.Icons.ImageSize = New System.Drawing.Size(48, 48)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'Browser
        '
        Me.Browser.DefaultExt = "*.png"
        Me.Browser.Filter = """Image files (*.jpg;*.jpeg;*.png;*.bmp;*.ico)|*.jpg;*.jpeg;*.png;*.bmp;*.ico|All " & _
    "files|*.*"""
        Me.Browser.RestoreDirectory = True
        '
        'DriveListContext
        '
        Me.DriveListContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextAddDisk, Me.ContextAddCD, Me.ContextAddFloppy, Me.ContextSetAsBoot, Me.ContextRemoveDrive})
        Me.DriveListContext.Name = "DriveListContext"
        Me.DriveListContext.Size = New System.Drawing.Size(240, 114)
        '
        'ContextAddDisk
        '
        Me.ContextAddDisk.Name = "ContextAddDisk"
        Me.ContextAddDisk.Size = New System.Drawing.Size(239, 22)
        Me.ContextAddDisk.Text = "Add disk image"
        '
        'ContextAddCD
        '
        Me.ContextAddCD.Name = "ContextAddCD"
        Me.ContextAddCD.Size = New System.Drawing.Size(239, 22)
        Me.ContextAddCD.Text = "Add CD image"
        '
        'ContextAddFloppy
        '
        Me.ContextAddFloppy.Name = "ContextAddFloppy"
        Me.ContextAddFloppy.Size = New System.Drawing.Size(239, 22)
        Me.ContextAddFloppy.Text = "Add floppy image"
        '
        'ContextSetAsBoot
        '
        Me.ContextSetAsBoot.Enabled = False
        Me.ContextSetAsBoot.Name = "ContextSetAsBoot"
        Me.ContextSetAsBoot.Size = New System.Drawing.Size(239, 22)
        Me.ContextSetAsBoot.Text = "Set as boot drive"
        '
        'ContextRemoveDrive
        '
        Me.ContextRemoveDrive.Enabled = False
        Me.ContextRemoveDrive.Name = "ContextRemoveDrive"
        Me.ContextRemoveDrive.Size = New System.Drawing.Size(239, 22)
        Me.ContextRemoveDrive.Text = "Remove selected drive from list"
        '
        'DriveIcons
        '
        Me.DriveIcons.ImageStream = CType(resources.GetObject("DriveIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DriveIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.DriveIcons.Images.SetKeyName(0, "Floppy")
        Me.DriveIcons.Images.SetKeyName(1, "Disc")
        Me.DriveIcons.Images.SetKeyName(2, "Drive")
        '
        'GroupContainer
        '
        Me.GroupContainer.Controls.Add(Me.MacNameFrame)
        Me.GroupContainer.Controls.Add(Me.IconFrame)
        Me.GroupContainer.Controls.Add(Me.MemoryFrame)
        Me.GroupContainer.Controls.Add(Me.DriveFrame)
        Me.GroupContainer.Controls.Add(Me.NetworkFrame)
        Me.GroupContainer.Controls.Add(Me.MediaFrame)
        Me.GroupContainer.Controls.Add(Me.InputFrame)
        Me.GroupContainer.Controls.Add(Me.SerialFrame)
        Me.GroupContainer.Controls.Add(Me.ExtFSFrame)
        Me.GroupContainer.Controls.Add(Me.MiscFrame)
        Me.GroupContainer.Controls.Add(Me.JITFrame)
        Me.GroupContainer.Controls.Add(Me.EMCFrame)
        Me.GroupContainer.Location = New System.Drawing.Point(371, 2)
        Me.GroupContainer.Name = "GroupContainer"
        Me.GroupContainer.Size = New System.Drawing.Size(373, 290)
        Me.GroupContainer.TabIndex = 27
        '
        'MacNameFrame
        '
        Me.MacNameFrame.Controls.Add(Me.MacName)
        Me.MacNameFrame.Controls.Add(Me.MacNameLabel)
        Me.MacNameFrame.Location = New System.Drawing.Point(0, 0)
        Me.MacNameFrame.Name = "MacNameFrame"
        Me.MacNameFrame.Size = New System.Drawing.Size(367, 276)
        Me.MacNameFrame.TabIndex = 4
        Me.MacNameFrame.TabStop = False
        Me.MacNameFrame.Text = "Name"
        '
        'MacName
        '
        Me.MacName.Location = New System.Drawing.Point(10, 70)
        Me.MacName.Name = "MacName"
        Me.MacName.Size = New System.Drawing.Size(347, 21)
        Me.MacName.TabIndex = 1
        '
        'MacNameLabel
        '
        Me.MacNameLabel.Location = New System.Drawing.Point(10, 33)
        Me.MacNameLabel.Name = "MacNameLabel"
        Me.MacNameLabel.Size = New System.Drawing.Size(347, 30)
        Me.MacNameLabel.TabIndex = 0
        Me.MacNameLabel.Text = "The most important thing for any computer, the name. The name can be anything, li" & _
    "ke Performa 9000, Mac OS 7, iMac G3, or simply Mac"
        '
        'IconFrame
        '
        Me.IconFrame.Controls.Add(Me.IconAdd)
        Me.IconFrame.Controls.Add(Me.IconList)
        Me.IconFrame.Controls.Add(Me.IconInfo)
        Me.IconFrame.Location = New System.Drawing.Point(0, 0)
        Me.IconFrame.Name = "IconFrame"
        Me.IconFrame.Size = New System.Drawing.Size(367, 276)
        Me.IconFrame.TabIndex = 3
        Me.IconFrame.TabStop = False
        Me.IconFrame.Text = "Icon"
        '
        'IconAdd
        '
        Me.IconAdd.Location = New System.Drawing.Point(10, 170)
        Me.IconAdd.Name = "IconAdd"
        Me.IconAdd.Size = New System.Drawing.Size(42, 23)
        Me.IconAdd.TabIndex = 2
        Me.IconAdd.Text = "Add"
        Me.IconAdd.UseVisualStyleBackColor = True
        '
        'IconList
        '
        Me.IconList.Location = New System.Drawing.Point(10, 90)
        Me.IconList.Name = "IconList"
        Me.IconList.Size = New System.Drawing.Size(346, 74)
        Me.IconList.TabIndex = 1
        Me.IconList.UseCompatibleStateImageBehavior = False
        '
        'IconInfo
        '
        Me.IconInfo.AutoSize = True
        Me.IconInfo.Location = New System.Drawing.Point(10, 33)
        Me.IconInfo.Name = "IconInfo"
        Me.IconInfo.Size = New System.Drawing.Size(350, 52)
        Me.IconInfo.TabIndex = 0
        Me.IconInfo.Text = resources.GetString("IconInfo.Text")
        '
        'MemoryFrame
        '
        Me.MemoryFrame.Controls.Add(Me.MemoryBoxMBLabel)
        Me.MemoryFrame.Controls.Add(Me.MemoryBoxLabel)
        Me.MemoryFrame.Controls.Add(Me.MemoryBox)
        Me.MemoryFrame.Controls.Add(Me.MemoryTracker)
        Me.MemoryFrame.Location = New System.Drawing.Point(0, 0)
        Me.MemoryFrame.Name = "MemoryFrame"
        Me.MemoryFrame.Size = New System.Drawing.Size(367, 279)
        Me.MemoryFrame.TabIndex = 8
        Me.MemoryFrame.TabStop = False
        Me.MemoryFrame.Text = "Memory"
        '
        'MemoryBoxMBLabel
        '
        Me.MemoryBoxMBLabel.AutoSize = True
        Me.MemoryBoxMBLabel.Location = New System.Drawing.Point(336, 26)
        Me.MemoryBoxMBLabel.Name = "MemoryBoxMBLabel"
        Me.MemoryBoxMBLabel.Size = New System.Drawing.Size(23, 13)
        Me.MemoryBoxMBLabel.TabIndex = 3
        Me.MemoryBoxMBLabel.Text = "MiB"
        '
        'MemoryBoxLabel
        '
        Me.MemoryBoxLabel.AutoSize = True
        Me.MemoryBoxLabel.Location = New System.Drawing.Point(6, 26)
        Me.MemoryBoxLabel.Name = "MemoryBoxLabel"
        Me.MemoryBoxLabel.Size = New System.Drawing.Size(207, 13)
        Me.MemoryBoxLabel.TabIndex = 2
        Me.MemoryBoxLabel.Text = "Select how much RAM to give to this Mac:"
        '
        'MemoryBox
        '
        Me.MemoryBox.Location = New System.Drawing.Point(286, 23)
        Me.MemoryBox.Name = "MemoryBox"
        Me.MemoryBox.Size = New System.Drawing.Size(46, 21)
        Me.MemoryBox.TabIndex = 1
        '
        'MemoryTracker
        '
        Me.MemoryTracker.Location = New System.Drawing.Point(6, 52)
        Me.MemoryTracker.Maximum = 1024
        Me.MemoryTracker.Name = "MemoryTracker"
        Me.MemoryTracker.Size = New System.Drawing.Size(355, 45)
        Me.MemoryTracker.TabIndex = 0
        Me.MemoryTracker.TickFrequency = 41
        '
        'DriveFrame
        '
        Me.DriveFrame.Controls.Add(Me.DrivePollMedia)
        Me.DriveFrame.Controls.Add(Me.DriveBootCD)
        Me.DriveFrame.Controls.Add(Me.DriveBootDisk)
        Me.DriveFrame.Controls.Add(Me.DriveSetBootDrive)
        Me.DriveFrame.Controls.Add(Me.DriveRemove)
        Me.DriveFrame.Controls.Add(Me.DriveAddFloppy)
        Me.DriveFrame.Controls.Add(Me.DriveAddCD)
        Me.DriveFrame.Controls.Add(Me.DriveAddDisk)
        Me.DriveFrame.Controls.Add(Me.DriveList)
        Me.DriveFrame.Location = New System.Drawing.Point(0, 0)
        Me.DriveFrame.Name = "DriveFrame"
        Me.DriveFrame.Size = New System.Drawing.Size(367, 279)
        Me.DriveFrame.TabIndex = 8
        Me.DriveFrame.TabStop = False
        Me.DriveFrame.Text = "Drives"
        '
        'DrivePollMedia
        '
        Me.DrivePollMedia.AutoSize = True
        Me.DrivePollMedia.Location = New System.Drawing.Point(149, 244)
        Me.DrivePollMedia.Name = "DrivePollMedia"
        Me.DrivePollMedia.Size = New System.Drawing.Size(126, 17)
        Me.DrivePollMedia.TabIndex = 10
        Me.DrivePollMedia.Text = "Check for new media"
        Me.DrivePollMedia.UseVisualStyleBackColor = True
        '
        'DriveBootCD
        '
        Me.DriveBootCD.AutoSize = True
        Me.DriveBootCD.Location = New System.Drawing.Point(10, 256)
        Me.DriveBootCD.Name = "DriveBootCD"
        Me.DriveBootCD.Size = New System.Drawing.Size(89, 17)
        Me.DriveBootCD.TabIndex = 9
        Me.DriveBootCD.TabStop = True
        Me.DriveBootCD.Text = "Boot from CD"
        Me.DriveBootCD.UseVisualStyleBackColor = True
        '
        'DriveBootDisk
        '
        Me.DriveBootDisk.AutoSize = True
        Me.DriveBootDisk.Location = New System.Drawing.Point(10, 233)
        Me.DriveBootDisk.Name = "DriveBootDisk"
        Me.DriveBootDisk.Size = New System.Drawing.Size(93, 17)
        Me.DriveBootDisk.TabIndex = 8
        Me.DriveBootDisk.TabStop = True
        Me.DriveBootDisk.Text = "Boot from disk"
        Me.DriveBootDisk.UseVisualStyleBackColor = True
        '
        'DriveSetBootDrive
        '
        Me.DriveSetBootDrive.Location = New System.Drawing.Point(219, 204)
        Me.DriveSetBootDrive.Name = "DriveSetBootDrive"
        Me.DriveSetBootDrive.Size = New System.Drawing.Size(70, 23)
        Me.DriveSetBootDrive.TabIndex = 7
        Me.DriveSetBootDrive.Text = "Set Boot"
        Me.DriveSetBootDrive.UseVisualStyleBackColor = True
        '
        'DriveRemove
        '
        Me.DriveRemove.Location = New System.Drawing.Point(289, 204)
        Me.DriveRemove.Name = "DriveRemove"
        Me.DriveRemove.Size = New System.Drawing.Size(70, 23)
        Me.DriveRemove.TabIndex = 6
        Me.DriveRemove.Text = "Remove"
        Me.DriveRemove.UseVisualStyleBackColor = True
        '
        'DriveAddFloppy
        '
        Me.DriveAddFloppy.Location = New System.Drawing.Point(9, 204)
        Me.DriveAddFloppy.Name = "DriveAddFloppy"
        Me.DriveAddFloppy.Size = New System.Drawing.Size(70, 23)
        Me.DriveAddFloppy.TabIndex = 5
        Me.DriveAddFloppy.Text = "Add Floppy"
        Me.DriveAddFloppy.UseVisualStyleBackColor = True
        '
        'DriveAddCD
        '
        Me.DriveAddCD.Location = New System.Drawing.Point(79, 204)
        Me.DriveAddCD.Name = "DriveAddCD"
        Me.DriveAddCD.Size = New System.Drawing.Size(70, 23)
        Me.DriveAddCD.TabIndex = 4
        Me.DriveAddCD.Text = "Add CD"
        Me.DriveAddCD.UseVisualStyleBackColor = True
        '
        'DriveAddDisk
        '
        Me.DriveAddDisk.Location = New System.Drawing.Point(149, 204)
        Me.DriveAddDisk.Name = "DriveAddDisk"
        Me.DriveAddDisk.Size = New System.Drawing.Size(70, 23)
        Me.DriveAddDisk.TabIndex = 3
        Me.DriveAddDisk.Text = "Add Disk"
        Me.DriveAddDisk.UseVisualStyleBackColor = True
        '
        'DriveList
        '
        Me.DriveList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DriveLCPath, Me.DriveLCType, Me.DriveLCBootMark})
        Me.DriveList.ContextMenuStrip = Me.DriveListContext
        Me.DriveList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DriveList.Location = New System.Drawing.Point(10, 20)
        Me.DriveList.Name = "DriveList"
        Me.DriveList.Size = New System.Drawing.Size(349, 178)
        Me.DriveList.SmallImageList = Me.DriveIcons
        Me.DriveList.TabIndex = 2
        Me.DriveList.UseCompatibleStateImageBehavior = False
        Me.DriveList.View = System.Windows.Forms.View.Details
        '
        'DriveLCPath
        '
        Me.DriveLCPath.Text = "Path"
        Me.DriveLCPath.Width = 263
        '
        'DriveLCType
        '
        Me.DriveLCType.Text = "Type"
        Me.DriveLCType.Width = 46
        '
        'DriveLCBootMark
        '
        Me.DriveLCBootMark.Text = "Boot"
        Me.DriveLCBootMark.Width = 34
        '
        'NetworkFrame
        '
        Me.NetworkFrame.Controls.Add(Me.NetEnable)
        Me.NetworkFrame.Controls.Add(Me.NetContainer)
        Me.NetworkFrame.Location = New System.Drawing.Point(0, 0)
        Me.NetworkFrame.Name = "NetworkFrame"
        Me.NetworkFrame.Size = New System.Drawing.Size(367, 279)
        Me.NetworkFrame.TabIndex = 8
        Me.NetworkFrame.TabStop = False
        Me.NetworkFrame.Text = "Network"
        '
        'NetEnable
        '
        Me.NetEnable.AutoSize = True
        Me.NetEnable.Checked = True
        Me.NetEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NetEnable.Location = New System.Drawing.Point(12, 13)
        Me.NetEnable.Name = "NetEnable"
        Me.NetEnable.Size = New System.Drawing.Size(149, 17)
        Me.NetEnable.TabIndex = 28
        Me.NetEnable.Text = "Enable network hardware"
        Me.NetEnable.UseVisualStyleBackColor = True
        '
        'NetContainer
        '
        Me.NetContainer.Controls.Add(Me.NetMulticastModeLabel)
        Me.NetContainer.Controls.Add(Me.NetMulticastMode)
        Me.NetContainer.Controls.Add(Me.NetFakeAddressLabel)
        Me.NetContainer.Controls.Add(Me.NetTypeLabel)
        Me.NetContainer.Controls.Add(Me.NetFakeAddress)
        Me.NetContainer.Controls.Add(Me.NetPermPhysicalAddress)
        Me.NetContainer.Controls.Add(Me.NetRouterEnabled)
        Me.NetContainer.Controls.Add(Me.NetEnableUDP)
        Me.NetContainer.Controls.Add(Me.NetType)
        Me.NetContainer.Controls.Add(Me.NetUPDPortLabel)
        Me.NetContainer.Controls.Add(Me.NetRouterConfig)
        Me.NetContainer.Controls.Add(Me.NetUPDPort)
        Me.NetContainer.Location = New System.Drawing.Point(2, 35)
        Me.NetContainer.Name = "NetContainer"
        Me.NetContainer.Size = New System.Drawing.Size(356, 241)
        Me.NetContainer.TabIndex = 29
        '
        'NetMulticastModeLabel
        '
        Me.NetMulticastModeLabel.AutoSize = True
        Me.NetMulticastModeLabel.Location = New System.Drawing.Point(7, 220)
        Me.NetMulticastModeLabel.Name = "NetMulticastModeLabel"
        Me.NetMulticastModeLabel.Size = New System.Drawing.Size(82, 13)
        Me.NetMulticastModeLabel.TabIndex = 8
        Me.NetMulticastModeLabel.Text = "Multicast mode:"
        '
        'NetMulticastMode
        '
        Me.NetMulticastMode.Location = New System.Drawing.Point(116, 217)
        Me.NetMulticastMode.Name = "NetMulticastMode"
        Me.NetMulticastMode.Size = New System.Drawing.Size(133, 21)
        Me.NetMulticastMode.TabIndex = 9
        '
        'NetTypeLabel
        '
        Me.NetTypeLabel.AutoSize = True
        Me.NetTypeLabel.Location = New System.Drawing.Point(7, 3)
        Me.NetTypeLabel.Name = "NetTypeLabel"
        Me.NetTypeLabel.Size = New System.Drawing.Size(78, 13)
        Me.NetTypeLabel.TabIndex = 1
        Me.NetTypeLabel.Text = "Network Type:"
        '
        'NetFakeAddress
        '
        Me.NetFakeAddress.ForeColor = System.Drawing.Color.Gray
        Me.NetFakeAddress.Location = New System.Drawing.Point(116, 190)
        Me.NetFakeAddress.Name = "NetFakeAddress"
        Me.NetFakeAddress.Size = New System.Drawing.Size(133, 21)
        Me.NetFakeAddress.TabIndex = 6
        '
        'NetPermPhysicalAddress
        '
        Me.NetPermPhysicalAddress.AutoSize = True
        Me.NetPermPhysicalAddress.Location = New System.Drawing.Point(10, 25)
        Me.NetPermPhysicalAddress.Name = "NetPermPhysicalAddress"
        Me.NetPermPhysicalAddress.Size = New System.Drawing.Size(211, 17)
        Me.NetPermPhysicalAddress.TabIndex = 4
        Me.NetPermPhysicalAddress.Text = "Make permanent the ethernet address"
        Me.NetPermPhysicalAddress.UseVisualStyleBackColor = True
        '
        'NetRouterEnabled
        '
        Me.NetRouterEnabled.AutoSize = True
        Me.NetRouterEnabled.Location = New System.Drawing.Point(10, 50)
        Me.NetRouterEnabled.Name = "NetRouterEnabled"
        Me.NetRouterEnabled.Size = New System.Drawing.Size(177, 17)
        Me.NetRouterEnabled.TabIndex = 5
        Me.NetRouterEnabled.Text = "Enable router module of Basilisk"
        Me.NetRouterEnabled.UseVisualStyleBackColor = True
        '
        'NetEnableUDP
        '
        Me.NetEnableUDP.AutoSize = True
        Me.NetEnableUDP.Location = New System.Drawing.Point(10, 75)
        Me.NetEnableUDP.Name = "NetEnableUDP"
        Me.NetEnableUDP.Size = New System.Drawing.Size(116, 17)
        Me.NetEnableUDP.TabIndex = 0
        Me.NetEnableUDP.Text = "Enable UDP Tunnel"
        Me.NetEnableUDP.UseVisualStyleBackColor = True
        '
        'NetType
        '
        Me.NetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetType.FormattingEnabled = True
        Me.NetType.Items.AddRange(New Object() {"Slirp (Virtual Network)", "Router", "None"})
        Me.NetType.Location = New System.Drawing.Point(116, 0)
        Me.NetType.Name = "NetType"
        Me.NetType.Size = New System.Drawing.Size(133, 21)
        Me.NetType.TabIndex = 0
        '
        'NetUPDPortLabel
        '
        Me.NetUPDPortLabel.AutoSize = True
        Me.NetUPDPortLabel.Enabled = False
        Me.NetUPDPortLabel.Location = New System.Drawing.Point(8, 103)
        Me.NetUPDPortLabel.Name = "NetUPDPortLabel"
        Me.NetUPDPortLabel.Size = New System.Drawing.Size(54, 13)
        Me.NetUPDPortLabel.TabIndex = 3
        Me.NetUPDPortLabel.Text = "UDP Port:"
        '
        'NetRouterConfig
        '
        Me.NetRouterConfig.Controls.Add(Me.NetServerPortsLabel)
        Me.NetRouterConfig.Controls.Add(Me.NetFTPPortsLabel)
        Me.NetRouterConfig.Controls.Add(Me.NetServerPorts)
        Me.NetRouterConfig.Controls.Add(Me.NetFTPPorts)
        Me.NetRouterConfig.Location = New System.Drawing.Point(7, 130)
        Me.NetRouterConfig.Name = "NetRouterConfig"
        Me.NetRouterConfig.Size = New System.Drawing.Size(351, 60)
        Me.NetRouterConfig.TabIndex = 2
        '
        'NetServerPortsLabel
        '
        Me.NetServerPortsLabel.AutoSize = True
        Me.NetServerPortsLabel.Location = New System.Drawing.Point(0, 33)
        Me.NetServerPortsLabel.Name = "NetServerPortsLabel"
        Me.NetServerPortsLabel.Size = New System.Drawing.Size(71, 13)
        Me.NetServerPortsLabel.TabIndex = 5
        Me.NetServerPortsLabel.Text = "Server Ports:"
        '
        'NetFTPPortsLabel
        '
        Me.NetFTPPortsLabel.AutoSize = True
        Me.NetFTPPortsLabel.Location = New System.Drawing.Point(0, 3)
        Me.NetFTPPortsLabel.Name = "NetFTPPortsLabel"
        Me.NetFTPPortsLabel.Size = New System.Drawing.Size(57, 13)
        Me.NetFTPPortsLabel.TabIndex = 4
        Me.NetFTPPortsLabel.Text = "FTP Ports:"
        '
        'NetServerPorts
        '
        Me.NetServerPorts.Location = New System.Drawing.Point(109, 30)
        Me.NetServerPorts.Name = "NetServerPorts"
        Me.NetServerPorts.Size = New System.Drawing.Size(133, 21)
        Me.NetServerPorts.TabIndex = 1
        '
        'NetFTPPorts
        '
        Me.NetFTPPorts.Location = New System.Drawing.Point(109, 0)
        Me.NetFTPPorts.Name = "NetFTPPorts"
        Me.NetFTPPorts.Size = New System.Drawing.Size(133, 21)
        Me.NetFTPPorts.TabIndex = 0
        '
        'NetUPDPort
        '
        Me.NetUPDPort.Enabled = False
        Me.NetUPDPort.Location = New System.Drawing.Point(116, 100)
        Me.NetUPDPort.Name = "NetUPDPort"
        Me.NetUPDPort.Size = New System.Drawing.Size(133, 21)
        Me.NetUPDPort.TabIndex = 0
        '
        'MediaFrame
        '
        Me.MediaFrame.Controls.Add(Me.MediaEnableSound)
        Me.MediaFrame.Controls.Add(Me.MediaEnableCD)
        Me.MediaFrame.Controls.Add(Me.MediaEnableQuickDraw)
        Me.MediaFrame.Controls.Add(Me.MediaModeLabel)
        Me.MediaFrame.Controls.Add(Me.MediaMode)
        Me.MediaFrame.Controls.Add(Me.MediaRefreshLabel)
        Me.MediaFrame.Controls.Add(Me.MediaRefresh)
        Me.MediaFrame.Controls.Add(Me.MediaResLabel)
        Me.MediaFrame.Controls.Add(Me.MediaResCust)
        Me.MediaFrame.Controls.Add(Me.MediaResY)
        Me.MediaFrame.Controls.Add(Me.MediaResX)
        Me.MediaFrame.Location = New System.Drawing.Point(0, 0)
        Me.MediaFrame.Name = "MediaFrame"
        Me.MediaFrame.Size = New System.Drawing.Size(367, 279)
        Me.MediaFrame.TabIndex = 5
        Me.MediaFrame.TabStop = False
        Me.MediaFrame.Text = "Screen"
        '
        'MediaEnableSound
        '
        Me.MediaEnableSound.AutoSize = True
        Me.MediaEnableSound.Location = New System.Drawing.Point(230, 130)
        Me.MediaEnableSound.Name = "MediaEnableSound"
        Me.MediaEnableSound.Size = New System.Drawing.Size(90, 17)
        Me.MediaEnableSound.TabIndex = 5
        Me.MediaEnableSound.Text = "Enable sound"
        Me.MediaEnableSound.UseVisualStyleBackColor = True
        '
        'MediaEnableCD
        '
        Me.MediaEnableCD.AutoSize = True
        Me.MediaEnableCD.Location = New System.Drawing.Point(10, 130)
        Me.MediaEnableCD.Name = "MediaEnableCD"
        Me.MediaEnableCD.Size = New System.Drawing.Size(142, 17)
        Me.MediaEnableCD.TabIndex = 6
        Me.MediaEnableCD.Text = "Enable CD-ROM support"
        Me.MediaEnableCD.UseVisualStyleBackColor = True
        '
        'MediaEnableQuickDraw
        '
        Me.MediaEnableQuickDraw.AutoSize = True
        Me.MediaEnableQuickDraw.Location = New System.Drawing.Point(18, 100)
        Me.MediaEnableQuickDraw.Name = "MediaEnableQuickDraw"
        Me.MediaEnableQuickDraw.Size = New System.Drawing.Size(173, 17)
        Me.MediaEnableQuickDraw.TabIndex = 8
        Me.MediaEnableQuickDraw.Text = "Enable QuickDraw acceleration"
        Me.MediaEnableQuickDraw.UseVisualStyleBackColor = True
        '
        'MediaModeLabel
        '
        Me.MediaModeLabel.AutoSize = True
        Me.MediaModeLabel.Location = New System.Drawing.Point(15, 76)
        Me.MediaModeLabel.Name = "MediaModeLabel"
        Me.MediaModeLabel.Size = New System.Drawing.Size(37, 13)
        Me.MediaModeLabel.TabIndex = 7
        Me.MediaModeLabel.Text = "Mode:"
        '
        'MediaMode
        '
        Me.MediaMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MediaMode.FormattingEnabled = True
        Me.MediaMode.Items.AddRange(New Object() {"Windowed", "Full screen"})
        Me.MediaMode.Location = New System.Drawing.Point(94, 73)
        Me.MediaMode.Name = "MediaMode"
        Me.MediaMode.Size = New System.Drawing.Size(131, 21)
        Me.MediaMode.TabIndex = 6
        '
        'MediaRefreshLabel
        '
        Me.MediaRefreshLabel.AutoSize = True
        Me.MediaRefreshLabel.Location = New System.Drawing.Point(15, 51)
        Me.MediaRefreshLabel.Name = "MediaRefreshLabel"
        Me.MediaRefreshLabel.Size = New System.Drawing.Size(72, 13)
        Me.MediaRefreshLabel.TabIndex = 5
        Me.MediaRefreshLabel.Text = "Refresh rate:"
        '
        'MediaRefresh
        '
        Me.MediaRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MediaRefresh.FormattingEnabled = True
        Me.MediaRefresh.Items.AddRange(New Object() {"5 Hz", "7.5 Hz", "10 Hz", "15 Hz", "30 Hz", "60 Hz"})
        Me.MediaRefresh.Location = New System.Drawing.Point(94, 46)
        Me.MediaRefresh.Name = "MediaRefresh"
        Me.MediaRefresh.Size = New System.Drawing.Size(131, 21)
        Me.MediaRefresh.TabIndex = 4
        '
        'MediaResLabel
        '
        Me.MediaResLabel.AutoSize = True
        Me.MediaResLabel.Location = New System.Drawing.Point(15, 23)
        Me.MediaResLabel.Name = "MediaResLabel"
        Me.MediaResLabel.Size = New System.Drawing.Size(61, 13)
        Me.MediaResLabel.TabIndex = 2
        Me.MediaResLabel.Text = "Resolution:"
        '
        'MediaResCust
        '
        Me.MediaResCust.AutoSize = True
        Me.MediaResCust.Location = New System.Drawing.Point(232, 23)
        Me.MediaResCust.Name = "MediaResCust"
        Me.MediaResCust.Size = New System.Drawing.Size(120, 17)
        Me.MediaResCust.TabIndex = 3
        Me.MediaResCust.Text = "Custom Resolutions"
        Me.MediaResCust.UseVisualStyleBackColor = True
        '
        'MediaResY
        '
        Me.MediaResY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MediaResY.FormattingEnabled = True
        Me.MediaResY.Items.AddRange(New Object() {"30", "120", "144", "192", "240", "288", "300", "384", "360", "432", "450", "480", "504", "540", "576", "600", "648", "720", "768", "900", "1080"})
        Me.MediaResY.Location = New System.Drawing.Point(167, 20)
        Me.MediaResY.Name = "MediaResY"
        Me.MediaResY.Size = New System.Drawing.Size(58, 21)
        Me.MediaResY.TabIndex = 1
        '
        'MediaResX
        '
        Me.MediaResX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MediaResX.FormattingEnabled = True
        Me.MediaResX.Items.AddRange(New Object() {"40", "160", "256", "320", "384", "400", "426", "512", "640", "768", "800", "848", "896", "960", "1024", "1152", "1280", "1366", "1600", "1920"})
        Me.MediaResX.Location = New System.Drawing.Point(94, 20)
        Me.MediaResX.Name = "MediaResX"
        Me.MediaResX.Size = New System.Drawing.Size(58, 21)
        Me.MediaResX.TabIndex = 0
        '
        'InputFrame
        '
        Me.InputFrame.Controls.Add(Me.InputMouseWheelLines)
        Me.InputFrame.Controls.Add(Me.InputMouseWheelMode)
        Me.InputFrame.Controls.Add(Me.InputMouseWheelModeLabel)
        Me.InputFrame.Controls.Add(Me.InputKeyCodesPathPanel)
        Me.InputFrame.Controls.Add(Me.InputKeycodesEnable)
        Me.InputFrame.Controls.Add(Me.InputEmuKbdType)
        Me.InputFrame.Controls.Add(Me.InputEmuKbdTypeLabel)
        Me.InputFrame.Location = New System.Drawing.Point(0, 0)
        Me.InputFrame.Name = "InputFrame"
        Me.InputFrame.Size = New System.Drawing.Size(367, 279)
        Me.InputFrame.TabIndex = 8
        Me.InputFrame.TabStop = False
        Me.InputFrame.Text = "Mouse and keyboard"
        '
        'InputMouseWheelLines
        '
        Me.InputMouseWheelLines.Location = New System.Drawing.Point(294, 61)
        Me.InputMouseWheelLines.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.InputMouseWheelLines.Name = "InputMouseWheelLines"
        Me.InputMouseWheelLines.Size = New System.Drawing.Size(54, 21)
        Me.InputMouseWheelLines.TabIndex = 7
        '
        'InputMouseWheelMode
        '
        Me.InputMouseWheelMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InputMouseWheelMode.FormattingEnabled = True
        Me.InputMouseWheelMode.Items.AddRange(New Object() {"Page Up/Down", "Cursor Up/Down"})
        Me.InputMouseWheelMode.Location = New System.Drawing.Point(118, 60)
        Me.InputMouseWheelMode.Name = "InputMouseWheelMode"
        Me.InputMouseWheelMode.Size = New System.Drawing.Size(169, 21)
        Me.InputMouseWheelMode.TabIndex = 6
        '
        'InputMouseWheelModeLabel
        '
        Me.InputMouseWheelModeLabel.AutoSize = True
        Me.InputMouseWheelModeLabel.Location = New System.Drawing.Point(10, 63)
        Me.InputMouseWheelModeLabel.Name = "InputMouseWheelModeLabel"
        Me.InputMouseWheelModeLabel.Size = New System.Drawing.Size(102, 13)
        Me.InputMouseWheelModeLabel.TabIndex = 5
        Me.InputMouseWheelModeLabel.Text = "Mouse wheel mode:"
        '
        'InputKeyCodesPathPanel
        '
        Me.InputKeyCodesPathPanel.Controls.Add(Me.InputKeyCodesPathLabel)
        Me.InputKeyCodesPathPanel.Controls.Add(Me.InputKeyCodesPath)
        Me.InputKeyCodesPathPanel.Enabled = False
        Me.InputKeyCodesPathPanel.Location = New System.Drawing.Point(10, 159)
        Me.InputKeyCodesPathPanel.Name = "InputKeyCodesPathPanel"
        Me.InputKeyCodesPathPanel.Size = New System.Drawing.Size(338, 21)
        Me.InputKeyCodesPathPanel.TabIndex = 4
        '
        'InputKeyCodesPathLabel
        '
        Me.InputKeyCodesPathLabel.AutoSize = True
        Me.InputKeyCodesPathLabel.Location = New System.Drawing.Point(0, 3)
        Me.InputKeyCodesPathLabel.Name = "InputKeyCodesPathLabel"
        Me.InputKeyCodesPathLabel.Size = New System.Drawing.Size(101, 13)
        Me.InputKeyCodesPathLabel.TabIndex = 1
        Me.InputKeyCodesPathLabel.Text = "Keycodes File Path:"
        '
        'InputKeyCodesPath
        '
        Me.InputKeyCodesPath.Location = New System.Drawing.Point(108, 0)
        Me.InputKeyCodesPath.Name = "InputKeyCodesPath"
        Me.InputKeyCodesPath.Size = New System.Drawing.Size(230, 21)
        Me.InputKeyCodesPath.TabIndex = 0
        '
        'InputKeycodesEnable
        '
        Me.InputKeycodesEnable.AutoSize = True
        Me.InputKeycodesEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InputKeycodesEnable.Location = New System.Drawing.Point(8, 129)
        Me.InputKeycodesEnable.Name = "InputKeycodesEnable"
        Me.InputKeycodesEnable.Size = New System.Drawing.Size(123, 17)
        Me.InputKeycodesEnable.TabIndex = 3
        Me.InputKeycodesEnable.Text = "Enable keycodes file"
        Me.InputKeycodesEnable.UseVisualStyleBackColor = True
        '
        'InputEmuKbdType
        '
        Me.InputEmuKbdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InputEmuKbdType.FormattingEnabled = True
        Me.InputEmuKbdType.Items.AddRange(New Object() {"Apple Extended Keyboard II (ISO)", "Macintosh Plus Keyboard with keypad", "Apple PowerBook Keyboard (ISO)"})
        Me.InputEmuKbdType.Location = New System.Drawing.Point(118, 30)
        Me.InputEmuKbdType.Name = "InputEmuKbdType"
        Me.InputEmuKbdType.Size = New System.Drawing.Size(230, 21)
        Me.InputEmuKbdType.TabIndex = 1
        '
        'InputEmuKbdTypeLabel
        '
        Me.InputEmuKbdTypeLabel.AutoSize = True
        Me.InputEmuKbdTypeLabel.Location = New System.Drawing.Point(10, 33)
        Me.InputEmuKbdTypeLabel.Name = "InputEmuKbdTypeLabel"
        Me.InputEmuKbdTypeLabel.Size = New System.Drawing.Size(84, 13)
        Me.InputEmuKbdTypeLabel.TabIndex = 0
        Me.InputEmuKbdTypeLabel.Text = "Keyboard Type:"
        '
        'SerialFrame
        '
        Me.SerialFrame.Controls.Add(Me.SerialBFilePath)
        Me.SerialFrame.Controls.Add(Me.SerialBFileBrowse)
        Me.SerialFrame.Controls.Add(Me.SerialAFilePath)
        Me.SerialFrame.Controls.Add(Me.SerialAFileBrowse)
        Me.SerialFrame.Controls.Add(Me.SerialBLabel)
        Me.SerialFrame.Controls.Add(Me.SerialALabel)
        Me.SerialFrame.Controls.Add(Me.SerialB)
        Me.SerialFrame.Controls.Add(Me.SerialA)
        Me.SerialFrame.Location = New System.Drawing.Point(0, 0)
        Me.SerialFrame.Name = "SerialFrame"
        Me.SerialFrame.Size = New System.Drawing.Size(367, 279)
        Me.SerialFrame.TabIndex = 8
        Me.SerialFrame.TabStop = False
        Me.SerialFrame.Text = "Serial ports"
        '
        'SerialBFilePath
        '
        Me.SerialBFilePath.Location = New System.Drawing.Point(9, 103)
        Me.SerialBFilePath.Name = "SerialBFilePath"
        Me.SerialBFilePath.Size = New System.Drawing.Size(271, 21)
        Me.SerialBFilePath.TabIndex = 7
        '
        'SerialBFileBrowse
        '
        Me.SerialBFileBrowse.Location = New System.Drawing.Point(286, 101)
        Me.SerialBFileBrowse.Name = "SerialBFileBrowse"
        Me.SerialBFileBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SerialBFileBrowse.TabIndex = 6
        Me.SerialBFileBrowse.Text = "Browse"
        Me.SerialBFileBrowse.UseVisualStyleBackColor = True
        '
        'SerialAFilePath
        '
        Me.SerialAFilePath.Location = New System.Drawing.Point(9, 44)
        Me.SerialAFilePath.Name = "SerialAFilePath"
        Me.SerialAFilePath.Size = New System.Drawing.Size(271, 21)
        Me.SerialAFilePath.TabIndex = 5
        '
        'SerialAFileBrowse
        '
        Me.SerialAFileBrowse.Location = New System.Drawing.Point(286, 42)
        Me.SerialAFileBrowse.Name = "SerialAFileBrowse"
        Me.SerialAFileBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SerialAFileBrowse.TabIndex = 4
        Me.SerialAFileBrowse.Text = "Browse"
        Me.SerialAFileBrowse.UseVisualStyleBackColor = True
        '
        'SerialBLabel
        '
        Me.SerialBLabel.AutoSize = True
        Me.SerialBLabel.Location = New System.Drawing.Point(6, 76)
        Me.SerialBLabel.Name = "SerialBLabel"
        Me.SerialBLabel.Size = New System.Drawing.Size(65, 13)
        Me.SerialBLabel.TabIndex = 3
        Me.SerialBLabel.Text = "Serial Port 2"
        '
        'SerialALabel
        '
        Me.SerialALabel.AutoSize = True
        Me.SerialALabel.Location = New System.Drawing.Point(6, 20)
        Me.SerialALabel.Name = "SerialALabel"
        Me.SerialALabel.Size = New System.Drawing.Size(65, 13)
        Me.SerialALabel.TabIndex = 2
        Me.SerialALabel.Text = "Serial Port 1"
        '
        'SerialB
        '
        Me.SerialB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialB.FormattingEnabled = True
        Me.SerialB.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "File", "None"})
        Me.SerialB.Location = New System.Drawing.Point(76, 73)
        Me.SerialB.Name = "SerialB"
        Me.SerialB.Size = New System.Drawing.Size(80, 21)
        Me.SerialB.TabIndex = 1
        '
        'SerialA
        '
        Me.SerialA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialA.FormattingEnabled = True
        Me.SerialA.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "File", "None"})
        Me.SerialA.Location = New System.Drawing.Point(76, 17)
        Me.SerialA.Name = "SerialA"
        Me.SerialA.Size = New System.Drawing.Size(80, 21)
        Me.SerialA.TabIndex = 0
        '
        'ExtFSFrame
        '
        Me.ExtFSFrame.Controls.Add(Me.ExtFSDrivesLabel)
        Me.ExtFSFrame.Controls.Add(Me.ExtFSDrives)
        Me.ExtFSFrame.Controls.Add(Me.ExtFSEnable)
        Me.ExtFSFrame.Location = New System.Drawing.Point(0, 0)
        Me.ExtFSFrame.Name = "ExtFSFrame"
        Me.ExtFSFrame.Size = New System.Drawing.Size(367, 279)
        Me.ExtFSFrame.TabIndex = 9
        Me.ExtFSFrame.TabStop = False
        Me.ExtFSFrame.Text = "MacOS External FileSystem"
        '
        'ExtFSDrivesLabel
        '
        Me.ExtFSDrivesLabel.AutoSize = True
        Me.ExtFSDrivesLabel.Location = New System.Drawing.Point(7, 60)
        Me.ExtFSDrivesLabel.Name = "ExtFSDrivesLabel"
        Me.ExtFSDrivesLabel.Size = New System.Drawing.Size(171, 13)
        Me.ExtFSDrivesLabel.TabIndex = 10
        Me.ExtFSDrivesLabel.Text = "Volumes which MacOS can access:"
        Me.ExtFSDrivesLabel.Visible = False
        '
        'ExtFSDrives
        '
        Me.ExtFSDrives.FormattingEnabled = True
        Me.ExtFSDrives.Items.AddRange(New Object() {"C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ExtFSDrives.Location = New System.Drawing.Point(10, 80)
        Me.ExtFSDrives.Name = "ExtFSDrives"
        Me.ExtFSDrives.Size = New System.Drawing.Size(347, 180)
        Me.ExtFSDrives.TabIndex = 9
        Me.ExtFSDrives.Visible = False
        '
        'ExtFSEnable
        '
        Me.ExtFSEnable.AutoSize = True
        Me.ExtFSEnable.Location = New System.Drawing.Point(10, 30)
        Me.ExtFSEnable.Name = "ExtFSEnable"
        Me.ExtFSEnable.Size = New System.Drawing.Size(155, 17)
        Me.ExtFSEnable.TabIndex = 8
        Me.ExtFSEnable.Text = "Enable External FileSystem"
        Me.ExtFSEnable.UseVisualStyleBackColor = True
        '
        'MiscFrame
        '
        Me.MiscFrame.Controls.Add(Me.MiscIgnoreIllegal)
        Me.MiscFrame.Controls.Add(Me.MiscClipConv)
        Me.MiscFrame.Controls.Add(Me.MiscIdle)
        Me.MiscFrame.Controls.Add(Me.MiscIgnoreSegv)
        Me.MiscFrame.Controls.Add(Me.MiscEnableGUI)
        Me.MiscFrame.Controls.Add(Me.MiscROM)
        Me.MiscFrame.Controls.Add(Me.MiscROMBrowse)
        Me.MiscFrame.Controls.Add(Me.MiscROMLabel)
        Me.MiscFrame.Location = New System.Drawing.Point(0, 0)
        Me.MiscFrame.Name = "MiscFrame"
        Me.MiscFrame.Size = New System.Drawing.Size(367, 279)
        Me.MiscFrame.TabIndex = 8
        Me.MiscFrame.TabStop = False
        Me.MiscFrame.Text = "Miscelaneous"
        '
        'MiscIgnoreIllegal
        '
        Me.MiscIgnoreIllegal.AutoSize = True
        Me.MiscIgnoreIllegal.Location = New System.Drawing.Point(12, 120)
        Me.MiscIgnoreIllegal.Name = "MiscIgnoreIllegal"
        Me.MiscIgnoreIllegal.Size = New System.Drawing.Size(149, 17)
        Me.MiscIgnoreIllegal.TabIndex = 9
        Me.MiscIgnoreIllegal.Text = "Ignore Illegal Instructions"
        Me.MiscIgnoreIllegal.UseVisualStyleBackColor = True
        '
        'MiscClipConv
        '
        Me.MiscClipConv.AutoSize = True
        Me.MiscClipConv.Location = New System.Drawing.Point(12, 150)
        Me.MiscClipConv.Name = "MiscClipConv"
        Me.MiscClipConv.Size = New System.Drawing.Size(225, 17)
        Me.MiscClipConv.TabIndex = 8
        Me.MiscClipConv.Text = "Convert clipboard contents when copying"
        Me.MiscClipConv.UseVisualStyleBackColor = True
        '
        'MiscIdle
        '
        Me.MiscIdle.AutoSize = True
        Me.MiscIdle.Location = New System.Drawing.Point(12, 180)
        Me.MiscIdle.Name = "MiscIdle"
        Me.MiscIdle.Size = New System.Drawing.Size(207, 17)
        Me.MiscIdle.TabIndex = 7
        Me.MiscIdle.Text = "Reduce CPU load when the Mac is idle"
        Me.MiscIdle.UseVisualStyleBackColor = True
        '
        'MiscIgnoreSegv
        '
        Me.MiscIgnoreSegv.AutoSize = True
        Me.MiscIgnoreSegv.Location = New System.Drawing.Point(12, 90)
        Me.MiscIgnoreSegv.Name = "MiscIgnoreSegv"
        Me.MiscIgnoreSegv.Size = New System.Drawing.Size(177, 17)
        Me.MiscIgnoreSegv.TabIndex = 6
        Me.MiscIgnoreSegv.Text = "Ignore Illegal Memory Accesses"
        Me.MiscIgnoreSegv.UseVisualStyleBackColor = True
        '
        'MiscEnableGUI
        '
        Me.MiscEnableGUI.AutoSize = True
        Me.MiscEnableGUI.Location = New System.Drawing.Point(12, 60)
        Me.MiscEnableGUI.Name = "MiscEnableGUI"
        Me.MiscEnableGUI.Size = New System.Drawing.Size(79, 17)
        Me.MiscEnableGUI.TabIndex = 5
        Me.MiscEnableGUI.Text = "Enable GUI"
        Me.MiscEnableGUI.UseVisualStyleBackColor = True
        '
        'MiscROM
        '
        Me.MiscROM.Location = New System.Drawing.Point(72, 30)
        Me.MiscROM.Name = "MiscROM"
        Me.MiscROM.Size = New System.Drawing.Size(208, 21)
        Me.MiscROM.TabIndex = 2
        '
        'MiscROMBrowse
        '
        Me.MiscROMBrowse.Location = New System.Drawing.Point(286, 28)
        Me.MiscROMBrowse.Name = "MiscROMBrowse"
        Me.MiscROMBrowse.Size = New System.Drawing.Size(75, 23)
        Me.MiscROMBrowse.TabIndex = 1
        Me.MiscROMBrowse.Text = "Browse"
        Me.MiscROMBrowse.UseVisualStyleBackColor = True
        '
        'MiscROMLabel
        '
        Me.MiscROMLabel.AutoSize = True
        Me.MiscROMLabel.Location = New System.Drawing.Point(9, 33)
        Me.MiscROMLabel.Name = "MiscROMLabel"
        Me.MiscROMLabel.Size = New System.Drawing.Size(34, 13)
        Me.MiscROMLabel.TabIndex = 0
        Me.MiscROMLabel.Text = "ROM:"
        '
        'JITFrame
        '
        Me.JITFrame.Controls.Add(Me.JITEnable)
        Me.JITFrame.Controls.Add(Me.JIT68kEnable)
        Me.JITFrame.Controls.Add(Me.JITDebugExtFS)
        Me.JITFrame.Location = New System.Drawing.Point(0, 0)
        Me.JITFrame.Name = "JITFrame"
        Me.JITFrame.Size = New System.Drawing.Size(367, 279)
        Me.JITFrame.TabIndex = 10
        Me.JITFrame.TabStop = False
        Me.JITFrame.Text = "JIT and debugging options"
        '
        'JITEnable
        '
        Me.JITEnable.AutoSize = True
        Me.JITEnable.Location = New System.Drawing.Point(10, 20)
        Me.JITEnable.Name = "JITEnable"
        Me.JITEnable.Size = New System.Drawing.Size(120, 17)
        Me.JITEnable.TabIndex = 0
        Me.JITEnable.Text = "Enable JIT Compiler"
        Me.JITEnable.UseVisualStyleBackColor = True
        '
        'JIT68kEnable
        '
        Me.JIT68kEnable.AutoSize = True
        Me.JIT68kEnable.Location = New System.Drawing.Point(10, 50)
        Me.JIT68kEnable.Name = "JIT68kEnable"
        Me.JIT68kEnable.Size = New System.Drawing.Size(221, 17)
        Me.JIT68kEnable.TabIndex = 9
        Me.JIT68kEnable.Text = "Enable 68k emulator (Not recommended)"
        Me.JIT68kEnable.UseVisualStyleBackColor = True
        '
        'JITDebugExtFS
        '
        Me.JITDebugExtFS.AutoSize = True
        Me.JITDebugExtFS.Location = New System.Drawing.Point(10, 80)
        Me.JITDebugExtFS.Name = "JITDebugExtFS"
        Me.JITDebugExtFS.Size = New System.Drawing.Size(88, 17)
        Me.JITDebugExtFS.TabIndex = 10
        Me.JITDebugExtFS.Text = "Debug ExtFS"
        Me.JITDebugExtFS.UseVisualStyleBackColor = True
        '
        'EMCFrame
        '
        Me.EMCFrame.Controls.Add(Me.EMCEditor)
        Me.EMCFrame.Location = New System.Drawing.Point(0, 0)
        Me.EMCFrame.Name = "EMCFrame"
        Me.EMCFrame.Size = New System.Drawing.Size(367, 279)
        Me.EMCFrame.TabIndex = 9
        Me.EMCFrame.TabStop = False
        Me.EMCFrame.Text = "Edit Manually Config File"
        '
        'EMCEditor
        '
        Me.EMCEditor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EMCKeywordValueColumn})
        Me.EMCEditor.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMCEditor.FullRowSelect = True
        Me.EMCEditor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.EMCEditor.LabelEdit = True
        Me.EMCEditor.Location = New System.Drawing.Point(10, 30)
        Me.EMCEditor.Name = "EMCEditor"
        Me.EMCEditor.Size = New System.Drawing.Size(351, 235)
        Me.EMCEditor.TabIndex = 1
        Me.EMCEditor.UseCompatibleStateImageBehavior = False
        Me.EMCEditor.View = System.Windows.Forms.View.Details
        '
        'EMCKeywordValueColumn
        '
        Me.EMCKeywordValueColumn.Text = "Edit lines by double clicking them."
        Me.EMCKeywordValueColumn.Width = 338
        '
        'OptionList
        '
        Me.OptionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Options, Me.Value})
        Me.OptionList.FullRowSelect = True
        Me.OptionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.OptionList.Location = New System.Drawing.Point(12, 12)
        Me.OptionList.Name = "OptionList"
        Me.OptionList.Size = New System.Drawing.Size(353, 376)
        Me.OptionList.TabIndex = 26
        Me.OptionList.UseCompatibleStateImageBehavior = False
        Me.OptionList.View = System.Windows.Forms.View.Details
        '
        'Options
        '
        Me.Options.Text = "Options"
        Me.Options.Width = 173
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 176
        '
        'frmSettingsSheepVM
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(750, 400)
        Me.Controls.Add(Me.GroupContainer)
        Me.Controls.Add(Me.OptionList)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsSheepVM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Settings for %s"
        Me.DriveListContext.ResumeLayout(False)
        Me.GroupContainer.ResumeLayout(False)
        Me.MacNameFrame.ResumeLayout(False)
        Me.MacNameFrame.PerformLayout()
        Me.IconFrame.ResumeLayout(False)
        Me.IconFrame.PerformLayout()
        Me.MemoryFrame.ResumeLayout(False)
        Me.MemoryFrame.PerformLayout()
        CType(Me.MemoryTracker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DriveFrame.ResumeLayout(False)
        Me.DriveFrame.PerformLayout()
        Me.NetworkFrame.ResumeLayout(False)
        Me.NetworkFrame.PerformLayout()
        Me.NetContainer.ResumeLayout(False)
        Me.NetContainer.PerformLayout()
        Me.NetRouterConfig.ResumeLayout(False)
        Me.NetRouterConfig.PerformLayout()
        Me.MediaFrame.ResumeLayout(False)
        Me.MediaFrame.PerformLayout()
        Me.InputFrame.ResumeLayout(False)
        Me.InputFrame.PerformLayout()
        CType(Me.InputMouseWheelLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputKeyCodesPathPanel.ResumeLayout(False)
        Me.InputKeyCodesPathPanel.PerformLayout()
        Me.SerialFrame.ResumeLayout(False)
        Me.SerialFrame.PerformLayout()
        Me.ExtFSFrame.ResumeLayout(False)
        Me.ExtFSFrame.PerformLayout()
        Me.MiscFrame.ResumeLayout(False)
        Me.MiscFrame.PerformLayout()
        Me.JITFrame.ResumeLayout(False)
        Me.JITFrame.PerformLayout()
        Me.EMCFrame.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Browser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents DriveListContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextAddDisk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAddCD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAddFloppy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextSetAsBoot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextRemoveDrive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriveIcons As System.Windows.Forms.ImageList
    Friend WithEvents GroupContainer As System.Windows.Forms.Panel
    Friend WithEvents IconFrame As System.Windows.Forms.GroupBox
    Friend WithEvents IconList As System.Windows.Forms.ListView
    Friend WithEvents IconInfo As System.Windows.Forms.Label
    Friend WithEvents MediaFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MediaModeLabel As System.Windows.Forms.Label
    Friend WithEvents MediaMode As System.Windows.Forms.ComboBox
    Friend WithEvents MediaRefreshLabel As System.Windows.Forms.Label
    Friend WithEvents MediaRefresh As System.Windows.Forms.ComboBox
    Friend WithEvents MediaResLabel As System.Windows.Forms.Label
    Friend WithEvents MediaResCust As System.Windows.Forms.CheckBox
    Friend WithEvents MediaResY As System.Windows.Forms.ComboBox
    Friend WithEvents MediaResX As System.Windows.Forms.ComboBox
    Friend WithEvents NetworkFrame As System.Windows.Forms.GroupBox
    Friend WithEvents NetPermPhysicalAddress As System.Windows.Forms.CheckBox
    Friend WithEvents NetEnableUDP As System.Windows.Forms.CheckBox
    Friend WithEvents NetUPDPortLabel As System.Windows.Forms.Label
    Friend WithEvents NetUPDPort As System.Windows.Forms.TextBox
    Friend WithEvents NetRouterConfig As System.Windows.Forms.Panel
    Friend WithEvents NetServerPortsLabel As System.Windows.Forms.Label
    Friend WithEvents NetFTPPortsLabel As System.Windows.Forms.Label
    Friend WithEvents NetServerPorts As System.Windows.Forms.TextBox
    Friend WithEvents NetFTPPorts As System.Windows.Forms.TextBox
    Friend WithEvents NetTypeLabel As System.Windows.Forms.Label
    Friend WithEvents NetType As System.Windows.Forms.ComboBox
    Friend WithEvents NetRouterEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents SerialFrame As System.Windows.Forms.GroupBox
    Friend WithEvents SerialBFilePath As System.Windows.Forms.TextBox
    Friend WithEvents SerialBFileBrowse As System.Windows.Forms.Button
    Friend WithEvents SerialAFilePath As System.Windows.Forms.TextBox
    Friend WithEvents SerialAFileBrowse As System.Windows.Forms.Button
    Friend WithEvents SerialBLabel As System.Windows.Forms.Label
    Friend WithEvents SerialALabel As System.Windows.Forms.Label
    Friend WithEvents SerialB As System.Windows.Forms.ComboBox
    Friend WithEvents SerialA As System.Windows.Forms.ComboBox
    Friend WithEvents EMCFrame As System.Windows.Forms.GroupBox
    Friend WithEvents EMCEditor As System.Windows.Forms.ListView
    Friend WithEvents EMCKeywordValueColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DrivePollMedia As System.Windows.Forms.CheckBox
    Friend WithEvents DriveBootCD As System.Windows.Forms.RadioButton
    Friend WithEvents DriveBootDisk As System.Windows.Forms.RadioButton
    Friend WithEvents DriveSetBootDrive As System.Windows.Forms.Button
    Friend WithEvents DriveRemove As System.Windows.Forms.Button
    Friend WithEvents DriveAddFloppy As System.Windows.Forms.Button
    Friend WithEvents DriveAddCD As System.Windows.Forms.Button
    Friend WithEvents DriveAddDisk As System.Windows.Forms.Button
    Friend WithEvents DriveList As System.Windows.Forms.ListView
    Friend WithEvents DriveLCPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveLCType As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveLCBootMark As System.Windows.Forms.ColumnHeader
    Friend WithEvents MiscFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MiscIdle As System.Windows.Forms.CheckBox
    Friend WithEvents MiscIgnoreSegv As System.Windows.Forms.CheckBox
    Friend WithEvents MiscEnableGUI As System.Windows.Forms.CheckBox
    Friend WithEvents MiscROM As System.Windows.Forms.TextBox
    Friend WithEvents MiscROMBrowse As System.Windows.Forms.Button
    Friend WithEvents MiscROMLabel As System.Windows.Forms.Label
    Friend WithEvents MacNameFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MacName As System.Windows.Forms.TextBox
    Friend WithEvents MacNameLabel As System.Windows.Forms.Label
    Friend WithEvents ExtFSFrame As System.Windows.Forms.GroupBox
    Friend WithEvents ExtFSDrivesLabel As System.Windows.Forms.Label
    Friend WithEvents ExtFSDrives As System.Windows.Forms.CheckedListBox
    Friend WithEvents ExtFSEnable As System.Windows.Forms.CheckBox
    Friend WithEvents JITFrame As System.Windows.Forms.GroupBox
    Friend WithEvents JITEnable As System.Windows.Forms.CheckBox
    Friend WithEvents InputFrame As System.Windows.Forms.GroupBox
    Friend WithEvents InputMouseWheelLines As System.Windows.Forms.NumericUpDown
    Friend WithEvents InputMouseWheelMode As System.Windows.Forms.ComboBox
    Friend WithEvents InputMouseWheelModeLabel As System.Windows.Forms.Label
    Friend WithEvents InputKeyCodesPathPanel As System.Windows.Forms.Panel
    Friend WithEvents InputKeyCodesPathLabel As System.Windows.Forms.Label
    Friend WithEvents InputKeyCodesPath As System.Windows.Forms.TextBox
    Friend WithEvents InputKeycodesEnable As System.Windows.Forms.CheckBox
    Friend WithEvents InputEmuKbdType As System.Windows.Forms.ComboBox
    Friend WithEvents InputEmuKbdTypeLabel As System.Windows.Forms.Label
    Friend WithEvents MediaEnableSound As System.Windows.Forms.CheckBox
    Friend WithEvents MediaEnableCD As System.Windows.Forms.CheckBox
    Friend WithEvents MemoryFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MemoryBoxMBLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryBoxLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryBox As System.Windows.Forms.TextBox
    Friend WithEvents MemoryTracker As System.Windows.Forms.TrackBar
    Friend WithEvents OptionList As System.Windows.Forms.ListView
    Friend WithEvents Options As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconAdd As System.Windows.Forms.Button
    Friend WithEvents MediaEnableQuickDraw As System.Windows.Forms.CheckBox
    Friend WithEvents NetEnable As System.Windows.Forms.CheckBox
    Friend WithEvents NetContainer As System.Windows.Forms.Panel
    Friend WithEvents MiscClipConv As System.Windows.Forms.CheckBox
    Friend WithEvents MiscIgnoreIllegal As System.Windows.Forms.CheckBox
    Friend WithEvents JIT68kEnable As System.Windows.Forms.CheckBox
    Friend WithEvents NetFakeAddressLabel As System.Windows.Forms.Label
    Friend WithEvents NetFakeAddress As System.Windows.Forms.TextBox
    Friend WithEvents JITDebugExtFS As System.Windows.Forms.CheckBox
    Friend WithEvents NetMulticastModeLabel As System.Windows.Forms.Label
    Friend WithEvents NetMulticastMode As System.Windows.Forms.TextBox
#End Region
End Class