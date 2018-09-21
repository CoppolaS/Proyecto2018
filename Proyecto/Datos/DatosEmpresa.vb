Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class DatosEmpresa
    Public Con As Conexion = New Conexion
    Dim sql As String
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    'sucursales
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

    'cargos
    Public Function ListaCargos() As DataSet
        sql = "CALL `proyecto`.`LABM_Cargos`(?opcion,?ID_C,?nombre);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_C", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    'funcionarios
    Public Function ListaFuncionarios1() As DataSet
        sql = "CALL `proyecto`.`LABM_Funcionarios`(?opcion,?ID_F,?nombre,?apellido,?telefono,?mail,?cedula,?user,?pass,?cargo,?privilegios,?eliminado,?sucursal,?id_sucursal);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_F", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?telefono", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?mail", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?cedula", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?user", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?pass", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?cargo", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?privilegios", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?eliminado", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?sucursal", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?id_sucursal", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function ListaFuncionarios2(Optional ByVal ID As Integer = 0) As DataSet
        sql = "CALL `proyecto`.`LABM_Funcionarios`(?opcion,?ID_F,?nombre,?apellido,?telefono,?mail,?cedula,?user,?pass,?cargo,?privilegios,?eliminado,?sucursal,?id_sucursal);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 5
            cm.Parameters.Add("?ID_F", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?telefono", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?mail", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?cedula", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?user", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?pass", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?cargo", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?privilegios", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?eliminado", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?sucursal", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?id_sucursal", MySqlDbType.Int32).Value = ID
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoFuncionario(ByVal nodo As Encapsuladoras.Funcionarios) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_F", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreFuncionario)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoFuncionario)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoFuncionario)
                cmd.Parameters.AddWithValue("mail", nodo.MailFuncionario)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaFuncionario)
                cmd.Parameters.AddWithValue("user", nodo.UsuarioFuncionario)
                cmd.Parameters.AddWithValue("pass", nodo.ContrasenaFuncionario)
                cmd.Parameters.AddWithValue("cargo", nodo.CargoFuncionario)
                cmd.Parameters.AddWithValue("privilegios", nodo.PrivilegiosFuncionario)
                cmd.Parameters.AddWithValue("eliminado", 0)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalFuncionario)
                cmd.Parameters.AddWithValue("id_sucursal", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el funcionario")
        End Try
        Return False
    End Function

    Public Function EliminoFuncionario(ByVal nodo As Encapsuladoras.Funcionarios) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_F", nodo.IDFuncionario)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreFuncionario)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoFuncionario)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoFuncionario)
                cmd.Parameters.AddWithValue("mail", nodo.MailFuncionario)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaFuncionario)
                cmd.Parameters.AddWithValue("user", nodo.UsuarioFuncionario)
                cmd.Parameters.AddWithValue("pass", nodo.ContrasenaFuncionario)
                cmd.Parameters.AddWithValue("cargo", nodo.CargoFuncionario)
                cmd.Parameters.AddWithValue("privilegios", nodo.PrivilegiosFuncionario)
                cmd.Parameters.AddWithValue("eliminado", 1)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalFuncionario)
                cmd.Parameters.AddWithValue("id_sucursal", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el funcionario")
        End Try
        Return False
    End Function

    Public Function ModificoFuncionario(ByVal nodo As Encapsuladoras.Funcionarios) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?,?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_F", nodo.IDFuncionario)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreFuncionario)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoFuncionario)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoFuncionario)
                cmd.Parameters.AddWithValue("mail", nodo.MailFuncionario)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaFuncionario)
                cmd.Parameters.AddWithValue("user", nodo.UsuarioFuncionario)
                cmd.Parameters.AddWithValue("pass", nodo.ContrasenaFuncionario)
                cmd.Parameters.AddWithValue("cargo", nodo.CargoFuncionario)
                cmd.Parameters.AddWithValue("privilegios", nodo.PrivilegiosFuncionario)
                cmd.Parameters.AddWithValue("eliminado", 1)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalFuncionario)
                cmd.Parameters.AddWithValue("id_sucursal", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el funcionario")
        End Try
        Return False
    End Function

End Class
