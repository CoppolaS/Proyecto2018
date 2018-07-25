Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class Login
    Public Con As Conexion = New Conexion

    Public Function LoginPrograma(ByVal nodo As Encapsuladoras.Login) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call Login_Programa (?,?,?)}", Con.cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("ID_UP", nodo.ID_UsuarioProgramaLogin)
                cmd.Parameters.AddWithValue("Usuario", nodo.UsuarioLogin)
                cmd.Parameters.AddWithValue("Contrasena", nodo.ContrasenaLogin)
                Con.cn.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al acceder a la base de datos")
        End Try
        Return False
    End Function

End Class
