Imports Negocio

Public Class Produccion
    Dim Verif As New Negocio.VerificarOtros
    Dim VerifP As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Produccion
    Dim dv As New DataView

    Private Sub GestionCultivos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load, ComboBoxSucursales1.SeleccionCambio
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.SelectedIndex = 0
        ComboBox7.SelectedIndex = 0
        Tabla8.DataGridView1.Columns.Clear()
        Tabla9.DataGridView1.Columns.Clear()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = "yyyy-MM-dd"
        DateTimePicker4.Format = DateTimePickerFormat.Custom
        DateTimePicker4.CustomFormat = "yyyy-MM-dd"
        DateTimePicker5.Format = DateTimePickerFormat.Custom
        DateTimePicker5.CustomFormat = "yyyy-MM-dd"
        dv = Verif.ValidoListaHectareas
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox7.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox1.Items.Add(dv(i).Item("ID").ToString())
        Next
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
        CargarTabla1()
        CargarTabla2()
        CargarTabla3()
        dv = VerifP.ValidoListaProcesos
        dv.RowFilter = "Eliminado = 0 and [Uso de materia prima] = 1"
        For i As Integer = 0 To dv.Count - 1
            ComboBox3.Items.Add(dv(i).Item("ID").ToString())
        Next
        dv.RowFilter = "Eliminado = 0 and [Uso de producto intermedio] = 1"
        For i As Integer = 0 To dv.Count - 1
            ComboBox4.Items.Add(dv(i).Item("ID").ToString())
        Next
        dv = VerifP.ValidoListaVinos
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox5.Items.Add(dv(i).Item("ID").ToString())
        Next
        Tabla8.DataGridView1.Columns.Add("1", "ID de la materia prima seleccionada")
        Tabla8.DataGridView1.Columns.Add("2", "Cepa de la materia prima seleccionada")
        Tabla8.DataGridView1.Columns.Add("3", "Cantidad de kilos a prensar")
        Tabla9.DataGridView1.Columns.Add("1", "ID del producto intermedio seleccionado")
        Tabla9.DataGridView1.Columns.Add("2", "Cepa del producto intermedio seleccionado")
        Tabla9.DataGridView1.Columns.Add("3", "Cantidad de litros a embotellar")
        Tabla9.DataGridView1.Columns.Add("4", "ID_Cepa")
        Tabla9.DataGridView1.Columns(3).Visible = False
        TabControl1.SelectedTab = TabPage3
        TabControl2.SelectedTab = TabPage6
    End Sub

    Private Sub CargarTabla1() Handles ComboBox1.SelectedIndexChanged
        dv = Verif.ValidoListaParcelasPlantaciones(ComboBox1.SelectedItem)
        dv.RowFilter = "Eliminado = 0"
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(0).Visible = False
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla2() Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedIndex = 0 Then
            dv = Verif.ValidoListaMateriasPrimasProcesos(6)
            Button4.Enabled = True
            Button5.Enabled = False
        Else
            dv = Verif.ValidoListaMateriasPrimasProcesos(7)
            Button4.Enabled = False
            Button5.Enabled = True
        End If
        If Tabla8.DataGridView1.RowCount > 0 Then
            dv.RowFilter = "Eliminado = 0 and [Cantidad actual] <> 0 and [Nombre de cepa] = '" + Tabla8.DataGridView1.Rows(0).Cells(1).Value.ToString + "'"
        Else
            dv.RowFilter = "Eliminado = 0 and [Cantidad actual] <> 0"
        End If
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.Columns(2).Visible = False
        Tabla2.DataGridView1.Columns(7).Visible = False
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla3() Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedIndex = 0 Then
            dv = Verif.ValidoListaProductosIntermediosProcesos(8)
            Button8.Enabled = True
            Button9.Enabled = False
        Else
            dv = Verif.ValidoListaProductosIntermediosProcesos(9)
            Button8.Enabled = False
            Button9.Enabled = True
        End If
        dv.RowFilter = "Eliminado = 0 and [Cantidad actual] <> 0"
        Tabla3.DataGridView1.DataSource = dv
        Tabla3.DataGridView1.Columns(2).Visible = False
        Tabla3.DataGridView1.Columns(7).Visible = False
        Tabla3.DataGridView1.Columns(8).Visible = False
        Tabla3.DataGridView1.Columns(11).Visible = False
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub Cosechar(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        encapsuladora.ID_ParcelaP = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        encapsuladora.FechaCosechadoP = DateTimePicker1.Value
        encapsuladora.CantidadP = Integer.Parse(TextBox1.Text)
        encapsuladora.EstadoSanitarioP = Integer.Parse(ComboBox2.SelectedItem)
        Verif.ValidoIngresoParcelasCosechas(encapsuladora)
        TextBox1.Clear()
        ComboBox2.SelectedIndex = -1
        CargarTabla1()
        CargarTabla2()
    End Sub

    Private Sub AsignarProcesoMP(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        encapsuladora.IDMateriaPrimaP = Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        encapsuladora.FechaProcesoP = DateTimePicker2.Value
        encapsuladora.ID_ProcesoP = Integer.Parse(ComboBox3.SelectedItem)
        Verif.ValidoAsignarProcesoMP(encapsuladora)
        ComboBox3.SelectedIndex = -1
        CargarTabla2()
    End Sub

    Private Sub FinalizarProcesoMP(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        encapsuladora.IDMateriaPrimaP = Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        encapsuladora.FechaProcesoP = DateTimePicker3.Value
        Verif.ValidoFinalizarProcesoMP(encapsuladora)
        CargarTabla2()
    End Sub

    Private Sub AsignarProcesoPI(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Tabla4.DataGridView1.Rows.Count > 0 Then
            encapsuladora.IDProductoIntermedioP = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            encapsuladora.FechaProcesoP = DateTimePicker4.Value
            encapsuladora.ID_ProcesoP = Integer.Parse(ComboBox4.SelectedItem)
            Verif.ValidoAsignarProcesoPI(encapsuladora)
            If Tabla4.DataGridView1.Columns.Count = 6 Then
                For i As Integer = 0 To Tabla4.DataGridView1.Rows.Count - 1
                    encapsuladora.ID_TanqueP = Integer.Parse(Tabla4.DataGridView1.Rows(i).Cells(0).Value.ToString)
                    Verif.ValidoAsignarTanqueProcesoPI(encapsuladora)
                Next
            Else
                For i As Integer = 0 To Tabla4.DataGridView1.Rows.Count - 1
                    encapsuladora.ID_BarricaP = Integer.Parse(Tabla4.DataGridView1.Rows(i).Cells(0).Value.ToString)
                    Verif.ValidoAsignarBarricaProcesoPI(encapsuladora)
                Next
            End If
            CargarTabla3()
            Tabla4.DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub FinalizarProcesoPI(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        encapsuladora.IDProductoIntermedioP = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        encapsuladora.FechaProcesoP = DateTimePicker5.Value
        Verif.ValidoFinalizarProcesoPI(encapsuladora)
        CargarTabla3()
    End Sub

    Private Sub AgregarPrensar(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Tabla2.DataGridView1.SelectedRows.Count > 0 And ComboBox6.SelectedIndex = 0 And Integer.Parse(TextBox5.Text) <= Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString) Then
            Dim ID As Integer = Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            Dim Cepa As String = Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(10).Value.ToString
            Tabla8.DataGridView1.Rows.Add(ID, Cepa, TextBox5.Text)
            CargarTabla2()
            Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(4).Value = Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString) - Integer.Parse(TextBox5.Text)
        End If
    End Sub

    Private Sub QuitarPrensar(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If Tabla8.DataGridView1.SelectedRows.Count > 0 Then
            Tabla8.DataGridView1.Rows.RemoveAt(Tabla8.DataGridView1.CurrentRow.Index)
            CargarTabla2()
        End If
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, ComboBox2.SelectedIndexChanged, DateTimePicker1.ValueChanged
        If TextBox1.TextLength > 0 And ComboBox2.SelectedIndex <> -1 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

        If TextBox5.TextLength > 0 Then
            Button10.Enabled = True
        Else
            Button10.Enabled = False
        End If

        If TextBox6.TextLength > 0 Then
            Button12.Enabled = True
        Else
            Button12.Enabled = False
        End If
    End Sub

    Private Sub AceptarPrensado(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If Tabla8.DataGridView1.RowCount > 0 Then
            encapsuladora.FechaAvanceP = DateTimePicker6.Value
            encapsuladora.CantidadLitrosP = Integer.Parse(TextBox6.Text)
            Verif.ValidoAceptarPrensado1(encapsuladora)
            For i As Integer = 0 To Tabla8.DataGridView1.RowCount - 1
                encapsuladora.IDMateriaPrimaP = Integer.Parse(Tabla8.DataGridView1.Rows(i).Cells(0).Value.ToString)
                encapsuladora.CantidadP = Integer.Parse(Tabla8.DataGridView1.Rows(i).Cells(2).Value.ToString)
                encapsuladora.FechaAvanceP = DateTimePicker6.Value
                encapsuladora.CantidadLitrosP = Integer.Parse(TextBox6.Text)
                Verif.ValidoAceptarPrensado2(encapsuladora)
            Next
            CargarTabla2()
            CargarTabla3()
        End If
    End Sub

    Private Sub ProcesoPIcambio(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        dv = Verif.ValidoListaTanquesBarricas(Integer.Parse(ComboBox4.SelectedItem))
        dv.RowFilter = "Eliminado = 0"
        Tabla5.DataGridView1.DataSource = dv
        Try
            Tabla4.DataGridView1.Columns.Clear()
        Catch ex As Exception
        End Try
        For i As Integer = 0 To Tabla5.DataGridView1.Columns.Count - 1
            Tabla4.DataGridView1.Columns.Add(Tabla5.DataGridView1.Columns.Item(i).HeaderText, Tabla5.DataGridView1.Columns.Item(i).HeaderText)
        Next
        If Tabla5.DataGridView1.Columns.Count = 6 Then
            Label26.Text = "Agregar los tanques a usar"
        Else
            Label26.Text = "Agregar las barricas a usar"
        End If
        Tabla4.DataGridView1.Columns(1).Visible = False
        Tabla4.DataGridView1.Columns(2).Visible = False
        Tabla4.DataGridView1.Columns("Eliminado").Visible = False
        Tabla5.DataGridView1.Columns(1).Visible = False
        Tabla5.DataGridView1.Columns(2).Visible = False
        Tabla5.DataGridView1.Columns("Eliminado").Visible = False
        Tabla4.DataGridView1.ClearSelection()
        Tabla5.DataGridView1.ClearSelection()
    End Sub

    Private Sub AgregarProcesoPI(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Tabla5.DataGridView1.SelectedRows.Count > 0 Then
            Dim ID As Integer = Integer.Parse(Tabla5.DataGridView1.Rows(Tabla5.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            Dim Nro As Integer = Integer.Parse(Tabla5.DataGridView1.Rows(Tabla5.DataGridView1.CurrentRow.Index).Cells(1).Value.ToString)
            Dim Cap As Integer = Integer.Parse(Tabla5.DataGridView1.Rows(Tabla5.DataGridView1.CurrentRow.Index).Cells(3).Value.ToString)
            Dim Mat As String = Tabla5.DataGridView1.Rows(Tabla5.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString
            If Tabla5.DataGridView1.Columns.Count = 6 Then
                Tabla4.DataGridView1.Rows.Add(ID, Nro, 0, Cap, Mat, 0)
            Else
                Dim NroUsos As Integer = Integer.Parse(Tabla5.DataGridView1.Rows(Tabla5.DataGridView1.CurrentRow.Index).Cells(5).Value.ToString)
                Tabla4.DataGridView1.Rows.Add(ID, Nro, 0, Cap, Mat, NroUsos, 0)
            End If
            'Tabla5.DataGridView1.CurrentRow.Visible = False
            Tabla4.DataGridView1.ClearSelection()
        End If
    End Sub

    Private Sub QuitarProcesoPI(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'For i As Integer = 0 To Tabla5.DataGridView1.Rows.Count - 1
        '    If Integer.Parse(Tabla5.DataGridView1.Rows(i).Cells(0).Value.ToString) = Integer.Parse(Tabla4.DataGridView1.Rows(Tabla4.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString) Then
        '        Tabla5.DataGridView1.Rows(i).Visible = True
        '    End If
        'Next
        If Tabla4.DataGridView1.SelectedRows.Count > 0 Then
            Tabla4.DataGridView1.Rows.RemoveAt(Tabla4.DataGridView1.CurrentRow.Index)
            Tabla4.DataGridView1.ClearSelection()
        End If
    End Sub

    Private Sub AgregarCepa(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Tabla3.DataGridView1.SelectedRows.Count > 0 And ComboBox7.SelectedIndex = 0 And Integer.Parse(TextBox7.Text) <= Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString) Then
            Dim ID As Integer = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            Dim Cepa As String = Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(10).Value.ToString
            Dim IDCepa As Integer = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(11).Value.ToString)
            Tabla9.DataGridView1.Rows.Add(ID, Cepa, TextBox7.Text, IDCepa)
            Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(4).Value = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString) - Integer.Parse(TextBox7.Text)
        End If
    End Sub

    Private Sub QuitarCepa(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If Tabla9.DataGridView1.SelectedRows.Count > 0 Then
            Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(4).Value = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString) + Integer.Parse(Tabla9.DataGridView1.Rows(Tabla9.DataGridView1.CurrentRow.Index).Cells(2).Value.ToString)
            Tabla9.DataGridView1.Rows.RemoveAt(Tabla9.DataGridView1.CurrentRow.Index)
        End If
    End Sub

End Class