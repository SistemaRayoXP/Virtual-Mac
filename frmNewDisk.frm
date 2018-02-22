VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmNewDisk 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "New Mac Wizard"
   ClientHeight    =   5415
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7455
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00FFFFFF&
   Icon            =   "frmNewDisk.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5415
   ScaleWidth      =   7455
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame NewDisk1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Caption         =   "NewMac1"
      Height          =   4695
      Left            =   0
      TabIndex        =   4
      Top             =   0
      Width           =   7455
      Begin VB.PictureBox WizardStart 
         BackColor       =   &H00404040&
         BorderStyle     =   0  'None
         Height          =   4695
         Left            =   0
         Picture         =   "frmNewDisk.frx":18BA
         ScaleHeight     =   4695
         ScaleWidth      =   2460
         TabIndex        =   5
         Top             =   0
         Width           =   2460
      End
      Begin VB.Label TitleStart 
         BackStyle       =   0  'Transparent
         Caption         =   "Welcome to the Virtual Disk Wizard"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2640
         TabIndex        =   7
         Top             =   240
         Width           =   4575
      End
      Begin VB.Label DescriptionStart 
         BackStyle       =   0  'Transparent
         Caption         =   $"frmNewDisk.frx":27476
         Height          =   1215
         Left            =   2640
         TabIndex        =   6
         Top             =   960
         Width           =   4695
      End
   End
   Begin VB.Frame NewDiskWizard 
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      Height          =   4695
      Left            =   0
      TabIndex        =   8
      Top             =   0
      Visible         =   0   'False
      Width           =   7455
      Begin VB.Frame NewDisk2 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   22
         Top             =   840
         Visible         =   0   'False
         Width           =   7455
         Begin VB.PictureBox NewDisk2ButtonFixer 
            Height          =   4215
            Left            =   -120
            ScaleHeight     =   4155
            ScaleWidth      =   7515
            TabIndex        =   27
            TabStop         =   0   'False
            Top             =   -160
            Width           =   7575
            Begin VB.OptionButton EditVirtualDisk 
               Caption         =   "Edit an existing virtual disk"
               Height          =   255
               Left            =   720
               TabIndex        =   36
               Top             =   1500
               Visible         =   0   'False
               Width           =   4095
            End
            Begin VB.OptionButton DiscImage 
               Caption         =   "Create a disc image"
               Height          =   255
               Left            =   720
               TabIndex        =   35
               Top             =   1200
               Width           =   4815
            End
            Begin VB.OptionButton FloppyDisk 
               Caption         =   "Create a floppy disk"
               Height          =   255
               Left            =   720
               TabIndex        =   29
               Top             =   900
               Width           =   4815
            End
            Begin VB.OptionButton FixedDisk 
               Caption         =   "Create a fixed disk"
               Height          =   255
               Left            =   720
               TabIndex        =   28
               Top             =   600
               Value           =   -1  'True
               Width           =   4815
            End
            Begin VB.Label Label4 
               Caption         =   "Select an option:"
               Height          =   255
               Left            =   600
               TabIndex        =   30
               Top             =   270
               Width           =   2175
            End
         End
      End
      Begin VB.Frame NewDisk3 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   23
         Top             =   840
         Visible         =   0   'False
         Width           =   7215
         Begin VB.CommandButton NewDisk3Browse 
            Caption         =   "Browse..."
            Height          =   340
            Left            =   5760
            TabIndex        =   25
            Top             =   615
            Width           =   1095
         End
         Begin VB.TextBox NewDisk3FileName 
            Height          =   285
            Left            =   680
            TabIndex        =   24
            Top             =   645
            Width           =   4935
         End
         Begin VB.Label NewVDTitleHelp 
            Caption         =   "Name and location:"
            Height          =   255
            Left            =   675
            TabIndex        =   26
            Top             =   270
            Width           =   1695
         End
      End
      Begin VB.Frame Top 
         BackColor       =   &H00FFFFFF&
         Height          =   975
         Left            =   0
         TabIndex        =   31
         Top             =   -120
         Width           =   7455
         Begin VB.PictureBox WizardPictureSmall 
            Height          =   800
            Left            =   6600
            Picture         =   "frmNewDisk.frx":27663
            ScaleHeight     =   735
            ScaleWidth      =   735
            TabIndex        =   32
            Top             =   140
            Width           =   800
         End
         Begin VB.Label Action 
            BackStyle       =   0  'Transparent
            Caption         =   "Disk Options"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   360
            TabIndex        =   34
            Top             =   225
            Width           =   5175
         End
         Begin VB.Label ActionDescription 
            BackStyle       =   0  'Transparent
            Caption         =   "You can create a new virtual disk for your Macintosh."
            Height          =   375
            Left            =   600
            TabIndex        =   33
            Top             =   465
            Width           =   5175
         End
      End
      Begin VB.Frame NewMacFromExist 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   9
         Top             =   840
         Visible         =   0   'False
         Width           =   7215
         Begin VB.TextBox FileNameA 
            Height          =   285
            IMEMode         =   3  'DISABLE
            Left            =   600
            TabIndex        =   17
            Text            =   "New Mac"
            Top             =   840
            Width           =   5055
         End
         Begin VB.CommandButton BrowseA 
            Caption         =   "Browse..."
            Height          =   340
            Left            =   5760
            TabIndex        =   10
            Top             =   825
            Width           =   1095
         End
         Begin VB.Label FileNameTitleA 
            Caption         =   "Name and location:"
            Height          =   255
            Left            =   600
            TabIndex        =   12
            Top             =   600
            Width           =   1815
         End
         Begin VB.Label HelpA 
            BackStyle       =   0  'Transparent
            Caption         =   "Specify the .mcc file you want to add to the Virtual Mac Console."
            Height          =   255
            Left            =   600
            TabIndex        =   11
            Top             =   240
            Width           =   5775
         End
      End
   End
   Begin VB.Frame NewDiskEnd 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Caption         =   "NewMac1"
      Height          =   4695
      Left            =   0
      TabIndex        =   13
      Top             =   0
      Visible         =   0   'False
      Width           =   7455
      Begin VB.CheckBox OpenSettingsAfterFinish 
         BackColor       =   &H00FFFFFF&
         Caption         =   "When I click Finish, open Settings."
         Height          =   375
         Left            =   2680
         TabIndex        =   19
         Top             =   3060
         Value           =   1  'Checked
         Width           =   4215
      End
      Begin VB.PictureBox WizardEnd 
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         Height          =   4695
         Left            =   0
         Picture         =   "frmNewDisk.frx":292FB
         ScaleHeight     =   4695
         ScaleWidth      =   2460
         TabIndex        =   14
         Top             =   0
         Width           =   2460
      End
      Begin VB.Label AdviceClickFinish 
         BackStyle       =   0  'Transparent
         Caption         =   "To close this wizard, click Finish."
         Height          =   255
         Left            =   2680
         TabIndex        =   21
         Top             =   3480
         Width           =   3135
      End
      Begin VB.Label AdviceNoHD 
         BackStyle       =   0  'Transparent
         Caption         =   "Before you can install an operating system on this Virtual Mac, you must add a virtual hard disk to it."
         Height          =   495
         Left            =   2640
         TabIndex        =   20
         Top             =   1800
         Visible         =   0   'False
         Width           =   4095
      End
      Begin VB.Label VMName 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Height          =   435
         Left            =   2640
         TabIndex        =   18
         Top             =   1200
         Width           =   4695
         WordWrap        =   -1  'True
      End
      Begin VB.Label DescriptionEnd 
         BackStyle       =   0  'Transparent
         Caption         =   "You have completed succefully the New Virtual Mac Wizard and have named your Mac:"
         Height          =   495
         Left            =   2640
         TabIndex        =   16
         Top             =   720
         Width           =   3975
      End
      Begin VB.Label TitleEnd 
         BackStyle       =   0  'Transparent
         Caption         =   "Completing the New Virtual Mac Wizard"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2640
         TabIndex        =   15
         Top             =   240
         Width           =   4575
      End
   End
   Begin MSComDlg.CommonDialog Browse 
      Left            =   120
      Top             =   4800
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame ControlBox 
      Height          =   835
      Left            =   0
      TabIndex        =   3
      Top             =   4620
      Width           =   7455
      Begin VB.CommandButton cmdCancel 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   340
         Left            =   6200
         TabIndex        =   2
         Top             =   300
         Width           =   1095
      End
      Begin VB.CommandButton cmdNext 
         Caption         =   "Next >"
         Default         =   -1  'True
         Height          =   340
         Left            =   4920
         TabIndex        =   0
         Top             =   300
         Width           =   1095
      End
      Begin VB.CommandButton cmdBack 
         Caption         =   "< Back"
         Enabled         =   0   'False
         Height          =   340
         Left            =   3810
         TabIndex        =   1
         ToolTipText     =   "Atras"
         Top             =   300
         Width           =   1095
      End
   End
End
Attribute VB_Name = "frmNewDisk"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdBack_Click()

If NewDisk2.Visible = True Then
    cmdBack.Enabled = False
    NewDisk2.Visible = False
    NewDiskWizard.Visible = False
    NewDisk1.Visible = True
    GoTo EndNext
End If

If NewDisk3.Visible = True Then
    NewDisk3.Visible = False
    Action.Caption = "Disk Wizard"
    ActionDescription.Caption = "You can create a new virtual disk for your Macintosh."
    NewDisk2.Visible = True
    GoTo EndNext
End If

EndNext:
End Sub

Private Sub cmdCancel_Click()
    Unload Me
    frmMain.Show
End Sub

Private Sub cmdNext_Click()
Dim VDisk As Long

If NewDisk1.Visible = True Then
    NewDisk1.Visible = False
    NewDiskWizard.Visible = True
    NewDisk2.Visible = True
    cmdBack.Enabled = True
    GoTo EndNext
End If

If NewDisk2.Visible = True Then
    
End If

EndNext:
End Sub

Private Sub NewDisk3Browse_Click()
Browse.Filter = "Virtual Disk Files (*.dsk;*.img;*.vhd)|*.dsk;*.img;*.vhd|All files (*.*)|*.*"
Browse.ShowSave
NewMac7VDName.Text = Browse.FileName
End Sub

Function VerifyKey(PressedKey)
    
    
Dim AllowedKeys As String
    
    AllowedKeys = "1234567890" & Chr(vbKeyBack)
    
    If InStr(1, AllowedKeys, Chr(PressedKey)) Then
        
        VerifyKey = PressedKey
    Else
        VerifyKey = 0
    End If
    

End Function

Private Sub NewDisk3FileName_Change()

If NewDisk3FileName.Text = "" Then
    cmdNext.Enabled = False
End If

End Sub
