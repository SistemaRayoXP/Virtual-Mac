<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
                fTerminateCalled = True
            End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Start As System.Windows.Forms.Button
	Public WithEvents Remove As System.Windows.Forms.Button
	Public WithEvents Settings As System.Windows.Forms.Button
	Public WithEvents NewMac As System.Windows.Forms.Button
	Public WithEvents VMGraphicScroll As System.Windows.Forms.VScrollBar
	Public WithEvents _VMSnap_0 As System.Windows.Forms.PictureBox
	Public WithEvents _VMName_0 As System.Windows.Forms.Label
	Public WithEvents _VMDescription_0 As System.Windows.Forms.Label
	Public WithEvents _VM_0 As System.Windows.Forms.Panel
	Public WithEvents VMGraphicList As System.Windows.Forms.Panel
	Public WithEvents VMList As System.Windows.Forms.ListBox
	Public WithEvents VM As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents VMDescription As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents VMName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents VMSnap As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Start = New System.Windows.Forms.Button
        Me.Remove = New System.Windows.Forms.Button
        Me.Settings = New System.Windows.Forms.Button
        Me.NewMac = New System.Windows.Forms.Button
        Me.VMGraphicList = New System.Windows.Forms.Panel
        Me.VMList = New System.Windows.Forms.ListBox
        Me.VMGraphicScroll = New System.Windows.Forms.VScrollBar
        Me._VM_0 = New System.Windows.Forms.Panel
        Me._VMSnap_0 = New System.Windows.Forms.PictureBox
        Me._VMName_0 = New System.Windows.Forms.Label
        Me._VMDescription_0 = New System.Windows.Forms.Label
        Me.VM = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
        Me.VMDescription = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.VMName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.VMSnap = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.VirtualMacTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowVMC = New System.Windows.Forms.ToolStripMenuItem
        Me.IconNewMac = New System.Windows.Forms.ToolStripMenuItem
        Me.IconNewDisk = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.IconOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuBar1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuBar2 = New System.Windows.Forms.ToolStripSeparator
        Me.IconExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNewMac = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNewDisk = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFileOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileBar1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAction = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionStart = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuActionPause = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionRestart = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionBar1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuActionRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionBar2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuActionSettings = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionProperties = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpContents = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpSearchForHelpOn = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.VMGraphicList.SuspendLayout()
        Me._VM_0.SuspendLayout()
        CType(Me._VMSnap_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMSnap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.SystemColors.Control
        Me.Start.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Start, "Start")
        Me.Start.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Start.Name = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Remove
        '
        Me.Remove.BackColor = System.Drawing.SystemColors.Control
        Me.Remove.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Remove, "Remove")
        Me.Remove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Remove.Name = "Remove"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.SystemColors.Control
        Me.Settings.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Settings, "Settings")
        Me.Settings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Settings.Name = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'NewMac
        '
        Me.NewMac.BackColor = System.Drawing.SystemColors.Control
        Me.NewMac.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMac.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMac, "NewMac")
        Me.NewMac.Name = "NewMac"
        Me.NewMac.UseVisualStyleBackColor = True
        '
        'VMGraphicList
        '
        Me.VMGraphicList.BackColor = System.Drawing.Color.White
        Me.VMGraphicList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VMGraphicList.Controls.Add(Me.VMList)
        Me.VMGraphicList.Controls.Add(Me.VMGraphicScroll)
        Me.VMGraphicList.Controls.Add(Me._VM_0)
        Me.VMGraphicList.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMGraphicList.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.VMGraphicList, "VMGraphicList")
        Me.VMGraphicList.Name = "VMGraphicList"
        Me.VMGraphicList.TabStop = True
        '
        'VMList
        '
        Me.VMList.BackColor = System.Drawing.SystemColors.Window
        Me.VMList.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMList.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.VMList, "VMList")
        Me.VMList.Name = "VMList"
        '
        'VMGraphicScroll
        '
        Me.VMGraphicScroll.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMGraphicScroll.LargeChange = 1
        resources.ApplyResources(Me.VMGraphicScroll, "VMGraphicScroll")
        Me.VMGraphicScroll.Maximum = 3
        Me.VMGraphicScroll.Name = "VMGraphicScroll"
        Me.VMGraphicScroll.TabStop = True
        '
        '_VM_0
        '
        Me._VM_0.BackColor = System.Drawing.Color.White
        Me._VM_0.Controls.Add(Me._VMSnap_0)
        Me._VM_0.Controls.Add(Me._VMName_0)
        Me._VM_0.Controls.Add(Me._VMDescription_0)
        Me._VM_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._VM_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VM.SetIndex(Me._VM_0, CType(0, Short))
        resources.ApplyResources(Me._VM_0, "_VM_0")
        Me._VM_0.Name = "_VM_0"
        '
        '_VMSnap_0
        '
        Me._VMSnap_0.BackColor = System.Drawing.SystemColors.Control
        Me._VMSnap_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._VMSnap_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._VMSnap_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMSnap.SetIndex(Me._VMSnap_0, CType(0, Short))
        resources.ApplyResources(Me._VMSnap_0, "_VMSnap_0")
        Me._VMSnap_0.Name = "_VMSnap_0"
        Me._VMSnap_0.TabStop = False
        '
        '_VMName_0
        '
        Me._VMName_0.BackColor = System.Drawing.Color.Transparent
        Me._VMName_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._VMName_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMName.SetIndex(Me._VMName_0, CType(0, Short))
        resources.ApplyResources(Me._VMName_0, "_VMName_0")
        Me._VMName_0.Name = "_VMName_0"
        '
        '_VMDescription_0
        '
        Me._VMDescription_0.BackColor = System.Drawing.Color.Transparent
        Me._VMDescription_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._VMDescription_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMDescription.SetIndex(Me._VMDescription_0, CType(0, Short))
        resources.ApplyResources(Me._VMDescription_0, "_VMDescription_0")
        Me._VMDescription_0.Name = "_VMDescription_0"
        '
        'VM
        '
        '
        'VMDescription
        '
        '
        'VMName
        '
        '
        'VMSnap
        '
        '
        'VirtualMacTray
        '
        Me.VirtualMacTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.VirtualMacTray, "VirtualMacTray")
        Me.VirtualMacTray.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowVMC, Me.IconNewMac, Me.IconNewDisk, Me.MenuBar0, Me.IconOptions, Me.MenuBar1, Me.MenuBar2, Me.IconExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'ShowVMC
        '
        resources.ApplyResources(Me.ShowVMC, "ShowVMC")
        Me.ShowVMC.Name = "ShowVMC"
        '
        'IconNewMac
        '
        Me.IconNewMac.Name = "IconNewMac"
        resources.ApplyResources(Me.IconNewMac, "IconNewMac")
        '
        'IconNewDisk
        '
        Me.IconNewDisk.Name = "IconNewDisk"
        resources.ApplyResources(Me.IconNewDisk, "IconNewDisk")
        '
        'MenuBar0
        '
        Me.MenuBar0.Name = "MenuBar0"
        resources.ApplyResources(Me.MenuBar0, "MenuBar0")
        '
        'IconOptions
        '
        Me.IconOptions.Name = "IconOptions"
        resources.ApplyResources(Me.IconOptions, "IconOptions")
        '
        'MenuBar1
        '
        Me.MenuBar1.Name = "MenuBar1"
        resources.ApplyResources(Me.MenuBar1, "MenuBar1")
        '
        'MenuBar2
        '
        Me.MenuBar2.Name = "MenuBar2"
        resources.ApplyResources(Me.MenuBar2, "MenuBar2")
        '
        'IconExit
        '
        Me.IconExit.Name = "IconExit"
        resources.ApplyResources(Me.IconExit, "IconExit")
        '
        'mnuFile
        '
        resources.ApplyResources(Me.mnuFile, "mnuFile")
        Me.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewMac, Me.mnuNewDisk, Me.mnuFileBar0, Me.mnuFileOptions, Me.mnuFileBar1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        '
        'mnuNewMac
        '
        Me.mnuNewMac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuNewMac.Name = "mnuNewMac"
        resources.ApplyResources(Me.mnuNewMac, "mnuNewMac")
        '
        'mnuNewDisk
        '
        Me.mnuNewDisk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuNewDisk.Name = "mnuNewDisk"
        resources.ApplyResources(Me.mnuNewDisk, "mnuNewDisk")
        '
        'mnuFileBar0
        '
        Me.mnuFileBar0.Name = "mnuFileBar0"
        resources.ApplyResources(Me.mnuFileBar0, "mnuFileBar0")
        '
        'mnuFileOptions
        '
        Me.mnuFileOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFileOptions.Name = "mnuFileOptions"
        resources.ApplyResources(Me.mnuFileOptions, "mnuFileOptions")
        '
        'mnuFileBar1
        '
        Me.mnuFileBar1.Name = "mnuFileBar1"
        resources.ApplyResources(Me.mnuFileBar1, "mnuFileBar1")
        '
        'mnuFileExit
        '
        Me.mnuFileExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFileExit.Name = "mnuFileExit"
        resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
        '
        'mnuAction
        '
        resources.ApplyResources(Me.mnuAction, "mnuAction")
        Me.mnuAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuAction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActionStart, Me.mnuActionBar0, Me.mnuActionPause, Me.mnuActionRestart, Me.mnuActionBar1, Me.mnuActionRemove, Me.mnuActionBar2, Me.mnuActionSettings, Me.mnuActionProperties})
        Me.mnuAction.Name = "mnuAction"
        '
        'mnuActionStart
        '
        Me.mnuActionStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.mnuActionStart, "mnuActionStart")
        Me.mnuActionStart.Name = "mnuActionStart"
        '
        'mnuActionBar0
        '
        Me.mnuActionBar0.Name = "mnuActionBar0"
        resources.ApplyResources(Me.mnuActionBar0, "mnuActionBar0")
        '
        'mnuActionPause
        '
        Me.mnuActionPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.mnuActionPause, "mnuActionPause")
        Me.mnuActionPause.Name = "mnuActionPause"
        '
        'mnuActionRestart
        '
        Me.mnuActionRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.mnuActionRestart, "mnuActionRestart")
        Me.mnuActionRestart.Name = "mnuActionRestart"
        '
        'mnuActionBar1
        '
        Me.mnuActionBar1.Name = "mnuActionBar1"
        resources.ApplyResources(Me.mnuActionBar1, "mnuActionBar1")
        '
        'mnuActionRemove
        '
        resources.ApplyResources(Me.mnuActionRemove, "mnuActionRemove")
        Me.mnuActionRemove.Name = "mnuActionRemove"
        '
        'mnuActionBar2
        '
        Me.mnuActionBar2.Name = "mnuActionBar2"
        resources.ApplyResources(Me.mnuActionBar2, "mnuActionBar2")
        '
        'mnuActionSettings
        '
        resources.ApplyResources(Me.mnuActionSettings, "mnuActionSettings")
        Me.mnuActionSettings.Name = "mnuActionSettings"
        '
        'mnuActionProperties
        '
        resources.ApplyResources(Me.mnuActionProperties, "mnuActionProperties")
        Me.mnuActionProperties.Name = "mnuActionProperties"
        '
        'mnuHelp
        '
        resources.ApplyResources(Me.mnuHelp, "mnuHelp")
        Me.mnuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpContents, Me.mnuHelpSearchForHelpOn, Me.mnuHelpBar0, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Padding = New System.Windows.Forms.Padding(0)
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuHelpContents.Name = "mnuHelpContents"
        Me.mnuHelpContents.Padding = New System.Windows.Forms.Padding(0)
        resources.ApplyResources(Me.mnuHelpContents, "mnuHelpContents")
        '
        'mnuHelpSearchForHelpOn
        '
        Me.mnuHelpSearchForHelpOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuHelpSearchForHelpOn.Name = "mnuHelpSearchForHelpOn"
        Me.mnuHelpSearchForHelpOn.Padding = New System.Windows.Forms.Padding(0)
        resources.ApplyResources(Me.mnuHelpSearchForHelpOn, "mnuHelpSearchForHelpOn")
        '
        'mnuHelpBar0
        '
        Me.mnuHelpBar0.Name = "mnuHelpBar0"
        resources.ApplyResources(Me.mnuHelpBar0, "mnuHelpBar0")
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        resources.ApplyResources(Me.mnuHelpAbout, "mnuHelpAbout")
        '
        'MainMenu1
        '
        Me.MainMenu1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MainMenu1.ImageScalingSize = New System.Drawing.Size(0, 0)
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAction, Me.mnuHelp})
        resources.ApplyResources(Me.MainMenu1, "MainMenu1")
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu1.Stretch = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.Start
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.NewMac)
        Me.Controls.Add(Me.VMGraphicList)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MainMenu1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.VMGraphicList.ResumeLayout(False)
        Me._VM_0.ResumeLayout(False)
        CType(Me._VMSnap_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMSnap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VirtualMacTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowVMC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IconNewDisk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IconOptions As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuNewMac As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuNewDisk As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFileBar0 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuFileOptions As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFileBar1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAction As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuActionStart As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuActionBar0 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuActionPause As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuActionRestart As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuActionBar1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuActionRemove As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuActionBar2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuActionSettings As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuActionProperties As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpContents As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpSearchForHelpOn As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpBar0 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IconNewMac As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBar2 As System.Windows.Forms.ToolStripSeparator
#End Region
End Class