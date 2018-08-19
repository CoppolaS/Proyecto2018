Imports Datos

Public Class VerificarEmpresa
    Dim DatosE As New Datos.DatosEmpresa
    Dim dv As New DataView
    Dim ds As New DataSet

    'sucursales
    Public Function ValidoListaSucursales() As DataView
        ds = DatosE.ListaSucursales
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Dirección"
        dv = ds.Tables(0).DefaultView
        Return dv
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

    'funcionarios
    Public Function ValidoListaFuncionarios(Optional ByVal ID As Integer = 0) As DataView
        ds = DatosE.ListaFuncionarios(ID)
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Apellido"
        ds.Tables(0).Columns(3).ColumnName = "Teléfono"
        ds.Tables(0).Columns(4).ColumnName = "Mail"
        ds.Tables(0).Columns(5).ColumnName = "Cédula"
        ds.Tables(0).Columns(6).ColumnName = "Eliminado"
        ds.Tables(0).Columns(7).ColumnName = "Cargo"
        ds.Tables(0).Columns(8).ColumnName = "Usuario"
        dv = ds.Tables(0).DefaultView
        dv.RowFilter = "Eliminado = 0"
        Return dv
    End Function

End Class
