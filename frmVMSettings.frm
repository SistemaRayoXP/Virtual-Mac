VERSION 5.00
Begin VB.Form frmVMSettings 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Settings for Macintosh"
   ClientHeight    =   5835
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   8865
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmVMSettings.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5835
   ScaleWidth      =   8865
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   320
      Left            =   7680
      TabIndex        =   1
      Top             =   5400
      Width           =   1095
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   320
      Left            =   6480
      TabIndex        =   0
      Top             =   5400
      Width           =   1095
   End
End
Attribute VB_Name = "frmVMSettings"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCancel_Click()
Unload Me 'Saves nothing and closes the dialog
End Sub

Private Sub cmdOK_Click()
SaveSettings:
'Save settings in a file

Unload Me

End Sub
