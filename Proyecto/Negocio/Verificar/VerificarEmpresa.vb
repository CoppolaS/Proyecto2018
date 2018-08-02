Imports Datos

Public Class VerificarEmpresa
    Dim DatosE As New Datos.DatosEmpresa

    Public Function ValidoListaSucursales() As DataSet
        Dim LS As New DataSet
        LS = DatosE.poronga
        Return LS
    End Function

    'Public Function ValidoListaFuncionarios(Optional ByVal ID_S As Integer = 0) As ArrayList
    '    Dim LF As New ArrayList
    '    LF = DatosE.ListaFuncionarios
    '    Return LF
    'End Function

End Class
