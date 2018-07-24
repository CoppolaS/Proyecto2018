Public Class Prueba
    Dim txt As String
    Dim d As Datos.ABM
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt = Me.TextBox1.Text
        d.AgregaCliente(txt)
    End Sub
End Class