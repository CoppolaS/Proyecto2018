Imports Negocio

Public Class Empresa_Sucursales
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.Sucursales
    Dim dv As New DataView
    'pasar logica a negocio

    Private Sub Empresa_Sucursales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Tabla2.DataGridView1.Columns.Add("a", "ID")
        Tabla2.DataGridView1.Columns.Add("b", "Nombre")
        Tabla2.DataGridView1.Columns.Add("c", "Apellido")
        Tabla2.DataGridView1.Columns.Add("d", "Teléfono")
        Tabla2.DataGridView1.Columns.Add("e", "Mail")
        Tabla2.DataGridView1.Columns.Add("f", "Cédula")
        Tabla2.DataGridView1.Columns.Add("g", "Cargo")
        Tabla2.DataGridView1.Columns.Add("h", "Usuario")
        Tabla1.DataGridView1.DataSource = Verif.ValidoListaSucursales.Tables(0).DefaultView
        For Each DataGridViewColumn In Tabla1.DataGridView1.Columns
            Dim i As Integer
            ComboBox1.Items.Add(Tabla1.DataGridView1.Columns(i).HeaderText.ToString)
            i = i + 1
        Next
        ComboBox1.SelectedIndex() = 1
        'CargarTabla()
    End Sub

    Private Sub CargarTabla()
        Tabla1.DataGridView1.Rows.Clear()
        For i = 0 To Verif.ValidoListaSucursales.Tables(0).Rows.Count - 1
            If Verif.ValidoListaSucursales.Tables(0).Rows(i).Item(3) = 0 Then
                Tabla1.DataGridView1.DataSource = Verif.ValidoListaSucursales.Tables(0).Rows(i).Item(3)
            End If
        Next
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    'Private Sub CargarTabla2(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Tabla1.Paint
    '    If Tabla.ID > 0 Then
    '        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
    '            administrar_nombreTB.Enabled = True
    '            administrar_direccionTB.Enabled = True
    '            eliminar_BTN.Enabled = True
    '            modificar_BTN.Enabled = True
    '            administrar_nombreTB.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
    '            administrar_direccionTB.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
    '            Tabla2.DataGridView1.Rows.Clear()
    '            For Each itemFuncionario As Encapsuladoras.Funcionarios In Verif.ValidoListaFuncionarios(Tabla.ID)
    '                If itemFuncionario.EliminadoFuncionario = False Then
    '                    Tabla2.DataGridView1.Rows.Add(itemFuncionario.IDFuncionario, itemFuncionario.NombreFuncionario, itemFuncionario.ApellidoFuncionario, itemFuncionario.TelefonoFuncionario.ToString.Insert(0, "0"), itemFuncionario.MailFuncionario, itemFuncionario.CedulaFuncionario, itemFuncionario.CargoFuncionario, itemFuncionario.UsuarioFuncionario)
    '                End If
    '            Next
    '            Tabla2.DataGridView1.ClearSelection()
    '        End If
    '    End If
    'End Sub

    'Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
    '    encapsuladora.NombreSucursal = ingresar_nombreTB.Text
    '    encapsuladora.DireccionSucursal = ingresar_direccionTB.Text
    '    Verif.ValidoIngresoSucursales(encapsuladora)
    '    ingresar_nombreTB.Clear()
    '    ingresar_direccionTB.Clear()
    '    CargarTabla()
    'End Sub

    'Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
    '    encapsuladora.IDSucursal = Tabla.ID
    '    Verif.ValidoEliminarSucursales(encapsuladora)
    '    CargarTabla()
    'End Sub


    'Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
    '    encapsuladora.IDSucursal = Tabla.ID
    '    encapsuladora.NombreSucursal = administrar_nombreTB.Text
    '    encapsuladora.DireccionSucursal = administrar_direccionTB.Text
    '    Verif.ValidoModificarSucursales(encapsuladora)
    '    administrar_nombreTB.Clear()
    '    administrar_direccionTB.Clear()
    '    administrar_nombreTB.Enabled = False
    '    administrar_direccionTB.Enabled = False
    '    modificar_BTN.Focus()
    '    CargarTabla()
    'End Sub

    Private Sub habilitar_ingreso(sender As Object, e As System.EventArgs) Handles ingresar_nombreTB.TextChanged, ingresar_direccionTB.TextChanged
        If ingresar_nombreTB.TextLength > 0 And ingresar_direccionTB.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub

    Private Sub buscador_TextChanged(sender As Object, e As System.EventArgs) Handles buscador.TextChanged
        dv = Verif.ValidoListaSucursales.Tables(0).DefaultView
        dv.RowFilter = "Nombre = " & buscador.Text
        'Verif.ValidoListaSucursales.Tables(0).DefaultView.RowFilter = "nombre Like '%" & buscador.Text & "%'"
        'ComboBox1.SelectedItem.ToString & " " & buscador.Text
    End Sub

End Class