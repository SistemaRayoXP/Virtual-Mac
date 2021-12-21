Option Strict Off
Option Explicit On
Friend Class frmVirtualMacintosh
	Inherits System.Windows.Forms.Form
	
    Public Sub mnuActionClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionClose.Click
        Me.Close()
    End Sub
	
    Public Sub mnuCDCapture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCDCapture.Click
        CDBrowser.ShowDialog()
        If CDBrowser.FileName <> "" Then
            MsgBox(CDBrowser.FileName)
            mnuCDRelease.Enabled = True
        End If
    End Sub

    Private Sub mnuCDRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCDRelease.Click
        CDBrowser.FileName = ""
        mnuCDRelease.Enabled = True
    End Sub

    Public Sub mnuFloppyCapture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFloppyCapture.Click
        FloppyBrowser.ShowDialog()
        If FloppyBrowser.FileName <> "" Then
            MsgBox(FloppyBrowser.FileName)
            mnuFloppyRelease.Enabled = True
        End If
    End Sub

    Private Sub mnuFloppyRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFloppyRelease.Click
        FloppyBrowser.FileName = ""
        mnuFloppyRelease.Enabled = True
    End Sub
	
    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub VMStatusBar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles VMStatusBar.ItemClicked

    End Sub

    Private Sub VMStatusBar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles VMStatusBar.Resize
        'Me.Width = VMStatusBar.Width +
    End Sub

    Private Sub frmVirtualMacintosh_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Close As Integer

        Close = frmVirtualMacintoshClose.ShowDialog()

        If Close = 2 Then
            e.Cancel = True
        Else
            Me.Visible = False
        End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class