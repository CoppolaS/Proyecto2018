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

End Class
