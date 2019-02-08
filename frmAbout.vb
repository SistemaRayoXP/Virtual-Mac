Option Strict Off
Option Explicit On
Friend Class frmAbout
    Inherits System.Windows.Forms.Form
    ' ; Note for me: The labels can confuse values with the declarations, rename them

    Private Sub EmaculationLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EmaculationLink.LinkClicked
        Process.Start("http://www.emaculation.com/doku.php")
    End Sub

    Private Sub ArmandoLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ArmandoLink.LinkClicked
        Process.Start("http://edsonarmando.000webhostapp.com")
    End Sub

    Private Sub frmAbout_ChangeUICues(sender As Object, e As System.Windows.Forms.UICuesEventArgs) Handles Me.ChangeUICues
        MsgBox(sender.ToString)
    End Sub

    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeUICulture(My.Settings.Lang)
        OSName.Text = SysInfo.OSName
        OSVersion.Text = SysInfo.OSBuild
        CPUType.Text = SysInfo.CPUClass
        CPUCores.Text = SysInfo.CPUCores
        RAMInstalled.Text = SysInfo.InstalledRAM
        CurrUsr.Text = SysInfo.UserName
        PCName.Text = SysInfo.ComputerName

        Dim AvailRAM As Long = (My.Computer.Info.AvailablePhysicalMemory / 1024) / 1024
        RAMAvailable.Text = AvailRAM & " MB"
    End Sub

    Private Sub AvailMemTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailMemTimer.Tick
        Dim AvailRAM As Long = (My.Computer.Info.AvailablePhysicalMemory / 1024) / 1024
        RAMAvailable.Text = AvailRAM & " MB"
    End Sub
End Class