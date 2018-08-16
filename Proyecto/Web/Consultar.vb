Public Class Consultar
    Dim Neg As New Negocio.VerificarOtros

    Public Sub LogWeb(ByVal user As String, ByVal contra As String)
        Neg.VerificarLoginWeb(user, contra)
    End Sub
End Class
