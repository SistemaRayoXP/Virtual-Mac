Option Strict Off
Option Explicit On
Friend Class frmAbout
    Inherits System.Windows.Forms.Form
    ' : Some sidenotes to do:
    ' ; I've made many declarations here and in ApplicationEvents.vb because
    ' ; in this case I could't (or I didn't know how to) reuse declarations
    ' ; (Maybe inheritance, but I don't know how to use it, I'll check later)
    ' ; So to make it clear, in SetInfo() every argument is used as the value
    ' ; for its equivalent, example Proc (Of Proc-essor, not confuse with procedure)
    ' ; is set with CPU.
    '
    ' ; Note for me: The labels can confuse values with the declarations, rename them

    Private Sub EmaculationLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EmaculationLink.LinkClicked
        Process.Start("http://www.emaculation.com/doku.php")
    End Sub

    Private Sub ArmandoLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ArmandoLink.LinkClicked
        Process.Start("http://edsonarmando.000webhostapp.com")
    End Sub

    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetLabels()
        Dim AvailRAM As Long = (My.Computer.Info.AvailablePhysicalMemory / 1024) / 1024
        RAMAvailable.Text = AvailRAM & " MB"
    End Sub

    Public Sub SetLabels()
        OSName.Text = SysInfo.OSName
        OSVersion.Text = SysInfo.OSBuild
        CPUType.Text = SysInfo.CPUClass
        CPUCores.Text = SysInfo.CPUCores
        RAMInstalled.Text = SysInfo.InstalledRAM
        CurrUsr.Text = SysInfo.UserName
        PCName.Text = SysInfo.ComputerName
    End Sub

    Private Sub AvailMemTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvailMemTimer.Tick
        Dim AvailRAM As Long = (My.Computer.Info.AvailablePhysicalMemory / 1024) / 1024
        RAMAvailable.Text = AvailRAM & " MB"
    End Sub
End Class