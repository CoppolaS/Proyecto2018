Imports Negocio

Public Class Parametros_Datos
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Datos
    Dim dv As New DataView

    Private Sub Parametros_Datos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Unidad")
        ComboBox1.Items.Add("Descripción")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaDatos()
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(4).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox7.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox6.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox5.Text = Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreDato = TextBox0.Text
        encapsuladora.UnidadDato = TextBox1.Text
        encapsuladora.DescripcionDato = TextBox2.Text
        Verif.ValidoIngresoDatos(encapsuladora)
        TextBox0.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDDato = Tabla.ID
        Verif.ValidoEliminarDatos(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDDato = Tabla.ID
        encapsuladora.NombreDato = TextBox7.Text
        encapsuladora.UnidadDato = TextBox6.Text
        encapsuladora.DescripcionDato = TextBox5.Text
        Verif.ValidoModificarDatos(encapsuladora)
        TextBox7.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox7.Enabled = False
        TextBox6.Enabled = False
        TextBox5.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox0.TextChanged, TextBox1.TextChanged, TextBox2.TextChanged
        If TextBox0.TextLength > 0 And TextBox1.TextLength > 0 And TextBox2.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub
End Class