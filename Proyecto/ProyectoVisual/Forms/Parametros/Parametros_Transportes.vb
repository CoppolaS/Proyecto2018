Imports Negocio

Public Class Parametros_Transportes
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Transportes
    Dim dv As New DataView

    Private Sub Parametros_Tratamientos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Add("Producto")
        ComboBox1.Items.Add("Tipo")
        ComboBox1.Items.Add("Nombre")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaTransportes
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(7).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaClickeada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            NumericUpDown6.Enabled = True
            NumericUpDown5.Enabled = True
            NumericUpDown4.Enabled = True
            TextBox6.Enabled = True
            TextBox5.Enabled = True
            TextBox1.Enabled = True
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            NumericUpDown6.Value = Integer.Parse(Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString)
            TextBox6.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox5.Text = Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox1.Text = Tabla1.DataGridView1(4, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            NumericUpDown5.Value = Integer.Parse(Tabla1.DataGridView1(5, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString)
            NumericUpDown4.Value = Integer.Parse(Tabla1.DataGridView1(6, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString)
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.CapacidadTransporte = NumericUpDown1.Value
        encapsuladora.ProductoTransporte = TextBox2.Text
        encapsuladora.TipoTransporte = TextBox3.Text
        encapsuladora.NombreTransporte = TextBox4.Text
        encapsuladora.OcupadosTransporte = NumericUpDown2.Value
        encapsuladora.CantidadTransporte = NumericUpDown3.Value
        Verif.ValidoIngresoTransportes(encapsuladora)
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDTransporte = Tabla.ID
        Verif.ValidoEliminarTransportes(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDTransporte = Tabla.ID
        encapsuladora.CapacidadTransporte = NumericUpDown6.Value
        encapsuladora.ProductoTransporte = TextBox6.Text
        encapsuladora.TipoTransporte = TextBox5.Text
        encapsuladora.NombreTransporte = TextBox1.Text
        encapsuladora.OcupadosTransporte = NumericUpDown5.Value
        encapsuladora.CantidadTransporte = NumericUpDown4.Value
        Verif.ValidoModificarTransportes(encapsuladora)
        NumericUpDown6.Value = 0
        NumericUpDown5.Value = 0
        NumericUpDown4.Value = 0
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox1.Clear()
        NumericUpDown6.Enabled = False
        NumericUpDown5.Enabled = False
        NumericUpDown4.Enabled = False
        TextBox6.Enabled = False
        TextBox5.Enabled = False
        TextBox1.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged
        If TextBox2.TextLength > 0 And TextBox3.TextLength > 0 And TextBox4.TextLength > 0 And NumericUpDown1.Value > 0 And NumericUpDown2.Value > 0 And NumericUpDown3.Value > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub
End Class