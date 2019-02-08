<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSplash
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
    Public WithEvents Mac As System.Windows.Forms.Label
	Public WithEvents Starting As System.Windows.Forms.Label
	Public WithEvents Virtual As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Mac = New System.Windows.Forms.Label()
        Me.Starting = New System.Windows.Forms.Label()
        Me.Virtual = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Mac
        '
        resources.ApplyResources(Me.Mac, "Mac")
        Me.Mac.BackColor = System.Drawing.Color.Transparent
        Me.Mac.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Mac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Mac.Name = "Mac"
        Me.Mac.UseWaitCursor = True
        '
        'Starting
        '
        resources.ApplyResources(Me.Starting, "Starting")
        Me.Starting.BackColor = System.Drawing.Color.Transparent
        Me.Starting.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Starting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Starting.Name = "Starting"
        Me.Starting.UseWaitCursor = True
        '
        'Virtual
        '
        resources.ApplyResources(Me.Virtual, "Virtual")
        Me.Virtual.BackColor = System.Drawing.Color.Transparent
        Me.Virtual.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Virtual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Virtual.Name = "Virtual"
        Me.Virtual.UseWaitCursor = True
        '
        'Version
        '
        resources.ApplyResources(Me.Version, "Version")
        Me.Version.BackColor = System.Drawing.Color.White
        Me.Version.ForeColor = System.Drawing.Color.Silver
        Me.Version.Name = "Version"
        Me.Version.UseWaitCursor = True
        '
        'ProgressBar
        '
        resources.ApplyResources(Me.ProgressBar, "ProgressBar")
        Me.ProgressBar.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Step = 5
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.UseWaitCursor = True
        Me.ProgressBar.Value = 20
        '
        'frmSplash
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Mac)
        Me.Controls.Add(Me.Starting)
        Me.Controls.Add(Me.Virtual)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
#End Region
End Class