Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class ABM
    Public connection As Conexion = New Conexion
    Function AgregaCliente(ByVal txt As String)
        Try
            Dim comand As OdbcCommand = New OdbcCommand("{call prueba (?)}", connection.cn)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@Descripcion", txt)
            connection.cn.Open()
            comand.ExecuteNonQuery()
            connection.cn.Close()
            MsgBox("El cliente se agrego correctamente")
        Catch ex As OdbcException
            Return False
        Finally

            connection.cn.Close()
        End Try

        Return True
    End Function

End Class
