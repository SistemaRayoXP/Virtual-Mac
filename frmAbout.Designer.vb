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
    Public WithEvents _AboutTab_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents _AboutTab_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents AboutTab As System.Windows.Forms.TabControl
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AboutTab = New System.Windows.Forms.TabControl
        Me._AboutTab_TabPage0 = New System.Windows.Forms.TabPage
        Me.LicenseInformation = New System.Windows.Forms.Label
        Me.ProductNAV = New System.Windows.Forms.Label
        Me.MvMCopyright = New System.Windows.Forms.Label
        Me.ThirdPartyNotice = New System.Windows.Forms.Label
        Me.ArmandoTechnologiesCopyright = New System.Windows.Forms.Label
        Me.AppleCopyright = New System.Windows.Forms.Label
        Me.ArmandoLink = New System.Windows.Forms.LinkLabel
        Me.EmaculationLink = New System.Windows.Forms.LinkLabel
        Me._AboutTab_TabPage1 = New System.Windows.Forms.TabPage
        Me.OSName = New System.Windows.Forms.Label
        Me.CPUCoresLabel = New System.Windows.Forms.Label
        Me.CPUType = New System.Windows.Forms.Label
        Me.OSVersion = New System.Windows.Forms.Label
        Me.SysInfoLabel = New System.Windows.Forms.Label
        Me.CPUTypeLabel = New System.Windows.Forms.Label
        Me.RAMInstalledLabel = New System.Windows.Forms.Label
        Me.CPUCores = New System.Windows.Forms.Label
        Me.OSNameLabel = New System.Windows.Forms.Label
        Me.OSVersionLabel = New System.Windows.Forms.Label
        Me.RAMInstalled = New System.Windows.Forms.Label
        Me.RAMAvailableLabel = New System.Windows.Forms.Label
        Me.RAMAvailable = New System.Windows.Forms.Label
        Me.CurrUsr = New System.Windows.Forms.Label
        Me.CurrUsrLabel = New System.Windows.Forms.Label
        Me.UserInfoLabel = New System.Windows.Forms.Label
        Me.PCName = New System.Windows.Forms.Label
        Me.PCNameLabel = New System.Windows.Forms.Label
        Me.AvailMemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AboutTab.SuspendLayout()
        Me._AboutTab_TabPage0.SuspendLayout()
        Me._AboutTab_TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AboutTab
        '
        Me.AboutTab.Controls.Add(Me._AboutTab_TabPage0)
        Me.AboutTab.Controls.Add(Me._AboutTab_TabPage1)
        Me.AboutTab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutTab.ItemSize = New System.Drawing.Size(42, 18)
        Me.AboutTab.Location = New System.Drawing.Point(8, 8)
        Me.AboutTab.Name = "AboutTab"
        Me.AboutTab.SelectedIndex = 0
        Me.AboutTab.Size = New System.Drawing.Size(497, 321)
        Me.AboutTab.TabIndex = 0
        '
        '_AboutTab_TabPage0
        '
        Me._AboutTab_TabPage0.BackgroundImage = Global.VirtualMac.My.Resources.Resources.About
        Me._AboutTab_TabPage0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._AboutTab_TabPage0.Controls.Add(Me.LicenseInformation)
        Me._AboutTab_TabPage0.Controls.Add(Me.ProductNAV)
        Me._AboutTab_TabPage0.Controls.Add(Me.MvMCopyright)
        Me._AboutTab_TabPage0.Controls.Add(Me.ThirdPartyNotice)
        Me._AboutTab_TabPage0.Controls.Add(Me.ArmandoTechnologiesCopyright)
        Me._AboutTab_TabPage0.Controls.Add(Me.AppleCopyright)
        Me._AboutTab_TabPage0.Controls.Add(Me.ArmandoLink)
        Me._AboutTab_TabPage0.Controls.Add(Me.EmaculationLink)
        Me._AboutTab_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._AboutTab_TabPage0.Name = "_AboutTab_TabPage0"
        Me._AboutTab_TabPage0.Size = New System.Drawing.Size(489, 295)
        Me._AboutTab_TabPage0.TabIndex = 0
        Me._AboutTab_TabPage0.Text = "About Virtual Mac"
        '
        'LicenseInformation
        '
        Me.LicenseInformation.BackColor = System.Drawing.Color.Transparent
        Me.LicenseInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.LicenseInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseInformation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LicenseInformation.Location = New System.Drawing.Point(24, 136)
        Me.LicenseInformation.Name = "LicenseInformation"
        Me.LicenseInformation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LicenseInformation.Size = New System.Drawing.Size(449, 17)
        Me.LicenseInformation.TabIndex = 5
        Me.LicenseInformation.Text = "Licensed under GNU GPL v3"
        '
        'ProductNAV
        '
        Me.ProductNAV.BackColor = System.Drawing.Color.Transparent
        Me.ProductNAV.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProductNAV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNAV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProductNAV.Location = New System.Drawing.Point(24, 88)
        Me.ProductNAV.Name = "ProductNAV"
        Me.ProductNAV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProductNAV.Size = New System.Drawing.Size(449, 17)
        Me.ProductNAV.TabIndex = 7
        Me.ProductNAV.Text = "TEA's Virtual Mac"
        '
        'MvMCopyright
        '
        Me.MvMCopyright.BackColor = System.Drawing.Color.Transparent
        Me.MvMCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.MvMCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MvMCopyright.Location = New System.Drawing.Point(24, 219)
        Me.MvMCopyright.Name = "MvMCopyright"
        Me.MvMCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MvMCopyright.Size = New System.Drawing.Size(449, 17)
        Me.MvMCopyright.TabIndex = 2
        Me.MvMCopyright.Text = "Mini vMac © 2001-2018 The Gryphel Project"
        '
        'ThirdPartyNotice
        '
        Me.ThirdPartyNotice.BackColor = System.Drawing.Color.Transparent
        Me.ThirdPartyNotice.Cursor = System.Windows.Forms.Cursors.Default
        Me.ThirdPartyNotice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ThirdPartyNotice.Location = New System.Drawing.Point(24, 202)
        Me.ThirdPartyNotice.Name = "ThirdPartyNotice"
        Me.ThirdPartyNotice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirdPartyNotice.Size = New System.Drawing.Size(449, 17)
        Me.ThirdPartyNotice.TabIndex = 3
        Me.ThirdPartyNotice.Text = "Portions of this Software:"
        '
        'ArmandoTechnologiesCopyright
        '
        Me.ArmandoTechnologiesCopyright.BackColor = System.Drawing.Color.Transparent
        Me.ArmandoTechnologiesCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.ArmandoTechnologiesCopyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArmandoTechnologiesCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ArmandoTechnologiesCopyright.Location = New System.Drawing.Point(24, 102)
        Me.ArmandoTechnologiesCopyright.Name = "ArmandoTechnologiesCopyright"
        Me.ArmandoTechnologiesCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ArmandoTechnologiesCopyright.Size = New System.Drawing.Size(449, 17)
        Me.ArmandoTechnologiesCopyright.TabIndex = 6
        Me.ArmandoTechnologiesCopyright.Text = "Copyright © 2017-2018 Tecnologias Edson Armando"
        '
        'AppleCopyright
        '
        Me.AppleCopyright.BackColor = System.Drawing.Color.Transparent
        Me.AppleCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.AppleCopyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppleCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppleCopyright.Location = New System.Drawing.Point(24, 119)
        Me.AppleCopyright.Name = "AppleCopyright"
        Me.AppleCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AppleCopyright.Size = New System.Drawing.Size(449, 17)
        Me.AppleCopyright.TabIndex = 8
        Me.AppleCopyright.Text = "Copyright © 1984-2001 Apple Computer"
        '
        'ArmandoLink
        '
        Me.ArmandoLink.AutoSize = True
        Me.ArmandoLink.BackColor = System.Drawing.Color.Transparent
        Me.ArmandoLink.LinkColor = System.Drawing.Color.Blue
        Me.ArmandoLink.Location = New System.Drawing.Point(24, 162)
        Me.ArmandoLink.Name = "ArmandoLink"
        Me.ArmandoLink.Size = New System.Drawing.Size(141, 13)
        Me.ArmandoLink.TabIndex = 9
        Me.ArmandoLink.TabStop = True
        Me.ArmandoLink.Text = "Tecnologias Edson Armando"
        '
        'EmaculationLink
        '
        Me.EmaculationLink.AutoSize = True
        Me.EmaculationLink.BackColor = System.Drawing.Color.Transparent
        Me.EmaculationLink.LinkColor = System.Drawing.Color.Blue
        Me.EmaculationLink.Location = New System.Drawing.Point(24, 175)
        Me.EmaculationLink.Name = "EmaculationLink"
        Me.EmaculationLink.Size = New System.Drawing.Size(91, 13)
        Me.EmaculationLink.TabIndex = 10
        Me.EmaculationLink.TabStop = True
        Me.EmaculationLink.Text = "E-Maculation.com"
        '
        '_AboutTab_TabPage1
        '
        Me._AboutTab_TabPage1.BackgroundImage = Global.VirtualMac.My.Resources.Resources.About
        Me._AboutTab_TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me._AboutTab_TabPage1.Controls.Add(Me.OSName)
        Me._AboutTab_TabPage1.Controls.Add(Me.CPUCoresLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.CPUType)
        Me._AboutTab_TabPage1.Controls.Add(Me.OSVersion)
        Me._AboutTab_TabPage1.Controls.Add(Me.SysInfoLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.CPUTypeLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.RAMInstalledLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.CPUCores)
        Me._AboutTab_TabPage1.Controls.Add(Me.OSNameLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.OSVersionLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.RAMInstalled)
        Me._AboutTab_TabPage1.Controls.Add(Me.RAMAvailableLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.RAMAvailable)
        Me._AboutTab_TabPage1.Controls.Add(Me.CurrUsr)
        Me._AboutTab_TabPage1.Controls.Add(Me.CurrUsrLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.UserInfoLabel)
        Me._AboutTab_TabPage1.Controls.Add(Me.PCName)
        Me._AboutTab_TabPage1.Controls.Add(Me.PCNameLabel)
        Me._AboutTab_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._AboutTab_TabPage1.Name = "_AboutTab_TabPage1"
        Me._AboutTab_TabPage1.Size = New System.Drawing.Size(489, 295)
        Me._AboutTab_TabPage1.TabIndex = 1
        Me._AboutTab_TabPage1.Text = "System Information"
        Me._AboutTab_TabPage1.UseVisualStyleBackColor = True
        '
        'OSName
        '
        Me.OSName.BackColor = System.Drawing.Color.Transparent
        Me.OSName.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSName.Location = New System.Drawing.Point(196, 103)
        Me.OSName.Name = "OSName"
        Me.OSName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSName.Size = New System.Drawing.Size(275, 17)
        Me.OSName.TabIndex = 11
        '
        'CPUCoresLabel
        '
        Me.CPUCoresLabel.BackColor = System.Drawing.Color.Transparent
        Me.CPUCoresLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUCoresLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CPUCoresLabel.Location = New System.Drawing.Point(32, 154)
        Me.CPUCoresLabel.Name = "CPUCoresLabel"
        Me.CPUCoresLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPUCoresLabel.Size = New System.Drawing.Size(137, 17)
        Me.CPUCoresLabel.TabIndex = 14
        Me.CPUCoresLabel.Text = "Processor cores:"
        '
        'CPUType
        '
        Me.CPUType.BackColor = System.Drawing.Color.Transparent
        Me.CPUType.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CPUType.Location = New System.Drawing.Point(196, 137)
        Me.CPUType.Name = "CPUType"
        Me.CPUType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPUType.Size = New System.Drawing.Size(275, 17)
        Me.CPUType.TabIndex = 16
        '
        'OSVersion
        '
        Me.OSVersion.BackColor = System.Drawing.Color.Transparent
        Me.OSVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSVersion.Location = New System.Drawing.Point(196, 120)
        Me.OSVersion.Name = "OSVersion"
        Me.OSVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSVersion.Size = New System.Drawing.Size(275, 17)
        Me.OSVersion.TabIndex = 10
        '
        'SysInfoLabel
        '
        Me.SysInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.SysInfoLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.SysInfoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SysInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SysInfoLabel.Location = New System.Drawing.Point(24, 87)
        Me.SysInfoLabel.Name = "SysInfoLabel"
        Me.SysInfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SysInfoLabel.Size = New System.Drawing.Size(121, 17)
        Me.SysInfoLabel.TabIndex = 13
        Me.SysInfoLabel.Text = "System Information"
        '
        'CPUTypeLabel
        '
        Me.CPUTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.CPUTypeLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CPUTypeLabel.Location = New System.Drawing.Point(32, 137)
        Me.CPUTypeLabel.Name = "CPUTypeLabel"
        Me.CPUTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPUTypeLabel.Size = New System.Drawing.Size(137, 17)
        Me.CPUTypeLabel.TabIndex = 17
        Me.CPUTypeLabel.Text = "Processor type:"
        '
        'RAMInstalledLabel
        '
        Me.RAMInstalledLabel.BackColor = System.Drawing.Color.Transparent
        Me.RAMInstalledLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMInstalledLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAMInstalledLabel.Location = New System.Drawing.Point(32, 171)
        Me.RAMInstalledLabel.Name = "RAMInstalledLabel"
        Me.RAMInstalledLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RAMInstalledLabel.Size = New System.Drawing.Size(137, 17)
        Me.RAMInstalledLabel.TabIndex = 18
        Me.RAMInstalledLabel.Text = "Total physical memory:"
        '
        'CPUCores
        '
        Me.CPUCores.BackColor = System.Drawing.Color.Transparent
        Me.CPUCores.Cursor = System.Windows.Forms.Cursors.Default
        Me.CPUCores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CPUCores.Location = New System.Drawing.Point(196, 154)
        Me.CPUCores.Name = "CPUCores"
        Me.CPUCores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPUCores.Size = New System.Drawing.Size(275, 17)
        Me.CPUCores.TabIndex = 15
        '
        'OSNameLabel
        '
        Me.OSNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.OSNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSNameLabel.Location = New System.Drawing.Point(32, 103)
        Me.OSNameLabel.Name = "OSNameLabel"
        Me.OSNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSNameLabel.Size = New System.Drawing.Size(137, 17)
        Me.OSNameLabel.TabIndex = 12
        Me.OSNameLabel.Text = "Operating System:"
        '
        'OSVersionLabel
        '
        Me.OSVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.OSVersionLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSVersionLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSVersionLabel.Location = New System.Drawing.Point(32, 120)
        Me.OSVersionLabel.Name = "OSVersionLabel"
        Me.OSVersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSVersionLabel.Size = New System.Drawing.Size(137, 17)
        Me.OSVersionLabel.TabIndex = 9
        Me.OSVersionLabel.Text = "System Version:"
        '
        'RAMInstalled
        '
        Me.RAMInstalled.BackColor = System.Drawing.Color.Transparent
        Me.RAMInstalled.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMInstalled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAMInstalled.Location = New System.Drawing.Point(196, 171)
        Me.RAMInstalled.Name = "RAMInstalled"
        Me.RAMInstalled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RAMInstalled.Size = New System.Drawing.Size(275, 17)
        Me.RAMInstalled.TabIndex = 19
        '
        'RAMAvailableLabel
        '
        Me.RAMAvailableLabel.BackColor = System.Drawing.Color.Transparent
        Me.RAMAvailableLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMAvailableLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAMAvailableLabel.Location = New System.Drawing.Point(32, 188)
        Me.RAMAvailableLabel.Name = "RAMAvailableLabel"
        Me.RAMAvailableLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RAMAvailableLabel.Size = New System.Drawing.Size(137, 17)
        Me.RAMAvailableLabel.TabIndex = 20
        Me.RAMAvailableLabel.Text = "Available physical memory:"
        '
        'RAMAvailable
        '
        Me.RAMAvailable.BackColor = System.Drawing.Color.Transparent
        Me.RAMAvailable.Cursor = System.Windows.Forms.Cursors.Default
        Me.RAMAvailable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAMAvailable.Location = New System.Drawing.Point(196, 188)
        Me.RAMAvailable.Name = "RAMAvailable"
        Me.RAMAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RAMAvailable.Size = New System.Drawing.Size(275, 17)
        Me.RAMAvailable.TabIndex = 21
        '
        'CurrUsr
        '
        Me.CurrUsr.BackColor = System.Drawing.Color.Transparent
        Me.CurrUsr.Cursor = System.Windows.Forms.Cursors.Default
        Me.CurrUsr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrUsr.Location = New System.Drawing.Point(196, 223)
        Me.CurrUsr.Name = "CurrUsr"
        Me.CurrUsr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurrUsr.Size = New System.Drawing.Size(275, 17)
        Me.CurrUsr.TabIndex = 22
        '
        'CurrUsrLabel
        '
        Me.CurrUsrLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrUsrLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.CurrUsrLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrUsrLabel.Location = New System.Drawing.Point(32, 223)
        Me.CurrUsrLabel.Name = "CurrUsrLabel"
        Me.CurrUsrLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurrUsrLabel.Size = New System.Drawing.Size(137, 17)
        Me.CurrUsrLabel.TabIndex = 23
        Me.CurrUsrLabel.Text = "Current user name:"
        '
        'UserInfoLabel
        '
        Me.UserInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserInfoLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UserInfoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserInfoLabel.Location = New System.Drawing.Point(24, 208)
        Me.UserInfoLabel.Name = "UserInfoLabel"
        Me.UserInfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserInfoLabel.Size = New System.Drawing.Size(121, 17)
        Me.UserInfoLabel.TabIndex = 24
        Me.UserInfoLabel.Text = "User Information"
        '
        'PCName
        '
        Me.PCName.BackColor = System.Drawing.Color.Transparent
        Me.PCName.Cursor = System.Windows.Forms.Cursors.Default
        Me.PCName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PCName.Location = New System.Drawing.Point(196, 240)
        Me.PCName.Name = "PCName"
        Me.PCName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PCName.Size = New System.Drawing.Size(275, 17)
        Me.PCName.TabIndex = 25
        '
        'PCNameLabel
        '
        Me.PCNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.PCNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PCNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PCNameLabel.Location = New System.Drawing.Point(32, 240)
        Me.PCNameLabel.Name = "PCNameLabel"
        Me.PCNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PCNameLabel.Size = New System.Drawing.Size(137, 17)
        Me.PCNameLabel.TabIndex = 26
        Me.PCNameLabel.Text = "Computer name:"
        '
        'AvailMemTimer
        '
        Me.AvailMemTimer.Enabled = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(508, 335)
        Me.Controls.Add(Me.AboutTab)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "1025"
        Me.Text = "About VirtualMac"
        Me.AboutTab.ResumeLayout(False)
        Me._AboutTab_TabPage0.ResumeLayout(False)
        Me._AboutTab_TabPage0.PerformLayout()
        Me._AboutTab_TabPage1.ResumeLayout(False)
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