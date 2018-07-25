Imports Negocio.Verificar

Public Class Login
    Dim Verificar As New Negocio.Verificar

    Private Sub Enabler(ByVal sender As Object, ByVal e As System.EventArgs) Handles userTB.TextChanged, passTB.TextChanged
        If userTB.Text <> "" And passTB.Text <> "" Then
            iniciarsesion.Enabled = True
        Else
            iniciarsesion.Enabled = False
        End If
    End Sub

    Private Sub iniciarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iniciarsesion.Click
        Verificar.VerificarLogin(userTB.Text, passTB.Text)
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class

