Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class DatosOtros
    Public Con As Conexion = New Conexion
    Dim sql As String
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Public Function LoginPrograma(ByVal User As String, ByVal Pass As String) As Boolean
        Try
            Dim cmd As OdbcCommand = New OdbcCommand("{call Login_Programa (?,?)}", Con.cn1)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("usuario", User)
            cmd.Parameters.AddWithValue("contrasena", Pass)
            Con.cn1.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            dr.Read()
            UsuarioLogeado.User = dr.GetString(0)
            UsuarioLogeado.Pass = dr.GetString(1)
            UsuarioLogeado.Privilegios = dr.GetInt32(2)
            UsuarioLogeado.Cargo = dr.GetString(3)
            UsuarioLogeado.Ventana1 = dr.GetInt32(4)
            UsuarioLogeado.Ventana2 = dr.GetInt32(5)
            UsuarioLogeado.Ventana3 = dr.GetInt32(6)
            UsuarioLogeado.Sucursal = dr.GetString(7)
            UsuarioLogeado.Logeado = True
            dr.Close()
        Catch ex As Exception
            UsuarioLogeado.Logeado = False
        End Try
        Con.cn1.Close()
        Return False
    End Function

    Public Function LoginWeb(ByVal User As String, ByVal Pass As String) As Boolean
        Try
            Dim cmd2 As OdbcCommand = New OdbcCommand("{call Login_Web1 (?,?)}", Con.cn1)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.AddWithValue("usuarioV", User)
            cmd2.Parameters.AddWithValue("contrasenaV", Pass)
            Con.cn1.Open()
            cmd2.ExecuteNonQuery()
            Dim dr2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim tipo As New Integer
            dr2.Read()
            tipo = dr2.GetInt32(0)
            dr2.Close()
            Con.cn1.Close()
            Dim cmd As OdbcCommand = New OdbcCommand("{call Login_Web2 (?,?,?)}", Con.cn1)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("usuarioV", User)
            cmd.Parameters.AddWithValue("contrasenaV", Pass)
            cmd.Parameters.AddWithValue("tipo", tipo)
            Con.cn1.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            dr.Read()
            If (dr.GetInt32(0) = 0) Then
                Return 2
            ElseIf (dr.GetValue(1) = 1) Then
                Return 3
            Else
                If (tipo = 1) Then
                    UsuarioLogeadoWeb.Log = 1
                    UsuarioLogeadoWeb.id = dr.GetInt32(0)
                    UsuarioLogeadoWeb.Tipo = tipo
                    UsuarioLogeadoWeb.Nombre = dr.GetString(2)
                    UsuarioLogeadoWeb.Telefono = dr.GetString(3)
                    UsuarioLogeadoWeb.Mail = dr.GetString(4)
                    UsuarioLogeadoWeb.Direccion = dr.GetString(5)
                ElseIf (tipo = 2) Then
                    UsuarioLogeadoWeb.Log = 1
                    UsuarioLogeadoWeb.id = dr.GetInt32(0)
                    UsuarioLogeadoWeb.Tipo = tipo
                    UsuarioLogeadoWeb.Nombre = dr.GetString(2)
                    UsuarioLogeadoWeb.Apellido = dr.GetString(3)
                    UsuarioLogeadoWeb.Telefono = dr.GetString(4)
                    UsuarioLogeadoWeb.Cedula = dr.GetString(5)
                    UsuarioLogeadoWeb.Mail = dr.GetString(6)
                End If
            End If
            dr.Close()
        Catch ex As Exception
            UsuarioLogeadoWeb.Log = 0
            Return 2
        End Try
        Con.cn1.Close()
        Return 1
    End Function

    Public Function VentanasInicio(ByVal Opcion As Integer, Optional ByVal ventana As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`Inicio`(?opcion,?user,?pass,?ventana);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.VarChar).Value = Opcion
            cm.Parameters.Add("?user", MySqlDbType.VarChar).Value = UsuarioLogeado.User
            cm.Parameters.Add("?pass", MySqlDbType.VarChar).Value = UsuarioLogeado.Pass
            Select Case Opcion
                Case 1
                    cm.Parameters.Add("?ventana", MySqlDbType.Int32).Value = UsuarioLogeado.Ventana1
                Case 2
                    cm.Parameters.Add("?ventana", MySqlDbType.Int32).Value = UsuarioLogeado.Ventana2
                Case 3
                    cm.Parameters.Add("?ventana", MySqlDbType.Int32).Value = UsuarioLogeado.Ventana3
                Case 4
                    cm.Parameters.Add("?ventana", MySqlDbType.Int32).Value = ventana
            End Select
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    'hectareas
    Public Function ListaHectareas() As DataSet
        sql = "CALL `proyecto`.`LABM_Hectareas`(?opcion,?ID_H,?cantidad,?numero,?m2libres,?m2ocupados,?sucursal);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_H", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?numero", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?m2libres", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?m2ocupados", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?sucursal", MySqlDbType.VarChar).Value = UsuarioLogeado.Sucursal
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoHectarea(ByVal nodo As Encapsuladoras.Hectareas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Hectareas (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_H", 0)
                cmd.Parameters.AddWithValue("cantidad", nodo.CantidadHectareas)
                cmd.Parameters.AddWithValue("numero", 0)
                cmd.Parameters.AddWithValue("m2libres", 0)
                cmd.Parameters.AddWithValue("m2ocupados", 0)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalHectarea)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la hectárea")
        End Try
        Return False
    End Function

    Public Function EliminoHectarea(ByVal nodo As Encapsuladoras.Hectareas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Hectareas (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_H", nodo.IDHectarea)
                cmd.Parameters.AddWithValue("cantidad", 0)
                cmd.Parameters.AddWithValue("numero", 0)
                cmd.Parameters.AddWithValue("m2libres", 0)
                cmd.Parameters.AddWithValue("m2ocupados", 0)
                cmd.Parameters.AddWithValue("sucursal", Datos.UsuarioLogeado.Sucursal)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar la hectárea")
        End Try
        Return False
    End Function

    'parcelas
    Public Function ListaParcelas(Optional ByVal ID_H As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_Parcelas`(?opcion,?ID_P,?cantidad,?numero,?m2,?ID_H);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?numero", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?m2", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?ID_H", MySqlDbType.Int32).Value = ID_H
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoParcela(ByVal nodo As Encapsuladoras.Parcelas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Parcelas (?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("cantidad", nodo.CantidadParcelas)
                cmd.Parameters.AddWithValue("numero", 0)
                cmd.Parameters.AddWithValue("m2", nodo.MetrosCuadradosParcela)
                cmd.Parameters.AddWithValue("ID_H", nodo.IDHectarea)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la parcela")
        End Try
        Return False
    End Function

    Public Function EliminoParcela(ByVal nodo As Encapsuladoras.Parcelas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Parcelas (?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_P", nodo.IDParcela)
                cmd.Parameters.AddWithValue("cantidad", 0)
                cmd.Parameters.AddWithValue("numero", 0)
                cmd.Parameters.AddWithValue("m2", nodo.MetrosCuadradosParcela)
                cmd.Parameters.AddWithValue("ID_H", nodo.IDHectarea)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar la parcela")
        End Try
        Return False
    End Function

    'materia prima
    Public Function ListaMateriasPrimas(Optional ByVal ID_MP As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_MateriaPrima`(?opcion,?ID_MP,?fecha,?valor,?dato);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            If ID_MP = 0 Then
                cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            Else
                cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 5
            End If
            cm.Parameters.Add("?ID_MP", MySqlDbType.Int32).Value = ID_MP
            cm.Parameters.Add("?fecha", MySqlDbType.Int32).Value = "0"
            cm.Parameters.Add("?valor", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?dato", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoMateriaPrimaDato(ByVal nodo As Encapsuladoras.DatosCultivos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_MateriaPrima (?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 6)
                cmd.Parameters.AddWithValue("ID_MP", nodo.IDDato)
                cmd.Parameters.AddWithValue("fecha", nodo.FechaDato)
                cmd.Parameters.AddWithValue("valor", nodo.ValorDato)
                cmd.Parameters.AddWithValue("dato", nodo.NroDato)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el dato")
        End Try
        Return False
    End Function

    'producto intermedio
    Public Function ListaProductosIntermedios(Optional ByVal ID_PI As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_ProductoIntermedio`(?opcion,?ID_PI,?fecha,?valor,?dato);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            If ID_PI = 0 Then
                cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            Else
                cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 5
            End If
            cm.Parameters.Add("?ID_PI", MySqlDbType.Int32).Value = ID_PI
            cm.Parameters.Add("?fecha", MySqlDbType.Int32).Value = "0"
            cm.Parameters.Add("?valor", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?dato", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoProductoIntermedioDato(ByVal nodo As Encapsuladoras.DatosCultivos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_ProductoIntermedio (?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 6)
                cmd.Parameters.AddWithValue("ID_PI", nodo.IDDato)
                cmd.Parameters.AddWithValue("fecha", nodo.FechaDato)
                cmd.Parameters.AddWithValue("valor", nodo.ValorDato)
                cmd.Parameters.AddWithValue("dato", nodo.NroDato)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el dato")
        End Try
        Return False
    End Function

    'datos cultivos
    Public Function ListaParcelasDatos(Optional ByVal ID_P As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_DatosCultivos`(?opcion,?ID_P,?fecha,?valor,?dato);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = ID_P
            cm.Parameters.Add("?fecha", MySqlDbType.Int32).Value = "0"
            cm.Parameters.Add("?valor", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?dato", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoParcelaDato(ByVal nodo As Encapsuladoras.DatosCultivos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_DatosCultivos (?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_P", nodo.IDDato)
                cmd.Parameters.AddWithValue("fecha", nodo.FechaDato.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("valor", nodo.ValorDato)
                cmd.Parameters.AddWithValue("dato", nodo.NroDato)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox("La parcela seleccionada no tiene una plantación y cosecha actual")
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el dato")
        End Try
        Return False
    End Function

    'gestion produccion
    Public Function IngresoPonerEnVentaGestionProduccion(ByVal nodo As Encapsuladoras.GestionProduccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_GestionProduccion (?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 1)
                cmd.Parameters.AddWithValue("ID_MP", nodo.IDMP)
                cmd.Parameters.AddWithValue("ID_PI", nodo.IDPI)
                cmd.Parameters.AddWithValue("CantidadSeleccionada", nodo.Cantidad_Seleccionada)
                cmd.Parameters.AddWithValue("Venta", nodo.VentaBoolean)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la venta")
        End Try
        Return False
    End Function

    Public Function IngresoQuitarDeVentaGestionProduccion(ByVal nodo As Encapsuladoras.GestionProduccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_GestionProduccion (?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_MP", nodo.IDMP)
                cmd.Parameters.AddWithValue("ID_PI", nodo.IDPI)
                cmd.Parameters.AddWithValue("CantidadSeleccionada", 0)
                cmd.Parameters.AddWithValue("Venta", nodo.VentaBoolean)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el dato")
        End Try
        Return False
    End Function

    'asignar tratamientos
    Public Function ListaPlantacionesCosechas(Optional ByVal ID_P As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_AsignarTratamientos`(?opcion,?ID_P,?FechaPlant,?ID_C,?ID_T,?FechaTratamiento,?userFuncionario,?passFuncionario);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = ID_P
            cm.Parameters.Add("?FechaPlant", MySqlDbType.Int32).Value = "0"
            cm.Parameters.Add("?ID_C", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?ID_T", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaTratamiento", MySqlDbType.Int32).Value = "0"
            cm.Parameters.Add("?userFuncionario", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?passFuncionario", MySqlDbType.VarChar).Value = "0"
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoPlantacionCosecha(ByVal nodo As Encapsuladoras.AsignarTratamientos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsignarTratamientos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_P", nodo.ID_ParcelaAT)
                cmd.Parameters.AddWithValue("FechaPlant", nodo.FechaPlantadoAT.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("ID_C", nodo.ID_CepaAT)
                cmd.Parameters.AddWithValue("ID_T", 0)
                cmd.Parameters.AddWithValue("FechaTratamiento", "0000-00-00")
                cmd.Parameters.AddWithValue("userFuncionario", "0")
                cmd.Parameters.AddWithValue("passFuncionario", "0")
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la fecha de plantado")
        End Try
        Return False
    End Function

    Public Function FinalizoPlantacionCosecha(ByVal nodo As Encapsuladoras.AsignarTratamientos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsignarTratamientos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_P", nodo.ID_ParcelaAT)
                cmd.Parameters.AddWithValue("FechaPlant", nodo.FechaPlantadoAT.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("ID_C", 0)
                cmd.Parameters.AddWithValue("ID_T", 0)
                cmd.Parameters.AddWithValue("FechaTratamiento", "0000-00-00")
                cmd.Parameters.AddWithValue("userFuncionario", "0")
                cmd.Parameters.AddWithValue("passFuncionario", "0")
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la fecha de plantado")
        End Try
        Return False
    End Function

    Public Function IngresoTratamiento(ByVal nodo As Encapsuladoras.AsignarTratamientos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsignarTratamientos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_P", nodo.ID_ParcelaAT)
                cmd.Parameters.AddWithValue("FechaPlant", "0000-00-00")
                cmd.Parameters.AddWithValue("ID_C", 0)
                cmd.Parameters.AddWithValue("ID_T", nodo.ID_TratamientoAT)
                cmd.Parameters.AddWithValue("FechaTratamiento", nodo.FechaTratamientoAT.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("userFuncionario", UsuarioLogeado.User)
                cmd.Parameters.AddWithValue("passFuncionario", UsuarioLogeado.Pass)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la fecha de plantado")
        End Try
        Return False
    End Function

    Public Function FinalizoTratamiento(ByVal nodo As Encapsuladoras.AsignarTratamientos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsignarTratamientos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 5)
                cmd.Parameters.AddWithValue("ID_P", nodo.ID_ParcelaAT)
                cmd.Parameters.AddWithValue("FechaPlant", "0000-00-00")
                cmd.Parameters.AddWithValue("ID_C", 0)
                cmd.Parameters.AddWithValue("ID_T", nodo.ID_TratamientoAT)
                cmd.Parameters.AddWithValue("FechaTratamiento", nodo.FechaTratamientoAT.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("userFuncionario", "0")
                cmd.Parameters.AddWithValue("passFuncionario", "0")
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la fecha de plantado")
        End Try
        Return False
    End Function

    'produccion
    Public Function ListaParcelasPlantaciones(Optional ByVal ID_H As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_Parcelas`(?opcion,?ID_P,?cantidad,?numero,?m2,?ID_H);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 4
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?numero", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?m2", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?ID_H", MySqlDbType.Int32).Value = ID_H
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function ListaMateriasPrimasProcesos(ByVal Filtro As Integer) As DataSet
        sql = "CALL `proyecto`.`LABM_Produccion`(?opcion,?ID_P,?FechaCosechado,?Cantidad,?EstadoSanitario,?IDProductoIntermedio,?IDMateriaPrima,?FechaProceso,?IDProceso,?FechaAvance,?CantidadLitros,?IDTanque,?IDBarrica);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = Filtro
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaCosechado", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?Cantidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?EstadoSanitario", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDProductoIntermedio", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDMateriaPrima", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaProceso", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?IDProceso", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaAvance", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?CantidadLitros", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDTanque", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDBarrica", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function ListaProductosIntermediosProcesos(ByVal Filtro As Integer) As DataSet
        sql = "CALL `proyecto`.`LABM_Produccion`(?opcion,?ID_P,?FechaCosechado,?Cantidad,?EstadoSanitario,?IDProductoIntermedio,?IDMateriaPrima,?FechaProceso,?IDProceso,?FechaAvance,?CantidadLitros,?IDTanque,?IDBarrica);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = Filtro
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaCosechado", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?Cantidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?EstadoSanitario", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDProductoIntermedio", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDMateriaPrima", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaProceso", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?IDProceso", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaAvance", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?CantidadLitros", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDTanque", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDBarrica", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoParcelaCosecha(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 1)
                cmd.Parameters.AddWithValue("ID_P", nodo.ID_ParcelaP)
                cmd.Parameters.AddWithValue("FechaCosechado", nodo.FechaCosechadoP.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("Cantidad", nodo.CantidadP)
                cmd.Parameters.AddWithValue("EstadoSanitario", nodo.EstadoSanitarioP)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", 0)
                cmd.Parameters.AddWithValue("FechaProceso", "0000-00-00")
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la cosecha")
        End Try
        Return False
    End Function

    Public Function AsignarProcesoMP(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", nodo.IDMateriaPrimaP)
                cmd.Parameters.AddWithValue("FechaProceso", nodo.FechaProcesoP.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("IDProceso", nodo.ID_ProcesoP)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso en la materia prima")
        End Try
        Return False
    End Function

    Public Function FinalizarProcesoMP(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", nodo.IDMateriaPrimaP)
                cmd.Parameters.AddWithValue("FechaProceso", nodo.FechaProcesoP.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso en la materia prima")
        End Try
        Return False
    End Function

    Public Function AsignarProcesoPI(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", nodo.IDProductoIntermedioP)
                cmd.Parameters.AddWithValue("IDMateriaPrima", 0)
                cmd.Parameters.AddWithValue("FechaProceso", nodo.FechaProcesoP.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("IDProceso", nodo.ID_ProcesoP)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso en el producto intermedio")
        End Try
        Return False
    End Function

    Public Function FinalizarProcesoPI(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 5)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", nodo.IDProductoIntermedioP)
                cmd.Parameters.AddWithValue("IDMateriaPrima", 0)
                cmd.Parameters.AddWithValue("FechaProceso", nodo.FechaProcesoP.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso en el producto intermedio")
        End Try
        Return False
    End Function

    Public Function AceptarPrensado1(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 10)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", 0)
                cmd.Parameters.AddWithValue("FechaProceso", "0000-00-00")
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", nodo.FechaAvanceP)
                cmd.Parameters.AddWithValue("CantidadLitros", nodo.CantidadLitrosP)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el prensado")
        End Try
        Return False
    End Function

    Public Function AceptarPrensado2(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 11)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", nodo.CantidadP)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", nodo.IDMateriaPrimaP)
                cmd.Parameters.AddWithValue("FechaProceso", "0000-00-00")
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", nodo.FechaAvanceP)
                cmd.Parameters.AddWithValue("CantidadLitros", nodo.CantidadLitrosP)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el prensado")
        End Try
        Return False
    End Function

    Public Function ListaTanquesBarricas(ByVal ID_P As Integer) As DataSet
        sql = "CALL `proyecto`.`LABM_Produccion`(?opcion,?ID_P,?FechaCosechado,?Cantidad,?EstadoSanitario,?IDProductoIntermedio,?IDMateriaPrima,?FechaProceso,?IDProceso,?FechaAvance,?CantidadLitros,?IDTanque,?IDBarrica);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 12
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaCosechado", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?Cantidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?EstadoSanitario", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDProductoIntermedio", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDMateriaPrima", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?FechaProceso", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?IDProceso", MySqlDbType.Int32).Value = ID_P
            cm.Parameters.Add("?FechaAvance", MySqlDbType.Date).Value = "0000-00-00"
            cm.Parameters.Add("?CantidadLitros", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDTanque", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?IDBarrica", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function AsignarTanqueProcesoPI(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 41)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", 0)
                cmd.Parameters.AddWithValue("FechaProceso", "0000-00-00")
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", nodo.ID_TanqueP)
                cmd.Parameters.AddWithValue("IDBarrica", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso en el producto intermedio")
        End Try
        Return False
    End Function

    Public Function AsignarBarricaProcesoPI(ByVal nodo As Encapsuladoras.Produccion) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Produccion (?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 41)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("FechaCosechado", "0000-00-00")
                cmd.Parameters.AddWithValue("Cantidad", 0)
                cmd.Parameters.AddWithValue("EstadoSanitario", 0)
                cmd.Parameters.AddWithValue("IDProductoIntermedio", 0)
                cmd.Parameters.AddWithValue("IDMateriaPrima", 0)
                cmd.Parameters.AddWithValue("FechaProceso", "0000-00-00")
                cmd.Parameters.AddWithValue("IDProceso", 0)
                cmd.Parameters.AddWithValue("FechaAvance", "0000-00-00")
                cmd.Parameters.AddWithValue("CantidadLitros", 0)
                cmd.Parameters.AddWithValue("IDTanque", 0)
                cmd.Parameters.AddWithValue("IDBarrica", nodo.ID_BarricaP)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                MsgBox(o.ToString)
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso en el producto intermedio")
        End Try
        Return False
    End Function

End Class
