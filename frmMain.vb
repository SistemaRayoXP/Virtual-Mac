Option Strict Off
Option Explicit On
Friend Class frmMain
	Inherits System.Windows.Forms.Form
    'Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
	
	Public Sub RedrawList()
		On Error Resume Next
		
		
		'===Declarations===
		Dim retF As Integer 'To set the parent of the Frame
		Dim retS As Integer 'To set the parent of the VMSnap
		Dim i As Integer 'Used to identify the graphic being handled
		Dim x As Integer 'Used to know which and where was the last graphic
		Dim division As Integer
		
		'===Duplicate the items so we can have more than 1 machine at time===
		'Check how much items exist. The items are created as they exist in a
		'hidden list. Let's mean you made 2 VMs, then 2 items will be added to
		'this hidden list, and this Instruction called RedrawList will check how
		'much items you made, then it will draw the number of items (In this case, 2)
		'To do this, it will draw every item individually, and will repeat the
		'actions until it gets to all the items using a 'For' cycle
		
		For i = 1 To VMList.Items.Count
			
			x = i - 1
			
			'Load the right item (If  there are 3 items, we will load the fourth and so on)
			VM.Load(i)
			VMName.Load(i)
			VMDescription.Load(i)
			VMSnap.Load(i)
			
			'==Set the items to their respective parents==
			
			'Frame and PictureBox Parents
			retF = SetParent(VM(i).Handle.ToInt32, VMGraphicList.Handle.ToInt32)
			retS = SetParent(VMSnap(i).Handle.ToInt32, VM(i).Handle.ToInt32)
			
			'As these are labels, they need the container property (SetParent will not work on these)
			VMName(i).Parent = VM(i)
			VMDescription(i).Parent = VM(i)
			
			'===Set position properties for the items===
			
			'Machine List Item (The frame)
			VM(i).Visible = True
			VM(i).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(VM(x).Top) + VB6.PixelsToTwipsY(VM(0).Height))
			VM(i).Left = 0
			
			'Machine Name
			VMName(i).Visible = True
			VMName(i).Top = VMName(x).Top
			VMName(i).Left = VMName(x).Left
			VMName(i).Text = VB6.GetItemString(VMList, i - 1)
			
			'Machine Description (Status)
			VMDescription(i).Visible = True
			VMDescription(i).Top = VMDescription(x).Top
			VMDescription(i).Left = VMDescription(x).Left
			VMDescription(i).Text = "Not running"
			
			'Machine Picture Properties (When running, it will show a
			'screenshot of the machine screen)
			VMSnap(i).Visible = True
			VMSnap(i).Top = VMSnap(x).Top
			VMSnap(i).Left = VMSnap(x).Left
		Next 
		
		division = 915 * VM.Count / 183 - 5
		
		division = division - 15
		
		division = division * 1
		
		VMGraphicScroll.Minimum = 0
		VMGraphicScroll.Maximum = (division + VMGraphicScroll.LargeChange - 1)
		
		Select Case (VMGraphicScroll.Maximum - VMGraphicScroll.LargeChange + 1)
			Case -15
				VMGraphicScroll.Enabled = False
			Case -10
				VMGraphicScroll.Enabled = False
			Case -5
				VMGraphicScroll.Enabled = False
			Case 0
				VMGraphicScroll.Enabled = False
			Case Is > 0
				VMGraphicScroll.Enabled = True
		End Select
		
	End Sub
	
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        VirtualMacTray.Visible = True

        RedrawList()

    End Sub

    Private Sub frmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If Me.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then
            SaveSetting(My.Application.Info.Title, "Settings", "MainLeft", CStr(VB6.PixelsToTwipsX(Me.Left)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainTop", CStr(VB6.PixelsToTwipsY(Me.Top)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainWidth", CStr(VB6.PixelsToTwipsX(Me.Width)))
            SaveSetting(My.Application.Info.Title, "Settings", "MainHeight", CStr(VB6.PixelsToTwipsY(Me.Height)))
        End If

    End Sub

    Public Sub Start68kEmulation()

        MsgBox("Virtual Mac © " & "Beta. Virtualization isn't supported (again). Only fake OS X screen plus example stuff avaible")

        'Shell (App.Path & "\68k.exe"), vbNormalFocus
        frmVirtualMacintosh.Text = VMName(VMList.SelectedIndex + 1).Text & " - Virtual Mac"
        frmVirtualMacintosh.Show()

    End Sub

    Public Sub EnableButtons()

        mnuActionStart.Enabled = True
        'mnuActionPause.Enabled = True
        'mnuActionRestart.Enabled = True

        mnuActionRemove.Enabled = True
        mnuActionSettings.Enabled = True

        'mnuActionProperties.Enabled = True

        Settings.Enabled = True
        Remove.Enabled = True
        Start.Enabled = True

    End Sub

    Private Sub StartPPCEmulation()

        MsgBox("PPC.exe MUST be in the same directory as VirtualMac. Launching SheepShaver WITHOUT PREFS (Expect errors)", MsgBoxStyle.Information)

        Shell(My.Application.Info.DirectoryPath & "\PPC.exe", AppWinStyle.NormalFocus)

    End Sub

    Public Sub mnuActionRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionRemove.Click

        RemoveSelectedMac()

    End Sub

    Public Sub RemoveSelectedMac()

        'Declarations
        'UPGRADE_NOTE: Focused was upgraded to Focused_Renamed. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Focused_Renamed As Boolean
        Dim Answer As Short
        Dim x As Integer

        'Checks that you have a machine selected
        If VMList.SelectedIndex <> -1 Then
            Focused_Renamed = True
        End If

        'Asks you if you really want to delete the machine
        If Focused_Renamed = True Then
            Answer = MsgBox("You have choosen to remove '" & VB6.GetItemString(VMList, VMList.SelectedIndex) & "' from the Virtual Mac Console. Removing items from this list will not delete the .mcc or .dsk files from your physical computer. Do you want to remove this Virtual Mac from the Virtual Mac Console?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Virtual Mac")

            'If you don't want that old Mac Plus, this
            'is where it's deleted and recycled (Maybe)
            If Answer = 6 Then
                'First let's unload all the list items
                For x = 1 To VMList.Items.Count
                    VM(x).Visible = False
                    VMName(x).Visible = False
                    VMDescription(x).Visible = False
                    VMSnap(x).Visible = False
                    VMName.Unload(x)
                    VMDescription.Unload(x)
                    VMSnap.Unload(x)
                    VM.Unload(x)
                Next
                'Let's delete the item from the hidden list
                VMList.Items.RemoveAt(VMList.SelectedIndex)
                DisableButtons() 'Disable the buttons
                'And finally redraw (Reload) the items in the list
                RedrawList()
            End If

        End If

    End Sub

    Public Sub mnuActionSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionSettings.Click

        frmVMSettings.Text = "Settings for " & VB6.GetItemString(VMList, VMList.SelectedIndex)
        frmVMSettings.Show()

    End Sub

    Public Sub mnuActionStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActionStart.Click
        Start68kEmulation()
    End Sub

    Public Sub mnuFileOptions_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileOptions.Click
        frmOptions.Show()
    End Sub

    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
        End
    End Sub

    Public Sub mnuNewDisk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewDisk.Click
        frmNewDisk.Show()
    End Sub

    Public Sub mnuNewMac_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewMac.Click
        frmNewMac.Show()
    End Sub

    Private Sub NewMac_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NewMac.Click
        frmNewMac.Show()
    End Sub

    Private Sub Remove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Remove.Click

        RemoveSelectedMac()

    End Sub

    Private Sub Settings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Settings.Click

        OpenSettingsFor(VB6.GetItemString(VMList, VMList.SelectedIndex))

    End Sub

    Public Sub OpenSettingsFor(ByRef MacName As String)

        frmVMSettings.Text = "Settings for " & MacName
        frmVMSettings.Show()

    End Sub

    Private Sub Start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Start.Click
        Start68kEmulation()
    End Sub

    Public Sub DisableButtons()

        mnuActionStart.Enabled = False
        mnuActionPause.Enabled = False
        mnuActionRestart.Enabled = False
        mnuActionRemove.Enabled = False
        mnuActionSettings.Enabled = False
        mnuActionProperties.Enabled = False
        Settings.Enabled = False
        Remove.Enabled = False
        Start.Enabled = False

    End Sub

    Private Sub VM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VM.Click
        Dim Index As Short = VM.GetIndex(eventSender)
        '===Makes it look like you selected an object===
        'When you make a single click, you'll select the element

        'Declarations
        Dim x As Integer

        'This makes all the items 'un-select', in other words, makes them white
        For x = 1 To VMList.Items.Count
            VM(x).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        Next

        'This selects the current item
        VM(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000D)

        'Let's enable those buttons and select the
        'corresponding item in the hidden list
        EnableButtons()
        VMList.SelectedIndex = Index - 1

    End Sub

    Private Sub VM_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VM.DoubleClick
        Dim Index As Short = VM.GetIndex(eventSender)

        Start68kEmulation()

    End Sub

    Private Sub VMDescription_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMDescription.Click
        Dim Index As Short = VMDescription.GetIndex(eventSender)
        '===Makes it look like you selected an object===
        'When you make a single click, you'll select the element

        'Declarations
        Dim x As Integer

        'This makes all the items 'un-select', in other words, makes them white
        For x = 1 To VMList.Items.Count
            VM(x).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        Next

        'This selects the current item
        VM(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000D)

        'Let's enable those buttons and select the
        'corresponding item in the hidden list
        EnableButtons()
        VMList.SelectedIndex = Index - 1

    End Sub

    Private Sub VMDescription_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMDescription.DoubleClick
        Dim Index As Short = VMDescription.GetIndex(eventSender)

        Start68kEmulation()

    End Sub

    Private Sub VMGraphicList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMGraphicList.Click
        'To handle errors in execution time (And avoid that
        'the app will crash just because a human error)
        On Error GoTo ErrorHandler

        'Declarations
        Dim x As Integer

        If VMList.Items.Count > 0 Then
            DisableButtons()

            VMList.SelectedIndex = -1

            For x = 1 To VMList.Items.Count
                VM(x).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
            Next
        End If

ErrorHandler:
        If Err.Number <> 0 Then
            If Err.Number = 340 Then Resume Next

            If Not Err.Number = 340 Then
                MsgBox("Error '" & Err.Number & "' in execution time. " & Err.Description, MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    'UPGRADE_NOTE: VMGraphicScroll.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
    'UPGRADE_WARNING: VScrollBar event VMGraphicScroll.Change has a new behavior. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub VMGraphicScroll_Change(ByVal newScrollValue As Integer)
        '===Will make the top of the list items to go up and down===

        'Funny declarations (Maybe not funny...)
        Dim x As Integer
        Dim i As Integer

        'Let's place down every item

        'Let's check that we have more than 3 VMs so we can scroll
        If VM.Count > 4 Then
            'Start
            For x = 1 To VM.Count - 1

                i = 915 * x - 915

                VM(x).Top = VB6.TwipsToPixelsY(newScrollValue * 183 - i)

                VM(x).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(VM(x).Top) * -1)

            Next
            'End
        End If

    End Sub

    'UPGRADE_NOTE: VMGraphicScroll.Scroll was changed from an event to a procedure. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
    Private Sub VMGraphicScroll_Scroll_Renamed(ByVal newScrollValue As Integer)
        '===Will make the top of the list items to go up and down===

        'Funny declarations (Maybe not funny...)
        Dim x As Integer
        Dim i As Integer

        'Let's place down every item

        'Let's check that we have more than 3 VMs so we can scroll
        If VM.Count > 4 Then
            'Start
            For x = 1 To VM.Count - 1

                i = 915 * x - 915

                VM(x).Top = VB6.TwipsToPixelsY(newScrollValue * 183 - i)

                VM(x).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(VM(x).Top) * -1)

            Next
            'End
        End If

    End Sub

    'UPGRADE_WARNING: Event VMList.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub VMList_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMList.SelectedIndexChanged

        If VMList.SelectedIndex <> -1 Then
            EnableButtons()
        End If

    End Sub

    Private Sub VMList_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMList.Enter

        If VMList.SelectedIndex <> -1 Then
            EnableButtons()
        End If

    End Sub

    Private Sub VMName_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMName.Click
        Dim Index As Short = VMName.GetIndex(eventSender)
        '===Makes it look like you selected an object===
        'When you make a single click, you'll select the element

        'Declarations
        Dim x As Integer

        'This makes all the items 'un-select', in other words, makes them white
        For x = 1 To VMList.Items.Count
            VM(x).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        Next

        'This selects the current item
        VM(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000D)

        'Let's enable those buttons and select the
        'corresponding item in the hidden list
        EnableButtons()
        VMList.SelectedIndex = Index - 1

    End Sub

    Private Sub VMName_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMName.DoubleClick
        Dim Index As Short = VMName.GetIndex(eventSender)

        Start68kEmulation()


    End Sub

    Private Sub VMSnap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMSnap.Click
        Dim Index As Short = VMSnap.GetIndex(eventSender)
        '===Makes it look like you selected an object===
        'When you make a single click, you'll select the element

        'Declarations
        Dim x As Integer

        'This makes all the items 'un-select', in other words, makes them white
        For x = 1 To VMList.Items.Count
            VM(x).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        Next

        'This selects the current item
        VM(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000D)

        'Let's enable those buttons and select the
        'corresponding item in the hidden list
        EnableButtons()
        VMList.SelectedIndex = Index - 1

    End Sub

    Private Sub VMSnap_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VMSnap.DoubleClick
        Dim Index As Short = VMSnap.GetIndex(eventSender)

        Start68kEmulation()

    End Sub
    Private Sub VMGraphicScroll_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles VMGraphicScroll.Scroll
        Select Case eventArgs.Type
            Case System.Windows.Forms.ScrollEventType.ThumbTrack
                VMGraphicScroll_Scroll_Renamed(eventArgs.NewValue)
            Case System.Windows.Forms.ScrollEventType.EndScroll
                VMGraphicScroll_Change(eventArgs.NewValue)
        End Select
    End Sub

    Private Sub IconNewMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconNewMac.Click
        frmNewMac.Show()
    End Sub

    Private Sub IconNewDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconNewDisk.Click
        frmNewDisk.Show()
    End Sub

    Private Sub IconOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconOptions.Click
        frmOptions.Show()
    End Sub

    Private Sub IconExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IconExit.Click
        frmVirtualMacintosh.Close()
        frmNewMac.Close()
        frmNewDisk.Close()
        frmSplash.Close()
        frmVMSettings.Close()
        frmOptions.Close()
        frmAbout.Close()
        Me.Close()
    End Sub

    Private Sub ShowVMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowVMC.Click
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me.Show()
        Me.Focus()
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.ShowInTaskbar = False
            Me.Visible = False
        End If
    End Sub

    Private Sub VirtualMacTray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VirtualMacTray.MouseDoubleClick
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me.Show()
        Me.Focus()
    End Sub
End Class