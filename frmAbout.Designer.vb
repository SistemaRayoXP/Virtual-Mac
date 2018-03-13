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
    Public WithEvents WebSite As System.Windows.Forms.Label
    Public WithEvents ThirdPartyNotice As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents AboutPicture As System.Windows.Forms.Panel
    Public WithEvents _AboutTab_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents TitleSys As System.Windows.Forms.Label
    Public WithEvents OSNameTitle As System.Windows.Forms.Label
    Public WithEvents OSName As System.Windows.Forms.Label
    Public WithEvents OSVersion As System.Windows.Forms.Label
    Public WithEvents OSVersionTitle As System.Windows.Forms.Label
    Public WithEvents SysInfoPicture As System.Windows.Forms.Panel
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
        Me.AboutPicture = New System.Windows.Forms.Panel
        Me.ProductNAV = New System.Windows.Forms.Label
        Me.ArmandoTechnologiesCopyright = New System.Windows.Forms.Label
        Me.LicenseInformation = New System.Windows.Forms.Label
        Me.WebSite = New System.Windows.Forms.Label
        Me.ThirdPartyNotice = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me._AboutTab_TabPage1 = New System.Windows.Forms.TabPage
        Me.SysInfoPicture = New System.Windows.Forms.Panel
        Me.TitleSys = New System.Windows.Forms.Label
        Me.OSNameTitle = New System.Windows.Forms.Label
        Me.OSName = New System.Windows.Forms.Label
        Me.OSVersion = New System.Windows.Forms.Label
        Me.OSVersionTitle = New System.Windows.Forms.Label
        Me.AppleCopyright = New System.Windows.Forms.Label
        Me.AboutTab.SuspendLayout()
        Me._AboutTab_TabPage0.SuspendLayout()
        Me.AboutPicture.SuspendLayout()
        Me._AboutTab_TabPage1.SuspendLayout()
        Me.SysInfoPicture.SuspendLayout()
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
        Me._AboutTab_TabPage0.Controls.Add(Me.AboutPicture)
        Me._AboutTab_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._AboutTab_TabPage0.Name = "_AboutTab_TabPage0"
        Me._AboutTab_TabPage0.Size = New System.Drawing.Size(489, 295)
        Me._AboutTab_TabPage0.TabIndex = 0
        Me._AboutTab_TabPage0.Text = "About"
        '
        'AboutPicture
        '
        Me.AboutPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AboutPicture.BackColor = System.Drawing.SystemColors.Control
        Me.AboutPicture.BackgroundImage = Global.VirtualMac.My.Resources.Resources.About
        Me.AboutPicture.Controls.Add(Me.AppleCopyright)
        Me.AboutPicture.Controls.Add(Me.ProductNAV)
        Me.AboutPicture.Controls.Add(Me.ArmandoTechnologiesCopyright)
        Me.AboutPicture.Controls.Add(Me.LicenseInformation)
        Me.AboutPicture.Controls.Add(Me.WebSite)
        Me.AboutPicture.Controls.Add(Me.ThirdPartyNotice)
        Me.AboutPicture.Controls.Add(Me.Label2)
        Me.AboutPicture.Cursor = System.Windows.Forms.Cursors.Default
        Me.AboutPicture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AboutPicture.Location = New System.Drawing.Point(0, 0)
        Me.AboutPicture.Name = "AboutPicture"
        Me.AboutPicture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AboutPicture.Size = New System.Drawing.Size(494, 295)
        Me.AboutPicture.TabIndex = 1
        Me.AboutPicture.TabStop = True
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
        Me.ProductNAV.Text = "Virtual Mac Technologies 0.2.2 Beta"
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
        Me.ArmandoTechnologiesCopyright.Text = "Copyright © 2018 Armando Technologies"
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
        Me.LicenseInformation.Text = "Creative Commons v2"
        '
        'WebSite
        '
        Me.WebSite.BackColor = System.Drawing.Color.Transparent
        Me.WebSite.Cursor = System.Windows.Forms.Cursors.Default
        Me.WebSite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WebSite.Location = New System.Drawing.Point(24, 162)
        Me.WebSite.Name = "WebSite"
        Me.WebSite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WebSite.Size = New System.Drawing.Size(449, 17)
        Me.WebSite.TabIndex = 4
        Me.WebSite.Text = "www.emaculation.com"
        '
        'ThirdPartyNotice
        '
        Me.ThirdPartyNotice.BackColor = System.Drawing.Color.Transparent
        Me.ThirdPartyNotice.Cursor = System.Windows.Forms.Cursors.Default
        Me.ThirdPartyNotice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ThirdPartyNotice.Location = New System.Drawing.Point(24, 189)
        Me.ThirdPartyNotice.Name = "ThirdPartyNotice"
        Me.ThirdPartyNotice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirdPartyNotice.Size = New System.Drawing.Size(449, 17)
        Me.ThirdPartyNotice.TabIndex = 3
        Me.ThirdPartyNotice.Text = "Portions of this Software:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(449, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mini vMac © 2001-2018 The Gryphel Project"
        '
        '_AboutTab_TabPage1
        '
        Me._AboutTab_TabPage1.Controls.Add(Me.SysInfoPicture)
        Me._AboutTab_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._AboutTab_TabPage1.Name = "_AboutTab_TabPage1"
        Me._AboutTab_TabPage1.Size = New System.Drawing.Size(489, 295)
        Me._AboutTab_TabPage1.TabIndex = 1
        Me._AboutTab_TabPage1.Text = "Information"
        '
        'SysInfoPicture
        '
        Me.SysInfoPicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SysInfoPicture.BackColor = System.Drawing.SystemColors.Control
        Me.SysInfoPicture.BackgroundImage = Global.VirtualMac.My.Resources.Resources.About
        Me.SysInfoPicture.Controls.Add(Me.TitleSys)
        Me.SysInfoPicture.Controls.Add(Me.OSNameTitle)
        Me.SysInfoPicture.Controls.Add(Me.OSName)
        Me.SysInfoPicture.Controls.Add(Me.OSVersion)
        Me.SysInfoPicture.Controls.Add(Me.OSVersionTitle)
        Me.SysInfoPicture.Cursor = System.Windows.Forms.Cursors.Default
        Me.SysInfoPicture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SysInfoPicture.Location = New System.Drawing.Point(0, 0)
        Me.SysInfoPicture.Name = "SysInfoPicture"
        Me.SysInfoPicture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SysInfoPicture.Size = New System.Drawing.Size(494, 295)
        Me.SysInfoPicture.TabIndex = 8
        Me.SysInfoPicture.TabStop = True
        '
        'TitleSys
        '
        Me.TitleSys.BackColor = System.Drawing.Color.Transparent
        Me.TitleSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.TitleSys.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleSys.Location = New System.Drawing.Point(24, 88)
        Me.TitleSys.Name = "TitleSys"
        Me.TitleSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TitleSys.Size = New System.Drawing.Size(121, 17)
        Me.TitleSys.TabIndex = 13
        Me.TitleSys.Text = "System Information"
        '
        'OSNameTitle
        '
        Me.OSNameTitle.BackColor = System.Drawing.Color.Transparent
        Me.OSNameTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSNameTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSNameTitle.Location = New System.Drawing.Point(32, 102)
        Me.OSNameTitle.Name = "OSNameTitle"
        Me.OSNameTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSNameTitle.Size = New System.Drawing.Size(121, 17)
        Me.OSNameTitle.TabIndex = 12
        Me.OSNameTitle.Text = "Operating System:"
        '
        'OSName
        '
        Me.OSName.BackColor = System.Drawing.Color.Transparent
        Me.OSName.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSName.Location = New System.Drawing.Point(232, 102)
        Me.OSName.Name = "OSName"
        Me.OSName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSName.Size = New System.Drawing.Size(241, 17)
        Me.OSName.TabIndex = 11
        Me.OSName.Text = "Windows 9000"
        '
        'OSVersion
        '
        Me.OSVersion.BackColor = System.Drawing.Color.Transparent
        Me.OSVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSVersion.Location = New System.Drawing.Point(232, 118)
        Me.OSVersion.Name = "OSVersion"
        Me.OSVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSVersion.Size = New System.Drawing.Size(241, 17)
        Me.OSVersion.TabIndex = 10
        Me.OSVersion.Text = "90.5.4800"
        '
        'OSVersionTitle
        '
        Me.OSVersionTitle.BackColor = System.Drawing.Color.Transparent
        Me.OSVersionTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.OSVersionTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OSVersionTitle.Location = New System.Drawing.Point(32, 118)
        Me.OSVersionTitle.Name = "OSVersionTitle"
        Me.OSVersionTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OSVersionTitle.Size = New System.Drawing.Size(121, 17)
        Me.OSVersionTitle.TabIndex = 9
        Me.OSVersionTitle.Text = "System Version:"
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
        Me.AppleCopyright.Text = "Copyright © 1997 Apple Computer"
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
        Me.AboutPicture.ResumeLayout(False)
        Me._AboutTab_TabPage1.ResumeLayout(False)
        Me.SysInfoPicture.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents AppleCopyright As System.Windows.Forms.Label
#End Region
End Class