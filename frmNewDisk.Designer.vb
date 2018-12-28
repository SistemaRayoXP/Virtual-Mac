<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewDisk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewDisk))
        Me.Welcome = New System.Windows.Forms.Panel
        Me.WelcomeDescription = New System.Windows.Forms.Label
        Me.WelcomeTitle = New System.Windows.Forms.Label
        Me.FormButtons = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.Wizard = New System.Windows.Forms.Panel
        Me.CreateNew = New System.Windows.Forms.Panel
        Me.SaveMac = New System.Windows.Forms.Button
        Me.MacName = New System.Windows.Forms.TextBox
        Me.CreateNewDescription = New System.Windows.Forms.Label
        Me.DescriptionContainer = New System.Windows.Forms.GroupBox
        Me.Description = New System.Windows.Forms.Label
        Me.DescriptionName = New System.Windows.Forms.Label
        Me.DiskMBLabel = New System.Windows.Forms.Label
        Me.DiskSize = New System.Windows.Forms.NumericUpDown
        Me.DiskSizeLabel = New System.Windows.Forms.Label
        Me.Save = New System.Windows.Forms.SaveFileDialog
        Me.DiskSizeDefaults = New System.Windows.Forms.ComboBox
        Me.Welcome.SuspendLayout()
        Me.FormButtons.SuspendLayout()
        Me.Wizard.SuspendLayout()
        Me.CreateNew.SuspendLayout()
        Me.DescriptionContainer.SuspendLayout()
        CType(Me.DiskSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Welcome
        '
        Me.Welcome.BackColor = System.Drawing.Color.White
        Me.Welcome.BackgroundImage = Global.VirtualMac.My.Resources.Resources.NewDisk
        Me.Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Welcome.Controls.Add(Me.WelcomeDescription)
        Me.Welcome.Controls.Add(Me.WelcomeTitle)
        Me.Welcome.Location = New System.Drawing.Point(0, 0)
        Me.Welcome.Margin = New System.Windows.Forms.Padding(0)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(497, 313)
        Me.Welcome.TabIndex = 3
        '
        'WelcomeDescription
        '
        Me.WelcomeDescription.Location = New System.Drawing.Point(170, 60)
        Me.WelcomeDescription.Name = "WelcomeDescription"
        Me.WelcomeDescription.Size = New System.Drawing.Size(300, 105)
        Me.WelcomeDescription.TabIndex = 1
        Me.WelcomeDescription.Text = resources.GetString("WelcomeDescription.Text")
        '
        'WelcomeTitle
        '
        Me.WelcomeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeTitle.Location = New System.Drawing.Point(170, 15)
        Me.WelcomeTitle.Name = "WelcomeTitle"
        Me.WelcomeTitle.Size = New System.Drawing.Size(300, 25)
        Me.WelcomeTitle.TabIndex = 0
        Me.WelcomeTitle.Text = "Welcome to the New Disk Wizard"
        '
        'FormButtons
        '
        Me.FormButtons.Controls.Add(Me.cmdCancel)
        Me.FormButtons.Controls.Add(Me.cmdNext)
        Me.FormButtons.Controls.Add(Me.cmdBack)
        Me.FormButtons.Location = New System.Drawing.Point(0, 308)
        Me.FormButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.FormButtons.Name = "FormButtons"
        Me.FormButtons.Size = New System.Drawing.Size(499, 54)
        Me.FormButtons.TabIndex = 2
        Me.FormButtons.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(412, 13)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(327, 13)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "&Next >"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(252, 13)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 0
        Me.cmdBack.Text = "< &Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Wizard
        '
        Me.Wizard.BackColor = System.Drawing.SystemColors.Control
        Me.Wizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Wizard.Controls.Add(Me.CreateNew)
        Me.Wizard.Controls.Add(Me.DescriptionContainer)
        Me.Wizard.Location = New System.Drawing.Point(0, 0)
        Me.Wizard.Margin = New System.Windows.Forms.Padding(0)
        Me.Wizard.Name = "Wizard"
        Me.Wizard.Size = New System.Drawing.Size(497, 313)
        Me.Wizard.TabIndex = 4
        '
        'CreateNew
        '
        Me.CreateNew.Controls.Add(Me.DiskSizeDefaults)
        Me.CreateNew.Controls.Add(Me.DiskMBLabel)
        Me.CreateNew.Controls.Add(Me.DiskSize)
        Me.CreateNew.Controls.Add(Me.DiskSizeLabel)
        Me.CreateNew.Controls.Add(Me.SaveMac)
        Me.CreateNew.Controls.Add(Me.MacName)
        Me.CreateNew.Controls.Add(Me.CreateNewDescription)
        Me.CreateNew.Location = New System.Drawing.Point(0, 59)
        Me.CreateNew.Name = "CreateNew"
        Me.CreateNew.Size = New System.Drawing.Size(498, 245)
        Me.CreateNew.TabIndex = 2
        '
        'SaveMac
        '
        Me.SaveMac.Location = New System.Drawing.Point(395, 68)
        Me.SaveMac.Name = "SaveMac"
        Me.SaveMac.Size = New System.Drawing.Size(75, 23)
        Me.SaveMac.TabIndex = 2
        Me.SaveMac.Text = "Browse..."
        Me.SaveMac.UseVisualStyleBackColor = True
        '
        'MacName
        '
        Me.MacName.Location = New System.Drawing.Point(25, 68)
        Me.MacName.Name = "MacName"
        Me.MacName.Size = New System.Drawing.Size(364, 20)
        Me.MacName.TabIndex = 1
        '
        'CreateNewDescription
        '
        Me.CreateNewDescription.Location = New System.Drawing.Point(22, 24)
        Me.CreateNewDescription.Name = "CreateNewDescription"
        Me.CreateNewDescription.Size = New System.Drawing.Size(450, 30)
        Me.CreateNewDescription.TabIndex = 0
        Me.CreateNewDescription.Text = "Click on Browse to set the path to your hard disk image. You can set the drop dow" & _
            "n list to the emulator you are creating the disk for and get suggestions of reco" & _
            "mmended sizes."
        '
        'DescriptionContainer
        '
        Me.DescriptionContainer.BackColor = System.Drawing.Color.White
        Me.DescriptionContainer.Controls.Add(Me.Description)
        Me.DescriptionContainer.Controls.Add(Me.DescriptionName)
        Me.DescriptionContainer.Location = New System.Drawing.Point(-1, -8)
        Me.DescriptionContainer.Name = "DescriptionContainer"
        Me.DescriptionContainer.Size = New System.Drawing.Size(499, 67)
        Me.DescriptionContainer.TabIndex = 0
        Me.DescriptionContainer.TabStop = False
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(48, 34)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(423, 30)
        Me.Description.TabIndex = 1
        Me.Description.Text = "Set the size and location for your new hard disk image."
        '
        'DescriptionName
        '
        Me.DescriptionName.AutoSize = True
        Me.DescriptionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionName.Location = New System.Drawing.Point(23, 20)
        Me.DescriptionName.Name = "DescriptionName"
        Me.DescriptionName.Size = New System.Drawing.Size(134, 13)
        Me.DescriptionName.TabIndex = 0
        Me.DescriptionName.Text = "Route and size of disk"
        '
        'DiskMBLabel
        '
        Me.DiskMBLabel.AutoSize = True
        Me.DiskMBLabel.Location = New System.Drawing.Point(395, 96)
        Me.DiskMBLabel.Name = "DiskMBLabel"
        Me.DiskMBLabel.Size = New System.Drawing.Size(23, 13)
        Me.DiskMBLabel.TabIndex = 22
        Me.DiskMBLabel.Text = "MB"
        '
        'DiskSize
        '
        Me.DiskSize.Location = New System.Drawing.Point(305, 94)
        Me.DiskSize.Maximum = New Decimal(New Integer() {130000, 0, 0, 0})
        Me.DiskSize.Name = "DiskSize"
        Me.DiskSize.Size = New System.Drawing.Size(84, 20)
        Me.DiskSize.TabIndex = 21
        '
        'DiskSizeLabel
        '
        Me.DiskSizeLabel.AutoSize = True
        Me.DiskSizeLabel.Location = New System.Drawing.Point(217, 96)
        Me.DiskSizeLabel.Name = "DiskSizeLabel"
        Me.DiskSizeLabel.Size = New System.Drawing.Size(82, 13)
        Me.DiskSizeLabel.TabIndex = 20
        Me.DiskSizeLabel.Text = "Size of the disk:"
        '
        'Save
        '
        Me.Save.Filter = "Disk file|*.dsk|Hard disk Image|*.img|RAW hard disk data|*.raw"
        Me.Save.FilterIndex = 2
        Me.Save.RestoreDirectory = True
        Me.Save.SupportMultiDottedExtensions = True
        '
        'DiskSizeDefaults
        '
        Me.DiskSizeDefaults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiskSizeDefaults.FormattingEnabled = True
        Me.DiskSizeDefaults.Items.AddRange(New Object() {"User defined", "Mini vMac", "Basilisk II - 40 MB", "Basilisk II - 100 MB", "Basilisk II - 200 MB", "Basilisk II - 500 MB", "Basilisk II - 1 GB", "SheepShaver - 500 MB", "SheepShaver - 1 GB", "SheepShaver - 2 GB", "PearPC - 3 GB", "PearPC - 6 GB", "QEMU - 500 MB", "QEMU - 1 GB", "QEMU - 2 GB", "QEMU - 4 GB", "QEMU - 6 GB", "QEMU - 10 GB"})
        Me.DiskSizeDefaults.Location = New System.Drawing.Point(25, 93)
        Me.DiskSizeDefaults.Name = "DiskSizeDefaults"
        Me.DiskSizeDefaults.Size = New System.Drawing.Size(186, 21)
        Me.DiskSizeDefaults.TabIndex = 23
        '
        'frmNewDisk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.Wizard)
        Me.Controls.Add(Me.Welcome)
        Me.Controls.Add(Me.FormButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewDisk"
        Me.Text = "New Disk Wizard"
        Me.Welcome.ResumeLayout(False)
        Me.FormButtons.ResumeLayout(False)
        Me.Wizard.ResumeLayout(False)
        Me.CreateNew.ResumeLayout(False)
        Me.CreateNew.PerformLayout()
        Me.DescriptionContainer.ResumeLayout(False)
        Me.DescriptionContainer.PerformLayout()
        CType(Me.DiskSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Welcome As System.Windows.Forms.Panel
    Friend WithEvents WelcomeDescription As System.Windows.Forms.Label
    Friend WithEvents WelcomeTitle As System.Windows.Forms.Label
    Friend WithEvents FormButtons As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents Wizard As System.Windows.Forms.Panel
    Friend WithEvents CreateNew As System.Windows.Forms.Panel
    Friend WithEvents SaveMac As System.Windows.Forms.Button
    Friend WithEvents MacName As System.Windows.Forms.TextBox
    Friend WithEvents CreateNewDescription As System.Windows.Forms.Label
    Friend WithEvents DescriptionContainer As System.Windows.Forms.GroupBox
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents DescriptionName As System.Windows.Forms.Label
    Friend WithEvents DiskMBLabel As System.Windows.Forms.Label
    Friend WithEvents DiskSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents DiskSizeLabel As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents DiskSizeDefaults As System.Windows.Forms.ComboBox
End Class
