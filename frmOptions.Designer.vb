<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOptions
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public BrowseOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents FolderFrame As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.FolderFrame = New System.Windows.Forms.GroupBox()
        Me.FolderAppCurrent = New System.Windows.Forms.Label()
        Me.FolderAppCurrentLabel = New System.Windows.Forms.Label()
        Me.FolderNewMacLabel = New System.Windows.Forms.Label()
        Me.FolderNewMac = New System.Windows.Forms.TextBox()
        Me.FolderNewMacBrowse = New System.Windows.Forms.Button()
        Me.ROMFrame = New System.Windows.Forms.GroupBox()
        Me.ROMNoteNoROM = New System.Windows.Forms.Label()
        Me.ROMSS = New System.Windows.Forms.TextBox()
        Me.ROMSSLabel = New System.Windows.Forms.Label()
        Me.ROMSSBrowse = New System.Windows.Forms.Button()
        Me.ROMBII = New System.Windows.Forms.TextBox()
        Me.ROMBIILabel = New System.Windows.Forms.Label()
        Me.ROMBIIBrowse = New System.Windows.Forms.Button()
        Me.ROMvMac = New System.Windows.Forms.TextBox()
        Me.ROMvMacLabel = New System.Windows.Forms.Label()
        Me.ROMvMacBrowse = New System.Windows.Forms.Button()
        Me.OptionContainer = New System.Windows.Forms.ListView()
        Me.Setting = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UseContainerFrame = New System.Windows.Forms.GroupBox()
        Me.UCDisableTest = New System.Windows.Forms.RadioButton()
        Me.UCEnableTest = New System.Windows.Forms.RadioButton()
        Me.EmulatorPathFrame = New System.Windows.Forms.GroupBox()
        Me.EPVerifyEmulatorPaths = New System.Windows.Forms.CheckBox()
        Me.EPvMacPathLabel = New System.Windows.Forms.Label()
        Me.EPvMacPath = New System.Windows.Forms.TextBox()
        Me.EPvMacPathBrowse = New System.Windows.Forms.Button()
        Me.EPQEMUPathLabel = New System.Windows.Forms.Label()
        Me.EPQEMUPath = New System.Windows.Forms.TextBox()
        Me.EPQEMUPathBrowse = New System.Windows.Forms.Button()
        Me.EPPPCPathLabel = New System.Windows.Forms.Label()
        Me.EPPPCPath = New System.Windows.Forms.TextBox()
        Me.EPPPCPathBrowse = New System.Windows.Forms.Button()
        Me.EPSSPathLabel = New System.Windows.Forms.Label()
        Me.EPSSPath = New System.Windows.Forms.TextBox()
        Me.EPSSPathBrowse = New System.Windows.Forms.Button()
        Me.EPBIIPathLabel = New System.Windows.Forms.Label()
        Me.EPBIIPath = New System.Windows.Forms.TextBox()
        Me.EPBIIPathBrowse = New System.Windows.Forms.Button()
        Me.LangFrame = New System.Windows.Forms.GroupBox()
        Me.LangSelected = New System.Windows.Forms.ComboBox()
        Me.LangInfo = New System.Windows.Forms.Label()
        Me.BrowseOpen = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderFrame.SuspendLayout()
        Me.ROMFrame.SuspendLayout()
        Me.UseContainerFrame.SuspendLayout()
        Me.EmulatorPathFrame.SuspendLayout()
        Me.LangFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        resources.ApplyResources(Me.cmdOK, "cmdOK")
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Tag = "1024"
        Me.ToolTip1.SetToolTip(Me.cmdOK, resources.GetString("cmdOK.ToolTip"))
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Tag = "1023"
        Me.ToolTip1.SetToolTip(Me.cmdCancel, resources.GetString("cmdCancel.ToolTip"))
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'FolderFrame
        '
        resources.ApplyResources(Me.FolderFrame, "FolderFrame")
        Me.FolderFrame.BackColor = System.Drawing.SystemColors.Control
        Me.FolderFrame.Controls.Add(Me.FolderAppCurrent)
        Me.FolderFrame.Controls.Add(Me.FolderAppCurrentLabel)
        Me.FolderFrame.Controls.Add(Me.FolderNewMacLabel)
        Me.FolderFrame.Controls.Add(Me.FolderNewMac)
        Me.FolderFrame.Controls.Add(Me.FolderNewMacBrowse)
        Me.FolderFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FolderFrame.Name = "FolderFrame"
        Me.FolderFrame.TabStop = False
        Me.ToolTip1.SetToolTip(Me.FolderFrame, resources.GetString("FolderFrame.ToolTip"))
        '
        'FolderAppCurrent
        '
        resources.ApplyResources(Me.FolderAppCurrent, "FolderAppCurrent")
        Me.FolderAppCurrent.Name = "FolderAppCurrent"
        Me.ToolTip1.SetToolTip(Me.FolderAppCurrent, resources.GetString("FolderAppCurrent.ToolTip"))
        '
        'FolderAppCurrentLabel
        '
        resources.ApplyResources(Me.FolderAppCurrentLabel, "FolderAppCurrentLabel")
        Me.FolderAppCurrentLabel.Name = "FolderAppCurrentLabel"
        Me.ToolTip1.SetToolTip(Me.FolderAppCurrentLabel, resources.GetString("FolderAppCurrentLabel.ToolTip"))
        '
        'FolderNewMacLabel
        '
        resources.ApplyResources(Me.FolderNewMacLabel, "FolderNewMacLabel")
        Me.FolderNewMacLabel.BackColor = System.Drawing.SystemColors.Control
        Me.FolderNewMacLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FolderNewMacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FolderNewMacLabel.Name = "FolderNewMacLabel"
        Me.ToolTip1.SetToolTip(Me.FolderNewMacLabel, resources.GetString("FolderNewMacLabel.ToolTip"))
        '
        'FolderNewMac
        '
        Me.FolderNewMac.AcceptsReturn = True
        resources.ApplyResources(Me.FolderNewMac, "FolderNewMac")
        Me.FolderNewMac.BackColor = System.Drawing.SystemColors.Window
        Me.FolderNewMac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FolderNewMac.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FolderNewMac.Name = "FolderNewMac"
        Me.FolderNewMac.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.FolderNewMac, resources.GetString("FolderNewMac.ToolTip"))
        '
        'FolderNewMacBrowse
        '
        resources.ApplyResources(Me.FolderNewMacBrowse, "FolderNewMacBrowse")
        Me.FolderNewMacBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.FolderNewMacBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.FolderNewMacBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FolderNewMacBrowse.Name = "FolderNewMacBrowse"
        Me.ToolTip1.SetToolTip(Me.FolderNewMacBrowse, resources.GetString("FolderNewMacBrowse.ToolTip"))
        Me.FolderNewMacBrowse.UseVisualStyleBackColor = True
        '
        'ROMFrame
        '
        resources.ApplyResources(Me.ROMFrame, "ROMFrame")
        Me.ROMFrame.BackColor = System.Drawing.SystemColors.Control
        Me.ROMFrame.Controls.Add(Me.ROMNoteNoROM)
        Me.ROMFrame.Controls.Add(Me.ROMSS)
        Me.ROMFrame.Controls.Add(Me.ROMSSLabel)
        Me.ROMFrame.Controls.Add(Me.ROMSSBrowse)
        Me.ROMFrame.Controls.Add(Me.ROMBII)
        Me.ROMFrame.Controls.Add(Me.ROMBIILabel)
        Me.ROMFrame.Controls.Add(Me.ROMBIIBrowse)
        Me.ROMFrame.Controls.Add(Me.ROMvMac)
        Me.ROMFrame.Controls.Add(Me.ROMvMacLabel)
        Me.ROMFrame.Controls.Add(Me.ROMvMacBrowse)
        Me.ROMFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ROMFrame.Name = "ROMFrame"
        Me.ROMFrame.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ROMFrame, resources.GetString("ROMFrame.ToolTip"))
        '
        'ROMNoteNoROM
        '
        resources.ApplyResources(Me.ROMNoteNoROM, "ROMNoteNoROM")
        Me.ROMNoteNoROM.Name = "ROMNoteNoROM"
        Me.ToolTip1.SetToolTip(Me.ROMNoteNoROM, resources.GetString("ROMNoteNoROM.ToolTip"))
        '
        'ROMSS
        '
        Me.ROMSS.AcceptsReturn = True
        resources.ApplyResources(Me.ROMSS, "ROMSS")
        Me.ROMSS.BackColor = System.Drawing.SystemColors.Window
        Me.ROMSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ROMSS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ROMSS.Name = "ROMSS"
        Me.ROMSS.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.ROMSS, resources.GetString("ROMSS.ToolTip"))
        '
        'ROMSSLabel
        '
        resources.ApplyResources(Me.ROMSSLabel, "ROMSSLabel")
        Me.ROMSSLabel.Name = "ROMSSLabel"
        Me.ToolTip1.SetToolTip(Me.ROMSSLabel, resources.GetString("ROMSSLabel.ToolTip"))
        '
        'ROMSSBrowse
        '
        resources.ApplyResources(Me.ROMSSBrowse, "ROMSSBrowse")
        Me.ROMSSBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.ROMSSBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.ROMSSBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ROMSSBrowse.Name = "ROMSSBrowse"
        Me.ToolTip1.SetToolTip(Me.ROMSSBrowse, resources.GetString("ROMSSBrowse.ToolTip"))
        Me.ROMSSBrowse.UseVisualStyleBackColor = True
        '
        'ROMBII
        '
        Me.ROMBII.AcceptsReturn = True
        resources.ApplyResources(Me.ROMBII, "ROMBII")
        Me.ROMBII.BackColor = System.Drawing.SystemColors.Window
        Me.ROMBII.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ROMBII.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ROMBII.Name = "ROMBII"
        Me.ROMBII.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.ROMBII, resources.GetString("ROMBII.ToolTip"))
        '
        'ROMBIILabel
        '
        resources.ApplyResources(Me.ROMBIILabel, "ROMBIILabel")
        Me.ROMBIILabel.Name = "ROMBIILabel"
        Me.ToolTip1.SetToolTip(Me.ROMBIILabel, resources.GetString("ROMBIILabel.ToolTip"))
        '
        'ROMBIIBrowse
        '
        resources.ApplyResources(Me.ROMBIIBrowse, "ROMBIIBrowse")
        Me.ROMBIIBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.ROMBIIBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.ROMBIIBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ROMBIIBrowse.Name = "ROMBIIBrowse"
        Me.ToolTip1.SetToolTip(Me.ROMBIIBrowse, resources.GetString("ROMBIIBrowse.ToolTip"))
        Me.ROMBIIBrowse.UseVisualStyleBackColor = True
        '
        'ROMvMac
        '
        Me.ROMvMac.AcceptsReturn = True
        resources.ApplyResources(Me.ROMvMac, "ROMvMac")
        Me.ROMvMac.BackColor = System.Drawing.SystemColors.Window
        Me.ROMvMac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ROMvMac.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ROMvMac.Name = "ROMvMac"
        Me.ROMvMac.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.ROMvMac, resources.GetString("ROMvMac.ToolTip"))
        '
        'ROMvMacLabel
        '
        resources.ApplyResources(Me.ROMvMacLabel, "ROMvMacLabel")
        Me.ROMvMacLabel.Name = "ROMvMacLabel"
        Me.ToolTip1.SetToolTip(Me.ROMvMacLabel, resources.GetString("ROMvMacLabel.ToolTip"))
        '
        'ROMvMacBrowse
        '
        resources.ApplyResources(Me.ROMvMacBrowse, "ROMvMacBrowse")
        Me.ROMvMacBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.ROMvMacBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.ROMvMacBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ROMvMacBrowse.Name = "ROMvMacBrowse"
        Me.ToolTip1.SetToolTip(Me.ROMvMacBrowse, resources.GetString("ROMvMacBrowse.ToolTip"))
        Me.ROMvMacBrowse.UseVisualStyleBackColor = True
        '
        'OptionContainer
        '
        resources.ApplyResources(Me.OptionContainer, "OptionContainer")
        Me.OptionContainer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Setting, Me.Value})
        Me.OptionContainer.FullRowSelect = True
        Me.OptionContainer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionContainer.Items.AddRange(New System.Windows.Forms.ListViewItem() {CType(resources.GetObject("OptionContainer.Items"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionContainer.Items1"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionContainer.Items2"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionContainer.Items3"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionContainer.Items4"), System.Windows.Forms.ListViewItem)})
        Me.OptionContainer.Name = "OptionContainer"
        Me.ToolTip1.SetToolTip(Me.OptionContainer, resources.GetString("OptionContainer.ToolTip"))
        Me.OptionContainer.UseCompatibleStateImageBehavior = False
        Me.OptionContainer.View = System.Windows.Forms.View.Details
        '
        'Setting
        '
        resources.ApplyResources(Me.Setting, "Setting")
        '
        'Value
        '
        resources.ApplyResources(Me.Value, "Value")
        '
        'UseContainerFrame
        '
        resources.ApplyResources(Me.UseContainerFrame, "UseContainerFrame")
        Me.UseContainerFrame.BackColor = System.Drawing.SystemColors.Control
        Me.UseContainerFrame.Controls.Add(Me.UCDisableTest)
        Me.UseContainerFrame.Controls.Add(Me.UCEnableTest)
        Me.UseContainerFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UseContainerFrame.Name = "UseContainerFrame"
        Me.UseContainerFrame.TabStop = False
        Me.ToolTip1.SetToolTip(Me.UseContainerFrame, resources.GetString("UseContainerFrame.ToolTip"))
        '
        'UCDisableTest
        '
        resources.ApplyResources(Me.UCDisableTest, "UCDisableTest")
        Me.UCDisableTest.Name = "UCDisableTest"
        Me.ToolTip1.SetToolTip(Me.UCDisableTest, resources.GetString("UCDisableTest.ToolTip"))
        Me.UCDisableTest.UseVisualStyleBackColor = True
        '
        'UCEnableTest
        '
        resources.ApplyResources(Me.UCEnableTest, "UCEnableTest")
        Me.UCEnableTest.Name = "UCEnableTest"
        Me.ToolTip1.SetToolTip(Me.UCEnableTest, resources.GetString("UCEnableTest.ToolTip"))
        Me.UCEnableTest.UseVisualStyleBackColor = True
        '
        'EmulatorPathFrame
        '
        resources.ApplyResources(Me.EmulatorPathFrame, "EmulatorPathFrame")
        Me.EmulatorPathFrame.BackColor = System.Drawing.SystemColors.Control
        Me.EmulatorPathFrame.Controls.Add(Me.EPVerifyEmulatorPaths)
        Me.EmulatorPathFrame.Controls.Add(Me.EPvMacPathLabel)
        Me.EmulatorPathFrame.Controls.Add(Me.EPvMacPath)
        Me.EmulatorPathFrame.Controls.Add(Me.EPvMacPathBrowse)
        Me.EmulatorPathFrame.Controls.Add(Me.EPQEMUPathLabel)
        Me.EmulatorPathFrame.Controls.Add(Me.EPQEMUPath)
        Me.EmulatorPathFrame.Controls.Add(Me.EPQEMUPathBrowse)
        Me.EmulatorPathFrame.Controls.Add(Me.EPPPCPathLabel)
        Me.EmulatorPathFrame.Controls.Add(Me.EPPPCPath)
        Me.EmulatorPathFrame.Controls.Add(Me.EPPPCPathBrowse)
        Me.EmulatorPathFrame.Controls.Add(Me.EPSSPathLabel)
        Me.EmulatorPathFrame.Controls.Add(Me.EPSSPath)
        Me.EmulatorPathFrame.Controls.Add(Me.EPSSPathBrowse)
        Me.EmulatorPathFrame.Controls.Add(Me.EPBIIPathLabel)
        Me.EmulatorPathFrame.Controls.Add(Me.EPBIIPath)
        Me.EmulatorPathFrame.Controls.Add(Me.EPBIIPathBrowse)
        Me.EmulatorPathFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EmulatorPathFrame.Name = "EmulatorPathFrame"
        Me.EmulatorPathFrame.TabStop = False
        Me.ToolTip1.SetToolTip(Me.EmulatorPathFrame, resources.GetString("EmulatorPathFrame.ToolTip"))
        '
        'EPVerifyEmulatorPaths
        '
        resources.ApplyResources(Me.EPVerifyEmulatorPaths, "EPVerifyEmulatorPaths")
        Me.EPVerifyEmulatorPaths.Name = "EPVerifyEmulatorPaths"
        Me.ToolTip1.SetToolTip(Me.EPVerifyEmulatorPaths, resources.GetString("EPVerifyEmulatorPaths.ToolTip"))
        Me.EPVerifyEmulatorPaths.UseVisualStyleBackColor = True
        '
        'EPvMacPathLabel
        '
        resources.ApplyResources(Me.EPvMacPathLabel, "EPvMacPathLabel")
        Me.EPvMacPathLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EPvMacPathLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPvMacPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPvMacPathLabel.Name = "EPvMacPathLabel"
        Me.ToolTip1.SetToolTip(Me.EPvMacPathLabel, resources.GetString("EPvMacPathLabel.ToolTip"))
        '
        'EPvMacPath
        '
        Me.EPvMacPath.AcceptsReturn = True
        resources.ApplyResources(Me.EPvMacPath, "EPvMacPath")
        Me.EPvMacPath.BackColor = System.Drawing.SystemColors.Window
        Me.EPvMacPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EPvMacPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EPvMacPath.Name = "EPvMacPath"
        Me.EPvMacPath.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.EPvMacPath, resources.GetString("EPvMacPath.ToolTip"))
        '
        'EPvMacPathBrowse
        '
        resources.ApplyResources(Me.EPvMacPathBrowse, "EPvMacPathBrowse")
        Me.EPvMacPathBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.EPvMacPathBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPvMacPathBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPvMacPathBrowse.Name = "EPvMacPathBrowse"
        Me.ToolTip1.SetToolTip(Me.EPvMacPathBrowse, resources.GetString("EPvMacPathBrowse.ToolTip"))
        Me.EPvMacPathBrowse.UseVisualStyleBackColor = True
        '
        'EPQEMUPathLabel
        '
        resources.ApplyResources(Me.EPQEMUPathLabel, "EPQEMUPathLabel")
        Me.EPQEMUPathLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EPQEMUPathLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPQEMUPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPQEMUPathLabel.Name = "EPQEMUPathLabel"
        Me.ToolTip1.SetToolTip(Me.EPQEMUPathLabel, resources.GetString("EPQEMUPathLabel.ToolTip"))
        '
        'EPQEMUPath
        '
        Me.EPQEMUPath.AcceptsReturn = True
        resources.ApplyResources(Me.EPQEMUPath, "EPQEMUPath")
        Me.EPQEMUPath.BackColor = System.Drawing.SystemColors.Window
        Me.EPQEMUPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EPQEMUPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EPQEMUPath.Name = "EPQEMUPath"
        Me.EPQEMUPath.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.EPQEMUPath, resources.GetString("EPQEMUPath.ToolTip"))
        '
        'EPQEMUPathBrowse
        '
        resources.ApplyResources(Me.EPQEMUPathBrowse, "EPQEMUPathBrowse")
        Me.EPQEMUPathBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.EPQEMUPathBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPQEMUPathBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPQEMUPathBrowse.Name = "EPQEMUPathBrowse"
        Me.ToolTip1.SetToolTip(Me.EPQEMUPathBrowse, resources.GetString("EPQEMUPathBrowse.ToolTip"))
        Me.EPQEMUPathBrowse.UseVisualStyleBackColor = True
        '
        'EPPPCPathLabel
        '
        resources.ApplyResources(Me.EPPPCPathLabel, "EPPPCPathLabel")
        Me.EPPPCPathLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EPPPCPathLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPPPCPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPPPCPathLabel.Name = "EPPPCPathLabel"
        Me.ToolTip1.SetToolTip(Me.EPPPCPathLabel, resources.GetString("EPPPCPathLabel.ToolTip"))
        '
        'EPPPCPath
        '
        Me.EPPPCPath.AcceptsReturn = True
        resources.ApplyResources(Me.EPPPCPath, "EPPPCPath")
        Me.EPPPCPath.BackColor = System.Drawing.SystemColors.Window
        Me.EPPPCPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EPPPCPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EPPPCPath.Name = "EPPPCPath"
        Me.EPPPCPath.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.EPPPCPath, resources.GetString("EPPPCPath.ToolTip"))
        '
        'EPPPCPathBrowse
        '
        resources.ApplyResources(Me.EPPPCPathBrowse, "EPPPCPathBrowse")
        Me.EPPPCPathBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.EPPPCPathBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPPPCPathBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPPPCPathBrowse.Name = "EPPPCPathBrowse"
        Me.ToolTip1.SetToolTip(Me.EPPPCPathBrowse, resources.GetString("EPPPCPathBrowse.ToolTip"))
        Me.EPPPCPathBrowse.UseVisualStyleBackColor = True
        '
        'EPSSPathLabel
        '
        resources.ApplyResources(Me.EPSSPathLabel, "EPSSPathLabel")
        Me.EPSSPathLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EPSSPathLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPSSPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPSSPathLabel.Name = "EPSSPathLabel"
        Me.ToolTip1.SetToolTip(Me.EPSSPathLabel, resources.GetString("EPSSPathLabel.ToolTip"))
        '
        'EPSSPath
        '
        Me.EPSSPath.AcceptsReturn = True
        resources.ApplyResources(Me.EPSSPath, "EPSSPath")
        Me.EPSSPath.BackColor = System.Drawing.SystemColors.Window
        Me.EPSSPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EPSSPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EPSSPath.Name = "EPSSPath"
        Me.EPSSPath.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.EPSSPath, resources.GetString("EPSSPath.ToolTip"))
        '
        'EPSSPathBrowse
        '
        resources.ApplyResources(Me.EPSSPathBrowse, "EPSSPathBrowse")
        Me.EPSSPathBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.EPSSPathBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPSSPathBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPSSPathBrowse.Name = "EPSSPathBrowse"
        Me.ToolTip1.SetToolTip(Me.EPSSPathBrowse, resources.GetString("EPSSPathBrowse.ToolTip"))
        Me.EPSSPathBrowse.UseVisualStyleBackColor = True
        '
        'EPBIIPathLabel
        '
        resources.ApplyResources(Me.EPBIIPathLabel, "EPBIIPathLabel")
        Me.EPBIIPathLabel.BackColor = System.Drawing.SystemColors.Control
        Me.EPBIIPathLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPBIIPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPBIIPathLabel.Name = "EPBIIPathLabel"
        Me.ToolTip1.SetToolTip(Me.EPBIIPathLabel, resources.GetString("EPBIIPathLabel.ToolTip"))
        '
        'EPBIIPath
        '
        Me.EPBIIPath.AcceptsReturn = True
        resources.ApplyResources(Me.EPBIIPath, "EPBIIPath")
        Me.EPBIIPath.BackColor = System.Drawing.SystemColors.Window
        Me.EPBIIPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EPBIIPath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.EPBIIPath.Name = "EPBIIPath"
        Me.EPBIIPath.ReadOnly = True
        Me.ToolTip1.SetToolTip(Me.EPBIIPath, resources.GetString("EPBIIPath.ToolTip"))
        '
        'EPBIIPathBrowse
        '
        resources.ApplyResources(Me.EPBIIPathBrowse, "EPBIIPathBrowse")
        Me.EPBIIPathBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.EPBIIPathBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.EPBIIPathBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EPBIIPathBrowse.Name = "EPBIIPathBrowse"
        Me.ToolTip1.SetToolTip(Me.EPBIIPathBrowse, resources.GetString("EPBIIPathBrowse.ToolTip"))
        Me.EPBIIPathBrowse.UseVisualStyleBackColor = True
        '
        'LangFrame
        '
        resources.ApplyResources(Me.LangFrame, "LangFrame")
        Me.LangFrame.BackColor = System.Drawing.SystemColors.Control
        Me.LangFrame.Controls.Add(Me.LangSelected)
        Me.LangFrame.Controls.Add(Me.LangInfo)
        Me.LangFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LangFrame.Name = "LangFrame"
        Me.LangFrame.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LangFrame, resources.GetString("LangFrame.ToolTip"))
        '
        'LangSelected
        '
        resources.ApplyResources(Me.LangSelected, "LangSelected")
        Me.LangSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LangSelected.FormattingEnabled = True
        Me.LangSelected.Items.AddRange(New Object() {resources.GetString("LangSelected.Items"), resources.GetString("LangSelected.Items1"), resources.GetString("LangSelected.Items2")})
        Me.LangSelected.Name = "LangSelected"
        Me.ToolTip1.SetToolTip(Me.LangSelected, resources.GetString("LangSelected.ToolTip"))
        '
        'LangInfo
        '
        resources.ApplyResources(Me.LangInfo, "LangInfo")
        Me.LangInfo.Name = "LangInfo"
        Me.ToolTip1.SetToolTip(Me.LangInfo, resources.GetString("LangInfo.ToolTip"))
        '
        'BrowseOpen
        '
        resources.ApplyResources(Me.BrowseOpen, "BrowseOpen")
        Me.BrowseOpen.ReadOnlyChecked = True
        Me.BrowseOpen.ShowReadOnly = True
        '
        'FolderBrowser
        '
        resources.ApplyResources(Me.FolderBrowser, "FolderBrowser")
        '
        'frmOptions
        '
        Me.AcceptButton = Me.cmdOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(Me.EmulatorPathFrame)
        Me.Controls.Add(Me.ROMFrame)
        Me.Controls.Add(Me.UseContainerFrame)
        Me.Controls.Add(Me.FolderFrame)
        Me.Controls.Add(Me.LangFrame)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.OptionContainer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowIcon = False
        Me.Tag = "1017"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.FolderFrame.ResumeLayout(False)
        Me.FolderFrame.PerformLayout()
        Me.ROMFrame.ResumeLayout(False)
        Me.ROMFrame.PerformLayout()
        Me.UseContainerFrame.ResumeLayout(False)
        Me.UseContainerFrame.PerformLayout()
        Me.EmulatorPathFrame.ResumeLayout(False)
        Me.EmulatorPathFrame.PerformLayout()
        Me.LangFrame.ResumeLayout(False)
        Me.LangFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents FolderNewMacLabel As System.Windows.Forms.Label
    Public WithEvents FolderNewMac As System.Windows.Forms.TextBox
    Public WithEvents FolderNewMacBrowse As System.Windows.Forms.Button
    Public WithEvents ROMFrame As System.Windows.Forms.GroupBox
    Public WithEvents ROMvMac As System.Windows.Forms.TextBox
    Public WithEvents ROMvMacBrowse As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Setting As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Public WithEvents UseContainerFrame As System.Windows.Forms.GroupBox
    Friend WithEvents UCDisableTest As System.Windows.Forms.RadioButton
    Friend WithEvents UCEnableTest As System.Windows.Forms.RadioButton
    Friend WithEvents OptionContainer As System.Windows.Forms.ListView
    Friend WithEvents ROMSSLabel As System.Windows.Forms.Label
    Public WithEvents ROMSS As System.Windows.Forms.TextBox
    Public WithEvents ROMSSBrowse As System.Windows.Forms.Button
    Friend WithEvents ROMBIILabel As System.Windows.Forms.Label
    Public WithEvents ROMBII As System.Windows.Forms.TextBox
    Public WithEvents ROMBIIBrowse As System.Windows.Forms.Button
    Friend WithEvents ROMvMacLabel As System.Windows.Forms.Label
    Friend WithEvents ROMNoteNoROM As System.Windows.Forms.Label
    Friend WithEvents FolderAppCurrentLabel As System.Windows.Forms.Label
    Friend WithEvents FolderAppCurrent As System.Windows.Forms.Label
    Public WithEvents EmulatorPathFrame As System.Windows.Forms.GroupBox
    Public WithEvents EPBIIPathLabel As System.Windows.Forms.Label
    Public WithEvents EPBIIPath As System.Windows.Forms.TextBox
    Public WithEvents EPBIIPathBrowse As System.Windows.Forms.Button
    Public WithEvents EPQEMUPathLabel As System.Windows.Forms.Label
    Public WithEvents EPQEMUPath As System.Windows.Forms.TextBox
    Public WithEvents EPQEMUPathBrowse As System.Windows.Forms.Button
    Public WithEvents EPPPCPathLabel As System.Windows.Forms.Label
    Public WithEvents EPPPCPath As System.Windows.Forms.TextBox
    Public WithEvents EPPPCPathBrowse As System.Windows.Forms.Button
    Public WithEvents EPSSPathLabel As System.Windows.Forms.Label
    Public WithEvents EPSSPath As System.Windows.Forms.TextBox
    Public WithEvents EPSSPathBrowse As System.Windows.Forms.Button
    Public WithEvents EPvMacPathLabel As System.Windows.Forms.Label
    Public WithEvents EPvMacPath As System.Windows.Forms.TextBox
    Public WithEvents EPvMacPathBrowse As System.Windows.Forms.Button
    Friend WithEvents EPVerifyEmulatorPaths As System.Windows.Forms.CheckBox
    Public WithEvents LangFrame As System.Windows.Forms.GroupBox
    Friend WithEvents LangSelected As System.Windows.Forms.ComboBox
    Friend WithEvents LangInfo As System.Windows.Forms.Label
#End Region
End Class