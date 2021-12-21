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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuActionStart = New System.Windows.Forms.MenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrayShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayNewMac = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayNewDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonNewM = New System.Windows.Forms.Button()
        Me.ButtonNewIcon = New System.Windows.Forms.Button()
        Me.VMList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MacIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuActionBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuAction = New System.Windows.Forms.MenuItem()
        Me.mnuActionPause = New System.Windows.Forms.MenuItem()
        Me.mnuActionRestart = New System.Windows.Forms.MenuItem()
        Me.mnuActionBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuActionRemove = New System.Windows.Forms.MenuItem()
        Me.mnuActionBar2 = New System.Windows.Forms.MenuItem()
        Me.mnuActionSettings = New System.Windows.Forms.MenuItem()
        Me.mnuActionProperties = New System.Windows.Forms.MenuItem()
        Me.mnuFileOptions = New System.Windows.Forms.MenuItem()
        Me.mnuFileDebug = New System.Windows.Forms.MenuItem()
        Me.mnuFileBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuHelpOnline = New System.Windows.Forms.MenuItem()
        Me.mnuHelpBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpContents = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHelpCrash = New System.Windows.Forms.MenuItem()
        Me.mnuFileBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuFileNewDisk = New System.Windows.Forms.MenuItem()
        Me.VirtualMacTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileNewMac = New System.Windows.Forms.MenuItem()
        Me.Browser = New System.Windows.Forms.OpenFileDialog()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuActionStart
        '
        resources.ApplyResources(Me.mnuActionStart, "mnuActionStart")
        Me.mnuActionStart.Index = 0
        '
        'ButtonStart
        '
        resources.ApplyResources(Me.ButtonStart, "ButtonStart")
        Me.ButtonStart.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonStart.Name = "ButtonStart"
        Me.ToolTip1.SetToolTip(Me.ButtonStart, resources.GetString("ButtonStart.ToolTip"))
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        resources.ApplyResources(Me.ButtonRemove, "ButtonRemove")
        Me.ButtonRemove.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ToolTip1.SetToolTip(Me.ButtonRemove, resources.GetString("ButtonRemove.ToolTip"))
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonSettings
        '
        resources.ApplyResources(Me.ButtonSettings, "ButtonSettings")
        Me.ButtonSettings.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ToolTip1.SetToolTip(Me.ButtonSettings, resources.GetString("ButtonSettings.ToolTip"))
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'TrayMenu
        '
        resources.ApplyResources(Me.TrayMenu, "TrayMenu")
        Me.TrayMenu.ImageScalingSize = New System.Drawing.Size(8, 8)
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayShow, Me.TrayNewMac, Me.TrayNewDisk, Me.TrayOptions, Me.TrayExit})
        Me.TrayMenu.Name = "ContextMenuStrip1"
        Me.TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolTip1.SetToolTip(Me.TrayMenu, resources.GetString("TrayMenu.ToolTip"))
        '
        'TrayShow
        '
        resources.ApplyResources(Me.TrayShow, "TrayShow")
        Me.TrayShow.Name = "TrayShow"
        '
        'TrayNewMac
        '
        resources.ApplyResources(Me.TrayNewMac, "TrayNewMac")
        Me.TrayNewMac.Name = "TrayNewMac"
        '
        'TrayNewDisk
        '
        resources.ApplyResources(Me.TrayNewDisk, "TrayNewDisk")
        Me.TrayNewDisk.Name = "TrayNewDisk"
        '
        'TrayOptions
        '
        resources.ApplyResources(Me.TrayOptions, "TrayOptions")
        Me.TrayOptions.Name = "TrayOptions"
        '
        'TrayExit
        '
        resources.ApplyResources(Me.TrayExit, "TrayExit")
        Me.TrayExit.Name = "TrayExit"
        '
        'ButtonNewM
        '
        resources.ApplyResources(Me.ButtonNewM, "ButtonNewM")
        Me.ButtonNewM.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNewM.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonNewM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonNewM.Name = "ButtonNewM"
        Me.ToolTip1.SetToolTip(Me.ButtonNewM, resources.GetString("ButtonNewM.ToolTip"))
        Me.ButtonNewM.UseVisualStyleBackColor = True
        '
        'ButtonNewIcon
        '
        resources.ApplyResources(Me.ButtonNewIcon, "ButtonNewIcon")
        Me.ButtonNewIcon.Name = "ButtonNewIcon"
        Me.ToolTip1.SetToolTip(Me.ButtonNewIcon, resources.GetString("ButtonNewIcon.ToolTip"))
        Me.ButtonNewIcon.UseVisualStyleBackColor = True
        '
        'VMList
        '
        resources.ApplyResources(Me.VMList, "VMList")
        Me.VMList.AllowDrop = True
        Me.VMList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.VMList.FullRowSelect = True
        Me.VMList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.VMList.HideSelection = False
        Me.VMList.MultiSelect = False
        Me.VMList.Name = "VMList"
        Me.VMList.ShowGroups = False
        Me.VMList.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.VMList.StateImageList = Me.MacIcons
        Me.VMList.TileSize = New System.Drawing.Size(220, 58)
        Me.ToolTip1.SetToolTip(Me.VMList, resources.GetString("VMList.ToolTip"))
        Me.VMList.UseCompatibleStateImageBehavior = False
        Me.VMList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'MacIcons
        '
        Me.MacIcons.ImageStream = CType(resources.GetObject("MacIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MacIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.MacIcons.Images.SetKeyName(0, "Generic")
        Me.MacIcons.Images.SetKeyName(1, "vMac")
        Me.MacIcons.Images.SetKeyName(2, "BII")
        Me.MacIcons.Images.SetKeyName(3, "SheepShaver")
        Me.MacIcons.Images.SetKeyName(4, "PearPC")
        Me.MacIcons.Images.SetKeyName(5, "OS6")
        Me.MacIcons.Images.SetKeyName(6, "OS7")
        Me.MacIcons.Images.SetKeyName(7, "OS8")
        Me.MacIcons.Images.SetKeyName(8, "OS9")
        Me.MacIcons.Images.SetKeyName(9, "OSX")
        '
        'mnuActionBar0
        '
        resources.ApplyResources(Me.mnuActionBar0, "mnuActionBar0")
        Me.mnuActionBar0.Index = 1
        '
        'mnuAction
        '
        resources.ApplyResources(Me.mnuAction, "mnuAction")
        Me.mnuAction.Index = 1
        Me.mnuAction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuActionStart, Me.mnuActionBar0, Me.mnuActionPause, Me.mnuActionRestart, Me.mnuActionBar1, Me.mnuActionRemove, Me.mnuActionBar2, Me.mnuActionSettings, Me.mnuActionProperties})
        '
        'mnuActionPause
        '
        resources.ApplyResources(Me.mnuActionPause, "mnuActionPause")
        Me.mnuActionPause.Index = 2
        '
        'mnuActionRestart
        '
        resources.ApplyResources(Me.mnuActionRestart, "mnuActionRestart")
        Me.mnuActionRestart.Index = 3
        '
        'mnuActionBar1
        '
        resources.ApplyResources(Me.mnuActionBar1, "mnuActionBar1")
        Me.mnuActionBar1.Index = 4
        '
        'mnuActionRemove
        '
        resources.ApplyResources(Me.mnuActionRemove, "mnuActionRemove")
        Me.mnuActionRemove.Index = 5
        '
        'mnuActionBar2
        '
        resources.ApplyResources(Me.mnuActionBar2, "mnuActionBar2")
        Me.mnuActionBar2.Index = 6
        '
        'mnuActionSettings
        '
        resources.ApplyResources(Me.mnuActionSettings, "mnuActionSettings")
        Me.mnuActionSettings.Index = 7
        '
        'mnuActionProperties
        '
        resources.ApplyResources(Me.mnuActionProperties, "mnuActionProperties")
        Me.mnuActionProperties.Index = 8
        '
        'mnuFileOptions
        '
        resources.ApplyResources(Me.mnuFileOptions, "mnuFileOptions")
        Me.mnuFileOptions.Index = 3
        '
        'mnuFileDebug
        '
        resources.ApplyResources(Me.mnuFileDebug, "mnuFileDebug")
        Me.mnuFileDebug.Index = 6
        '
        'mnuFileBar1
        '
        resources.ApplyResources(Me.mnuFileBar1, "mnuFileBar1")
        Me.mnuFileBar1.Index = 4
        '
        'mnuFileExit
        '
        resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
        Me.mnuFileExit.Index = 5
        '
        'mnuHelpOnline
        '
        resources.ApplyResources(Me.mnuHelpOnline, "mnuHelpOnline")
        Me.mnuHelpOnline.Index = 1
        '
        'mnuHelpBar0
        '
        resources.ApplyResources(Me.mnuHelpBar0, "mnuHelpBar0")
        Me.mnuHelpBar0.Index = 2
        '
        'mnuHelpContents
        '
        resources.ApplyResources(Me.mnuHelpContents, "mnuHelpContents")
        Me.mnuHelpContents.Index = 0
        '
        'mnuHelpAbout
        '
        resources.ApplyResources(Me.mnuHelpAbout, "mnuHelpAbout")
        Me.mnuHelpAbout.Index = 3
        '
        'mnuHelp
        '
        resources.ApplyResources(Me.mnuHelp, "mnuHelp")
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContents, Me.mnuHelpOnline, Me.mnuHelpBar0, Me.mnuHelpAbout, Me.mnuHelpCrash})
        '
        'mnuHelpCrash
        '
        resources.ApplyResources(Me.mnuHelpCrash, "mnuHelpCrash")
        Me.mnuHelpCrash.Index = 4
        '
        'mnuFileBar0
        '
        resources.ApplyResources(Me.mnuFileBar0, "mnuFileBar0")
        Me.mnuFileBar0.Index = 2
        '
        'mnuFileNewDisk
        '
        resources.ApplyResources(Me.mnuFileNewDisk, "mnuFileNewDisk")
        Me.mnuFileNewDisk.Index = 1
        '
        'VirtualMacTray
        '
        Me.VirtualMacTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.VirtualMacTray, "VirtualMacTray")
        Me.VirtualMacTray.ContextMenuStrip = Me.TrayMenu
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAction, Me.mnuHelp})
        resources.ApplyResources(Me.MainMenu1, "MainMenu1")
        '
        'mnuFile
        '
        resources.ApplyResources(Me.mnuFile, "mnuFile")
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileNewMac, Me.mnuFileNewDisk, Me.mnuFileBar0, Me.mnuFileOptions, Me.mnuFileBar1, Me.mnuFileExit, Me.mnuFileDebug})
        '
        'mnuFileNewMac
        '
        resources.ApplyResources(Me.mnuFileNewMac, "mnuFileNewMac")
        Me.mnuFileNewMac.Index = 0
        '
        'Browser
        '
        resources.ApplyResources(Me.Browser, "Browser")
        '
        'frmMain
        '
        Me.AcceptButton = Me.ButtonStart
        resources.ApplyResources(Me, "$this")
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.ButtonNewM)
        Me.Controls.Add(Me.ButtonNewIcon)
        Me.Controls.Add(Me.VMList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
