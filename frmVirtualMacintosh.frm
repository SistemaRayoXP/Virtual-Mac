VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form frmVirtualMacintosh 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Macintosh - Virtual Mac"
   ClientHeight    =   7560
   ClientLeft      =   150
   ClientTop       =   840
   ClientWidth     =   10770
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmVirtualMacintosh.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   7560
   ScaleWidth      =   10770
   StartUpPosition =   3  'Windows Default
   Begin MSComDlg.CommonDialog Browser 
      Left            =   0
      Top             =   6840
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin ComctlLib.StatusBar VMStatusBar 
      Align           =   2  'Align Bottom
      Height          =   300
      Left            =   0
      TabIndex        =   1
      Top             =   7260
      Width           =   10770
      _ExtentX        =   18997
      _ExtentY        =   529
      SimpleText      =   ""
      _Version        =   327682
      BeginProperty Panels {0713E89E-850A-101B-AFC0-4210102A8DA7} 
         NumPanels       =   5
         BeginProperty Panel1 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Bevel           =   0
            Object.Width           =   529
            MinWidth        =   529
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel2 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            AutoSize        =   2
            Object.Width           =   529
            MinWidth        =   529
            Text            =   "2"
            TextSave        =   "2"
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel3 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Bevel           =   2
            Object.Width           =   529
            MinWidth        =   529
            Text            =   "3"
            TextSave        =   "3"
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel4 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Bevel           =   0
            Object.Width           =   529
            MinWidth        =   529
            Text            =   "4"
            TextSave        =   "4"
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel5 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            AutoSize        =   2
            Bevel           =   0
            Enabled         =   0   'False
            Object.Width           =   344
            MinWidth        =   353
            Text            =   "|"
            TextSave        =   "|"
            Object.Tag             =   ""
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.PictureBox VMScreen 
      Height          =   7335
      Left            =   0
      Picture         =   "frmVirtualMacintosh.frx":18BA
      ScaleHeight     =   7275
      ScaleWidth      =   10755
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   0
      Width           =   10815
   End
   Begin VB.Menu mnuAction 
      Caption         =   "Action"
      Begin VB.Menu mnuActionFullScreen 
         Caption         =   "Full Screen Mode"
         Enabled         =   0   'False
         Shortcut        =   %{BKSP}
      End
      Begin VB.Menu mnuActionBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuActionCloseVM 
         Caption         =   "Close"
      End
   End
   Begin VB.Menu mnuCD 
      Caption         =   "CD"
      Begin VB.Menu mnuCDCapture 
         Caption         =   "Capture ISO Image..."
      End
      Begin VB.Menu mnuCDBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuCDRelease 
         Caption         =   "Release CD"
         Enabled         =   0   'False
      End
   End
   Begin VB.Menu mnuFloppy 
      Caption         =   "Floppy"
      Begin VB.Menu mnuFloppyCapture 
         Caption         =   "Capture Floppy Disk Image..."
      End
      Begin VB.Menu mnuFloppyBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFloppyRelease 
         Caption         =   "Release Disk"
         Enabled         =   0   'False
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "Help"
      Begin VB.Menu mnuHelpContents 
         Caption         =   "Virtual Mac Help"
         Enabled         =   0   'False
      End
      Begin VB.Menu mnuHelpBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHelpOnline 
         Caption         =   "Virtual Mac Online"
         Enabled         =   0   'False
      End
      Begin VB.Menu mnuHelpBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "About Virtual Mac..."
      End
   End
End
Attribute VB_Name = "frmVirtualMacintosh"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub mnuActionCloseVM_Click()
Unload Me
End Sub

Private Sub mnuCDCapture_Click()
Browser.Filter = "Disc Images (*.iso)|*.iso|All files (*.*)|*.*"
Browser.ShowOpen
MsgBox Browser.FileName
End Sub

Private Sub mnuFloppyCapture_Click()
Browser.Filter = "Floppy Images (*.img;*.ima)|*.img;*.ima|All files (*.*)|*.*"
Browser.ShowOpen
MsgBox Browser.FileName
End Sub

Private Sub mnuHelpAbout_Click()
frmAbout.Show
End Sub

