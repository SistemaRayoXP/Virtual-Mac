<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsPearPCVM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingsPearPCVM))
        Me.BoardSerialEnable = New System.Windows.Forms.CheckBox()
        Me.BoardComposeDialogKeyLabel = New System.Windows.Forms.Label()
        Me.BoardComposeDialogKey = New System.Windows.Forms.TextBox()
        Me.BoardChangeCDKeyLabel = New System.Windows.Forms.Label()
        Me.BoardChangeCDKey = New System.Windows.Forms.TextBox()
        Me.BoardMouseGrabKeyLabel = New System.Windows.Forms.Label()
        Me.BoardUSBEnable = New System.Windows.Forms.CheckBox()
        Me.BoardMouseGrabKey = New System.Windows.Forms.TextBox()
        Me.BoardRAMLabelMB = New System.Windows.Forms.Label()
        Me.BoardRAM = New System.Windows.Forms.TextBox()
        Me.BoardProcessorLabel = New System.Windows.Forms.Label()
        Me.Net3c90MacLabel = New System.Windows.Forms.Label()
        Me.Net8139Mac6 = New System.Windows.Forms.TextBox()
        Me.Net8139Mac5 = New System.Windows.Forms.TextBox()
        Me.BoardRAMLabel = New System.Windows.Forms.Label()
        Me.Net8139Mac4 = New System.Windows.Forms.TextBox()
        Me.Net8139Mac3 = New System.Windows.Forms.TextBox()
        Me.BoardFrame = New System.Windows.Forms.GroupBox()
        Me.BoardRAMSlider = New System.Windows.Forms.TrackBar()
        Me.BoardProcessorG4 = New System.Windows.Forms.RadioButton()
        Me.BoardProcessorG3 = New System.Windows.Forms.RadioButton()
        Me.MiscPageTable = New System.Windows.Forms.TextBox()
        Me.MiscPageTableLabel = New System.Windows.Forms.Label()
        Me.MiscNVRAMFileLabel = New System.Windows.Forms.Label()
        Me.MiscNVRAMFile = New System.Windows.Forms.TextBox()
        Me.MiscBootModeLabel = New System.Windows.Forms.Label()
        Me.MiscBootModeAuto = New System.Windows.Forms.RadioButton()
        Me.MiscBootModeSelect = New System.Windows.Forms.RadioButton()
        Me.MiscBootModeForce = New System.Windows.Forms.RadioButton()
        Me.MiscFrame = New System.Windows.Forms.GroupBox()
        Me.MiscNVRAMFileBrowse = New System.Windows.Forms.Button()
        Me.MiscPROMBootPathBrowse = New System.Windows.Forms.Button()
        Me.MiscPROMFileBrowse = New System.Windows.Forms.Button()
        Me.MiscInfo = New System.Windows.Forms.Label()
        Me.MiscAdvancedInfo = New System.Windows.Forms.Label()
        Me.MiscPROMBootArgs = New System.Windows.Forms.TextBox()
        Me.MiscPROMBootArgsLabel = New System.Windows.Forms.Label()
        Me.MiscMachArguments = New System.Windows.Forms.TextBox()
        Me.MiscMachArgumentsLabel = New System.Windows.Forms.Label()
        Me.MiscPROMBootPath = New System.Windows.Forms.TextBox()
        Me.MiscPROMBootPathLabel = New System.Windows.Forms.Label()
        Me.MiscPROMFile = New System.Windows.Forms.TextBox()
        Me.MiscPROMFileLabel = New System.Windows.Forms.Label()
        Me.Net8139MacLabel = New System.Windows.Forms.Label()
        Me.DisplayDriverBrowse = New System.Windows.Forms.Button()
        Me.DisplayDriver = New System.Windows.Forms.TextBox()
        Me.DisplayDriverLabel = New System.Windows.Forms.Label()
        Me.DisplayFrequency = New System.Windows.Forms.NumericUpDown()
        Me.DisplayRedrawLabel = New System.Windows.Forms.TextBox()
        Me.NetworkFrame = New System.Windows.Forms.GroupBox()
        Me.Net8139Enable = New System.Windows.Forms.CheckBox()
        Me.Net8139Mac1 = New System.Windows.Forms.TextBox()
        Me.Net8139Mac2 = New System.Windows.Forms.TextBox()
        Me.Net3c90xEnable = New System.Windows.Forms.CheckBox()
        Me.Net3c90Mac6 = New System.Windows.Forms.TextBox()
        Me.Net3c90Mac5 = New System.Windows.Forms.TextBox()
        Me.Net3c90Mac4 = New System.Windows.Forms.TextBox()
        Me.Net3c90Mac3 = New System.Windows.Forms.TextBox()
        Me.Net3c90Mac2 = New System.Windows.Forms.TextBox()
        Me.Net3c90Mac1 = New System.Windows.Forms.TextBox()
        Me.DisplayRedraw = New System.Windows.Forms.Label()
        Me.DisplayFullscreenKey = New System.Windows.Forms.TextBox()
        Me.DisplayFrame = New System.Windows.Forms.GroupBox()
        Me.DisplayResY = New System.Windows.Forms.ComboBox()
        Me.DisplayResX = New System.Windows.Forms.ComboBox()
        Me.DisplayResLabel = New System.Windows.Forms.Label()
        Me.DisplayColourDepth = New System.Windows.Forms.ComboBox()
        Me.DisplayFullscreenStart = New System.Windows.Forms.CheckBox()
        Me.DisplayResCustom = New System.Windows.Forms.CheckBox()
        Me.DisplayFullscreenKeyLabel = New System.Windows.Forms.Label()
        Me.DriveFrame = New System.Windows.Forms.GroupBox()
        Me.DriveMasterEnabled = New System.Windows.Forms.CheckBox()
        Me.DriveMasterType = New System.Windows.Forms.ComboBox()
        Me.DriveMasterTypeLabel = New System.Windows.Forms.Label()
        Me.DriveMasterPath = New System.Windows.Forms.TextBox()
        Me.DriveMasterPathLabel = New System.Windows.Forms.Label()
        Me.DriveMasterBrowse = New System.Windows.Forms.Button()
        Me.DriveSlaveEnabled = New System.Windows.Forms.CheckBox()
        Me.DriveSlaveType = New System.Windows.Forms.ComboBox()
        Me.DriveSlaveTypeLabel = New System.Windows.Forms.Label()
        Me.DriveSlavePath = New System.Windows.Forms.TextBox()
        Me.DriveSlavePathLabel = New System.Windows.Forms.Label()
        Me.DriveSlaveBrowse = New System.Windows.Forms.Button()
        Me.Browser = New System.Windows.Forms.OpenFileDialog()
        Me.SaveConfigFile = New System.Windows.Forms.SaveFileDialog()
        Me.SelectDrive = New System.Windows.Forms.FolderBrowserDialog()
        Me.OptionList = New System.Windows.Forms.ListView()
        Me.Options = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.GroupContainer = New System.Windows.Forms.Panel()
        Me.IconFrame = New System.Windows.Forms.GroupBox()
        Me.IconAdd = New System.Windows.Forms.Button()
        Me.IconList = New System.Windows.Forms.ListView()
        Me.IconInfo = New System.Windows.Forms.Label()
        Me.MacNameFrame = New System.Windows.Forms.GroupBox()
        Me.MacName = New System.Windows.Forms.TextBox()
        Me.MacNameLabel = New System.Windows.Forms.Label()
        Me.FileBrowserDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BoardFrame.SuspendLayout()
        CType(Me.BoardRAMSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiscFrame.SuspendLayout()
        CType(Me.DisplayFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NetworkFrame.SuspendLayout()
        Me.DisplayFrame.SuspendLayout()
        Me.DriveFrame.SuspendLayout()
        Me.GroupContainer.SuspendLayout()
        Me.IconFrame.SuspendLayout()
        Me.MacNameFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'BoardSerialEnable
        '
        resources.ApplyResources(Me.BoardSerialEnable, "BoardSerialEnable")
        Me.BoardSerialEnable.BackColor = System.Drawing.Color.Transparent
        Me.BoardSerialEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardSerialEnable.Name = "BoardSerialEnable"
        Me.BoardSerialEnable.UseVisualStyleBackColor = False
        '
        'BoardComposeDialogKeyLabel
        '
        resources.ApplyResources(Me.BoardComposeDialogKeyLabel, "BoardComposeDialogKeyLabel")
        Me.BoardComposeDialogKeyLabel.BackColor = System.Drawing.Color.Transparent
        Me.BoardComposeDialogKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardComposeDialogKeyLabel.Name = "BoardComposeDialogKeyLabel"
        '
        'BoardComposeDialogKey
        '
        resources.ApplyResources(Me.BoardComposeDialogKey, "BoardComposeDialogKey")
        Me.BoardComposeDialogKey.Name = "BoardComposeDialogKey"
        '
        'BoardChangeCDKeyLabel
        '
        resources.ApplyResources(Me.BoardChangeCDKeyLabel, "BoardChangeCDKeyLabel")
        Me.BoardChangeCDKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardChangeCDKeyLabel.Name = "BoardChangeCDKeyLabel"
        '
        'BoardChangeCDKey
        '
        resources.ApplyResources(Me.BoardChangeCDKey, "BoardChangeCDKey")
        Me.BoardChangeCDKey.Name = "BoardChangeCDKey"
        '
        'BoardMouseGrabKeyLabel
        '
        resources.ApplyResources(Me.BoardMouseGrabKeyLabel, "BoardMouseGrabKeyLabel")
        Me.BoardMouseGrabKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardMouseGrabKeyLabel.Name = "BoardMouseGrabKeyLabel"
        '
        'BoardUSBEnable
        '
        resources.ApplyResources(Me.BoardUSBEnable, "BoardUSBEnable")
        Me.BoardUSBEnable.BackColor = System.Drawing.Color.Transparent
        Me.BoardUSBEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardUSBEnable.Name = "BoardUSBEnable"
        Me.BoardUSBEnable.UseVisualStyleBackColor = False
        '
        'BoardMouseGrabKey
        '
        resources.ApplyResources(Me.BoardMouseGrabKey, "BoardMouseGrabKey")
        Me.BoardMouseGrabKey.Name = "BoardMouseGrabKey"
        '
        'BoardRAMLabelMB
        '
        resources.ApplyResources(Me.BoardRAMLabelMB, "BoardRAMLabelMB")
        Me.BoardRAMLabelMB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardRAMLabelMB.Name = "BoardRAMLabelMB"
        '
        'BoardRAM
        '
        resources.ApplyResources(Me.BoardRAM, "BoardRAM")
        Me.BoardRAM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardRAM.Name = "BoardRAM"
        '
        'BoardProcessorLabel
        '
        resources.ApplyResources(Me.BoardProcessorLabel, "BoardProcessorLabel")
        Me.BoardProcessorLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardProcessorLabel.Name = "BoardProcessorLabel"
        '
        'Net3c90MacLabel
        '
        resources.ApplyResources(Me.Net3c90MacLabel, "Net3c90MacLabel")
        Me.Net3c90MacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90MacLabel.Name = "Net3c90MacLabel"
        '
        'Net8139Mac6
        '
        Me.Net8139Mac6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net8139Mac6, "Net8139Mac6")
        Me.Net8139Mac6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Mac6.Name = "Net8139Mac6"
        '
        'Net8139Mac5
        '
        Me.Net8139Mac5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net8139Mac5, "Net8139Mac5")
        Me.Net8139Mac5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Mac5.Name = "Net8139Mac5"
        '
        'BoardRAMLabel
        '
        resources.ApplyResources(Me.BoardRAMLabel, "BoardRAMLabel")
        Me.BoardRAMLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardRAMLabel.Name = "BoardRAMLabel"
        '
        'Net8139Mac4
        '
        Me.Net8139Mac4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net8139Mac4, "Net8139Mac4")
        Me.Net8139Mac4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Mac4.Name = "Net8139Mac4"
        '
        'Net8139Mac3
        '
        Me.Net8139Mac3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net8139Mac3, "Net8139Mac3")
        Me.Net8139Mac3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Mac3.Name = "Net8139Mac3"
        '
        'BoardFrame
        '
        Me.BoardFrame.Controls.Add(Me.BoardRAMSlider)
        Me.BoardFrame.Controls.Add(Me.BoardComposeDialogKey)
        Me.BoardFrame.Controls.Add(Me.BoardComposeDialogKeyLabel)
        Me.BoardFrame.Controls.Add(Me.BoardChangeCDKey)
        Me.BoardFrame.Controls.Add(Me.BoardChangeCDKeyLabel)
        Me.BoardFrame.Controls.Add(Me.BoardMouseGrabKey)
        Me.BoardFrame.Controls.Add(Me.BoardMouseGrabKeyLabel)
        Me.BoardFrame.Controls.Add(Me.BoardUSBEnable)
        Me.BoardFrame.Controls.Add(Me.BoardRAM)
        Me.BoardFrame.Controls.Add(Me.BoardRAMLabel)
        Me.BoardFrame.Controls.Add(Me.BoardRAMLabelMB)
        Me.BoardFrame.Controls.Add(Me.BoardProcessorLabel)
        Me.BoardFrame.Controls.Add(Me.BoardProcessorG4)
        Me.BoardFrame.Controls.Add(Me.BoardProcessorG3)
        Me.BoardFrame.Controls.Add(Me.BoardSerialEnable)
        resources.ApplyResources(Me.BoardFrame, "BoardFrame")
        Me.BoardFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardFrame.Name = "BoardFrame"
        Me.BoardFrame.TabStop = False
        '
        'BoardRAMSlider
        '
        resources.ApplyResources(Me.BoardRAMSlider, "BoardRAMSlider")
        Me.BoardRAMSlider.Name = "BoardRAMSlider"
        '
        'BoardProcessorG4
        '
        resources.ApplyResources(Me.BoardProcessorG4, "BoardProcessorG4")
        Me.BoardProcessorG4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardProcessorG4.Name = "BoardProcessorG4"
        Me.BoardProcessorG4.UseVisualStyleBackColor = True
        '
        'BoardProcessorG3
        '
        resources.ApplyResources(Me.BoardProcessorG3, "BoardProcessorG3")
        Me.BoardProcessorG3.Checked = True
        Me.BoardProcessorG3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoardProcessorG3.Name = "BoardProcessorG3"
        Me.BoardProcessorG3.TabStop = True
        Me.BoardProcessorG3.UseVisualStyleBackColor = True
        '
        'MiscPageTable
        '
        resources.ApplyResources(Me.MiscPageTable, "MiscPageTable")
        Me.MiscPageTable.Name = "MiscPageTable"
        '
        'MiscPageTableLabel
        '
        resources.ApplyResources(Me.MiscPageTableLabel, "MiscPageTableLabel")
        Me.MiscPageTableLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPageTableLabel.Name = "MiscPageTableLabel"
        '
        'MiscNVRAMFileLabel
        '
        resources.ApplyResources(Me.MiscNVRAMFileLabel, "MiscNVRAMFileLabel")
        Me.MiscNVRAMFileLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscNVRAMFileLabel.Name = "MiscNVRAMFileLabel"
        '
        'MiscNVRAMFile
        '
        resources.ApplyResources(Me.MiscNVRAMFile, "MiscNVRAMFile")
        Me.MiscNVRAMFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscNVRAMFile.Name = "MiscNVRAMFile"
        '
        'MiscBootModeLabel
        '
        resources.ApplyResources(Me.MiscBootModeLabel, "MiscBootModeLabel")
        Me.MiscBootModeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscBootModeLabel.Name = "MiscBootModeLabel"
        '
        'MiscBootModeAuto
        '
        resources.ApplyResources(Me.MiscBootModeAuto, "MiscBootModeAuto")
        Me.MiscBootModeAuto.Checked = True
        Me.MiscBootModeAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscBootModeAuto.Name = "MiscBootModeAuto"
        Me.MiscBootModeAuto.TabStop = True
        Me.MiscBootModeAuto.UseVisualStyleBackColor = True
        '
        'MiscBootModeSelect
        '
        resources.ApplyResources(Me.MiscBootModeSelect, "MiscBootModeSelect")
        Me.MiscBootModeSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscBootModeSelect.Name = "MiscBootModeSelect"
        Me.MiscBootModeSelect.TabStop = True
        Me.MiscBootModeSelect.UseVisualStyleBackColor = True
        '
        'MiscBootModeForce
        '
        resources.ApplyResources(Me.MiscBootModeForce, "MiscBootModeForce")
        Me.MiscBootModeForce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscBootModeForce.Name = "MiscBootModeForce"
        Me.MiscBootModeForce.TabStop = True
        Me.MiscBootModeForce.UseVisualStyleBackColor = True
        '
        'MiscFrame
        '
        Me.MiscFrame.Controls.Add(Me.MiscNVRAMFileBrowse)
        Me.MiscFrame.Controls.Add(Me.MiscPROMBootPathBrowse)
        Me.MiscFrame.Controls.Add(Me.MiscPROMFileBrowse)
        Me.MiscFrame.Controls.Add(Me.MiscInfo)
        Me.MiscFrame.Controls.Add(Me.MiscAdvancedInfo)
        Me.MiscFrame.Controls.Add(Me.MiscPageTable)
        Me.MiscFrame.Controls.Add(Me.MiscPageTableLabel)
        Me.MiscFrame.Controls.Add(Me.MiscNVRAMFile)
        Me.MiscFrame.Controls.Add(Me.MiscNVRAMFileLabel)
        Me.MiscFrame.Controls.Add(Me.MiscBootModeLabel)
        Me.MiscFrame.Controls.Add(Me.MiscBootModeAuto)
        Me.MiscFrame.Controls.Add(Me.MiscBootModeSelect)
        Me.MiscFrame.Controls.Add(Me.MiscBootModeForce)
        Me.MiscFrame.Controls.Add(Me.MiscPROMBootArgs)
        Me.MiscFrame.Controls.Add(Me.MiscPROMBootArgsLabel)
        Me.MiscFrame.Controls.Add(Me.MiscMachArguments)
        Me.MiscFrame.Controls.Add(Me.MiscMachArgumentsLabel)
        Me.MiscFrame.Controls.Add(Me.MiscPROMBootPath)
        Me.MiscFrame.Controls.Add(Me.MiscPROMBootPathLabel)
        Me.MiscFrame.Controls.Add(Me.MiscPROMFile)
        Me.MiscFrame.Controls.Add(Me.MiscPROMFileLabel)
        resources.ApplyResources(Me.MiscFrame, "MiscFrame")
        Me.MiscFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscFrame.Name = "MiscFrame"
        Me.MiscFrame.TabStop = False
        '
        'MiscNVRAMFileBrowse
        '
        resources.ApplyResources(Me.MiscNVRAMFileBrowse, "MiscNVRAMFileBrowse")
        Me.MiscNVRAMFileBrowse.Name = "MiscNVRAMFileBrowse"
        Me.MiscNVRAMFileBrowse.UseVisualStyleBackColor = True
        '
        'MiscPROMBootPathBrowse
        '
        resources.ApplyResources(Me.MiscPROMBootPathBrowse, "MiscPROMBootPathBrowse")
        Me.MiscPROMBootPathBrowse.Name = "MiscPROMBootPathBrowse"
        Me.MiscPROMBootPathBrowse.UseVisualStyleBackColor = True
        '
        'MiscPROMFileBrowse
        '
        resources.ApplyResources(Me.MiscPROMFileBrowse, "MiscPROMFileBrowse")
        Me.MiscPROMFileBrowse.Name = "MiscPROMFileBrowse"
        Me.MiscPROMFileBrowse.UseVisualStyleBackColor = True
        '
        'MiscInfo
        '
        resources.ApplyResources(Me.MiscInfo, "MiscInfo")
        Me.MiscInfo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MiscInfo.Name = "MiscInfo"
        '
        'MiscAdvancedInfo
        '
        resources.ApplyResources(Me.MiscAdvancedInfo, "MiscAdvancedInfo")
        Me.MiscAdvancedInfo.ForeColor = System.Drawing.Color.Red
        Me.MiscAdvancedInfo.Name = "MiscAdvancedInfo"
        '
        'MiscPROMBootArgs
        '
        resources.ApplyResources(Me.MiscPROMBootArgs, "MiscPROMBootArgs")
        Me.MiscPROMBootArgs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPROMBootArgs.Name = "MiscPROMBootArgs"
        '
        'MiscPROMBootArgsLabel
        '
        resources.ApplyResources(Me.MiscPROMBootArgsLabel, "MiscPROMBootArgsLabel")
        Me.MiscPROMBootArgsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPROMBootArgsLabel.Name = "MiscPROMBootArgsLabel"
        '
        'MiscMachArguments
        '
        resources.ApplyResources(Me.MiscMachArguments, "MiscMachArguments")
        Me.MiscMachArguments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscMachArguments.Name = "MiscMachArguments"
        '
        'MiscMachArgumentsLabel
        '
        resources.ApplyResources(Me.MiscMachArgumentsLabel, "MiscMachArgumentsLabel")
        Me.MiscMachArgumentsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscMachArgumentsLabel.Name = "MiscMachArgumentsLabel"
        '
        'MiscPROMBootPath
        '
        resources.ApplyResources(Me.MiscPROMBootPath, "MiscPROMBootPath")
        Me.MiscPROMBootPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPROMBootPath.Name = "MiscPROMBootPath"
        '
        'MiscPROMBootPathLabel
        '
        resources.ApplyResources(Me.MiscPROMBootPathLabel, "MiscPROMBootPathLabel")
        Me.MiscPROMBootPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPROMBootPathLabel.Name = "MiscPROMBootPathLabel"
        '
        'MiscPROMFile
        '
        resources.ApplyResources(Me.MiscPROMFile, "MiscPROMFile")
        Me.MiscPROMFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPROMFile.Name = "MiscPROMFile"
        '
        'MiscPROMFileLabel
        '
        resources.ApplyResources(Me.MiscPROMFileLabel, "MiscPROMFileLabel")
        Me.MiscPROMFileLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MiscPROMFileLabel.Name = "MiscPROMFileLabel"
        '
        'Net8139MacLabel
        '
        resources.ApplyResources(Me.Net8139MacLabel, "Net8139MacLabel")
        Me.Net8139MacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139MacLabel.Name = "Net8139MacLabel"
        '
        'DisplayDriverBrowse
        '
        resources.ApplyResources(Me.DisplayDriverBrowse, "DisplayDriverBrowse")
        Me.DisplayDriverBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayDriverBrowse.Name = "DisplayDriverBrowse"
        Me.DisplayDriverBrowse.TabStop = False
        Me.DisplayDriverBrowse.UseVisualStyleBackColor = True
        '
        'DisplayDriver
        '
        resources.ApplyResources(Me.DisplayDriver, "DisplayDriver")
        Me.DisplayDriver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayDriver.Name = "DisplayDriver"
        Me.DisplayDriver.TabStop = False
        '
        'DisplayDriverLabel
        '
        resources.ApplyResources(Me.DisplayDriverLabel, "DisplayDriverLabel")
        Me.DisplayDriverLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayDriverLabel.Name = "DisplayDriverLabel"
        '
        'DisplayFrequency
        '
        resources.ApplyResources(Me.DisplayFrequency, "DisplayFrequency")
        Me.DisplayFrequency.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayFrequency.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DisplayFrequency.Maximum = New Decimal(New Integer() {140, 0, 0, 0})
        Me.DisplayFrequency.Name = "DisplayFrequency"
        Me.DisplayFrequency.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'DisplayRedrawLabel
        '
        resources.ApplyResources(Me.DisplayRedrawLabel, "DisplayRedrawLabel")
        Me.DisplayRedrawLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayRedrawLabel.Name = "DisplayRedrawLabel"
        Me.DisplayRedrawLabel.TabStop = False
        '
        'NetworkFrame
        '
        Me.NetworkFrame.Controls.Add(Me.Net8139Enable)
        Me.NetworkFrame.Controls.Add(Me.Net8139MacLabel)
        Me.NetworkFrame.Controls.Add(Me.Net8139Mac1)
        Me.NetworkFrame.Controls.Add(Me.Net8139Mac2)
        Me.NetworkFrame.Controls.Add(Me.Net8139Mac3)
        Me.NetworkFrame.Controls.Add(Me.Net8139Mac4)
        Me.NetworkFrame.Controls.Add(Me.Net8139Mac5)
        Me.NetworkFrame.Controls.Add(Me.Net8139Mac6)
        Me.NetworkFrame.Controls.Add(Me.Net3c90xEnable)
        Me.NetworkFrame.Controls.Add(Me.Net3c90MacLabel)
        Me.NetworkFrame.Controls.Add(Me.Net3c90Mac6)
        Me.NetworkFrame.Controls.Add(Me.Net3c90Mac5)
        Me.NetworkFrame.Controls.Add(Me.Net3c90Mac4)
        Me.NetworkFrame.Controls.Add(Me.Net3c90Mac3)
        Me.NetworkFrame.Controls.Add(Me.Net3c90Mac2)
        Me.NetworkFrame.Controls.Add(Me.Net3c90Mac1)
        resources.ApplyResources(Me.NetworkFrame, "NetworkFrame")
        Me.NetworkFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NetworkFrame.Name = "NetworkFrame"
        Me.NetworkFrame.TabStop = False
        '
        'Net8139Enable
        '
        resources.ApplyResources(Me.Net8139Enable, "Net8139Enable")
        Me.Net8139Enable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Enable.Name = "Net8139Enable"
        Me.Net8139Enable.UseVisualStyleBackColor = True
        '
        'Net8139Mac1
        '
        Me.Net8139Mac1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net8139Mac1, "Net8139Mac1")
        Me.Net8139Mac1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Mac1.Name = "Net8139Mac1"
        '
        'Net8139Mac2
        '
        Me.Net8139Mac2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net8139Mac2, "Net8139Mac2")
        Me.Net8139Mac2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139Mac2.Name = "Net8139Mac2"
        '
        'Net3c90xEnable
        '
        resources.ApplyResources(Me.Net3c90xEnable, "Net3c90xEnable")
        Me.Net3c90xEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90xEnable.Name = "Net3c90xEnable"
        Me.Net3c90xEnable.UseVisualStyleBackColor = True
        '
        'Net3c90Mac6
        '
        Me.Net3c90Mac6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net3c90Mac6, "Net3c90Mac6")
        Me.Net3c90Mac6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90Mac6.Name = "Net3c90Mac6"
        '
        'Net3c90Mac5
        '
        Me.Net3c90Mac5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net3c90Mac5, "Net3c90Mac5")
        Me.Net3c90Mac5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90Mac5.Name = "Net3c90Mac5"
        '
        'Net3c90Mac4
        '
        Me.Net3c90Mac4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net3c90Mac4, "Net3c90Mac4")
        Me.Net3c90Mac4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90Mac4.Name = "Net3c90Mac4"
        '
        'Net3c90Mac3
        '
        Me.Net3c90Mac3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net3c90Mac3, "Net3c90Mac3")
        Me.Net3c90Mac3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90Mac3.Name = "Net3c90Mac3"
        '
        'Net3c90Mac2
        '
        Me.Net3c90Mac2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net3c90Mac2, "Net3c90Mac2")
        Me.Net3c90Mac2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90Mac2.Name = "Net3c90Mac2"
        '
        'Net3c90Mac1
        '
        Me.Net3c90Mac1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.Net3c90Mac1, "Net3c90Mac1")
        Me.Net3c90Mac1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90Mac1.Name = "Net3c90Mac1"
        '
        'DisplayRedraw
        '
        resources.ApplyResources(Me.DisplayRedraw, "DisplayRedraw")
        Me.DisplayRedraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayRedraw.Name = "DisplayRedraw"
        '
        'DisplayFullscreenKey
        '
        resources.ApplyResources(Me.DisplayFullscreenKey, "DisplayFullscreenKey")
        Me.DisplayFullscreenKey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayFullscreenKey.Name = "DisplayFullscreenKey"
        '
        'DisplayFrame
        '
        Me.DisplayFrame.Controls.Add(Me.DisplayResY)
        Me.DisplayFrame.Controls.Add(Me.DisplayResX)
        Me.DisplayFrame.Controls.Add(Me.DisplayResLabel)
        Me.DisplayFrame.Controls.Add(Me.DisplayColourDepth)
        Me.DisplayFrame.Controls.Add(Me.DisplayFrequency)
        Me.DisplayFrame.Controls.Add(Me.DisplayFullscreenStart)
        Me.DisplayFrame.Controls.Add(Me.DisplayResCustom)
        Me.DisplayFrame.Controls.Add(Me.DisplayDriver)
        Me.DisplayFrame.Controls.Add(Me.DisplayDriverLabel)
        Me.DisplayFrame.Controls.Add(Me.DisplayDriverBrowse)
        Me.DisplayFrame.Controls.Add(Me.DisplayRedraw)
        Me.DisplayFrame.Controls.Add(Me.DisplayRedrawLabel)
        Me.DisplayFrame.Controls.Add(Me.DisplayFullscreenKey)
        Me.DisplayFrame.Controls.Add(Me.DisplayFullscreenKeyLabel)
        resources.ApplyResources(Me.DisplayFrame, "DisplayFrame")
        Me.DisplayFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayFrame.Name = "DisplayFrame"
        Me.DisplayFrame.TabStop = False
        '
        'DisplayResY
        '
        Me.DisplayResY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayResY.FormattingEnabled = True
        Me.DisplayResY.Items.AddRange(New Object() {resources.GetString("DisplayResY.Items"), resources.GetString("DisplayResY.Items1"), resources.GetString("DisplayResY.Items2"), resources.GetString("DisplayResY.Items3"), resources.GetString("DisplayResY.Items4"), resources.GetString("DisplayResY.Items5"), resources.GetString("DisplayResY.Items6"), resources.GetString("DisplayResY.Items7"), resources.GetString("DisplayResY.Items8"), resources.GetString("DisplayResY.Items9"), resources.GetString("DisplayResY.Items10"), resources.GetString("DisplayResY.Items11"), resources.GetString("DisplayResY.Items12"), resources.GetString("DisplayResY.Items13"), resources.GetString("DisplayResY.Items14"), resources.GetString("DisplayResY.Items15"), resources.GetString("DisplayResY.Items16"), resources.GetString("DisplayResY.Items17"), resources.GetString("DisplayResY.Items18"), resources.GetString("DisplayResY.Items19"), resources.GetString("DisplayResY.Items20")})
        resources.ApplyResources(Me.DisplayResY, "DisplayResY")
        Me.DisplayResY.Name = "DisplayResY"
        '
        'DisplayResX
        '
        Me.DisplayResX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayResX.FormattingEnabled = True
        Me.DisplayResX.Items.AddRange(New Object() {resources.GetString("DisplayResX.Items"), resources.GetString("DisplayResX.Items1"), resources.GetString("DisplayResX.Items2"), resources.GetString("DisplayResX.Items3"), resources.GetString("DisplayResX.Items4"), resources.GetString("DisplayResX.Items5"), resources.GetString("DisplayResX.Items6"), resources.GetString("DisplayResX.Items7"), resources.GetString("DisplayResX.Items8"), resources.GetString("DisplayResX.Items9"), resources.GetString("DisplayResX.Items10"), resources.GetString("DisplayResX.Items11"), resources.GetString("DisplayResX.Items12"), resources.GetString("DisplayResX.Items13"), resources.GetString("DisplayResX.Items14"), resources.GetString("DisplayResX.Items15"), resources.GetString("DisplayResX.Items16"), resources.GetString("DisplayResX.Items17"), resources.GetString("DisplayResX.Items18"), resources.GetString("DisplayResX.Items19")})
        resources.ApplyResources(Me.DisplayResX, "DisplayResX")
        Me.DisplayResX.Name = "DisplayResX"
        '
        'DisplayResLabel
        '
        resources.ApplyResources(Me.DisplayResLabel, "DisplayResLabel")
        Me.DisplayResLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayResLabel.Name = "DisplayResLabel"
        '
        'DisplayColourDepth
        '
        Me.DisplayColourDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.DisplayColourDepth, "DisplayColourDepth")
        Me.DisplayColourDepth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayColourDepth.FormattingEnabled = True
        Me.DisplayColourDepth.Items.AddRange(New Object() {resources.GetString("DisplayColourDepth.Items"), resources.GetString("DisplayColourDepth.Items1")})
        Me.DisplayColourDepth.Name = "DisplayColourDepth"
        '
        'DisplayFullscreenStart
        '
        resources.ApplyResources(Me.DisplayFullscreenStart, "DisplayFullscreenStart")
        Me.DisplayFullscreenStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayFullscreenStart.Name = "DisplayFullscreenStart"
        Me.DisplayFullscreenStart.UseVisualStyleBackColor = True
        '
        'DisplayResCustom
        '
        resources.ApplyResources(Me.DisplayResCustom, "DisplayResCustom")
        Me.DisplayResCustom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayResCustom.Name = "DisplayResCustom"
        Me.DisplayResCustom.UseVisualStyleBackColor = True
        '
        'DisplayFullscreenKeyLabel
        '
        resources.ApplyResources(Me.DisplayFullscreenKeyLabel, "DisplayFullscreenKeyLabel")
        Me.DisplayFullscreenKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayFullscreenKeyLabel.Name = "DisplayFullscreenKeyLabel"
        '
        'DriveFrame
        '
        Me.DriveFrame.Controls.Add(Me.DriveMasterEnabled)
        Me.DriveFrame.Controls.Add(Me.DriveMasterType)
        Me.DriveFrame.Controls.Add(Me.DriveMasterTypeLabel)
        Me.DriveFrame.Controls.Add(Me.DriveMasterPath)
        Me.DriveFrame.Controls.Add(Me.DriveMasterPathLabel)
        Me.DriveFrame.Controls.Add(Me.DriveMasterBrowse)
        Me.DriveFrame.Controls.Add(Me.DriveSlaveEnabled)
        Me.DriveFrame.Controls.Add(Me.DriveSlaveType)
        Me.DriveFrame.Controls.Add(Me.DriveSlaveTypeLabel)
        Me.DriveFrame.Controls.Add(Me.DriveSlavePath)
        Me.DriveFrame.Controls.Add(Me.DriveSlavePathLabel)
        Me.DriveFrame.Controls.Add(Me.DriveSlaveBrowse)
        resources.ApplyResources(Me.DriveFrame, "DriveFrame")
        Me.DriveFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveFrame.Name = "DriveFrame"
        Me.DriveFrame.TabStop = False
        '
        'DriveMasterEnabled
        '
        resources.ApplyResources(Me.DriveMasterEnabled, "DriveMasterEnabled")
        Me.DriveMasterEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveMasterEnabled.Name = "DriveMasterEnabled"
        Me.DriveMasterEnabled.UseVisualStyleBackColor = True
        '
        'DriveMasterType
        '
        Me.DriveMasterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.DriveMasterType, "DriveMasterType")
        Me.DriveMasterType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveMasterType.FormattingEnabled = True
        Me.DriveMasterType.Items.AddRange(New Object() {resources.GetString("DriveMasterType.Items"), resources.GetString("DriveMasterType.Items1"), resources.GetString("DriveMasterType.Items2")})
        Me.DriveMasterType.Name = "DriveMasterType"
        Me.DriveMasterType.TabStop = False
        '
        'DriveMasterTypeLabel
        '
        resources.ApplyResources(Me.DriveMasterTypeLabel, "DriveMasterTypeLabel")
        Me.DriveMasterTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveMasterTypeLabel.Name = "DriveMasterTypeLabel"
        '
        'DriveMasterPath
        '
        resources.ApplyResources(Me.DriveMasterPath, "DriveMasterPath")
        Me.DriveMasterPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveMasterPath.Name = "DriveMasterPath"
        '
        'DriveMasterPathLabel
        '
        resources.ApplyResources(Me.DriveMasterPathLabel, "DriveMasterPathLabel")
        Me.DriveMasterPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveMasterPathLabel.Name = "DriveMasterPathLabel"
        '
        'DriveMasterBrowse
        '
        resources.ApplyResources(Me.DriveMasterBrowse, "DriveMasterBrowse")
        Me.DriveMasterBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveMasterBrowse.Name = "DriveMasterBrowse"
        Me.DriveMasterBrowse.UseVisualStyleBackColor = True
        '
        'DriveSlaveEnabled
        '
        resources.ApplyResources(Me.DriveSlaveEnabled, "DriveSlaveEnabled")
        Me.DriveSlaveEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveSlaveEnabled.Name = "DriveSlaveEnabled"
        Me.DriveSlaveEnabled.UseVisualStyleBackColor = True
        '
        'DriveSlaveType
        '
        Me.DriveSlaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.DriveSlaveType, "DriveSlaveType")
        Me.DriveSlaveType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveSlaveType.FormattingEnabled = True
        Me.DriveSlaveType.Items.AddRange(New Object() {resources.GetString("DriveSlaveType.Items"), resources.GetString("DriveSlaveType.Items1"), resources.GetString("DriveSlaveType.Items2")})
        Me.DriveSlaveType.Name = "DriveSlaveType"
        '
        'DriveSlaveTypeLabel
        '
        resources.ApplyResources(Me.DriveSlaveTypeLabel, "DriveSlaveTypeLabel")
        Me.DriveSlaveTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveSlaveTypeLabel.Name = "DriveSlaveTypeLabel"
        '
        'DriveSlavePath
        '
        resources.ApplyResources(Me.DriveSlavePath, "DriveSlavePath")
        Me.DriveSlavePath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveSlavePath.Name = "DriveSlavePath"
        '
        'DriveSlavePathLabel
        '
        resources.ApplyResources(Me.DriveSlavePathLabel, "DriveSlavePathLabel")
        Me.DriveSlavePathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveSlavePathLabel.Name = "DriveSlavePathLabel"
        '
        'DriveSlaveBrowse
        '
        resources.ApplyResources(Me.DriveSlaveBrowse, "DriveSlaveBrowse")
        Me.DriveSlaveBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DriveSlaveBrowse.Name = "DriveSlaveBrowse"
        Me.DriveSlaveBrowse.UseVisualStyleBackColor = True
        '
        'Browser
        '
        resources.ApplyResources(Me.Browser, "Browser")
        '
        'SaveConfigFile
        '
        Me.SaveConfigFile.FileName = "PearPC"
        resources.ApplyResources(Me.SaveConfigFile, "SaveConfigFile")
        '
        'SelectDrive
        '
        resources.ApplyResources(Me.SelectDrive, "SelectDrive")
        Me.SelectDrive.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.SelectDrive.ShowNewFolderButton = False
        '
        'OptionList
        '
        Me.OptionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Options, Me.Value})
        Me.OptionList.FullRowSelect = True
        Me.OptionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionList.Items.AddRange(New System.Windows.Forms.ListViewItem() {CType(resources.GetObject("OptionList.Items"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items1"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items2"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items3"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items4"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items5"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items6"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionList.Items7"), System.Windows.Forms.ListViewItem)})
        resources.ApplyResources(Me.OptionList, "OptionList")
        Me.OptionList.Name = "OptionList"
        Me.OptionList.UseCompatibleStateImageBehavior = False
        Me.OptionList.View = System.Windows.Forms.View.Details
        '
        'Options
        '
        resources.ApplyResources(Me.Options, "Options")
        '
        'Value
        '
        resources.ApplyResources(Me.Value, "Value")
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdOK, "cmdOK")
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'GroupContainer
        '
        Me.GroupContainer.Controls.Add(Me.MiscFrame)
        Me.GroupContainer.Controls.Add(Me.NetworkFrame)
        Me.GroupContainer.Controls.Add(Me.DriveFrame)
        Me.GroupContainer.Controls.Add(Me.IconFrame)
        Me.GroupContainer.Controls.Add(Me.MacNameFrame)
        Me.GroupContainer.Controls.Add(Me.DisplayFrame)
        Me.GroupContainer.Controls.Add(Me.BoardFrame)
        resources.ApplyResources(Me.GroupContainer, "GroupContainer")
        Me.GroupContainer.Name = "GroupContainer"
        '
        'IconFrame
        '
        Me.IconFrame.Controls.Add(Me.IconAdd)
        Me.IconFrame.Controls.Add(Me.IconList)
        Me.IconFrame.Controls.Add(Me.IconInfo)
        resources.ApplyResources(Me.IconFrame, "IconFrame")
        Me.IconFrame.Name = "IconFrame"
        Me.IconFrame.TabStop = False
        '
        'IconAdd
        '
        resources.ApplyResources(Me.IconAdd, "IconAdd")
        Me.IconAdd.Name = "IconAdd"
        Me.IconAdd.UseVisualStyleBackColor = True
        '
        'IconList
        '
        resources.ApplyResources(Me.IconList, "IconList")
        Me.IconList.Name = "IconList"
        Me.IconList.UseCompatibleStateImageBehavior = False
        '
        'IconInfo
        '
        resources.ApplyResources(Me.IconInfo, "IconInfo")
        Me.IconInfo.Name = "IconInfo"
        '
        'MacNameFrame
        '
        Me.MacNameFrame.Controls.Add(Me.MacName)
        Me.MacNameFrame.Controls.Add(Me.MacNameLabel)
        resources.ApplyResources(Me.MacNameFrame, "MacNameFrame")
        Me.MacNameFrame.Name = "MacNameFrame"
        Me.MacNameFrame.TabStop = False
        '
        'MacName
        '
        resources.ApplyResources(Me.MacName, "MacName")
        Me.MacName.Name = "MacName"
        '
        'MacNameLabel
        '
        resources.ApplyResources(Me.MacNameLabel, "MacNameLabel")
        Me.MacNameLabel.Name = "MacNameLabel"
        '
        'FileBrowserDialog
        '
        resources.ApplyResources(Me.FileBrowserDialog, "FileBrowserDialog")
        '
        'frmSettingsPearPCVM
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OptionList)
        Me.Controls.Add(Me.GroupContainer)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsPearPCVM"
        Me.BoardFrame.ResumeLayout(False)
        Me.BoardFrame.PerformLayout()
        CType(Me.BoardRAMSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiscFrame.ResumeLayout(False)
        Me.MiscFrame.PerformLayout()
        CType(Me.DisplayFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NetworkFrame.ResumeLayout(False)
        Me.NetworkFrame.PerformLayout()
        Me.DisplayFrame.ResumeLayout(False)
        Me.DisplayFrame.PerformLayout()
        Me.DriveFrame.ResumeLayout(False)
        Me.DriveFrame.PerformLayout()
        Me.GroupContainer.ResumeLayout(False)
        Me.IconFrame.ResumeLayout(False)
        Me.IconFrame.PerformLayout()
        Me.MacNameFrame.ResumeLayout(False)
        Me.MacNameFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BoardSerialEnable As System.Windows.Forms.CheckBox
    Friend WithEvents BoardComposeDialogKeyLabel As System.Windows.Forms.Label
    Friend WithEvents BoardComposeDialogKey As System.Windows.Forms.TextBox
    Friend WithEvents BoardChangeCDKeyLabel As System.Windows.Forms.Label
    Friend WithEvents BoardChangeCDKey As System.Windows.Forms.TextBox
    Friend WithEvents BoardMouseGrabKeyLabel As System.Windows.Forms.Label
    Friend WithEvents BoardUSBEnable As System.Windows.Forms.CheckBox
    Friend WithEvents BoardMouseGrabKey As System.Windows.Forms.TextBox
    Friend WithEvents BoardRAMLabelMB As System.Windows.Forms.Label
    Friend WithEvents BoardRAM As System.Windows.Forms.TextBox
    Friend WithEvents BoardProcessorLabel As System.Windows.Forms.Label
    Friend WithEvents Net3c90MacLabel As System.Windows.Forms.Label
    Friend WithEvents Net8139Mac6 As System.Windows.Forms.TextBox
    Friend WithEvents Net8139Mac5 As System.Windows.Forms.TextBox
    Friend WithEvents BoardRAMLabel As System.Windows.Forms.Label
    Friend WithEvents Net8139Mac4 As System.Windows.Forms.TextBox
    Friend WithEvents Net8139Mac3 As System.Windows.Forms.TextBox
    Friend WithEvents BoardFrame As System.Windows.Forms.GroupBox
    Friend WithEvents BoardProcessorG4 As System.Windows.Forms.RadioButton
    Friend WithEvents BoardProcessorG3 As System.Windows.Forms.RadioButton
    Friend WithEvents MiscPageTable As System.Windows.Forms.TextBox
    Friend WithEvents MiscPageTableLabel As System.Windows.Forms.Label
    Friend WithEvents MiscNVRAMFileLabel As System.Windows.Forms.Label
    Friend WithEvents MiscNVRAMFile As System.Windows.Forms.TextBox
    Friend WithEvents MiscBootModeLabel As System.Windows.Forms.Label
    Friend WithEvents MiscBootModeAuto As System.Windows.Forms.RadioButton
    Friend WithEvents MiscBootModeSelect As System.Windows.Forms.RadioButton
    Friend WithEvents MiscBootModeForce As System.Windows.Forms.RadioButton
    Friend WithEvents MiscFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MiscAdvancedInfo As System.Windows.Forms.Label
    Friend WithEvents MiscMachArguments As System.Windows.Forms.TextBox
    Friend WithEvents MiscPROMBootArgs As System.Windows.Forms.TextBox
    Friend WithEvents MiscMachArgumentsLabel As System.Windows.Forms.Label
    Friend WithEvents MiscPROMBootArgsLabel As System.Windows.Forms.Label
    Friend WithEvents MiscPROMBootPath As System.Windows.Forms.TextBox
    Friend WithEvents MiscPROMFile As System.Windows.Forms.TextBox
    Friend WithEvents MiscPROMBootPathLabel As System.Windows.Forms.Label
    Friend WithEvents MiscPROMFileLabel As System.Windows.Forms.Label
    Friend WithEvents Net8139MacLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayDriverBrowse As System.Windows.Forms.Button
    Friend WithEvents DisplayDriver As System.Windows.Forms.TextBox
    Friend WithEvents DisplayDriverLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayFrequency As System.Windows.Forms.NumericUpDown
    Friend WithEvents DisplayRedrawLabel As System.Windows.Forms.TextBox
    Friend WithEvents NetworkFrame As System.Windows.Forms.GroupBox
    Friend WithEvents Net8139Mac2 As System.Windows.Forms.TextBox
    Friend WithEvents Net8139Mac1 As System.Windows.Forms.TextBox
    Friend WithEvents Net3c90Mac6 As System.Windows.Forms.TextBox
    Friend WithEvents Net3c90Mac5 As System.Windows.Forms.TextBox
    Friend WithEvents Net3c90Mac4 As System.Windows.Forms.TextBox
    Friend WithEvents Net3c90Mac3 As System.Windows.Forms.TextBox
    Friend WithEvents Net3c90Mac2 As System.Windows.Forms.TextBox
    Friend WithEvents Net3c90Mac1 As System.Windows.Forms.TextBox
    Friend WithEvents Net8139Enable As System.Windows.Forms.CheckBox
    Friend WithEvents Net3c90xEnable As System.Windows.Forms.CheckBox
    Friend WithEvents DisplayRedraw As System.Windows.Forms.Label
    Friend WithEvents DisplayFullscreenKey As System.Windows.Forms.TextBox
    Friend WithEvents DisplayFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DisplayResLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayColourDepth As System.Windows.Forms.ComboBox
    Friend WithEvents DisplayFullscreenKeyLabel As System.Windows.Forms.Label
    Friend WithEvents DisplayResCustom As System.Windows.Forms.CheckBox
    Friend WithEvents DisplayFullscreenStart As System.Windows.Forms.CheckBox
    Friend WithEvents DriveFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DriveSlaveBrowse As System.Windows.Forms.Button
    Friend WithEvents DriveSlaveTypeLabel As System.Windows.Forms.Label
    Friend WithEvents DriveSlavePathLabel As System.Windows.Forms.Label
    Friend WithEvents DriveSlavePath As System.Windows.Forms.TextBox
    Friend WithEvents DriveSlaveEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents DriveSlaveType As System.Windows.Forms.ComboBox
    Friend WithEvents DriveMasterBrowse As System.Windows.Forms.Button
    Friend WithEvents DriveMasterTypeLabel As System.Windows.Forms.Label
    Friend WithEvents DriveMasterPathLabel As System.Windows.Forms.Label
    Friend WithEvents DriveMasterPath As System.Windows.Forms.TextBox
    Friend WithEvents DriveMasterEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents DriveMasterType As System.Windows.Forms.ComboBox
    Friend WithEvents Browser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveConfigFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SelectDrive As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OptionList As System.Windows.Forms.ListView
    Friend WithEvents Options As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents GroupContainer As System.Windows.Forms.Panel
    Friend WithEvents MacNameFrame As System.Windows.Forms.GroupBox
    Friend WithEvents MacName As System.Windows.Forms.TextBox
    Friend WithEvents MacNameLabel As System.Windows.Forms.Label
    Friend WithEvents IconFrame As System.Windows.Forms.GroupBox
    Friend WithEvents IconAdd As System.Windows.Forms.Button
    Friend WithEvents IconList As System.Windows.Forms.ListView
    Friend WithEvents IconInfo As System.Windows.Forms.Label
    Friend WithEvents DisplayResX As System.Windows.Forms.ComboBox
    Friend WithEvents DisplayResY As System.Windows.Forms.ComboBox
    Friend WithEvents MiscInfo As System.Windows.Forms.Label
    Friend WithEvents BoardRAMSlider As System.Windows.Forms.TrackBar
    Friend WithEvents FileBrowserDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MiscNVRAMFileBrowse As System.Windows.Forms.Button
    Friend WithEvents MiscPROMBootPathBrowse As System.Windows.Forms.Button
    Friend WithEvents MiscPROMFileBrowse As System.Windows.Forms.Button
End Class
