VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form frmNewMac 
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
   Icon            =   "frmNewMac.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5415
   ScaleWidth      =   7455
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame NewMac1 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Height          =   4695
      Left            =   0
      TabIndex        =   8
      Top             =   0
      Width           =   7455
      Begin VB.PictureBox WizardStart 
         BackColor       =   &H00404040&
         BorderStyle     =   0  'None
         Height          =   4695
         Left            =   0
         Picture         =   "frmNewMac.frx":18BA
         ScaleHeight     =   4695
         ScaleWidth      =   2460
         TabIndex        =   9
         TabStop         =   0   'False
         Top             =   0
         Width           =   2460
      End
      Begin VB.Label TitleStart 
         BackStyle       =   0  'Transparent
         Caption         =   "Welcome to the New Virtual Macintosh Wizard"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Left            =   2640
         TabIndex        =   11
         Top             =   240
         Width           =   4575
      End
      Begin VB.Label DescriptionStart 
         BackStyle       =   0  'Transparent
         Caption         =   $"frmNewMac.frx":27476
         Height          =   1335
         Left            =   2640
         TabIndex        =   10
         Top             =   1080
         Width           =   4695
      End
   End
   Begin VB.Frame NewMacWizard 
      BorderStyle     =   0  'None
      Caption         =   "Frame1"
      Height          =   4695
      Left            =   0
      TabIndex        =   12
      Top             =   0
      Visible         =   0   'False
      Width           =   7455
      Begin VB.Frame NewMac2 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   17
         Top             =   840
         Visible         =   0   'False
         Width           =   7215
         Begin VB.PictureBox NewMac2ButtonFixer 
            Height          =   4215
            Left            =   -120
            ScaleHeight     =   4155
            ScaleWidth      =   7395
            TabIndex        =   30
            TabStop         =   0   'False
            Top             =   -240
            Width           =   7455
            Begin VB.OptionButton CreateNew 
               Caption         =   "Create a Virtual Macintosh Machine"
               Height          =   375
               Left            =   880
               TabIndex        =   31
               Top             =   700
               Value           =   -1  'True
               Width           =   5175
            End
            Begin VB.OptionButton UseDefaults 
               Caption         =   "Use default settings to create a Virtual Mac"
               Height          =   375
               Left            =   880
               TabIndex        =   32
               Top             =   1580
               Width           =   5175
            End
            Begin VB.OptionButton AddExist 
               Caption         =   "Add an existing Virtual Mac"
               Height          =   375
               Left            =   880
               TabIndex        =   33
               Top             =   2640
               Width           =   5175
            End
            Begin VB.Label HelpSelect 
               Caption         =   "Select an option:"
               Height          =   255
               Left            =   720
               TabIndex        =   47
               Top             =   420
               Width           =   2295
            End
            Begin VB.Label NewDescription2 
               BackStyle       =   0  'Transparent
               Caption         =   "This option guides you throught the basic configurations neccesary for creating a new Virtual Macintosh Machine."
               Height          =   495
               Left            =   1140
               TabIndex        =   36
               Top             =   1060
               Width           =   6135
            End
            Begin VB.Label UseDefaultsDescription2 
               BackStyle       =   0  'Transparent
               Caption         =   $"frmNewMac.frx":27687
               Height          =   615
               Left            =   1140
               TabIndex        =   35
               Top             =   1940
               Width           =   5895
            End
            Begin VB.Label AddExistDescription2 
               Caption         =   "You can add a Virtual Macintosh Machine to the Virtual Mac Console from existing .mcc files."
               Height          =   375
               Left            =   1140
               TabIndex        =   34
               Top             =   3000
               Width           =   6015
            End
         End
      End
      Begin VB.Frame NewMac5 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   55
         Top             =   840
         Visible         =   0   'False
         Width           =   7455
         Begin VB.PictureBox NewMac5ButtonFixer 
            Height          =   4095
            Left            =   -120
            ScaleHeight     =   4035
            ScaleWidth      =   7515
            TabIndex        =   56
            TabStop         =   0   'False
            Top             =   -120
            Width           =   7575
            Begin VB.Frame RAMAdjuster 
               BorderStyle     =   0  'None
               Height          =   1095
               Left            =   840
               TabIndex        =   57
               Top             =   2280
               Visible         =   0   'False
               Width           =   6135
               Begin ComctlLib.Slider RAMAdjust 
                  Height          =   495
                  Left            =   320
                  TabIndex        =   3
                  TabStop         =   0   'False
                  Top             =   460
                  Width           =   4780
                  _ExtentX        =   8440
                  _ExtentY        =   873
                  _Version        =   327682
                  LargeChange     =   4
                  SmallChange     =   2
                  Max             =   1000
                  TickFrequency   =   50
               End
               Begin VB.TextBox RAMMegabyteNumber 
                  Alignment       =   1  'Right Justify
                  Height          =   315
                  Left            =   5280
                  TabIndex        =   2
                  TabStop         =   0   'False
                  Text            =   "128"
                  Top             =   495
                  Width           =   495
               End
               Begin VB.Label MegaByte 
                  Caption         =   "MB"
                  Height          =   255
                  Left            =   5805
                  TabIndex        =   59
                  Top             =   540
                  Width           =   255
               End
               Begin VB.Label RAMDescription 
                  Caption         =   "Set the RAM for this Macintosh:"
                  Height          =   255
                  Left            =   120
                  TabIndex        =   58
                  Top             =   120
                  Width           =   2415
               End
            End
            Begin VB.OptionButton Recommend 
               Caption         =   "Using the recomended RAM"
               Height          =   255
               Left            =   840
               TabIndex        =   0
               Top             =   1680
               Value           =   -1  'True
               Width           =   4815
            End
            Begin VB.OptionButton Adjust 
               Caption         =   "Ajusting the RAM"
               Height          =   255
               Left            =   840
               TabIndex        =   1
               Top             =   2040
               Width           =   4815
            End
            Begin VB.Label RecRAM 
               Caption         =   "Recommended RAM [128 MB]"
               Height          =   255
               Left            =   720
               TabIndex        =   62
               Top             =   1080
               Width           =   2295
            End
            Begin VB.Label RAMHelpTitle 
               Caption         =   "Allocate RAM for this Mac by:"
               Height          =   255
               Left            =   720
               TabIndex        =   61
               Top             =   1440
               Width           =   2175
            End
            Begin VB.Label RAMHelp 
               Caption         =   $"frmNewMac.frx":2776B
               Height          =   855
               Left            =   720
               TabIndex        =   60
               Top             =   360
               Width           =   6135
            End
         End
      End
      Begin VB.Frame NewMac3 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   18
         Top             =   840
         Visible         =   0   'False
         Width           =   7215
         Begin VB.TextBox FileNameC 
            Height          =   285
            Left            =   480
            TabIndex        =   42
            Text            =   "New Mac"
            Top             =   1560
            Width           =   5175
         End
         Begin VB.CommandButton BrowseC 
            Caption         =   "Browse..."
            Height          =   340
            Left            =   5760
            TabIndex        =   19
            Top             =   1530
            Width           =   1095
         End
         Begin VB.Label FileNameTitleC 
            Caption         =   "Name and location:"
            Height          =   255
            Left            =   480
            TabIndex        =   21
            Top             =   1320
            Width           =   1695
         End
         Begin VB.Label HelpC 
            Caption         =   $"frmNewMac.frx":27858
            Height          =   855
            Left            =   480
            TabIndex        =   20
            Top             =   240
            Width           =   6495
         End
      End
      Begin VB.Frame NewMac6 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   70
         Top             =   840
         Visible         =   0   'False
         Width           =   7215
         Begin VB.TextBox DiskSizeMB 
            Alignment       =   1  'Right Justify
            Height          =   285
            Left            =   3120
            TabIndex        =   77
            Text            =   "1024"
            Top             =   2260
            Width           =   735
         End
         Begin VB.CommandButton NewVDBrowse 
            Caption         =   "Browse..."
            Height          =   340
            Left            =   5760
            TabIndex        =   72
            Top             =   1460
            Width           =   1095
         End
         Begin VB.TextBox NewMac7VDName 
            Height          =   285
            Left            =   680
            TabIndex        =   71
            Top             =   1480
            Width           =   4935
         End
         Begin VB.Label WarningLowerSize 
            Caption         =   "Please enter a size value between 4 MB and 130,557 MB."
            Height          =   255
            Left            =   720
            TabIndex        =   81
            Top             =   2640
            Visible         =   0   'False
            Width           =   4335
         End
         Begin VB.Label VDInfoAboutVD 
            Caption         =   "To learn more about virtual disks, see Virtual Mac Help. For advanced virtual hard disk options, use the Virtual Disk Wizard."
            Height          =   495
            Left            =   720
            TabIndex        =   80
            Top             =   3120
            Width           =   6375
         End
         Begin VB.Label VDInfoMaxMBSize 
            Caption         =   "130,557 MB"
            Height          =   255
            Left            =   3260
            TabIndex        =   79
            Top             =   1920
            Width           =   975
         End
         Begin VB.Label VDMBInfo 
            Caption         =   "MB"
            Height          =   255
            Left            =   3900
            TabIndex        =   78
            Top             =   2280
            Width           =   255
         End
         Begin VB.Label MaxVDSize 
            Caption         =   "Maxium virtual disk size:"
            Height          =   255
            Left            =   720
            TabIndex        =   76
            Top             =   1920
            Width           =   1935
         End
         Begin VB.Label InfoVDSize 
            Caption         =   "Virtual disk size:"
            Height          =   255
            Left            =   720
            TabIndex        =   75
            Top             =   2280
            Width           =   1695
         End
         Begin VB.Label NewVDHelp 
            Caption         =   $"frmNewMac.frx":27984
            Height          =   855
            Left            =   680
            TabIndex        =   74
            Top             =   240
            Width           =   6495
         End
         Begin VB.Label NewVDTitleHelp 
            Caption         =   "Name and location:"
            Height          =   255
            Left            =   680
            TabIndex        =   73
            Top             =   1110
            Width           =   1695
         End
      End
      Begin VB.Frame NewMac60 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   63
         Top             =   840
         Visible         =   0   'False
         Width           =   7455
         Begin VB.PictureBox Picture1 
            Height          =   4215
            Left            =   -120
            ScaleHeight     =   4155
            ScaleWidth      =   7515
            TabIndex        =   64
            TabStop         =   0   'False
            Top             =   -160
            Width           =   7575
            Begin VB.OptionButton CreateNewVD 
               Caption         =   "A new virtual disk"
               Height          =   255
               Left            =   840
               TabIndex        =   66
               Top             =   1840
               Value           =   -1  'True
               Width           =   4815
            End
            Begin VB.OptionButton AddExistingVD 
               Caption         =   "An existing virtual hard disk"
               Height          =   255
               Left            =   840
               TabIndex        =   65
               Top             =   2140
               Width           =   4815
            End
            Begin VB.Label NewMac60Help 
               BackStyle       =   0  'Transparent
               Caption         =   $"frmNewMac.frx":27A54
               Height          =   495
               Left            =   720
               TabIndex        =   69
               Top             =   360
               Width           =   6135
            End
            Begin VB.Label Label4 
               Caption         =   "Do you want to use:"
               Height          =   255
               Left            =   720
               TabIndex        =   68
               Top             =   1520
               Width           =   2175
            End
            Begin VB.Label NewMac60About 
               BackStyle       =   0  'Transparent
               Caption         =   "The first virtual hard disk you create or select for your virtual machine is called Disk 1 in Settings and is the Startup disk."
               Height          =   495
               Left            =   720
               TabIndex        =   67
               Top             =   960
               Width           =   6015
            End
         End
      End
      Begin VB.Frame Top 
         BackColor       =   &H00FFFFFF&
         Height          =   975
         Left            =   0
         TabIndex        =   13
         Top             =   -120
         Width           =   7455
         Begin VB.PictureBox WizardPictureSmall 
            Height          =   800
            Left            =   6600
            Picture         =   "frmNewMac.frx":27AEF
            ScaleHeight     =   735
            ScaleWidth      =   735
            TabIndex        =   14
            TabStop         =   0   'False
            Top             =   140
            Width           =   800
         End
         Begin VB.Label ActionDescription 
            BackStyle       =   0  'Transparent
            Caption         =   "You can create a new Virtual Mac or add an existing one to the Virtual Mac Console."
            Height          =   375
            Left            =   600
            TabIndex        =   16
            Top             =   480
            Width           =   5175
         End
         Begin VB.Label Action 
            BackStyle       =   0  'Transparent
            Caption         =   "Options"
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
            TabIndex        =   15
            Top             =   240
            Width           =   5175
         End
      End
      Begin VB.Frame NewMac4 
         BorderStyle     =   0  'None
         Height          =   3975
         Left            =   0
         TabIndex        =   26
         Top             =   840
         Visible         =   0   'False
         Width           =   7455
         Begin VB.ComboBox OSList 
            Height          =   315
            ItemData        =   "frmNewMac.frx":29787
            Left            =   720
            List            =   "frmNewMac.frx":297A3
            Style           =   2  'Dropdown List
            TabIndex        =   27
            Top             =   1560
            Width           =   2295
         End
         Begin VB.Label CPUArch 
            Alignment       =   1  'Right Justify
            Caption         =   "PowerPC"
            Height          =   255
            Left            =   4800
            TabIndex        =   54
            Top             =   2280
            Width           =   1215
         End
         Begin VB.Label DiskMB 
            Alignment       =   1  'Right Justify
            Caption         =   "500 MB"
            Height          =   255
            Left            =   4920
            TabIndex        =   53
            Top             =   1920
            Width           =   1095
         End
         Begin VB.Label MemoryMB 
            Alignment       =   1  'Right Justify
            Caption         =   "256 MB"
            Height          =   255
            Left            =   4920
            TabIndex        =   52
            Top             =   1560
            Width           =   1095
         End
         Begin VB.Label CPUType 
            Caption         =   "CPU arquitecture:"
            Height          =   255
            Left            =   3360
            TabIndex        =   51
            Top             =   2280
            Width           =   1335
         End
         Begin VB.Label Disk 
            Caption         =   "Disk space:"
            Height          =   255
            Left            =   3360
            TabIndex        =   50
            Top             =   1920
            Width           =   975
         End
         Begin VB.Label Memory 
            Caption         =   "Memory:"
            Height          =   255
            Left            =   3360
            TabIndex        =   49
            Top             =   1560
            Width           =   975
         End
         Begin VB.Label DefaultHardware 
            Caption         =   "Default hardware selection:"
            Height          =   255
            Left            =   3360
            TabIndex        =   48
            Top             =   1220
            Width           =   2055
         End
         Begin VB.Label OSListTitle 
            Caption         =   "Operating system: "
            Height          =   255
            Left            =   600
            TabIndex        =   29
            Top             =   1220
            Width           =   1695
         End
         Begin VB.Label Help4 
            Caption         =   $"frmNewMac.frx":29804
            Height          =   855
            Left            =   600
            TabIndex        =   28
            Top             =   240
            Width           =   6255
         End
      End
      Begin VB.Frame NewMacFromExist 
         BorderStyle     =   0  'None
         Height          =   3855
         Left            =   0
         TabIndex        =   22
         Top             =   840
         Visible         =   0   'False
         Width           =   7215
         Begin VB.TextBox FileNameA 
            Height          =   285
            IMEMode         =   3  'DISABLE
            Left            =   600
            TabIndex        =   41
            Top             =   840
            Width           =   5055
         End
         Begin VB.CommandButton BrowseA 
            Caption         =   "Browse..."
            Height          =   340
            Left            =   5760
            TabIndex        =   23
            Top             =   825
            Width           =   1095
         End
         Begin VB.Label FileNameTitleA 
            Caption         =   "Name and location:"
            Height          =   255
            Left            =   600
            TabIndex        =   25
            Top             =   600
            Width           =   1815
         End
         Begin VB.Label HelpA 
            BackStyle       =   0  'Transparent
            Caption         =   "Specify the .mcc file you want to add to the Virtual Mac Console."
            Height          =   255
            Left            =   600
            TabIndex        =   24
            Top             =   240
            Width           =   5775
         End
      End
   End
   Begin VB.Frame NewMacEnd 
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   0  'None
      Caption         =   "NewMac1"
      Height          =   4695
      Left            =   0
      TabIndex        =   37
      Top             =   0
      Visible         =   0   'False
      Width           =   7455
      Begin VB.CheckBox OpenSettingsAfterFinish 
         BackColor       =   &H00FFFFFF&
         Caption         =   "When I click Finish, open Settings."
         Height          =   375
         Left            =   2680
         TabIndex        =   44
         Top             =   3060
         Value           =   1  'Checked
         Width           =   4215
      End
      Begin VB.PictureBox WizardEnd 
         BackColor       =   &H00800000&
         BorderStyle     =   0  'None
         Height          =   4695
         Left            =   0
         Picture         =   "frmNewMac.frx":29907
         ScaleHeight     =   4695
         ScaleWidth      =   2460
         TabIndex        =   38
         Top             =   0
         Width           =   2460
      End
      Begin VB.Label AdviceClickFinish 
         BackStyle       =   0  'Transparent
         Caption         =   "To close this wizard, click Finish."
         Height          =   255
         Left            =   2680
         TabIndex        =   46
         Top             =   3480
         Width           =   3135
      End
      Begin VB.Label AdviceNoHD 
         BackStyle       =   0  'Transparent
         Caption         =   "Before you can install an operating system on this Virtual Mac, you must add a virtual hard disk to it."
         Height          =   495
         Left            =   2640
         TabIndex        =   45
         Top             =   1800
         Visible         =   0   'False
         Width           =   4095
      End
      Begin VB.Label VMName 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Height          =   435
         Left            =   2640
         TabIndex        =   43
         Top             =   1200
         Width           =   4695
         WordWrap        =   -1  'True
      End
      Begin VB.Label DescriptionEnd 
         BackStyle       =   0  'Transparent
         Caption         =   "You have completed succefully the New Virtual Mac Wizard and have named your Mac:"
         Height          =   495
         Left            =   2640
         TabIndex        =   40
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
         TabIndex        =   39
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
      TabIndex        =   7
      Top             =   4620
      Width           =   7455
      Begin VB.CommandButton cmdCancel 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   340
         Left            =   6200
         TabIndex        =   6
         Top             =   300
         Width           =   1095
      End
      Begin VB.CommandButton cmdNext 
         Caption         =   "Next >"
         Default         =   -1  'True
         Height          =   340
         Left            =   4920
         TabIndex        =   5
         Top             =   300
         Width           =   1095
      End
      Begin VB.CommandButton cmdBack 
         Caption         =   "< Back"
         Enabled         =   0   'False
         Height          =   340
         Left            =   3810
         TabIndex        =   4
         ToolTipText     =   "Atras"
         Top             =   300
         Width           =   1095
      End
   End
End
Attribute VB_Name = "frmNewMac"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Honestly, the most complicated assistant (Here is where my hard work is :D)

Private Type MEMORYSTATUS 'Api for checking how much RAM is avaible in the machine
dwLength As Long
dwMemoryLoad As Long
dwTotalPhys As Long
dwAvailPhys As Long
dwTotalPageFile As Long
dwAvailPageFile As Long
dwTotalVirtual As Long
dwAvailVirtual As Long
End Type
Private Declare Sub GlobalMemoryStatus Lib "kernel32" (lpBuffer As MEMORYSTATUS)

Private Sub Adjust_Click()

'This makes visible the Frame that shows the RAM slider to adjust the RAM

If Adjust.Value = True Then
RAMAdjuster.Visible = True
RAMAdjust.TabStop = True
RAMMegabyteNumber.TabStop = True
End If

End Sub

Private Sub BrowseA_Click()

'A for Add, that means 'Add an existing machine'.
'Opens a 'Open dialog' to search VirtualMac config file

Browse.Filter = "Virtual Mac Configuration File (*.mcc)|*.mcc|All files (*.*)|*.*"
Browse.ShowOpen
FileNameC.Text = Browse.FileName
End Sub

Private Sub BrowseC_Click()
'C for Create, that means 'Create a new machine'
'Opens the save dialog that let's you choose where
'will the config file be saved

Browse.Filter = "Virtual Mac Configuration File (*.mcc)|*.mcc|All files (*.*)|*.*"
Browse.ShowSave
FileNameC.Text = Browse.FileName

End Sub

Private Sub cmdBack_Click()

'This is the first part of the hard code, this makes
'that the right Frame will be shown, this is in base
'to which is the currently visible frame. This makes
'visible the earlier Frame. The instruction
'<GoTo EndNext> makes that you won't automatically jump
'until the Start screen

If NewMac2.Visible = True Then 'Go back to Start screen
    cmdBack.Enabled = False
    NewMac2.Visible = False
    NewMacWizard.Visible = False
    NewMac1.Visible = True
    GoTo EndNext
End If

'Both fo these go back to Page 2. But every one is different
'since one creates a new Mac, the other adds a new one

If NewMac3.Visible = True Then 'Back from the page 'Create a new one'
    NewMac3.Visible = False
    Action.Caption = "Options"
    ActionDescription.Caption = "You can create a new Virtual Mac or add an existing one to the Virtual Mac Console"
    NewMac2.Visible = True
    GoTo EndNext
End If

If NewMacFromExist.Visible = True Then 'Back from page 'Add a new one'
    NewMacFromExist.Visible = False
    Action.Caption = "Options"
    ActionDescription.Caption = "You can create a new Virtual Mac or add an existing one to the Virtual Mac Console"
    NewMac2.Visible = True
    GoTo EndNext
End If

If NewMac4.Visible = True Then 'Back from the page 'Name and Location'
    NewMac4.Visible = False
    Action.Caption = "Virtual Macintosh Name and Location"
    ActionDescription.Caption = "The name you specify will appear in the list of Virtual Macintoshes in the Virtual Mac Console"
    NewMac3.Visible = True
    GoTo EndNext
End If

If NewMac5.Visible = True Then 'Back from the page 'Select OS'
    NewMac5.Visible = False
    Action.Caption = "Operating System"
    ActionDescription.Caption = "Select the operating system you plan to install on this machine"
    NewMac4.Visible = True
    GoTo EndNext
End If

If NewMac6.Visible = True Then 'Back from the page 'RAM for this Mac'
    NewMac6.Visible = False
    Action.Caption = "Memory"
    ActionDescription.Caption = "You can configure the RAM on this Mac"
    NewMac5.Visible = True
    GoTo EndNext
End If


'Back from the page 'Finishing the New Mac Wizard'. Note: This changes as which option was choosen
If NewMacEnd.Visible = True Then
    
    'If choosen the option 'Create a new Mac', this will return
    'to the 'RAM' page
    If CreateNew.Value = True Then
        NewMacEnd.Visible = False
        cmdNext.Caption = "Next >"
        NewMacWizard.Visible = True
        NewMac6.Visible = True
        GoTo EndNext
    End If
    
    'If choosen the option 'Use default settings to create a Virtual Mac'
    'this will return to the page 2
    If UseDefaults.Value = True Then
        NewMacEnd.Visible = False
        AdviceNoHD.Visible = False
        cmdNext.Caption = "Next >"
        NewMacWizard.Visible = True
        NewMac3.Visible = True
        GoTo EndNext
    End If
End If

EndNext:
End Sub

Private Sub cmdCancel_Click()
    'If you cahnge of opinion and you think you don't need
    'a New Mac, this will Unload the current Window
    Unload Me
End Sub

Private Sub cmdNext_Click()
'Here is the REALLY HARD work. This code will make you advance
'throught the assistant. This will check which page (Frame) is
'shown and in base to your choices, it will show diferrent things

'Declarations
Dim MemStat As MEMORYSTATUS
Dim RAM As Long
Dim MacName As String
Dim VMemory As Long
Dim VDisk As Long
Dim VArch As String

'Assigning values to the declarations
MacName = Replace(FileNameC.Text, ".mcc", "")
VMemory = Replace(MemoryMB, " MB", "")
VDisk = DiskSizeMB
VArch = CPUArch.Caption

GlobalMemoryStatus MemStat
RAM = Str$(MemStat.dwTotalPhys / 1024 / 1024)


If NewMac1.Visible = True Then 'Shows the assistant
    NewMacWizard.Visible = True
    NewMac1.Visible = False
    NewMac2.Visible = True
    cmdBack.Enabled = True
    GoTo EndNext
End If

If NewMac2.Visible = True Then 'This will differ as the option you choose
    
    If AddExist.Value = True Then 'If you want to add from existing file
    NewMac2.Visible = False
    Action.Caption = "Existing Virtual Macintosh Name and Location"
    ActionDescription.Caption = "You can add a .mcc file from this computer or another computer to the Virtual Mac Console"
    NewMacFromExist.Visible = True
    FileNameA.SetFocus
    GoTo EndNext
    End If
    
    NewMac2.Visible = False 'If you want to create a NEW Mac
    Action.Caption = "Virtual Macintosh Name and Location"
    ActionDescription.Caption = "The name you specify will appear in the list of Virtual Macintoshes in the Virtual Mac Console"
    NewMac3.Visible = True
    FileNameC.SetFocus
    GoTo EndNext
End If

If NewMac3.Visible = True Then 'This will differ too with the choice that you've made before
    
    If Not Browse.FileTitle = "" Then
    MacName = Replace(Browse.FileTitle, ".mcc", "")
    End If
    
    If Browse.FileTitle = "" Then
    MacName = FileNameC
    End If
    
    If CreateNew.Value = True Then 'If you choosed to Create a new thing and follow instruction step by step
        AutoDetectOS
        Action.Caption = "Operating System"
        ActionDescription.Caption = "Select the operating system you plan to install on this machine"
        NewMac3.Visible = False
        cmdBack.Default = True
        cmdNext.Default = True
        cmdNext.SetFocus
        NewMac4.Visible = True
        GoTo EndNext
    End If
    
    If UseDefaults.Value = True Then 'If you don't wanna waste time and just want a new machine NOW
        AutoDetectOS
        'AutoConfigure 'This will be uncommented when implemmented
        VMName.Caption = MacName
        NewMacWizard.Visible = False
        cmdNext.Caption = "Finish"
        cmdBack.Default = True
        cmdNext.Default = True
        cmdNext.SetFocus
        AdviceNoHD.Visible = True
        NewMacEnd.Visible = True
        GoTo EndNext
    End If
    
End If


'Move away from the OS page and choose the RAM for you new Mac!
'(Only avaible when creating new one, not when you choosed use defaults)
If NewMac4.Visible = True Then
    NewMac4.Visible = False
    Action.Caption = "Memory"
    ActionDescription.Caption = "You can configure the RAM on this Mac"
    RAMAdjust.Max = RAM
    RAMAdjust.Value = VMemory
    RAMMegabyteNumber.Text = VMemory
    RecRAM.Caption = "Recommended RAM: [" & MemoryMB.Caption & "]"
    NewMac5.Visible = True
    GoTo EndNext
End If

If NewMac5.Visible = True Then 'Configure you new hard disk!
    NewMac5.Visible = False
    Action.Caption = "Virtual Hard Disk Location"
    ActionDescription.Caption = "This wizard creates a fixed size virtual disk with the specified size"
    DiskSizeMB.Text = Replace(DiskMB.Caption, " MB", "")
    
    If Not Browse.FileName = "" Then
    NewMac7VDName.Text = Replace(Browse.FileName, ".mcc", ".dsk")
    End If
    
    If Browse.FileName = "" Then
    NewMac7VDName = frmOptions.DefaultMacFolder & "\" & MacName & ".dsk"
    End If
    
    NewMac6.Visible = True
    GoTo EndNext
End If

If NewMac6.Visible = True Then 'You'll see the Finish page
    NewMac6.Visible = False
    OpenSettingsAfterFinish.Visible = False
    NewMacWizard.Visible = False
    cmdNext.Caption = "Finish"
    NewMacEnd.Visible = True
    GoTo EndNext
End If


If NewMacEnd.Visible = True Then

    frmMain.VMList.AddItem MacName
    
    frmMain.RedrawList
    
    Unload Me
        If OpenSettingsAfterFinish.Visible = True Then
                If OpenSettingsAfterFinish.Value = 1 Then
                    
                    frmVMSettings.Show MacName
                End If
        End If
    
End If

EndNext:
End Sub


Public Sub AutoDetectOS()
'This is another part of hard work. This works 60%
'since when it finds: 5,6,7,7.,8,9,10,10. and X
'it will automatically detect an OS. Later I will add
'CodeNames to this 'Detector'

'Declarations
Dim OSDetected As Integer
Dim Found As Long
Dim VDisk As Long
Dim VMemory As Long
Dim VArch As String
Dim Arch As String

'Thing that checks if you wrote any of these characters:
'"5","6","7","7.","8","9","10","10.","X"

Found = InStr(FileNameC.Text, " 5 ")
If Found <> 0 Then
OSDetected = 5
GoTo HardwareEngineer
End If

SysSoftware6:
Found = InStr(FileNameC.Text, " 6 ")
If Found <> 0 Then
OSDetected = 6
GoTo HardwareEngineer
End If

MacOS70:
Found = InStr(FileNameC.Text, " 7 ")
If Found <> 0 Then
OSDetected = 70
GoTo HardwareEngineer
End If

Found = InStr(FileNameC.Text, " 7.")
If Found <> 0 Then
OSDetected = 75
GoTo HardwareEngineer
End If

MacOS8:
Found = InStr(FileNameC.Text, " 8 ")
If Found <> 0 Then
OSDetected = 8
GoTo HardwareEngineer
End If

MacOS9:
Found = InStr(FileNameC.Text, " 9 ")
If Found <> 0 Then
OSDetected = 9
GoTo HardwareEngineer
End If

MacOSClassic:
Found = InStr(FileNameC.Text, " 9.")
If Found <> 0 Then
OSDetected = 9
GoTo HardwareEngineer
End If

OSX:
Found = InStr(FileNameC.Text, " X ")
If Found <> 0 Then
OSDetected = 10
GoTo HardwareEngineer
End If

Found = InStr(FileNameC.Text, " 10 ")
If Found <> 0 Then
OSDetected = 10
GoTo HardwareEngineer
End If

Found = InStr(FileNameC.Text, " 10.")
If Found <> 0 Then
OSDetected = 10
GoTo HardwareEngineer
End If

'These instructions set the OS to Other when you've not wrote any of these characters
If OSDetected <> 0 Then GoTo HardwareEngineer

OSDetected = 1

'This 'Hardware Engineer' makes default hardware choices for a specific OS
'Soon I will add support for Darwin and Linux
HardwareEngineer:
    Select Case OSDetected
        Case "5" 'System Software 5 Detected
            VMemory = 4
            VDisk = 100
            VArch = "m68k"
            OSList.ListIndex = 0
        Case "6" 'System Software 6 Detected
            VMemory = 8
            VDisk = 100
            VArch = "m68k"
            OSList.ListIndex = 1
        Case "70" 'MacOS 7.0/7.1 Detected
            VMemory = 16
            VDisk = 200
            VArch = "m68k"
            OSList.ListIndex = 2
        Case "75" 'MacOS 7.5/7.6 Detected
            VMemory = 32
            VDisk = 500
            VArch = "PPC"
            OSList.ListIndex = 3
        Case "8" 'MacOS 8 Detected
            VMemory = 64
            VDisk = 500
            VArch = "PPC"
            OSList.ListIndex = 4
        Case "9" 'MacOS 9/Classic Detected
            VMemory = 128
            VDisk = 1024
            VArch = "PPC"
            OSList.ListIndex = 5
        Case "10" 'OS X Detected
            VMemory = 256
            VDisk = 3072
            VArch = "PPC"
            OSList.ListIndex = 6
        Case "1" 'Couldn't detect the OS, so it's set to other
            VMemory = 128
            VDisk = 500
            VArch = "PPC"
            OSList.ListIndex = 7
    End Select

ArchFixer:
    Select Case VArch
        Case "m68k"
        Arch = "Motorola 68000"
        Case "PPC"
        Arch = "PowerPC"
    End Select
    
ListFixer:
        MemoryMB.Caption = VMemory & " MB"
        DiskMB.Caption = VDisk & " MB"
        CPUArch.Caption = Arch

End Sub

Private Sub DiskSizeMB_Change()
'This is the tiny code that makes the slider and the textbox to synchronize

On Error Resume Next

If DiskSizeMB.Text = "" Then
cmdNext.Enabled = False
WarningLowerSize.Visible = True
DiskSizeMB.SetFocus
Else
cmdNext.Enabled = True
WarningLowerSize.Visible = False
DiskSizeMB.SetFocus
End If

If DiskSizeMB.Text > 130557 Then
cmdNext.Enabled = False
WarningLowerSize.Visible = True
DiskSizeMB.SetFocus
Else
cmdNext.Enabled = True
WarningLowerSize.Visible = False
DiskSizeMB.SetFocus
End If

End Sub

Private Sub DiskSizeMB_Click()
DiskSizeMB.SetFocus
End Sub

Private Sub DiskSizeMB_KeyPress(KeyAscii As Integer)
'Goes to a function that makes that you can only press numbers,
'no letters, no dots, no special characters
KeyAscii = VerifyKey(KeyAscii)

End Sub

Private Sub NewVDBrowse_Click()
'Opens the dialog to let you choice the location of the new hard disk

Browse.Filter = "Virtual Mac Disk (*.dsk)|*.dsk|All files (*.*)|*.*"
Browse.ShowSave
NewMac7VDName.Text = Browse.FileName
End Sub

Private Sub RAMMegabyteNumber_GotFocus()
'This selects all the text when you click the TextBox with the
'Megabytes of RAM for your machine

RAMMegabyteNumber.SelStart = 0
RAMMegabyteNumber.SelLength = Len(RAMMegabyteNumber.Text)
End Sub

Private Sub Recommend_Click()
'Makes Invisible the Frame with the RAM Slider so you will use the default RAM for the machine

If Recommend.Value = True Then
RAMAdjuster.Visible = False
RAMAdjust.TabStop = False
RAMMegabyteNumber.TabStop = False
End If
End Sub

Private Sub FileNameC_GotFocus()
'Selects all the text when you click in the machine FileName TextBox

FileNameC.SelStart = 0
FileNameC.SelLength = Len(FileNameC.Text)
End Sub

Private Sub OSList_Change()
'Fixes the OSList so it will show the processor,
'amount of RAM and disk as you select another OS

ListFixer:
        MemoryMB.Caption = VMemory & " MB"
        DiskMB.Caption = VDisk & " MB"
        CPUArch.Caption = Arch

End Sub

Private Sub OSList_Click()
'Fixes the OSList so it will show the processor,
'amount of RAM and disk as you select another OS

'Boring delcarations
Dim ChangeOS As Integer

'Same as Hardware Engineer, it selects a default amount of RAM, disk and the right processor
HardwareFixer:
    Select Case OSList.ListIndex
        Case "0"
            VMemory = 4
            VDisk = 100
            VArch = "m68k"
        Case "1"
            VMemory = 8
            VDisk = 100
            VArch = "m683"
        Case "2"
            VMemory = 16
            VDisk = 200
            VArch = "m684"
        Case "3"
            VMemory = 32
            VDisk = 200
            VArch = "PPC"
        Case "4"
            VMemory = 64
            VDisk = 500
            VArch = "PPC"
        Case "5"
            VMemory = 128
            VDisk = 500
            VArch = "PPC"
        Case "6"
            VMemory = 256
            VDisk = 1024
            VArch = "PPC"
        Case "7"
            VMemory = 128
            VDisk = 1024
            VArch = "PPC"
    End Select

ArchFixer:
    Select Case VArch
        Case "m68k"
        Arch = "Motorola 68000"
        Case "m682"
        Arch = "Motorola 68020"
        Case "m683"
        Arch = "Motorola 68030"
        Case "m684"
        Arch = "Motorola 68040"
        Case "PPC"
        Arch = "PowerPC"
    End Select

'This fixes the list and labels
ListFixer:
        MemoryMB.Caption = VMemory & " MB"
        DiskMB.Caption = VDisk & " MB"
        CPUArch.Caption = Arch
ChangeOS = OSList.ListIndex

End Sub

Private Sub RAMAdjust_Scroll()
'Synchronizes the slider and the TextBox

RAMMegabyteNumber.Text = RAMAdjust.Value

End Sub

Private Sub RAMMegabyteNumber_Change()
'Makes that the value of the TextBox will be represented in the slider

On Error GoTo ErrorHandler

RAMAdjust.Value = RAMMegabyteNumber



ErrorHandler:
If Not Err.Number = 0 Then
        If Err.Number = 13 Then
        RAMAdjust.Value = 0
        End If
        
        If Err.Number <> 13 Then
        MsgBox Err.Description, vbCritical
        End If
End If
End Sub

Private Sub RAMMegabyteNumber_KeyPress(KeyAscii As Integer)

KeyAscii = VerifyKey(KeyAscii)

End Sub

Function VerifyKey(PressedKey)
'Lets only to send the keys assigned to numbers in the keyboard
    
'Declarations
Dim AllowedKeys As String
    
    'Here are listed the 'allowed' keys
    AllowedKeys = "1234567890" & Chr(vbKeyBack)
    
    'Here is made the check with a 'If' instruction
    If InStr(1, AllowedKeys, Chr(PressedKey)) Then
        VerifyKey = PressedKey 'If the pressed key is one of the allowed
    Else
        VerifyKey = 0
    End If
    

End Function

Public Sub AddVM()
'This procedure will, make place where at the end
'of the assistant the machine is made and the config file
'is written to disk. But for now it's incomplete

frmMain.RedrawList 'Verifies for new items and redraws the list

End Sub
