Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class DatosOtros
    Public Con As Conexion = New Conexion

    Public Function LoginPrograma(ByVal User As String, ByVal Pass As String) As Boolean
        Try
            Dim cmd As OdbcCommand = New OdbcCommand("{call Login_Programa (?,?)}", Con.cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("usuario", User)
            cmd.Parameters.AddWithValue("contrasena", Pass)
            Con.cn.Open()
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
        Con.cn.Close()
        Return False
    End Function

End Class
