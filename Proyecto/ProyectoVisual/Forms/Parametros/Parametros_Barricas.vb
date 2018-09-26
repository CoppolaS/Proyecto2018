Imports Negocio

Public Class Parametros_Barricas
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Barricas
    Dim dv As New DataView

    Private Sub Parametros_Barricas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Material")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles ComboBoxSucursales1.SeleccionCambio, buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaBarricas()
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(6).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            CheckBox2.Enabled = True
            TextBox7.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            If Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value = True Then
                CheckBox2.CheckState = CheckState.Checked
            Else
                CheckBox2.CheckState = CheckState.Unchecked
            End If
            TextBox6.Text = Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox5.Text = Tabla1.DataGridView1(4, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox4.Text = Tabla1.DataGridView1(5, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NumeroBarrica = TextBox0.Text
        encapsuladora.DisponibleBarrica = True
        encapsuladora.CapacidadBarrica = TextBox1.Text
        encapsuladora.MaterialBarrica = TextBox2.Text
        encapsuladora.UsosBarrica = TextBox3.Text
        encapsuladora.SucursalBarrica = Datos.UsuarioLogeado.Sucursal
        Verif.ValidoIngresoBarricas(encapsuladora)
        TextBox0.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDBarrica = Tabla.ID
        Verif.ValidoEliminarBarricas(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDBarrica = Tabla.ID
        encapsuladora.NumeroBarrica = TextBox7.Text
        encapsuladora.DisponibleBarrica = CheckBox2.CheckState
        encapsuladora.CapacidadBarrica = TextBox6.Text
        encapsuladora.MaterialBarrica = TextBox5.Text
        encapsuladora.UsosBarrica = TextBox4.Text
        Verif.ValidoModificarBarricas(encapsuladora)
        TextBox7.Clear()
        CheckBox2.CheckState = CheckState.Unchecked
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox7.Enabled = False
        TextBox6.Enabled = False
        TextBox5.Enabled = False
        TextBox4.Enabled = False
        CheckBox2.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox0.TextChanged, TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged
        If TextBox0.TextLength > 0 And TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And TextBox3.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub

End Class