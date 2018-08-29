Imports Datos

Public Class VerificarOtros
    Dim DatosD As New Datos.DatosOtros
    Dim dv As New DataView
    Dim ds As New DataSet

    Public Sub VerificarLogin(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        DatosD.LoginPrograma(UsuarioPrograma, ContrasenaPrograma)
        If UsuarioLogeado.Logeado = True Then
            MsgBox("Inicio de sesión exitoso")
        Else
            MsgBox("Combinación de usuario y contraseña incorrectos")
        End If
    End Sub

    Public Function VerificarLoginWeb(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        Return DatosD.LoginWeb(UsuarioPrograma, ContrasenaPrograma)
    End Function

    Public Function VerificarVentanas(ByVal Opcion As Integer, Optional ByVal ventana As Integer = 0) As DataView
        ds = DatosD.VentanasInicio(Opcion, ventana)
        dv.RowFilter = "Eliminado = 0"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

End Class
