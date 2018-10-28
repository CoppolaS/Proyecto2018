Imports Negocio

Public Class GestionProduccion
    Dim Verif As New Negocio.VerificarOtros
    Dim encapsuladora As New Encapsuladoras.GestionProduccion
    Dim dv As New DataView
    Dim tbl As Integer

    Private Sub GestionCultivos_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex = 0
        CargarTabla1()
        CargarTabla2()
    End Sub

    Private Sub CargarTabla1() Handles ComboBox1.SelectedIndexChanged
        dv = Verif.ValidoListaMateriasPrimas
        If ComboBox1.SelectedIndex = 0 Then
            dv.RowFilter = "Eliminado = 0"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            dv.RowFilter = "Eliminado = 0 and Venta = 1"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            dv.RowFilter = "Eliminado = 0 and Venta = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(7).Visible = False
        Tabla1.DataGridView1.ClearSelection()
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla2() Handles ComboBox1.SelectedIndexChanged
        dv = Verif.ValidoListaProductosIntermedios()
        If ComboBox1.SelectedIndex = 0 Then
            dv.RowFilter = "Eliminado = 0"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            dv.RowFilter = "Eliminado = 0 and Venta = 1"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            dv.RowFilter = "Eliminado = 0 and Venta = 0"
        End If
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.Columns(7).Visible = False
        Tabla1.DataGridView1.ClearSelection()
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        tbl = 1
        Button1.Enabled = True
        Button2.Enabled = True
        Tabla2.DataGridView1.ClearSelection()
        Label5.Text = "Cantidad actual: " & Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString
    End Sub

    Private Sub CeldaSeleccionada2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla2.ClickCelda
        tbl = 2
        Button1.Enabled = True
        Button2.Enabled = True
        Tabla1.DataGridView1.ClearSelection()
        Label5.Text = "Cantidad actual: " & Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString
    End Sub

    Private Sub PonerEnVenta(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If tbl = 1 And (Tabla1.DataGridView1.Rows(Tabla1.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString < Integer.Parse(TextBox3.Text)) Then
            MsgBox("La cantidad seleccionada es mayor a la cantidad actual")
            Exit Sub
        End If
        If tbl = 2 And (Tabla2.DataGridView1.Rows(Tabla2.DataGridView1.CurrentRow.Index).Cells(4).Value.ToString < Integer.Parse(TextBox3.Text)) Then
            MsgBox("La cantidad seleccionada es mayor a la cantidad actual")
            Exit Sub
        End If
        encapsuladora.Cantidad_Seleccionada = TextBox3.Text
        encapsuladora.VentaBoolean = True
        If tbl = 1 Then
            encapsuladora.IDMP = Tabla.ID
        Else
            encapsuladora.IDPI = Tabla.ID
        End If
        Verif.ValidoPonerEnVentaGestionProduccion(encapsuladora)
        TextBox3.Clear()
        CargarTabla1()
        CargarTabla2()
    End Sub

    Private Sub QuitarDeVenta(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        encapsuladora.VentaBoolean = False
        If tbl = 1 Then
            encapsuladora.IDMP = Tabla.ID
        Else
            encapsuladora.IDPI = Tabla.ID
        End If
        Verif.ValidoQuitarDeVentaGestionProduccion(encapsuladora)
        CargarTabla1()
        CargarTabla2()
    End Sub

End Class