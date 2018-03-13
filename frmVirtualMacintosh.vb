Option Strict Off
Option Explicit On
Friend Class frmVirtualMacintosh
	Inherits System.Windows.Forms.Form
	
	Public Sub mnuActionCloseVM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionCloseVM.Click
		Me.Close()
	End Sub
	
	Public Sub mnuCDCapture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCDCapture.Click
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		BrowserOpen.Filter = "Disc Images (*.iso)|*.iso|All files (*.*)|*.*"
		BrowserOpen.ShowDialog()
		MsgBox(BrowserOpen.FileName)
	End Sub
	
	Public Sub mnuFloppyCapture_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFloppyCapture.Click
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		BrowserOpen.Filter = "Floppy Images (*.img;*.ima)|*.img;*.ima|All files (*.*)|*.*"
		BrowserOpen.ShowDialog()
		MsgBox(BrowserOpen.FileName)
	End Sub
	
	Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
		frmAbout.Show()
	End Sub

    Private Sub VMStatusBar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles VMStatusBar.ItemClicked

    End Sub

    Private Sub VMStatusBar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles VMStatusBar.Resize

    End Sub
End Class