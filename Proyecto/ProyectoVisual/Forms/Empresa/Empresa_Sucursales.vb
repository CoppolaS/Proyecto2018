Imports Negocio

Public Class Empresa_Sucursales
    Dim Verif As New Negocio.VerificarOtros

    Private Sub Empresa_Sucursales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("id_s", "ID de Sucursal")
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns.Add("nombre_s", "Nombre de sucursal")
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns.Add("direccion_s", "Dirección de sucursal")
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        CargarTabla()
    End Sub

    Private Sub CargarTabla()
        DataGridView1.Rows.Clear()
        For Each itemSucursal As Encapsuladoras.Sucursales In Verif.ValidoLista
            DataGridView1.Rows.Add(itemSucursal.IDSucursal, itemSucursal.NombreSucursal, itemSucursal.DireccionSucursal)
        Next
        DataGridView1.ClearSelection()
    End Sub

End Class