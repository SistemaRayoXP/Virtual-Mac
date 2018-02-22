VERSION 5.00
Object = "{DA729E34-689F-49EA-A856-B57046630B73}#1.0#0"; "CustomProgressBar.ocx"
Begin VB.Form frmSplash 
   BackColor       =   &H8000000A&
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   4845
   ClientLeft      =   45
   ClientTop       =   45
   ClientWidth     =   6315
   ControlBox      =   0   'False
   FillColor       =   &H8000000A&
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   27.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H8000000A&
   Icon            =   "frmSplash.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MouseIcon       =   "frmSplash.frx":000C
   MousePointer    =   99  'Custom
   Picture         =   "frmSplash.frx":015E
   ScaleHeight     =   4845
   ScaleWidth      =   6315
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin Proyecto2.XP_ProgressBar LoadingBar 
      CausesValidation=   0   'False
      Height          =   200
      Left            =   1950
      TabIndex        =   3
      TabStop         =   0   'False
      Top             =   4350
      Width           =   2415
      _ExtentX        =   4260
      _ExtentY        =   344
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BrushStyle      =   0
      Color           =   16744528
      Max             =   10000
      Scrolling       =   9
   End
   Begin VB.Timer BarLoader 
      Interval        =   1
      Left            =   360
      Top             =   0
   End
   Begin VB.Timer LoadingTimer 
      Interval        =   1000
      Left            =   0
      Top             =   0
   End
   Begin VB.Label Mac 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Mac"
      BeginProperty Font 
         Name            =   "David Transparent"
         Size            =   48
         Charset         =   177
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C06C3A&
      Height          =   975
      Left            =   3675
      TabIndex        =   2
      Top             =   2520
      Width           =   1725
   End
   Begin VB.Label Starting 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Starting..."
      BeginProperty Font 
         Name            =   "System"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2310
      TabIndex        =   1
      Top             =   4080
      Width           =   1695
   End
   Begin VB.Label Virtual 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Virtual"
      BeginProperty Font 
         Name            =   "David Transparent"
         Size            =   48
         Charset         =   177
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   915
      TabIndex        =   0
      Top             =   2520
      Width           =   2685
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Sub InitCommonControls Lib "comctl32" ()

Private Sub BarLoader_Timer()
Dim X As Integer

X = 0

For X = 0 To 5000
LoadingBar.Value = X
Next

BarLoader.Enabled = False

End Sub

Private Sub Form_Initialize()
InitCommonControls
End Sub

Private Sub Form_Load()

With LoadingBar

    LoadingBar.Max = 5000
    LoadingBar.Min = 0
    LoadingBar.Value = 0
    
End With

End Sub

Private Sub LoadingTimer_Timer()
Unload Me
frmMain.VirtualMacTrayIcon.PonerSystray
frmMain.Show
End Sub

