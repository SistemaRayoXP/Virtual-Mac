Option Strict Off
Option Explicit On
Friend Class frmOptions
	Inherits System.Windows.Forms.Form
	Function SelectFolder(Optional ByRef DialogTitle As String = "", Optional ByRef IntialPath As Object = Nothing) As String
		Dim InitialPath As Object
		
		On Error GoTo errFunction
		
		Dim objShell As Object
		Dim objFolder As Object
		Dim Folder As Object
		
		objShell = CreateObject("Shell.Application")
		
		On Error Resume Next
		
		'UPGRADE_WARNING: Couldn't resolve default property of object objShell.BrowseForFolder. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        objFolder = objShell.BrowseForFolder(0, DialogTitle, 0, )
		
		'UPGRADE_WARNING: Couldn't resolve default property of object objFolder.Self. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Folder = objFolder.Self
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Folder.Path. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SelectFolder = Folder.Path
		
		Exit Function
		'Error Handler
errFunction: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		SelectFolder = vbNullString
		
	End Function
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub

    Private Sub BrowseFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowseFolder.Click

        FolderBrowser.ShowDialog()

        DefaultMacFolder.Text = FolderBrowser.SelectedPath

    End Sub

    Private Sub BrowseROM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrowseROM.Click

        BrowseOpen.Filter = "ROM File (*.rom)|*.rom|All files (*.*)|*.*"
        BrowseOpen.ShowDialog()
        If BrowseOpen.FileName = "" Then
            ROMFile.Text = "(No selected)"
        Else
            ROMFile.Text = BrowseOpen.FileName
        End If

    End Sub
End Class