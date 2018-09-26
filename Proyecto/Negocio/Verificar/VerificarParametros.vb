﻿Imports Datos

Public Class VerificarParametros
    Dim DatosP As New Datos.DatosParametros
    Dim dv As New DataView
    Dim ds As New DataSet

    'barricas
    Public Function ValidoListaBarricas() As DataView
        ds = DatosP.ListaBarricas()
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
        DatosP.IngresoBarrica(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarBarricas(ByVal encapsuladora As Encapsuladoras.Barricas)
        DatosP.EliminoBarrica(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarBarricas(ByVal encapsuladora As Encapsuladoras.Barricas)
        DatosP.ModificoBarrica(encapsuladora)
        Return Nothing
    End Function

    'tanques
    Public Function ValidoListaTanques() As DataView
        ds = DatosP.ListaTanques()
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "N° de tanque"
        ds.Tables(0).Columns(2).ColumnName = "¿Disponible?"
        ds.Tables(0).Columns(3).ColumnName = "Capacidad"
        ds.Tables(0).Columns(4).ColumnName = "Material"
        ds.Tables(0).Columns(5).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoTanques(ByVal encapsuladora As Encapsuladoras.Tanques)
        DatosP.IngresoTanque(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarTanques(ByVal encapsuladora As Encapsuladoras.Tanques)
        DatosP.EliminoTanque(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarTanques(ByVal encapsuladora As Encapsuladoras.Tanques)
        DatosP.ModificoTanque(encapsuladora)
        Return Nothing
    End Function

End Class
