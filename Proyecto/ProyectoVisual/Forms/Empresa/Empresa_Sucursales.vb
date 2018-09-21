Imports Negocio

Public Class Empresa_Sucursales
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.Sucursales
    Dim dv As New DataView

    Private Sub Empresa_Sucursales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Dirección")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla1()
    End Sub

    Private Sub CargarTabla1()
        dv = Verif.ValidoListaSucursales
        Filtrar(Me, New System.EventArgs)
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla.ID > 0 Then
            If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
                administrar_nombreTB.Enabled = True
                administrar_direccionTB.Enabled = True
                eliminar_BTN.Enabled = True
                modificar_BTN.Enabled = True
                administrar_nombreTB.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
                administrar_direccionTB.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
                Tabla2.DataGridView1.DataSource = Verif.ValidoListaFuncionarios2(Tabla.ID)
                Tabla2.DataGridView1.ClearSelection()
                Tabla2.DataGridView1.Columns(6).Visible = False
            End If
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreSucursal = ingresar_nombreTB.Text
        encapsuladora.DireccionSucursal = ingresar_direccionTB.Text
        Verif.ValidoIngresoSucursales(encapsuladora)
        ingresar_nombreTB.Clear()
        ingresar_direccionTB.Clear()
        CargarTabla1()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDSucursal = Tabla.ID
        Verif.ValidoEliminarSucursales(encapsuladora)
        CargarTabla1()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDSucursal = Tabla.ID
        encapsuladora.NombreSucursal = administrar_nombreTB.Text
        encapsuladora.DireccionSucursal = administrar_direccionTB.Text
        Verif.ValidoModificarSucursales(encapsuladora)
        administrar_nombreTB.Clear()
        administrar_direccionTB.Clear()
        administrar_nombreTB.Enabled = False
        administrar_direccionTB.Enabled = False
        modificar_BTN.Focus()
        CargarTabla1()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles ingresar_nombreTB.TextChanged, ingresar_direccionTB.TextChanged
        If ingresar_nombreTB.TextLength > 0 And ingresar_direccionTB.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub

    Private Sub Filtrar(sender As Object, e As System.EventArgs) Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaSucursales
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
    End Sub
End Class