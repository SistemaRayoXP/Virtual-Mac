<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuActionStart = New System.Windows.Forms.MenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonStart = New System.Windows.Forms.Button
        Me.mnuActionBar0 = New System.Windows.Forms.MenuItem
        Me.mnuAction = New System.Windows.Forms.MenuItem
        Me.mnuActionPause = New System.Windows.Forms.MenuItem
        Me.mnuActionRestart = New System.Windows.Forms.MenuItem
        Me.mnuActionBar1 = New System.Windows.Forms.MenuItem
        Me.mnuActionRemove = New System.Windows.Forms.MenuItem
        Me.mnuActionBar2 = New System.Windows.Forms.MenuItem
        Me.mnuActionSettings = New System.Windows.Forms.MenuItem
        Me.mnuActionProperties = New System.Windows.Forms.MenuItem
        Me.mnuFileOptions = New System.Windows.Forms.MenuItem
        Me.mnuFileDebug = New System.Windows.Forms.MenuItem
        Me.mnuFileBar1 = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.mnuHelpOnline = New System.Windows.Forms.MenuItem
        Me.mnuHelpBar0 = New System.Windows.Forms.MenuItem
        Me.mnuHelpContents = New System.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpCrash = New System.Windows.Forms.MenuItem
        Me.mnuFileBar0 = New System.Windows.Forms.MenuItem
        Me.mnuFileNewDisk = New System.Windows.Forms.MenuItem
        Me.TrayNewMac = New System.Windows.Forms.ToolStripMenuItem
        Me.ButtonRemove = New System.Windows.Forms.Button
        Me.ButtonSettings = New System.Windows.Forms.Button
        Me.TrayShow = New System.Windows.Forms.ToolStripMenuItem
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrayNewDisk = New System.Windows.Forms.ToolStripMenuItem
        Me.TrayOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.TrayExit = New System.Windows.Forms.ToolStripMenuItem
        Me.VirtualMacTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ButtonNewM = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileNewMac = New System.Windows.Forms.MenuItem
        Me.ButtonNewIcon = New System.Windows.Forms.Button
        Me.Browser = New System.Windows.Forms.OpenFileDialog
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.VMList = New System.Windows.Forms.ListView
        Me.MacIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuActionStart
        '
        Me.mnuActionStart.Index = 0
        Me.mnuActionStart.Text = "Start"
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonStart.Enabled = False
        Me.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonStart.Location = New System.Drawing.Point(267, 108)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 12
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'mnuActionBar0
        '
        Me.mnuActionBar0.Index = 1
        Me.mnuActionBar0.Text = "-"
        '
        'mnuAction
        '
        Me.mnuAction.Index = 1
        Me.mnuAction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuActionStart, Me.mnuActionBar0, Me.mnuActionPause, Me.mnuActionRestart, Me.mnuActionBar1, Me.mnuActionRemove, Me.mnuActionBar2, Me.mnuActionSettings, Me.mnuActionProperties})
        Me.mnuAction.Text = "Action"
        '
        'mnuActionPause
        '
        Me.mnuActionPause.Index = 2
        Me.mnuActionPause.Text = "Pause"
        '
        'mnuActionRestart
        '
        Me.mnuActionRestart.Index = 3
        Me.mnuActionRestart.Text = "Restart"
        '
        'mnuActionBar1
        '
        Me.mnuActionBar1.Index = 4
        Me.mnuActionBar1.Text = "-"
        '
        'mnuActionRemove
        '
        Me.mnuActionRemove.Index = 5
        Me.mnuActionRemove.Text = "Remove"
        '
        'mnuActionBar2
        '
        Me.mnuActionBar2.Index = 6
        Me.mnuActionBar2.Text = "-"
        '
        'mnuActionSettings
        '
        Me.mnuActionSettings.Index = 7
        Me.mnuActionSettings.Text = "Settings"
        '
        'mnuActionProperties
        '
        Me.mnuActionProperties.Index = 8
        Me.mnuActionProperties.Text = "Properties"
        '
        'mnuFileOptions
        '
        Me.mnuFileOptions.Index = 3
        Me.mnuFileOptions.Text = "Options"
        '
        'mnuFileDebug
        '
        Me.mnuFileDebug.Index = 6
        Me.mnuFileDebug.Text = "Debug"
        '
        'mnuFileBar1
        '
        Me.mnuFileBar1.Index = 4
        Me.mnuFileBar1.Text = "-"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 5
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuHelpOnline
        '
        Me.mnuHelpOnline.Index = 1
        Me.mnuHelpOnline.Text = "Virtual Mac Online"
        '
        'mnuHelpBar0
        '
        Me.mnuHelpBar0.Index = 2
        Me.mnuHelpBar0.Text = "-"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Index = 0
        Me.mnuHelpContents.Text = "Virtual Mac Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 3
        Me.mnuHelpAbout.Text = "About Virtual Mac..."
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContents, Me.mnuHelpOnline, Me.mnuHelpBar0, Me.mnuHelpAbout, Me.mnuHelpCrash})
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpCrash
        '
        Me.mnuHelpCrash.Index = 4
        Me.mnuHelpCrash.Text = "Crash"
        Me.mnuHelpCrash.Visible = False
        '
        'mnuFileBar0
        '
        Me.mnuFileBar0.Index = 2
        Me.mnuFileBar0.Text = "-"
        '
        'mnuFileNewDisk
        '
        Me.mnuFileNewDisk.Index = 1
        Me.mnuFileNewDisk.Text = "New Disk Wizard"
        '
        'TrayNewMac
        '
        Me.TrayNewMac.Name = "TrayNewMac"
        Me.TrayNewMac.Size = New System.Drawing.Size(217, 22)
        Me.TrayNewMac.Text = "New Macintosh Wizard"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRemove.Enabled = False
        Me.ButtonRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRemove.Location = New System.Drawing.Point(267, 68)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonRemove.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRemove.TabIndex = 11
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSettings.Enabled = False
        Me.ButtonSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSettings.Location = New System.Drawing.Point(267, 38)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSettings.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSettings.TabIndex = 10
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'TrayShow
        '
        Me.TrayShow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TrayShow.Name = "TrayShow"
        Me.TrayShow.Size = New System.Drawing.Size(217, 22)
        Me.TrayShow.Text = "Show Virtual Mac Console"
        '
        'TrayMenu
        '
        Me.TrayMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TrayMenu.ImageScalingSize = New System.Drawing.Size(8, 8)
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayShow, Me.TrayNewMac, Me.TrayNewDisk, Me.TrayOptions, Me.TrayExit})
        Me.TrayMenu.Name = "ContextMenuStrip1"
        Me.TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TrayMenu.Size = New System.Drawing.Size(218, 114)
        '
        'TrayNewDisk
        '
        Me.TrayNewDisk.Name = "TrayNewDisk"
        Me.TrayNewDisk.Size = New System.Drawing.Size(217, 22)
        Me.TrayNewDisk.Text = "New Disk Wizard"
        '
        'TrayOptions
        '
        Me.TrayOptions.Name = "TrayOptions"
        Me.TrayOptions.Size = New System.Drawing.Size(217, 22)
        Me.TrayOptions.Text = "Options"
        '
        'TrayExit
        '
        Me.TrayExit.Name = "TrayExit"
        Me.TrayExit.Size = New System.Drawing.Size(217, 22)
        Me.TrayExit.Text = "Exit"
        '
        'VirtualMacTray
        '
        Me.VirtualMacTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.VirtualMacTray.BalloonTipText = "Welcome to the vintage Macintosh emulator FrontEnd Virtual Mac"
        Me.VirtualMacTray.BalloonTipTitle = "Welcome to Virtual Mac"
        Me.VirtualMacTray.ContextMenuStrip = Me.TrayMenu
        Me.VirtualMacTray.Icon = CType(resources.GetObject("VirtualMacTray.Icon"), System.Drawing.Icon)
        Me.VirtualMacTray.Text = "Virtual Mac Console"
        Me.VirtualMacTray.Visible = True
        '
        'ButtonNewM
        '
        Me.ButtonNewM.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNewM.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonNewM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonNewM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNewM.Location = New System.Drawing.Point(267, 8)
        Me.ButtonNewM.Name = "ButtonNewM"
        Me.ButtonNewM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonNewM.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNewM.TabIndex = 9
        Me.ButtonNewM.Text = "New..."
        Me.ButtonNewM.UseVisualStyleBackColor = True
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAction, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileNewMac, Me.mnuFileNewDisk, Me.mnuFileBar0, Me.mnuFileOptions, Me.mnuFileBar1, Me.mnuFileExit, Me.mnuFileDebug})
        Me.mnuFile.Text = "File"
        '
        'mnuFileNewMac
        '
        Me.mnuFileNewMac.Index = 0
        Me.mnuFileNewMac.Text = "New Mac Wizard"
        '
        'ButtonNewIcon
        '
        Me.ButtonNewIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNewIcon.Location = New System.Drawing.Point(268, 137)
        Me.ButtonNewIcon.Name = "ButtonNewIcon"
        Me.ButtonNewIcon.Size = New System.Drawing.Size(75, 36)
        Me.ButtonNewIcon.TabIndex = 14
        Me.ButtonNewIcon.Text = "Change Icon"
        Me.ButtonNewIcon.UseVisualStyleBackColor = True
        Me.ButtonNewIcon.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 244
        '
        'VMList
        '
        Me.VMList.AllowDrop = True
        Me.VMList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.VMList.FullRowSelect = True
        Me.VMList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.VMList.HideSelection = False
        Me.VMList.Location = New System.Drawing.Point(7, 8)
        Me.VMList.MultiSelect = False
        Me.VMList.Name = "VMList"
        Me.VMList.ShowGroups = False
        Me.VMList.Size = New System.Drawing.Size(249, 189)
        Me.VMList.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.VMList.StateImageList = Me.MacIcons
        Me.VMList.TabIndex = 13
        Me.VMList.TileSize = New System.Drawing.Size(228, 58)
        Me.VMList.UseCompatibleStateImageBehavior = False
        Me.VMList.View = System.Windows.Forms.View.Details
        '
        'MacIcons
        '
        Me.MacIcons.ImageStream = CType(resources.GetObject("MacIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MacIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.MacIcons.Images.SetKeyName(0, "Generic.ico")
        Me.MacIcons.Images.SetKeyName(1, "Mini vMac.png")
        Me.MacIcons.Images.SetKeyName(2, "Basilisk.png")
        Me.MacIcons.Images.SetKeyName(3, "SheepShaver.png")
        Me.MacIcons.Images.SetKeyName(4, "PearPC.png")
        Me.MacIcons.Images.SetKeyName(5, "OS6.png")
        Me.MacIcons.Images.SetKeyName(6, "OS7.png")
        Me.MacIcons.Images.SetKeyName(7, "OS8.png")
        Me.MacIcons.Images.SetKeyName(8, "OS9.png")
        Me.MacIcons.Images.SetKeyName(9, "OSX.png")
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 209)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.ButtonNewM)
        Me.Controls.Add(Me.ButtonNewIcon)
        Me.Controls.Add(Me.VMList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.Text = "Virtual Mac Console"
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuActionStart As System.Windows.Forms.MenuItem
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents mnuActionBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAction As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionPause As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionRestart As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionBar1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionRemove As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionBar2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionSettings As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActionProperties As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileOptions As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileDebug As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileBar1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpOnline As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpContents As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileBar0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileNewDisk As System.Windows.Forms.MenuItem
    Friend WithEvents TrayNewMac As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ButtonRemove As System.Windows.Forms.Button
    Public WithEvents ButtonSettings As System.Windows.Forms.Button
    Friend WithEvents TrayShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TrayNewDisk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VirtualMacTray As System.Windows.Forms.NotifyIcon
    Public WithEvents ButtonNewM As System.Windows.Forms.Button
    Private WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileNewMac As System.Windows.Forms.MenuItem
    Friend WithEvents ButtonNewIcon As System.Windows.Forms.Button
    Friend WithEvents Browser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents VMList As System.Windows.Forms.ListView
    Public WithEvents MacIcons As System.Windows.Forms.ImageList
    Friend WithEvents mnuHelpCrash As System.Windows.Forms.MenuItem
End Class
