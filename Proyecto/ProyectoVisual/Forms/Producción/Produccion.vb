Imports Negocio

Public Class Produccion
    Dim Verif As New Negocio.VerificarOtros
    Dim VerifP As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Produccion
    Dim dv As New DataView

    Private Sub GestionCultivos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load, ComboBoxSucursales1.SeleccionCambio
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        dv = Verif.ValidoListaHectareas
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
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
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox3.Items.Add(dv(i).Item("ID").ToString())
        Next
    End Sub

    Private Sub CargarTabla1() Handles ComboBox1.SelectedIndexChanged
        dv = Verif.ValidoListaParcelasPlantaciones(ComboBox1.SelectedItem)
        dv.RowFilter = "Eliminado = 0"
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(0).Visible = False
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla2()
        dv = Verif.ValidoListaMateriasPrimas()
        dv.RowFilter = "Eliminado = 0"
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.Columns(6).Visible = False
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla3()
        dv = Verif.ValidoListaProductosIntermedios()
        dv.RowFilter = "Eliminado = 0"
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.Columns(6).Visible = False
        Tabla2.DataGridView1.ClearSelection()
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
        encapsuladora.FechaInicioProcesoP = DateTimePicker2.Value
        encapsuladora.ID_ProcesoP = Integer.Parse(ComboBox3.SelectedItem)
        Verif.ValidoAsignarProcesoMP(encapsuladora)
        ComboBox3.SelectedIndex = -1
        CargarTabla2()
    End Sub

End Class