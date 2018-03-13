Option Strict Off
Option Explicit On
Friend Class frmNewDisk
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBack.Click
		
		If NewDisk2.Visible = True Then
			cmdBack.Enabled = False
			NewDisk2.Visible = False
			NewDiskWizard.Visible = False
			NewDisk1.Visible = True
			GoTo EndNext
		End If
		
		If NewDisk3.Visible = True Then
			NewDisk3.Visible = False
			Action.Text = "Disk Wizard"
			ActionDescription.Text = "You can create a new virtual disk for your Macintosh."
			NewDisk2.Visible = True
			GoTo EndNext
		End If
		
EndNext: 
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
    Private Sub cmdNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.Click

        If NewDisk1.Visible = True Then
            NewDisk1.Visible = False
            NewDiskWizard.Visible = True
            NewDisk2.Visible = True
            cmdBack.Enabled = True
            FixedDisk.Focus()
            GoTo EndNext
        End If

        If NewDisk2.Visible = True Then

        End If

EndNext:
    End Sub
	
	Private Sub NewDisk3Browse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NewDisk3Browse.Click
        Dim NewMac7VDName As Object = ""

		BrowseSave.Filter = "Virtual Disk Files (*.dsk;*.img;*.vhd)|*.dsk;*.img;*.vhd|All files (*.*)|*.*"
		BrowseSave.ShowDialog()
		NewMac7VDName.Text = BrowseSave.FileName
	End Sub
	
	Function VerifyKey(ByRef PressedKey As Object) As Object
		
		
		Dim AllowedKeys As String
		
		AllowedKeys = "1234567890" & Chr(System.Windows.Forms.Keys.Back)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object PressedKey. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If InStr(1, AllowedKeys, Chr(PressedKey)) Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object PressedKey. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object VerifyKey. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VerifyKey = PressedKey
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object VerifyKey. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VerifyKey = 0
		End If
		
		
	End Function
	
	'UPGRADE_WARNING: Event NewDisk3FileName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub NewDisk3FileName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NewDisk3FileName.TextChanged
		
		If NewDisk3FileName.Text = "" Then
			cmdNext.Enabled = False
		End If
		
	End Sub
End Class