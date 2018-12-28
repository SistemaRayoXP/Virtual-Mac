<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsvMacVM
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Name", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Icon", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Drives", ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!))
        Me.OptionPanel = New System.Windows.Forms.Panel
        Me.IconFrame = New System.Windows.Forms.GroupBox
        Me.BrowseIcon = New System.Windows.Forms.Button
        Me.IconDescription = New System.Windows.Forms.Label
        Me.IconList = New System.Windows.Forms.ListView
        Me.DrivesFrame = New System.Windows.Forms.GroupBox
        Me.DrivesList = New System.Windows.Forms.ListBox
        Me.MoveItemDown = New System.Windows.Forms.Button
        Me.MoveItemUp = New System.Windows.Forms.Button
        Me.AddDisk = New System.Windows.Forms.Button
        Me.AddCD = New System.Windows.Forms.Button
        Me.DeleteItem = New System.Windows.Forms.Button
        Me.VMNameFrame = New System.Windows.Forms.GroupBox
        Me.VMNameHelp = New System.Windows.Forms.Label
        Me.VMName = New System.Windows.Forms.TextBox
        Me.OptionList = New System.Windows.Forms.ListView
        Me.Options = New System.Windows.Forms.ColumnHeader
        Me.Value = New System.Windows.Forms.ColumnHeader
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.OptionPanel.SuspendLayout()
        Me.IconFrame.SuspendLayout()
        Me.DrivesFrame.SuspendLayout()
        Me.VMNameFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionPanel
        '
        Me.OptionPanel.Controls.Add(Me.IconFrame)
        Me.OptionPanel.Controls.Add(Me.DrivesFrame)
        Me.OptionPanel.Controls.Add(Me.VMNameFrame)
        Me.OptionPanel.Location = New System.Drawing.Point(371, 1)
        Me.OptionPanel.Name = "OptionPanel"
        Me.OptionPanel.Size = New System.Drawing.Size(373, 294)
        Me.OptionPanel.TabIndex = 29
        '
        'IconFrame
        '
        Me.IconFrame.Controls.Add(Me.BrowseIcon)
        Me.IconFrame.Controls.Add(Me.IconDescription)
        Me.IconFrame.Controls.Add(Me.IconList)
        Me.IconFrame.Location = New System.Drawing.Point(0, 3)
        Me.IconFrame.Name = "IconFrame"
        Me.IconFrame.Size = New System.Drawing.Size(367, 279)
        Me.IconFrame.TabIndex = 3
        Me.IconFrame.TabStop = False
        Me.IconFrame.Text = "Icon"
        '
        'BrowseIcon
        '
        Me.BrowseIcon.Location = New System.Drawing.Point(286, 12)
        Me.BrowseIcon.Name = "BrowseIcon"
        Me.BrowseIcon.Size = New System.Drawing.Size(75, 23)
        Me.BrowseIcon.TabIndex = 6
        Me.BrowseIcon.Text = "Browse..."
        Me.BrowseIcon.UseVisualStyleBackColor = True
        '
        'IconDescription
        '
        Me.IconDescription.Location = New System.Drawing.Point(6, 17)
        Me.IconDescription.Name = "IconDescription"
        Me.IconDescription.Size = New System.Drawing.Size(261, 18)
        Me.IconDescription.TabIndex = 7
        Me.IconDescription.Text = "If you want an icon that isn't in the list, click Browse."
        '
        'IconList
        '
        Me.IconList.Location = New System.Drawing.Point(9, 38)
        Me.IconList.Name = "IconList"
        Me.IconList.Size = New System.Drawing.Size(352, 235)
        Me.IconList.TabIndex = 6
        Me.IconList.UseCompatibleStateImageBehavior = False
        '
        'DrivesFrame
        '
        Me.DrivesFrame.Controls.Add(Me.DrivesList)
        Me.DrivesFrame.Controls.Add(Me.MoveItemDown)
        Me.DrivesFrame.Controls.Add(Me.MoveItemUp)
        Me.DrivesFrame.Controls.Add(Me.AddDisk)
        Me.DrivesFrame.Controls.Add(Me.AddCD)
        Me.DrivesFrame.Controls.Add(Me.DeleteItem)
        Me.DrivesFrame.Location = New System.Drawing.Point(0, 3)
        Me.DrivesFrame.Name = "DrivesFrame"
        Me.DrivesFrame.Size = New System.Drawing.Size(367, 279)
        Me.DrivesFrame.TabIndex = 8
        Me.DrivesFrame.TabStop = False
        Me.DrivesFrame.Text = "Drives"
        '
        'DrivesList
        '
        Me.DrivesList.FormattingEnabled = True
        Me.DrivesList.Items.AddRange(New Object() {"C:\Users\Usuario\Documents\ISOs\Mac OS 8.5 Spanish.iso", "C:\Users\Usuario\Documents\My Macs\Mac OS 8\Mac OS 8.dsk", "C:\Users\Usuario\Documents\My Macs\Mac OS 8\Data.dsk"})
        Me.DrivesList.Location = New System.Drawing.Point(3, 17)
        Me.DrivesList.Name = "DrivesList"
        Me.DrivesList.Size = New System.Drawing.Size(358, 186)
        Me.DrivesList.TabIndex = 6
        '
        'MoveItemDown
        '
        Me.MoveItemDown.Enabled = False
        Me.MoveItemDown.Location = New System.Drawing.Point(328, 213)
        Me.MoveItemDown.Name = "MoveItemDown"
        Me.MoveItemDown.Size = New System.Drawing.Size(33, 23)
        Me.MoveItemDown.TabIndex = 5
        Me.MoveItemDown.Text = "\/"
        Me.MoveItemDown.UseVisualStyleBackColor = True
        '
        'MoveItemUp
        '
        Me.MoveItemUp.Enabled = False
        Me.MoveItemUp.Location = New System.Drawing.Point(294, 213)
        Me.MoveItemUp.Name = "MoveItemUp"
        Me.MoveItemUp.Size = New System.Drawing.Size(33, 23)
        Me.MoveItemUp.TabIndex = 4
        Me.MoveItemUp.Text = "/\"
        Me.MoveItemUp.UseVisualStyleBackColor = True
        '
        'AddDisk
        '
        Me.AddDisk.Location = New System.Drawing.Point(6, 213)
        Me.AddDisk.Name = "AddDisk"
        Me.AddDisk.Size = New System.Drawing.Size(56, 23)
        Me.AddDisk.TabIndex = 3
        Me.AddDisk.Text = "Add disk"
        Me.AddDisk.UseVisualStyleBackColor = True
        '
        'AddCD
        '
        Me.AddCD.Location = New System.Drawing.Point(68, 213)
        Me.AddCD.Name = "AddCD"
        Me.AddCD.Size = New System.Drawing.Size(56, 23)
        Me.AddCD.TabIndex = 2
        Me.AddCD.Text = "Add CD"
        Me.AddCD.UseVisualStyleBackColor = True
        '
        'DeleteItem
        '
        Me.DeleteItem.Location = New System.Drawing.Point(130, 213)
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.Size = New System.Drawing.Size(90, 23)
        Me.DeleteItem.TabIndex = 1
        Me.DeleteItem.Text = "Delete selected"
        Me.DeleteItem.UseVisualStyleBackColor = True
        '
        'VMNameFrame
        '
        Me.VMNameFrame.Controls.Add(Me.VMNameHelp)
        Me.VMNameFrame.Controls.Add(Me.VMName)
        Me.VMNameFrame.Location = New System.Drawing.Point(0, 3)
        Me.VMNameFrame.Name = "VMNameFrame"
        Me.VMNameFrame.Size = New System.Drawing.Size(367, 279)
        Me.VMNameFrame.TabIndex = 4
        Me.VMNameFrame.TabStop = False
        Me.VMNameFrame.Text = "Name"
        '
        'VMNameHelp
        '
        Me.VMNameHelp.Location = New System.Drawing.Point(6, 17)
        Me.VMNameHelp.Name = "VMNameHelp"
        Me.VMNameHelp.Size = New System.Drawing.Size(363, 18)
        Me.VMNameHelp.TabIndex = 7
        Me.VMNameHelp.Text = "Do you want a change? Why not start with the name?"
        '
        'VMName
        '
        Me.VMName.Location = New System.Drawing.Point(9, 38)
        Me.VMName.Name = "VMName"
        Me.VMName.Size = New System.Drawing.Size(352, 20)
        Me.VMName.TabIndex = 6
        '
        'OptionList
        '
        Me.OptionList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Options, Me.Value})
        Me.OptionList.FullRowSelect = True
        Me.OptionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.OptionList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.OptionList.Location = New System.Drawing.Point(12, 11)
        Me.OptionList.Name = "OptionList"
        Me.OptionList.Size = New System.Drawing.Size(353, 376)
        Me.OptionList.TabIndex = 28
        Me.OptionList.UseCompatibleStateImageBehavior = False
        Me.OptionList.View = System.Windows.Forms.View.Details
        '
        'Options
        '
        Me.Options.Text = "Options"
        Me.Options.Width = 173
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 176
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(665, 366)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 22)
        Me.cmdCancel.TabIndex = 27
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(585, 366)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 22)
        Me.cmdOK.TabIndex = 26
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'frmSettingsvMacVM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 400)
        Me.Controls.Add(Me.OptionPanel)
        Me.Controls.Add(Me.OptionList)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsvMacVM"
        Me.Text = "Settings for %s"
        Me.OptionPanel.ResumeLayout(False)
        Me.IconFrame.ResumeLayout(False)
        Me.DrivesFrame.ResumeLayout(False)
        Me.VMNameFrame.ResumeLayout(False)
        Me.VMNameFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OptionPanel As System.Windows.Forms.Panel
    Friend WithEvents IconFrame As System.Windows.Forms.GroupBox
    Friend WithEvents BrowseIcon As System.Windows.Forms.Button
    Friend WithEvents IconDescription As System.Windows.Forms.Label
    Friend WithEvents IconList As System.Windows.Forms.ListView
    Friend WithEvents DrivesFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DrivesList As System.Windows.Forms.ListBox
    Friend WithEvents MoveItemDown As System.Windows.Forms.Button
    Friend WithEvents MoveItemUp As System.Windows.Forms.Button
    Friend WithEvents AddDisk As System.Windows.Forms.Button
    Friend WithEvents AddCD As System.Windows.Forms.Button
    Friend WithEvents DeleteItem As System.Windows.Forms.Button
    Friend WithEvents VMNameFrame As System.Windows.Forms.GroupBox
    Friend WithEvents VMNameHelp As System.Windows.Forms.Label
    Friend WithEvents VMName As System.Windows.Forms.TextBox
    Friend WithEvents OptionList As System.Windows.Forms.ListView
    Friend WithEvents Options As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
End Class
