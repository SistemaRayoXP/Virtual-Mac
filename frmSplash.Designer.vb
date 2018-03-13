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
        Me.Mac = New System.Windows.Forms.Label
        Me.Starting = New System.Windows.Forms.Label
        Me.Virtual = New System.Windows.Forms.Label
        Me.Version = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'Mac
        '
        Me.Mac.BackColor = System.Drawing.Color.Transparent
        Me.Mac.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Mac.Font = New System.Drawing.Font("David Transparent", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Mac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Mac.Location = New System.Drawing.Point(228, 168)
        Me.Mac.Name = "Mac"
        Me.Mac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mac.Size = New System.Drawing.Size(149, 65)
        Me.Mac.TabIndex = 2
        Me.Mac.Text = "Mac"
        Me.Mac.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Mac.UseWaitCursor = True
        '
        'Starting
        '
        Me.Starting.BackColor = System.Drawing.Color.Transparent
        Me.Starting.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Starting.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Starting.Location = New System.Drawing.Point(154, 272)
        Me.Starting.Name = "Starting"
        Me.Starting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Starting.Size = New System.Drawing.Size(113, 17)
        Me.Starting.TabIndex = 1
        Me.Starting.Text = "Starting..."
        Me.Starting.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Starting.UseWaitCursor = True
        '
        'Virtual
        '
        Me.Virtual.BackColor = System.Drawing.Color.Transparent
        Me.Virtual.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Virtual.Font = New System.Drawing.Font("David Transparent", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Virtual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Virtual.Location = New System.Drawing.Point(38, 168)
        Me.Virtual.Name = "Virtual"
        Me.Virtual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Virtual.Size = New System.Drawing.Size(216, 65)
        Me.Virtual.TabIndex = 0
        Me.Virtual.Text = "Virtual"
        Me.Virtual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Virtual.UseWaitCursor = True
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.White
        Me.Version.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Black
        Me.Version.Location = New System.Drawing.Point(335, 233)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(42, 13)
        Me.Version.TabIndex = 3
        Me.Version.Text = "{022}"
        Me.Version.UseWaitCursor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(130, 288)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(161, 15)
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Value = 20
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 45.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(421, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Mac)
        Me.Controls.Add(Me.Starting)
        Me.Controls.Add(Me.Virtual)
        Me.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
#End Region
End Class