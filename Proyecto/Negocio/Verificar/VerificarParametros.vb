Imports Datos

Public Class VerificarParametros
    Dim DatosE As New Datos.DatosParametros
    Dim dv As New DataView
    Dim ds As New DataSet

    'barricas
    Public Function ValidoListaBarricas(Optional ByVal Sucursal As String = "0") As DataView
        ds = DatosE.ListaBarricas(Sucursal)
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "N° de barrica"
        ds.Tables(0).Columns(2).ColumnName = "¿Disponible?"
        ds.Tables(0).Columns(3).ColumnName = "Capacidad"
        ds.Tables(0).Columns(4).ColumnName = "Material"
        ds.Tables(0).Columns(5).ColumnName = "N° de usos"
        ds.Tables(0).Columns(6).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoBarricas(ByVal encapsuladora As Encapsuladoras.Barricas)
        DatosE.IngresoBarrica(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarBarricas(ByVal encapsuladora As Encapsuladoras.Barricas)
        DatosE.EliminoBarrica(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarBarricas(ByVal encapsuladora As Encapsuladoras.Barricas)
        DatosE.ModificoBarrica(encapsuladora)
        Return Nothing
    End Function
End Class
