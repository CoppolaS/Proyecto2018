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

    Public Function LoginWeb(ByVal User As String, ByVal Pass As String) As Boolean
        Try
            Dim cmd2 As OdbcCommand = New OdbcCommand("{call Login_Web1 (?,?)}", Con.cn)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.AddWithValue("usuarioV", User)
            cmd2.Parameters.AddWithValue("contrasenaV", Pass)
            Con.cn.Open()
            cmd2.ExecuteNonQuery()
            Dim dr2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim tipo As New Integer
            dr2.Read()
            MsgBox(dr2.GetInt32(0))
            tipo = dr2.GetInt32(0)
            dr2.Close()
            Dim cmd As OdbcCommand = New OdbcCommand("{call Login_Web2 (?,?,?)}", Con.cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("usuarioV", User)
            cmd.Parameters.AddWithValue("contrasenaV", Pass)
            cmd.Parameters.AddWithValue("tipo", tipo)
            cmd.ExecuteNonQuery()
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            dr.Read()
            If (dr.GetInt32(0) = 0) Then
                Return 2
            ElseIf (dr.GetInt32(1) = 1) Then
                Return 3
            Else
                If (dr.GetInt32(2) = 1) Then
                    UsuarioLogeadoWeb.Log = 1
                    UsuarioLogeadoWeb.id = dr.GetInt32(0)
                    UsuarioLogeadoWeb.Tipo = dr.GetInt32(2)
                    UsuarioLogeadoWeb.Nombre = dr.GetString(3)
                    UsuarioLogeadoWeb.Telefono = dr.GetString(4)
                    UsuarioLogeadoWeb.Mail = dr.GetString(5)
                    UsuarioLogeadoWeb.Direccion = dr.GetString(6)
                ElseIf (dr.GetInt32(2) = 2) Then
                    UsuarioLogeadoWeb.Log = 1
                    UsuarioLogeadoWeb.id = dr.GetInt32(0)
                    UsuarioLogeadoWeb.Tipo = dr.GetInt32(2)
                    UsuarioLogeadoWeb.Nombre = dr.GetString(3)
                    UsuarioLogeadoWeb.Apellido = dr.GetString(4)
                    UsuarioLogeadoWeb.Telefono = dr.GetString(5)
                    UsuarioLogeadoWeb.Cedula = dr.GetString(6)
                    UsuarioLogeadoWeb.Mail = dr.GetString(7)
                End If
            End If
                dr.Close()
        Catch ex As Exception
            UsuarioLogeadoWeb.Log = 0
            Return 2
        End Try
        Con.cn.Close()
        Return 1
    End Function

End Class
