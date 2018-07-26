Imports Datos

Public Class Verificar
    Dim LoginD As New Datos.LoginDatos

    Public Sub VerificarLogin(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        LoginD.LoginPrograma(UsuarioPrograma, ContrasenaPrograma)
        If UsuarioLogeado.Logeado = True Then
            MsgBox("Inicio de sesión exitoso")
        Else
            MsgBox("Combinación de usuario y contraseña incorrectos")
        End If
    End Sub

End Class
