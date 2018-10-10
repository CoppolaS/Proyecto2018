Imports Negocio

Public Class Parametros_Botellas
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Botellas
    Dim dv As New DataView

    Private Sub Empresa_Cargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles CheckBox1.CheckedChanged
        dv = Verif.ValidoListaBotellas
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = ""
        Else
            dv.RowFilter = "Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(2).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            TextBox2.Enabled = True
            TextBox2.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.CapacidadBotella = TextBox1.Text
        Verif.ValidoIngresoBotellas(encapsuladora)
        TextBox1.Clear()
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDBotella = Tabla.ID
        Verif.ValidoEliminarBotellas(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDBotella = Tabla.ID
        encapsuladora.CapacidadBotella = TextBox2.Text
        Verif.ValidoModificarBotellas(encapsuladora)
        TextBox2.Clear()
        TextBox2.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub

End Class