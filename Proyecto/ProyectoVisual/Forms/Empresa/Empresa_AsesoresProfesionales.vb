Imports Negocio

Public Class Empresa_AsesoresProfesionales
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.AsesoresProfesionales
    Dim dv As New DataView

    Private Sub Empresa_AsesoresProfesionales_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Apellido")
        ComboBox1.Items.Add("Mail")
        ComboBox1.Items.Add("Tipo")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        dv = Verif.ValidoListaSucursales
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox3.Items.Add(dv(i).Item("Nombre").ToString())
            ComboBox4.Items.Add(dv(i).Item("Nombre").ToString())
        Next
        dv = Verif.ValidoListaTiposAP
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox2.Items.Add(dv(i).Item("Nombre").ToString())
            ComboBox5.Items.Add(dv(i).Item("Nombre").ToString())
        Next
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles ComboBoxSucursales1.SeleccionCambio, buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaAsesoresProfesionales()
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(6).Visible = False
        Tabla1.DataGridView1.Columns(9).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        encapsuladora.NombreAsesorProfesional = TextBox1.Text
        encapsuladora.ApellidoAsesorProfesional = TextBox2.Text
        encapsuladora.TelefonoAsesorProfesional = TextBox3.Text
        encapsuladora.MailAsesorProfesional = TextBox9.Text
        encapsuladora.CedulaAsesorProfesional = TextBox4.Text
        encapsuladora.TipoAsesorProfesional = ComboBox2.SelectedItem.ToString
        encapsuladora.SucursalAsesorProfesional = ComboBox4.SelectedItem.ToString
        encapsuladora.UsuarioAsesorProfesional = TextBox11.Text
        encapsuladora.ContrasenaAsesorProfesional = TextBox12.Text
        Verif.ValidoIngresoAsesoresProfesionales(encapsuladora)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        ComboBox2.SelectedIndex() = -1
        ComboBox4.SelectedIndex() = -1
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        encapsuladora.IDAsesorProfesional = Tabla.ID
        Verif.ValidoEliminarAsesoresProfesionales(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        encapsuladora.IDAsesorProfesional = Tabla.ID
        encapsuladora.NombreAsesorProfesional = TextBox10.Text
        encapsuladora.ApellidoAsesorProfesional = TextBox8.Text
        encapsuladora.TelefonoAsesorProfesional = TextBox6.Text
        encapsuladora.MailAsesorProfesional = TextBox5.Text
        encapsuladora.CedulaAsesorProfesional = TextBox7.Text
        encapsuladora.TipoAsesorProfesional = ComboBox5.SelectedItem.ToString
        encapsuladora.SucursalAsesorProfesional = ComboBox3.SelectedItem.ToString
        encapsuladora.UsuarioAsesorProfesional = TextBox13.Text
        encapsuladora.ContrasenaAsesorProfesional = TextBox14.Text
        Verif.ValidoModificarAsesoresProfesionales(encapsuladora)
        TextBox10.Clear()
        TextBox8.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        ComboBox5.SelectedIndex() = -1
        ComboBox3.SelectedIndex() = -1
        TextBox10.Enabled = False
        TextBox8.Enabled = False
        TextBox6.Enabled = False
        TextBox5.Enabled = False
        TextBox7.Enabled = False
        TextBox13.Enabled = False
        TextBox14.Enabled = False
        ComboBox5.Enabled = False
        ComboBox3.Enabled = False
        Button3.Focus()
        CargarTabla()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            Button2.Enabled = True
            Button3.Enabled = True
            TextBox10.Enabled = True
            TextBox8.Enabled = True
            TextBox6.Enabled = True
            TextBox5.Enabled = True
            TextBox7.Enabled = True
            TextBox13.Enabled = True
            TextBox14.Enabled = True
            ComboBox5.Enabled = True
            ComboBox3.Enabled = True
            TextBox10.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox8.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox6.Text = Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox5.Text = Tabla1.DataGridView1(4, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox7.Text = Tabla1.DataGridView1(5, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox13.Text = Tabla1.DataGridView1(10, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox14.Text = Tabla1.DataGridView1(11, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            ComboBox5.SelectedItem = Tabla1.DataGridView1(7, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            ComboBox3.SelectedItem = Tabla1.DataGridView1(9, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Habilitar(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox9.TextChanged, ComboBox2.SelectedIndexChanged, ComboBox4.SelectedIndexChanged, TextBox11.TextChanged, TextBox12.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And TextBox3.TextLength > 0 And TextBox4.TextLength > 0 And TextBox9.TextLength > 0 And TextBox11.TextLength > 0 And TextBox12.TextLength > 0 And ComboBox2.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Validar_Click(sender As System.Object, e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        encapsuladora.IDAsesorProfesional = Tabla.ID
        encapsuladora.ValidoAsesorProfesional = ComboBox6.SelectedIndex
        Verif.ValidoUsuarioWebAsesorProfesional(encapsuladora)
        CargarTabla()
    End Sub
End Class