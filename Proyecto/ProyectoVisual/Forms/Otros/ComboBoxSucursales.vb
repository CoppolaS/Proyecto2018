Imports Negocio

Public Class ComboBoxSucursales
    Dim Verif As New Negocio.VerificarEmpresa
    Dim dv As New DataView

    Private Sub ComboBoxSucursales_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Datos.UsuarioLogeado.Privilegios = 1 Then
            ComboBox1.Enabled = True
            dv = Verif.ValidoListaSucursales
            dv.RowFilter = "Eliminado = 0"
            For i As Integer = 0 To dv.Count - 1
                ComboBox1.Items.Add(dv(i).Item("Nombre").ToString())
            Next
        End If
    End Sub
End Class
