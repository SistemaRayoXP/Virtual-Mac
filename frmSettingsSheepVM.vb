Option Strict Off
Option Explicit On
Friend Class frmSettingsSheepVM
    Inherits System.Windows.Forms.Form
    Public Item As String
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close() 'Saves nothing and closes the dialog
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        SaveSettings(Item)
        Me.Close()
    End Sub

    Private Sub frmVMSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Save in a Label the item for which is the config for
        Item = frmMain.VMList.FocusedItem.Index

        'Load the settings from the Console
        LoadSettings(Item)

    End Sub

    Public Sub LoadSettings(ByVal Item As Integer)
        Dim HostRAM As Long = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024
        MemorySlider.Maximum = HostRAM
        MemorySlider.TickFrequency = HostRAM / 20

        Me.Text = "Settings for " & frmMain.VMList.Items.Item(Item).Text
        VMName.Text = frmMain.VMList.Items.Item(Item).Text
        For x As Integer = 0 To frmMain.MacIcons.Images.Count - 1
            Icons.Images.Add(x, frmMain.MacIcons.Images.Item(x))
            With IconList.Items.Add(x)
                .ImageIndex = x
            End With
        Next


        IconFrame.Visible = False
        VMNameFrame.Visible = False
        MiscFrame.Visible = False
        NetworkFrame.Visible = False
        MemoryFrame.Visible = False
        InputFrame.Visible = False
        DrivesFrame.Visible = False
        ScreenFrame.Visible = False
        SerialFrame.Visible = False

        VMName.Visible = True
        ModemPort.SelectedIndex = 0
        PrinterPort.SelectedIndex = 0

    End Sub

    Public Sub SaveSettings(ByVal Item As Integer)
        'Set the Text of the TextBox as the Mac name
        frmMain.VMList.Items.Item(Item).Text = VMName.Text
    End Sub

    Private Sub Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseIcon.Click
        If Browser.ShowDialog() = 1 Then
            Dim ImgName As String = System.IO.Path.GetFileNameWithoutExtension(Browser.FileName)
            Dim Img As System.Drawing.Image
            Img = Image.FromFile(Browser.FileName)
            frmMain.MacIcons.Images.Add(ImgName, Img)
            My.Settings.x = My.Settings.x & Browser.FileName & ","
            Icons.Images.Add(ImgName, Img)
            IconList.Items.Add(ImgName, Icons.Images.Count - 1)
            IconList.Items.Item(Icons.Images.Count - 1).Focused = True
        End If
    End Sub

    Private Sub MemorySlider_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles MemorySlider.Scroll
        Memory.Text = MemorySlider.Value
    End Sub

    Private Sub OptionsList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptionsList.SelectedIndexChanged
        IconFrame.Visible = False
        VMNameFrame.Visible = False
        MiscFrame.Visible = False
        NetworkFrame.Visible = False
        MemoryFrame.Visible = False
        InputFrame.Visible = False
        DrivesFrame.Visible = False
        ScreenFrame.Visible = False
        SerialFrame.Visible = False

        Select Case OptionsList.FocusedItem.Index
            Case 0
                VMNameFrame.Visible = True
            Case 1
                IconFrame.Visible = True
            Case 2
                MemoryFrame.Visible = True
            Case 3
                DrivesFrame.Visible = True
            Case 4
                NetworkFrame.Visible = True
            Case 5
                ScreenFrame.Visible = True
            Case 6
                InputFrame.Visible = True
            Case 7
                SerialFrame.Visible = True
            Case 8
                MiscFrame.Visible = True
        End Select
    End Sub

    Private Sub CustResolution_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustResolution.CheckedChanged
        If CustResolution.Checked = True Then
            VMResDef.Visible = False
            VMResWidth.Visible = True
            VMResHeight.Visible = True
        Else
            VMResDef.Visible = True
            VMResWidth.Visible = False
            VMResHeight.Visible = False
        End If
    End Sub

    Private Sub DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItem.Click
        DrivesList.Items.RemoveAt(DrivesList.SelectedIndex)
        DeleteItem.Enabled = False
    End Sub

    Private Sub AddDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDisk.Click
        Browser.ShowDialog()
        DrivesList.Items.Add(Browser.FileName)
    End Sub

    Private Sub AddCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCD.Click
        Browser.ShowDialog()
        DrivesList.Items.Add(Browser.FileName)
    End Sub

    Private Sub NetInterface_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetInterface.SelectedIndexChanged
        If NetInterface.SelectedIndex = 1 Then
            RouterPanel.Enabled = True
        Else
            RouterPanel.Enabled = False
        End If
    End Sub

    Private Sub Memory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Memory.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

    Private Sub Memory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Memory.TextChanged
        If Memory.Text > MemorySlider.Maximum Then
            MemorySlider.Value = MemorySlider.Maximum
        Else
            MemorySlider.Value = Memory.Text
        End If
    End Sub

    Private Sub PrinterPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrinterPort.SelectedIndexChanged
        If PrinterPort.SelectedIndex = 12 Then
            PrinterOutputFile.Enabled = True
        Else
            PrinterOutputFile.Enabled = False
        End If
    End Sub

    Private Sub ModemPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModemPort.SelectedIndexChanged
        If ModemPort.SelectedIndex = 12 Then
            ModemOutputFile.Enabled = True
        Else
            ModemOutputFile.Enabled = False
        End If
    End Sub
End Class