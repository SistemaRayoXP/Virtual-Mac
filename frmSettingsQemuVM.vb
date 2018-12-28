Public Class frmSettingsQemuVM

    Private Sub frmSettingsQemuVM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadSettings()
    End Sub

    Public Sub LoadSettings()
        Dim x As String
        x = "qemu-system-ppc.exe -L pc-bios -boot d -m " _
        + 1024 + " -M mac99 -prom-env " & Chr(34) & "auto-boot?=true" & Chr(34) & " -prom-env " & Chr(34) & "boot-args=-v" & Chr(34) & " -prom-env " & Chr(34) & "vga-ndrv?=true" & Chr(34) & " -drive file=MacOS9.2.iso,format=raw,media=cdrom -drive file=MacOS9.2.img,format=raw,media=disk -sdl -netdev user,id=network01 -device sungem,netdev=network01 "

    End Sub
End Class