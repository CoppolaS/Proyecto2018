Imports Negocio

Public Class Empresa_TiposDeAsesores
    Dim Verif As New Negocio.VerificarEmpresa
    Dim encapsuladora As New Encapsuladoras.TiposAP
    Dim dv As New DataView

    Private Sub Empresa_TiposAP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaTiposAP
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            administrar_nombreTB.Enabled = True
            CheckBox3.Enabled = True
            administrar_nombreTB.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            If Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value = True Then
                CheckBox3.CheckState = CheckState.Checked
            Else
                CheckBox3.CheckState = CheckState.Unchecked
            End If
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreTipoAP = ingresar_nombreTB.Text
        encapsuladora.AlarmasTipoAP = CheckBox2.CheckState
        Verif.ValidoIngresoTiposAP(encapsuladora)
        ingresar_nombreTB.Clear()
        CheckBox2.CheckState = CheckState.Unchecked
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDTipoAP = Tabla.ID
        Verif.ValidoEliminarTiposAP(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDTipoAP = Tabla.ID
        encapsuladora.NombreTipoAP = administrar_nombreTB.Text
        encapsuladora.AlarmasTipoAP = CheckBox3.CheckState
        Verif.ValidoModificarTiposAP(encapsuladora)
        administrar_nombreTB.Clear()
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox3.Enabled = False
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

End Class