Public Class frmNewDisk
    Private Sub frmNewDisk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetInitialData()
    End Sub

    Public Sub SetInitialData()
        DiskSizeDefaults.SelectedIndex = 0
        Welcome.BringToFront()
        Welcome.Visible = True
        Wizard.Visible = False
        EndWizard.Visible = False
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If Welcome.Visible = True Then
            If DiskPath.Text = "" Then
                cmdNext.Enabled = False
            Else
                cmdNext.Enabled = True
            End If

            SwitchPages(Welcome, Wizard)
            cmdBack.Enabled = True
            DiskPath.Focus()

            GoTo EndOfInstruction
        End If

        If DiskPath.Text <> "" And Wizard.Visible = True Then
            Dim SizeToGrow As Integer = FixControlHeight(EndDefPath, EndWizard, 30)
            EndDefSize.Top = EndDefSize.Top + SizeToGrow
            EndDefSizeLabel.Top = EndDefSizeLabel.Top + SizeToGrow
            EndInfoFinish.Top = EndInfoFinish.Top + SizeToGrow

            EndDefPath.Text = DiskPath.Text
            EndDefSize.Text = DiskSize.Value & " MB"

            SwitchPages(Wizard, EndWizard)
            cmdNext.Text = "Finish"

            GoTo EndOfInstruction
        End If

        If EndWizard.Visible = True Then
            CreateDiskInBackground.RunWorkerAsync(DiskSize.Value & ";" & DiskPath.Text)
            MsgBox("The image ''" & DiskPath.Text & "'' is being created in the background.", MsgBoxStyle.Exclamation, "Creating disk image")
            Me.Close()
            GoTo EndOfInstruction
        End If

EndOfInstruction:

    End Sub

    Public Function FixControlHeight(ByVal Control As System.Windows.Forms.Control, ByVal Parent As System.Windows.Forms.Control, ByVal LeftMargin As Long) As Integer
        'Parent - Control.Location = Total size of the area where is visible the control
        'Size of the area where the control should be - Margin = Are where we want the control to stay on
        'Note that this is only minding the Width/X growing the height, so a certain space is respected
        Dim StayArea As UInteger = ((Parent.Width - Control.Location.X) - LeftMargin)
        Dim StayAreaTimes As Integer
        Dim HeightGrowth As Integer
        Dim OldHeight As Integer = Control.Height

        If (Control.PreferredSize.Width) > StayArea Then
            If Not Control.Height > Control.PreferredSize.Height Then
                While (Control.PreferredSize.Width) > StayAreaTimes
                    StayAreaTimes = StayAreaTimes + StayArea
                End While
                StayAreaTimes -= StayArea
                Dim PercentageToGrow As Integer = StayAreaTimes / StayArea + 1
                HeightGrowth = OldHeight * PercentageToGrow
                Control.Height = HeightGrowth
            End If
        End If

        Return HeightGrowth

    End Function

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click

        If Wizard.Visible = True Then
            cmdBack.Enabled = False
            cmdNext.Enabled = True
            SwitchPages(Wizard, Welcome)
        End If

        If EndWizard.Visible = True Then
            SwitchPages(EndWizard, Wizard)
            cmdNext.Text = "Next >"
        End If

    End Sub

    Public Sub SwitchPages(ByVal EarlyPage As System.Windows.Forms.Panel, ByVal NewPage As System.Windows.Forms.Panel)
        EarlyPage.BringToFront()
        NewPage.Visible = True
        NewPage.BringToFront()
        EarlyPage.Visible = False
    End Sub

    Private Sub SaveDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDisk.Click
        Save.ShowDialog()
        If Save.FileName <> "" Then
            DiskPath.Text = Save.FileName
        End If
    End Sub

    Private Sub DiskPath_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiskPath.TextChanged
        If DiskPath.Text <> "" Then
            cmdNext.Enabled = True
        Else
            cmdNext.Enabled = False
        End If
    End Sub

    Private Sub CreateDiskInBackground_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles CreateDiskInBackground.DoWork
        Dim HDSize As Long = e.Argument.ToString.Substring(0, InStr(e.Argument.ToString, ";") - 1)
        Dim HDPath As String = e.Argument.ToString.Substring(InStr(e.Argument.ToString, ";"))
        DiskImageCreator.CreateRawDisk(HDSize, HDPath)
    End Sub
End Class