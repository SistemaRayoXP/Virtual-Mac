Option Strict Off
Option Explicit On
Friend Class frmVMSettings
	Inherits System.Windows.Forms.Form
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close() 'Saves nothing and closes the dialog
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
SaveSettings: 
		'Save settings in a file
		
		Me.Close()
		
	End Sub
End Class