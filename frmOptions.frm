VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmOptions 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Options"
   ClientHeight    =   5850
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   8565
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H8000000F&
   Icon            =   "frmOptions.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5850
   ScaleWidth      =   8565
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Tag             =   "1017"
   Begin MSComDlg.CommonDialog Browse 
      Left            =   4440
      Top             =   3600
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame OptionsContainer 
      Caption         =   "Virtual Mac Options"
      Height          =   5535
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   4215
      Begin VB.ListBox OptionsList 
         Height          =   5325
         ItemData        =   "frmOptions.frx":000C
         Left            =   0
         List            =   "frmOptions.frx":0016
         TabIndex        =   9
         Top             =   240
         Width           =   4215
      End
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   320
      Left            =   6045
      TabIndex        =   0
      Tag             =   "1024"
      Top             =   5280
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   320
      Left            =   7260
      TabIndex        =   1
      Tag             =   "1023"
      Top             =   5280
      Width           =   1095
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3780
      Index           =   3
      Left            =   -20000
      ScaleHeight     =   3840.968
      ScaleMode       =   0  'User
      ScaleWidth      =   5745.64
      TabIndex        =   3
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample4 
         Caption         =   "Ejemplo 4"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2022
         Left            =   505
         TabIndex        =   7
         Tag             =   "1021"
         Top             =   502
         Width           =   2033
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3780
      Index           =   2
      Left            =   -20000
      ScaleHeight     =   3840.968
      ScaleMode       =   0  'User
      ScaleWidth      =   5745.64
      TabIndex        =   5
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample3 
         Caption         =   "Ejemplo 3"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2022
         Left            =   406
         TabIndex        =   6
         Tag             =   "1020"
         Top             =   403
         Width           =   2033
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3780
      Index           =   1
      Left            =   -20000
      ScaleHeight     =   3840.968
      ScaleMode       =   0  'User
      ScaleWidth      =   5745.64
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample2 
         Caption         =   "Ejemplo 2"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2022
         Left            =   307
         TabIndex        =   4
         Tag             =   "1019"
         Top             =   305
         Width           =   2033
      End
   End
   Begin VB.Frame Folders 
      Caption         =   "Folders"
      Height          =   3255
      Left            =   4560
      TabIndex        =   13
      Top             =   120
      Visible         =   0   'False
      Width           =   3735
      Begin VB.CommandButton BrowseFolder 
         Caption         =   "Browse..."
         Height          =   320
         Left            =   120
         TabIndex        =   16
         Top             =   840
         Width           =   975
      End
      Begin VB.TextBox DefaultMacFolder 
         Height          =   285
         Left            =   120
         Locked          =   -1  'True
         TabIndex        =   14
         Text            =   "C:\Documents and settings\Edson Armando\Mis documentos\My Macs"
         Top             =   480
         Width           =   3495
      End
      Begin VB.Label DefFolderTitle 
         Caption         =   "Default Mac Folder"
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   240
         Width           =   1575
      End
   End
   Begin VB.Frame ROM 
      Caption         =   "ROM"
      Height          =   3255
      Left            =   4560
      TabIndex        =   10
      Top             =   120
      Visible         =   0   'False
      Width           =   3735
      Begin VB.TextBox ROMFile 
         Height          =   285
         Left            =   120
         Locked          =   -1  'True
         TabIndex        =   12
         Top             =   360
         Width           =   3735
      End
      Begin VB.CommandButton BrowseROM 
         Caption         =   "Browse..."
         Height          =   320
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   1000
      End
   End
End
Attribute VB_Name = "frmOptions"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Function SelectFolder(Optional DialogTitle As String, _
                        Optional IntialPath As Variant) As String
  
On Local Error GoTo errFunction
      
    Dim objShell As Object
    Dim objFolder As Object
    Dim Folder As Object
    
    Set objShell = CreateObject("Shell.Application")
      
    On Error Resume Next
    
    Set objFolder = objShell.BrowseForFolder( _
                            0, _
                            DialogTitle, _
                            0, _
                            InitialPath)
      
    Set Folder = objFolder.Self

    SelectFolder = Folder.Path
  
Exit Function
'Error Handler
errFunction:
    MsgBox Err.Description, vbCritical
    SelectFolder = vbNullString
  
End Function

Private Sub BrowseFolder_Click()
Dim Folder As String

Folder = SelectFolder

DefaultMacFolder.Text = Folder

End Sub

Private Sub BrowseROM_Click()

Browse.Filter = "ROM File (*.rom)|*.rom|All files (*.*)|*.*"
Browse.ShowOpen
If Browse.FileName = "" Then
ROMFile.Text = "(No selected)"
Else
ROMFile.Text = Browse.FileName
End If

End Sub

Private Sub cmdCancel_Click()
Unload Me
End Sub

Private Sub cmdOK_Click()
Unload Me
End Sub

Private Sub Form_Load()
OptionsList.ListIndex = 0

If DefaultMacFolder.Text = "" Then
DefaultMacFolder.Text = "(No selected)"
End If

End Sub

Private Sub OptionsList_Click()

If Browse.FileName = "" Then
ROMFile.Text = "(No selected)"
End If

Select Case OptionsList.ListIndex

Case 0
ROM.Visible = True
Folders.Visible = False

Case 1
ROM.Visible = False
Folders.Visible = True

End Select

End Sub
