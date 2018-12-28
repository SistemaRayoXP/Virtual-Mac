Option Strict Off
Option Explicit On
Friend Class frmOptions
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        SaveSettings()
        Me.Close()
	End Sub

    Private Sub BrowseFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowseDefFolder.Click
        FolderBrowser.ShowDialog()
        DefaultMacFolder.Text = FolderBrowser.SelectedPath
    End Sub

    Private Sub OptionsContainer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsContainer.SelectedIndexChanged
        ROM.Visible = False
        Folders.Visible = False
        TestNewWindow.Visible = False
        Select Case OptionsContainer.FocusedItem.Index
            Case 0
                TestNewWindow.Visible = True
            Case 1
                'ShittyWindow.Visible = True
            Case 2
                ROM.Visible = True
            Case 3
                Folders.Visible = True
        End Select
    End Sub

    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadSettings()
    End Sub

    Public Sub LoadSettings()
        Dim ROMFileNames As String = System.IO.Path.GetFileName(My.Settings.vMacROM) & ", " & System.IO.Path.GetFileName(My.Settings.BasiliskROM) & ", " & System.IO.Path.GetFileName(My.Settings.SheepShaverROM)
        OptionsContainer.Items(2).SubItems(1).Text = ROMFileNames
        OptionsContainer.Items(3).SubItems(1).Text = My.Settings.DefaultMacFolder
        DefaultMacFolder.Text = My.Settings.DefaultMacFolder
        ProgramFolder.Text = My.Application.Info.DirectoryPath
        vMacROM.Text = My.Settings.vMacROM
        BIIROM.Text = My.Settings.BasiliskROM
        SSROM.Text = My.Settings.SheepShaverROM
        If My.Settings.TestWindow = True Then
            EnableTest.Checked = True
        Else
            DisableTest.Checked = True
        End If
    End Sub

    Public Sub SaveSettings()
        My.Settings.DefaultMacFolder = DefaultMacFolder.Text
        My.Settings.vMacROM = vMacROM.Text
        My.Settings.BasiliskROM = BIIROM.Text
        My.Settings.SheepShaverROM = SSROM.Text
        If EnableTest.Checked = True Then
            My.Settings.TestWindow = True
        Else
            My.Settings.TestWindow = False
        End If
    End Sub

    Private Sub BrowseSSROM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseSSROM.Click
        BrowseOpen.ShowDialog()
        If BrowseOpen.FileName <> "" Then
            Me.SSROM.Text = BrowseOpen.FileName
        End If
    End Sub

    Private Sub BrowseBIIROM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseBIIROM.Click
        BrowseOpen.ShowDialog()
        If BrowseOpen.FileName <> "" Then
            BIIROM.Text = BrowseOpen.FileName
        End If
    End Sub

    Private Sub BrowsevMacROM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowsevMacROM.Click
        BrowseOpen.ShowDialog()
        If BrowseOpen.FileName <> "" Then
            vMacROM.Text = BrowseOpen.FileName
        End If
    End Sub
End Class