<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewMac
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewMac))
        Me.FormButtons = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.Wizard = New System.Windows.Forms.Panel
        Me.AddExisting = New System.Windows.Forms.Panel
        Me.AEName = New System.Windows.Forms.TextBox
        Me.AENameLabel = New System.Windows.Forms.Label
        Me.AEFileLabel = New System.Windows.Forms.Label
        Me.AEEmulatorTypeLabel = New System.Windows.Forms.Label
        Me.AEEmulatorType = New System.Windows.Forms.ComboBox
        Me.AEInfo = New System.Windows.Forms.Label
        Me.AEBrowseFile = New System.Windows.Forms.Button
        Me.AEFile = New System.Windows.Forms.TextBox
        Me.SelectType = New System.Windows.Forms.Panel
        Me.DontUseWizardDescription = New System.Windows.Forms.Label
        Me.DontUseWizard = New System.Windows.Forms.RadioButton
        Me.AddFromFileDescription = New System.Windows.Forms.Label
        Me.UseWizardDescription = New System.Windows.Forms.Label
        Me.AddFromFile = New System.Windows.Forms.RadioButton
        Me.UseWizard = New System.Windows.Forms.RadioButton
        Me.SelectTypeDescription = New System.Windows.Forms.Label
        Me.SelectDisk = New System.Windows.Forms.Panel
        Me.NoDisk = New System.Windows.Forms.RadioButton
        Me.BrowseDiskLocation = New System.Windows.Forms.Button
        Me.DiskPath = New System.Windows.Forms.TextBox
        Me.SelectDiskDescription = New System.Windows.Forms.Label
        Me.ExistingDisk = New System.Windows.Forms.RadioButton
        Me.NewDisk = New System.Windows.Forms.RadioButton
        Me.DiskTools = New System.Windows.Forms.Panel
        Me.DiskSizeLabel = New System.Windows.Forms.Label
        Me.DiskSize = New System.Windows.Forms.NumericUpDown
        Me.DiskMBLabel = New System.Windows.Forms.Label
        Me.HwPresets = New System.Windows.Forms.Panel
        Me.RecHwLabel = New System.Windows.Forms.Label
        Me.OSListDescription = New System.Windows.Forms.Label
        Me.HwPresetsDescription = New System.Windows.Forms.Label
        Me.DefMem = New System.Windows.Forms.Label
        Me.DefDisk = New System.Windows.Forms.Label
        Me.DefCPU = New System.Windows.Forms.Label
        Me.DefCPULabel = New System.Windows.Forms.Label
        Me.DefDiskLabel = New System.Windows.Forms.Label
        Me.DefMemLabel = New System.Windows.Forms.Label
        Me.OSList = New System.Windows.Forms.ComboBox
        Me.CreateNew = New System.Windows.Forms.Panel
        Me.SaveMac = New System.Windows.Forms.Button
        Me.MacName = New System.Windows.Forms.TextBox
        Me.CreateNewDescription = New System.Windows.Forms.Label
        Me.AssignRAM = New System.Windows.Forms.Panel
        Me.RecommendedRAM = New System.Windows.Forms.Label
        Me.AssignRAMDescription = New System.Windows.Forms.Label
        Me.CustomRAM = New System.Windows.Forms.RadioButton
        Me.DefaultRAM = New System.Windows.Forms.RadioButton
        Me.CustomRAMContainer = New System.Windows.Forms.Panel
        Me.WarningInvalidSize = New System.Windows.Forms.Label
        Me.RAMSlider = New System.Windows.Forms.TrackBar
        Me.RamMBLabel = New System.Windows.Forms.Label
        Me.RAM = New System.Windows.Forms.TextBox
        Me.DescriptionContainer = New System.Windows.Forms.GroupBox
        Me.Description = New System.Windows.Forms.Label
        Me.DescriptionName = New System.Windows.Forms.Label
        Me.Open = New System.Windows.Forms.OpenFileDialog
        Me.Save = New System.Windows.Forms.SaveFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Welcome = New System.Windows.Forms.Panel
        Me.WelcomeDescription = New System.Windows.Forms.Label
        Me.WelcomeTitle = New System.Windows.Forms.Label
        Me.EndWizard = New System.Windows.Forms.Panel
        Me.MachineDisk = New System.Windows.Forms.Label
        Me.MachineMemory = New System.Windows.Forms.Label
        Me.MachineName = New System.Windows.Forms.Label
        Me.FinishDescription = New System.Windows.Forms.Label
        Me.DiskLabel = New System.Windows.Forms.Label
        Me.MemoryLabel = New System.Windows.Forms.Label
        Me.NameLabel = New System.Windows.Forms.Label
        Me.EndDescription = New System.Windows.Forms.Label
        Me.EndTitle = New System.Windows.Forms.Label
        Me.FormButtons.SuspendLayout()
        Me.Wizard.SuspendLayout()
        Me.AddExisting.SuspendLayout()
        Me.SelectType.SuspendLayout()
        Me.SelectDisk.SuspendLayout()
        Me.DiskTools.SuspendLayout()
        CType(Me.DiskSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HwPresets.SuspendLayout()
        Me.CreateNew.SuspendLayout()
        Me.AssignRAM.SuspendLayout()
        Me.CustomRAMContainer.SuspendLayout()
        CType(Me.RAMSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescriptionContainer.SuspendLayout()
        Me.Welcome.SuspendLayout()
        Me.EndWizard.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormButtons
        '
        Me.FormButtons.Controls.Add(Me.cmdCancel)
        Me.FormButtons.Controls.Add(Me.cmdNext)
        Me.FormButtons.Controls.Add(Me.cmdBack)
        Me.FormButtons.Location = New System.Drawing.Point(-1, 307)
        Me.FormButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.FormButtons.Name = "FormButtons"
        Me.FormButtons.Size = New System.Drawing.Size(499, 54)
        Me.FormButtons.TabIndex = 0
        Me.FormButtons.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(412, 13)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(327, 13)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "&Next >"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(252, 13)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 0
        Me.cmdBack.Text = "< &Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Wizard
        '
        Me.Wizard.BackColor = System.Drawing.SystemColors.Control
        Me.Wizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Wizard.Controls.Add(Me.AddExisting)
        Me.Wizard.Controls.Add(Me.SelectType)
        Me.Wizard.Controls.Add(Me.SelectDisk)
        Me.Wizard.Controls.Add(Me.HwPresets)
        Me.Wizard.Controls.Add(Me.CreateNew)
        Me.Wizard.Controls.Add(Me.AssignRAM)
        Me.Wizard.Controls.Add(Me.DescriptionContainer)
        Me.Wizard.Location = New System.Drawing.Point(0, 0)
        Me.Wizard.Margin = New System.Windows.Forms.Padding(0)
        Me.Wizard.Name = "Wizard"
        Me.Wizard.Size = New System.Drawing.Size(497, 313)
        Me.Wizard.TabIndex = 2
        '
        'AddExisting
        '
        Me.AddExisting.Controls.Add(Me.AEName)
        Me.AddExisting.Controls.Add(Me.AENameLabel)
        Me.AddExisting.Controls.Add(Me.AEFileLabel)
        Me.AddExisting.Controls.Add(Me.AEEmulatorTypeLabel)
        Me.AddExisting.Controls.Add(Me.AEEmulatorType)
        Me.AddExisting.Controls.Add(Me.AEInfo)
        Me.AddExisting.Controls.Add(Me.AEBrowseFile)
        Me.AddExisting.Controls.Add(Me.AEFile)
        Me.AddExisting.Location = New System.Drawing.Point(0, 59)
        Me.AddExisting.Name = "AddExisting"
        Me.AddExisting.Size = New System.Drawing.Size(498, 245)
        Me.AddExisting.TabIndex = 3
        '
        'AEName
        '
        Me.AEName.Location = New System.Drawing.Point(30, 70)
        Me.AEName.Name = "AEName"
        Me.AEName.Size = New System.Drawing.Size(285, 21)
        Me.AEName.TabIndex = 4
        '
        'AENameLabel
        '
        Me.AENameLabel.AutoSize = True
        Me.AENameLabel.Location = New System.Drawing.Point(27, 48)
        Me.AENameLabel.Name = "AENameLabel"
        Me.AENameLabel.Size = New System.Drawing.Size(38, 13)
        Me.AENameLabel.TabIndex = 6
        Me.AENameLabel.Text = "Name:"
        '
        'AEFileLabel
        '
        Me.AEFileLabel.AutoSize = True
        Me.AEFileLabel.Location = New System.Drawing.Point(30, 103)
        Me.AEFileLabel.Name = "AEFileLabel"
        Me.AEFileLabel.Size = New System.Drawing.Size(27, 13)
        Me.AEFileLabel.TabIndex = 5
        Me.AEFileLabel.Text = "File:"
        '
        'AEEmulatorTypeLabel
        '
        Me.AEEmulatorTypeLabel.AutoSize = True
        Me.AEEmulatorTypeLabel.Location = New System.Drawing.Point(323, 48)
        Me.AEEmulatorTypeLabel.Name = "AEEmulatorTypeLabel"
        Me.AEEmulatorTypeLabel.Size = New System.Drawing.Size(53, 13)
        Me.AEEmulatorTypeLabel.TabIndex = 4
        Me.AEEmulatorTypeLabel.Text = "Emulator:"
        '
        'AEEmulatorType
        '
        Me.AEEmulatorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AEEmulatorType.FormattingEnabled = True
        Me.AEEmulatorType.Items.AddRange(New Object() {"Mini vMac Batch", "Virtual Mac MvM File", "Basilisk", "SheepShaver", "PearPC", "QEMU Windows Batch"})
        Me.AEEmulatorType.Location = New System.Drawing.Point(326, 70)
        Me.AEEmulatorType.Name = "AEEmulatorType"
        Me.AEEmulatorType.Size = New System.Drawing.Size(159, 21)
        Me.AEEmulatorType.TabIndex = 3
        '
        'AEInfo
        '
        Me.AEInfo.AutoSize = True
        Me.AEInfo.Location = New System.Drawing.Point(30, 20)
        Me.AEInfo.Name = "AEInfo"
        Me.AEInfo.Size = New System.Drawing.Size(234, 13)
        Me.AEInfo.TabIndex = 2
        Me.AEInfo.Text = "Select the file to add to the Virtual Mac Console"
        '
        'AEBrowseFile
        '
        Me.AEBrowseFile.Location = New System.Drawing.Point(410, 125)
        Me.AEBrowseFile.Name = "AEBrowseFile"
        Me.AEBrowseFile.Size = New System.Drawing.Size(75, 23)
        Me.AEBrowseFile.TabIndex = 6
        Me.AEBrowseFile.Text = "Browse"
        Me.AEBrowseFile.UseVisualStyleBackColor = True
        '
        'AEFile
        '
        Me.AEFile.Location = New System.Drawing.Point(30, 125)
        Me.AEFile.Name = "AEFile"
        Me.AEFile.Size = New System.Drawing.Size(371, 21)
        Me.AEFile.TabIndex = 5
        '
        'SelectType
        '
        Me.SelectType.Controls.Add(Me.DontUseWizardDescription)
        Me.SelectType.Controls.Add(Me.DontUseWizard)
        Me.SelectType.Controls.Add(Me.AddFromFileDescription)
        Me.SelectType.Controls.Add(Me.UseWizardDescription)
        Me.SelectType.Controls.Add(Me.AddFromFile)
        Me.SelectType.Controls.Add(Me.UseWizard)
        Me.SelectType.Controls.Add(Me.SelectTypeDescription)
        Me.SelectType.Location = New System.Drawing.Point(0, 59)
        Me.SelectType.Name = "SelectType"
        Me.SelectType.Size = New System.Drawing.Size(498, 245)
        Me.SelectType.TabIndex = 1
        '
        'DontUseWizardDescription
        '
        Me.DontUseWizardDescription.Location = New System.Drawing.Point(54, 60)
        Me.DontUseWizardDescription.Name = "DontUseWizardDescription"
        Me.DontUseWizardDescription.Size = New System.Drawing.Size(412, 33)
        Me.DontUseWizardDescription.TabIndex = 3
        Me.DontUseWizardDescription.Text = "Recommended for more users. Creates a Macintosh in base to the system you want to" & _
            " install on it."
        '
        'DontUseWizard
        '
        Me.DontUseWizard.AutoSize = True
        Me.DontUseWizard.Checked = True
        Me.DontUseWizard.Location = New System.Drawing.Point(57, 40)
        Me.DontUseWizard.Name = "DontUseWizard"
        Me.DontUseWizard.Size = New System.Drawing.Size(118, 17)
        Me.DontUseWizard.TabIndex = 0
        Me.DontUseWizard.TabStop = True
        Me.DontUseWizard.Text = "&Create a Macintosh"
        Me.DontUseWizard.UseVisualStyleBackColor = True
        '
        'AddFromFileDescription
        '
        Me.AddFromFileDescription.Location = New System.Drawing.Point(54, 175)
        Me.AddFromFileDescription.Name = "AddFromFileDescription"
        Me.AddFromFileDescription.Size = New System.Drawing.Size(412, 33)
        Me.AddFromFileDescription.TabIndex = 5
        Me.AddFromFileDescription.Text = "For Basilisk, SheepShaver and PearPC users. Creates a Macintosh from a file in yo" & _
            "ur physical machine."
        '
        'UseWizardDescription
        '
        Me.UseWizardDescription.Location = New System.Drawing.Point(54, 116)
        Me.UseWizardDescription.Name = "UseWizardDescription"
        Me.UseWizardDescription.Size = New System.Drawing.Size(412, 33)
        Me.UseWizardDescription.TabIndex = 4
        Me.UseWizardDescription.Text = "Recommended for advanced users. Creates a Macintosh guiding you to increase or de" & _
            "crease the resources you assign to this Macintosh."
        '
        'AddFromFile
        '
        Me.AddFromFile.AutoSize = True
        Me.AddFromFile.Location = New System.Drawing.Point(57, 155)
        Me.AddFromFile.Name = "AddFromFile"
        Me.AddFromFile.Size = New System.Drawing.Size(100, 17)
        Me.AddFromFile.TabIndex = 2
        Me.AddFromFile.Text = "Create from file"
        Me.AddFromFile.UseVisualStyleBackColor = True
        '
        'UseWizard
        '
        Me.UseWizard.AutoSize = True
        Me.UseWizard.Location = New System.Drawing.Point(57, 96)
        Me.UseWizard.Name = "UseWizard"
        Me.UseWizard.Size = New System.Drawing.Size(105, 17)
        Me.UseWizard.TabIndex = 1
        Me.UseWizard.Text = "Customise a Mac"
        Me.UseWizard.UseVisualStyleBackColor = True
        '
        'SelectTypeDescription
        '
        Me.SelectTypeDescription.AutoSize = True
        Me.SelectTypeDescription.Location = New System.Drawing.Point(47, 24)
        Me.SelectTypeDescription.Name = "SelectTypeDescription"
        Me.SelectTypeDescription.Size = New System.Drawing.Size(88, 13)
        Me.SelectTypeDescription.TabIndex = 0
        Me.SelectTypeDescription.Text = "Select an option:"
        '
        'SelectDisk
        '
        Me.SelectDisk.Controls.Add(Me.NoDisk)
        Me.SelectDisk.Controls.Add(Me.BrowseDiskLocation)
        Me.SelectDisk.Controls.Add(Me.DiskPath)
        Me.SelectDisk.Controls.Add(Me.SelectDiskDescription)
        Me.SelectDisk.Controls.Add(Me.ExistingDisk)
        Me.SelectDisk.Controls.Add(Me.NewDisk)
        Me.SelectDisk.Controls.Add(Me.DiskTools)
        Me.SelectDisk.Location = New System.Drawing.Point(0, 59)
        Me.SelectDisk.Name = "SelectDisk"
        Me.SelectDisk.Size = New System.Drawing.Size(498, 245)
        Me.SelectDisk.TabIndex = 7
        '
        'NoDisk
        '
        Me.NoDisk.AutoSize = True
        Me.NoDisk.Location = New System.Drawing.Point(25, 123)
        Me.NoDisk.Name = "NoDisk"
        Me.NoDisk.Size = New System.Drawing.Size(107, 17)
        Me.NoDisk.TabIndex = 16
        Me.NoDisk.Text = "Do not use a disk"
        Me.NoDisk.UseVisualStyleBackColor = True
        '
        'BrowseDiskLocation
        '
        Me.BrowseDiskLocation.Location = New System.Drawing.Point(395, 55)
        Me.BrowseDiskLocation.Name = "BrowseDiskLocation"
        Me.BrowseDiskLocation.Size = New System.Drawing.Size(75, 21)
        Me.BrowseDiskLocation.TabIndex = 21
        Me.BrowseDiskLocation.Text = "Browse..."
        Me.BrowseDiskLocation.UseVisualStyleBackColor = True
        '
        'DiskPath
        '
        Me.DiskPath.Location = New System.Drawing.Point(25, 55)
        Me.DiskPath.Name = "DiskPath"
        Me.DiskPath.Size = New System.Drawing.Size(364, 21)
        Me.DiskPath.TabIndex = 20
        '
        'SelectDiskDescription
        '
        Me.SelectDiskDescription.Location = New System.Drawing.Point(22, 15)
        Me.SelectDiskDescription.Name = "SelectDiskDescription"
        Me.SelectDiskDescription.Size = New System.Drawing.Size(445, 30)
        Me.SelectDiskDescription.TabIndex = 22
        Me.SelectDiskDescription.Text = "A Macintosh needs a disk to install the operating system. You can create a new di" & _
            "sk to install MacOS (Or Linux) or you can use an exisitng disk with a preinstall" & _
            "ed operating system."
        '
        'ExistingDisk
        '
        Me.ExistingDisk.AutoSize = True
        Me.ExistingDisk.Location = New System.Drawing.Point(25, 106)
        Me.ExistingDisk.Name = "ExistingDisk"
        Me.ExistingDisk.Size = New System.Drawing.Size(119, 17)
        Me.ExistingDisk.TabIndex = 15
        Me.ExistingDisk.Text = "Use an existing disk"
        Me.ExistingDisk.UseVisualStyleBackColor = True
        '
        'NewDisk
        '
        Me.NewDisk.AutoSize = True
        Me.NewDisk.Checked = True
        Me.NewDisk.Location = New System.Drawing.Point(25, 90)
        Me.NewDisk.Name = "NewDisk"
        Me.NewDisk.Size = New System.Drawing.Size(111, 17)
        Me.NewDisk.TabIndex = 14
        Me.NewDisk.TabStop = True
        Me.NewDisk.Text = "Create a new disk"
        Me.NewDisk.UseVisualStyleBackColor = True
        '
        'DiskTools
        '
        Me.DiskTools.Controls.Add(Me.DiskSizeLabel)
        Me.DiskTools.Controls.Add(Me.DiskSize)
        Me.DiskTools.Controls.Add(Me.DiskMBLabel)
        Me.DiskTools.Location = New System.Drawing.Point(229, 95)
        Me.DiskTools.Name = "DiskTools"
        Me.DiskTools.Size = New System.Drawing.Size(197, 25)
        Me.DiskTools.TabIndex = 17
        '
        'DiskSizeLabel
        '
        Me.DiskSizeLabel.AutoSize = True
        Me.DiskSizeLabel.Location = New System.Drawing.Point(3, 4)
        Me.DiskSizeLabel.Name = "DiskSizeLabel"
        Me.DiskSizeLabel.Size = New System.Drawing.Size(83, 13)
        Me.DiskSizeLabel.TabIndex = 17
        Me.DiskSizeLabel.Text = "Size of the disk:"
        '
        'DiskSize
        '
        Me.DiskSize.Location = New System.Drawing.Point(92, 2)
        Me.DiskSize.Maximum = New Decimal(New Integer() {130000, 0, 0, 0})
        Me.DiskSize.Name = "DiskSize"
        Me.DiskSize.Size = New System.Drawing.Size(68, 21)
        Me.DiskSize.TabIndex = 18
        '
        'DiskMBLabel
        '
        Me.DiskMBLabel.AutoSize = True
        Me.DiskMBLabel.Location = New System.Drawing.Point(162, 5)
        Me.DiskMBLabel.Name = "DiskMBLabel"
        Me.DiskMBLabel.Size = New System.Drawing.Size(21, 13)
        Me.DiskMBLabel.TabIndex = 19
        Me.DiskMBLabel.Text = "MB"
        '
        'HwPresets
        '
        Me.HwPresets.Controls.Add(Me.RecHwLabel)
        Me.HwPresets.Controls.Add(Me.OSListDescription)
        Me.HwPresets.Controls.Add(Me.HwPresetsDescription)
        Me.HwPresets.Controls.Add(Me.DefMem)
        Me.HwPresets.Controls.Add(Me.DefDisk)
        Me.HwPresets.Controls.Add(Me.DefCPU)
        Me.HwPresets.Controls.Add(Me.DefCPULabel)
        Me.HwPresets.Controls.Add(Me.DefDiskLabel)
        Me.HwPresets.Controls.Add(Me.DefMemLabel)
        Me.HwPresets.Controls.Add(Me.OSList)
        Me.HwPresets.Location = New System.Drawing.Point(0, 59)
        Me.HwPresets.Name = "HwPresets"
        Me.HwPresets.Size = New System.Drawing.Size(498, 245)
        Me.HwPresets.TabIndex = 4
        '
        'RecHwLabel
        '
        Me.RecHwLabel.Location = New System.Drawing.Point(236, 70)
        Me.RecHwLabel.Name = "RecHwLabel"
        Me.RecHwLabel.Size = New System.Drawing.Size(212, 28)
        Me.RecHwLabel.TabIndex = 9
        Me.RecHwLabel.Text = "Recommended hardware for this operating system:"
        '
        'OSListDescription
        '
        Me.OSListDescription.AutoSize = True
        Me.OSListDescription.Location = New System.Drawing.Point(22, 80)
        Me.OSListDescription.Name = "OSListDescription"
        Me.OSListDescription.Size = New System.Drawing.Size(88, 13)
        Me.OSListDescription.TabIndex = 8
        Me.OSListDescription.Text = "Select an option:"
        '
        'HwPresetsDescription
        '
        Me.HwPresetsDescription.Location = New System.Drawing.Point(22, 15)
        Me.HwPresetsDescription.Name = "HwPresetsDescription"
        Me.HwPresetsDescription.Size = New System.Drawing.Size(448, 50)
        Me.HwPresetsDescription.TabIndex = 7
        Me.HwPresetsDescription.Text = resources.GetString("HwPresetsDescription.Text")
        '
        'DefMem
        '
        Me.DefMem.Location = New System.Drawing.Point(345, 101)
        Me.DefMem.Name = "DefMem"
        Me.DefMem.Size = New System.Drawing.Size(103, 13)
        Me.DefMem.TabIndex = 6
        Me.DefMem.Text = "256 MB"
        Me.DefMem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DefDisk
        '
        Me.DefDisk.Location = New System.Drawing.Point(345, 125)
        Me.DefDisk.Name = "DefDisk"
        Me.DefDisk.Size = New System.Drawing.Size(103, 13)
        Me.DefDisk.TabIndex = 5
        Me.DefDisk.Text = "2048 MB"
        Me.DefDisk.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DefCPU
        '
        Me.DefCPU.Location = New System.Drawing.Point(345, 149)
        Me.DefCPU.Name = "DefCPU"
        Me.DefCPU.Size = New System.Drawing.Size(103, 13)
        Me.DefCPU.TabIndex = 4
        Me.DefCPU.Text = "Unknown"
        Me.DefCPU.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DefCPULabel
        '
        Me.DefCPULabel.AutoSize = True
        Me.DefCPULabel.Location = New System.Drawing.Point(236, 149)
        Me.DefCPULabel.Name = "DefCPULabel"
        Me.DefCPULabel.Size = New System.Drawing.Size(31, 13)
        Me.DefCPULabel.TabIndex = 3
        Me.DefCPULabel.Text = "CPU:"
        '
        'DefDiskLabel
        '
        Me.DefDiskLabel.AutoSize = True
        Me.DefDiskLabel.Location = New System.Drawing.Point(236, 125)
        Me.DefDiskLabel.Name = "DefDiskLabel"
        Me.DefDiskLabel.Size = New System.Drawing.Size(30, 13)
        Me.DefDiskLabel.TabIndex = 2
        Me.DefDiskLabel.Text = "Disk:"
        '
        'DefMemLabel
        '
        Me.DefMemLabel.AutoSize = True
        Me.DefMemLabel.Location = New System.Drawing.Point(236, 101)
        Me.DefMemLabel.Name = "DefMemLabel"
        Me.DefMemLabel.Size = New System.Drawing.Size(49, 13)
        Me.DefMemLabel.TabIndex = 1
        Me.DefMemLabel.Text = "Memory:"
        '
        'OSList
        '
        Me.OSList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OSList.FormattingEnabled = True
        Me.OSList.Items.AddRange(New Object() {"System Software 6", "System Software 7", "System Software 7 Pro", "Mac OS 8", "Mac OS 9", "Mac OS X", "Debian", "Lubuntu", "Other Linux", "Other"})
        Me.OSList.Location = New System.Drawing.Point(35, 101)
        Me.OSList.Name = "OSList"
        Me.OSList.Size = New System.Drawing.Size(158, 21)
        Me.OSList.TabIndex = 0
        '
        'CreateNew
        '
        Me.CreateNew.Controls.Add(Me.SaveMac)
        Me.CreateNew.Controls.Add(Me.MacName)
        Me.CreateNew.Controls.Add(Me.CreateNewDescription)
        Me.CreateNew.Location = New System.Drawing.Point(0, 59)
        Me.CreateNew.Name = "CreateNew"
        Me.CreateNew.Size = New System.Drawing.Size(498, 245)
        Me.CreateNew.TabIndex = 2
        '
        'SaveMac
        '
        Me.SaveMac.Location = New System.Drawing.Point(395, 68)
        Me.SaveMac.Name = "SaveMac"
        Me.SaveMac.Size = New System.Drawing.Size(75, 23)
        Me.SaveMac.TabIndex = 2
        Me.SaveMac.Text = "Browse..."
        Me.SaveMac.UseVisualStyleBackColor = True
        '
        'MacName
        '
        Me.MacName.Location = New System.Drawing.Point(25, 68)
        Me.MacName.Name = "MacName"
        Me.MacName.Size = New System.Drawing.Size(364, 21)
        Me.MacName.TabIndex = 1
        '
        'CreateNewDescription
        '
        Me.CreateNewDescription.Location = New System.Drawing.Point(22, 24)
        Me.CreateNewDescription.Name = "CreateNewDescription"
        Me.CreateNewDescription.Size = New System.Drawing.Size(448, 41)
        Me.CreateNewDescription.TabIndex = 0
        Me.CreateNewDescription.Text = "Give a name to your Macintosh, remember to make it descirptive, something like ""M" & _
            "ac OS 7"" or ""iMac G3"" are good examples. "
        '
        'AssignRAM
        '
        Me.AssignRAM.Controls.Add(Me.RecommendedRAM)
        Me.AssignRAM.Controls.Add(Me.AssignRAMDescription)
        Me.AssignRAM.Controls.Add(Me.CustomRAM)
        Me.AssignRAM.Controls.Add(Me.DefaultRAM)
        Me.AssignRAM.Controls.Add(Me.CustomRAMContainer)
        Me.AssignRAM.Location = New System.Drawing.Point(0, 59)
        Me.AssignRAM.Name = "AssignRAM"
        Me.AssignRAM.Size = New System.Drawing.Size(498, 245)
        Me.AssignRAM.TabIndex = 5
        '
        'RecommendedRAM
        '
        Me.RecommendedRAM.AutoSize = True
        Me.RecommendedRAM.Location = New System.Drawing.Point(47, 60)
        Me.RecommendedRAM.Name = "RecommendedRAM"
        Me.RecommendedRAM.Size = New System.Drawing.Size(199, 13)
        Me.RecommendedRAM.TabIndex = 6
        Me.RecommendedRAM.Text = "The recommended memory is [ %m MB ]"
        '
        'AssignRAMDescription
        '
        Me.AssignRAMDescription.Location = New System.Drawing.Point(47, 15)
        Me.AssignRAMDescription.Name = "AssignRAMDescription"
        Me.AssignRAMDescription.Size = New System.Drawing.Size(423, 42)
        Me.AssignRAMDescription.TabIndex = 4
        Me.AssignRAMDescription.Text = resources.GetString("AssignRAMDescription.Text")
        '
        'CustomRAM
        '
        Me.CustomRAM.AutoSize = True
        Me.CustomRAM.Location = New System.Drawing.Point(57, 107)
        Me.CustomRAM.Name = "CustomRAM"
        Me.CustomRAM.Size = New System.Drawing.Size(156, 17)
        Me.CustomRAM.TabIndex = 1
        Me.CustomRAM.Text = "Use this amount of memory"
        Me.CustomRAM.UseVisualStyleBackColor = True
        '
        'DefaultRAM
        '
        Me.DefaultRAM.AutoSize = True
        Me.DefaultRAM.Checked = True
        Me.DefaultRAM.Location = New System.Drawing.Point(57, 84)
        Me.DefaultRAM.Name = "DefaultRAM"
        Me.DefaultRAM.Size = New System.Drawing.Size(173, 17)
        Me.DefaultRAM.TabIndex = 0
        Me.DefaultRAM.TabStop = True
        Me.DefaultRAM.Text = "Use the recommended memory"
        Me.DefaultRAM.UseVisualStyleBackColor = True
        '
        'CustomRAMContainer
        '
        Me.CustomRAMContainer.Controls.Add(Me.WarningInvalidSize)
        Me.CustomRAMContainer.Controls.Add(Me.RAMSlider)
        Me.CustomRAMContainer.Controls.Add(Me.RamMBLabel)
        Me.CustomRAMContainer.Controls.Add(Me.RAM)
        Me.CustomRAMContainer.Location = New System.Drawing.Point(50, 130)
        Me.CustomRAMContainer.Name = "CustomRAMContainer"
        Me.CustomRAMContainer.Size = New System.Drawing.Size(420, 93)
        Me.CustomRAMContainer.TabIndex = 7
        '
        'WarningInvalidSize
        '
        Me.WarningInvalidSize.AutoSize = True
        Me.WarningInvalidSize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WarningInvalidSize.Location = New System.Drawing.Point(10, 69)
        Me.WarningInvalidSize.Name = "WarningInvalidSize"
        Me.WarningInvalidSize.Size = New System.Drawing.Size(219, 13)
        Me.WarningInvalidSize.TabIndex = 8
        Me.WarningInvalidSize.Text = "Please use a valid size between %n and %x"
        '
        'RAMSlider
        '
        Me.RAMSlider.Location = New System.Drawing.Point(3, 22)
        Me.RAMSlider.Maximum = 960
        Me.RAMSlider.Minimum = 4
        Me.RAMSlider.Name = "RAMSlider"
        Me.RAMSlider.Size = New System.Drawing.Size(329, 45)
        Me.RAMSlider.TabIndex = 2
        Me.RAMSlider.TickFrequency = 48
        Me.RAMSlider.Value = 4
        '
        'RamMBLabel
        '
        Me.RamMBLabel.AutoSize = True
        Me.RamMBLabel.Location = New System.Drawing.Point(385, 28)
        Me.RamMBLabel.Name = "RamMBLabel"
        Me.RamMBLabel.Size = New System.Drawing.Size(21, 13)
        Me.RamMBLabel.TabIndex = 5
        Me.RamMBLabel.Text = "MB"
        '
        'RAM
        '
        Me.RAM.Location = New System.Drawing.Point(338, 25)
        Me.RAM.Name = "RAM"
        Me.RAM.Size = New System.Drawing.Size(45, 21)
        Me.RAM.TabIndex = 3
        '
        'DescriptionContainer
        '
        Me.DescriptionContainer.BackColor = System.Drawing.Color.White
        Me.DescriptionContainer.Controls.Add(Me.Description)
        Me.DescriptionContainer.Controls.Add(Me.DescriptionName)
        Me.DescriptionContainer.Location = New System.Drawing.Point(-1, -8)
        Me.DescriptionContainer.Name = "DescriptionContainer"
        Me.DescriptionContainer.Size = New System.Drawing.Size(499, 67)
        Me.DescriptionContainer.TabIndex = 0
        Me.DescriptionContainer.TabStop = False
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(48, 34)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(423, 30)
        Me.Description.TabIndex = 1
        Me.Description.Text = "You can create a new Mac or add an existing one to the Virtual Mac Console"
        '
        'DescriptionName
        '
        Me.DescriptionName.AutoSize = True
        Me.DescriptionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionName.Location = New System.Drawing.Point(23, 20)
        Me.DescriptionName.Name = "DescriptionName"
        Me.DescriptionName.Size = New System.Drawing.Size(50, 13)
        Me.DescriptionName.TabIndex = 0
        Me.DescriptionName.Text = "Options"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.ReshowDelay = 200
        '
        'Welcome
        '
        Me.Welcome.BackColor = System.Drawing.Color.White
        Me.Welcome.BackgroundImage = Global.VirtualMac.My.Resources.Resources.NewMac
        Me.Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Welcome.Controls.Add(Me.WelcomeDescription)
        Me.Welcome.Controls.Add(Me.WelcomeTitle)
        Me.Welcome.Location = New System.Drawing.Point(0, 0)
        Me.Welcome.Margin = New System.Windows.Forms.Padding(0)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(497, 313)
        Me.Welcome.TabIndex = 1
        '
        'WelcomeDescription
        '
        Me.WelcomeDescription.Location = New System.Drawing.Point(170, 75)
        Me.WelcomeDescription.Name = "WelcomeDescription"
        Me.WelcomeDescription.Size = New System.Drawing.Size(300, 80)
        Me.WelcomeDescription.TabIndex = 1
        Me.WelcomeDescription.Text = "This wizard helps you create and configure a new Macintosh or add an existing Mac" & _
            "intosh to the Virtual Mac Console." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Macintosh configuration is stored in a" & _
            " .mcc file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To continue, click Next."
        '
        'WelcomeTitle
        '
        Me.WelcomeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeTitle.Location = New System.Drawing.Point(170, 15)
        Me.WelcomeTitle.Name = "WelcomeTitle"
        Me.WelcomeTitle.Size = New System.Drawing.Size(300, 45)
        Me.WelcomeTitle.TabIndex = 0
        Me.WelcomeTitle.Text = "Welcome to the New Macintosh Wizard"
        '
        'EndWizard
        '
        Me.EndWizard.BackColor = System.Drawing.Color.White
        Me.EndWizard.BackgroundImage = Global.VirtualMac.My.Resources.Resources.NewMac
        Me.EndWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EndWizard.Controls.Add(Me.MachineDisk)
        Me.EndWizard.Controls.Add(Me.MachineMemory)
        Me.EndWizard.Controls.Add(Me.MachineName)
        Me.EndWizard.Controls.Add(Me.FinishDescription)
        Me.EndWizard.Controls.Add(Me.DiskLabel)
        Me.EndWizard.Controls.Add(Me.MemoryLabel)
        Me.EndWizard.Controls.Add(Me.NameLabel)
        Me.EndWizard.Controls.Add(Me.EndDescription)
        Me.EndWizard.Controls.Add(Me.EndTitle)
        Me.EndWizard.Location = New System.Drawing.Point(0, 0)
        Me.EndWizard.Margin = New System.Windows.Forms.Padding(0)
        Me.EndWizard.Name = "EndWizard"
        Me.EndWizard.Size = New System.Drawing.Size(497, 313)
        Me.EndWizard.TabIndex = 3
        '
        'MachineDisk
        '
        Me.MachineDisk.AutoSize = True
        Me.MachineDisk.Location = New System.Drawing.Point(277, 147)
        Me.MachineDisk.Name = "MachineDisk"
        Me.MachineDisk.Size = New System.Drawing.Size(22, 13)
        Me.MachineDisk.TabIndex = 8
        Me.MachineDisk.Text = "C:\"
        '
        'MachineMemory
        '
        Me.MachineMemory.AutoSize = True
        Me.MachineMemory.Location = New System.Drawing.Point(277, 129)
        Me.MachineMemory.Name = "MachineMemory"
        Me.MachineMemory.Size = New System.Drawing.Size(42, 13)
        Me.MachineMemory.TabIndex = 7
        Me.MachineMemory.Text = "255 MB"
        '
        'MachineName
        '
        Me.MachineName.AutoSize = True
        Me.MachineName.Location = New System.Drawing.Point(277, 111)
        Me.MachineName.Name = "MachineName"
        Me.MachineName.Size = New System.Drawing.Size(77, 13)
        Me.MachineName.TabIndex = 6
        Me.MachineName.Text = "Example Name"
        '
        'FinishDescription
        '
        Me.FinishDescription.Location = New System.Drawing.Point(170, 223)
        Me.FinishDescription.Name = "FinishDescription"
        Me.FinishDescription.Size = New System.Drawing.Size(300, 35)
        Me.FinishDescription.TabIndex = 5
        Me.FinishDescription.Text = "To close this wizard and create this Mac, click Finish."
        '
        'DiskLabel
        '
        Me.DiskLabel.AutoSize = True
        Me.DiskLabel.Location = New System.Drawing.Point(181, 147)
        Me.DiskLabel.Name = "DiskLabel"
        Me.DiskLabel.Size = New System.Drawing.Size(30, 13)
        Me.DiskLabel.TabIndex = 4
        Me.DiskLabel.Text = "Disk:"
        '
        'MemoryLabel
        '
        Me.MemoryLabel.AutoSize = True
        Me.MemoryLabel.Location = New System.Drawing.Point(181, 129)
        Me.MemoryLabel.Name = "MemoryLabel"
        Me.MemoryLabel.Size = New System.Drawing.Size(49, 13)
        Me.MemoryLabel.TabIndex = 3
        Me.MemoryLabel.Text = "Memory:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(181, 111)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Name:"
        '
        'EndDescription
        '
        Me.EndDescription.Location = New System.Drawing.Point(170, 62)
        Me.EndDescription.Name = "EndDescription"
        Me.EndDescription.Size = New System.Drawing.Size(300, 49)
        Me.EndDescription.TabIndex = 1
        Me.EndDescription.Text = "You have succefully completed the New Macintosh Wizard. Your Macintosh will be cr" & _
            "eated with the following attributes:"
        '
        'EndTitle
        '
        Me.EndTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndTitle.Location = New System.Drawing.Point(169, 13)
        Me.EndTitle.Name = "EndTitle"
        Me.EndTitle.Size = New System.Drawing.Size(301, 46)
        Me.EndTitle.TabIndex = 0
        Me.EndTitle.Text = "Completing the New Macintosh Wizard"
        '
        'frmNewMac
        '
        Me.AcceptButton = Me.cmdNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(499, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.Welcome)
        Me.Controls.Add(Me.Wizard)
        Me.Controls.Add(Me.EndWizard)
        Me.Controls.Add(Me.FormButtons)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewMac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Macintosh Wizard"
        Me.FormButtons.ResumeLayout(False)
        Me.Wizard.ResumeLayout(False)
        Me.AddExisting.ResumeLayout(False)
        Me.AddExisting.PerformLayout()
        Me.SelectType.ResumeLayout(False)
        Me.SelectType.PerformLayout()
        Me.SelectDisk.ResumeLayout(False)
        Me.SelectDisk.PerformLayout()
        Me.DiskTools.ResumeLayout(False)
        Me.DiskTools.PerformLayout()
        CType(Me.DiskSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HwPresets.ResumeLayout(False)
        Me.HwPresets.PerformLayout()
        Me.CreateNew.ResumeLayout(False)
        Me.CreateNew.PerformLayout()
        Me.AssignRAM.ResumeLayout(False)
        Me.AssignRAM.PerformLayout()
        Me.CustomRAMContainer.ResumeLayout(False)
        Me.CustomRAMContainer.PerformLayout()
        CType(Me.RAMSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescriptionContainer.ResumeLayout(False)
        Me.DescriptionContainer.PerformLayout()
        Me.Welcome.ResumeLayout(False)
        Me.EndWizard.ResumeLayout(False)
        Me.EndWizard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormButtons As System.Windows.Forms.GroupBox
    Friend WithEvents Welcome As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents WelcomeDescription As System.Windows.Forms.Label
    Friend WithEvents WelcomeTitle As System.Windows.Forms.Label
    Friend WithEvents Wizard As System.Windows.Forms.Panel
    Friend WithEvents DescriptionContainer As System.Windows.Forms.GroupBox
    Friend WithEvents SelectType As System.Windows.Forms.Panel
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents DescriptionName As System.Windows.Forms.Label
    Friend WithEvents HwPresets As System.Windows.Forms.Panel
    Friend WithEvents AddExisting As System.Windows.Forms.Panel
    Friend WithEvents CreateNew As System.Windows.Forms.Panel
    Friend WithEvents SelectDisk As System.Windows.Forms.Panel
    Friend WithEvents AssignRAM As System.Windows.Forms.Panel
    Friend WithEvents EndWizard As System.Windows.Forms.Panel
    Friend WithEvents DiskLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents EndDescription As System.Windows.Forms.Label
    Friend WithEvents EndTitle As System.Windows.Forms.Label
    Friend WithEvents FinishDescription As System.Windows.Forms.Label
    Friend WithEvents MachineDisk As System.Windows.Forms.Label
    Friend WithEvents MachineMemory As System.Windows.Forms.Label
    Friend WithEvents MachineName As System.Windows.Forms.Label
    Friend WithEvents AddFromFile As System.Windows.Forms.RadioButton
    Friend WithEvents UseWizard As System.Windows.Forms.RadioButton
    Friend WithEvents SelectTypeDescription As System.Windows.Forms.Label
    Friend WithEvents UseWizardDescription As System.Windows.Forms.Label
    Friend WithEvents AddFromFileDescription As System.Windows.Forms.Label
    Friend WithEvents DontUseWizardDescription As System.Windows.Forms.Label
    Friend WithEvents DontUseWizard As System.Windows.Forms.RadioButton
    Friend WithEvents SaveMac As System.Windows.Forms.Button
    Friend WithEvents MacName As System.Windows.Forms.TextBox
    Friend WithEvents CreateNewDescription As System.Windows.Forms.Label
    Friend WithEvents Open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HwPresetsDescription As System.Windows.Forms.Label
    Friend WithEvents DefMem As System.Windows.Forms.Label
    Friend WithEvents DefDisk As System.Windows.Forms.Label
    Friend WithEvents DefCPU As System.Windows.Forms.Label
    Friend WithEvents DefCPULabel As System.Windows.Forms.Label
    Friend WithEvents DefDiskLabel As System.Windows.Forms.Label
    Friend WithEvents DefMemLabel As System.Windows.Forms.Label
    Friend WithEvents OSList As System.Windows.Forms.ComboBox
    Friend WithEvents OSListDescription As System.Windows.Forms.Label
    Friend WithEvents RamMBLabel As System.Windows.Forms.Label
    Friend WithEvents AssignRAMDescription As System.Windows.Forms.Label
    Friend WithEvents RAM As System.Windows.Forms.TextBox
    Friend WithEvents RAMSlider As System.Windows.Forms.TrackBar
    Friend WithEvents CustomRAM As System.Windows.Forms.RadioButton
    Friend WithEvents DefaultRAM As System.Windows.Forms.RadioButton
    Friend WithEvents RecommendedRAM As System.Windows.Forms.Label
    Friend WithEvents RecHwLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CustomRAMContainer As System.Windows.Forms.Panel
    Friend WithEvents DiskSizeLabel As System.Windows.Forms.Label
    Friend WithEvents DiskSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents DiskMBLabel As System.Windows.Forms.Label
    Friend WithEvents WarningInvalidSize As System.Windows.Forms.Label
    Friend WithEvents DiskTools As System.Windows.Forms.Panel
    Friend WithEvents SelectDiskDescription As System.Windows.Forms.Label
    Friend WithEvents ExistingDisk As System.Windows.Forms.RadioButton
    Friend WithEvents NewDisk As System.Windows.Forms.RadioButton
    Friend WithEvents BrowseDiskLocation As System.Windows.Forms.Button
    Friend WithEvents DiskPath As System.Windows.Forms.TextBox
    Friend WithEvents NoDisk As System.Windows.Forms.RadioButton
    Friend WithEvents AEBrowseFile As System.Windows.Forms.Button
    Friend WithEvents AEFile As System.Windows.Forms.TextBox
    Friend WithEvents AEInfo As System.Windows.Forms.Label
    Friend WithEvents AEFileLabel As System.Windows.Forms.Label
    Friend WithEvents AEEmulatorTypeLabel As System.Windows.Forms.Label
    Friend WithEvents AEEmulatorType As System.Windows.Forms.ComboBox
    Friend WithEvents AEName As System.Windows.Forms.TextBox
    Friend WithEvents AENameLabel As System.Windows.Forms.Label
End Class
