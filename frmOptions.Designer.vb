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
	Public WithEvents fraSample4 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
	Public WithEvents fraSample3 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
	Public WithEvents fraSample2 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
    Public WithEvents Folders As System.Windows.Forms.GroupBox
    Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
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
        Me._picOptions_3 = New System.Windows.Forms.Panel
        Me.fraSample4 = New System.Windows.Forms.GroupBox
        Me._picOptions_2 = New System.Windows.Forms.Panel
        Me.fraSample3 = New System.Windows.Forms.GroupBox
        Me._picOptions_1 = New System.Windows.Forms.Panel
        Me.fraSample2 = New System.Windows.Forms.GroupBox
        Me.Folders = New System.Windows.Forms.GroupBox
        Me.DefFolderTitle = New System.Windows.Forms.Label
        Me.DefaultMacFolder = New System.Windows.Forms.TextBox
        Me.BrowseFolder = New System.Windows.Forms.Button
        Me.ROM = New System.Windows.Forms.GroupBox
        Me.ROMFile = New System.Windows.Forms.TextBox
        Me.BrowseROM = New System.Windows.Forms.Button
        Me.picOptions = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me._picOptions_3.SuspendLayout()
        Me._picOptions_2.SuspendLayout()
        Me._picOptions_1.SuspendLayout()
        Me.Folders.SuspendLayout()
        Me.ROM.SuspendLayout()
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        '_picOptions_3
        '
        Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_3.Controls.Add(Me.fraSample4)
        Me._picOptions_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptions.SetIndex(Me._picOptions_3, CType(3, Short))
        resources.ApplyResources(Me._picOptions_3, "_picOptions_3")
        Me._picOptions_3.Name = "_picOptions_3"
        '
        'fraSample4
        '
        Me.fraSample4.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample4.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.fraSample4, "fraSample4")
        Me.fraSample4.Name = "fraSample4"
        Me.fraSample4.TabStop = False
        Me.fraSample4.Tag = "1021"
        '
        '_picOptions_2
        '
        Me._picOptions_2.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_2.Controls.Add(Me.fraSample3)
        Me._picOptions_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptions.SetIndex(Me._picOptions_2, CType(2, Short))
        resources.ApplyResources(Me._picOptions_2, "_picOptions_2")
        Me._picOptions_2.Name = "_picOptions_2"
        '
        'fraSample3
        '
        Me.fraSample3.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample3.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.fraSample3, "fraSample3")
        Me.fraSample3.Name = "fraSample3"
        Me.fraSample3.TabStop = False
        Me.fraSample3.Tag = "1020"
        '
        '_picOptions_1
        '
        Me._picOptions_1.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_1.Controls.Add(Me.fraSample2)
        Me._picOptions_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptions.SetIndex(Me._picOptions_1, CType(1, Short))
        resources.ApplyResources(Me._picOptions_1, "_picOptions_1")
        Me._picOptions_1.Name = "_picOptions_1"
        '
        'fraSample2
        '
        Me.fraSample2.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.fraSample2, "fraSample2")
        Me.fraSample2.Name = "fraSample2"
        Me.fraSample2.TabStop = False
        Me.fraSample2.Tag = "1019"
        '
        'Folders
        '
        Me.Folders.BackColor = System.Drawing.SystemColors.Control
        Me.Folders.Controls.Add(Me.DefFolderTitle)
        Me.Folders.Controls.Add(Me.DefaultMacFolder)
        Me.Folders.Controls.Add(Me.BrowseFolder)
        Me.Folders.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Folders, "Folders")
        Me.Folders.Name = "Folders"
        Me.Folders.TabStop = False
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
        'BrowseFolder
        '
        Me.BrowseFolder.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseFolder.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseFolder.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseFolder, "BrowseFolder")
        Me.BrowseFolder.Name = "BrowseFolder"
        Me.BrowseFolder.UseVisualStyleBackColor = True
        '
        'ROM
        '
        Me.ROM.BackColor = System.Drawing.SystemColors.Control
        Me.ROM.Controls.Add(Me.ROMFile)
        Me.ROM.Controls.Add(Me.BrowseROM)
        Me.ROM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ROM, "ROM")
        Me.ROM.Name = "ROM"
        Me.ROM.TabStop = False
        '
        'ROMFile
        '
        Me.ROMFile.AcceptsReturn = True
        Me.ROMFile.BackColor = System.Drawing.SystemColors.Window
        Me.ROMFile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ROMFile.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.ROMFile, "ROMFile")
        Me.ROMFile.Name = "ROMFile"
        Me.ROMFile.ReadOnly = True
        '
        'BrowseROM
        '
        Me.BrowseROM.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseROM.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseROM.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseROM, "BrowseROM")
        Me.BrowseROM.Name = "BrowseROM"
        Me.BrowseROM.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'ListView1
        '
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {CType(resources.GetObject("ListView1.Groups"), System.Windows.Forms.ListViewGroup), CType(resources.GetObject("ListView1.Groups1"), System.Windows.Forms.ListViewGroup)})
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Name = "ListView1"
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmOptions
        '
        Me.AcceptButton = Me.cmdOK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ROM)
        Me.Controls.Add(Me.Folders)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me._picOptions_3)
        Me.Controls.Add(Me._picOptions_2)
        Me.Controls.Add(Me._picOptions_1)
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
        Me._picOptions_3.ResumeLayout(False)
        Me._picOptions_2.ResumeLayout(False)
        Me._picOptions_1.ResumeLayout(False)
        Me.Folders.ResumeLayout(False)
        Me.Folders.PerformLayout()
        Me.ROM.ResumeLayout(False)
        Me.ROM.PerformLayout()
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents DefFolderTitle As System.Windows.Forms.Label
    Public WithEvents DefaultMacFolder As System.Windows.Forms.TextBox
    Public WithEvents BrowseFolder As System.Windows.Forms.Button
    Public WithEvents ROM As System.Windows.Forms.GroupBox
    Public WithEvents ROMFile As System.Windows.Forms.TextBox
    Public WithEvents BrowseROM As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
#End Region
End Class