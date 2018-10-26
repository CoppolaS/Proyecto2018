Imports Negocio.VerificarOtros
Imports Datos.UsuarioLogeado

Public Class Login
    Dim Verificar As New Negocio.VerificarOtros

    Private Sub Enabler(ByVal sender As Object, ByVal e As System.EventArgs) Handles userTB.TextChanged, passTB.TextChanged
        If userTB.Text <> "" And passTB.Text <> "" Then
            iniciarsesion.Enabled = True
        Else
            iniciarsesion.Enabled = False
        End If
    End Sub

    Private Sub iniciarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarsesion.Click
        Verificar.VerificarLogin(userTB.Text, passTB.Text)
        If Datos.UsuarioLogeado.Logeado = True Then
            Inicio.Show()
            Me.Close()
        Else
            userTB.Clear()
            passTB.Clear()
            userTB.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        userTB.Text = "lalberto"
        passTB.Text = "123456"
        iniciarsesion.PerformClick()
    End Sub
End Class

