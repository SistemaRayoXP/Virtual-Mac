VERSION 5.00
Object = "{E1742569-C6BE-4FBD-ADF3-F1DDD40BF642}#1.0#0"; "SysTray.ocx"
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Virtual Mac Console"
   ClientHeight    =   3030
   ClientLeft      =   150
   ClientTop       =   840
   ClientWidth     =   5295
   FillColor       =   &H8000000A&
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3030
   ScaleWidth      =   5295
   StartUpPosition =   3  'Windows Default
   Begin sysTray.Tray VirtualMacTrayIcon 
      Left            =   4725
      Top             =   2400
      _ExtentX        =   847
      _ExtentY        =   847
      ToolTipText     =   "Virtual Mac"
      IconPicture     =   "frmMain.frx":18BA
   End
   Begin VB.CommandButton Start 
      Caption         =   "Start"
      Default         =   -1  'True
      Enabled         =   0   'False
      Height          =   340
      Left            =   4000
      TabIndex        =   3
      Top             =   1575
      Width           =   1140
   End
   Begin VB.CommandButton Remove 
      Caption         =   "Remove"
      Enabled         =   0   'False
      Height          =   340
      Left            =   4000
      TabIndex        =   2
      Top             =   1000
      Width           =   1140
   End
   Begin VB.CommandButton Settings 
      Caption         =   "Settings"
      Enabled         =   0   'False
      Height          =   340
      Left            =   4000
      TabIndex        =   1
      Top             =   550
      Width           =   1140
   End
   Begin VB.CommandButton NewMac 
      Caption         =   "New..."
      Height          =   340
      Left            =   4000
      TabIndex        =   0
      Top             =   100
      Width           =   1140
   End
   Begin VB.PictureBox VMGraphicList 
      BackColor       =   &H00FFFFFF&
      Height          =   2775
      Left            =   120
      ScaleHeight     =   2715
      ScaleWidth      =   3675
      TabIndex        =   5
      Top             =   120
      Width           =   3735
      Begin VB.VScrollBar VMGraphicScroll 
         Enabled         =   0   'False
         Height          =   2715
         Left            =   3420
         Max             =   1
         TabIndex        =   10
         Top             =   0
         Width           =   260
      End
      Begin VB.Frame VM 
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         Height          =   915
         Index           =   0
         Left            =   0
         TabIndex        =   6
         Top             =   -915
         Width           =   3400
         Begin VB.PictureBox VMSnap 
            Height          =   640
            Index           =   0
            Left            =   120
            ScaleHeight     =   585
            ScaleWidth      =   795
            TabIndex        =   7
            Top             =   140
            Width           =   855
         End
         Begin VB.Label VMName 
            BackStyle       =   0  'Transparent
            Caption         =   "Example Name"
            Height          =   255
            Index           =   0
            Left            =   1200
            TabIndex        =   9
            Top             =   120
            Width           =   2295
         End
         Begin VB.Label VMDescription 
            BackStyle       =   0  'Transparent
            Caption         =   "Not running"
            Height          =   255
            Index           =   0
            Left            =   1200
            TabIndex        =   8
            Top             =   480
            Width           =   2295
         End
      End
   End
   Begin VB.ListBox VMList 
      Height          =   2790
      ItemData        =   "frmMain.frx":3184
      Left            =   120
      List            =   "frmMain.frx":3186
      TabIndex        =   4
      Top             =   120
      Width           =   3735
   End
   Begin VB.Menu mnuFile 
      Caption         =   "File"
      Begin VB.Menu mnuNewMac 
         Caption         =   "New Mac Wizard"
      End
      Begin VB.Menu mnuNewDisk 
         Caption         =   "New Disk Wizard"
      End
      Begin VB.Menu mnuFileBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileOptions 
         Caption         =   "Options"
      End
      Begin VB.Menu mnuFileBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileExit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnuAction 
      Caption         =   "Action"
      Begin VB.Menu mnuActionStart 
         Caption         =   "Start"
      End
      Begin VB.Menu mnuActionBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuActionPause 
         Caption         =   "Pause"
         Enabled         =   0   'False
      End
      Begin VB.Menu mnuActionRestart 
         Caption         =   "Restart"
         Enabled         =   0   'False
      End
      Begin VB.Menu mnuActionBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuActionRemove 
         Caption         =   "Remove"
      End
      Begin VB.Menu mnuActionBar2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuActionSettings 
         Caption         =   "Settings"
      End
      Begin VB.Menu mnuActionProperties 
         Caption         =   "Properties"
         Enabled         =   0   'False
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "Help"
      Begin VB.Menu mnuHelpContents 
         Caption         =   "Virtual Mac Help"
      End
      Begin VB.Menu mnuHelpSearchForHelpOn 
         Caption         =   "Online Help"
      End
      Begin VB.Menu mnuHelpBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "About Virtual Mac..."
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function SetParent _
    Lib "user32" ( _
            ByVal hWndChild As Long, _
            ByVal hWndNewParent As Long) As Long
Private Declare Function OSWinHelp% Lib "user32" Alias "WinHelpA" (ByVal hwnd&, ByVal HelpFile$, ByVal wCommand%, dwData As Any)

Public Sub RedrawList()
On Error Resume Next


'===Declarations===
Dim retF As Long 'To set the parent of the Frame
Dim retS As Long 'To set the parent of the VMSnap
Dim i As Long 'Used to identify the graphic being handled
Dim X As Long 'Used to know which and where was the last graphic

'===Duplicate the items so we can have more than 1 machine at time===
'Check how much items exist. The items are created as they exist in a
'hidden list. Let's mean you made 2 VMs, then 2 items will be added to
'this hidden list, and this Instruction called RedrawList will check how
'much items you made, then it will draw the number of items (In this case, 2)
'To do this, it will draw every item individually, and will repeat the
'actions until it gets to all the items using a 'For' cycle

For i = 1 To VMList.ListCount
    
    X = i - 1
    
    'Load the right item (If  there are 3 items, we will load the fourth and so on)
        Load VM(i)
        Load VMName(i)
        Load VMDescription(i)
        Load VMSnap(i)
        
    '==Set the items to their respective parents==
    
    'Frame and PictureBox Parents
        retF = SetParent(VM(i).hwnd, VMGraphicList.hwnd)
        retS = SetParent(VMSnap(i).hwnd, VM(i).hwnd)
    
    'As these are labels, they need the container property (SetParent will not work on these)
        Set VMName(i).Container = VM(i)
        Set VMDescription(i).Container = VM(i)
        
    '===Set position properties for the items===
    
    'Machine List Item (The frame)
        VM(i).Visible = True
        VM(i).Top = VM(X).Top + VM(0).Height
        VM(i).Left = 0
        
    'Machine Name
        VMName(i).Visible = True
        VMName(i).Top = VMName(X).Top
        VMName(i).Left = VMName(X).Left
        VMName(i).Caption = VMList.List(i - 1)
    
    'Machine Description (Status)
        VMDescription(i).Visible = True
        VMDescription(i).Top = VMDescription(X).Top
        VMDescription(i).Left = VMDescription(X).Left
        VMDescription(i).Caption = "Not running"
    
    'Machine Picture Properties (When running, it will show a
    'screenshot of the machine screen)
        VMSnap(i).Visible = True
        VMSnap(i).Top = VMSnap(X).Top
        VMSnap(i).Left = VMSnap(X).Left
Next

End Sub

Private Sub Form_GotFocus()
'===Bug fix===
'There was a bug that made the Main form to show prior
'to the New Mac Wizard when there were no machines
'and New Mac Wizard showed up automatically

If VMList.ListCount = 0 Then
    If frmNewMac.Visible = True Then
    frmNewMac.Show
    End If
End If

End Sub

Private Sub Form_Load()

If VMList.ListCount = 0 Then
    frmNewMac.Show
    frmNewMac.SetFocus
End If

RedrawList

End Sub

Private Sub Form_Terminate()
VirtualMacTrayIcon.RemoverSystray
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Dim i As Integer
    
    'close all sub forms
    For i = Forms.Count - 1 To 1 Step -1
        Unload Forms(i)
    Next
    If Me.WindowState <> vbMinimized Then
        SaveSetting App.Title, "Settings", "MainLeft", Me.Left
        SaveSetting App.Title, "Settings", "MainTop", Me.Top
        SaveSetting App.Title, "Settings", "MainWidth", Me.Width
        SaveSetting App.Title, "Settings", "MainHeight", Me.Height
    End If
    
frmMain.VirtualMacTrayIcon.RemoverSystray

End Sub

Public Sub Start68kEmulation()

'MsgBox "VirtualMac © Beta 0.1.2. Only Motorola 68000 emulation supported (68k.exe must be same as Virtual Mac Directory)", vbInformation

MsgBox "Virtual Mac © 0.1.2 Beta. Virtualization isn't supported (again). Only fake OS X screen plus example stuff avaible"

'Shell (App.Path & "\68k.exe"), vbNormalFocus
frmVirtualMacintosh.Show

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

MsgBox "PPC.exe MUST be in the same directory as VirtualMac. Launching SheepShaver WITHOUT PREFS (Expect errors)", vbInformation

Shell (App.Path & "\PPC.exe"), vbNormalFocus

End Sub

Private Sub mnuActionRemove_Click()

RemoveSelectedMac

End Sub

Public Sub RemoveSelectedMac()

'Declarations
Dim Focused As Boolean
Dim Answer As Integer
Dim X As Long

'Checks that you have a machine selected
If VMList.ListIndex <> -1 Then
    Focused = True
End If

'Asks you if you really want to delete the machine
If Focused = True Then
    Answer = MsgBox("You have choosen to remove '" & VMList.List(VMList.ListIndex) & "' from the Virtual Mac Console. Removing items from this list will not delete the .mcc or .dsk files from your physical computer. Do you want to remove this Virtual Mac from the Virtual Mac Console?", vbExclamation + vbYesNo, "Virtual Mac")
    
    'If you don't want that old Mac Plus, this
    'is where it's deleted and recycled (Maybe)
    If Answer = 6 Then
            'First let's unload all the list items
                For X = 1 To VMList.ListCount
                    VM(X).Visible = False
                    VMName(X).Visible = False
                    VMDescription(X).Visible = False
                    VMSnap(X).Visible = False
                    Unload VMName(X)
                    Unload VMDescription(X)
                    Unload VMSnap(X)
                    Unload VM(X)
                Next
            'Let's delete the item from the hidden list
            VMList.RemoveItem VMList.ListIndex
        DisableButtons 'Disable the buttons
        'And finally redraw (Reload) the items in the list
        RedrawList
    End If
    
End If

End Sub

Private Sub mnuActionSettings_Click()

frmVMSettings.Caption = "Settings for " & VMList.List(VMList.ListIndex)
frmVMSettings.Show

End Sub

Private Sub mnuActionStart_Click()
Start68kEmulation
End Sub

Private Sub mnuFileOptions_Click()
    frmOptions.Show
End Sub

Private Sub mnuHelpAbout_Click()
    frmAbout.Show
End Sub

Private Sub mnuHelpSearchForHelpOn_Click()
    Dim nRet As Integer


    'si no hay archivo de ayuda para este proyecto, mostrar un mensaje al usuario
    'puede establecer el archivo de Ayuda para su aplicación en el cuadro
    'de diálogo Propiedades del proyecto
    If Len(App.HelpFile) = 0 Then
        MsgBox "Cannot show help contents. There is no help content avaible (yet)", vbInformation, Me.Caption
    Else
        On Error Resume Next
        nRet = OSWinHelp(Me.hwnd, App.HelpFile, 261, 0)
        If Err Then
            MsgBox Err.Description
        End If
    End If

End Sub

Private Sub mnuHelpContents_Click()
    Dim nRet As Integer

    'si no hay archivo de ayuda para este proyecto, mostrar un mensaje al usuario
    'puede establecer el archivo de Ayuda para la aplicación en el cuadro
    'de diálogo Propiedades del proyecto
    If Len(App.HelpFile) = 0 Then
        MsgBox "Cannot show help contents. There is no help content avaible (yet)", vbInformation, Me.Caption
    Else
        On Error Resume Next
        nRet = OSWinHelp(Me.hwnd, App.HelpFile, 3, 0)
        If Err Then
            MsgBox Err.Description
        End If
    End If

End Sub

Private Sub mnuFileExit_Click()
    Unload Me
    End
End Sub

Private Sub mnuNewDisk_Click()
frmNewDisk.Show
End Sub

Private Sub mnuNewMac_Click()
frmNewMac.Show
End Sub

Private Sub NewMac_Click()
frmNewMac.Show
End Sub

Private Sub Remove_Click()

RemoveSelectedMac

End Sub

Private Sub Settings_Click()

OpenSettingsFor VMList.List(VMList.ListIndex)

End Sub

Public Sub OpenSettingsFor(MacName As String)

frmVMSettings.Caption = "Settings for " & MacName
frmVMSettings.Show

End Sub

Private Sub Start_Click()
Start68kEmulation
End Sub

Private Sub VirtualMacTrayIcon_DblClick(Button As Integer)
MsgBox "XDR"
'frmMain.ShowInTaskbar = True

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

Private Sub VM_Click(Index As Integer)
'===Makes it look like you selected an object===
'When you make a single click, you'll select the element

'Declarations
Dim X As Long

'This makes all the items 'un-select', in other words, makes them white
For X = 1 To VMList.ListCount
VM(X).BackColor = &HFFFFFF
Next

'This selects the current item
VM(Index).BackColor = &H8000000D

'Let's enable those buttons and select the
'corresponding item in the hidden list
EnableButtons
VMList.ListIndex = Index - 1

End Sub

Private Sub VM_DblClick(Index As Integer)

Start68kEmulation

End Sub

Private Sub VMDescription_Click(Index As Integer)
'===Makes it look like you selected an object===
'When you make a single click, you'll select the element

'Declarations
Dim X As Long

'This makes all the items 'un-select', in other words, makes them white
For X = 1 To VMList.ListCount
VM(X).BackColor = &HFFFFFF
Next

'This selects the current item
VM(Index).BackColor = &H8000000D

'Let's enable those buttons and select the
'corresponding item in the hidden list
EnableButtons
VMList.ListIndex = Index - 1

End Sub

Private Sub VMDescription_DblClick(Index As Integer)

Start68kEmulation

End Sub

Private Sub VMGraphicList_Click()
'To handle errors in execution time (And avoid that
'the app will crash just because a human error)
On Error GoTo ErrorHandler

'Declarations
Dim X As Long

If VMList.ListCount > 0 Then
    DisableButtons
    
    VMList.ListIndex = -1
    
    For X = 1 To VMList.ListCount
    VM(X).BackColor = &HFFFFFF
    Next
End If

ErrorHandler:
If Err.Number <> 0 Then
    If Err.Number = 340 Then Resume Next
    
    If Not Err.Number = 340 Then
        MsgBox "Error '" & Err.Number & "' in execution time. " & Err.Description, vbExclamation
    End If
End If
End Sub

Private Sub VMGraphicScroll_Change()
'===Will make the top of the list items to go up and down===

'Funny declarations (Maybe not funny...)
'Dim X As Long
'Dim Sum As Long

'Sum = VM(0) * VM.Count

'Let's place down every item
'For X = 1 To Sum

'Next

End Sub

Private Sub VMList_Click()

    If VMList.ListIndex <> -1 Then
        EnableButtons
    End If

End Sub

Private Sub VMList_GotFocus()

    If VMList.ListIndex <> -1 Then
        EnableButtons
    End If

End Sub

Private Sub VMName_Click(Index As Integer)
'===Makes it look like you selected an object===
'When you make a single click, you'll select the element

'Declarations
Dim X As Long

'This makes all the items 'un-select', in other words, makes them white
For X = 1 To VMList.ListCount
VM(X).BackColor = &HFFFFFF
Next

'This selects the current item
VM(Index).BackColor = &H8000000D

'Let's enable those buttons and select the
'corresponding item in the hidden list
EnableButtons
VMList.ListIndex = Index - 1

End Sub

Private Sub VMName_DblClick(Index As Integer)

Start68kEmulation


End Sub

Private Sub VMSnap_Click(Index As Integer)
'===Makes it look like you selected an object===
'When you make a single click, you'll select the element

'Declarations
Dim X As Long

'This makes all the items 'un-select', in other words, makes them white
For X = 1 To VMList.ListCount
VM(X).BackColor = &HFFFFFF
Next

'This selects the current item
VM(Index).BackColor = &H8000000D

'Let's enable those buttons and select the
'corresponding item in the hidden list
EnableButtons
VMList.ListIndex = Index - 1

End Sub

Private Sub VMSnap_DblClick(Index As Integer)

Start68kEmulation

End Sub
