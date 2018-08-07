Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class DatosEmpresa
    Public Con As Conexion = New Conexion

    Public Function ListaSucursales() As ArrayList
        Dim arr As New ArrayList
        Try
            Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("opcion", 1)
            cmd.Parameters.AddWithValue("ID_S", 0)
            cmd.Parameters.AddWithValue("nombre", "")
            cmd.Parameters.AddWithValue("direccion", "")
            Con.cn.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read
                Dim nodo As Encapsuladoras.Sucursales = New Encapsuladoras.Sucursales
                nodo.IDSucursal = dr.GetInt32(0)
                nodo.NombreSucursal = dr.GetString(1)
                nodo.DireccionSucursal = dr.GetString(2)
                nodo.EliminadoSucursal = dr.GetBoolean(3)
                arr.Add(nodo)
            End While
            dr.Close()
        Catch ex As Exception
        End Try
        Con.cn.Close()
        Return arr
    End Function

    Public Function ListaFuncionarios(Optional ByVal ID As Integer = 0) As ArrayList
        Dim arr As New ArrayList
        Try
            Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?)}", Con.cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("opcion", 5)
            'cmd.Parameters.AddWithValue("ID_F", 0)
            'cmd.Parameters.AddWithValue("nombre", "")
            'cmd.Parameters.AddWithValue("apellido", "")
            'cmd.Parameters.AddWithValue("telefono", 0)
            'cmd.Parameters.AddWithValue("mail", "")
            'cmd.Parameters.AddWithValue("cargo", "")
            'cmd.Parameters.AddWithValue("usuario", "")
            cmd.Parameters.AddWithValue("id_sucursal", ID)
            Con.cn.Open()
            cmd.ExecuteNonQuery()
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read
                Dim nodo As Encapsuladoras.Funcionarios = New Encapsuladoras.Funcionarios
                nodo.IDFuncionario = dr.GetInt32(0)
                nodo.NombreFuncionario = dr.GetString(1)
                nodo.ApellidoFuncionario = dr.GetString(2)
                nodo.TelefonoFuncionario = dr.GetInt32(3)
                nodo.MailFuncionario = dr.GetString(4)
                nodo.CedulaFuncionario = dr.GetInt32(5)
                nodo.EliminadoFuncionario = dr.GetBoolean(6)
                nodo.CargoFuncionario = dr.GetString(7)
                nodo.UsuarioFuncionario = dr.GetString(8)
                arr.Add(nodo)
            End While
            dr.Close()
        Catch ex As Exception
        End Try
        Con.cn.Close()
        Return arr
    End Function

    Public Function IngresoSucursal(ByVal nodo As Encapsuladoras.Sucursales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_S", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreSucursal)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionSucursal)
                Con.cn.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la sucursal")
        End Try
        Return False
    End Function

    Public Function EliminoSucursal(ByVal nodo As Encapsuladoras.Sucursales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_S", nodo.IDSucursal)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("direccion", "")
                Con.cn.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar la sucursal")
        End Try
        Return False
    End Function

    Public Function ModificoSucursal(ByVal nodo As Encapsuladoras.Sucursales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_S", nodo.IDSucursal)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreSucursal)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionSucursal)
                Con.cn.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar la sucursal")
        End Try
        Return False
    End Function

End Class
