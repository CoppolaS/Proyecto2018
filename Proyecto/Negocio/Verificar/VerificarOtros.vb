Imports Datos

Public Class VerificarOtros
    Dim DatosO As New Datos.DatosOtros
    Dim dv As New DataView
    Dim ds As New DataSet

    Public Sub VerificarLogin(ByVal UsuarioPrograma As String, ByVal ContrasenaPrograma As String)
        DatosO.LoginPrograma(UsuarioPrograma, ContrasenaPrograma)
        If UsuarioLogeado.Logeado = True Then
            MsgBox("Inicio de sesión exitoso")
        Else
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

End Class
