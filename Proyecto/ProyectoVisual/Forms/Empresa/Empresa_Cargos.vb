Imports Negocio

Public Class Empresa_Cargos
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.Cargos
    Dim dv As New DataView

    Private Sub Empresa_Cargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla()
        dv = Verif.ValidoListaCargos
        Filtrar(Me, New System.EventArgs)
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(2).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            administrar_nombreTB.Enabled = True
            administrar_nombreTB.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreCargo = ingresar_nombreTB.Text
        Verif.ValidoIngresoCargos(encapsuladora)
        ingresar_nombreTB.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDCargo = Tabla.ID
        Verif.ValidoEliminarCargos(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDCargo = Tabla.ID
        encapsuladora.NombreCargo = administrar_nombreTB.Text
        Verif.ValidoModificarCargos(encapsuladora)
        administrar_nombreTB.Clear()
        administrar_nombreTB.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles ingresar_nombreTB.TextChanged
        If ingresar_nombreTB.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub

    Private Sub Filtrar(sender As Object, e As System.EventArgs) Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaCargos
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
    End Sub
End Class