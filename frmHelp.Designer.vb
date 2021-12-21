<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.HelpRenderer = New System.Windows.Forms.WebBrowser
        Me.NavigationBar = New System.Windows.Forms.ToolStrip
        Me.GoHome = New System.Windows.Forms.ToolStripButton
        Me.GoBack = New System.Windows.Forms.ToolStripButton
        Me.GoForward = New System.Windows.Forms.ToolStripButton
        Me.SearchStart = New System.Windows.Forms.ToolStripButton
        Me.SearchBox = New System.Windows.Forms.ToolStripTextBox
        Me.NavigationBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpRenderer
        '
        Me.HelpRenderer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HelpRenderer.Location = New System.Drawing.Point(0, 57)
        Me.HelpRenderer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HelpRenderer.Name = "HelpRenderer"
        Me.HelpRenderer.Size = New System.Drawing.Size(719, 381)
        Me.HelpRenderer.TabIndex = 0
        Me.HelpRenderer.Url = New System.Uri("", System.UriKind.Relative)
        '
        'NavigationBar
        '
        Me.NavigationBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.NavigationBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoHome, Me.GoBack, Me.GoForward, Me.SearchStart, Me.SearchBox})
        Me.NavigationBar.Location = New System.Drawing.Point(0, 0)
        Me.NavigationBar.Name = "NavigationBar"
        Me.NavigationBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.NavigationBar.Size = New System.Drawing.Size(719, 38)
        Me.NavigationBar.TabIndex = 1
        Me.NavigationBar.Text = "Navigation"
        '
        'GoHome
        '
        Me.GoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GoHome.Image = Global.VirtualMac.My.Resources.Resources.BrowserHome
        Me.GoHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoHome.Name = "GoHome"
        Me.GoHome.Size = New System.Drawing.Size(44, 35)
        Me.GoHome.Text = "Home"
        Me.GoHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GoBack
        '
        Me.GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GoBack.Enabled = False
        Me.GoBack.Image = Global.VirtualMac.My.Resources.Resources.BrowserBack
        Me.GoBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(36, 35)
        Me.GoBack.Text = "Back"
        Me.GoBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GoForward
        '
        Me.GoForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GoForward.Enabled = False
        Me.GoForward.Image = Global.VirtualMac.My.Resources.Resources.BrowserForward
        Me.GoForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoForward.Name = "GoForward"
        Me.GoForward.Size = New System.Drawing.Size(54, 35)
        Me.GoForward.Text = "Forward"
        Me.GoForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SearchStart
        '
        Me.SearchStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SearchStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchStart.Enabled = False
        Me.SearchStart.Image = Global.VirtualMac.My.Resources.Resources.BrowserSearch
        Me.SearchStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchStart.Name = "SearchStart"
        Me.SearchStart.Size = New System.Drawing.Size(23, 35)
        Me.SearchStart.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'SearchBox
        '
        Me.SearchBox.AcceptsReturn = True
        Me.SearchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SearchBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(100, 38)
        Me.SearchBox.Text = "Search..."
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 438)
        Me.Controls.Add(Me.NavigationBar)
        Me.Controls.Add(Me.HelpRenderer)
        Me.Name = "frmHelp"
        Me.Text = "Help - VirtualMac"
        Me.NavigationBar.ResumeLayout(False)
        Me.NavigationBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpRenderer As System.Windows.Forms.WebBrowser
    Friend WithEvents NavigationBar As System.Windows.Forms.ToolStrip
    Friend WithEvents GoBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents GoHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents GoForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchBox As System.Windows.Forms.ToolStripTextBox
End Class
