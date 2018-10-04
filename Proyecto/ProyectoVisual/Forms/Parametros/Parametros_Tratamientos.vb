Imports Negocio

Public Class Parametros_Tratamientos
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Tratamientos
    Dim dv As New DataView

    Private Sub Parametros_Tratamientos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Descripción")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaTratamientos
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaClickeada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            administrar_nombreTB.Enabled = True
            TextBox2.Enabled = True
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            administrar_nombreTB.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox2.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreTratamiento = ingresar_nombreTB.Text
        encapsuladora.DescripcionTratamiento = TextBox1.Text
        Verif.ValidoIngresoTratamientos(encapsuladora)
        ingresar_nombreTB.Clear()
        TextBox1.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDTratamiento = Tabla.ID
        Verif.ValidoEliminarTratamientos(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDTratamiento = Tabla.ID
        encapsuladora.NombreTratamiento = administrar_nombreTB.Text
        encapsuladora.DescripcionTratamiento = TextBox2.Text
        Verif.ValidoModificarTratamientos(encapsuladora)
        administrar_nombreTB.Clear()
        TextBox2.Clear()
        administrar_nombreTB.Enabled = False
        TextBox2.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles ingresar_nombreTB.TextChanged, TextBox1.TextChanged
        If ingresar_nombreTB.TextLength > 0 And TextBox1.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub
End Class