Module DiskImageCreator
    Public Function CreateRawDisk(ByVal DiskSize As Integer, ByVal DiskPath As String, Optional ShowMessages As Boolean = True) As Long
        Dim Size((DiskSize * 1024) * 1024) As Byte

        '//Create the file, so we don't depend on the creation of the file to report progress
        '//And after file creation, fill the file with zeroes until we get the desired size
        '//As the byte gets assigned a value, it's written, and also it's reported as a progress of the creation
        For x As Integer = 0 To Size.Length - 1
            Size(x) = 0
        Next
        My.Computer.FileSystem.WriteAllBytes(DiskPath, Size, False)

        If ShowMessages = False Then Exit Function
        MsgBox("The image ''" & DiskPath & "'' was created succefully.", MsgBoxStyle.Exclamation, "Creating disk image")
    End Function
    '//This thing below is useless right now. In a later update, this will create Mac formatted floppy disks of 720 KB and 1.44 MB
    Public Function CreateFloppyDisk(ByVal DiskSize As Integer, ByVal DiskPath As String, Optional ShowMessages As Boolean = True) As Long
        Dim FloppyImageToUse() As Byte = {0}

        Select Case DiskSize
            Case "720"

            Case "1440"

        End Select

        '//Create the file from an existing image, which is formatted and ready to use with a Mac

        My.Computer.FileSystem.WriteAllBytes(DiskPath, FloppyImageToUse, False)
        If ShowMessages = False Then Exit Function
        MsgBox("The image ''" & DiskPath & "'' was created succefully.", MsgBoxStyle.Exclamation, "Creating disk image")
    End Function
End Module
