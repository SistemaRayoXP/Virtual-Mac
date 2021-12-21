<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsBasiliskVM
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingsBasiliskVM))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Name", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Icon", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Memory")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Drives", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Network", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Screen", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mouse and keyboard")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Serial ports")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Misc. Hardware")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("External FileSystem")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Miscelaneous")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("JIT and debugging")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Manually Config File")
        Me.OptionPanel = New System.Windows.Forms.Panel()
        Me.IconFrame = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.IconInfo = New System.Windows.Forms.Label()
        Me.ScreenFrame = New System.Windows.Forms.GroupBox()
        Me.ScrModeLabel = New System.Windows.Forms.Label()
        Me.ScrMode = New System.Windows.Forms.ComboBox()
        Me.ScrRefreshLabel = New System.Windows.Forms.Label()
        Me.ScrRefresh = New System.Windows.Forms.ComboBox()
        Me.ScrResLabel = New System.Windows.Forms.Label()
        Me.ScrResCust = New System.Windows.Forms.CheckBox()
        Me.ScrResY = New System.Windows.Forms.ComboBox()
        Me.ScrResX = New System.Windows.Forms.ComboBox()
        Me.NetworkFrame = New System.Windows.Forms.GroupBox()
        Me.NetPermPhysicalAddress = New System.Windows.Forms.CheckBox()
        Me.NetEnableUDP = New System.Windows.Forms.CheckBox()
        Me.NetUPDPortLabel = New System.Windows.Forms.Label()
        Me.NetUPDPort = New System.Windows.Forms.TextBox()
        Me.NetRouterConfig = New System.Windows.Forms.Panel()
        Me.NetServerPortsLabel = New System.Windows.Forms.Label()
        Me.NetFTPPortsLabel = New System.Windows.Forms.Label()
        Me.NetServerPorts = New System.Windows.Forms.TextBox()
        Me.NetFTPPorts = New System.Windows.Forms.TextBox()
        Me.NetTypeLabel = New System.Windows.Forms.Label()
        Me.NetType = New System.Windows.Forms.ComboBox()
        Me.NetRouterEnabled = New System.Windows.Forms.CheckBox()
        Me.SerialFrame = New System.Windows.Forms.GroupBox()
        Me.SBFilePath = New System.Windows.Forms.TextBox()
        Me.SBFileBrowse = New System.Windows.Forms.Button()
        Me.SAFilePath = New System.Windows.Forms.TextBox()
        Me.SAFileBrowse = New System.Windows.Forms.Button()
        Me.SerialBLabel = New System.Windows.Forms.Label()
        Me.SerialALabel = New System.Windows.Forms.Label()
        Me.SerialB = New System.Windows.Forms.ComboBox()
        Me.SerialA = New System.Windows.Forms.ComboBox()
        Me.EMCFrame = New System.Windows.Forms.GroupBox()
        Me.EMCEditor = New System.Windows.Forms.ListView()
        Me.EMCKeywordValueColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.DriveListContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DriveContxAddDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveContxAddCD = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveContxAddFloppy = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveContextBar0 = New System.Windows.Forms.ToolStripSeparator()
        Me.DriveContxSetAsBoot = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveContextBar1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DriveContxRemoveDrive = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.MiscFrame = New System.Windows.Forms.GroupBox()
        Me.MiscIdleWait = New System.Windows.Forms.CheckBox()
        Me.MiscIgnoreSegv = New System.Windows.Forms.CheckBox()
        Me.MiscEnableGUI = New System.Windows.Forms.CheckBox()
        Me.MiscROM = New System.Windows.Forms.TextBox()
        Me.MiscROMBrowse = New System.Windows.Forms.Button()
        Me.MiscROMLabel = New System.Windows.Forms.Label()
        Me.MacNameFrame = New System.Windows.Forms.GroupBox()
        Me.MacName = New System.Windows.Forms.TextBox()
        Me.MacNameLabel = New System.Windows.Forms.Label()
        Me.ExtFSFrame = New System.Windows.Forms.GroupBox()
        Me.ExtFSDrivesLabel = New System.Windows.Forms.Label()
        Me.ExtFSDrives = New System.Windows.Forms.CheckedListBox()
        Me.ExtFSEnable = New System.Windows.Forms.CheckBox()
        Me.JITFrame = New System.Windows.Forms.GroupBox()
        Me.JITDebugExtFS = New System.Windows.Forms.CheckBox()
        Me.JITCacheSizeLabel = New System.Windows.Forms.Label()
        Me.JITDebug = New System.Windows.Forms.CheckBox()
        Me.JITDontUseInfo = New System.Windows.Forms.Label()
        Me.JITLazyFlush = New System.Windows.Forms.CheckBox()
        Me.JITFPU = New System.Windows.Forms.CheckBox()
        Me.JITInLine = New System.Windows.Forms.CheckBox()
        Me.JITEnable = New System.Windows.Forms.CheckBox()
        Me.JITCacheSize = New System.Windows.Forms.ComboBox()
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
        Me.MiscHwFrame = New System.Windows.Forms.GroupBox()
        Me.MiscHwSound = New System.Windows.Forms.CheckBox()
        Me.MiscHwCPU = New System.Windows.Forms.ComboBox()
        Me.MiscHwFPU = New System.Windows.Forms.CheckBox()
        Me.MiscHwModelLabel = New System.Windows.Forms.Label()
        Me.MiscHwModel = New System.Windows.Forms.ComboBox()
        Me.MiscHwCD = New System.Windows.Forms.CheckBox()
        Me.MiscHwCPULabel = New System.Windows.Forms.Label()
        Me.MemoryFrame = New System.Windows.Forms.GroupBox()
        Me.MemoryBoxMBLabel = New System.Windows.Forms.Label()
        Me.MemoryBoxLabel = New System.Windows.Forms.Label()
        Me.MemoryBox = New System.Windows.Forms.TextBox()
        Me.MemoryTracker = New System.Windows.Forms.TrackBar()
        Me.OptionList = New System.Windows.Forms.ListView()
        Me.Options = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.ControlToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NetMulticastModeLabel = New System.Windows.Forms.Label()
        Me.NetMulticastMode = New System.Windows.Forms.TextBox()
        Me.OptionPanel.SuspendLayout()
        Me.IconFrame.SuspendLayout()
        Me.ScreenFrame.SuspendLayout()
        Me.NetworkFrame.SuspendLayout()
        Me.NetRouterConfig.SuspendLayout()
        Me.SerialFrame.SuspendLayout()
        Me.EMCFrame.SuspendLayout()
        Me.DriveFrame.SuspendLayout()
        Me.DriveListContext.SuspendLayout()
        Me.MiscFrame.SuspendLayout()
        Me.MacNameFrame.SuspendLayout()
        Me.ExtFSFrame.SuspendLayout()
        Me.JITFrame.SuspendLayout()
        Me.InputFrame.SuspendLayout()
        CType(Me.InputMouseWheelLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputKeyCodesPathPanel.SuspendLayout()
        Me.MiscHwFrame.SuspendLayout()
        Me.MemoryFrame.SuspendLayout()
        CType(Me.MemoryTracker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptionPanel
        '
        Me.OptionPanel.Controls.Add(Me.NetworkFrame)
        Me.OptionPanel.Controls.Add(Me.IconFrame)
        Me.OptionPanel.Controls.Add(Me.ScreenFrame)
        Me.OptionPanel.Controls.Add(Me.SerialFrame)
        Me.OptionPanel.Controls.Add(Me.EMCFrame)
        Me.OptionPanel.Controls.Add(Me.DriveFrame)
        Me.OptionPanel.Controls.Add(Me.MiscFrame)
        Me.OptionPanel.Controls.Add(Me.MacNameFrame)
        Me.OptionPanel.Controls.Add(Me.ExtFSFrame)
        Me.OptionPanel.Controls.Add(Me.JITFrame)
        Me.OptionPanel.Controls.Add(Me.InputFrame)
        Me.OptionPanel.Controls.Add(Me.MiscHwFrame)
        Me.OptionPanel.Controls.Add(Me.MemoryFrame)
        Me.OptionPanel.Location = New System.Drawing.Point(371, 1)
        Me.OptionPanel.Name = "OptionPanel"
        Me.OptionPanel.Size = New System.Drawing.Size(373, 290)
        Me.OptionPanel.TabIndex = 25
        '
        'IconFrame
        '
        Me.IconFrame.Controls.Add(Me.ListView1)
        Me.IconFrame.Controls.Add(Me.IconInfo)
        Me.IconFrame.Location = New System.Drawing.Point(0, 0)
        Me.IconFrame.Name = "IconFrame"
        Me.IconFrame.Size = New System.Drawing.Size(367, 276)
        Me.IconFrame.TabIndex = 3
        Me.IconFrame.TabStop = False
        Me.IconFrame.Text = "Icon"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(10, 90)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(346, 74)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'IconInfo
        '
        Me.IconInfo.AutoSize = True
        Me.IconInfo.Location = New System.Drawing.Point(10, 33)
        Me.IconInfo.Name = "IconInfo"
        Me.IconInfo.Size = New System.Drawing.Size(346, 52)
        Me.IconInfo.TabIndex = 0
        Me.IconInfo.Text = resources.GetString("IconInfo.Text")
        '
        'ScreenFrame
        '
        Me.ScreenFrame.Controls.Add(Me.ScrModeLabel)
        Me.ScreenFrame.Controls.Add(Me.ScrMode)
        Me.ScreenFrame.Controls.Add(Me.ScrRefreshLabel)
        Me.ScreenFrame.Controls.Add(Me.ScrRefresh)
        Me.ScreenFrame.Controls.Add(Me.ScrResLabel)
        Me.ScreenFrame.Controls.Add(Me.ScrResCust)
        Me.ScreenFrame.Controls.Add(Me.ScrResY)
        Me.ScreenFrame.Controls.Add(Me.ScrResX)
        Me.ScreenFrame.Location = New System.Drawing.Point(0, 0)
        Me.ScreenFrame.Name = "ScreenFrame"
        Me.ScreenFrame.Size = New System.Drawing.Size(367, 279)
        Me.ScreenFrame.TabIndex = 5
        Me.ScreenFrame.TabStop = False
        Me.ScreenFrame.Text = "Screen"
        '
        'ScrModeLabel
        '
        Me.ScrModeLabel.AutoSize = True
        Me.ScrModeLabel.Location = New System.Drawing.Point(15, 95)
        Me.ScrModeLabel.Name = "ScrModeLabel"
        Me.ScrModeLabel.Size = New System.Drawing.Size(37, 13)
        Me.ScrModeLabel.TabIndex = 7
        Me.ScrModeLabel.Text = "Mode:"
        '
        'ScrMode
        '
        Me.ScrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ScrMode.FormattingEnabled = True
        Me.ScrMode.Items.AddRange(New Object() {"Windowed", "Full screen"})
        Me.ScrMode.Location = New System.Drawing.Point(89, 92)
        Me.ScrMode.Name = "ScrMode"
        Me.ScrMode.Size = New System.Drawing.Size(131, 21)
        Me.ScrMode.TabIndex = 6
        '
        'ScrRefreshLabel
        '
        Me.ScrRefreshLabel.AutoSize = True
        Me.ScrRefreshLabel.Location = New System.Drawing.Point(15, 59)
        Me.ScrRefreshLabel.Name = "ScrRefreshLabel"
        Me.ScrRefreshLabel.Size = New System.Drawing.Size(68, 13)
        Me.ScrRefreshLabel.TabIndex = 5
        Me.ScrRefreshLabel.Text = "Refresh rate:"
        '
        'ScrRefresh
        '
        Me.ScrRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ScrRefresh.FormattingEnabled = True
        Me.ScrRefresh.Items.AddRange(New Object() {"5 Hz", "7.5 Hz", "10 Hz", "15 Hz", "30 Hz", "60 Hz"})
        Me.ScrRefresh.Location = New System.Drawing.Point(89, 56)
        Me.ScrRefresh.Name = "ScrRefresh"
        Me.ScrRefresh.Size = New System.Drawing.Size(131, 21)
        Me.ScrRefresh.TabIndex = 4
        '
        'ScrResLabel
        '
        Me.ScrResLabel.AutoSize = True
        Me.ScrResLabel.Location = New System.Drawing.Point(15, 23)
        Me.ScrResLabel.Name = "ScrResLabel"
        Me.ScrResLabel.Size = New System.Drawing.Size(60, 13)
        Me.ScrResLabel.TabIndex = 2
        Me.ScrResLabel.Text = "Resolution:"
        '
        'ScrResCust
        '
        Me.ScrResCust.AutoSize = True
        Me.ScrResCust.Location = New System.Drawing.Point(242, 22)
        Me.ScrResCust.Name = "ScrResCust"
        Me.ScrResCust.Size = New System.Drawing.Size(119, 17)
        Me.ScrResCust.TabIndex = 3
        Me.ScrResCust.Text = "Custom Resolutions"
        Me.ScrResCust.UseVisualStyleBackColor = True
        '
        'ScrResY
        '
        Me.ScrResY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ScrResY.FormattingEnabled = True
        Me.ScrResY.Items.AddRange(New Object() {"30", "120", "144", "192", "240", "288", "300", "384", "360", "432", "450", "480", "504", "540", "576", "600", "648", "720", "768", "900", "1080"})
        Me.ScrResY.Location = New System.Drawing.Point(162, 20)
        Me.ScrResY.Name = "ScrResY"
        Me.ScrResY.Size = New System.Drawing.Size(58, 21)
        Me.ScrResY.TabIndex = 1
        '
        'ScrResX
        '
        Me.ScrResX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ScrResX.FormattingEnabled = True
        Me.ScrResX.Items.AddRange(New Object() {"40", "160", "256", "320", "384", "400", "426", "512", "640", "768", "800", "848", "896", "960", "1024", "1152", "1280", "1366", "1600", "1920"})
        Me.ScrResX.Location = New System.Drawing.Point(89, 20)
        Me.ScrResX.Name = "ScrResX"
        Me.ScrResX.Size = New System.Drawing.Size(58, 21)
        Me.ScrResX.TabIndex = 0
        '
        'NetworkFrame
        '
        Me.NetworkFrame.Controls.Add(Me.NetMulticastMode)
        Me.NetworkFrame.Controls.Add(Me.NetMulticastModeLabel)
        Me.NetworkFrame.Controls.Add(Me.NetPermPhysicalAddress)
        Me.NetworkFrame.Controls.Add(Me.NetEnableUDP)
        Me.NetworkFrame.Controls.Add(Me.NetUPDPortLabel)
        Me.NetworkFrame.Controls.Add(Me.NetUPDPort)
        Me.NetworkFrame.Controls.Add(Me.NetRouterConfig)
        Me.NetworkFrame.Controls.Add(Me.NetTypeLabel)
        Me.NetworkFrame.Controls.Add(Me.NetType)
        Me.NetworkFrame.Controls.Add(Me.NetRouterEnabled)
        Me.NetworkFrame.Location = New System.Drawing.Point(0, 0)
        Me.NetworkFrame.Name = "NetworkFrame"
        Me.NetworkFrame.Size = New System.Drawing.Size(367, 279)
        Me.NetworkFrame.TabIndex = 8
        Me.NetworkFrame.TabStop = False
        Me.NetworkFrame.Text = "Network"
        '
        'NetPermPhysicalAddress
        '
        Me.NetPermPhysicalAddress.AutoSize = True
        Me.NetPermPhysicalAddress.Location = New System.Drawing.Point(13, 60)
        Me.NetPermPhysicalAddress.Name = "NetPermPhysicalAddress"
        Me.NetPermPhysicalAddress.Size = New System.Drawing.Size(206, 17)
        Me.NetPermPhysicalAddress.TabIndex = 4
        Me.NetPermPhysicalAddress.Text = "Make permanent the ethernet address"
        Me.NetPermPhysicalAddress.UseVisualStyleBackColor = True
        '
        'NetEnableUDP
        '
        Me.NetEnableUDP.AutoSize = True
        Me.NetEnableUDP.Location = New System.Drawing.Point(13, 120)
        Me.NetEnableUDP.Name = "NetEnableUDP"
        Me.NetEnableUDP.Size = New System.Drawing.Size(121, 17)
        Me.NetEnableUDP.TabIndex = 0
        Me.NetEnableUDP.Text = "Enable UDP Tunnel"
        Me.ControlToolTip.SetToolTip(Me.NetEnableUDP, resources.GetString("NetEnableUDP.ToolTip"))
        Me.NetEnableUDP.UseVisualStyleBackColor = True
        '
        'NetUPDPortLabel
        '
        Me.NetUPDPortLabel.AutoSize = True
        Me.NetUPDPortLabel.Enabled = False
        Me.NetUPDPortLabel.Location = New System.Drawing.Point(10, 153)
        Me.NetUPDPortLabel.Name = "NetUPDPortLabel"
        Me.NetUPDPortLabel.Size = New System.Drawing.Size(55, 13)
        Me.NetUPDPortLabel.TabIndex = 3
        Me.NetUPDPortLabel.Text = "UDP Port:"
        '
        'NetUPDPort
        '
        Me.NetUPDPort.Enabled = False
        Me.NetUPDPort.Location = New System.Drawing.Point(93, 150)
        Me.NetUPDPort.Name = "NetUPDPort"
        Me.NetUPDPort.Size = New System.Drawing.Size(133, 20)
        Me.NetUPDPort.TabIndex = 0
        Me.ControlToolTip.SetToolTip(Me.NetUPDPort, "This option is only used if Enable UDP Tunnel is marked." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This selects the port b" & _
        "y which the emulator is going to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "connect to the network. The default value is t" & _
        "he recommended.")
        '
        'NetRouterConfig
        '
        Me.NetRouterConfig.Controls.Add(Me.NetServerPortsLabel)
        Me.NetRouterConfig.Controls.Add(Me.NetFTPPortsLabel)
        Me.NetRouterConfig.Controls.Add(Me.NetServerPorts)
        Me.NetRouterConfig.Controls.Add(Me.NetFTPPorts)
        Me.NetRouterConfig.Location = New System.Drawing.Point(10, 180)
        Me.NetRouterConfig.Name = "NetRouterConfig"
        Me.NetRouterConfig.Size = New System.Drawing.Size(367, 60)
        Me.NetRouterConfig.TabIndex = 2
        '
        'NetServerPortsLabel
        '
        Me.NetServerPortsLabel.AutoSize = True
        Me.NetServerPortsLabel.Location = New System.Drawing.Point(0, 33)
        Me.NetServerPortsLabel.Name = "NetServerPortsLabel"
        Me.NetServerPortsLabel.Size = New System.Drawing.Size(68, 13)
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
        Me.NetServerPorts.Location = New System.Drawing.Point(83, 30)
        Me.NetServerPorts.Name = "NetServerPorts"
        Me.NetServerPorts.Size = New System.Drawing.Size(133, 20)
        Me.NetServerPorts.TabIndex = 1
        Me.ControlToolTip.SetToolTip(Me.NetServerPorts, resources.GetString("NetServerPorts.ToolTip"))
        '
        'NetFTPPorts
        '
        Me.NetFTPPorts.Location = New System.Drawing.Point(83, 0)
        Me.NetFTPPorts.Name = "NetFTPPorts"
        Me.NetFTPPorts.Size = New System.Drawing.Size(133, 20)
        Me.NetFTPPorts.TabIndex = 0
        Me.ControlToolTip.SetToolTip(Me.NetFTPPorts, resources.GetString("NetFTPPorts.ToolTip"))
        '
        'NetTypeLabel
        '
        Me.NetTypeLabel.AutoSize = True
        Me.NetTypeLabel.Location = New System.Drawing.Point(10, 33)
        Me.NetTypeLabel.Name = "NetTypeLabel"
        Me.NetTypeLabel.Size = New System.Drawing.Size(77, 13)
        Me.NetTypeLabel.TabIndex = 1
        Me.NetTypeLabel.Text = "Network Type:"
        '
        'NetType
        '
        Me.NetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetType.FormattingEnabled = True
        Me.NetType.Items.AddRange(New Object() {"Slirp (Virtual Network)", "Router", "None"})
        Me.NetType.Location = New System.Drawing.Point(93, 30)
        Me.NetType.Name = "NetType"
        Me.NetType.Size = New System.Drawing.Size(133, 21)
        Me.NetType.TabIndex = 0
        Me.ControlToolTip.SetToolTip(Me.NetType, resources.GetString("NetType.ToolTip"))
        '
        'NetRouterEnabled
        '
        Me.NetRouterEnabled.AutoSize = True
        Me.NetRouterEnabled.Location = New System.Drawing.Point(13, 90)
        Me.NetRouterEnabled.Name = "NetRouterEnabled"
        Me.NetRouterEnabled.Size = New System.Drawing.Size(176, 17)
        Me.NetRouterEnabled.TabIndex = 5
        Me.NetRouterEnabled.Text = "Enable router module of Basilisk"
        Me.NetRouterEnabled.UseVisualStyleBackColor = True
        '
        'SerialFrame
        '
        Me.SerialFrame.Controls.Add(Me.SBFilePath)
        Me.SerialFrame.Controls.Add(Me.SBFileBrowse)
        Me.SerialFrame.Controls.Add(Me.SAFilePath)
        Me.SerialFrame.Controls.Add(Me.SAFileBrowse)
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
        'SBFilePath
        '
        Me.SBFilePath.Location = New System.Drawing.Point(9, 103)
        Me.SBFilePath.Name = "SBFilePath"
        Me.SBFilePath.Size = New System.Drawing.Size(271, 20)
        Me.SBFilePath.TabIndex = 7
        '
        'SBFileBrowse
        '
        Me.SBFileBrowse.Location = New System.Drawing.Point(286, 101)
        Me.SBFileBrowse.Name = "SBFileBrowse"
        Me.SBFileBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SBFileBrowse.TabIndex = 6
        Me.SBFileBrowse.Text = "Browse"
        Me.SBFileBrowse.UseVisualStyleBackColor = True
        '
        'SAFilePath
        '
        Me.SAFilePath.Location = New System.Drawing.Point(9, 44)
        Me.SAFilePath.Name = "SAFilePath"
        Me.SAFilePath.Size = New System.Drawing.Size(271, 20)
        Me.SAFilePath.TabIndex = 5
        '
        'SAFileBrowse
        '
        Me.SAFileBrowse.Location = New System.Drawing.Point(286, 42)
        Me.SAFileBrowse.Name = "SAFileBrowse"
        Me.SAFileBrowse.Size = New System.Drawing.Size(75, 23)
        Me.SAFileBrowse.TabIndex = 4
        Me.SAFileBrowse.Text = "Browse"
        Me.SAFileBrowse.UseVisualStyleBackColor = True
        '
        'SerialBLabel
        '
        Me.SerialBLabel.AutoSize = True
        Me.SerialBLabel.Location = New System.Drawing.Point(6, 76)
        Me.SerialBLabel.Name = "SerialBLabel"
        Me.SerialBLabel.Size = New System.Drawing.Size(64, 13)
        Me.SerialBLabel.TabIndex = 3
        Me.SerialBLabel.Text = "Serial Port 2"
        '
        'SerialALabel
        '
        Me.SerialALabel.AutoSize = True
        Me.SerialALabel.Location = New System.Drawing.Point(6, 20)
        Me.SerialALabel.Name = "SerialALabel"
        Me.SerialALabel.Size = New System.Drawing.Size(64, 13)
        Me.SerialALabel.TabIndex = 2
        Me.SerialALabel.Text = "Serial Port 1"
        '
        'SerialB
        '
        Me.SerialB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialB.FormattingEnabled = True
        Me.SerialB.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "File"})
        Me.SerialB.Location = New System.Drawing.Point(76, 73)
        Me.SerialB.Name = "SerialB"
        Me.SerialB.Size = New System.Drawing.Size(80, 21)
        Me.SerialB.TabIndex = 1
        '
        'SerialA
        '
        Me.SerialA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialA.FormattingEnabled = True
        Me.SerialA.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "File"})
        Me.SerialA.Location = New System.Drawing.Point(76, 17)
        Me.SerialA.Name = "SerialA"
        Me.SerialA.Size = New System.Drawing.Size(80, 21)
        Me.SerialA.TabIndex = 0
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
        Me.DriveBootCD.Size = New System.Drawing.Size(88, 17)
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
        Me.DriveBootDisk.Size = New System.Drawing.Size(92, 17)
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
        Me.ControlToolTip.SetToolTip(Me.DriveSetBootDrive, "Set the selected disk as the boot drive." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This only works on hard disks")
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
        'DriveListContext
        '
        Me.DriveListContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DriveContxAddDisk, Me.DriveContxAddCD, Me.DriveContxAddFloppy, Me.DriveContextBar0, Me.DriveContxSetAsBoot, Me.DriveContextBar1, Me.DriveContxRemoveDrive})
        Me.DriveListContext.Name = "DriveListContext"
        Me.DriveListContext.Size = New System.Drawing.Size(240, 126)
        '
        'DriveContxAddDisk
        '
        Me.DriveContxAddDisk.Name = "DriveContxAddDisk"
        Me.DriveContxAddDisk.Size = New System.Drawing.Size(239, 22)
        Me.DriveContxAddDisk.Text = "Add disk image"
        '
        'DriveContxAddCD
        '
        Me.DriveContxAddCD.Name = "DriveContxAddCD"
        Me.DriveContxAddCD.Size = New System.Drawing.Size(239, 22)
        Me.DriveContxAddCD.Text = "Add CD image"
        '
        'DriveContxAddFloppy
        '
        Me.DriveContxAddFloppy.Name = "DriveContxAddFloppy"
        Me.DriveContxAddFloppy.Size = New System.Drawing.Size(239, 22)
        Me.DriveContxAddFloppy.Text = "Add floppy image"
        '
        'DriveContextBar0
        '
        Me.DriveContextBar0.Name = "DriveContextBar0"
        Me.DriveContextBar0.Size = New System.Drawing.Size(236, 6)
        '
        'DriveContxSetAsBoot
        '
        Me.DriveContxSetAsBoot.Enabled = False
        Me.DriveContxSetAsBoot.Name = "DriveContxSetAsBoot"
        Me.DriveContxSetAsBoot.Size = New System.Drawing.Size(239, 22)
        Me.DriveContxSetAsBoot.Text = "Set as boot drive"
        '
        'DriveContextBar1
        '
        Me.DriveContextBar1.Name = "DriveContextBar1"
        Me.DriveContextBar1.Size = New System.Drawing.Size(236, 6)
        '
        'DriveContxRemoveDrive
        '
        Me.DriveContxRemoveDrive.Enabled = False
        Me.DriveContxRemoveDrive.Name = "DriveContxRemoveDrive"
        Me.DriveContxRemoveDrive.Size = New System.Drawing.Size(239, 22)
        Me.DriveContxRemoveDrive.Text = "Remove selected drive from list"
        '
        'DriveIcons
        '
        Me.DriveIcons.ImageStream = CType(resources.GetObject("DriveIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DriveIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.DriveIcons.Images.SetKeyName(0, "Floppy")
        Me.DriveIcons.Images.SetKeyName(1, "Disc")
        Me.DriveIcons.Images.SetKeyName(2, "Drive")
        '
        'MiscFrame
        '
        Me.MiscFrame.Controls.Add(Me.MiscIdleWait)
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
        'MiscIdleWait
        '
        Me.MiscIdleWait.AutoSize = True
        Me.MiscIdleWait.Location = New System.Drawing.Point(12, 120)
        Me.MiscIdleWait.Name = "MiscIdleWait"
        Me.MiscIdleWait.Size = New System.Drawing.Size(144, 17)
        Me.MiscIdleWait.TabIndex = 7
        Me.MiscIdleWait.Text = "Don't use CPU when idle"
        Me.MiscIdleWait.UseVisualStyleBackColor = True
        '
        'MiscIgnoreSegv
        '
        Me.MiscIgnoreSegv.AutoSize = True
        Me.MiscIgnoreSegv.Location = New System.Drawing.Point(12, 90)
        Me.MiscIgnoreSegv.Name = "MiscIgnoreSegv"
        Me.MiscIgnoreSegv.Size = New System.Drawing.Size(175, 17)
        Me.MiscIgnoreSegv.TabIndex = 6
        Me.MiscIgnoreSegv.Text = "Ignore Illegal Memory Accesses"
        Me.MiscIgnoreSegv.UseVisualStyleBackColor = True
        '
        'MiscEnableGUI
        '
        Me.MiscEnableGUI.AutoSize = True
        Me.MiscEnableGUI.Location = New System.Drawing.Point(12, 60)
        Me.MiscEnableGUI.Name = "MiscEnableGUI"
        Me.MiscEnableGUI.Size = New System.Drawing.Size(81, 17)
        Me.MiscEnableGUI.TabIndex = 5
        Me.MiscEnableGUI.Text = "Enable GUI"
        Me.ControlToolTip.SetToolTip(Me.MiscEnableGUI, "Note that this option is useless in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows and is kept only for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "multiplataform" & _
        " compatibility")
        Me.MiscEnableGUI.UseVisualStyleBackColor = True
        '
        'MiscROM
        '
        Me.MiscROM.Location = New System.Drawing.Point(72, 30)
        Me.MiscROM.Name = "MiscROM"
        Me.MiscROM.Size = New System.Drawing.Size(208, 20)
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
        Me.MiscROMLabel.Size = New System.Drawing.Size(35, 13)
        Me.MiscROMLabel.TabIndex = 0
        Me.MiscROMLabel.Text = "ROM:"
        '
        'MacNameFrame
        '
        Me.MacNameFrame.Controls.Add(Me.MacName)
        Me.MacNameFrame.Controls.Add(Me.MacNameLabel)
        Me.MacNameFrame.Location = New System.Drawing.Point(0, 3)
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
        Me.MacName.Size = New System.Drawing.Size(347, 20)
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
        Me.ExtFSDrivesLabel.Size = New System.Drawing.Size(178, 13)
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
        Me.ExtFSDrives.Size = New System.Drawing.Size(347, 184)
        Me.ExtFSDrives.TabIndex = 9
        Me.ExtFSDrives.Visible = False
        '
        'ExtFSEnable
        '
        Me.ExtFSEnable.AutoSize = True
        Me.ExtFSEnable.Location = New System.Drawing.Point(10, 30)
        Me.ExtFSEnable.Name = "ExtFSEnable"
        Me.ExtFSEnable.Size = New System.Drawing.Size(153, 17)
        Me.ExtFSEnable.TabIndex = 8
        Me.ExtFSEnable.Text = "Enable External FileSystem"
        Me.ControlToolTip.SetToolTip(Me.ExtFSEnable, "Enables the access to your host drives. To access them," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "just boot into MacOS and" & _
        " double click the 'My PC' icon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that appears in the desktop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not confuse wi" & _
        "th Linux's Extensible FileSystem (Ext)")
        Me.ExtFSEnable.UseVisualStyleBackColor = True
        '
        'JITFrame
        '
        Me.JITFrame.Controls.Add(Me.JITDebugExtFS)
        Me.JITFrame.Controls.Add(Me.JITCacheSizeLabel)
        Me.JITFrame.Controls.Add(Me.JITDebug)
        Me.JITFrame.Controls.Add(Me.JITDontUseInfo)
        Me.JITFrame.Controls.Add(Me.JITLazyFlush)
        Me.JITFrame.Controls.Add(Me.JITFPU)
        Me.JITFrame.Controls.Add(Me.JITInLine)
        Me.JITFrame.Controls.Add(Me.JITEnable)
        Me.JITFrame.Controls.Add(Me.JITCacheSize)
        Me.JITFrame.Location = New System.Drawing.Point(0, 0)
        Me.JITFrame.Name = "JITFrame"
        Me.JITFrame.Size = New System.Drawing.Size(367, 279)
        Me.JITFrame.TabIndex = 10
        Me.JITFrame.TabStop = False
        Me.JITFrame.Text = "JIT and debugging options"
        '
        'JITDebugExtFS
        '
        Me.JITDebugExtFS.AutoSize = True
        Me.JITDebugExtFS.Location = New System.Drawing.Point(10, 200)
        Me.JITDebugExtFS.Name = "JITDebugExtFS"
        Me.JITDebugExtFS.Size = New System.Drawing.Size(152, 17)
        Me.JITDebugExtFS.TabIndex = 8
        Me.JITDebugExtFS.Text = "Debug External FileSystem"
        Me.ControlToolTip.SetToolTip(Me.JITDebugExtFS, "Debug the ExtFS driver. This is only intended to use the output" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to perfection th" & _
        "e code, so it's not useful unless you are a programmer")
        Me.JITDebugExtFS.UseVisualStyleBackColor = True
        '
        'JITCacheSizeLabel
        '
        Me.JITCacheSizeLabel.AutoSize = True
        Me.JITCacheSizeLabel.Location = New System.Drawing.Point(9, 83)
        Me.JITCacheSizeLabel.Name = "JITCacheSizeLabel"
        Me.JITCacheSizeLabel.Size = New System.Drawing.Size(137, 13)
        Me.JITCacheSizeLabel.TabIndex = 7
        Me.JITCacheSizeLabel.Text = "JIT Translation Cache Size:"
        '
        'JITDebug
        '
        Me.JITDebug.AutoSize = True
        Me.JITDebug.Location = New System.Drawing.Point(10, 170)
        Me.JITDebug.Name = "JITDebug"
        Me.JITDebug.Size = New System.Drawing.Size(119, 17)
        Me.JITDebug.TabIndex = 6
        Me.JITDebug.Text = "Debug JIT Compiler"
        Me.ControlToolTip.SetToolTip(Me.JITDebug, "Sets the JIT compiler in debug mode. This is used to perfection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the emulation on" & _
        " the JIT side. This is only used by programmers")
        Me.JITDebug.UseVisualStyleBackColor = True
        '
        'JITDontUseInfo
        '
        Me.JITDontUseInfo.AutoSize = True
        Me.JITDontUseInfo.Location = New System.Drawing.Point(5, 263)
        Me.JITDontUseInfo.Name = "JITDontUseInfo"
        Me.JITDontUseInfo.Size = New System.Drawing.Size(357, 13)
        Me.JITDontUseInfo.TabIndex = 5
        Me.JITDontUseInfo.Text = "These options shouldn't be changed unless you know what are you doing."
        '
        'JITLazyFlush
        '
        Me.JITLazyFlush.AutoSize = True
        Me.JITLazyFlush.Location = New System.Drawing.Point(10, 110)
        Me.JITLazyFlush.Name = "JITLazyFlush"
        Me.JITLazyFlush.Size = New System.Drawing.Size(232, 17)
        Me.JITLazyFlush.TabIndex = 3
        Me.JITLazyFlush.Text = "Enable lazy invalidation of translation cache"
        Me.JITLazyFlush.UseVisualStyleBackColor = True
        '
        'JITFPU
        '
        Me.JITFPU.AutoSize = True
        Me.JITFPU.Location = New System.Drawing.Point(10, 50)
        Me.JITFPU.Name = "JITFPU"
        Me.JITFPU.Size = New System.Drawing.Size(143, 17)
        Me.JITFPU.TabIndex = 2
        Me.JITFPU.Text = "Compile FPU instructions"
        Me.ControlToolTip.SetToolTip(Me.JITFPU, resources.GetString("JITFPU.ToolTip"))
        Me.JITFPU.UseVisualStyleBackColor = True
        '
        'JITInLine
        '
        Me.JITInLine.AutoSize = True
        Me.JITInLine.Location = New System.Drawing.Point(10, 140)
        Me.JITInLine.Name = "JITInLine"
        Me.JITInLine.Size = New System.Drawing.Size(213, 17)
        Me.JITInLine.TabIndex = 1
        Me.JITInLine.Text = "Translate throught constant inline jumps"
        Me.JITInLine.UseVisualStyleBackColor = True
        '
        'JITEnable
        '
        Me.JITEnable.AutoSize = True
        Me.JITEnable.Location = New System.Drawing.Point(10, 20)
        Me.JITEnable.Name = "JITEnable"
        Me.JITEnable.Size = New System.Drawing.Size(120, 17)
        Me.JITEnable.TabIndex = 0
        Me.JITEnable.Text = "Enable JIT Compiler"
        Me.ControlToolTip.SetToolTip(Me.JITEnable, "Enables the Just In Time compiler. This makes the emulation a bit faster")
        Me.JITEnable.UseVisualStyleBackColor = True
        '
        'JITCacheSize
        '
        Me.JITCacheSize.FormattingEnabled = True
        Me.JITCacheSize.Items.AddRange(New Object() {"2048", "4096", "8192", "16384"})
        Me.JITCacheSize.Location = New System.Drawing.Point(152, 80)
        Me.JITCacheSize.Name = "JITCacheSize"
        Me.JITCacheSize.Size = New System.Drawing.Size(90, 21)
        Me.JITCacheSize.TabIndex = 4
        Me.ControlToolTip.SetToolTip(Me.JITCacheSize, resources.GetString("JITCacheSize.ToolTip"))
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
        Me.InputMouseWheelLines.Size = New System.Drawing.Size(54, 20)
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
        Me.InputKeyCodesPath.Size = New System.Drawing.Size(230, 20)
        Me.InputKeyCodesPath.TabIndex = 0
        '
        'InputKeycodesEnable
        '
        Me.InputKeycodesEnable.AutoSize = True
        Me.InputKeycodesEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InputKeycodesEnable.Location = New System.Drawing.Point(8, 129)
        Me.InputKeycodesEnable.Name = "InputKeycodesEnable"
        Me.InputKeycodesEnable.Size = New System.Drawing.Size(124, 17)
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
        Me.InputEmuKbdTypeLabel.Size = New System.Drawing.Size(82, 13)
        Me.InputEmuKbdTypeLabel.TabIndex = 0
        Me.InputEmuKbdTypeLabel.Text = "Keyboard Type:"
        '
        'MiscHwFrame
        '
        Me.MiscHwFrame.Controls.Add(Me.MiscHwSound)
        Me.MiscHwFrame.Controls.Add(Me.MiscHwCPU)
        Me.MiscHwFrame.Controls.Add(Me.MiscHwFPU)
        Me.MiscHwFrame.Controls.Add(Me.MiscHwModelLabel)
        Me.MiscHwFrame.Controls.Add(Me.MiscHwModel)
        Me.MiscHwFrame.Controls.Add(Me.MiscHwCD)
        Me.MiscHwFrame.Controls.Add(Me.MiscHwCPULabel)
        Me.MiscHwFrame.Location = New System.Drawing.Point(0, 0)
        Me.MiscHwFrame.Name = "MiscHwFrame"
        Me.MiscHwFrame.Size = New System.Drawing.Size(367, 279)
        Me.MiscHwFrame.TabIndex = 9
        Me.MiscHwFrame.TabStop = False
        Me.MiscHwFrame.Text = "Miscelaneous Mac Hardware"
        '
        'MiscHwSound
        '
        Me.MiscHwSound.AutoSize = True
        Me.MiscHwSound.Location = New System.Drawing.Point(228, 101)
        Me.MiscHwSound.Name = "MiscHwSound"
        Me.MiscHwSound.Size = New System.Drawing.Size(91, 17)
        Me.MiscHwSound.TabIndex = 5
        Me.MiscHwSound.Text = "Enable sound"
        Me.MiscHwSound.UseVisualStyleBackColor = True
        '
        'MiscHwCPU
        '
        Me.MiscHwCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MiscHwCPU.FormattingEnabled = True
        Me.MiscHwCPU.Items.AddRange(New Object() {"Motorola 68020", "Motorola 68030", "Motorola 68040"})
        Me.MiscHwCPU.Location = New System.Drawing.Point(80, 58)
        Me.MiscHwCPU.Name = "MiscHwCPU"
        Me.MiscHwCPU.Size = New System.Drawing.Size(127, 21)
        Me.MiscHwCPU.TabIndex = 3
        '
        'MiscHwFPU
        '
        Me.MiscHwFPU.AutoSize = True
        Me.MiscHwFPU.Location = New System.Drawing.Point(228, 60)
        Me.MiscHwFPU.Name = "MiscHwFPU"
        Me.MiscHwFPU.Size = New System.Drawing.Size(83, 17)
        Me.MiscHwFPU.TabIndex = 2
        Me.MiscHwFPU.Text = "Enable FPU"
        Me.ControlToolTip.SetToolTip(Me.MiscHwFPU, resources.GetString("MiscHwFPU.ToolTip"))
        Me.MiscHwFPU.UseVisualStyleBackColor = True
        '
        'MiscHwModelLabel
        '
        Me.MiscHwModelLabel.AutoSize = True
        Me.MiscHwModelLabel.Location = New System.Drawing.Point(7, 27)
        Me.MiscHwModelLabel.Name = "MiscHwModelLabel"
        Me.MiscHwModelLabel.Size = New System.Drawing.Size(63, 13)
        Me.MiscHwModelLabel.TabIndex = 1
        Me.MiscHwModelLabel.Text = "Mac Model:"
        '
        'MiscHwModel
        '
        Me.MiscHwModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MiscHwModel.FormattingEnabled = True
        Me.MiscHwModel.Items.AddRange(New Object() {"Mac IIci (System 7)", "Quadra 900 (Mac OS 8)"})
        Me.MiscHwModel.Location = New System.Drawing.Point(80, 24)
        Me.MiscHwModel.Name = "MiscHwModel"
        Me.MiscHwModel.Size = New System.Drawing.Size(127, 21)
        Me.MiscHwModel.TabIndex = 0
        '
        'MiscHwCD
        '
        Me.MiscHwCD.AutoSize = True
        Me.MiscHwCD.Location = New System.Drawing.Point(10, 101)
        Me.MiscHwCD.Name = "MiscHwCD"
        Me.MiscHwCD.Size = New System.Drawing.Size(143, 17)
        Me.MiscHwCD.TabIndex = 6
        Me.MiscHwCD.Text = "Enable CD-ROM support"
        Me.MiscHwCD.UseVisualStyleBackColor = True
        '
        'MiscHwCPULabel
        '
        Me.MiscHwCPULabel.AutoSize = True
        Me.MiscHwCPULabel.Location = New System.Drawing.Point(9, 61)
        Me.MiscHwCPULabel.Name = "MiscHwCPULabel"
        Me.MiscHwCPULabel.Size = New System.Drawing.Size(32, 13)
        Me.MiscHwCPULabel.TabIndex = 4
        Me.MiscHwCPULabel.Text = "CPU:"
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
        Me.MemoryBoxMBLabel.Size = New System.Drawing.Size(25, 13)
        Me.MemoryBoxMBLabel.TabIndex = 3
        Me.MemoryBoxMBLabel.Text = "MiB"
        Me.ControlToolTip.SetToolTip(Me.MemoryBoxMBLabel, "Windows uses MiB, but refers to them as MB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A MiB (Mebibyte) is equal to 1024 KB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A MB (Megabyte) is equal to 1000 KB")
        '
        'MemoryBoxLabel
        '
        Me.MemoryBoxLabel.AutoSize = True
        Me.MemoryBoxLabel.Location = New System.Drawing.Point(6, 26)
        Me.MemoryBoxLabel.Name = "MemoryBoxLabel"
        Me.MemoryBoxLabel.Size = New System.Drawing.Size(209, 13)
        Me.MemoryBoxLabel.TabIndex = 2
        Me.MemoryBoxLabel.Text = "Select how much RAM to give to this Mac:"
        '
        'MemoryBox
        '
        Me.MemoryBox.Location = New System.Drawing.Point(286, 23)
        Me.MemoryBox.Name = "MemoryBox"
        Me.MemoryBox.Size = New System.Drawing.Size(46, 20)
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
        'OptionList
        '
        Me.OptionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Options, Me.Value})
        Me.OptionList.FullRowSelect = True
        Me.OptionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13})
        Me.OptionList.Location = New System.Drawing.Point(12, 11)
        Me.OptionList.Name = "OptionList"
        Me.OptionList.Size = New System.Drawing.Size(353, 376)
        Me.OptionList.TabIndex = 24
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
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(665, 366)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 22)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(585, 366)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 22)
        Me.cmdOK.TabIndex = 22
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'ControlToolTip
        '
        Me.ControlToolTip.AutoPopDelay = 10000
        Me.ControlToolTip.InitialDelay = 500
        Me.ControlToolTip.ReshowDelay = 100
        '
        'NetMulticastModeLabel
        '
        Me.NetMulticastModeLabel.AutoSize = True
        Me.NetMulticastModeLabel.Location = New System.Drawing.Point(10, 243)
        Me.NetMulticastModeLabel.Name = "NetMulticastModeLabel"
        Me.NetMulticastModeLabel.Size = New System.Drawing.Size(81, 13)
        Me.NetMulticastModeLabel.TabIndex = 6
        Me.NetMulticastModeLabel.Text = "Multicast mode:"
        '
        'NetMulticastMode
        '
        Me.NetMulticastMode.Location = New System.Drawing.Point(93, 240)
        Me.NetMulticastMode.Name = "NetMulticastMode"
        Me.NetMulticastMode.Size = New System.Drawing.Size(133, 20)
        Me.NetMulticastMode.TabIndex = 7
        '
        'frmSettingsBasiliskVM
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(750, 400)
        Me.Controls.Add(Me.OptionPanel)
        Me.Controls.Add(Me.OptionList)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettingsBasiliskVM"
        Me.Text = "Settings for %s"
        Me.OptionPanel.ResumeLayout(False)
        Me.IconFrame.ResumeLayout(False)
        Me.IconFrame.PerformLayout()
        Me.ScreenFrame.ResumeLayout(False)
        Me.ScreenFrame.PerformLayout()
        Me.NetworkFrame.ResumeLayout(False)
        Me.NetworkFrame.PerformLayout()
        Me.NetRouterConfig.ResumeLayout(False)
        Me.NetRouterConfig.PerformLayout()
        Me.SerialFrame.ResumeLayout(False)
        Me.SerialFrame.PerformLayout()
        Me.EMCFrame.ResumeLayout(False)
        Me.DriveFrame.ResumeLayout(False)
        Me.DriveFrame.PerformLayout()
        Me.DriveListContext.ResumeLayout(False)
        Me.MiscFrame.ResumeLayout(False)
        Me.MiscFrame.PerformLayout()
        Me.MacNameFrame.ResumeLayout(False)
        Me.MacNameFrame.PerformLayout()
        Me.ExtFSFrame.ResumeLayout(False)
        Me.ExtFSFrame.PerformLayout()
        Me.JITFrame.ResumeLayout(False)
        Me.JITFrame.PerformLayout()
        Me.InputFrame.ResumeLayout(False)
        Me.InputFrame.PerformLayout()
        CType(Me.InputMouseWheelLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputKeyCodesPathPanel.ResumeLayout(False)
        Me.InputKeyCodesPathPanel.PerformLayout()
        Me.MiscHwFrame.ResumeLayout(False)
        Me.MiscHwFrame.PerformLayout()
        Me.MemoryFrame.ResumeLayout(False)
        Me.MemoryFrame.PerformLayout()
        CType(Me.MemoryTracker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OptionPanel As System.Windows.Forms.Panel
    Friend WithEvents SerialFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MiscFrame As System.Windows.Forms.GroupBox
    Friend WithEvents NetworkFrame As System.Windows.Forms.GroupBox
    Friend WithEvents InputFrame As System.Windows.Forms.GroupBox
    Friend WithEvents ScreenFrame As System.Windows.Forms.GroupBox
    Friend WithEvents IconFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DriveFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MemoryFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MacNameFrame As System.Windows.Forms.GroupBox
    Friend WithEvents OptionList As System.Windows.Forms.ListView
    Friend WithEvents Options As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents MiscHwFrame As System.Windows.Forms.GroupBox
    Friend WithEvents ScrResLabel As System.Windows.Forms.Label
    Friend WithEvents ScrResY As System.Windows.Forms.ComboBox
    Friend WithEvents ScrResX As System.Windows.Forms.ComboBox
    Friend WithEvents ScrRefreshLabel As System.Windows.Forms.Label
    Friend WithEvents ScrRefresh As System.Windows.Forms.ComboBox
    Friend WithEvents ScrResCust As System.Windows.Forms.CheckBox
    Friend WithEvents ScrModeLabel As System.Windows.Forms.Label
    Friend WithEvents ScrMode As System.Windows.Forms.ComboBox
    Friend WithEvents SerialALabel As System.Windows.Forms.Label
    Friend WithEvents SerialB As System.Windows.Forms.ComboBox
    Friend WithEvents SerialA As System.Windows.Forms.ComboBox
    Friend WithEvents SerialBLabel As System.Windows.Forms.Label
    Friend WithEvents SBFilePath As System.Windows.Forms.TextBox
    Friend WithEvents SBFileBrowse As System.Windows.Forms.Button
    Friend WithEvents SAFilePath As System.Windows.Forms.TextBox
    Friend WithEvents SAFileBrowse As System.Windows.Forms.Button
    Friend WithEvents NetTypeLabel As System.Windows.Forms.Label
    Friend WithEvents NetType As System.Windows.Forms.ComboBox
    Friend WithEvents NetRouterConfig As System.Windows.Forms.Panel
    Friend WithEvents NetUPDPort As System.Windows.Forms.TextBox
    Friend WithEvents NetUPDPortLabel As System.Windows.Forms.Label
    Friend WithEvents MiscROM As System.Windows.Forms.TextBox
    Friend WithEvents MiscROMBrowse As System.Windows.Forms.Button
    Friend WithEvents MiscROMLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryBox As System.Windows.Forms.TextBox
    Friend WithEvents MemoryTracker As System.Windows.Forms.TrackBar
    Friend WithEvents MemoryBoxLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryBoxMBLabel As System.Windows.Forms.Label
    Friend WithEvents ControlToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MiscHwCPULabel As System.Windows.Forms.Label
    Friend WithEvents MiscHwCPU As System.Windows.Forms.ComboBox
    Friend WithEvents MiscHwFPU As System.Windows.Forms.CheckBox
    Friend WithEvents MiscHwModelLabel As System.Windows.Forms.Label
    Friend WithEvents MiscHwModel As System.Windows.Forms.ComboBox
    Friend WithEvents MiscHwSound As System.Windows.Forms.CheckBox
    Friend WithEvents MiscHwCD As System.Windows.Forms.CheckBox
    Friend WithEvents MiscEnableGUI As System.Windows.Forms.CheckBox
    Friend WithEvents JITFrame As System.Windows.Forms.GroupBox
    Friend WithEvents JITLazyFlush As System.Windows.Forms.CheckBox
    Friend WithEvents JITFPU As System.Windows.Forms.CheckBox
    Friend WithEvents JITInLine As System.Windows.Forms.CheckBox
    Friend WithEvents JITEnable As System.Windows.Forms.CheckBox
    Friend WithEvents JITDebug As System.Windows.Forms.CheckBox
    Friend WithEvents JITDontUseInfo As System.Windows.Forms.Label
    Friend WithEvents JITCacheSize As System.Windows.Forms.ComboBox
    Friend WithEvents JITCacheSizeLabel As System.Windows.Forms.Label
    Friend WithEvents DriveList As System.Windows.Forms.ListView
    Friend WithEvents DriveIcons As System.Windows.Forms.ImageList
    Friend WithEvents DriveListContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DriveContxAddDisk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriveContxAddCD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriveContxAddFloppy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriveContxSetAsBoot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriveContxRemoveDrive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriveLCPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveLCType As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveLCBootMark As System.Windows.Forms.ColumnHeader
    Friend WithEvents DriveRemove As System.Windows.Forms.Button
    Friend WithEvents DriveAddFloppy As System.Windows.Forms.Button
    Friend WithEvents DriveAddCD As System.Windows.Forms.Button
    Friend WithEvents DriveAddDisk As System.Windows.Forms.Button
    Friend WithEvents NetEnableUDP As System.Windows.Forms.CheckBox
    Friend WithEvents NetServerPortsLabel As System.Windows.Forms.Label
    Friend WithEvents NetFTPPortsLabel As System.Windows.Forms.Label
    Friend WithEvents NetServerPorts As System.Windows.Forms.TextBox
    Friend WithEvents NetFTPPorts As System.Windows.Forms.TextBox
    Friend WithEvents InputEmuKbdType As System.Windows.Forms.ComboBox
    Friend WithEvents InputEmuKbdTypeLabel As System.Windows.Forms.Label
    Friend WithEvents InputKeycodesEnable As System.Windows.Forms.CheckBox
    Friend WithEvents InputKeyCodesPathPanel As System.Windows.Forms.Panel
    Friend WithEvents InputKeyCodesPathLabel As System.Windows.Forms.Label
    Friend WithEvents InputKeyCodesPath As System.Windows.Forms.TextBox
    Friend WithEvents InputMouseWheelMode As System.Windows.Forms.ComboBox
    Friend WithEvents InputMouseWheelModeLabel As System.Windows.Forms.Label
    Friend WithEvents InputMouseWheelLines As System.Windows.Forms.NumericUpDown
    Friend WithEvents DriveSetBootDrive As System.Windows.Forms.Button
    Friend WithEvents MiscIgnoreSegv As System.Windows.Forms.CheckBox
    Friend WithEvents MiscIdleWait As System.Windows.Forms.CheckBox
    Friend WithEvents JITDebugExtFS As System.Windows.Forms.CheckBox
    Friend WithEvents ExtFSFrame As System.Windows.Forms.GroupBox
    Friend WithEvents ExtFSEnable As System.Windows.Forms.CheckBox
    Friend WithEvents ExtFSDrives As System.Windows.Forms.CheckedListBox
    Friend WithEvents ExtFSDrivesLabel As System.Windows.Forms.Label
    Friend WithEvents MacName As System.Windows.Forms.TextBox
    Friend WithEvents MacNameLabel As System.Windows.Forms.Label
    Friend WithEvents DriveBootCD As System.Windows.Forms.RadioButton
    Friend WithEvents DriveBootDisk As System.Windows.Forms.RadioButton
    Friend WithEvents DrivePollMedia As System.Windows.Forms.CheckBox
    Friend WithEvents NetPermPhysicalAddress As System.Windows.Forms.CheckBox
    Friend WithEvents EMCFrame As System.Windows.Forms.GroupBox
    Friend WithEvents EMCEditor As System.Windows.Forms.ListView
    Friend WithEvents EMCKeywordValueColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents NetRouterEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents IconInfo As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents DriveContextBar0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DriveContextBar1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NetMulticastMode As System.Windows.Forms.TextBox
    Friend WithEvents NetMulticastModeLabel As System.Windows.Forms.Label
End Class
