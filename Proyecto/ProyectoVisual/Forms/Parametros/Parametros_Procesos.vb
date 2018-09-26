Imports Negocio

Public Class Parametros_Procesos
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Procesos
    Dim dv As New DataView

    Private Sub Parametros_Procesos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Descripción")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaProcesos
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(7).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
            modificar_BTN.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
            TextBox3.Text = Tabla1.DataGridView1(1, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            TextBox4.Text = Tabla1.DataGridView1(2, Tabla1.DataGridView1.CurrentRow.Index).Value.ToString
            If Tabla1.DataGridView1(3, Tabla1.DataGridView1.CurrentRow.Index).Value = True Then
                CheckBox6.CheckState = CheckState.Checked
            Else
                CheckBox6.CheckState = CheckState.Unchecked
            End If
            If Tabla1.DataGridView1(4, Tabla1.DataGridView1.CurrentRow.Index).Value = True Then
                CheckBox7.CheckState = CheckState.Checked
            Else
                CheckBox7.CheckState = CheckState.Unchecked
            End If
            If Tabla1.DataGridView1(5, Tabla1.DataGridView1.CurrentRow.Index).Value = True Then
                CheckBox8.CheckState = CheckState.Checked
            Else
                CheckBox8.CheckState = CheckState.Unchecked
            End If
            If Tabla1.DataGridView1(6, Tabla1.DataGridView1.CurrentRow.Index).Value = True Then
                CheckBox9.CheckState = CheckState.Checked
            Else
                CheckBox9.CheckState = CheckState.Unchecked
            End If
        End If
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        encapsuladora.NombreProceso = TextBox1.Text
        encapsuladora.DescripcionProceso = TextBox2.Text
        encapsuladora.MateriaPrimaProceso = CheckBox2.CheckState
        encapsuladora.ProductoIntermedioProceso = CheckBox3.CheckState
        If CheckBox4.CheckState = CheckState.Checked Then
            encapsuladora.BarricaProceso = True
        Else
            encapsuladora.BarricaProceso = False
        End If
        If CheckBox5.CheckState = CheckState.Checked Then
            encapsuladora.TanqueProceso = True
        Else
            encapsuladora.TanqueProceso = False
        End If
        Verif.ValidoIngresoProcesos(encapsuladora)
        TextBox1.Clear()
        TextBox2.Clear()
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox4.CheckState = CheckState.Unchecked
        CheckBox5.CheckState = CheckState.Unchecked
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDProceso = Tabla.ID
        Verif.ValidoEliminarProcesos(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Modificar(sender As System.Object, e As System.EventArgs) Handles modificar_BTN.Click
        encapsuladora.IDProceso = Tabla.ID
        encapsuladora.NombreProceso = TextBox3.Text
        encapsuladora.DescripcionProceso = TextBox4.Text
        encapsuladora.MateriaPrimaProceso = CheckBox6.CheckState
        Verif.ValidoModificarProcesos(encapsuladora)
        TextBox3.Clear()
        TextBox4.Clear()
        CheckBox6.CheckState = CheckState.Unchecked
        CheckBox7.CheckState = CheckState.Unchecked
        CheckBox8.CheckState = CheckState.Unchecked
        CheckBox9.CheckState = CheckState.Unchecked
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        modificar_BTN.Focus()
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged, TextBox1.TextChanged, TextBox2.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If

        If CheckBox4.CheckState = CheckState.Checked Then
            CheckBox5.Enabled = False
        ElseIf CheckBox4.CheckState = CheckState.Unchecked Then
            CheckBox5.Enabled = True
        End If

        If CheckBox5.CheckState = CheckState.Checked Then
            CheckBox4.Enabled = False
        ElseIf CheckBox5.CheckState = CheckState.Unchecked Then
            CheckBox4.Enabled = True
        End If

        If CheckBox8.CheckState = CheckState.Checked Then
            CheckBox9.Enabled = False
        ElseIf CheckBox8.CheckState = CheckState.Unchecked Then
            CheckBox9.Enabled = True
        End If

        If CheckBox9.CheckState = CheckState.Checked Then
            CheckBox8.Enabled = False
        ElseIf CheckBox9.CheckState = CheckState.Unchecked Then
            CheckBox8.Enabled = True
        End If
    End Sub

End Class