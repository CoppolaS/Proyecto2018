Public Class Site1
    Inherits System.Web.UI.MasterPage
    Public pepe As New Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pepe = 0
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim Verif As New Negocio.VerificarOtros
        pepe = Verif.VerificarLoginWeb(TextBox1.Text, TextBox2.Text)

    End Sub
End Class