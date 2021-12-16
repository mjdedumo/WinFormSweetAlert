Module Module1
    Public Function msgQuestion(mensahe As String) As Integer
        Dim msg As New swalQuestion(mensahe)
        Return msg.ShowDialog()
    End Function
End Module
