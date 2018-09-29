Imports Negocio.VerificarOtros
Imports Datos.UsuarioLogeado

Public Class Inicio
    Dim Verif As New Negocio.VerificarOtros
    Dim dv As New DataView

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = Datos.UsuarioLogeado.Ventana1 - 1
        ComboBox2.SelectedIndex = Datos.UsuarioLogeado.Ventana2 - 1
        ComboBox3.SelectedIndex = Datos.UsuarioLogeado.Ventana3 - 1
        CargarTablas()
    End Sub

    Private Sub CargarTablas()
        Tabla1.DataGridView1.DataSource = Verif.VerificarVentanas(4, Datos.UsuarioLogeado.Ventana1)
        Tabla1.DataGridView1.Columns("Eliminado").Visible = False

        Tabla2.DataGridView1.DataSource = Verif.VerificarVentanas(4, Datos.UsuarioLogeado.Ventana2)
        Tabla2.DataGridView1.Columns("Eliminado").Visible = False

        Tabla3.DataGridView1.DataSource = Verif.VerificarVentanas(4, Datos.UsuarioLogeado.Ventana3)
        Tabla3.DataGridView1.Columns("Eliminado").Visible = False

        Tabla1.DataGridView1.ClearSelection()
        Tabla2.DataGridView1.ClearSelection()
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Datos.UsuarioLogeado.Ventana1 = ComboBox1.SelectedItem.ToString.Substring(0, 1)
        Tabla1.DataGridView1.DataSource = Verif.VerificarVentanas(1, Datos.UsuarioLogeado.Ventana1)
        CargarTablas()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Datos.UsuarioLogeado.Ventana2 = ComboBox2.SelectedItem.ToString.Substring(0, 1)
        Tabla2.DataGridView1.DataSource = Verif.VerificarVentanas(2, Datos.UsuarioLogeado.Ventana2)
        CargarTablas()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Datos.UsuarioLogeado.Ventana3 = ComboBox3.SelectedItem.ToString.Substring(0, 1)
        Tabla3.DataGridView1.DataSource = Verif.VerificarVentanas(3, Datos.UsuarioLogeado.Ventana3)
        CargarTablas()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Terrenos.Show()
        Me.Close()
    End Sub
End Class