Option Strict Off
Option Explicit On
Friend Class frmOptions
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        My.Settings.DefaultMacFolder = FolderNewMac.Text
        My.Settings.vMacROM = ROMvMac.Text
        My.Settings.BasiliskROM = ROMBII.Text
        My.Settings.SheepShaverROM = ROMSS.Text
        My.Settings.vMacPath = EPvMacPath.Text
        My.Settings.BasiliskPath = EPBIIPath.Text
        My.Settings.SheepShaverPath = EPSSPath.Text
        My.Settings.PearPCPath = EPPPCPath.Text
        My.Settings.QEMUPath = EPQEMUPath.Text
        My.Settings.VerifyEmulatorPaths = EPVerifyEmulatorPaths.Checked

        Select Case LangSelected.SelectedIndex
            Case 0
                My.Settings.Lang = "en-US"
            Case 1
                My.Settings.Lang = "de-DE"
            Case 2
                My.Settings.Lang = "es-MX"
        End Select

        If UCEnableTest.Checked = True Then
            My.Settings.TestWindow = True
        Else
            My.Settings.TestWindow = False
        End If
        My.Settings.Save()

        Me.Close()
    End Sub

    Private Sub BrowseFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FolderNewMacBrowse.Click
        If FolderBrowser.ShowDialog() = Forms.DialogResult.OK Then
            FolderNewMac.Text = FolderBrowser.SelectedPath
        End If
    End Sub

    Private Sub OptionsContainer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionContainer.SelectedIndexChanged
        ROMFrame.Visible = False
        FolderFrame.Visible = False
        UseContainerFrame.Visible = False
        EmulatorPathFrame.Visible = False
        LangFrame.Visible = False
        Select Case OptionContainer.FocusedItem.Index
            Case 0
                UseContainerFrame.Visible = True
            Case 1
                ROMFrame.Visible = True
            Case 2
                FolderFrame.Visible = True
            Case 3
                EmulatorPathFrame.Visible = True
            Case 4
                LangFrame.Visible = True
        End Select
    End Sub

    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ROMFileNames As String = System.IO.Path.GetFileName(My.Settings.vMacROM) & ", " & System.IO.Path.GetFileName(My.Settings.BasiliskROM) & ", " & System.IO.Path.GetFileName(My.Settings.SheepShaverROM)
        OptionContainer.Items(2).SubItems(1).Text = ROMFileNames
        OptionContainer.Items(3).SubItems(1).Text = My.Settings.DefaultMacFolder
        FolderAppCurrent.Text = My.Application.Info.DirectoryPath

        FolderNewMac.Text = My.Settings.DefaultMacFolder
        ROMvMac.Text = My.Settings.vMacROM
        ROMBII.Text = My.Settings.BasiliskROM
        ROMSS.Text = My.Settings.SheepShaverROM
        EPvMacPath.Text = My.Settings.vMacPath
        EPBIIPath.Text = My.Settings.BasiliskPath
        EPSSPath.Text = My.Settings.SheepShaverPath
        EPPPCPath.Text = My.Settings.PearPCPath
        EPQEMUPath.Text = My.Settings.QEMUPath
        EPVerifyEmulatorPaths.Checked = My.Settings.VerifyEmulatorPaths

        Select Case My.Settings.Lang
            Case "en-US"
                LangSelected.SelectedIndex = 0
            Case "de-DE"
                LangSelected.SelectedIndex = 1
            Case "es-MX"
                LangSelected.SelectedIndex = 2
        End Select

        If My.Settings.TestWindow = True Then
            UCEnableTest.Checked = True
        Else
            UCDisableTest.Checked = True
        End If
    End Sub

    Private Sub BrowseForFile(sender As System.Object, e As System.EventArgs) Handles EPvMacPathBrowse.Click, EPSSPathBrowse.Click, EPQEMUPathBrowse.Click, EPPPCPathBrowse.Click, EPBIIPathBrowse.Click, ROMvMacBrowse.Click, ROMSSBrowse.Click, ROMBIIBrowse.Click
        If BrowseOpen.ShowDialog = Forms.DialogResult.OK Then
            If ReferenceEquals(sender, EPvMacPathBrowse) = True Then
                EPvMacPath.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, EPBIIPathBrowse) = True Then
                EPBIIPath.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, EPSSPathBrowse) = True Then
                EPSSPath.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, EPPPCPathBrowse) = True Then
                EPPPCPath.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, EPQEMUPathBrowse) = True Then
                EPQEMUPath.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, ROMvMacBrowse) = True Then
                ROMvMac.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, ROMBIIBrowse) = True Then
                ROMBII.Text = BrowseOpen.FileName

            ElseIf ReferenceEquals(sender, ROMSSBrowse) = True Then
                ROMSS.Text = BrowseOpen.FileName
            Else
            End If
        End If
    End Sub

    Private Sub UseContainer_Status(sender As Object, e As System.EventArgs) Handles UCEnableTest.CheckedChanged, UCDisableTest.CheckedChanged
        If UCEnableTest.Checked = True Then
            OptionContainer.Items.Item(0).SubItems(1).Text = "Yes"
        Else
            OptionContainer.Items.Item(0).SubItems(1).Text = "No"
        End If
    End Sub
End Class