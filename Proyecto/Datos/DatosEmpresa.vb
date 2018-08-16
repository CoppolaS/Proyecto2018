Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class DatosEmpresa
    Public Con As Conexion = New Conexion
    Dim sql As String
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Public Function ListaSucursales() As DataSet
        sql = "CALL `proyecto`.`LABM_Sucursales`(?opcion,?ID_S,?nombre,?direccion);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_S", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = "0"
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function ListaFuncionarios(Optional ByVal ID As Integer = 0) As ArrayList
        Dim arr As New ArrayList
        Try
            Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?)}", Con.cn1)
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
            Con.cn1.Open()
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
        Con.cn1.Close()
        Return arr
    End Function

    Public Function IngresoSucursal(ByVal nodo As Encapsuladoras.Sucursales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_S", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreSucursal)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionSucursal)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_S", nodo.IDSucursal)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("direccion", "")
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Sucursales (?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_S", nodo.IDSucursal)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreSucursal)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionSucursal)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar la sucursal")
        End Try
        Return False
    End Function

End Class
