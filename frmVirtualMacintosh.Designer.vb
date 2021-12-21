<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVirtualMacintosh
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
    Public FloppyBrowser As System.Windows.Forms.OpenFileDialog
    Public WithEvents VMScreen As System.Windows.Forms.PictureBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVirtualMacintosh))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FloppyBrowser = New System.Windows.Forms.OpenFileDialog
        Me.VMScreen = New System.Windows.Forms.PictureBox
        Me.VMStatusBar = New System.Windows.Forms.StatusStrip
        Me.CDBrowser = New System.Windows.Forms.OpenFileDialog
        Me.MainMenu2 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuAction = New System.Windows.Forms.MenuItem
        Me.mnuActionFullScreen = New System.Windows.Forms.MenuItem
        Me.mnuActionBar0 = New System.Windows.Forms.MenuItem
        Me.mnuActionClose = New System.Windows.Forms.MenuItem
        Me.mnuCD = New System.Windows.Forms.MenuItem
        Me.mnuCDCapture = New System.Windows.Forms.MenuItem
        Me.mnuCDBar0 = New System.Windows.Forms.MenuItem
        Me.mnuCDRelease = New System.Windows.Forms.MenuItem
        Me.mnuFloppy = New System.Windows.Forms.MenuItem
        Me.mnuFloppyCapture = New System.Windows.Forms.MenuItem
        Me.mnuFloppyBar0 = New System.Windows.Forms.MenuItem
        Me.mnuFloppyRelease = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpContents = New System.Windows.Forms.MenuItem
        Me.mnuHelpBar0 = New System.Windows.Forms.MenuItem
        Me.mnuHelpOnline = New System.Windows.Forms.MenuItem
        Me.mnuHelpBar1 = New System.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
        CType(Me.VMScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FloppyBrowser
        '
        Me.FloppyBrowser.Filter = "Floppy Images (*.img;*.ima)|*.img;*.ima|All files (*.*)|*.*"
        '
        'VMScreen
        '
        Me.VMScreen.BackColor = System.Drawing.SystemColors.Control
        Me.VMScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VMScreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMScreen.Image = CType(resources.GetObject("VMScreen.Image"), System.Drawing.Image)
        Me.VMScreen.Location = New System.Drawing.Point(0, -5)
        Me.VMScreen.Name = "VMScreen"
        Me.VMScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VMScreen.Size = New System.Drawing.Size(803, 605)
        Me.VMScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.VMScreen.TabIndex = 0
        Me.VMScreen.TabStop = False
        '
        'VMStatusBar
        '
        Me.VMStatusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VMStatusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.VMStatusBar.Location = New System.Drawing.Point(0, 599)
        Me.VMStatusBar.Name = "VMStatusBar"
        Me.VMStatusBar.Size = New System.Drawing.Size(803, 22)
        Me.VMStatusBar.TabIndex = 3
        Me.VMStatusBar.Text = "StatusStrip1"
        '
        'CDBrowser
        '
        Me.CDBrowser.Filter = "Disc Images (*.iso)|*.iso|All files (*.*)|*.*"
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAction, Me.mnuCD, Me.mnuFloppy, Me.mnuHelp})
        '
        'mnuAction
        '
        Me.mnuAction.Index = 0
        Me.mnuAction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuActionFullScreen, Me.mnuActionBar0, Me.mnuActionClose})
        Me.mnuAction.Text = "Action"
        '
        'mnuActionFullScreen
        '
        Me.mnuActionFullScreen.Index = 0
        Me.mnuActionFullScreen.Text = "Full screen mode"
        '
        'mnuActionBar0
        '
        Me.mnuActionBar0.Index = 1
        Me.mnuActionBar0.Text = "-"
        '
        'mnuActionClose
        '
        Me.mnuActionClose.Index = 2
        Me.mnuActionClose.Text = "Close"
        '
        'mnuCD
        '
        Me.mnuCD.Index = 1
        Me.mnuCD.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCDCapture, Me.mnuCDBar0, Me.mnuCDRelease})
        Me.mnuCD.Text = "CD"
        '
        'mnuCDCapture
        '
        Me.mnuCDCapture.Index = 0
        Me.mnuCDCapture.Text = "Capture ISO image..."
        '
        'mnuCDBar0
        '
        Me.mnuCDBar0.Index = 1
        Me.mnuCDBar0.Text = "-"
        '
        'mnuCDRelease
        '
        Me.mnuCDRelease.Index = 2
        Me.mnuCDRelease.Text = "Release CD"
        '
        'mnuFloppy
        '
        Me.mnuFloppy.Index = 2
        Me.mnuFloppy.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFloppyCapture, Me.mnuFloppyBar0, Me.mnuFloppyRelease})
        Me.mnuFloppy.Text = "Floppy"
        '
        'mnuFloppyCapture
        '
        Me.mnuFloppyCapture.Index = 0
        Me.mnuFloppyCapture.Text = "Capture floppy disk image..."
        '
        'mnuFloppyBar0
        '
        Me.mnuFloppyBar0.Index = 1
        Me.mnuFloppyBar0.Text = "-"
        '
        'mnuFloppyRelease
        '
        Me.mnuFloppyRelease.Index = 2
        Me.mnuFloppyRelease.Text = "Release disk"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 3
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContents, Me.mnuHelpBar0, Me.mnuHelpOnline, Me.mnuHelpBar1, Me.mnuHelpAbout})
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Index = 0
        Me.mnuHelpContents.Text = "Virtual Mac Help"
        '
        'mnuHelpBar0
        '
        Me.mnuHelpBar0.Index = 1
        Me.mnuHelpBar0.Text = "-"
        '
        'mnuHelpOnline
        '
        Me.mnuHelpOnline.Index = 2
        Me.mnuHelpOnline.Text = "Virtual Mac Online"
        '
        'mnuHelpBar1
        '
        Me.mnuHelpBar1.Index = 3
        Me.mnuHelpBar1.Text = "-"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 4
        Me.mnuHelpAbout.Text = "About Virtual Mac..."
        '
        'frmVirtualMacintosh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 621)
        Me.Controls.Add(Me.VMStatusBar)
        Me.Controls.Add(Me.VMScreen)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 56)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu2
        Me.Name = "frmVirtualMacintosh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Macintosh - Virtual Mac"
        CType(Me.VMScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VMStatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents CDBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuAction As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionFullScreen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionClose As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCD As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCDCapture As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCDBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCDRelease As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFloppy As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFloppyCapture As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFloppyBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFloppyRelease As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpContents As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpOnline As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpBar1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
#End Region
End Class