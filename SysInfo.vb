Imports System.Management
Module SysInfo
    Public OSName As String
    Public OSBuild As String
    Public CPUClass As String
    Public CPUCores As String
    Public InstalledRAM As String
    Public UserName As String
    Public ComputerName As String

    Public Function GetSysInfo() As String
        Dim VersionArray() As String = Split(My.Computer.Info.OSVersion, ".")

        'Setting the labels with the versions
        Dim BuildOS As String = VersionArray(0) + "." + VersionArray(1) + "." + VersionArray(2)
        Dim NameOS As String = ""
        Dim CPUInfo As String = GetProcessorInfo()
        Dim NameCPU As String = CPUInfo.ToString.Substring(0, InStr(CPUInfo, ";") - 1)
        Dim CoresCPU As String = CPUInfo.ToString.Substring(InStr(CPUInfo, ";"), InStr(CPUInfo, "_") - InStr(CPUInfo, ";") - 1)
        Dim TotalRAM As Long = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024
        Dim UsrName As String = Replace(Replace(My.User.Name, My.Computer.Name, ""), "\", "")
        Dim PCName As String = My.Computer.Name

        'Naming the Windows OS by its version
        frmAbout.OSName.Text = "Unknown"
        Select Case BuildOS
            Case "6.0.6000"
                NameOS = "Windows Vista RTM"
            Case "6.0.6001"
                NameOS = "Windows Vista SP1"
            Case "6.0.6002"
                NameOS = "Windows Vista SP2"
            Case "6.1.7600"
                NameOS = "Windows 7 RTM"
            Case "6.1.7601"
                NameOS = "Windows 7 SP1"
            Case "6.2.9200"
                NameOS = "Windows 8"
            Case "6.2.9600"
                NameOS = "Windows 8.1"
        End Select
        Select Case My.Computer.Info.OSVersion
            Case "5.1.2600.0"
                NameOS = "Windows XP RTM"
            Case "5.1.2600.1106"
                NameOS = "Windows XP SP1"
            Case "5.1.2600.2180"
                NameOS = "Windows XP SP2"
            Case "5.1.2600.5512"
                NameOS = "Windows XP SP3"
        End Select

        OSName = NameOS
        OSBuild = BuildOS
        CPUClass = NameCPU
        CPUCores = CoresCPU
        InstalledRAM = TotalRAM
        UserName = UsrName
        ComputerName = PCName

        Return (NameOS + vbCrLf + BuildOS + vbCrLf + NameCPU + vbCrLf + CoresCPU + vbCrLf & TotalRAM & " MB" & vbCrLf + UsrName + vbCrLf + PCName)

    End Function

    Public Function GetProcessorInfo() As String
        Dim Info As String = ""

        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Processor")

            For Each queryObj As ManagementObject In searcher.Get()
                Info = queryObj("Name")
                Info = Info & " (" & Replace(Replace(Replace(queryObj("Caption"), "Family ", "F"), "Model ", "M"), "Stepping ", "S") & ")"
                Info = Info & ";" & queryObj("NumberOfCores")
                Info = Info & "_" & queryObj("MaxClockSpeed")
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while getting the processor info: " & err.Message & " . The system information may be incomplete", "Virtual Mac", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Info
    End Function
End Module
