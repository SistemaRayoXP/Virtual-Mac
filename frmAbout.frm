VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Object = "{6FBA474E-43AC-11CE-9A0E-00AA0062BB4C}#1.0#0"; "SYSINFO.OCX"
Begin VB.Form frmAbout 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "About VirtualMac"
   ClientHeight    =   5025
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7620
   ClipControls    =   0   'False
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmAbout.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5025
   ScaleWidth      =   7620
   StartUpPosition =   1  'CenterOwner
   Tag             =   "1025"
   Begin TabDlg.SSTab AboutTab 
      Height          =   4815
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   7455
      _ExtentX        =   13150
      _ExtentY        =   8493
      _Version        =   393216
      Style           =   1
      Tabs            =   2
      Tab             =   1
      TabHeight       =   520
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      TabCaption(0)   =   "About"
      TabPicture(0)   =   "frmAbout.frx":000C
      Tab(0).ControlEnabled=   0   'False
      Tab(0).Control(0)=   "AboutPicture"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).ControlCount=   1
      TabCaption(1)   =   "Information"
      TabPicture(1)   =   "frmAbout.frx":0028
      Tab(1).ControlEnabled=   -1  'True
      Tab(1).Control(0)=   "SysInfoPicture"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "SysInfo"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).ControlCount=   2
      Begin VB.PictureBox AboutPicture 
         BorderStyle     =   0  'None
         Height          =   4420
         Left            =   -74970
         Picture         =   "frmAbout.frx":0044
         ScaleHeight     =   4425
         ScaleWidth      =   7395
         TabIndex        =   1
         Top             =   340
         Width           =   7400
         Begin VB.Label ProductNAV 
            BackStyle       =   0  'Transparent
            Caption         =   "Virtual Mac Technologies 0.1.2 Beta"
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
            TabIndex        =   7
            Top             =   1320
            Width           =   3615
         End
         Begin VB.Label Copyright 
            BackStyle       =   0  'Transparent
            Caption         =   "Copyright © 2018 Armando Technologies"
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
            TabIndex        =   6
            Top             =   1530
            Width           =   3615
         End
         Begin VB.Label LicenseType 
            BackStyle       =   0  'Transparent
            Caption         =   "Licensed under GNU GPL v2"
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
            TabIndex        =   5
            Top             =   1755
            Width           =   3135
         End
         Begin VB.Label WebSite 
            BackStyle       =   0  'Transparent
            Caption         =   "www.emaculation.com"
            Height          =   255
            Left            =   360
            TabIndex        =   4
            Top             =   2175
            Width           =   2775
         End
         Begin VB.Label ThirdPartyNotice 
            BackStyle       =   0  'Transparent
            Caption         =   "Portions of this Software:"
            Height          =   255
            Left            =   360
            TabIndex        =   3
            Top             =   2595
            Width           =   2775
         End
         Begin VB.Label Label2 
            BackStyle       =   0  'Transparent
            Caption         =   "Mini vMac © 2001-2018 The Gryphel Project"
            Height          =   255
            Left            =   360
            TabIndex        =   2
            Top             =   2835
            Width           =   6735
         End
      End
      Begin SysInfoLib.SysInfo SysInfo 
         Left            =   6840
         Top             =   360
         _ExtentX        =   1005
         _ExtentY        =   1005
         _Version        =   393216
      End
      Begin VB.PictureBox SysInfoPicture 
         BorderStyle     =   0  'None
         Height          =   4420
         Left            =   30
         Picture         =   "frmAbout.frx":1CA06
         ScaleHeight     =   4425
         ScaleWidth      =   7395
         TabIndex        =   8
         Top             =   340
         Width           =   7400
         Begin VB.Label TitleSys 
            BackStyle       =   0  'Transparent
            Caption         =   "System Information"
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
            TabIndex        =   13
            Top             =   1320
            Width           =   1815
         End
         Begin VB.Label OSNameTitle 
            BackStyle       =   0  'Transparent
            Caption         =   "Operating System:"
            Height          =   255
            Left            =   480
            TabIndex        =   12
            Top             =   1530
            Width           =   1815
         End
         Begin VB.Label OSName 
            BackStyle       =   0  'Transparent
            Caption         =   "Windows 9000"
            Height          =   255
            Left            =   3480
            TabIndex        =   11
            Top             =   1530
            Width           =   3615
         End
         Begin VB.Label OSVersion 
            BackStyle       =   0  'Transparent
            Caption         =   "90.5.4800"
            Height          =   255
            Left            =   3480
            TabIndex        =   10
            Top             =   1770
            Width           =   3615
         End
         Begin VB.Label OSVersionTitle 
            BackStyle       =   0  'Transparent
            Caption         =   "System Version:"
            Height          =   255
            Left            =   480
            TabIndex        =   9
            Top             =   1770
            Width           =   1815
         End
      End
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

SystemInformation

End Sub

Public Sub SystemInformation()

'Declarations
Dim Version As String
Dim Name As String
Dim Processor As String
Dim Features As String
Dim ProcNum As String
Dim ClockSpeed As String
Dim TotalMemory As Long
Dim AvaibleMemory As String


'Here you obtain the system info

Version = Replace(SysInfo.OSVersion, "0", "") & "." & SysInfo.OSBuild


'Naming the Windows OS by its version

Select Case SysInfo.OSVersion
Case 5.01
Name = "Windows XP"
Case 6#
Name = "Windows Vista"
Case 6.01
Name = "Windows 7"
End Select

'Assigning the info to the labels

OSName.Caption = Name
OSVersion.Caption = Version

End Sub
