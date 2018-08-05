Imports Datos

Public Class VerificarEmpresa
    Dim DatosE As New Datos.DatosEmpresa

    Public Function ValidoListaSucursales() As ArrayList
        Return DatosE.ListaSucursales
    End Function

    Public Function ValidoListaFuncionarios(Optional ByVal ID As Integer = 0) As ArrayList
        Return DatosE.ListaFuncionarios(ID)
    End Function

End Class
