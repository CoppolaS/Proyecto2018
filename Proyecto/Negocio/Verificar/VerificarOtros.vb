Imports Datos

Public Class VerificarOtros
    Dim LoginD As New Datos.DatosOtros
    Dim ReturnLog As New Integer
    Public Sub VerificarLogin(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        LoginD.LoginPrograma(UsuarioPrograma, ContrasenaPrograma)
        If UsuarioLogeado.Logeado = True Then
            MsgBox("Inicio de sesión exitoso")
        Else
            MsgBox("Combinación de usuario y contraseña incorrectos")
        End If
    End Sub

    Public Function VerificarLoginWeb(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        Return LoginD.LoginWeb(UsuarioPrograma, ContrasenaPrograma)
    End Function

End Class
