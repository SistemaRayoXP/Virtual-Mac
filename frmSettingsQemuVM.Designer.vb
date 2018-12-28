<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsQemuVM
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
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Name", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Icon", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Memory")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Drives", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Network", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Screen", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mouse and keyboard")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Serial ports")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Miscelaneous")
        Me.BrowseIcon = New System.Windows.Forms.Button
        Me.OptionPanel = New System.Windows.Forms.Panel
        Me.SerialFrame = New System.Windows.Forms.GroupBox
        Me.PrinterPort = New System.Windows.Forms.ComboBox
        Me.PrinterPortLabel = New System.Windows.Forms.Label
        Me.PrinterOutputFile = New System.Windows.Forms.Panel
        Me.PrinterOutputPath = New System.Windows.Forms.TextBox
        Me.BrowsePOFile = New System.Windows.Forms.Button
        Me.ModemPort = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ModemOutputFile = New System.Windows.Forms.Panel
        Me.ModemOutputPath = New System.Windows.Forms.TextBox
        Me.BrowseMOFile = New System.Windows.Forms.Button
        Me.MiscFrame = New System.Windows.Forms.GroupBox
        Me.IgnoreIllegal = New System.Windows.Forms.CheckBox
        Me.IdleCPU = New System.Windows.Forms.CheckBox
        Me.Enable68kEmu = New System.Windows.Forms.CheckBox
        Me.EnableJIT = New System.Windows.Forms.CheckBox
        Me.NetworkFrame = New System.Windows.Forms.GroupBox
        Me.NetInterfaceLabel = New System.Windows.Forms.Label
        Me.NetInterface = New System.Windows.Forms.ComboBox
        Me.RouterPanel = New System.Windows.Forms.Panel
        Me.FTPPortsLabel = New System.Windows.Forms.Label
        Me.ServerPortsLabel = New System.Windows.Forms.Label
        Me.FTPPorts = New System.Windows.Forms.TextBox
        Me.ServerPorts = New System.Windows.Forms.TextBox
        Me.InputFrame = New System.Windows.Forms.GroupBox
        Me.KeyboardGroup = New System.Windows.Forms.GroupBox
        Me.KeyCodesPathLabel = New System.Windows.Forms.Label
        Me.KeyCodesPath = New System.Windows.Forms.TextBox
        Me.UseKeycodes = New System.Windows.Forms.CheckBox
        Me.BrowseKeyCodes = New System.Windows.Forms.Button
        Me.MouseGroup = New System.Windows.Forms.GroupBox
        Me.ScrollLinesLabel = New System.Windows.Forms.Label
        Me.WheelFunctionLabel = New System.Windows.Forms.Label
        Me.WheelFunction = New System.Windows.Forms.ComboBox
        Me.ScrollLines = New System.Windows.Forms.NumericUpDown
        Me.ScreenFrame = New System.Windows.Forms.GroupBox
        Me.CustResolution = New System.Windows.Forms.CheckBox
        Me.VMResHeight = New System.Windows.Forms.ComboBox
        Me.VMResWidth = New System.Windows.Forms.ComboBox
        Me.VMResLabel = New System.Windows.Forms.Label
        Me.VMResDef = New System.Windows.Forms.ComboBox
        Me.RefeshRateLabel = New System.Windows.Forms.Label
        Me.RefreshRate = New System.Windows.Forms.ComboBox
        Me.StartModeLabel = New System.Windows.Forms.Label
        Me.StartMode = New System.Windows.Forms.ComboBox
        Me.IconFrame = New System.Windows.Forms.GroupBox
        Me.IconDescription = New System.Windows.Forms.Label
        Me.IconList = New System.Windows.Forms.ListView
        Me.DrivesFrame = New System.Windows.Forms.GroupBox
        Me.DrivesList = New System.Windows.Forms.ListBox
        Me.MoveItemDown = New System.Windows.Forms.Button
        Me.MoveItemUp = New System.Windows.Forms.Button
        Me.AddDisk = New System.Windows.Forms.Button
        Me.AddCD = New System.Windows.Forms.Button
        Me.DeleteItem = New System.Windows.Forms.Button
        Me.MemoryFrame = New System.Windows.Forms.GroupBox
        Me.Memory = New System.Windows.Forms.TextBox
        Me.MegabyteLabel = New System.Windows.Forms.Label
        Me.MemoryLabel = New System.Windows.Forms.Label
        Me.MemorySlider = New System.Windows.Forms.TrackBar
        Me.VMNameFrame = New System.Windows.Forms.GroupBox
        Me.VMNameHelp = New System.Windows.Forms.Label
        Me.VMName = New System.Windows.Forms.TextBox
        Me.OptionList = New System.Windows.Forms.ListView
        Me.Options = New System.Windows.Forms.ColumnHeader
        Me.Value = New System.Windows.Forms.ColumnHeader
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.OptionPanel.SuspendLayout()
        Me.SerialFrame.SuspendLayout()
        Me.PrinterOutputFile.SuspendLayout()
        Me.ModemOutputFile.SuspendLayout()
        Me.MiscFrame.SuspendLayout()
        Me.NetworkFrame.SuspendLayout()
        Me.RouterPanel.SuspendLayout()
        Me.InputFrame.SuspendLayout()
        Me.KeyboardGroup.SuspendLayout()
        Me.MouseGroup.SuspendLayout()
        CType(Me.ScrollLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScreenFrame.SuspendLayout()
        Me.IconFrame.SuspendLayout()
        Me.DrivesFrame.SuspendLayout()
        Me.MemoryFrame.SuspendLayout()
        CType(Me.MemorySlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VMNameFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowseIcon
        '
        Me.BrowseIcon.Location = New System.Drawing.Point(286, 12)
        Me.BrowseIcon.Name = "BrowseIcon"
        Me.BrowseIcon.Size = New System.Drawing.Size(75, 23)
        Me.BrowseIcon.TabIndex = 6
        Me.BrowseIcon.Text = "Browse..."
        Me.BrowseIcon.UseVisualStyleBackColor = True
        '
        'OptionPanel
        '
        Me.OptionPanel.Controls.Add(Me.SerialFrame)
        Me.OptionPanel.Controls.Add(Me.MiscFrame)
        Me.OptionPanel.Controls.Add(Me.NetworkFrame)
        Me.OptionPanel.Controls.Add(Me.InputFrame)
        Me.OptionPanel.Controls.Add(Me.ScreenFrame)
        Me.OptionPanel.Controls.Add(Me.IconFrame)
        Me.OptionPanel.Controls.Add(Me.DrivesFrame)
        Me.OptionPanel.Controls.Add(Me.MemoryFrame)
        Me.OptionPanel.Controls.Add(Me.VMNameFrame)
        Me.OptionPanel.Location = New System.Drawing.Point(371, 1)
        Me.OptionPanel.Name = "OptionPanel"
        Me.OptionPanel.Size = New System.Drawing.Size(373, 294)
        Me.OptionPanel.TabIndex = 29
        '
        'SerialFrame
        '
        Me.SerialFrame.Controls.Add(Me.PrinterPort)
        Me.SerialFrame.Controls.Add(Me.PrinterPortLabel)
        Me.SerialFrame.Controls.Add(Me.PrinterOutputFile)
        Me.SerialFrame.Controls.Add(Me.ModemPort)
        Me.SerialFrame.Controls.Add(Me.Label2)
        Me.SerialFrame.Controls.Add(Me.ModemOutputFile)
        Me.SerialFrame.Location = New System.Drawing.Point(0, 3)
        Me.SerialFrame.Name = "SerialFrame"
        Me.SerialFrame.Size = New System.Drawing.Size(367, 279)
        Me.SerialFrame.TabIndex = 8
        Me.SerialFrame.TabStop = False
        Me.SerialFrame.Text = "Serial ports"
        '
        'PrinterPort
        '
        Me.PrinterPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrinterPort.FormattingEnabled = True
        Me.PrinterPort.Items.AddRange(New Object() {"COM 1", "COM 2", "COM 3", "COM 4", "COM 5", "COM 6", "LPT 1", "LPT 2", "LPT 3", "LPT 4", "LPT 5", "LPT 6", "File"})
        Me.PrinterPort.Location = New System.Drawing.Point(76, 80)
        Me.PrinterPort.Name = "PrinterPort"
        Me.PrinterPort.Size = New System.Drawing.Size(69, 21)
        Me.PrinterPort.TabIndex = 8
        '
        'PrinterPortLabel
        '
        Me.PrinterPortLabel.AutoSize = True
        Me.PrinterPortLabel.Location = New System.Drawing.Point(6, 84)
        Me.PrinterPortLabel.Name = "PrinterPortLabel"
        Me.PrinterPortLabel.Size = New System.Drawing.Size(62, 13)
        Me.PrinterPortLabel.TabIndex = 7
        Me.PrinterPortLabel.Text = "Printer Port:"
        '
        'PrinterOutputFile
        '
        Me.PrinterOutputFile.Controls.Add(Me.PrinterOutputPath)
        Me.PrinterOutputFile.Controls.Add(Me.BrowsePOFile)
        Me.PrinterOutputFile.Location = New System.Drawing.Point(6, 100)
        Me.PrinterOutputFile.Name = "PrinterOutputFile"
        Me.PrinterOutputFile.Size = New System.Drawing.Size(360, 31)
        Me.PrinterOutputFile.TabIndex = 9
        '
        'PrinterOutputPath
        '
        Me.PrinterOutputPath.Location = New System.Drawing.Point(3, 5)
        Me.PrinterOutputPath.Name = "PrinterOutputPath"
        Me.PrinterOutputPath.Size = New System.Drawing.Size(274, 20)
        Me.PrinterOutputPath.TabIndex = 0
        '
        'BrowsePOFile
        '
        Me.BrowsePOFile.Location = New System.Drawing.Point(283, 4)
        Me.BrowsePOFile.Name = "BrowsePOFile"
        Me.BrowsePOFile.Size = New System.Drawing.Size(75, 23)
        Me.BrowsePOFile.TabIndex = 4
        Me.BrowsePOFile.Text = "Browse"
        Me.BrowsePOFile.UseVisualStyleBackColor = True
        '
        'ModemPort
        '
        Me.ModemPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModemPort.FormattingEnabled = True
        Me.ModemPort.Items.AddRange(New Object() {"COM 1", "COM 2", "COM 3", "COM 4", "COM 5", "COM 6", "LPT 1", "LPT 2", "LPT 3", "LPT 4", "LPT 5", "LPT 6", "File"})
        Me.ModemPort.Location = New System.Drawing.Point(76, 20)
        Me.ModemPort.Name = "ModemPort"
        Me.ModemPort.Size = New System.Drawing.Size(69, 21)
        Me.ModemPort.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modem Port:"
        '
        'ModemOutputFile
        '
        Me.ModemOutputFile.Controls.Add(Me.ModemOutputPath)
        Me.ModemOutputFile.Controls.Add(Me.BrowseMOFile)
        Me.ModemOutputFile.Location = New System.Drawing.Point(6, 40)
        Me.ModemOutputFile.Name = "ModemOutputFile"
        Me.ModemOutputFile.Size = New System.Drawing.Size(360, 31)
        Me.ModemOutputFile.TabIndex = 6
        '
        'ModemOutputPath
        '
        Me.ModemOutputPath.Location = New System.Drawing.Point(3, 5)
        Me.ModemOutputPath.Name = "ModemOutputPath"
        Me.ModemOutputPath.Size = New System.Drawing.Size(274, 20)
        Me.ModemOutputPath.TabIndex = 0
        '
        'BrowseMOFile
        '
        Me.BrowseMOFile.Location = New System.Drawing.Point(283, 4)
        Me.BrowseMOFile.Name = "BrowseMOFile"
        Me.BrowseMOFile.Size = New System.Drawing.Size(75, 23)
        Me.BrowseMOFile.TabIndex = 4
        Me.BrowseMOFile.Text = "Browse"
        Me.BrowseMOFile.UseVisualStyleBackColor = True
        '
        'MiscFrame
        '
        Me.MiscFrame.Controls.Add(Me.IgnoreIllegal)
        Me.MiscFrame.Controls.Add(Me.IdleCPU)
        Me.MiscFrame.Controls.Add(Me.Enable68kEmu)
        Me.MiscFrame.Controls.Add(Me.EnableJIT)
        Me.MiscFrame.Location = New System.Drawing.Point(0, 3)
        Me.MiscFrame.Name = "MiscFrame"
        Me.MiscFrame.Size = New System.Drawing.Size(367, 279)
        Me.MiscFrame.TabIndex = 8
        Me.MiscFrame.TabStop = False
        Me.MiscFrame.Text = "Miscelaneous"
        '
        'IgnoreIllegal
        '
        Me.IgnoreIllegal.AutoSize = True
        Me.IgnoreIllegal.Location = New System.Drawing.Point(3, 86)
        Me.IgnoreIllegal.Name = "IgnoreIllegal"
        Me.IgnoreIllegal.Size = New System.Drawing.Size(172, 17)
        Me.IgnoreIllegal.TabIndex = 3
        Me.IgnoreIllegal.Text = "Ignore illegal memory accesses"
        Me.IgnoreIllegal.UseVisualStyleBackColor = True
        '
        'IdleCPU
        '
        Me.IdleCPU.AutoSize = True
        Me.IdleCPU.Location = New System.Drawing.Point(3, 63)
        Me.IdleCPU.Name = "IdleCPU"
        Me.IdleCPU.Size = New System.Drawing.Size(144, 17)
        Me.IdleCPU.TabIndex = 2
        Me.IdleCPU.Text = "Don't use CPU when idle"
        Me.IdleCPU.UseVisualStyleBackColor = True
        '
        'Enable68kEmu
        '
        Me.Enable68kEmu.AutoSize = True
        Me.Enable68kEmu.Enabled = False
        Me.Enable68kEmu.Location = New System.Drawing.Point(3, 40)
        Me.Enable68kEmu.Name = "Enable68kEmu"
        Me.Enable68kEmu.Size = New System.Drawing.Size(191, 17)
        Me.Enable68kEmu.TabIndex = 1
        Me.Enable68kEmu.Text = "Enable 68k emulator (experimental)"
        Me.Enable68kEmu.UseVisualStyleBackColor = True
        '
        'EnableJIT
        '
        Me.EnableJIT.AutoSize = True
        Me.EnableJIT.Location = New System.Drawing.Point(3, 17)
        Me.EnableJIT.Name = "EnableJIT"
        Me.EnableJIT.Size = New System.Drawing.Size(120, 17)
        Me.EnableJIT.TabIndex = 0
        Me.EnableJIT.Text = "Enable JIT Compiler"
        Me.EnableJIT.UseVisualStyleBackColor = True
        '
        'NetworkFrame
        '
        Me.NetworkFrame.Controls.Add(Me.NetInterfaceLabel)
        Me.NetworkFrame.Controls.Add(Me.NetInterface)
        Me.NetworkFrame.Controls.Add(Me.RouterPanel)
        Me.NetworkFrame.Location = New System.Drawing.Point(0, 3)
        Me.NetworkFrame.Name = "NetworkFrame"
        Me.NetworkFrame.Size = New System.Drawing.Size(367, 279)
        Me.NetworkFrame.TabIndex = 8
        Me.NetworkFrame.TabStop = False
        Me.NetworkFrame.Text = "Network"
        '
        'NetInterfaceLabel
        '
        Me.NetInterfaceLabel.AutoSize = True
        Me.NetInterfaceLabel.Location = New System.Drawing.Point(14, 30)
        Me.NetInterfaceLabel.Name = "NetInterfaceLabel"
        Me.NetInterfaceLabel.Size = New System.Drawing.Size(95, 13)
        Me.NetInterfaceLabel.TabIndex = 2
        Me.NetInterfaceLabel.Text = "Network Interface:"
        '
        'NetInterface
        '
        Me.NetInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetInterface.FormattingEnabled = True
        Me.NetInterface.Items.AddRange(New Object() {"Slirp", "Router", "Disabled"})
        Me.NetInterface.Location = New System.Drawing.Point(119, 27)
        Me.NetInterface.Name = "NetInterface"
        Me.NetInterface.Size = New System.Drawing.Size(242, 21)
        Me.NetInterface.TabIndex = 1
        '
        'RouterPanel
        '
        Me.RouterPanel.Controls.Add(Me.FTPPortsLabel)
        Me.RouterPanel.Controls.Add(Me.ServerPortsLabel)
        Me.RouterPanel.Controls.Add(Me.FTPPorts)
        Me.RouterPanel.Controls.Add(Me.ServerPorts)
        Me.RouterPanel.Location = New System.Drawing.Point(9, 51)
        Me.RouterPanel.Name = "RouterPanel"
        Me.RouterPanel.Size = New System.Drawing.Size(360, 62)
        Me.RouterPanel.TabIndex = 8
        '
        'FTPPortsLabel
        '
        Me.FTPPortsLabel.AutoSize = True
        Me.FTPPortsLabel.Location = New System.Drawing.Point(5, 6)
        Me.FTPPortsLabel.Name = "FTPPortsLabel"
        Me.FTPPortsLabel.Size = New System.Drawing.Size(54, 13)
        Me.FTPPortsLabel.TabIndex = 4
        Me.FTPPortsLabel.Text = "FTP Ports"
        '
        'ServerPortsLabel
        '
        Me.ServerPortsLabel.AutoSize = True
        Me.ServerPortsLabel.Location = New System.Drawing.Point(5, 33)
        Me.ServerPortsLabel.Name = "ServerPortsLabel"
        Me.ServerPortsLabel.Size = New System.Drawing.Size(65, 13)
        Me.ServerPortsLabel.TabIndex = 6
        Me.ServerPortsLabel.Text = "Server Ports"
        '
        'FTPPorts
        '
        Me.FTPPorts.Location = New System.Drawing.Point(110, 3)
        Me.FTPPorts.Name = "FTPPorts"
        Me.FTPPorts.Size = New System.Drawing.Size(242, 20)
        Me.FTPPorts.TabIndex = 3
        '
        'ServerPorts
        '
        Me.ServerPorts.Location = New System.Drawing.Point(110, 30)
        Me.ServerPorts.Name = "ServerPorts"
        Me.ServerPorts.Size = New System.Drawing.Size(242, 20)
        Me.ServerPorts.TabIndex = 5
        '
        'InputFrame
        '
        Me.InputFrame.Controls.Add(Me.KeyboardGroup)
        Me.InputFrame.Controls.Add(Me.MouseGroup)
        Me.InputFrame.Location = New System.Drawing.Point(0, 3)
        Me.InputFrame.Name = "InputFrame"
        Me.InputFrame.Size = New System.Drawing.Size(367, 279)
        Me.InputFrame.TabIndex = 8
        Me.InputFrame.TabStop = False
        Me.InputFrame.Text = "Mouse and keyboard"
        '
        'KeyboardGroup
        '
        Me.KeyboardGroup.Controls.Add(Me.KeyCodesPathLabel)
        Me.KeyboardGroup.Controls.Add(Me.KeyCodesPath)
        Me.KeyboardGroup.Controls.Add(Me.UseKeycodes)
        Me.KeyboardGroup.Controls.Add(Me.BrowseKeyCodes)
        Me.KeyboardGroup.Location = New System.Drawing.Point(6, 126)
        Me.KeyboardGroup.Name = "KeyboardGroup"
        Me.KeyboardGroup.Size = New System.Drawing.Size(355, 147)
        Me.KeyboardGroup.TabIndex = 0
        Me.KeyboardGroup.TabStop = False
        Me.KeyboardGroup.Text = "Keyboard"
        '
        'KeyCodesPathLabel
        '
        Me.KeyCodesPathLabel.AutoSize = True
        Me.KeyCodesPathLabel.Location = New System.Drawing.Point(3, 49)
        Me.KeyCodesPathLabel.Name = "KeyCodesPathLabel"
        Me.KeyCodesPathLabel.Size = New System.Drawing.Size(109, 13)
        Me.KeyCodesPathLabel.TabIndex = 3
        Me.KeyCodesPathLabel.Text = "Path to keycodes file:"
        '
        'KeyCodesPath
        '
        Me.KeyCodesPath.Location = New System.Drawing.Point(3, 70)
        Me.KeyCodesPath.Name = "KeyCodesPath"
        Me.KeyCodesPath.Size = New System.Drawing.Size(307, 20)
        Me.KeyCodesPath.TabIndex = 2
        '
        'UseKeycodes
        '
        Me.UseKeycodes.AutoSize = True
        Me.UseKeycodes.Location = New System.Drawing.Point(6, 20)
        Me.UseKeycodes.Name = "UseKeycodes"
        Me.UseKeycodes.Size = New System.Drawing.Size(110, 17)
        Me.UseKeycodes.TabIndex = 0
        Me.UseKeycodes.Text = "Use keycodes file"
        Me.UseKeycodes.UseVisualStyleBackColor = True
        '
        'BrowseKeyCodes
        '
        Me.BrowseKeyCodes.Location = New System.Drawing.Point(316, 68)
        Me.BrowseKeyCodes.Name = "BrowseKeyCodes"
        Me.BrowseKeyCodes.Size = New System.Drawing.Size(33, 23)
        Me.BrowseKeyCodes.TabIndex = 1
        Me.BrowseKeyCodes.Text = "..."
        Me.BrowseKeyCodes.UseVisualStyleBackColor = True
        '
        'MouseGroup
        '
        Me.MouseGroup.Controls.Add(Me.ScrollLinesLabel)
        Me.MouseGroup.Controls.Add(Me.WheelFunctionLabel)
        Me.MouseGroup.Controls.Add(Me.WheelFunction)
        Me.MouseGroup.Controls.Add(Me.ScrollLines)
        Me.MouseGroup.Location = New System.Drawing.Point(6, 20)
        Me.MouseGroup.Name = "MouseGroup"
        Me.MouseGroup.Size = New System.Drawing.Size(355, 100)
        Me.MouseGroup.TabIndex = 5
        Me.MouseGroup.TabStop = False
        Me.MouseGroup.Text = "Mouse"
        '
        'ScrollLinesLabel
        '
        Me.ScrollLinesLabel.AutoSize = True
        Me.ScrollLinesLabel.Location = New System.Drawing.Point(6, 47)
        Me.ScrollLinesLabel.Name = "ScrollLinesLabel"
        Me.ScrollLinesLabel.Size = New System.Drawing.Size(74, 13)
        Me.ScrollLinesLabel.TabIndex = 6
        Me.ScrollLinesLabel.Text = "Lines to scroll:"
        '
        'WheelFunctionLabel
        '
        Me.WheelFunctionLabel.AutoSize = True
        Me.WheelFunctionLabel.Location = New System.Drawing.Point(6, 21)
        Me.WheelFunctionLabel.Name = "WheelFunctionLabel"
        Me.WheelFunctionLabel.Size = New System.Drawing.Size(82, 13)
        Me.WheelFunctionLabel.TabIndex = 5
        Me.WheelFunctionLabel.Text = "Wheel function:"
        '
        'WheelFunction
        '
        Me.WheelFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WheelFunction.FormattingEnabled = True
        Me.WheelFunction.Items.AddRange(New Object() {"Cursor Up/Down", "Page Up/Down"})
        Me.WheelFunction.Location = New System.Drawing.Point(95, 18)
        Me.WheelFunction.Name = "WheelFunction"
        Me.WheelFunction.Size = New System.Drawing.Size(76, 21)
        Me.WheelFunction.TabIndex = 3
        '
        'ScrollLines
        '
        Me.ScrollLines.Location = New System.Drawing.Point(95, 45)
        Me.ScrollLines.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ScrollLines.Name = "ScrollLines"
        Me.ScrollLines.Size = New System.Drawing.Size(76, 20)
        Me.ScrollLines.TabIndex = 4
        '
        'ScreenFrame
        '
        Me.ScreenFrame.Controls.Add(Me.CustResolution)
        Me.ScreenFrame.Controls.Add(Me.VMResHeight)
        Me.ScreenFrame.Controls.Add(Me.VMResWidth)
        Me.ScreenFrame.Controls.Add(Me.VMResLabel)
        Me.ScreenFrame.Controls.Add(Me.VMResDef)
        Me.ScreenFrame.Controls.Add(Me.RefeshRateLabel)
        Me.ScreenFrame.Controls.Add(Me.RefreshRate)
        Me.ScreenFrame.Controls.Add(Me.StartModeLabel)
        Me.ScreenFrame.Controls.Add(Me.StartMode)
        Me.ScreenFrame.Location = New System.Drawing.Point(0, 3)
        Me.ScreenFrame.Name = "ScreenFrame"
        Me.ScreenFrame.Size = New System.Drawing.Size(367, 279)
        Me.ScreenFrame.TabIndex = 5
        Me.ScreenFrame.TabStop = False
        Me.ScreenFrame.Text = "Screen"
        '
        'CustResolution
        '
        Me.CustResolution.AutoSize = True
        Me.CustResolution.Location = New System.Drawing.Point(189, 23)
        Me.CustResolution.Name = "CustResolution"
        Me.CustResolution.Size = New System.Drawing.Size(114, 17)
        Me.CustResolution.TabIndex = 8
        Me.CustResolution.Text = "Custom Resolution"
        Me.CustResolution.UseVisualStyleBackColor = True
        '
        'VMResHeight
        '
        Me.VMResHeight.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VMResHeight.FormattingEnabled = True
        Me.VMResHeight.Items.AddRange(New Object() {"384", "480", "600", "768", "864", "1024"})
        Me.VMResHeight.Location = New System.Drawing.Point(139, 21)
        Me.VMResHeight.Name = "VMResHeight"
        Me.VMResHeight.Size = New System.Drawing.Size(46, 21)
        Me.VMResHeight.TabIndex = 7
        Me.VMResHeight.Visible = False
        '
        'VMResWidth
        '
        Me.VMResWidth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VMResWidth.FormattingEnabled = True
        Me.VMResWidth.Items.AddRange(New Object() {"512", "640", "800", "1024", "1152", "1280"})
        Me.VMResWidth.Location = New System.Drawing.Point(87, 21)
        Me.VMResWidth.Name = "VMResWidth"
        Me.VMResWidth.Size = New System.Drawing.Size(46, 21)
        Me.VMResWidth.TabIndex = 6
        Me.VMResWidth.Visible = False
        '
        'VMResLabel
        '
        Me.VMResLabel.AutoSize = True
        Me.VMResLabel.Location = New System.Drawing.Point(6, 24)
        Me.VMResLabel.Name = "VMResLabel"
        Me.VMResLabel.Size = New System.Drawing.Size(60, 13)
        Me.VMResLabel.TabIndex = 5
        Me.VMResLabel.Text = "Resolution:"
        '
        'VMResDef
        '
        Me.VMResDef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VMResDef.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.VMResDef.FormattingEnabled = True
        Me.VMResDef.Items.AddRange(New Object() {"512x384", "640x480", "800x600", "1024x768", "1152x864", "1280x1024", "Maximum"})
        Me.VMResDef.Location = New System.Drawing.Point(87, 21)
        Me.VMResDef.Name = "VMResDef"
        Me.VMResDef.Size = New System.Drawing.Size(98, 21)
        Me.VMResDef.TabIndex = 4
        '
        'RefeshRateLabel
        '
        Me.RefeshRateLabel.AutoSize = True
        Me.RefeshRateLabel.Location = New System.Drawing.Point(6, 78)
        Me.RefeshRateLabel.Name = "RefeshRateLabel"
        Me.RefeshRateLabel.Size = New System.Drawing.Size(73, 13)
        Me.RefeshRateLabel.TabIndex = 3
        Me.RefeshRateLabel.Text = "Refresh Rate:"
        '
        'RefreshRate
        '
        Me.RefreshRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RefreshRate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshRate.FormattingEnabled = True
        Me.RefreshRate.Items.AddRange(New Object() {"5 Hz", "7.5 Hz", "10 Hz", "15 Hz", "30 Hz", "60 Hz", "Dynamic"})
        Me.RefreshRate.Location = New System.Drawing.Point(87, 75)
        Me.RefreshRate.Name = "RefreshRate"
        Me.RefreshRate.Size = New System.Drawing.Size(98, 21)
        Me.RefreshRate.TabIndex = 2
        '
        'StartModeLabel
        '
        Me.StartModeLabel.AutoSize = True
        Me.StartModeLabel.Location = New System.Drawing.Point(6, 51)
        Me.StartModeLabel.Name = "StartModeLabel"
        Me.StartModeLabel.Size = New System.Drawing.Size(43, 13)
        Me.StartModeLabel.TabIndex = 1
        Me.StartModeLabel.Text = "Start in:"
        '
        'StartMode
        '
        Me.StartMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StartMode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StartMode.FormattingEnabled = True
        Me.StartMode.Items.AddRange(New Object() {"Window", "Fullscreen"})
        Me.StartMode.Location = New System.Drawing.Point(87, 48)
        Me.StartMode.Name = "StartMode"
        Me.StartMode.Size = New System.Drawing.Size(98, 21)
        Me.StartMode.TabIndex = 0
        '
        'IconFrame
        '
        Me.IconFrame.Controls.Add(Me.BrowseIcon)
        Me.IconFrame.Controls.Add(Me.IconDescription)
        Me.IconFrame.Controls.Add(Me.IconList)
        Me.IconFrame.Location = New System.Drawing.Point(0, 3)
        Me.IconFrame.Name = "IconFrame"
        Me.IconFrame.Size = New System.Drawing.Size(367, 279)
        Me.IconFrame.TabIndex = 3
        Me.IconFrame.TabStop = False
        Me.IconFrame.Text = "Icon"
        '
        'IconDescription
        '
        Me.IconDescription.Location = New System.Drawing.Point(6, 17)
        Me.IconDescription.Name = "IconDescription"
        Me.IconDescription.Size = New System.Drawing.Size(261, 18)
        Me.IconDescription.TabIndex = 7
        Me.IconDescription.Text = "If you want an icon that isn't in the list, click Browse."
        '
        'IconList
        '
        Me.IconList.Location = New System.Drawing.Point(9, 38)
        Me.IconList.Name = "IconList"
        Me.IconList.Size = New System.Drawing.Size(352, 235)
        Me.IconList.TabIndex = 6
        Me.IconList.UseCompatibleStateImageBehavior = False
        '
        'DrivesFrame
        '
        Me.DrivesFrame.Controls.Add(Me.DrivesList)
        Me.DrivesFrame.Controls.Add(Me.MoveItemDown)
        Me.DrivesFrame.Controls.Add(Me.MoveItemUp)
        Me.DrivesFrame.Controls.Add(Me.AddDisk)
        Me.DrivesFrame.Controls.Add(Me.AddCD)
        Me.DrivesFrame.Controls.Add(Me.DeleteItem)
        Me.DrivesFrame.Location = New System.Drawing.Point(0, 3)
        Me.DrivesFrame.Name = "DrivesFrame"
        Me.DrivesFrame.Size = New System.Drawing.Size(367, 279)
        Me.DrivesFrame.TabIndex = 8
        Me.DrivesFrame.TabStop = False
        Me.DrivesFrame.Text = "Drives"
        '
        'DrivesList
        '
        Me.DrivesList.FormattingEnabled = True
        Me.DrivesList.Items.AddRange(New Object() {"C:\Users\Usuario\Documents\ISOs\Mac OS 8.5 Spanish.iso", "C:\Users\Usuario\Documents\My Macs\Mac OS 8\Mac OS 8.dsk", "C:\Users\Usuario\Documents\My Macs\Mac OS 8\Data.dsk"})
        Me.DrivesList.Location = New System.Drawing.Point(3, 17)
        Me.DrivesList.Name = "DrivesList"
        Me.DrivesList.Size = New System.Drawing.Size(358, 186)
        Me.DrivesList.TabIndex = 6
        '
        'MoveItemDown
        '
        Me.MoveItemDown.Enabled = False
        Me.MoveItemDown.Location = New System.Drawing.Point(328, 213)
        Me.MoveItemDown.Name = "MoveItemDown"
        Me.MoveItemDown.Size = New System.Drawing.Size(33, 23)
        Me.MoveItemDown.TabIndex = 5
        Me.MoveItemDown.Text = "\/"
        Me.MoveItemDown.UseVisualStyleBackColor = True
        '
        'MoveItemUp
        '
        Me.MoveItemUp.Enabled = False
        Me.MoveItemUp.Location = New System.Drawing.Point(294, 213)
        Me.MoveItemUp.Name = "MoveItemUp"
        Me.MoveItemUp.Size = New System.Drawing.Size(33, 23)
        Me.MoveItemUp.TabIndex = 4
        Me.MoveItemUp.Text = "/\"
        Me.MoveItemUp.UseVisualStyleBackColor = True
        '
        'AddDisk
        '
        Me.AddDisk.Location = New System.Drawing.Point(6, 213)
        Me.AddDisk.Name = "AddDisk"
        Me.AddDisk.Size = New System.Drawing.Size(56, 23)
        Me.AddDisk.TabIndex = 3
        Me.AddDisk.Text = "Add disk"
        Me.AddDisk.UseVisualStyleBackColor = True
        '
        'AddCD
        '
        Me.AddCD.Location = New System.Drawing.Point(68, 213)
        Me.AddCD.Name = "AddCD"
        Me.AddCD.Size = New System.Drawing.Size(56, 23)
        Me.AddCD.TabIndex = 2
        Me.AddCD.Text = "Add CD"
        Me.AddCD.UseVisualStyleBackColor = True
        '
        'DeleteItem
        '
        Me.DeleteItem.Location = New System.Drawing.Point(130, 213)
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.Size = New System.Drawing.Size(90, 23)
        Me.DeleteItem.TabIndex = 1
        Me.DeleteItem.Text = "Delete selected"
        Me.DeleteItem.UseVisualStyleBackColor = True
        '
        'MemoryFrame
        '
        Me.MemoryFrame.Controls.Add(Me.Memory)
        Me.MemoryFrame.Controls.Add(Me.MegabyteLabel)
        Me.MemoryFrame.Controls.Add(Me.MemoryLabel)
        Me.MemoryFrame.Controls.Add(Me.MemorySlider)
        Me.MemoryFrame.Location = New System.Drawing.Point(0, 3)
        Me.MemoryFrame.Name = "MemoryFrame"
        Me.MemoryFrame.Size = New System.Drawing.Size(367, 279)
        Me.MemoryFrame.TabIndex = 8
        Me.MemoryFrame.TabStop = False
        Me.MemoryFrame.Text = "Memory"
        '
        'Memory
        '
        Me.Memory.Location = New System.Drawing.Point(273, 61)
        Me.Memory.Name = "Memory"
        Me.Memory.Size = New System.Drawing.Size(43, 20)
        Me.Memory.TabIndex = 5
        '
        'MegabyteLabel
        '
        Me.MegabyteLabel.AutoSize = True
        Me.MegabyteLabel.Location = New System.Drawing.Point(322, 63)
        Me.MegabyteLabel.Name = "MegabyteLabel"
        Me.MegabyteLabel.Size = New System.Drawing.Size(23, 13)
        Me.MegabyteLabel.TabIndex = 4
        Me.MegabyteLabel.Text = "MB"
        '
        'MemoryLabel
        '
        Me.MemoryLabel.AutoSize = True
        Me.MemoryLabel.Location = New System.Drawing.Point(6, 35)
        Me.MemoryLabel.Name = "MemoryLabel"
        Me.MemoryLabel.Size = New System.Drawing.Size(257, 13)
        Me.MemoryLabel.TabIndex = 2
        Me.MemoryLabel.Text = "Set the amount of RAM to dedicate to this Macintosh"
        '
        'MemorySlider
        '
        Me.MemorySlider.Location = New System.Drawing.Point(3, 60)
        Me.MemorySlider.Maximum = 100
        Me.MemorySlider.Name = "MemorySlider"
        Me.MemorySlider.Size = New System.Drawing.Size(264, 45)
        Me.MemorySlider.TabIndex = 0
        Me.MemorySlider.TickFrequency = 5
        '
        'VMNameFrame
        '
        Me.VMNameFrame.Controls.Add(Me.VMNameHelp)
        Me.VMNameFrame.Controls.Add(Me.VMName)
        Me.VMNameFrame.Location = New System.Drawing.Point(0, 3)
        Me.VMNameFrame.Name = "VMNameFrame"
        Me.VMNameFrame.Size = New System.Drawing.Size(367, 279)
        Me.VMNameFrame.TabIndex = 4
        Me.VMNameFrame.TabStop = False
        Me.VMNameFrame.Text = "Name"
        '
        'VMNameHelp
        '
        Me.VMNameHelp.Location = New System.Drawing.Point(6, 17)
        Me.VMNameHelp.Name = "VMNameHelp"
        Me.VMNameHelp.Size = New System.Drawing.Size(363, 18)
        Me.VMNameHelp.TabIndex = 7
        Me.VMNameHelp.Text = "Do you want a change? Why not start with the name?"
        '
        'VMName
        '
        Me.VMName.Location = New System.Drawing.Point(9, 38)
        Me.VMName.Name = "VMName"
        Me.VMName.Size = New System.Drawing.Size(352, 20)
        Me.VMName.TabIndex = 6
        '
        'OptionList
        '
        Me.OptionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Options, Me.Value})
        Me.OptionList.FullRowSelect = True
        Me.OptionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18})
        Me.OptionList.Location = New System.Drawing.Point(12, 11)
        Me.OptionList.Name = "OptionList"
        Me.OptionList.Size = New System.Drawing.Size(353, 376)
        Me.OptionList.TabIndex = 28
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
        Me.cmdCancel.TabIndex = 27
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
        Me.cmdOK.TabIndex = 26
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'frmSettingsQemuVM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 400)
        Me.Controls.Add(Me.OptionPanel)
        Me.Controls.Add(Me.OptionList)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSettingsQemuVM"
        Me.Text = "Settings for %s"
        Me.OptionPanel.ResumeLayout(False)
        Me.SerialFrame.ResumeLayout(False)
        Me.SerialFrame.PerformLayout()
        Me.PrinterOutputFile.ResumeLayout(False)
        Me.PrinterOutputFile.PerformLayout()
        Me.ModemOutputFile.ResumeLayout(False)
        Me.ModemOutputFile.PerformLayout()
        Me.MiscFrame.ResumeLayout(False)
        Me.MiscFrame.PerformLayout()
        Me.NetworkFrame.ResumeLayout(False)
        Me.NetworkFrame.PerformLayout()
        Me.RouterPanel.ResumeLayout(False)
        Me.RouterPanel.PerformLayout()
        Me.InputFrame.ResumeLayout(False)
        Me.KeyboardGroup.ResumeLayout(False)
        Me.KeyboardGroup.PerformLayout()
        Me.MouseGroup.ResumeLayout(False)
        Me.MouseGroup.PerformLayout()
        CType(Me.ScrollLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScreenFrame.ResumeLayout(False)
        Me.ScreenFrame.PerformLayout()
        Me.IconFrame.ResumeLayout(False)
        Me.DrivesFrame.ResumeLayout(False)
        Me.MemoryFrame.ResumeLayout(False)
        Me.MemoryFrame.PerformLayout()
        CType(Me.MemorySlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VMNameFrame.ResumeLayout(False)
        Me.VMNameFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BrowseIcon As System.Windows.Forms.Button
    Friend WithEvents OptionPanel As System.Windows.Forms.Panel
    Friend WithEvents SerialFrame As System.Windows.Forms.GroupBox
    Friend WithEvents PrinterPort As System.Windows.Forms.ComboBox
    Friend WithEvents PrinterPortLabel As System.Windows.Forms.Label
    Friend WithEvents PrinterOutputFile As System.Windows.Forms.Panel
    Friend WithEvents PrinterOutputPath As System.Windows.Forms.TextBox
    Friend WithEvents BrowsePOFile As System.Windows.Forms.Button
    Friend WithEvents ModemPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ModemOutputFile As System.Windows.Forms.Panel
    Friend WithEvents ModemOutputPath As System.Windows.Forms.TextBox
    Friend WithEvents BrowseMOFile As System.Windows.Forms.Button
    Friend WithEvents MiscFrame As System.Windows.Forms.GroupBox
    Friend WithEvents IgnoreIllegal As System.Windows.Forms.CheckBox
    Friend WithEvents IdleCPU As System.Windows.Forms.CheckBox
    Friend WithEvents Enable68kEmu As System.Windows.Forms.CheckBox
    Friend WithEvents EnableJIT As System.Windows.Forms.CheckBox
    Friend WithEvents NetworkFrame As System.Windows.Forms.GroupBox
    Friend WithEvents NetInterfaceLabel As System.Windows.Forms.Label
    Friend WithEvents NetInterface As System.Windows.Forms.ComboBox
    Friend WithEvents RouterPanel As System.Windows.Forms.Panel
    Friend WithEvents FTPPortsLabel As System.Windows.Forms.Label
    Friend WithEvents ServerPortsLabel As System.Windows.Forms.Label
    Friend WithEvents FTPPorts As System.Windows.Forms.TextBox
    Friend WithEvents ServerPorts As System.Windows.Forms.TextBox
    Friend WithEvents InputFrame As System.Windows.Forms.GroupBox
    Friend WithEvents KeyboardGroup As System.Windows.Forms.GroupBox
    Friend WithEvents KeyCodesPathLabel As System.Windows.Forms.Label
    Friend WithEvents KeyCodesPath As System.Windows.Forms.TextBox
    Friend WithEvents UseKeycodes As System.Windows.Forms.CheckBox
    Friend WithEvents BrowseKeyCodes As System.Windows.Forms.Button
    Friend WithEvents MouseGroup As System.Windows.Forms.GroupBox
    Friend WithEvents ScrollLinesLabel As System.Windows.Forms.Label
    Friend WithEvents WheelFunctionLabel As System.Windows.Forms.Label
    Friend WithEvents WheelFunction As System.Windows.Forms.ComboBox
    Friend WithEvents ScrollLines As System.Windows.Forms.NumericUpDown
    Friend WithEvents ScreenFrame As System.Windows.Forms.GroupBox
    Friend WithEvents CustResolution As System.Windows.Forms.CheckBox
    Friend WithEvents VMResHeight As System.Windows.Forms.ComboBox
    Friend WithEvents VMResWidth As System.Windows.Forms.ComboBox
    Friend WithEvents VMResLabel As System.Windows.Forms.Label
    Friend WithEvents VMResDef As System.Windows.Forms.ComboBox
    Friend WithEvents RefeshRateLabel As System.Windows.Forms.Label
    Friend WithEvents RefreshRate As System.Windows.Forms.ComboBox
    Friend WithEvents StartModeLabel As System.Windows.Forms.Label
    Friend WithEvents StartMode As System.Windows.Forms.ComboBox
    Friend WithEvents IconFrame As System.Windows.Forms.GroupBox
    Friend WithEvents IconDescription As System.Windows.Forms.Label
    Friend WithEvents IconList As System.Windows.Forms.ListView
    Friend WithEvents DrivesFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DrivesList As System.Windows.Forms.ListBox
    Friend WithEvents MoveItemDown As System.Windows.Forms.Button
    Friend WithEvents MoveItemUp As System.Windows.Forms.Button
    Friend WithEvents AddDisk As System.Windows.Forms.Button
    Friend WithEvents AddCD As System.Windows.Forms.Button
    Friend WithEvents DeleteItem As System.Windows.Forms.Button
    Friend WithEvents MemoryFrame As System.Windows.Forms.GroupBox
    Friend WithEvents Memory As System.Windows.Forms.TextBox
    Friend WithEvents MegabyteLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryLabel As System.Windows.Forms.Label
    Friend WithEvents MemorySlider As System.Windows.Forms.TrackBar
    Friend WithEvents VMNameFrame As System.Windows.Forms.GroupBox
    Friend WithEvents VMNameHelp As System.Windows.Forms.Label
    Friend WithEvents VMName As System.Windows.Forms.TextBox
    Friend WithEvents OptionList As System.Windows.Forms.ListView
    Friend WithEvents Options As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
End Class
