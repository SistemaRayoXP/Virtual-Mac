Imports System.Management
Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            SysInfo.GetSysInfo()
            frmAbout.ProductNAV.Text = frmAbout.ProductNAV.Text & " " & My.Application.Info.Version.ToString & " Beta"
            If My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder) = False Then
                My.Settings.DefaultMacFolder = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Macs"
            End If
            If My.Settings.vMacROM = "" Then
                My.Settings.vMacROM = My.Application.Info.DirectoryPath & "\Emulators\vMac\MacII.ROM"
            End If
            If My.Settings.BasiliskROM = "" Then
                My.Settings.BasiliskROM = My.Application.Info.DirectoryPath & "\Emulators\BasiliskII\Mac_OS_ROM"
            End If
            If My.Settings.SheepShaverROM = "" Then
                My.Settings.SheepShaverROM = My.Application.Info.DirectoryPath & "\Emulators\SheepShaver\Mac_OS_ROM"
            End If

            Select Case My.Settings.Lang
                Case "en-US"
                    My.Application.ChangeUICulture("en-US")
                Case "es-MX"
                    My.Application.ChangeUICulture("es-MX")
                Case "de-DE"
                    My.Application.ChangeUICulture("de-DE")
            End Select

            If Not My.Application.CommandLineArgs.Count = 0 Then
                For x As Integer = 0 To My.Application.CommandLineArgs.Count - 1
                    Select Case My.Application.CommandLineArgs.Item(x)
                        Case "/debug"
                            frmMain.mnuFileDebug.Visible = True
                            frmMain.mnuHelpCrash.Visible = True
                        Case "/log"
                    End Select
                Next
            End If

            SearchForMacs()

            If My.Settings.VerifyEmulatorPaths = True Then
                If My.Settings.PearPCPath = "" Or My.Settings.QEMUPath = "" Or My.Settings.SheepShaverPath = "" _
            Or My.Settings.BasiliskPath = "" Or My.Settings.vMacPath = "" Then
                    MsgBox("Some emulator(s)' path isn't set yet. In order to launch this/these emulator(s), " & _
                        "you must set their path. To do so, click on menu File > Options and select ''Emulator " & _
                        "path'' and set the paths for the emulators", MsgBoxStyle.Exclamation, "Incorrect paths")
                End If
            End If
        End Sub

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If MsgBox("Virtual Mac is already running. Click Ok to show Virtual Mac Console. Click Cancel to close this dialog", MsgBoxStyle.OkCancel, "Virtual Mac is alerady running") = MsgBoxResult.Ok Then
                frmMain.Show()
            End If
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            For x As Integer = 0 To My.Application.CommandLineArgs.Count - 1
                Select Case My.Application.CommandLineArgs.Item(x)
                    Case "/debug"
                        MsgBox(e.Exception.Message)
                        Resume Next
                    Case "/log"
                        Resume Next
                    Case ""
                        Resume Next
                End Select
            Next
        End Sub

        Private Sub SearchForMacs()
            If My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultMacFolder) = True Then
                Dim Subdirectories As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(My.Settings.DefaultMacFolder)
                Dim FilesFound As String = ""

                For x As Integer = 0 To Subdirectories.Count - 1
                    For Each FileDetected As String In My.Computer.FileSystem.GetFiles( _
                                    Subdirectories.Item(x), _
                                     FileIO.SearchOption.SearchAllSubDirectories, _
                                    "*.mcf")
                        If Not frmMain.VMList.Items.IndexOfKey(System.IO.Path.GetFileNameWithoutExtension(FileDetected)) = -1 Then
                            Dim EmulatorType As String = InputBox("The file ''" & My.Computer.FileSystem.GetName(FileDetected) & _
                                                                "'' was detected as a possible Virtual Mac configuration file. " & _
                                                                "Possible emulators are 'Basilisk', 'SheepShaver', 'PearPC', 'QEMU'." & _
                                                                "Please write below the emulator to which this file will be associated:", _
                                                                "Virtual Mac Configuration file detected")
                            ConfigFileHandler.CreateFromFile(FileDetected, EmulatorType, System.IO.Path.GetFileNameWithoutExtension(FileDetected))
                        End If
                    Next
                Next
            End If
        End Sub
    End Class
End Namespace

