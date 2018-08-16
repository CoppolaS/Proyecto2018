Imports Datos

Public Class VerificarEmpresa
    Dim DatosE As New Datos.DatosEmpresa

    'sucursales
    Public Function ValidoListaSucursales() As DataSet
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

    'funcionarios
    Public Function ValidoListaFuncionarios(Optional ByVal ID As Integer = 0) As ArrayList
        Return DatosE.ListaFuncionarios(ID)
    End Function

End Class
