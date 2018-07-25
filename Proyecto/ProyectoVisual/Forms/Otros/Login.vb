Imports Negocio.Verificar
Imports Encapsuladoras.Login

Public Class Login
    Dim Verificar As New Negocio.Verificar
    Dim encapsuladora As Encapsuladoras.Login = New Encapsuladoras.Login

    Private Sub Enabler(ByVal sender As Object, ByVal e As System.EventArgs) Handles userTB.TextChanged, passTB.TextChanged
        If userTB.Text <> "" And passTB.Text <> "" Then
            iniciarsesion.Enabled = True
        Else
            iniciarsesion.Enabled = False
        End If
    End Sub

    Private Sub iniciarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarsesion.Click
        encapsuladora.UsuarioLogin = userTB.Text
        encapsuladora.ContrasenaLogin = passTB.Text
        Verificar.VerificarLogin(encapsuladora)
        userTB.Clear()
        passTB.Clear()
    End Sub

End Class

