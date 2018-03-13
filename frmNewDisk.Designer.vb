<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewDisk
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
	Public WithEvents WizardStart As System.Windows.Forms.PictureBox
	Public WithEvents TitleStart As System.Windows.Forms.Label
	Public WithEvents DescriptionStart As System.Windows.Forms.Label
	Public WithEvents NewDisk1 As System.Windows.Forms.Panel
    Public WithEvents NewDisk2 As System.Windows.Forms.Panel
	Public WithEvents NewDisk3Browse As System.Windows.Forms.Button
	Public WithEvents NewDisk3FileName As System.Windows.Forms.TextBox
	Public WithEvents NewVDTitleHelp As System.Windows.Forms.Label
	Public WithEvents NewDisk3 As System.Windows.Forms.Panel
	Public WithEvents WizardPictureSmall As System.Windows.Forms.PictureBox
	Public WithEvents Action As System.Windows.Forms.Label
	Public WithEvents ActionDescription As System.Windows.Forms.Label
	Public WithEvents Top_Renamed As System.Windows.Forms.GroupBox
	Public WithEvents FileNameA As System.Windows.Forms.TextBox
	Public WithEvents BrowseA As System.Windows.Forms.Button
	Public WithEvents FileNameTitleA As System.Windows.Forms.Label
	Public WithEvents HelpA As System.Windows.Forms.Label
	Public WithEvents NewMacFromExist As System.Windows.Forms.Panel
	Public WithEvents NewDiskWizard As System.Windows.Forms.Panel
	Public WithEvents OpenSettingsAfterFinish As System.Windows.Forms.CheckBox
	Public WithEvents WizardEnd As System.Windows.Forms.PictureBox
	Public WithEvents AdviceClickFinish As System.Windows.Forms.Label
	Public WithEvents AdviceNoHD As System.Windows.Forms.Label
	Public WithEvents VMName As System.Windows.Forms.Label
	Public WithEvents DescriptionEnd As System.Windows.Forms.Label
	Public WithEvents TitleEnd As System.Windows.Forms.Label
	Public WithEvents NewDiskEnd As System.Windows.Forms.Panel
	Public BrowseSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdNext As System.Windows.Forms.Button
	Public WithEvents cmdBack As System.Windows.Forms.Button
	Public WithEvents ControlBox_Renamed As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewDisk))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdBack = New System.Windows.Forms.Button
        Me.NewDisk1 = New System.Windows.Forms.Panel
        Me.TitleStart = New System.Windows.Forms.Label
        Me.DescriptionStart = New System.Windows.Forms.Label
        Me.NewDiskWizard = New System.Windows.Forms.Panel
        Me.NewDisk2 = New System.Windows.Forms.Panel
        Me.EditVirtualDisk = New System.Windows.Forms.RadioButton
        Me.DiscImage = New System.Windows.Forms.RadioButton
        Me.FloppyDisk = New System.Windows.Forms.RadioButton
        Me.FixedDisk = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.NewDisk3 = New System.Windows.Forms.Panel
        Me.NewDisk3Browse = New System.Windows.Forms.Button
        Me.NewDisk3FileName = New System.Windows.Forms.TextBox
        Me.NewVDTitleHelp = New System.Windows.Forms.Label
        Me.Top_Renamed = New System.Windows.Forms.GroupBox
        Me.Action = New System.Windows.Forms.Label
        Me.ActionDescription = New System.Windows.Forms.Label
        Me.NewMacFromExist = New System.Windows.Forms.Panel
        Me.FileNameA = New System.Windows.Forms.TextBox
        Me.BrowseA = New System.Windows.Forms.Button
        Me.FileNameTitleA = New System.Windows.Forms.Label
        Me.HelpA = New System.Windows.Forms.Label
        Me.NewDiskEnd = New System.Windows.Forms.Panel
        Me.OpenSettingsAfterFinish = New System.Windows.Forms.CheckBox
        Me.AdviceClickFinish = New System.Windows.Forms.Label
        Me.AdviceNoHD = New System.Windows.Forms.Label
        Me.VMName = New System.Windows.Forms.Label
        Me.DescriptionEnd = New System.Windows.Forms.Label
        Me.TitleEnd = New System.Windows.Forms.Label
        Me.BrowseSave = New System.Windows.Forms.SaveFileDialog
        Me.ControlBox_Renamed = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.WizardPictureSmall = New System.Windows.Forms.PictureBox
        Me.WizardStart = New System.Windows.Forms.PictureBox
        Me.WizardEnd = New System.Windows.Forms.PictureBox
        Me.NewDisk1.SuspendLayout()
        Me.NewDiskWizard.SuspendLayout()
        Me.NewDisk2.SuspendLayout()
        Me.NewDisk3.SuspendLayout()
        Me.Top_Renamed.SuspendLayout()
        Me.NewMacFromExist.SuspendLayout()
        Me.NewDiskEnd.SuspendLayout()
        Me.ControlBox_Renamed.SuspendLayout()
        CType(Me.WizardPictureSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizardStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizardEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.cmdBack, "cmdBack")
        Me.cmdBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBack.Name = "cmdBack"
        Me.ToolTip1.SetToolTip(Me.cmdBack, resources.GetString("cmdBack.ToolTip"))
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'NewDisk1
        '
        Me.NewDisk1.BackColor = System.Drawing.Color.White
        Me.NewDisk1.Controls.Add(Me.WizardStart)
        Me.NewDisk1.Controls.Add(Me.TitleStart)
        Me.NewDisk1.Controls.Add(Me.DescriptionStart)
        Me.NewDisk1.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDisk1.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDisk1, "NewDisk1")
        Me.NewDisk1.Name = "NewDisk1"
        '
        'TitleStart
        '
        Me.TitleStart.BackColor = System.Drawing.Color.Transparent
        Me.TitleStart.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.TitleStart, "TitleStart")
        Me.TitleStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleStart.Name = "TitleStart"
        '
        'DescriptionStart
        '
        Me.DescriptionStart.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.DescriptionStart.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DescriptionStart, "DescriptionStart")
        Me.DescriptionStart.Name = "DescriptionStart"
        '
        'NewDiskWizard
        '
        Me.NewDiskWizard.BackColor = System.Drawing.SystemColors.Control
        Me.NewDiskWizard.Controls.Add(Me.NewDisk2)
        Me.NewDiskWizard.Controls.Add(Me.NewDisk3)
        Me.NewDiskWizard.Controls.Add(Me.Top_Renamed)
        Me.NewDiskWizard.Controls.Add(Me.NewMacFromExist)
        Me.NewDiskWizard.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDiskWizard.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDiskWizard, "NewDiskWizard")
        Me.NewDiskWizard.Name = "NewDiskWizard"
        '
        'NewDisk2
        '
        Me.NewDisk2.BackColor = System.Drawing.SystemColors.Control
        Me.NewDisk2.Controls.Add(Me.EditVirtualDisk)
        Me.NewDisk2.Controls.Add(Me.DiscImage)
        Me.NewDisk2.Controls.Add(Me.FloppyDisk)
        Me.NewDisk2.Controls.Add(Me.FixedDisk)
        Me.NewDisk2.Controls.Add(Me.Label4)
        Me.NewDisk2.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDisk2.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDisk2, "NewDisk2")
        Me.NewDisk2.Name = "NewDisk2"
        '
        'EditVirtualDisk
        '
        Me.EditVirtualDisk.BackColor = System.Drawing.SystemColors.Control
        Me.EditVirtualDisk.Cursor = System.Windows.Forms.Cursors.Default
        Me.EditVirtualDisk.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.EditVirtualDisk, "EditVirtualDisk")
        Me.EditVirtualDisk.Name = "EditVirtualDisk"
        Me.EditVirtualDisk.TabStop = True
        Me.EditVirtualDisk.UseVisualStyleBackColor = False
        '
        'DiscImage
        '
        Me.DiscImage.BackColor = System.Drawing.SystemColors.Control
        Me.DiscImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.DiscImage.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DiscImage, "DiscImage")
        Me.DiscImage.Name = "DiscImage"
        Me.DiscImage.TabStop = True
        Me.DiscImage.UseVisualStyleBackColor = False
        '
        'FloppyDisk
        '
        Me.FloppyDisk.BackColor = System.Drawing.SystemColors.Control
        Me.FloppyDisk.Cursor = System.Windows.Forms.Cursors.Default
        Me.FloppyDisk.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FloppyDisk, "FloppyDisk")
        Me.FloppyDisk.Name = "FloppyDisk"
        Me.FloppyDisk.TabStop = True
        Me.FloppyDisk.UseVisualStyleBackColor = False
        '
        'FixedDisk
        '
        Me.FixedDisk.BackColor = System.Drawing.SystemColors.Control
        Me.FixedDisk.Checked = True
        Me.FixedDisk.Cursor = System.Windows.Forms.Cursors.Default
        Me.FixedDisk.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FixedDisk, "FixedDisk")
        Me.FixedDisk.Name = "FixedDisk"
        Me.FixedDisk.TabStop = True
        Me.FixedDisk.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'NewDisk3
        '
        Me.NewDisk3.BackColor = System.Drawing.SystemColors.Control
        Me.NewDisk3.Controls.Add(Me.NewDisk3Browse)
        Me.NewDisk3.Controls.Add(Me.NewDisk3FileName)
        Me.NewDisk3.Controls.Add(Me.NewVDTitleHelp)
        Me.NewDisk3.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDisk3.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDisk3, "NewDisk3")
        Me.NewDisk3.Name = "NewDisk3"
        '
        'NewDisk3Browse
        '
        Me.NewDisk3Browse.BackColor = System.Drawing.SystemColors.Control
        Me.NewDisk3Browse.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDisk3Browse.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDisk3Browse, "NewDisk3Browse")
        Me.NewDisk3Browse.Name = "NewDisk3Browse"
        Me.NewDisk3Browse.UseVisualStyleBackColor = False
        '
        'NewDisk3FileName
        '
        Me.NewDisk3FileName.AcceptsReturn = True
        Me.NewDisk3FileName.BackColor = System.Drawing.SystemColors.Window
        Me.NewDisk3FileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NewDisk3FileName.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.NewDisk3FileName, "NewDisk3FileName")
        Me.NewDisk3FileName.Name = "NewDisk3FileName"
        '
        'NewVDTitleHelp
        '
        Me.NewVDTitleHelp.BackColor = System.Drawing.SystemColors.Control
        Me.NewVDTitleHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewVDTitleHelp.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewVDTitleHelp, "NewVDTitleHelp")
        Me.NewVDTitleHelp.Name = "NewVDTitleHelp"
        '
        'Top_Renamed
        '
        Me.Top_Renamed.BackColor = System.Drawing.Color.White
        Me.Top_Renamed.Controls.Add(Me.WizardPictureSmall)
        Me.Top_Renamed.Controls.Add(Me.Action)
        Me.Top_Renamed.Controls.Add(Me.ActionDescription)
        Me.Top_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.Top_Renamed, "Top_Renamed")
        Me.Top_Renamed.Name = "Top_Renamed"
        Me.Top_Renamed.TabStop = False
        '
        'Action
        '
        Me.Action.BackColor = System.Drawing.Color.Transparent
        Me.Action.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.Action, "Action")
        Me.Action.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Action.Name = "Action"
        '
        'ActionDescription
        '
        Me.ActionDescription.BackColor = System.Drawing.Color.Transparent
        Me.ActionDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.ActionDescription.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ActionDescription, "ActionDescription")
        Me.ActionDescription.Name = "ActionDescription"
        '
        'NewMacFromExist
        '
        Me.NewMacFromExist.BackColor = System.Drawing.SystemColors.Control
        Me.NewMacFromExist.Controls.Add(Me.FileNameA)
        Me.NewMacFromExist.Controls.Add(Me.BrowseA)
        Me.NewMacFromExist.Controls.Add(Me.FileNameTitleA)
        Me.NewMacFromExist.Controls.Add(Me.HelpA)
        Me.NewMacFromExist.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewMacFromExist.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewMacFromExist, "NewMacFromExist")
        Me.NewMacFromExist.Name = "NewMacFromExist"
        '
        'FileNameA
        '
        Me.FileNameA.AcceptsReturn = True
        Me.FileNameA.BackColor = System.Drawing.SystemColors.Window
        Me.FileNameA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FileNameA.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.FileNameA, "FileNameA")
        Me.FileNameA.Name = "FileNameA"
        '
        'BrowseA
        '
        Me.BrowseA.BackColor = System.Drawing.SystemColors.Control
        Me.BrowseA.Cursor = System.Windows.Forms.Cursors.Default
        Me.BrowseA.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.BrowseA, "BrowseA")
        Me.BrowseA.Name = "BrowseA"
        Me.BrowseA.UseVisualStyleBackColor = False
        '
        'FileNameTitleA
        '
        Me.FileNameTitleA.BackColor = System.Drawing.SystemColors.Control
        Me.FileNameTitleA.Cursor = System.Windows.Forms.Cursors.Default
        Me.FileNameTitleA.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.FileNameTitleA, "FileNameTitleA")
        Me.FileNameTitleA.Name = "FileNameTitleA"
        '
        'HelpA
        '
        Me.HelpA.BackColor = System.Drawing.Color.Transparent
        Me.HelpA.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpA.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.HelpA, "HelpA")
        Me.HelpA.Name = "HelpA"
        '
        'NewDiskEnd
        '
        Me.NewDiskEnd.BackColor = System.Drawing.Color.White
        Me.NewDiskEnd.Controls.Add(Me.OpenSettingsAfterFinish)
        Me.NewDiskEnd.Controls.Add(Me.WizardEnd)
        Me.NewDiskEnd.Controls.Add(Me.AdviceClickFinish)
        Me.NewDiskEnd.Controls.Add(Me.AdviceNoHD)
        Me.NewDiskEnd.Controls.Add(Me.VMName)
        Me.NewDiskEnd.Controls.Add(Me.DescriptionEnd)
        Me.NewDiskEnd.Controls.Add(Me.TitleEnd)
        Me.NewDiskEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.NewDiskEnd.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.NewDiskEnd, "NewDiskEnd")
        Me.NewDiskEnd.Name = "NewDiskEnd"
        '
        'OpenSettingsAfterFinish
        '
        Me.OpenSettingsAfterFinish.BackColor = System.Drawing.Color.White
        Me.OpenSettingsAfterFinish.Checked = True
        Me.OpenSettingsAfterFinish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OpenSettingsAfterFinish.Cursor = System.Windows.Forms.Cursors.Default
        Me.OpenSettingsAfterFinish.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.OpenSettingsAfterFinish, "OpenSettingsAfterFinish")
        Me.OpenSettingsAfterFinish.Name = "OpenSettingsAfterFinish"
        Me.OpenSettingsAfterFinish.UseVisualStyleBackColor = False
        '
        'AdviceClickFinish
        '
        Me.AdviceClickFinish.BackColor = System.Drawing.Color.Transparent
        Me.AdviceClickFinish.Cursor = System.Windows.Forms.Cursors.Default
        Me.AdviceClickFinish.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AdviceClickFinish, "AdviceClickFinish")
        Me.AdviceClickFinish.Name = "AdviceClickFinish"
        '
        'AdviceNoHD
        '
        Me.AdviceNoHD.BackColor = System.Drawing.Color.Transparent
        Me.AdviceNoHD.Cursor = System.Windows.Forms.Cursors.Default
        Me.AdviceNoHD.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.AdviceNoHD, "AdviceNoHD")
        Me.AdviceNoHD.Name = "AdviceNoHD"
        '
        'VMName
        '
        resources.ApplyResources(Me.VMName, "VMName")
        Me.VMName.BackColor = System.Drawing.Color.Transparent
        Me.VMName.Cursor = System.Windows.Forms.Cursors.Default
        Me.VMName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VMName.Name = "VMName"
        '
        'DescriptionEnd
        '
        Me.DescriptionEnd.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.DescriptionEnd.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DescriptionEnd, "DescriptionEnd")
        Me.DescriptionEnd.Name = "DescriptionEnd"
        '
        'TitleEnd
        '
        Me.TitleEnd.BackColor = System.Drawing.Color.Transparent
        Me.TitleEnd.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.TitleEnd, "TitleEnd")
        Me.TitleEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleEnd.Name = "TitleEnd"
        '
        'ControlBox_Renamed
        '
        Me.ControlBox_Renamed.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox_Renamed.Controls.Add(Me.cmdCancel)
        Me.ControlBox_Renamed.Controls.Add(Me.cmdNext)
        Me.ControlBox_Renamed.Controls.Add(Me.cmdBack)
        Me.ControlBox_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.ControlBox_Renamed, "ControlBox_Renamed")
        Me.ControlBox_Renamed.Name = "ControlBox_Renamed"
        Me.ControlBox_Renamed.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.cmdNext, "cmdNext")
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'WizardPictureSmall
        '
        Me.WizardPictureSmall.BackColor = System.Drawing.SystemColors.Control
        Me.WizardPictureSmall.Cursor = System.Windows.Forms.Cursors.Default
        Me.WizardPictureSmall.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.WizardPictureSmall, "WizardPictureSmall")
        Me.WizardPictureSmall.Name = "WizardPictureSmall"
        Me.WizardPictureSmall.TabStop = False
        '
        'WizardStart
        '
        Me.WizardStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.WizardStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.WizardStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WizardStart.Image = Global.VirtualMac.My.Resources.Resources.NewDisk
        resources.ApplyResources(Me.WizardStart, "WizardStart")
        Me.WizardStart.Name = "WizardStart"
        Me.WizardStart.TabStop = False
        '
        'WizardEnd
        '
        Me.WizardEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WizardEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.WizardEnd.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.WizardEnd, "WizardEnd")
        Me.WizardEnd.Name = "WizardEnd"
        Me.WizardEnd.TabStop = False
        '
        'frmNewDisk
        '
        Me.AcceptButton = Me.cmdNext
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancel
        Me.Controls.Add(Me.NewDiskWizard)
        Me.Controls.Add(Me.NewDisk1)
        Me.Controls.Add(Me.NewDiskEnd)
        Me.Controls.Add(Me.ControlBox_Renamed)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewDisk"
        Me.NewDisk1.ResumeLayout(False)
        Me.NewDiskWizard.ResumeLayout(False)
        Me.NewDisk2.ResumeLayout(False)
        Me.NewDisk3.ResumeLayout(False)
        Me.NewDisk3.PerformLayout()
        Me.Top_Renamed.ResumeLayout(False)
        Me.NewMacFromExist.ResumeLayout(False)
        Me.NewMacFromExist.PerformLayout()
        Me.NewDiskEnd.ResumeLayout(False)
        Me.NewDiskEnd.PerformLayout()
        Me.ControlBox_Renamed.ResumeLayout(False)
        CType(Me.WizardPictureSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizardStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizardEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents EditVirtualDisk As System.Windows.Forms.RadioButton
    Public WithEvents DiscImage As System.Windows.Forms.RadioButton
    Public WithEvents FloppyDisk As System.Windows.Forms.RadioButton
    Public WithEvents FixedDisk As System.Windows.Forms.RadioButton
    Public WithEvents Label4 As System.Windows.Forms.Label
#End Region 
End Class