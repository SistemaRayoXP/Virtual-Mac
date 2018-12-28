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
    Public WithEvents Folders As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BrowseOpen = New System.Windows.Forms.OpenFileDialog
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Folders = New System.Windows.Forms.GroupBox
        Me.ProgramFolder = New System.Windows.Forms.Label
        Me.ProgramFolderLabel = New System.Windows.Forms.Label
        Me.DefFolderTitle = New System.Windows.Forms.Label
        Me.DefaultMacFolder = New System.Windows.Forms.TextBox
        Me.BrowseDefFolder = New System.Windows.Forms.Button
        Me.ROM = New System.Windows.Forms.GroupBox
        Me.NoteQemuPPCROM = New System.Windows.Forms.Label
        Me.SSROMLabel = New System.Windows.Forms.Label
        Me.SSROM = New System.Windows.Forms.TextBox
        Me.BrowseSSROM = New System.Windows.Forms.Button
        Me.BIIROMLabel = New System.Windows.Forms.Label
        Me.BIIROM = New System.Windows.Forms.TextBox
        Me.BrowseBIIROM = New System.Windows.Forms.Button
        Me.vMacROMLabel = New System.Windows.Forms.Label
        Me.vMacROM = New System.Windows.Forms.TextBox
        Me.BrowsevMacROM = New System.Windows.Forms.Button
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.OptionsContainer = New System.Windows.Forms.ListView
        Me.Options = New System.Windows.Forms.ColumnHeader
        Me.Value = New System.Windows.Forms.ColumnHeader
        Me.TestNewWindow = New System.Windows.Forms.GroupBox
        Me.DisableTest = New System.Windows.Forms.RadioButton
        Me.EnableTest = New System.Windows.Forms.RadioButton
        Me.Folders.SuspendLayout()
        Me.ROM.SuspendLayout()
        Me.TestNewWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowseOpen
        '
        resources.ApplyResources(Me.BrowseOpen, "BrowseOpen")
        Me.BrowseOpen.ReadOnlyChecked = True
        Me.BrowseOpen.ShowReadOnly = True
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdOK, "cmdOK")
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Tag = "1024"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Tag = "1023"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Folders
        '
        Me.Folders.BackColor = System.Drawing.SystemColors.Control
        Me.Folders.Controls.Add(Me.ProgramFolder)
        Me.Folders.Controls.Add(Me.ProgramFolderLabel)
        Me.Folders.Controls.Add(Me.DefFolderTitle)
        Me.Folders.Controls.Add(Me.DefaultMacFolder)
        Me.Folders.Controls.Add(Me.BrowseDefFolder)
        Me.Folders.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Folders, "Folders")
        Me.Folders.Name = "Folders"
        Me.Folders.TabStop = False
        '
        'ProgramFolder
        '
        resources.ApplyResources(Me.ProgramFolder, "ProgramFolder")
        Me.ProgramFolder.Name = "ProgramFolder"
        '
        'ProgramFolderLabel
        '
        resources.ApplyResources(Me.ProgramFolderLabel, "ProgramFolderLabel")
        Me.ProgramFolderLabel.Name = "ProgramFolderLabel"
        '
        'DefFolderTitle
        '
        Me.DefFolderTitle.BackColor = System.Drawing.SystemColors.Control
        Me.DefFolderTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.DefFolderTitle.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DefFolderTitle, "DefFolderTitle")
        Me.DefFolderTitle.Name = "DefFolderTitle"
        '
        'DefaultMacFolder
        '
        Me.DefaultMacFolder.AcceptsReturn = True
        Me.DefaultMacFolder.BackColor = System.Drawing.SystemColors.Window
        Me.DefaultMacFolder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DefaultMacFolder.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.DefaultMacFolder, "DefaultMacFolder")
        Me.DefaultMacFolder.Name = "DefaultMacFolder"
        Me.DefaultMacFolder.ReadOnly = True
        '
        'BrowseDefFolder
        '
        Me.BrowseDefFolder.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseDefFolder.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseDefFolder.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseDefFolder, "BrowseDefFolder")
        Me.BrowseDefFolder.Name = "BrowseDefFolder"
        Me.BrowseDefFolder.UseVisualStyleBackColor = True
        '
        'ROM
        '
        Me.ROM.BackColor = System.Drawing.SystemColors.Control
        Me.ROM.Controls.Add(Me.NoteQemuPPCROM)
        Me.ROM.Controls.Add(Me.SSROMLabel)
        Me.ROM.Controls.Add(Me.SSROM)
        Me.ROM.Controls.Add(Me.BrowseSSROM)
        Me.ROM.Controls.Add(Me.BIIROMLabel)
        Me.ROM.Controls.Add(Me.BIIROM)
        Me.ROM.Controls.Add(Me.BrowseBIIROM)
        Me.ROM.Controls.Add(Me.vMacROMLabel)
        Me.ROM.Controls.Add(Me.vMacROM)
        Me.ROM.Controls.Add(Me.BrowsevMacROM)
        Me.ROM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ROM, "ROM")
        Me.ROM.Name = "ROM"
        Me.ROM.TabStop = False
        '
        'NoteQemuPPCROM
        '
        resources.ApplyResources(Me.NoteQemuPPCROM, "NoteQemuPPCROM")
        Me.NoteQemuPPCROM.Name = "NoteQemuPPCROM"
        '
        'SSROMLabel
        '
        resources.ApplyResources(Me.SSROMLabel, "SSROMLabel")
        Me.SSROMLabel.Name = "SSROMLabel"
        '
        'SSROM
        '
        Me.SSROM.AcceptsReturn = True
        Me.SSROM.BackColor = System.Drawing.SystemColors.Window
        Me.SSROM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SSROM.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.SSROM, "SSROM")
        Me.SSROM.Name = "SSROM"
        Me.SSROM.ReadOnly = True
        '
        'BrowseSSROM
        '
        Me.BrowseSSROM.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseSSROM.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseSSROM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseSSROM, "BrowseSSROM")
        Me.BrowseSSROM.Name = "BrowseSSROM"
        Me.BrowseSSROM.UseVisualStyleBackColor = True
        '
        'BIIROMLabel
        '
        resources.ApplyResources(Me.BIIROMLabel, "BIIROMLabel")
        Me.BIIROMLabel.Name = "BIIROMLabel"
        '
        'BIIROM
        '
        Me.BIIROM.AcceptsReturn = True
        Me.BIIROM.BackColor = System.Drawing.SystemColors.Window
        Me.BIIROM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BIIROM.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.BIIROM, "BIIROM")
        Me.BIIROM.Name = "BIIROM"
        Me.BIIROM.ReadOnly = True
        '
        'BrowseBIIROM
        '
        Me.BrowseBIIROM.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseBIIROM.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseBIIROM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseBIIROM, "BrowseBIIROM")
        Me.BrowseBIIROM.Name = "BrowseBIIROM"
        Me.BrowseBIIROM.UseVisualStyleBackColor = True
        '
        'vMacROMLabel
        '
        resources.ApplyResources(Me.vMacROMLabel, "vMacROMLabel")
        Me.vMacROMLabel.Name = "vMacROMLabel"
        '
        'vMacROM
        '
        Me.vMacROM.AcceptsReturn = True
        Me.vMacROM.BackColor = System.Drawing.SystemColors.Window
        Me.vMacROM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vMacROM.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.vMacROM, "vMacROM")
        Me.vMacROM.Name = "vMacROM"
        Me.vMacROM.ReadOnly = True
        '
        'BrowsevMacROM
        '
        Me.BrowsevMacROM.BackColor = System.Drawing.SystemColors.Control
        Me.BrowsevMacROM.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowsevMacROM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowsevMacROM, "BrowsevMacROM")
        Me.BrowsevMacROM.Name = "BrowsevMacROM"
        Me.BrowsevMacROM.UseVisualStyleBackColor = True
        '
        'OptionsContainer
        '
        Me.OptionsContainer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Options, Me.Value})
        Me.OptionsContainer.FullRowSelect = True
        Me.OptionsContainer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionsContainer.Items.AddRange(New System.Windows.Forms.ListViewItem() {CType(resources.GetObject("OptionsContainer.Items"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionsContainer.Items1"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionsContainer.Items2"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionsContainer.Items3"), System.Windows.Forms.ListViewItem), CType(resources.GetObject("OptionsContainer.Items4"), System.Windows.Forms.ListViewItem)})
        resources.ApplyResources(Me.OptionsContainer, "OptionsContainer")
        Me.OptionsContainer.Name = "OptionsContainer"
        Me.OptionsContainer.UseCompatibleStateImageBehavior = False
        Me.OptionsContainer.View = System.Windows.Forms.View.Details
        '
        'Options
        '
        resources.ApplyResources(Me.Options, "Options")
        '
        'Value
        '
        resources.ApplyResources(Me.Value, "Value")
        '
        'TestNewWindow
        '
        Me.TestNewWindow.BackColor = System.Drawing.SystemColors.Control
        Me.TestNewWindow.Controls.Add(Me.DisableTest)
        Me.TestNewWindow.Controls.Add(Me.EnableTest)
        Me.TestNewWindow.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.TestNewWindow, "TestNewWindow")
        Me.TestNewWindow.Name = "TestNewWindow"
        Me.TestNewWindow.TabStop = False
        '
        'DisableTest
        '
        resources.ApplyResources(Me.DisableTest, "DisableTest")
        Me.DisableTest.Name = "DisableTest"
        Me.DisableTest.UseVisualStyleBackColor = True
        '
        'EnableTest
        '
        resources.ApplyResources(Me.EnableTest, "EnableTest")
        Me.EnableTest.Name = "EnableTest"
        Me.EnableTest.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.cmdOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(Me.TestNewWindow)
        Me.Controls.Add(Me.ROM)
        Me.Controls.Add(Me.Folders)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.OptionsContainer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "1017"
        Me.Folders.ResumeLayout(False)
        Me.Folders.PerformLayout()
        Me.ROM.ResumeLayout(False)
        Me.ROM.PerformLayout()
        Me.TestNewWindow.ResumeLayout(False)
        Me.TestNewWindow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents DefFolderTitle As System.Windows.Forms.Label
    Public WithEvents DefaultMacFolder As System.Windows.Forms.TextBox
    Public WithEvents BrowseDefFolder As System.Windows.Forms.Button
    Public WithEvents ROM As System.Windows.Forms.GroupBox
    Public WithEvents vMacROM As System.Windows.Forms.TextBox
    Public WithEvents BrowsevMacROM As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Options As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Public WithEvents TestNewWindow As System.Windows.Forms.GroupBox
    Friend WithEvents DisableTest As System.Windows.Forms.RadioButton
    Friend WithEvents EnableTest As System.Windows.Forms.RadioButton
    Friend WithEvents OptionsContainer As System.Windows.Forms.ListView
    Friend WithEvents SSROMLabel As System.Windows.Forms.Label
    Public WithEvents SSROM As System.Windows.Forms.TextBox
    Public WithEvents BrowseSSROM As System.Windows.Forms.Button
    Friend WithEvents BIIROMLabel As System.Windows.Forms.Label
    Public WithEvents BIIROM As System.Windows.Forms.TextBox
    Public WithEvents BrowseBIIROM As System.Windows.Forms.Button
    Friend WithEvents vMacROMLabel As System.Windows.Forms.Label
    Friend WithEvents NoteQemuPPCROM As System.Windows.Forms.Label
    Friend WithEvents ProgramFolderLabel As System.Windows.Forms.Label
    Friend WithEvents ProgramFolder As System.Windows.Forms.Label
#End Region
End Class