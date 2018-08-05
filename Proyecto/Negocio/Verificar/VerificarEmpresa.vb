Imports Datos

Public Class VerificarEmpresa
    Dim DatosE As New Datos.DatosEmpresa

    'sucursales
    Public Function ValidoListaSucursales() As ArrayList
        Return DatosE.ListaSucursales
    End Function

    Public Function ValidoIngresoSucursales(ByVal encapsuladora As Encapsuladoras.Sucursales)
        DatosE.IngresoSucursal(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarSucursales(ByVal encapsuladora As Encapsuladoras.Sucursales)
        DatosE.EliminoSucursal(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarSucursales(ByVal encapsuladora As Encapsuladoras.Sucursales)
        DatosE.ModificoSucursal(encapsuladora)
        Return Nothing
    End Function

    'Public Function CargarTabla(ByRef tabla As DataTable) As DataSet
    '    Dim ds As New DataSet
    '    For Each itemSucursal As Encapsuladoras.Sucursales In ValidoListaSucursales()
    '        If itemSucursal.EliminadoSucursal = False Then
    '            ds.(itemSucursal.IDSucursal, itemSucursal.NombreSucursal, itemSucursal.DireccionSucursal)
    '        End If
    '    Next
    '    Tabla1.DataGridView1.ClearSelection()
    'End Function

    'funcionarios
    Public Function ValidoListaFuncionarios(Optional ByVal ID As Integer = 0) As ArrayList
        Return DatosE.ListaFuncionarios(ID)
    End Function

End Class
