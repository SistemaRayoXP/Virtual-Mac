<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
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
	Public WithEvents ProductNAV As System.Windows.Forms.Label
    Public WithEvents ArmandoTechnologiesCopyright As System.Windows.Forms.Label
    Public WithEvents LicenseInformation As System.Windows.Forms.Label
    Public WithEvents ThirdPartyNotice As System.Windows.Forms.Label
    Public WithEvents MvMCopyright As System.Windows.Forms.Label
    Public WithEvents AboutTab_AppInfo As System.Windows.Forms.TabPage
    Public WithEvents AboutTab_SysInfo As System.Windows.Forms.TabPage
    Public WithEvents AboutTab As System.Windows.Forms.TabControl
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AboutTab = New System.Windows.Forms.TabControl()
        Me.AboutTab_AppInfo = New System.Windows.Forms.TabPage()
        Me.LicenseInformation = New System.Windows.Forms.Label()
        Me.ProductNAV = New System.Windows.Forms.Label()
        Me.MvMCopyright = New System.Windows.Forms.Label()
        Me.ThirdPartyNotice = New System.Windows.Forms.Label()
        Me.ArmandoTechnologiesCopyright = New System.Windows.Forms.Label()
        Me.AppleCopyright = New System.Windows.Forms.Label()
        Me.ArmandoLink = New System.Windows.Forms.LinkLabel()
        Me.EmaculationLink = New System.Windows.Forms.LinkLabel()
        Me.AboutTab_SysInfo = New System.Windows.Forms.TabPage()
        Me.OSName = New System.Windows.Forms.Label()
        Me.CPUCoresLabel = New System.Windows.Forms.Label()
        Me.CPUType = New System.Windows.Forms.Label()
        Me.OSVersion = New System.Windows.Forms.Label()
        Me.SysInfoLabel = New System.Windows.Forms.Label()
        Me.CPUTypeLabel = New System.Windows.Forms.Label()
        Me.RAMInstalledLabel = New System.Windows.Forms.Label()
        Me.CPUCores = New System.Windows.Forms.Label()
        Me.OSNameLabel = New System.Windows.Forms.Label()
        Me.OSVersionLabel = New System.Windows.Forms.Label()
        Me.RAMInstalled = New System.Windows.Forms.Label()
        Me.RAMAvailableLabel = New System.Windows.Forms.Label()
        Me.RAMAvailable = New System.Windows.Forms.Label()
        Me.CurrUsr = New System.Windows.Forms.Label()
        Me.CurrUsrLabel = New System.Windows.Forms.Label()
        Me.UserInfoLabel = New System.Windows.Forms.Label()
        Me.PCName = New System.Windows.Forms.Label()
        Me.PCNameLabel = New System.Windows.Forms.Label()
        Me.AvailMemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AboutTab.SuspendLayout()
        Me.AboutTab_AppInfo.SuspendLayout()
        Me.AboutTab_SysInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'AboutTab
        '
        Me.AboutTab.Controls.Add(Me.AboutTab_AppInfo)
        Me.AboutTab.Controls.Add(Me.AboutTab_SysInfo)
        resources.ApplyResources(Me.AboutTab, "AboutTab")
        Me.AboutTab.Name = "AboutTab"
        Me.AboutTab.SelectedIndex = 0
        '
        'AboutTab_AppInfo
        '
        Me.AboutTab_AppInfo.BackgroundImage = Global.VirtualMac.My.Resources.Resources.About
        resources.ApplyResources(Me.AboutTab_AppInfo, "AboutTab_AppInfo")
        Me.AboutTab_AppInfo.Controls.Add(Me.LicenseInformation)
        Me.AboutTab_AppInfo.Controls.Add(Me.ProductNAV)
        Me.AboutTab_AppInfo.Controls.Add(Me.MvMCopyright)
        Me.AboutTab_AppInfo.Controls.Add(Me.ThirdPartyNotice)
        Me.AboutTab_AppInfo.Controls.Add(Me.ArmandoTechnologiesCopyright)
        Me.AboutTab_AppInfo.Controls.Add(Me.AppleCopyright)
        Me.AboutTab_AppInfo.Controls.Add(Me.ArmandoLink)
        Me.AboutTab_AppInfo.Controls.Add(Me.EmaculationLink)
        Me.AboutTab_AppInfo.Name = "AboutTab_AppInfo"
        '
        'LicenseInformation
        '
        Me.LicenseInformation.BackColor = System.Drawing.Color.Transparent
        Me.LicenseInformation.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.LicenseInformation, "LicenseInformation")
        Me.LicenseInformation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LicenseInformation.Name = "LicenseInformation"
        '
        'ProductNAV
        '
        Me.ProductNAV.BackColor = System.Drawing.Color.Transparent
        Me.ProductNAV.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.ProductNAV, "ProductNAV")
        Me.ProductNAV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProductNAV.Name = "ProductNAV"
        '
        'MvMCopyright
        '
        Me.MvMCopyright.BackColor = System.Drawing.Color.Transparent
        Me.MvMCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.MvMCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.MvMCopyright, "MvMCopyright")
        Me.MvMCopyright.Name = "MvMCopyright"
        '
        'ThirdPartyNotice
        '
        Me.ThirdPartyNotice.BackColor = System.Drawing.Color.Transparent
        Me.ThirdPartyNotice.Cursor = System.Windows.Forms.Cursors.Default
        Me.ThirdPartyNotice.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ThirdPartyNotice, "ThirdPartyNotice")
        Me.ThirdPartyNotice.Name = "ThirdPartyNotice"
        '
        'ArmandoTechnologiesCopyright
        '
        Me.ArmandoTechnologiesCopyright.BackColor = System.Drawing.Color.Transparent
        Me.ArmandoTechnologiesCopyright.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.ArmandoTechnologiesCopyright, "ArmandoTechnologiesCopyright")
        Me.ArmandoTechnologiesCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ArmandoTechnologiesCopyright.Name = "ArmandoTechnologiesCopyright"
        '
        'AppleCopyright
        '
        Me.AppleCopyright.BackColor = System.Drawing.Color.Transparent
        Me.AppleCopyright.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.AppleCopyright, "AppleCopyright")
        Me.AppleCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppleCopyright.Name = "AppleCopyright"
        '
        'ArmandoLink
        '
        resources.ApplyResources(Me.ArmandoLink, "ArmandoLink")
        Me.ArmandoLink.BackColor = System.Drawing.Color.Transparent
        Me.ArmandoLink.LinkColor = System.Drawing.Color.Blue
        Me.ArmandoLink.Name = "ArmandoLink"
        Me.ArmandoLink.TabStop = True
        '
        'EmaculationLink
        '
        resources.ApplyResources(Me.EmaculationLink, "EmaculationLink")
        Me.EmaculationLink.BackColor = System.Drawing.Color.Transparent
        Me.EmaculationLink.LinkColor = System.Drawing.Color.Blue
        Me.EmaculationLink.Name = "EmaculationLink"
        Me.EmaculationLink.TabStop = True
        '
        'AboutTab_SysInfo
        '
        Me.AboutTab_SysInfo.BackgroundImage = Global.VirtualMac.My.Resources.Resources.About
        resources.ApplyResources(Me.AboutTab_SysInfo, "AboutTab_SysInfo")
        Me.AboutTab_SysInfo.Controls.Add(Me.OSName)
        Me.AboutTab_SysInfo.Controls.Add(Me.CPUCoresLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.CPUType)
        Me.AboutTab_SysInfo.Controls.Add(Me.OSVersion)
        Me.AboutTab_SysInfo.Controls.Add(Me.SysInfoLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.CPUTypeLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.RAMInstalledLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.CPUCores)
        Me.AboutTab_SysInfo.Controls.Add(Me.OSNameLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.OSVersionLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.RAMInstalled)
        Me.AboutTab_SysInfo.Controls.Add(Me.RAMAvailableLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.RAMAvailable)
        Me.AboutTab_SysInfo.Controls.Add(Me.CurrUsr)
        Me.AboutTab_SysInfo.Controls.Add(Me.CurrUsrLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.UserInfoLabel)
        Me.AboutTab_SysInfo.Controls.Add(Me.PCName)
        Me.AboutTab_SysInfo.Controls.Add(Me.PCNameLabel)
        Me.AboutTab_SysInfo.Name = "AboutTab_SysInfo"
        Me.AboutTab_SysInfo.UseVisualStyleBackColor = True
        '
        'OSName
        '
        Me.OSName.BackColor = System.Drawing.Color.Transparent
        Me.OSName.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSName.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OSName, "OSName")
        Me.OSName.Name = "OSName"
        '
        'CPUCoresLabel
        '
        Me.CPUCoresLabel.BackColor = System.Drawing.Color.Transparent
        Me.CPUCoresLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUCoresLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CPUCoresLabel, "CPUCoresLabel")
        Me.CPUCoresLabel.Name = "CPUCoresLabel"
        '
        'CPUType
        '
        Me.CPUType.BackColor = System.Drawing.Color.Transparent
        Me.CPUType.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUType.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CPUType, "CPUType")
        Me.CPUType.Name = "CPUType"
        '
        'OSVersion
        '
        Me.OSVersion.BackColor = System.Drawing.Color.Transparent
        Me.OSVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSVersion.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OSVersion, "OSVersion")
        Me.OSVersion.Name = "OSVersion"
        '
        'SysInfoLabel
        '
        Me.SysInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.SysInfoLabel.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.SysInfoLabel, "SysInfoLabel")
        Me.SysInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SysInfoLabel.Name = "SysInfoLabel"
        '
        'CPUTypeLabel
        '
        Me.CPUTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.CPUTypeLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CPUTypeLabel, "CPUTypeLabel")
        Me.CPUTypeLabel.Name = "CPUTypeLabel"
        '
        'RAMInstalledLabel
        '
        Me.RAMInstalledLabel.BackColor = System.Drawing.Color.Transparent
        Me.RAMInstalledLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMInstalledLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMInstalledLabel, "RAMInstalledLabel")
        Me.RAMInstalledLabel.Name = "RAMInstalledLabel"
        '
        'CPUCores
        '
        Me.CPUCores.BackColor = System.Drawing.Color.Transparent
        Me.CPUCores.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUCores.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CPUCores, "CPUCores")
        Me.CPUCores.Name = "CPUCores"
        '
        'OSNameLabel
        '
        Me.OSNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.OSNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OSNameLabel, "OSNameLabel")
        Me.OSNameLabel.Name = "OSNameLabel"
        '
        'OSVersionLabel
        '
        Me.OSVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.OSVersionLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSVersionLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OSVersionLabel, "OSVersionLabel")
        Me.OSVersionLabel.Name = "OSVersionLabel"
        '
        'RAMInstalled
        '
        Me.RAMInstalled.BackColor = System.Drawing.Color.Transparent
        Me.RAMInstalled.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMInstalled.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMInstalled, "RAMInstalled")
        Me.RAMInstalled.Name = "RAMInstalled"
        '
        'RAMAvailableLabel
        '
        Me.RAMAvailableLabel.BackColor = System.Drawing.Color.Transparent
        Me.RAMAvailableLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMAvailableLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMAvailableLabel, "RAMAvailableLabel")
        Me.RAMAvailableLabel.Name = "RAMAvailableLabel"
        '
        'RAMAvailable
        '
        Me.RAMAvailable.BackColor = System.Drawing.Color.Transparent
        Me.RAMAvailable.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMAvailable.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.RAMAvailable, "RAMAvailable")
        Me.RAMAvailable.Name = "RAMAvailable"
        '
        'CurrUsr
        '
        Me.CurrUsr.BackColor = System.Drawing.Color.Transparent
        Me.CurrUsr.Cursor = System.Windows.Forms.Cursors.Default
        Me.CurrUsr.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CurrUsr, "CurrUsr")
        Me.CurrUsr.Name = "CurrUsr"
        '
        'CurrUsrLabel
        '
        Me.CurrUsrLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrUsrLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CurrUsrLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.CurrUsrLabel, "CurrUsrLabel")
        Me.CurrUsrLabel.Name = "CurrUsrLabel"
        '
        'UserInfoLabel
        '
        Me.UserInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserInfoLabel.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.UserInfoLabel, "UserInfoLabel")
        Me.UserInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserInfoLabel.Name = "UserInfoLabel"
        '
        'PCName
        '
        Me.PCName.BackColor = System.Drawing.Color.Transparent
        Me.PCName.Cursor = System.Windows.Forms.Cursors.Default
        Me.PCName.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.PCName, "PCName")
        Me.PCName.Name = "PCName"
        '
        'PCNameLabel
        '
        Me.PCNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.PCNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PCNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.PCNameLabel, "PCNameLabel")
        Me.PCNameLabel.Name = "PCNameLabel"
        '
        'AvailMemTimer
        '
        Me.AvailMemTimer.Enabled = True
        '
        'frmAbout
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.AboutTab)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.Tag = "1025"
        Me.AboutTab.ResumeLayout(False)
        Me.AboutTab_AppInfo.ResumeLayout(False)
        Me.AboutTab_AppInfo.PerformLayout()
        Me.AboutTab_SysInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents AppleCopyright As System.Windows.Forms.Label
    Friend WithEvents ArmandoLink As System.Windows.Forms.LinkLabel
    Friend WithEvents EmaculationLink As System.Windows.Forms.LinkLabel
    Public WithEvents PCNameLabel As System.Windows.Forms.Label
    Public WithEvents PCName As System.Windows.Forms.Label
    Public WithEvents UserInfoLabel As System.Windows.Forms.Label
    Public WithEvents CurrUsrLabel As System.Windows.Forms.Label
    Public WithEvents CurrUsr As System.Windows.Forms.Label
    Public WithEvents RAMAvailable As System.Windows.Forms.Label
    Public WithEvents RAMAvailableLabel As System.Windows.Forms.Label
    Public WithEvents RAMInstalled As System.Windows.Forms.Label
    Public WithEvents RAMInstalledLabel As System.Windows.Forms.Label
    Public WithEvents CPUTypeLabel As System.Windows.Forms.Label
    Public WithEvents CPUType As System.Windows.Forms.Label
    Public WithEvents CPUCores As System.Windows.Forms.Label
    Public WithEvents CPUCoresLabel As System.Windows.Forms.Label
    Public WithEvents SysInfoLabel As System.Windows.Forms.Label
    Public WithEvents OSNameLabel As System.Windows.Forms.Label
    Public WithEvents OSName As System.Windows.Forms.Label
    Public WithEvents OSVersion As System.Windows.Forms.Label
    Public WithEvents OSVersionLabel As System.Windows.Forms.Label
    Friend WithEvents AvailMemTimer As System.Windows.Forms.Timer
#End Region
End Class