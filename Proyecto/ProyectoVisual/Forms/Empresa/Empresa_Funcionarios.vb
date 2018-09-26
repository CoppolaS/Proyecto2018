Imports Negocio

Public Class Empresa_Funcionarios
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.Funcionarios
    Dim dv As New DataView

    Private Sub Empresa_Funcionarios_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Apellido")
        ComboBox1.Items.Add("Mail")
        ComboBox1.Items.Add("Usuario")
        ComboBox1.Items.Add("Cargo")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox7.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        dv = Verif.ValidoListaCargos
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox2.Items.Add(dv(i).Item("Nombre").ToString())
            ComboBox5.Items.Add(dv(i).Item("Nombre").ToString())
        Next
        dv = Verif.ValidoListaSucursales
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox4.Items.Add(dv(i).Item("Nombre").ToString())
            ComboBox7.Items.Add(dv(i).Item("Nombre").ToString())
        Next
        If Datos.UsuarioLogeado.Privilegios <> 4 Then
            CheckBox2.Enabled = True
        End If
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles ComboBoxSucursales1.SeleccionCambio, buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaFuncionarios()
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
        Tabla1.DataGridView1.Columns(7).Visible = False
        Tabla1.DataGridView1.Columns(10).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreFuncionario = TextBox1.Text
        encapsuladora.ApellidoFuncionario = TextBox2.Text
        encapsuladora.TelefonoFuncionario = TextBox3.Text
        encapsuladora.MailFuncionario = TextBox4.Text
        encapsuladora.CedulaFuncionario = TextBox5.Text
        encapsuladora.CargoFuncionario = ComboBox2.SelectedItem.ToString
        If ComboBox3.SelectedIndex = -1 Then
            encapsuladora.PrivilegiosFuncionario = 4
        Else
            encapsuladora.PrivilegiosFuncionario = ComboBox3.SelectedItem.ToString
        End If
        encapsuladora.SucursalFuncionario = ComboBox4.SelectedItem.ToString
        encapsuladora.UsuarioFuncionario = TextBox6.Text
        encapsuladora.ContrasenaFuncionario = TextBox7.Text
        Verif.ValidoIngresoFuncionarios(encapsuladora)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox2.SelectedIndex() = -1
        ComboBox3.SelectedIndex() = -1
        ComboBox4.SelectedIndex() = -1
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDFuncionario = Tabla.ID
        encapsuladora.UsuarioFuncionario = Tabla1.DataGridView1(6, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        encapsuladora.ContrasenaFuncionario = Tabla1.DataGridView1(7, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        Verif.ValidoEliminarFuncionarios(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDFuncionario = Tabla.ID
        encapsuladora.NombreFuncionario = TextBox8.Text
        encapsuladora.ApellidoFuncionario = TextBox9.Text
        encapsuladora.TelefonoFuncionario = TextBox10.Text
        encapsuladora.MailFuncionario = TextBox11.Text
        encapsuladora.CedulaFuncionario = TextBox12.Text
        encapsuladora.CargoFuncionario = ComboBox5.SelectedItem.ToString
        encapsuladora.PrivilegiosFuncionario = ComboBox6.SelectedItem.ToString
        encapsuladora.SucursalFuncionario = ComboBox7.SelectedItem.ToString
        encapsuladora.UsuarioFuncionario = TextBox13.Text
        encapsuladora.ContrasenaFuncionario = TextBox14.Text
        Verif.ValidoModificarFuncionarios(encapsuladora)
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        ComboBox5.SelectedIndex() = -1
        ComboBox6.SelectedIndex() = -1
        ComboBox7.SelectedIndex() = -1
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False
        TextBox14.Enabled = False
        ComboBox5.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
            TextBox12.Enabled = True
            TextBox13.Enabled = True
            TextBox14.Enabled = True
            ComboBox5.Enabled = True
            ComboBox6.Enabled = True
            ComboBox7.Enabled = True
            TextBox8.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox9.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox10.Text = Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox11.Text = Tabla1.DataGridView1(4, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox12.Text = Tabla1.DataGridView1(5, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox13.Text = Tabla1.DataGridView1(6, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox14.Text = Tabla1.DataGridView1(7, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            ComboBox5.SelectedItem = Tabla1.DataGridView1(8, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            ComboBox6.SelectedItem = Tabla1.DataGridView1(9, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            ComboBox7.SelectedItem = Tabla1.DataGridView1(10, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Habilitar(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged, Tabla1.ClickCelda, CheckBox2.CheckedChanged, TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, ComboBox2.SelectedIndexChanged, ComboBox3.SelectedIndexChanged, ComboBox4.SelectedIndexChanged
        If CheckBox3.CheckState = CheckState.Checked Then
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            ComboBox3.Enabled = True
        Else
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            ComboBox3.Enabled = False
        End If

        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And TextBox3.TextLength > 0 And TextBox4.TextLength > 0 And TextBox5.TextLength > 0 And ComboBox2.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If

        If CheckBox2.CheckState = CheckState.Checked Then
            Tabla1.DataGridView1.Columns(7).Visible = True
        Else
            Tabla1.DataGridView1.Columns(7).Visible = False
        End If
    End Sub

End Class