Imports Negocio

Public Class ComboBoxSucursales
    Dim Verif As New Negocio.VerificarEmpresa
    Dim dv As New DataView

    Private Sub ComboBoxSucursales_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        dv = Verif.ValidoListaSucursales
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox1.Items.Add(dv(i).Item("Nombre").ToString())
        Next
        If Datos.UsuarioLogeado.Privilegios = 1 Then
            ComboBox1.Enabled = True
        End If
    End Sub

    Public Event SeleccionCambio(sender As System.Object, e As System.EventArgs)

    Private Sub Combobox1CambioSeleccion(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Datos.UsuarioLogeado.Sucursal = ComboBox1.SelectedItem.ToString
        RaiseEvent SeleccionCambio(Me, New System.EventArgs)
    End Sub
End Class
