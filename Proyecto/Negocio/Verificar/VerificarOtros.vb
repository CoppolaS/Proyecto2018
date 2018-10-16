Imports Datos

Public Class VerificarOtros
    Dim DatosO As New Datos.DatosOtros
    Dim dv As New DataView
    Dim ds As New DataSet

    Public Sub VerificarLogin(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        DatosO.LoginPrograma(UsuarioPrograma, ContrasenaPrograma)
        If UsuarioLogeado.Logeado = False Then
            MsgBox("Combinación de usuario y contraseña incorrectos")
        End If
    End Sub

    Public Function VerificarLoginWeb(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        Return DatosO.LoginWeb(UsuarioPrograma, ContrasenaPrograma)
    End Function

    Public Function VerificarVentanas(ByVal Opcion As Integer, Optional ByVal ventana As Integer = 0) As DataView
        ds = DatosO.VentanasInicio(Opcion, ventana)
        dv.RowFilter = "Eliminado = 0"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    'hectareas
    Public Function ValidoListaHectareas() As DataView
        ds = DatosO.ListaHectareas()
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "N° de hectárea"
        ds.Tables(0).Columns(2).ColumnName = "Metros cuadrados libres"
        ds.Tables(0).Columns(3).ColumnName = "Metros cuadrados ocupados"
        ds.Tables(0).Columns(4).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoHectareas(ByVal encapsuladora As Encapsuladoras.Hectareas)
        DatosO.IngresoHectarea(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarHectareas(ByVal encapsuladora As Encapsuladoras.Hectareas)
        DatosO.EliminoHectarea(encapsuladora)
        Return Nothing
    End Function

    'parcelas
    Public Function ValidoListaParcelas(Optional ByVal ID_H As Integer = 0) As DataView
        ds = DatosO.ListaParcelas(ID_H)
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "N° de parcela"
        ds.Tables(0).Columns(2).ColumnName = "Metros cuadrados"
        ds.Tables(0).Columns(3).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoParcelas(ByVal encapsuladora As Encapsuladoras.Parcelas)
        DatosO.IngresoParcela(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarParcelas(ByVal encapsuladora As Encapsuladoras.Parcelas)
        DatosO.EliminoParcela(encapsuladora)
        Return Nothing
    End Function

    'materia prima
    Public Function ValidoListaMateriasPrimas(Optional ByVal ID_MP As Integer = 0) As DataView
        ds = DatosO.ListaMateriasPrimas(ID_MP)
        If ID_MP = 0 Then
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Estado sanitario"
            ds.Tables(0).Columns(2).ColumnName = "Fecha de avance"
            ds.Tables(0).Columns(3).ColumnName = "Cantidad"
            ds.Tables(0).Columns(4).ColumnName = "Cantidad actual"
            ds.Tables(0).Columns(5).ColumnName = "Venta"
            ds.Tables(0).Columns(6).ColumnName = "Eliminado"
            ds.Tables(0).Columns(7).ColumnName = "Fecha de cosechado"
            ds.Tables(0).Columns(8).ColumnName = "Fecha de plantado"
        Else
            ds.Tables(0).Columns(0).ColumnName = "Fecha del dato"
            ds.Tables(0).Columns(1).ColumnName = "Nombre del dato"
            ds.Tables(0).Columns(2).ColumnName = "Cantidad del dato"
        End If
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoMateriasPrimasDatos(ByVal encapsuladora As Encapsuladoras.DatosCultivos)
        DatosO.IngresoMateriaPrimaDato(encapsuladora)
        Return Nothing
    End Function

    'producto intermedio
    Public Function ValidoListaProductosIntermedios(Optional ByVal ID_PI As Integer = 0) As DataView
        ds = DatosO.ListaProductosIntermedios(ID_PI)
        If ID_PI = 0 Then
            ds.Tables(0).Columns(0).ColumnName = "ID"
            ds.Tables(0).Columns(1).ColumnName = "Fecha de entrada"
            ds.Tables(0).Columns(2).ColumnName = "Fecha de salida"
            ds.Tables(0).Columns(3).ColumnName = "Cantidad"
            ds.Tables(0).Columns(4).ColumnName = "Venta"
            ds.Tables(0).Columns(5).ColumnName = "Cantidad actual"
            ds.Tables(0).Columns(6).ColumnName = "Eliminado"
            ds.Tables(0).Columns(7).ColumnName = "Fecha de avance"
            ds.Tables(0).Columns(8).ColumnName = "Fecha de cosechado"
        Else
            ds.Tables(0).Columns(0).ColumnName = "Fecha del dato"
            ds.Tables(0).Columns(1).ColumnName = "Nombre del dato"
            ds.Tables(0).Columns(2).ColumnName = "Cantidad del dato"
        End If
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoProductosIntermediosDatos(ByVal encapsuladora As Encapsuladoras.DatosCultivos)
        DatosO.IngresoProductoIntermedioDato(encapsuladora)
        Return Nothing
    End Function

    'datos cultivos
    Public Function ValidoListaParcelasDatos(Optional ByVal ID_P As Integer = 0) As DataView
        ds = DatosO.ListaParcelasDatos(ID_P)
        ds.Tables(0).Columns(0).ColumnName = "Fecha del dato"
        ds.Tables(0).Columns(1).ColumnName = "Nombre del dato"
        ds.Tables(0).Columns(2).ColumnName = "Cantidad del dato"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoParcelasDatos(ByVal encapsuladora As Encapsuladoras.DatosCultivos)
        DatosO.IngresoParcelaDato(encapsuladora)
        Return Nothing
    End Function

End Class
