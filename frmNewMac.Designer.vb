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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewMac))
        Me.FormButtons = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Wizard = New System.Windows.Forms.Panel()
        Me.CreateFrame = New System.Windows.Forms.Panel()
        Me.CreateNoWizardLabel = New System.Windows.Forms.Label()
        Me.CreateNoWizard = New System.Windows.Forms.RadioButton()
        Me.CreateAddExistLabel = New System.Windows.Forms.Label()
        Me.CreateAddExist = New System.Windows.Forms.RadioButton()
        Me.CreateNormalLabel = New System.Windows.Forms.Label()
        Me.CreateNormal = New System.Windows.Forms.RadioButton()
        Me.CreateInfo = New System.Windows.Forms.Label()
        Me.MacNameFrame = New System.Windows.Forms.Panel()
        Me.MacName = New System.Windows.Forms.TextBox()
        Me.MacNameLabel = New System.Windows.Forms.Label()
        Me.MacNameBrowse = New System.Windows.Forms.Button()
        Me.AddFromFileFrame = New System.Windows.Forms.Panel()
        Me.AddName = New System.Windows.Forms.TextBox()
        Me.AddNameLabel = New System.Windows.Forms.Label()
        Me.AddFile = New System.Windows.Forms.TextBox()
        Me.AddFileLabel = New System.Windows.Forms.Label()
        Me.AddEmulatorLabel = New System.Windows.Forms.Label()
        Me.AddEmulator = New System.Windows.Forms.ComboBox()
        Me.AddInfo = New System.Windows.Forms.Label()
        Me.AddFileBrowse = New System.Windows.Forms.Button()
        Me.HwPresetsFrame = New System.Windows.Forms.Panel()
        Me.HwEmulator = New System.Windows.Forms.ComboBox()
        Me.HwInfoDef = New System.Windows.Forms.Label()
        Me.HwEmulatorLabel = New System.Windows.Forms.Label()
        Me.HwInfo = New System.Windows.Forms.Label()
        Me.HwRAM = New System.Windows.Forms.Label()
        Me.HwRAMLabel = New System.Windows.Forms.Label()
        Me.HwDisk = New System.Windows.Forms.Label()
        Me.HwDiskLabel = New System.Windows.Forms.Label()
        Me.HwCPU = New System.Windows.Forms.Label()
        Me.HwCPULabel = New System.Windows.Forms.Label()
        Me.HwOSList = New System.Windows.Forms.ComboBox()
        Me.RAMFrame = New System.Windows.Forms.Panel()
        Me.RAMInfo = New System.Windows.Forms.Label()
        Me.RAMCustom = New System.Windows.Forms.RadioButton()
        Me.RAMDefault = New System.Windows.Forms.RadioButton()
        Me.RAMControlsPanel = New System.Windows.Forms.Panel()
        Me.RAMCustomInvalidSize = New System.Windows.Forms.Label()
        Me.RAMSlider = New System.Windows.Forms.TrackBar()
        Me.RAMLabelMB = New System.Windows.Forms.Label()
        Me.RAMBox = New System.Windows.Forms.TextBox()
        Me.DiskFrame = New System.Windows.Forms.Panel()
        Me.DiskNew = New System.Windows.Forms.RadioButton()
        Me.DiskExisting = New System.Windows.Forms.RadioButton()
        Me.DiskNone = New System.Windows.Forms.RadioButton()
        Me.DiskInfo = New System.Windows.Forms.Label()
        Me.DiskPathBrowse = New System.Windows.Forms.Button()
        Me.DiskPath = New System.Windows.Forms.TextBox()
        Me.DiskSizeFrame = New System.Windows.Forms.Panel()
        Me.DiskSize = New System.Windows.Forms.NumericUpDown()
        Me.DiskSizeLabel = New System.Windows.Forms.Label()
        Me.DiskSizeLabelMB = New System.Windows.Forms.Label()
        Me.DescriptionContainer = New System.Windows.Forms.GroupBox()
        Me.Description = New System.Windows.Forms.Label()
        Me.DescriptionName = New System.Windows.Forms.Label()
        Me.Open = New System.Windows.Forms.OpenFileDialog()
        Me.Save = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Welcome = New System.Windows.Forms.Panel()
        Me.WelcomeDescription = New System.Windows.Forms.Label()
        Me.WelcomeTitle = New System.Windows.Forms.Label()
        Me.EndWizard = New System.Windows.Forms.Panel()
        Me.EndTitle = New System.Windows.Forms.Label()
        Me.EndInfo = New System.Windows.Forms.Label()
        Me.EndMacName = New System.Windows.Forms.Label()
        Me.EndMacNameLabel = New System.Windows.Forms.Label()
        Me.EndRAM = New System.Windows.Forms.Label()
        Me.EndRAMLabel = New System.Windows.Forms.Label()
        Me.EndDiskPath = New System.Windows.Forms.Label()
        Me.EndDiskPathLabel = New System.Windows.Forms.Label()
        Me.EndInfoFinish = New System.Windows.Forms.Label()
        Me.FormButtons.SuspendLayout()
        Me.Wizard.SuspendLayout()
        Me.CreateFrame.SuspendLayout()
        Me.MacNameFrame.SuspendLayout()
        Me.AddFromFileFrame.SuspendLayout()
        Me.HwPresetsFrame.SuspendLayout()
        Me.RAMFrame.SuspendLayout()
        Me.RAMControlsPanel.SuspendLayout()
        CType(Me.RAMSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiskFrame.SuspendLayout()
        Me.DiskSizeFrame.SuspendLayout()
        CType(Me.DiskSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescriptionContainer.SuspendLayout()
        Me.Welcome.SuspendLayout()
        Me.EndWizard.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormButtons
        '
        resources.ApplyResources(Me.FormButtons, "FormButtons")
        Me.FormButtons.Controls.Add(Me.cmdCancel)
        Me.FormButtons.Controls.Add(Me.cmdNext)
        Me.FormButtons.Controls.Add(Me.cmdBack)
        Me.FormButtons.Name = "FormButtons"
        Me.FormButtons.TabStop = False
        Me.ToolTip1.SetToolTip(Me.FormButtons, resources.GetString("FormButtons.ToolTip"))
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Name = "cmdCancel"
        Me.ToolTip1.SetToolTip(Me.cmdCancel, resources.GetString("cmdCancel.ToolTip"))
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        resources.ApplyResources(Me.cmdNext, "cmdNext")
        Me.cmdNext.Name = "cmdNext"
        Me.ToolTip1.SetToolTip(Me.cmdNext, resources.GetString("cmdNext.ToolTip"))
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        resources.ApplyResources(Me.cmdBack, "cmdBack")
        Me.cmdBack.Name = "cmdBack"
        Me.ToolTip1.SetToolTip(Me.cmdBack, resources.GetString("cmdBack.ToolTip"))
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Wizard
        '
        resources.ApplyResources(Me.Wizard, "Wizard")
        Me.Wizard.BackColor = System.Drawing.SystemColors.Control
        Me.Wizard.Controls.Add(Me.MacNameFrame)
        Me.Wizard.Controls.Add(Me.AddFromFileFrame)
        Me.Wizard.Controls.Add(Me.HwPresetsFrame)
        Me.Wizard.Controls.Add(Me.RAMFrame)
        Me.Wizard.Controls.Add(Me.DiskFrame)
        Me.Wizard.Controls.Add(Me.CreateFrame)
        Me.Wizard.Controls.Add(Me.DescriptionContainer)
        Me.Wizard.Name = "Wizard"
        Me.ToolTip1.SetToolTip(Me.Wizard, resources.GetString("Wizard.ToolTip"))
        '
        'CreateFrame
        '
        resources.ApplyResources(Me.CreateFrame, "CreateFrame")
        Me.CreateFrame.Controls.Add(Me.CreateNoWizardLabel)
        Me.CreateFrame.Controls.Add(Me.CreateNoWizard)
        Me.CreateFrame.Controls.Add(Me.CreateAddExistLabel)
        Me.CreateFrame.Controls.Add(Me.CreateAddExist)
        Me.CreateFrame.Controls.Add(Me.CreateNormalLabel)
        Me.CreateFrame.Controls.Add(Me.CreateNormal)
        Me.CreateFrame.Controls.Add(Me.CreateInfo)
        Me.CreateFrame.Name = "CreateFrame"
        Me.ToolTip1.SetToolTip(Me.CreateFrame, resources.GetString("CreateFrame.ToolTip"))
        '
        'CreateNoWizardLabel
        '
        resources.ApplyResources(Me.CreateNoWizardLabel, "CreateNoWizardLabel")
        Me.CreateNoWizardLabel.Name = "CreateNoWizardLabel"
        Me.ToolTip1.SetToolTip(Me.CreateNoWizardLabel, resources.GetString("CreateNoWizardLabel.ToolTip"))
        '
        'CreateNoWizard
        '
        resources.ApplyResources(Me.CreateNoWizard, "CreateNoWizard")
        Me.CreateNoWizard.Checked = True
        Me.CreateNoWizard.Name = "CreateNoWizard"
        Me.CreateNoWizard.TabStop = True
        Me.ToolTip1.SetToolTip(Me.CreateNoWizard, resources.GetString("CreateNoWizard.ToolTip"))
        Me.CreateNoWizard.UseVisualStyleBackColor = True
        '
        'CreateAddExistLabel
        '
        resources.ApplyResources(Me.CreateAddExistLabel, "CreateAddExistLabel")
        Me.CreateAddExistLabel.Name = "CreateAddExistLabel"
        Me.ToolTip1.SetToolTip(Me.CreateAddExistLabel, resources.GetString("CreateAddExistLabel.ToolTip"))
        '
        'CreateAddExist
        '
        resources.ApplyResources(Me.CreateAddExist, "CreateAddExist")
        Me.CreateAddExist.Name = "CreateAddExist"
        Me.ToolTip1.SetToolTip(Me.CreateAddExist, resources.GetString("CreateAddExist.ToolTip"))
        Me.CreateAddExist.UseVisualStyleBackColor = True
        '
        'CreateNormalLabel
        '
        resources.ApplyResources(Me.CreateNormalLabel, "CreateNormalLabel")
        Me.CreateNormalLabel.Name = "CreateNormalLabel"
        Me.ToolTip1.SetToolTip(Me.CreateNormalLabel, resources.GetString("CreateNormalLabel.ToolTip"))
        '
        'CreateNormal
        '
        resources.ApplyResources(Me.CreateNormal, "CreateNormal")
        Me.CreateNormal.Name = "CreateNormal"
        Me.ToolTip1.SetToolTip(Me.CreateNormal, resources.GetString("CreateNormal.ToolTip"))
        Me.CreateNormal.UseVisualStyleBackColor = True
        '
        'CreateInfo
        '
        resources.ApplyResources(Me.CreateInfo, "CreateInfo")
        Me.CreateInfo.Name = "CreateInfo"
        Me.ToolTip1.SetToolTip(Me.CreateInfo, resources.GetString("CreateInfo.ToolTip"))
        '
        'MacNameFrame
        '
        resources.ApplyResources(Me.MacNameFrame, "MacNameFrame")
        Me.MacNameFrame.Controls.Add(Me.MacName)
        Me.MacNameFrame.Controls.Add(Me.MacNameLabel)
        Me.MacNameFrame.Controls.Add(Me.MacNameBrowse)
        Me.MacNameFrame.Name = "MacNameFrame"
        Me.ToolTip1.SetToolTip(Me.MacNameFrame, resources.GetString("MacNameFrame.ToolTip"))
        '
        'MacName
        '
        resources.ApplyResources(Me.MacName, "MacName")
        Me.MacName.Name = "MacName"
        Me.ToolTip1.SetToolTip(Me.MacName, resources.GetString("MacName.ToolTip"))
        '
        'MacNameLabel
        '
        resources.ApplyResources(Me.MacNameLabel, "MacNameLabel")
        Me.MacNameLabel.Name = "MacNameLabel"
        Me.ToolTip1.SetToolTip(Me.MacNameLabel, resources.GetString("MacNameLabel.ToolTip"))
        '
        'MacNameBrowse
        '
        resources.ApplyResources(Me.MacNameBrowse, "MacNameBrowse")
        Me.MacNameBrowse.Name = "MacNameBrowse"
        Me.ToolTip1.SetToolTip(Me.MacNameBrowse, resources.GetString("MacNameBrowse.ToolTip"))
        Me.MacNameBrowse.UseVisualStyleBackColor = True
        '
        'AddFromFileFrame
        '
        resources.ApplyResources(Me.AddFromFileFrame, "AddFromFileFrame")
        Me.AddFromFileFrame.Controls.Add(Me.AddName)
        Me.AddFromFileFrame.Controls.Add(Me.AddNameLabel)
        Me.AddFromFileFrame.Controls.Add(Me.AddFile)
        Me.AddFromFileFrame.Controls.Add(Me.AddFileLabel)
        Me.AddFromFileFrame.Controls.Add(Me.AddEmulatorLabel)
        Me.AddFromFileFrame.Controls.Add(Me.AddEmulator)
        Me.AddFromFileFrame.Controls.Add(Me.AddInfo)
        Me.AddFromFileFrame.Controls.Add(Me.AddFileBrowse)
        Me.AddFromFileFrame.Name = "AddFromFileFrame"
        Me.ToolTip1.SetToolTip(Me.AddFromFileFrame, resources.GetString("AddFromFileFrame.ToolTip"))
        '
        'AddName
        '
        resources.ApplyResources(Me.AddName, "AddName")
        Me.AddName.Name = "AddName"
        Me.ToolTip1.SetToolTip(Me.AddName, resources.GetString("AddName.ToolTip"))
        '
        'AddNameLabel
        '
        resources.ApplyResources(Me.AddNameLabel, "AddNameLabel")
        Me.AddNameLabel.Name = "AddNameLabel"
        Me.ToolTip1.SetToolTip(Me.AddNameLabel, resources.GetString("AddNameLabel.ToolTip"))
        '
        'AddFile
        '
        resources.ApplyResources(Me.AddFile, "AddFile")
        Me.AddFile.Name = "AddFile"
        Me.ToolTip1.SetToolTip(Me.AddFile, resources.GetString("AddFile.ToolTip"))
        '
        'AddFileLabel
        '
        resources.ApplyResources(Me.AddFileLabel, "AddFileLabel")
        Me.AddFileLabel.Name = "AddFileLabel"
        Me.ToolTip1.SetToolTip(Me.AddFileLabel, resources.GetString("AddFileLabel.ToolTip"))
        '
        'AddEmulatorLabel
        '
        resources.ApplyResources(Me.AddEmulatorLabel, "AddEmulatorLabel")
        Me.AddEmulatorLabel.Name = "AddEmulatorLabel"
        Me.ToolTip1.SetToolTip(Me.AddEmulatorLabel, resources.GetString("AddEmulatorLabel.ToolTip"))
        '
        'AddEmulator
        '
        resources.ApplyResources(Me.AddEmulator, "AddEmulator")
        Me.AddEmulator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AddEmulator.FormattingEnabled = True
        Me.AddEmulator.Items.AddRange(New Object() {resources.GetString("AddEmulator.Items"), resources.GetString("AddEmulator.Items1"), resources.GetString("AddEmulator.Items2"), resources.GetString("AddEmulator.Items3"), resources.GetString("AddEmulator.Items4"), resources.GetString("AddEmulator.Items5")})
        Me.AddEmulator.Name = "AddEmulator"
        Me.ToolTip1.SetToolTip(Me.AddEmulator, resources.GetString("AddEmulator.ToolTip"))
        '
        'AddInfo
        '
        resources.ApplyResources(Me.AddInfo, "AddInfo")
        Me.AddInfo.Name = "AddInfo"
        Me.ToolTip1.SetToolTip(Me.AddInfo, resources.GetString("AddInfo.ToolTip"))
        '
        'AddFileBrowse
        '
        resources.ApplyResources(Me.AddFileBrowse, "AddFileBrowse")
        Me.AddFileBrowse.Name = "AddFileBrowse"
        Me.ToolTip1.SetToolTip(Me.AddFileBrowse, resources.GetString("AddFileBrowse.ToolTip"))
        Me.AddFileBrowse.UseVisualStyleBackColor = True
        '
        'HwPresetsFrame
        '
        resources.ApplyResources(Me.HwPresetsFrame, "HwPresetsFrame")
        Me.HwPresetsFrame.Controls.Add(Me.HwEmulator)
        Me.HwPresetsFrame.Controls.Add(Me.HwInfoDef)
        Me.HwPresetsFrame.Controls.Add(Me.HwEmulatorLabel)
        Me.HwPresetsFrame.Controls.Add(Me.HwInfo)
        Me.HwPresetsFrame.Controls.Add(Me.HwRAM)
        Me.HwPresetsFrame.Controls.Add(Me.HwRAMLabel)
        Me.HwPresetsFrame.Controls.Add(Me.HwDisk)
        Me.HwPresetsFrame.Controls.Add(Me.HwDiskLabel)
        Me.HwPresetsFrame.Controls.Add(Me.HwCPU)
        Me.HwPresetsFrame.Controls.Add(Me.HwCPULabel)
        Me.HwPresetsFrame.Controls.Add(Me.HwOSList)
        Me.HwPresetsFrame.Name = "HwPresetsFrame"
        Me.ToolTip1.SetToolTip(Me.HwPresetsFrame, resources.GetString("HwPresetsFrame.ToolTip"))
        '
        'HwEmulator
        '
        resources.ApplyResources(Me.HwEmulator, "HwEmulator")
        Me.HwEmulator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HwEmulator.FormattingEnabled = True
        Me.HwEmulator.Items.AddRange(New Object() {resources.GetString("HwEmulator.Items"), resources.GetString("HwEmulator.Items1"), resources.GetString("HwEmulator.Items2"), resources.GetString("HwEmulator.Items3"), resources.GetString("HwEmulator.Items4")})
        Me.HwEmulator.Name = "HwEmulator"
        Me.ToolTip1.SetToolTip(Me.HwEmulator, resources.GetString("HwEmulator.ToolTip"))
        '
        'HwInfoDef
        '
        resources.ApplyResources(Me.HwInfoDef, "HwInfoDef")
        Me.HwInfoDef.Name = "HwInfoDef"
        Me.ToolTip1.SetToolTip(Me.HwInfoDef, resources.GetString("HwInfoDef.ToolTip"))
        '
        'HwEmulatorLabel
        '
        resources.ApplyResources(Me.HwEmulatorLabel, "HwEmulatorLabel")
        Me.HwEmulatorLabel.Name = "HwEmulatorLabel"
        Me.ToolTip1.SetToolTip(Me.HwEmulatorLabel, resources.GetString("HwEmulatorLabel.ToolTip"))
        '
        'HwInfo
        '
        resources.ApplyResources(Me.HwInfo, "HwInfo")
        Me.HwInfo.Name = "HwInfo"
        Me.ToolTip1.SetToolTip(Me.HwInfo, resources.GetString("HwInfo.ToolTip"))
        '
        'HwRAM
        '
        resources.ApplyResources(Me.HwRAM, "HwRAM")
        Me.HwRAM.Name = "HwRAM"
        Me.ToolTip1.SetToolTip(Me.HwRAM, resources.GetString("HwRAM.ToolTip"))
        '
        'HwRAMLabel
        '
        resources.ApplyResources(Me.HwRAMLabel, "HwRAMLabel")
        Me.HwRAMLabel.Name = "HwRAMLabel"
        Me.ToolTip1.SetToolTip(Me.HwRAMLabel, resources.GetString("HwRAMLabel.ToolTip"))
        '
        'HwDisk
        '
        resources.ApplyResources(Me.HwDisk, "HwDisk")
        Me.HwDisk.Name = "HwDisk"
        Me.ToolTip1.SetToolTip(Me.HwDisk, resources.GetString("HwDisk.ToolTip"))
        '
        'HwDiskLabel
        '
        resources.ApplyResources(Me.HwDiskLabel, "HwDiskLabel")
        Me.HwDiskLabel.Name = "HwDiskLabel"
        Me.ToolTip1.SetToolTip(Me.HwDiskLabel, resources.GetString("HwDiskLabel.ToolTip"))
        '
        'HwCPU
        '
        resources.ApplyResources(Me.HwCPU, "HwCPU")
        Me.HwCPU.Name = "HwCPU"
        Me.ToolTip1.SetToolTip(Me.HwCPU, resources.GetString("HwCPU.ToolTip"))
        '
        'HwCPULabel
        '
        resources.ApplyResources(Me.HwCPULabel, "HwCPULabel")
        Me.HwCPULabel.Name = "HwCPULabel"
        Me.ToolTip1.SetToolTip(Me.HwCPULabel, resources.GetString("HwCPULabel.ToolTip"))
        '
        'HwOSList
        '
        resources.ApplyResources(Me.HwOSList, "HwOSList")
        Me.HwOSList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HwOSList.FormattingEnabled = True
        Me.HwOSList.Name = "HwOSList"
        Me.ToolTip1.SetToolTip(Me.HwOSList, resources.GetString("HwOSList.ToolTip"))
        '
        'RAMFrame
        '
        resources.ApplyResources(Me.RAMFrame, "RAMFrame")
        Me.RAMFrame.Controls.Add(Me.RAMInfo)
        Me.RAMFrame.Controls.Add(Me.RAMCustom)
        Me.RAMFrame.Controls.Add(Me.RAMDefault)
        Me.RAMFrame.Controls.Add(Me.RAMControlsPanel)
        Me.RAMFrame.Name = "RAMFrame"
        Me.ToolTip1.SetToolTip(Me.RAMFrame, resources.GetString("RAMFrame.ToolTip"))
        '
        'RAMInfo
        '
        resources.ApplyResources(Me.RAMInfo, "RAMInfo")
        Me.RAMInfo.Name = "RAMInfo"
        Me.ToolTip1.SetToolTip(Me.RAMInfo, resources.GetString("RAMInfo.ToolTip"))
        '
        'RAMCustom
        '
        resources.ApplyResources(Me.RAMCustom, "RAMCustom")
        Me.RAMCustom.Name = "RAMCustom"
        Me.ToolTip1.SetToolTip(Me.RAMCustom, resources.GetString("RAMCustom.ToolTip"))
        Me.RAMCustom.UseVisualStyleBackColor = True
        '
        'RAMDefault
        '
        resources.ApplyResources(Me.RAMDefault, "RAMDefault")
        Me.RAMDefault.Checked = True
        Me.RAMDefault.Name = "RAMDefault"
        Me.RAMDefault.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RAMDefault, resources.GetString("RAMDefault.ToolTip"))
        Me.RAMDefault.UseVisualStyleBackColor = True
        '
        'RAMControlsPanel
        '
        resources.ApplyResources(Me.RAMControlsPanel, "RAMControlsPanel")
        Me.RAMControlsPanel.Controls.Add(Me.RAMCustomInvalidSize)
        Me.RAMControlsPanel.Controls.Add(Me.RAMSlider)
        Me.RAMControlsPanel.Controls.Add(Me.RAMLabelMB)
        Me.RAMControlsPanel.Controls.Add(Me.RAMBox)
        Me.RAMControlsPanel.Name = "RAMControlsPanel"
        Me.ToolTip1.SetToolTip(Me.RAMControlsPanel, resources.GetString("RAMControlsPanel.ToolTip"))
        '
        'RAMCustomInvalidSize
        '
        resources.ApplyResources(Me.RAMCustomInvalidSize, "RAMCustomInvalidSize")
        Me.RAMCustomInvalidSize.Name = "RAMCustomInvalidSize"
        Me.ToolTip1.SetToolTip(Me.RAMCustomInvalidSize, resources.GetString("RAMCustomInvalidSize.ToolTip"))
        '
        'RAMSlider
        '
        resources.ApplyResources(Me.RAMSlider, "RAMSlider")
        Me.RAMSlider.Maximum = 960
        Me.RAMSlider.Minimum = 4
        Me.RAMSlider.Name = "RAMSlider"
        Me.RAMSlider.TickFrequency = 48
        Me.ToolTip1.SetToolTip(Me.RAMSlider, resources.GetString("RAMSlider.ToolTip"))
        Me.RAMSlider.Value = 4
        '
        'RAMLabelMB
        '
        resources.ApplyResources(Me.RAMLabelMB, "RAMLabelMB")
        Me.RAMLabelMB.Name = "RAMLabelMB"
        Me.ToolTip1.SetToolTip(Me.RAMLabelMB, resources.GetString("RAMLabelMB.ToolTip"))
        '
        'RAMBox
        '
        resources.ApplyResources(Me.RAMBox, "RAMBox")
        Me.RAMBox.Name = "RAMBox"
        Me.ToolTip1.SetToolTip(Me.RAMBox, resources.GetString("RAMBox.ToolTip"))
        '
        'DiskFrame
        '
        resources.ApplyResources(Me.DiskFrame, "DiskFrame")
        Me.DiskFrame.Controls.Add(Me.DiskNew)
        Me.DiskFrame.Controls.Add(Me.DiskExisting)
        Me.DiskFrame.Controls.Add(Me.DiskNone)
        Me.DiskFrame.Controls.Add(Me.DiskInfo)
        Me.DiskFrame.Controls.Add(Me.DiskPathBrowse)
        Me.DiskFrame.Controls.Add(Me.DiskPath)
        Me.DiskFrame.Controls.Add(Me.DiskSizeFrame)
        Me.DiskFrame.Name = "DiskFrame"
        Me.ToolTip1.SetToolTip(Me.DiskFrame, resources.GetString("DiskFrame.ToolTip"))
        '
        'DiskNew
        '
        resources.ApplyResources(Me.DiskNew, "DiskNew")
        Me.DiskNew.Checked = True
        Me.DiskNew.Name = "DiskNew"
        Me.DiskNew.TabStop = True
        Me.ToolTip1.SetToolTip(Me.DiskNew, resources.GetString("DiskNew.ToolTip"))
        Me.DiskNew.UseVisualStyleBackColor = True
        '
        'DiskExisting
        '
        resources.ApplyResources(Me.DiskExisting, "DiskExisting")
        Me.DiskExisting.Name = "DiskExisting"
        Me.ToolTip1.SetToolTip(Me.DiskExisting, resources.GetString("DiskExisting.ToolTip"))
        Me.DiskExisting.UseVisualStyleBackColor = True
        '
        'DiskNone
        '
        resources.ApplyResources(Me.DiskNone, "DiskNone")
        Me.DiskNone.Name = "DiskNone"
        Me.ToolTip1.SetToolTip(Me.DiskNone, resources.GetString("DiskNone.ToolTip"))
        Me.DiskNone.UseVisualStyleBackColor = True
        '
        'DiskInfo
        '
        resources.ApplyResources(Me.DiskInfo, "DiskInfo")
        Me.DiskInfo.Name = "DiskInfo"
        Me.ToolTip1.SetToolTip(Me.DiskInfo, resources.GetString("DiskInfo.ToolTip"))
        '
        'DiskPathBrowse
        '
        resources.ApplyResources(Me.DiskPathBrowse, "DiskPathBrowse")
        Me.DiskPathBrowse.Name = "DiskPathBrowse"
        Me.ToolTip1.SetToolTip(Me.DiskPathBrowse, resources.GetString("DiskPathBrowse.ToolTip"))
        Me.DiskPathBrowse.UseVisualStyleBackColor = True
        '
        'DiskPath
        '
        resources.ApplyResources(Me.DiskPath, "DiskPath")
        Me.DiskPath.Name = "DiskPath"
        Me.ToolTip1.SetToolTip(Me.DiskPath, resources.GetString("DiskPath.ToolTip"))
        '
        'DiskSizeFrame
        '
        resources.ApplyResources(Me.DiskSizeFrame, "DiskSizeFrame")
        Me.DiskSizeFrame.Controls.Add(Me.DiskSize)
        Me.DiskSizeFrame.Controls.Add(Me.DiskSizeLabel)
        Me.DiskSizeFrame.Controls.Add(Me.DiskSizeLabelMB)
        Me.DiskSizeFrame.Name = "DiskSizeFrame"
        Me.ToolTip1.SetToolTip(Me.DiskSizeFrame, resources.GetString("DiskSizeFrame.ToolTip"))
        '
        'DiskSize
        '
        resources.ApplyResources(Me.DiskSize, "DiskSize")
        Me.DiskSize.Maximum = New Decimal(New Integer() {130000, 0, 0, 0})
        Me.DiskSize.Name = "DiskSize"
        Me.ToolTip1.SetToolTip(Me.DiskSize, resources.GetString("DiskSize.ToolTip"))
        '
        'DiskSizeLabel
        '
        resources.ApplyResources(Me.DiskSizeLabel, "DiskSizeLabel")
        Me.DiskSizeLabel.Name = "DiskSizeLabel"
        Me.ToolTip1.SetToolTip(Me.DiskSizeLabel, resources.GetString("DiskSizeLabel.ToolTip"))
        '
        'DiskSizeLabelMB
        '
        resources.ApplyResources(Me.DiskSizeLabelMB, "DiskSizeLabelMB")
        Me.DiskSizeLabelMB.Name = "DiskSizeLabelMB"
        Me.ToolTip1.SetToolTip(Me.DiskSizeLabelMB, resources.GetString("DiskSizeLabelMB.ToolTip"))
        '
        'DescriptionContainer
        '
        resources.ApplyResources(Me.DescriptionContainer, "DescriptionContainer")
        Me.DescriptionContainer.BackColor = System.Drawing.Color.White
        Me.DescriptionContainer.Controls.Add(Me.Description)
        Me.DescriptionContainer.Controls.Add(Me.DescriptionName)
        Me.DescriptionContainer.Name = "DescriptionContainer"
        Me.DescriptionContainer.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DescriptionContainer, resources.GetString("DescriptionContainer.ToolTip"))
        '
        'Description
        '
        resources.ApplyResources(Me.Description, "Description")
        Me.Description.Name = "Description"
        Me.ToolTip1.SetToolTip(Me.Description, resources.GetString("Description.ToolTip"))
        '
        'DescriptionName
        '
        resources.ApplyResources(Me.DescriptionName, "DescriptionName")
        Me.DescriptionName.Name = "DescriptionName"
        Me.ToolTip1.SetToolTip(Me.DescriptionName, resources.GetString("DescriptionName.ToolTip"))
        '
        'Open
        '
        resources.ApplyResources(Me.Open, "Open")
        '
        'Save
        '
        resources.ApplyResources(Me.Save, "Save")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.ReshowDelay = 200
        '
        'Welcome
        '
        resources.ApplyResources(Me.Welcome, "Welcome")
        Me.Welcome.BackColor = System.Drawing.Color.White
        Me.Welcome.BackgroundImage = Global.VirtualMac.My.Resources.Resources.NewMac
        Me.Welcome.Controls.Add(Me.WelcomeDescription)
        Me.Welcome.Controls.Add(Me.WelcomeTitle)
        Me.Welcome.Name = "Welcome"
        Me.ToolTip1.SetToolTip(Me.Welcome, resources.GetString("Welcome.ToolTip"))
        '
        'WelcomeDescription
        '
        resources.ApplyResources(Me.WelcomeDescription, "WelcomeDescription")
        Me.WelcomeDescription.Name = "WelcomeDescription"
        Me.ToolTip1.SetToolTip(Me.WelcomeDescription, resources.GetString("WelcomeDescription.ToolTip"))
        '
        'WelcomeTitle
        '
        resources.ApplyResources(Me.WelcomeTitle, "WelcomeTitle")
        Me.WelcomeTitle.Name = "WelcomeTitle"
        Me.ToolTip1.SetToolTip(Me.WelcomeTitle, resources.GetString("WelcomeTitle.ToolTip"))
        '
        'EndWizard
        '
        resources.ApplyResources(Me.EndWizard, "EndWizard")
        Me.EndWizard.BackColor = System.Drawing.Color.White
        Me.EndWizard.BackgroundImage = Global.VirtualMac.My.Resources.Resources.NewMac
        Me.EndWizard.Controls.Add(Me.EndTitle)
        Me.EndWizard.Controls.Add(Me.EndInfo)
        Me.EndWizard.Controls.Add(Me.EndMacName)
        Me.EndWizard.Controls.Add(Me.EndMacNameLabel)
        Me.EndWizard.Controls.Add(Me.EndRAM)
        Me.EndWizard.Controls.Add(Me.EndRAMLabel)
        Me.EndWizard.Controls.Add(Me.EndDiskPath)
        Me.EndWizard.Controls.Add(Me.EndDiskPathLabel)
        Me.EndWizard.Controls.Add(Me.EndInfoFinish)
        Me.EndWizard.Name = "EndWizard"
        Me.ToolTip1.SetToolTip(Me.EndWizard, resources.GetString("EndWizard.ToolTip"))
        '
        'EndTitle
        '
        resources.ApplyResources(Me.EndTitle, "EndTitle")
        Me.EndTitle.Name = "EndTitle"
        Me.ToolTip1.SetToolTip(Me.EndTitle, resources.GetString("EndTitle.ToolTip"))
        '
        'EndInfo
        '
        resources.ApplyResources(Me.EndInfo, "EndInfo")
        Me.EndInfo.Name = "EndInfo"
        Me.ToolTip1.SetToolTip(Me.EndInfo, resources.GetString("EndInfo.ToolTip"))
        '
        'EndMacName
        '
        resources.ApplyResources(Me.EndMacName, "EndMacName")
        Me.EndMacName.Name = "EndMacName"
        Me.ToolTip1.SetToolTip(Me.EndMacName, resources.GetString("EndMacName.ToolTip"))
        '
        'EndMacNameLabel
        '
        resources.ApplyResources(Me.EndMacNameLabel, "EndMacNameLabel")
        Me.EndMacNameLabel.Name = "EndMacNameLabel"
        Me.ToolTip1.SetToolTip(Me.EndMacNameLabel, resources.GetString("EndMacNameLabel.ToolTip"))
        '
        'EndRAM
        '
        resources.ApplyResources(Me.EndRAM, "EndRAM")
        Me.EndRAM.Name = "EndRAM"
        Me.ToolTip1.SetToolTip(Me.EndRAM, resources.GetString("EndRAM.ToolTip"))
        '
        'EndRAMLabel
        '
        resources.ApplyResources(Me.EndRAMLabel, "EndRAMLabel")
        Me.EndRAMLabel.Name = "EndRAMLabel"
        Me.ToolTip1.SetToolTip(Me.EndRAMLabel, resources.GetString("EndRAMLabel.ToolTip"))
        '
        'EndDiskPath
        '
        resources.ApplyResources(Me.EndDiskPath, "EndDiskPath")
        Me.EndDiskPath.Name = "EndDiskPath"
        Me.ToolTip1.SetToolTip(Me.EndDiskPath, resources.GetString("EndDiskPath.ToolTip"))
        '
        'EndDiskPathLabel
        '
        resources.ApplyResources(Me.EndDiskPathLabel, "EndDiskPathLabel")
        Me.EndDiskPathLabel.Name = "EndDiskPathLabel"
        Me.ToolTip1.SetToolTip(Me.EndDiskPathLabel, resources.GetString("EndDiskPathLabel.ToolTip"))
        '
        'EndInfoFinish
        '
        resources.ApplyResources(Me.EndInfoFinish, "EndInfoFinish")
        Me.EndInfoFinish.Name = "EndInfoFinish"
        Me.ToolTip1.SetToolTip(Me.EndInfoFinish, resources.GetString("EndInfoFinish.ToolTip"))
        '
        'frmNewMac
        '
        Me.AcceptButton = Me.cmdNext
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ControlBox = False
        Me.Controls.Add(Me.Welcome)
        Me.Controls.Add(Me.EndWizard)
        Me.Controls.Add(Me.Wizard)
        Me.Controls.Add(Me.FormButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmNewMac"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.FormButtons.ResumeLayout(False)
        Me.Wizard.ResumeLayout(False)
        Me.CreateFrame.ResumeLayout(False)
        Me.CreateFrame.PerformLayout()
        Me.MacNameFrame.ResumeLayout(False)
        Me.MacNameFrame.PerformLayout()
        Me.AddFromFileFrame.ResumeLayout(False)
        Me.AddFromFileFrame.PerformLayout()
        Me.HwPresetsFrame.ResumeLayout(False)
        Me.HwPresetsFrame.PerformLayout()
        Me.RAMFrame.ResumeLayout(False)
        Me.RAMFrame.PerformLayout()
        Me.RAMControlsPanel.ResumeLayout(False)
        Me.RAMControlsPanel.PerformLayout()
        CType(Me.RAMSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiskFrame.ResumeLayout(False)
        Me.DiskFrame.PerformLayout()
        Me.DiskSizeFrame.ResumeLayout(False)
        Me.DiskSizeFrame.PerformLayout()
        CType(Me.DiskSize, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CreateFrame As System.Windows.Forms.Panel
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents DescriptionName As System.Windows.Forms.Label
    Friend WithEvents HwPresetsFrame As System.Windows.Forms.Panel
    Friend WithEvents AddFromFileFrame As System.Windows.Forms.Panel
    Friend WithEvents MacNameFrame As System.Windows.Forms.Panel
    Friend WithEvents DiskFrame As System.Windows.Forms.Panel
    Friend WithEvents RAMFrame As System.Windows.Forms.Panel
    Friend WithEvents EndWizard As System.Windows.Forms.Panel
    Friend WithEvents EndDiskPathLabel As System.Windows.Forms.Label
    Friend WithEvents EndRAMLabel As System.Windows.Forms.Label
    Friend WithEvents EndMacNameLabel As System.Windows.Forms.Label
    Friend WithEvents EndInfo As System.Windows.Forms.Label
    Friend WithEvents EndTitle As System.Windows.Forms.Label
    Friend WithEvents EndInfoFinish As System.Windows.Forms.Label
    Friend WithEvents EndDiskPath As System.Windows.Forms.Label
    Friend WithEvents EndRAM As System.Windows.Forms.Label
    Friend WithEvents EndMacName As System.Windows.Forms.Label
    Friend WithEvents CreateAddExist As System.Windows.Forms.RadioButton
    Friend WithEvents CreateNormal As System.Windows.Forms.RadioButton
    Friend WithEvents CreateInfo As System.Windows.Forms.Label
    Friend WithEvents CreateNormalLabel As System.Windows.Forms.Label
    Friend WithEvents CreateAddExistLabel As System.Windows.Forms.Label
    Friend WithEvents CreateNoWizardLabel As System.Windows.Forms.Label
    Friend WithEvents CreateNoWizard As System.Windows.Forms.RadioButton
    Friend WithEvents MacNameBrowse As System.Windows.Forms.Button
    Friend WithEvents MacName As System.Windows.Forms.TextBox
    Friend WithEvents MacNameLabel As System.Windows.Forms.Label
    Friend WithEvents Open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HwInfo As System.Windows.Forms.Label
    Friend WithEvents HwRAM As System.Windows.Forms.Label
    Friend WithEvents HwDisk As System.Windows.Forms.Label
    Friend WithEvents HwCPU As System.Windows.Forms.Label
    Friend WithEvents HwCPULabel As System.Windows.Forms.Label
    Friend WithEvents HwDiskLabel As System.Windows.Forms.Label
    Friend WithEvents HwRAMLabel As System.Windows.Forms.Label
    Friend WithEvents HwOSList As System.Windows.Forms.ComboBox
    Friend WithEvents HwEmulatorLabel As System.Windows.Forms.Label
    Friend WithEvents RAMLabelMB As System.Windows.Forms.Label
    Friend WithEvents RAMInfo As System.Windows.Forms.Label
    Friend WithEvents RAMBox As System.Windows.Forms.TextBox
    Friend WithEvents RAMSlider As System.Windows.Forms.TrackBar
    Friend WithEvents RAMCustom As System.Windows.Forms.RadioButton
    Friend WithEvents RAMDefault As System.Windows.Forms.RadioButton
    Friend WithEvents HwInfoDef As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RAMControlsPanel As System.Windows.Forms.Panel
    Friend WithEvents DiskSizeLabel As System.Windows.Forms.Label
    Friend WithEvents DiskSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents DiskSizeLabelMB As System.Windows.Forms.Label
    Friend WithEvents RAMCustomInvalidSize As System.Windows.Forms.Label
    Friend WithEvents DiskSizeFrame As System.Windows.Forms.Panel
    Friend WithEvents DiskInfo As System.Windows.Forms.Label
    Friend WithEvents DiskExisting As System.Windows.Forms.RadioButton
    Friend WithEvents DiskNew As System.Windows.Forms.RadioButton
    Friend WithEvents DiskPathBrowse As System.Windows.Forms.Button
    Friend WithEvents DiskPath As System.Windows.Forms.TextBox
    Friend WithEvents DiskNone As System.Windows.Forms.RadioButton
    Friend WithEvents AddFileBrowse As System.Windows.Forms.Button
    Friend WithEvents AddFile As System.Windows.Forms.TextBox
    Friend WithEvents AddInfo As System.Windows.Forms.Label
    Friend WithEvents AddFileLabel As System.Windows.Forms.Label
    Friend WithEvents AddEmulatorLabel As System.Windows.Forms.Label
    Friend WithEvents AddEmulator As System.Windows.Forms.ComboBox
    Friend WithEvents AddName As System.Windows.Forms.TextBox
    Friend WithEvents AddNameLabel As System.Windows.Forms.Label
    Friend WithEvents HwEmulator As System.Windows.Forms.ComboBox
End Class
