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
	Public BrowserOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents VMScreen As System.Windows.Forms.PictureBox
	Public WithEvents mnuActionFullScreen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuActionBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuActionCloseVM As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAction As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCDCapture As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCDBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuCDRelease As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCD As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFloppyCapture As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFloppyBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFloppyRelease As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFloppy As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelpContents As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelpBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuHelpOnline As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelpBar1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVirtualMacintosh))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BrowserOpen = New System.Windows.Forms.OpenFileDialog
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnuAction = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionFullScreen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActionBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuActionCloseVM = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCD = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCDCapture = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCDBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCDRelease = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFloppy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFloppyCapture = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFloppyBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFloppyRelease = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpContents = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpBar0 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuHelpOnline = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpBar1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStatusBar = New System.Windows.Forms.StatusStrip
        Me.VMScreen = New System.Windows.Forms.PictureBox
        Me.MainMenu1.SuspendLayout()
        CType(Me.VMScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MainMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAction, Me.mnuCD, Me.mnuFloppy, Me.mnuHelp})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu1.Size = New System.Drawing.Size(718, 24)
        Me.MainMenu1.TabIndex = 2
        '
        'mnuAction
        '
        Me.mnuAction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActionFullScreen, Me.mnuActionBar0, Me.mnuActionCloseVM})
        Me.mnuAction.Name = "mnuAction"
        Me.mnuAction.Size = New System.Drawing.Size(49, 20)
        Me.mnuAction.Text = "Action"
        '
        'mnuActionFullScreen
        '
        Me.mnuActionFullScreen.Enabled = False
        Me.mnuActionFullScreen.Name = "mnuActionFullScreen"
        Me.mnuActionFullScreen.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Back), System.Windows.Forms.Keys)
        Me.mnuActionFullScreen.Size = New System.Drawing.Size(209, 22)
        Me.mnuActionFullScreen.Text = "Full Screen Mode"
        '
        'mnuActionBar0
        '
        Me.mnuActionBar0.Name = "mnuActionBar0"
        Me.mnuActionBar0.Size = New System.Drawing.Size(206, 6)
        '
        'mnuActionCloseVM
        '
        Me.mnuActionCloseVM.Name = "mnuActionCloseVM"
        Me.mnuActionCloseVM.Size = New System.Drawing.Size(209, 22)
        Me.mnuActionCloseVM.Text = "Close"
        '
        'mnuCD
        '
        Me.mnuCD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCDCapture, Me.mnuCDBar0, Me.mnuCDRelease})
        Me.mnuCD.Name = "mnuCD"
        Me.mnuCD.Size = New System.Drawing.Size(33, 20)
        Me.mnuCD.Text = "CD"
        '
        'mnuCDCapture
        '
        Me.mnuCDCapture.Name = "mnuCDCapture"
        Me.mnuCDCapture.Size = New System.Drawing.Size(179, 22)
        Me.mnuCDCapture.Text = "Capture ISO Image..."
        '
        'mnuCDBar0
        '
        Me.mnuCDBar0.Name = "mnuCDBar0"
        Me.mnuCDBar0.Size = New System.Drawing.Size(176, 6)
        '
        'mnuCDRelease
        '
        Me.mnuCDRelease.Enabled = False
        Me.mnuCDRelease.Name = "mnuCDRelease"
        Me.mnuCDRelease.Size = New System.Drawing.Size(179, 22)
        Me.mnuCDRelease.Text = "Release CD"
        '
        'mnuFloppy
        '
        Me.mnuFloppy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFloppyCapture, Me.mnuFloppyBar0, Me.mnuFloppyRelease})
        Me.mnuFloppy.Name = "mnuFloppy"
        Me.mnuFloppy.Size = New System.Drawing.Size(51, 20)
        Me.mnuFloppy.Text = "Floppy"
        '
        'mnuFloppyCapture
        '
        Me.mnuFloppyCapture.Name = "mnuFloppyCapture"
        Me.mnuFloppyCapture.Size = New System.Drawing.Size(215, 22)
        Me.mnuFloppyCapture.Text = "Capture Floppy Disk Image..."
        '
        'mnuFloppyBar0
        '
        Me.mnuFloppyBar0.Name = "mnuFloppyBar0"
        Me.mnuFloppyBar0.Size = New System.Drawing.Size(212, 6)
        '
        'mnuFloppyRelease
        '
        Me.mnuFloppyRelease.Enabled = False
        Me.mnuFloppyRelease.Name = "mnuFloppyRelease"
        Me.mnuFloppyRelease.Size = New System.Drawing.Size(215, 22)
        Me.mnuFloppyRelease.Text = "Release Disk"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpContents, Me.mnuHelpBar0, Me.mnuHelpOnline, Me.mnuHelpBar1, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Enabled = False
        Me.mnuHelpContents.Name = "mnuHelpContents"
        Me.mnuHelpContents.Size = New System.Drawing.Size(170, 22)
        Me.mnuHelpContents.Text = "Virtual Mac Help"
        '
        'mnuHelpBar0
        '
        Me.mnuHelpBar0.Name = "mnuHelpBar0"
        Me.mnuHelpBar0.Size = New System.Drawing.Size(167, 6)
        '
        'mnuHelpOnline
        '
        Me.mnuHelpOnline.Enabled = False
        Me.mnuHelpOnline.Name = "mnuHelpOnline"
        Me.mnuHelpOnline.Size = New System.Drawing.Size(170, 22)
        Me.mnuHelpOnline.Text = "Virtual Mac Online"
        '
        'mnuHelpBar1
        '
        Me.mnuHelpBar1.Name = "mnuHelpBar1"
        Me.mnuHelpBar1.Size = New System.Drawing.Size(167, 6)
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(170, 22)
        Me.mnuHelpAbout.Text = "About Virtual Mac..."
        '
        'VMStatusBar
        '
        Me.VMStatusBar.Location = New System.Drawing.Point(0, 508)
        Me.VMStatusBar.Name = "VMStatusBar"
        Me.VMStatusBar.Size = New System.Drawing.Size(718, 22)
        Me.VMStatusBar.TabIndex = 3
        Me.VMStatusBar.Text = "StatusStrip1"
        '
        'VMScreen
        '
        Me.VMScreen.BackColor = System.Drawing.SystemColors.Control
        Me.VMScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VMScreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMScreen.Image = CType(resources.GetObject("VMScreen.Image"), System.Drawing.Image)
        Me.VMScreen.Location = New System.Drawing.Point(-3, 27)
        Me.VMScreen.Name = "VMScreen"
        Me.VMScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VMScreen.Size = New System.Drawing.Size(721, 495)
        Me.VMScreen.TabIndex = 0
        Me.VMScreen.TabStop = False
        '
        'frmVirtualMacintosh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(718, 530)
        Me.Controls.Add(Me.VMStatusBar)
        Me.Controls.Add(Me.VMScreen)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 56)
        Me.MaximizeBox = False
        Me.Name = "frmVirtualMacintosh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Macintosh - Virtual Mac"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.VMScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VMStatusBar As System.Windows.Forms.StatusStrip
#End Region
End Class