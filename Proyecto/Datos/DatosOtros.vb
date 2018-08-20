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
            UsuarioLogeado.Cargo = dr.GetString(2)
            UsuarioLogeado.Ventana1 = dr.GetInt32(3)
            UsuarioLogeado.Ventana2 = dr.GetInt32(4)
            UsuarioLogeado.Ventana3 = dr.GetInt32(5)
            UsuarioLogeado.Logeado = True
            dr.Close()
        Catch ex As Exception
            UsuarioLogeado.Logeado = False
        End Try
        Con.cn1.Close()
        Return False
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

End Class
