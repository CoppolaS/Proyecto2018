﻿Imports Negocio

Public Class Empresa_Vendedores
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.Vendedores
    Dim dv As New DataView

    Private Sub Empresa_Vendedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Mail")
        ComboBox1.Items.Add("Dirección")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaVendedores
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(5).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaClickeada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            TextBox5.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox6.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox7.Text = Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox8.Text = Tabla1.DataGridView1(4, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreVendedor = TextBox1.Text
        encapsuladora.TelefonoVendedor = TextBox2.Text
        encapsuladora.MailVendedor = TextBox3.Text
        encapsuladora.DireccionVendedor = TextBox4.Text
        Verif.ValidoIngresoVendedores(encapsuladora)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDVendedor = Tabla.ID
        Verif.ValidoEliminarVendedores(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDVendedor = Tabla.ID
        encapsuladora.NombreVendedor = TextBox5.Text
        encapsuladora.TelefonoVendedor = TextBox6.Text
        encapsuladora.MailVendedor = TextBox7.Text
        encapsuladora.DireccionVendedor = TextBox8.Text
        Verif.ValidoModificarVendedores(encapsuladora)
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And TextBox3.TextLength > 0 And TextBox4.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub

End Class