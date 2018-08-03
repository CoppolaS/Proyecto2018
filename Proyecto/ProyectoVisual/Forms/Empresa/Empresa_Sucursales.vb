Imports Negocio
''revisar
Public Class Empresa_Sucursales
    Dim Verif As New Negocio.VerificarEmpresa
    Dim PropTablas As New Negocio.PropiedadesTablas
    Dim dgv As New DataGridView

    Private Sub Empresa_Sucursales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'DataGridView1.Columns.Add("id_s", "ID de Sucursal")
        'DataGridView1.Columns.Add("nombre_s", "Nombre de sucursal")
        'DataGridView1.Columns.Add("direccion_s", "Dirección de sucursal")
        DataGridView1.DataSource = Verif.ValidoListaSucursales.Tables(0).DefaultView
        'DataGridView1 = PropTablas.PropiedadesTabla1
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'CargarTabla()
        'DataGridView1 = dgv
    End Sub

    'Private Sub CargarTabla()
    '    DataGridView1.Rows.Clear()
    '    For Each itemSucursal As Encapsuladoras.Sucursales In Verif.ValidoListaSucursales
    '        DataGridView1.Rows.Add(itemSucursal.IDSucursal, itemSucursal.NombreSucursal, itemSucursal.DireccionSucursal)
    '    Next
    '    DataGridView1.ClearSelection()
    'End Sub

    'Private Sub Enabler(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CellClick
    '    Dim Fila As Integer = DataGridView1.CurrentRow.Index
    '    Dim ID_S As Integer = DataGridView1.Rows(Fila).Cells(0).Value
    '    If DataGridView1.SelectedRows.Count > 0 Then
    '        DataGridView2.Rows.Clear()
    '        For Each itemFuncionario As Encapsuladoras.Funcionarios In Verif.ValidoListaFuncionarios(ID_S)
    '            DataGridView2.Rows.Add(itemFuncionario.IDFuncionario, itemFuncionario.NombreFuncionario, itemFuncionario.ApellidoFuncionario, itemFuncionario.TelefonoFuncionario, itemFuncionario.MailFuncionario, itemFuncionario.CargoFuncionario, itemFuncionario.UsuarioFuncionario)
    '        Next
    '        DataGridView2.ClearSelection()
    '    End If
    'End Sub

End Class