Imports Negocio

Public Class GestionCultivos
    Dim Verif As New Negocio.VerificarOtros
    Dim VerifP As New Negocio.VerificarParametros
    Dim dv As New DataView

    Private Sub GestionCultivos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load, ComboBoxSucursales1.SeleccionCambio
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
        dv = VerifP.ValidoListaDatos()
        dv.RowFilter = "Eliminado = 0"
        Tabla4.DataGridView1.Columns.Clear()
        Tabla4.DataGridView1.Columns.Add("Fecha", "Fecha")
        For i As Integer = 0 To dv.Count - 1
            Tabla4.DataGridView1.Columns.Add(dv(i).Item("Nombre").ToString(), dv(i).Item("Nombre").ToString())
        Next
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

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda, Tabla2.ClickCelda, Tabla3.ClickCelda
        Dim TablaSeleccionada As Integer
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            TablaSeleccionada = 1
        End If
        If Tabla2.DataGridView1.SelectedRows.Count > 0 Then
            TablaSeleccionada = 2
        End If
        If Tabla3.DataGridView1.SelectedRows.Count > 0 Then
            TablaSeleccionada = 3
        End If
    End Sub

    'Private Sub CeldaSeleccionada2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If Tabla2.DataGridView1.SelectedRows.Count > 0 Then
    '        Button4.Enabled = True
    '    End If
    'End Sub

    'Private Sub IngresarHectarea(sender As System.Object, e As System.EventArgs)
    '    encapsuladora1.CantidadHectareas = Integer.Parse(TextBox1.Text)
    '    encapsuladora1.SucursalHectarea = Datos.UsuarioLogeado.Sucursal
    '    Verif.ValidoIngresoHectareas(encapsuladora1)
    '    TextBox1.Clear()
    '    CargarTabla1()
    'End Sub

    'Private Sub IngresarParcela(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    '    encapsuladora2.CantidadParcelas = Integer.Parse(TextBox2.Text)
    '    encapsuladora2.MetrosCuadradosParcela = Integer.Parse(TextBox3.Text)
    '    encapsuladora2.IDHectarea = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value)
    '    If (encapsuladora2.CantidadParcelas * encapsuladora2.MetrosCuadradosParcela) > 10000 Or (encapsuladora2.CantidadParcelas * encapsuladora2.MetrosCuadradosParcela) > Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(2).Value Then
    '        MsgBox("No hay suficiente espacio en la hectárea seleccionada")
    '    Else
    '        Verif.ValidoIngresoParcelas(encapsuladora2)
    '    End If
    '    TextBox2.Clear()
    '    TextBox3.Clear()
    '    CargarTabla1()
    '    CargarTabla2()
    'End Sub

    'Private Sub EliminarHectarea(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    encapsuladora1.IDHectarea = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value)
    '    Verif.ValidoEliminarHectareas(encapsuladora1)
    '    CargarTabla1()
    'End Sub

    'Private Sub EliminarParcela(sender As System.Object, e As System.EventArgs) Handles Button4.Click
    '    encapsuladora2.IDParcela = Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(0).Value)
    '    encapsuladora2.MetrosCuadradosParcela = Integer.Parse(Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(2).Value)
    '    encapsuladora2.IDHectarea = Integer.Parse(Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(0).Value)
    '    Verif.ValidoEliminarParcelas(encapsuladora2)
    '    CargarTabla1()
    '    CargarTabla2()
    'End Sub

    'Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged
    '    If TextBox1.TextLength <> 0 Then
    '        Button1.Enabled = True
    '    Else
    '        Button1.Enabled = False
    '    End If

    '    If TextBox2.TextLength <> 0 And TextBox3.TextLength <> 0 And Tabla1.DataGridView1.SelectedRows.Count > 0 Then
    '        Button3.Enabled = True
    '    Else
    '        Button3.Enabled = False
    '    End If
    'End Sub

End Class