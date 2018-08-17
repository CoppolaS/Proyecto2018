Public Class Login
    Inherits System.Web.UI.Page
    Dim Neg As New Negocio.VerificarOtros

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub LogWeb(ByVal user As String, ByVal contra As String)
        Neg.VerificarLoginWeb(user, contra)
    End Sub

    Protected Sub Close(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

    End Sub
End Class