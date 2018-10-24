Imports Negocio

Public Class AsignarTratamientos
    Dim Verif As New Negocio.VerificarOtros
    Dim VerifP As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.AsignarTratamientos
    Dim dv As New DataView
    Dim tbl As Integer

    Private Sub GestionCultivos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load, ComboBoxSucursales1.SeleccionCambio
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker4.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        DateTimePicker3.CustomFormat = "yyyy-MM-dd"
        DateTimePicker4.CustomFormat = "yyyy-MM-dd"
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        dv = Verif.ValidoListaHectareas
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox1.Items.Add(dv(i).Item("ID").ToString())
        Next
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
        dv = VerifP.ValidoListaCepas
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox3.Items.Add(dv(i).Item("ID").ToString())
        Next
        dv = VerifP.ValidoListaTratamientos
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox2.Items.Add(dv(i).Item("ID").ToString())
        Next
        CargarTabla1()
    End Sub

    Private Sub CargarTabla1() Handles ComboBox1.SelectedIndexChanged
        dv = Verif.ValidoListaParcelas(ComboBox1.SelectedItem)
        dv.RowFilter = "Eliminado = 0"
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(0).Visible = False
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla2()
        dv = Verif.ValidoListaPlantacionesCosechas(Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString))
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla3()
        dv = VerifP.ValidoListaTratamientos(Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString))
        dv.RowFilter = "Eliminado = 0"
        Tabla3.DataGridView1.DataSource = dv
        Tabla3.DataGridView1.Columns(0).Visible = False
        Tabla3.DataGridView1.Columns(3).Visible = False
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        CargarTabla2()
        CargarTabla3()
        If Tabla2.DataGridView1.RowCount = 0 Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            Button4.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
            Button4.Enabled = True
        End If
    End Sub

    Private Sub AgregarPlantadoCosechado(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        encapsuladora.FechaPlantadoAT = DateTimePicker1.Value
        encapsuladora.ID_CepaAT = Integer.Parse(ComboBox3.SelectedItem)
        encapsuladora.ID_ParcelaAT = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        Verif.ValidoIngresoFechaPlantadoCosechado(encapsuladora)
        ComboBox3.SelectedIndex = -1
        CargarTabla1()
        CargarTabla2()
    End Sub

    Private Sub DesplantarPlantadoCosechado(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        encapsuladora.FechaPlantadoAT = DateTimePicker2.Value
        encapsuladora.ID_ParcelaAT = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        Verif.ValidoFinalizarPlantadoCosechado(encapsuladora)
        ComboBox3.SelectedIndex = -1
        CargarTabla1()
        CargarTabla2()
        CargarTabla3()
    End Sub

    Private Sub AgregarTratamiento(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        encapsuladora.ID_TratamientoAT = Integer.Parse(ComboBox2.SelectedItem)
        encapsuladora.FechaTratamientoAT = DateTimePicker3.Value
        encapsuladora.ID_ParcelaAT = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        Verif.ValidoIngresoTratamiento(encapsuladora)
        ComboBox2.SelectedIndex = -1
        CargarTabla1()
        CargarTabla3()
    End Sub

    Private Sub FinalizarTratamiento(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        encapsuladora.ID_TratamientoAT = Integer.Parse(Tabla3.DataGridView1.Rows(Tabla3.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        encapsuladora.FechaTratamientoAT = DateTimePicker4.Value
        encapsuladora.ID_ParcelaAT = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
        Verif.ValidoFinalizarTratamiento(encapsuladora)
        CargarTabla3()
    End Sub
End Class