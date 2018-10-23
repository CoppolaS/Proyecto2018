Imports Datos

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

    'procesos
    Public Function ValidoListaProcesos() As DataView
        ds = DatosP.ListaProcesos()
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Descripción"
        ds.Tables(0).Columns(3).ColumnName = "Uso de materia prima"
        ds.Tables(0).Columns(4).ColumnName = "Uso de producto intermedio"
        ds.Tables(0).Columns(5).ColumnName = "Uso de barricas"
        ds.Tables(0).Columns(6).ColumnName = "Uso de tanques"
        ds.Tables(0).Columns(7).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoProcesos(ByVal encapsuladora As Encapsuladoras.Procesos)
        DatosP.IngresoProceso(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarProcesos(ByVal encapsuladora As Encapsuladoras.Procesos)
        DatosP.EliminoProceso(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarProcesos(ByVal encapsuladora As Encapsuladoras.Procesos)
        DatosP.ModificoProceso(encapsuladora)
        Return Nothing
    End Function

    'tratamientos
    Public Function ValidoListaTratamientos(Optional ByVal ID_P As Integer = 0) As DataView
        ds = DatosP.ListaTratamientos(ID_P)
        If ID_P = 0 Then
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Nombre"
            ds.Tables(0).Columns(2).ColumnName = "Descripción"
        Else
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Nombre"
            ds.Tables(0).Columns(2).ColumnName = "Descripción"
            ds.Tables(0).Columns(3).ColumnName = "Eliminado"
            ds.Tables(0).Columns(4).ColumnName = "Fecha de comienzo"
            ds.Tables(0).Columns(5).ColumnName = "Fecha de finalización"
        End If
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoTratamientos(ByVal encapsuladora As Encapsuladoras.Tratamientos)
        DatosP.IngresoTratamiento(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarTratamientos(ByVal encapsuladora As Encapsuladoras.Tratamientos)
        DatosP.EliminoTratamiento(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarTratamientos(ByVal encapsuladora As Encapsuladoras.Tratamientos)
        DatosP.ModificoTratamiento(encapsuladora)
        Return Nothing
    End Function

    'datos
    Public Function ValidoListaDatos() As DataView
        ds = DatosP.ListaDatos()
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Unidad"
        ds.Tables(0).Columns(3).ColumnName = "Descripción"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoDatos(ByVal encapsuladora As Encapsuladoras.Datos)
        DatosP.IngresoDato(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarDatos(ByVal encapsuladora As Encapsuladoras.Datos)
        DatosP.EliminoDato(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarDatos(ByVal encapsuladora As Encapsuladoras.Datos)
        DatosP.ModificoDato(encapsuladora)
        Return Nothing
    End Function

    'cepas
    Public Function ValidoListaCepas(Optional ByVal ID_V As Integer = 0) As DataView
        ds = DatosP.ListaCepas(ID_V)
        If ID_V = 0 Then
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Nombre"
            ds.Tables(0).Columns(2).ColumnName = "Imagen Uva"
            ds.Tables(0).Columns(3).ColumnName = "Imagen Mosto"
            ds.Tables(0).Columns(4).ColumnName = "Descripción Uva"
            ds.Tables(0).Columns(5).ColumnName = "Descripción Mosto"
            ds.Tables(0).Columns(6).ColumnName = "Precio Uva"
            ds.Tables(0).Columns(7).ColumnName = "Precio Mosto"
        Else
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Nombre"
        End If
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoCepas(ByVal encapsuladora As Encapsuladoras.Cepas)
        DatosP.IngresoCepa(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoIngresoCepasVinos(ByVal encapsuladora As Encapsuladoras.Cepas)
        DatosP.IngresoCepaVino(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarCepas(ByVal encapsuladora As Encapsuladoras.Cepas)
        DatosP.EliminoCepa(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarCepasVinos(ByVal encapsuladora As Encapsuladoras.Cepas)
        DatosP.EliminoCepaVino(encapsuladora)
        Return Nothing
    End Function

    'botellas
    Public Function ValidoListaBotellas(Optional ByVal ID_V As Integer = 0) As DataView
        ds = DatosP.ListaBotellas(ID_V)
        If ID_V = 0 Then
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Capacidad"
            ds.Tables(0).Columns(2).ColumnName = "Eliminado"
        Else
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Capacidad"
            ds.Tables(0).Columns(2).ColumnName = "Foto"
            ds.Tables(0).Columns(3).ColumnName = "Precio"
        End If
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoBotellas(ByVal encapsuladora As Encapsuladoras.Botellas)
        DatosP.IngresoBotella(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoIngresoBotellasVinos(ByVal encapsuladora As Encapsuladoras.Botellas)
        DatosP.IngresoBotellaVino(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarBotellas(ByVal encapsuladora As Encapsuladoras.Botellas)
        DatosP.EliminoBotella(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarBotellasVinos(ByVal encapsuladora As Encapsuladoras.Botellas)
        DatosP.EliminoBotellaVino(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarBotellas(ByVal encapsuladora As Encapsuladoras.Botellas)
        DatosP.ModificoBotella(encapsuladora)
        Return Nothing
    End Function

    'vinos
    Public Function ValidoListaVinos() As DataView
        ds = DatosP.ListaVinos()
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Descripción"
        ds.Tables(0).Columns(3).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoVinos(ByVal encapsuladora As Encapsuladoras.Vinos)
        DatosP.IngresoVino(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarVinos(ByVal encapsuladora As Encapsuladoras.Vinos)
        DatosP.EliminoVino(encapsuladora)
        Return Nothing
    End Function

End Class
