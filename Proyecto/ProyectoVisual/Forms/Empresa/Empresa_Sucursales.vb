'https://www.youtube.com/watch?v=171skzi5BKc

Imports Negocio

Public Class Empresa_Sucursales
    Dim Verif As New Negocio.VerificarEmpresa

    Private Sub Empresa_Sucursales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Tabla1.DataGridView1.Columns.Add("id_s", "ID de Sucursal")
        Tabla1.DataGridView1.Columns.Add("nombre", "Nombre de sucursal")
        Tabla1.DataGridView1.Columns.Add("direccion", "Dirección de sucursal")
        Tabla2.DataGridView1.Columns.Add("a", "ID")
        Tabla2.DataGridView1.Columns.Add("b", "Nombre")
        Tabla2.DataGridView1.Columns.Add("c", "Apellido")
        Tabla2.DataGridView1.Columns.Add("d", "Teléfono")
        Tabla2.DataGridView1.Columns.Add("e", "Mail")
        Tabla2.DataGridView1.Columns.Add("f", "Cargo")
        Tabla2.DataGridView1.Columns.Add("g", "Usuario")
        Dim c As DataGridViewColumn
        For Each c In Tabla1.DataGridView1.Columns
            Dim i As Integer
            ComboBox1.Items.Add(Tabla1.DataGridView1.Columns(i).HeaderText.ToString.Insert(0, i.ToString & " " & "-" & " "))
            i = i + 1
        Next
        CargarTabla()
    End Sub

    Private Sub CargarTabla()
        Tabla1.DataGridView1.Rows.Clear()
        For Each itemSucursal As Encapsuladoras.Sucursales In Verif.ValidoListaSucursales
            Tabla1.DataGridView1.Rows.Add(itemSucursal.IDSucursal, itemSucursal.NombreSucursal, itemSucursal.DireccionSucursal)
        Next
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub Enabler(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Tabla1.Paint
        If Tabla.ID > 0 Then
            If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
                Tabla2.DataGridView1.Rows.Clear()
                For Each itemFuncionario As Encapsuladoras.Funcionarios In Verif.ValidoListaFuncionarios(Tabla.ID)
                    Tabla2.DataGridView1.Rows.Add(itemFuncionario.IDFuncionario, itemFuncionario.NombreFuncionario, itemFuncionario.ApellidoFuncionario, itemFuncionario.TelefonoFuncionario.ToString.Insert(0, "0"), itemFuncionario.MailFuncionario, itemFuncionario.CargoFuncionario, itemFuncionario.UsuarioFuncionario)
                Next
                Tabla2.DataGridView1.ClearSelection()
            End If
        End If
    End Sub

    'terminar el filtrador
    Private Sub Filtrar(sender As Object, e As System.EventArgs) Handles buscador.TextChanged
        Dim fila As Integer
        Dim columna As Integer
        columna = Integer.Parse(ComboBox1.SelectedItem.ToString.Substring(0, 1))
        For Each DataGridViewRow In Tabla1.DataGridView1.Rows
            If Tabla1.DataGridView1.Item(columna, fila).ToString.Contains(buscador.Text.ToString) = False Then
                Tabla1.DataGridView1.Rows(fila).Visible = False
            End If
        Next
    End Sub
End Class