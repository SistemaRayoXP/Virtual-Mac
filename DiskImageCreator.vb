Imports System.IO

Module DiskImageCreator
    Public Sub CreateDisk(ByVal Size As Long, ByVal Path As String)
        Dim bytes() As Byte
        Dim fs As FileStream = File.Create(Path)
        Dim x As Integer = 0

        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
    End Sub

    Public Function Byter() As Byte

    End Function
End Module