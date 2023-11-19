Friend Class ExcelPackage
    Private fileInfo As IO.FileInfo

    Public Sub New(fileInfo As IO.FileInfo)
        Me.fileInfo = fileInfo
    End Sub
End Class
