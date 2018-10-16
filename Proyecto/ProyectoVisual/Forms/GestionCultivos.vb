Imports Negocio

Public Class GestionCultivos
    Dim Verif As New Negocio.VerificarOtros
    Dim VerifP As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.DatosCultivos
    Dim dv As New DataView
    Dim tbl As Integer

    Private Sub GestionCultivos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load, ComboBoxSucursales1.SeleccionCambio
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Value = Today
        ComboBox1.Items.Clear()
        dv = Verif.ValidoListaHectareas
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox1.Items.Add(dv(i).Item("ID").ToString())
        Next
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
        dv = VerifP.ValidoListaDatos()
        Tabla5.DataGridView1.DataSource = dv
        Tabla5.DataGridView1.Columns(4).Visible = False
        Tabla5.DataGridView1.ClearSelection()
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox2.Items.Add(dv(i).Item("ID").ToString())
        Next
        CargarTabla1()
        CargarTabla2()
        CargarTabla3()
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
        dv = Verif.ValidoListaMateriasPrimas()
        dv.RowFilter = "Eliminado = 0"
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.Columns(6).Visible = False
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla3()
        dv = Verif.ValidoListaProductosIntermedios()
        dv.RowFilter = "Eliminado = 0"
        Tabla3.DataGridView1.DataSource = dv
        Tabla3.DataGridView1.Columns(6).Visible = False
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        tbl = 1
        Button1.Enabled = True
        dv = Verif.ValidoListaParcelasDatos(Tabla.ID)
        Tabla4.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.ClearSelection()
        Tabla3.DataGridView1.ClearSelection()
        Tabla4.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla2.ClickCelda
        tbl = 2
        Button1.Enabled = True
        dv = Verif.ValidoListaMateriasPrimas(Tabla.ID)
        Tabla4.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
        Tabla3.DataGridView1.ClearSelection()
        Tabla4.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada3(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla3.ClickCelda
        tbl = 3
        Button1.Enabled = True
        dv = Verif.ValidoListaProductosIntermedios(Tabla.ID)
        Tabla4.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
        Tabla2.DataGridView1.ClearSelection()
        Tabla4.DataGridView1.ClearSelection()
    End Sub

    Private Sub IngresarDato(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        encapsuladora.NroDato = Integer.Parse(ComboBox2.SelectedItem)
        encapsuladora.ValorDato = Integer.Parse(TextBox1.Text)
        encapsuladora.FechaDato = DateTimePicker1.Value
        encapsuladora.IDDato = Tabla.ID
        If tbl = 1 Then
            Verif.ValidoIngresoParcelasDatos(encapsuladora)
            CargarTabla1()
        End If
        If tbl = 2 Then
            Verif.ValidoIngresoMateriasPrimasDatos(encapsuladora)
            CargarTabla2()
        End If
        If tbl = 3 Then
            Verif.ValidoIngresoProductosIntermediosDatos(encapsuladora)
            CargarTabla3()
        End If
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()
        Button1.Enabled = False
    End Sub

End Class