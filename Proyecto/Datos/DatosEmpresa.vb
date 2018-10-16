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

    'clientes
    Public Function ListaClientes() As DataSet
        sql = "CALL `proyecto`.`LABM_Clientes`(?opcion,?ID_C,?nombre,?telefono,?mail,?direccion,?usuario,?contrasena,?valido);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_C", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?telefono", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?mail", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?contrasena", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?valido", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoCliente(ByVal nodo As Encapsuladoras.Clientes) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Clientes (?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_C", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreCliente)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoCliente)
                cmd.Parameters.AddWithValue("mail", nodo.MailCliente)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionCliente)
                cmd.Parameters.AddWithValue("usuario", nodo.UsuarioCliente)
                cmd.Parameters.AddWithValue("contrasena", nodo.ContrasenaCliente)
                cmd.Parameters.AddWithValue("valido", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el cliente")
        End Try
        Return False
    End Function

    Public Function EliminoCliente(ByVal nodo As Encapsuladoras.Clientes) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Clientes (?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_C", nodo.IDCliente)
                cmd.Parameters.AddWithValue("nombre", "0")
                cmd.Parameters.AddWithValue("telefono", 0)
                cmd.Parameters.AddWithValue("mail", "0")
                cmd.Parameters.AddWithValue("direccion", "0")
                cmd.Parameters.AddWithValue("usuario", "0")
                cmd.Parameters.AddWithValue("contrasena", "0")
                cmd.Parameters.AddWithValue("valido", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el cliente")
        End Try
        Return False
    End Function

    Public Function ModificoCliente(ByVal nodo As Encapsuladoras.Clientes) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Clientes (?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_C", nodo.IDCliente)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreCliente)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoCliente)
                cmd.Parameters.AddWithValue("mail", nodo.MailCliente)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionCliente)
                cmd.Parameters.AddWithValue("usuario", nodo.UsuarioCliente)
                cmd.Parameters.AddWithValue("contrasena", nodo.ContrasenaCliente)
                cmd.Parameters.AddWithValue("valido", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el cliente")
        End Try
        Return False
    End Function

    Public Function ValidoUW_C(ByVal nodo As Encapsuladoras.Clientes) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Clientes (?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 5)
                cmd.Parameters.AddWithValue("ID_C", nodo.IDCliente)
                cmd.Parameters.AddWithValue("nombre", "0")
                cmd.Parameters.AddWithValue("telefono", 0)
                cmd.Parameters.AddWithValue("mail", "0")
                cmd.Parameters.AddWithValue("direccion", "0")
                cmd.Parameters.AddWithValue("usuario", "0")
                cmd.Parameters.AddWithValue("contrasena", "0")
                cmd.Parameters.AddWithValue("valido", nodo.ValidoCliente)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al validar el cliente")
        End Try
        Return False
    End Function

    'vendedores
    Public Function ListaVendedores() As DataSet
        sql = "CALL `proyecto`.`LABM_Vendedores`(?opcion,?ID_V,?nombre,?telefono,?mail,?direccion);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_V", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?telefono", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?mail", MySqlDbType.VarChar).Value = "0"
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

    Public Function IngresoVendedor(ByVal nodo As Encapsuladoras.Vendedores) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Vendedores (?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_V", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreVendedor)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoVendedor)
                cmd.Parameters.AddWithValue("mail", nodo.MailVendedor)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionVendedor)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el vendedor")
        End Try
        Return False
    End Function

    Public Function EliminoVendedor(ByVal nodo As Encapsuladoras.Vendedores) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Vendedores (?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_V", nodo.IDVendedor)
                cmd.Parameters.AddWithValue("nombre", "0")
                cmd.Parameters.AddWithValue("telefono", 0)
                cmd.Parameters.AddWithValue("mail", "0")
                cmd.Parameters.AddWithValue("direccion", "0")
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el vendedor")
        End Try
        Return False
    End Function

    Public Function ModificoVendedor(ByVal nodo As Encapsuladoras.Vendedores) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Vendedores (?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_V", nodo.IDVendedor)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreVendedor)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoVendedor)
                cmd.Parameters.AddWithValue("mail", nodo.MailVendedor)
                cmd.Parameters.AddWithValue("direccion", nodo.DireccionVendedor)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el vendedor")
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

    Public Function IngresoCargo(ByVal nodo As Encapsuladoras.Cargos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Cargos (?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_C", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreCargo)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el cargo")
        End Try
        Return False
    End Function

    Public Function EliminoCargo(ByVal nodo As Encapsuladoras.Cargos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Cargos (?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_C", nodo.IDCargo)
                cmd.Parameters.AddWithValue("nombre", "")
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el cargo")
        End Try
        Return False
    End Function

    Public Function ModificoCargo(ByVal nodo As Encapsuladoras.Cargos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Cargos (?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_C", nodo.IDCargo)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreCargo)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el cargo")
        End Try
        Return False
    End Function

    'tiposap
    Public Function ListaTiposAP() As DataSet
        sql = "CALL `proyecto`.`LABM_TiposAP`(?opcion,?ID_TAP,?nombre,?alarmas,?cosechas,?materiaprima,?productointermedio);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_TAP", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?alarmas", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?cosechas", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?materiaprima", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?productointermedio", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoTipoAP(ByVal nodo As Encapsuladoras.TiposAP) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_TiposAP (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_TAP", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreTipoAP)
                cmd.Parameters.AddWithValue("alarmas", nodo.AlarmasTipoAP)
                cmd.Parameters.AddWithValue("cosechas", nodo.CosechasTipoAP)
                cmd.Parameters.AddWithValue("materiaprima", nodo.MateriaPrimaTipoAP)
                cmd.Parameters.AddWithValue("productointermedio", nodo.ProductoIntermedioTipoAP)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el tipo de asesor profesional")
        End Try
        Return False
    End Function

    Public Function EliminoTipoAP(ByVal nodo As Encapsuladoras.TiposAP) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_TiposAP (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_TAP", nodo.IDTipoAP)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("alarmas", False)
                cmd.Parameters.AddWithValue("cosechas", False)
                cmd.Parameters.AddWithValue("materiaprima", False)
                cmd.Parameters.AddWithValue("productointermedio", False)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el tipo de asesor profesional")
        End Try
        Return False
    End Function

    Public Function ModificoTipoAP(ByVal nodo As Encapsuladoras.TiposAP) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_TiposAP (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_TAP", nodo.IDTipoAP)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreTipoAP)
                cmd.Parameters.AddWithValue("alarmas", nodo.AlarmasTipoAP)
                cmd.Parameters.AddWithValue("cosechas", nodo.CosechasTipoAP)
                cmd.Parameters.AddWithValue("materiaprima", nodo.MateriaPrimaTipoAP)
                cmd.Parameters.AddWithValue("productointermedio", nodo.ProductoIntermedioTipoAP)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el tipo de asesor profesional")
        End Try
        Return False
    End Function

    'funcionarios
    Public Function ListaFuncionarios() As DataSet
        sql = "CALL `proyecto`.`LABM_Funcionarios`(?opcion,?ID_F,?nombre,?apellido,?telefono,?mail,?cedula,?user,?pass,?cargo,?privilegios,?sucursal);"
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

    Public Function IngresoFuncionario(ByVal nodo As Encapsuladoras.Funcionarios) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
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
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalFuncionario)
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_F", nodo.IDFuncionario)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("apellido", "")
                cmd.Parameters.AddWithValue("telefono", 0)
                cmd.Parameters.AddWithValue("mail", "")
                cmd.Parameters.AddWithValue("cedula", 0)
                cmd.Parameters.AddWithValue("user", nodo.UsuarioFuncionario)
                cmd.Parameters.AddWithValue("pass", nodo.ContrasenaFuncionario)
                cmd.Parameters.AddWithValue("cargo", "")
                cmd.Parameters.AddWithValue("privilegios", 0)
                cmd.Parameters.AddWithValue("sucursal", "")
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Funcionarios (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
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
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalFuncionario)
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

    'asesores profesionales
    Public Function ListaAsesoresProfesionales() As DataSet
        sql = "CALL `proyecto`.`LABM_AsesoresProfesionales`(?opcion,?ID_AP,?nombre,?apellido,?telefono,?mail,?cedula,?tipo,?sucursal,?usuario,?contrasena,?valido);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_AP", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?telefono", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?mail", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?cedula", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?tipo", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?sucursal", MySqlDbType.VarChar).Value = UsuarioLogeado.Sucursal
            cm.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?contrasena", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?valido", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoAsesorProfesional(ByVal nodo As Encapsuladoras.AsesoresProfesionales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_AP", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreAsesorProfesional)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoAsesorProfesional)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoAsesorProfesional)
                cmd.Parameters.AddWithValue("mail", nodo.MailAsesorProfesional)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaAsesorProfesional)
                cmd.Parameters.AddWithValue("tipo", nodo.TipoAsesorProfesional)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalAsesorProfesional)
                cmd.Parameters.AddWithValue("usuario", nodo.UsuarioAsesorProfesional)
                cmd.Parameters.AddWithValue("contrasena", nodo.ContrasenaAsesorProfesional)
                cmd.Parameters.AddWithValue("valido", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el asesor profesional")
        End Try
        Return False
    End Function

    Public Function EliminoAsesorProfesional(ByVal nodo As Encapsuladoras.AsesoresProfesionales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_AP", nodo.IDAsesorProfesional)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("apellido", "")
                cmd.Parameters.AddWithValue("telefono", 0)
                cmd.Parameters.AddWithValue("mail", "")
                cmd.Parameters.AddWithValue("cedula", 0)
                cmd.Parameters.AddWithValue("tipo", "")
                cmd.Parameters.AddWithValue("sucursal", "")
                cmd.Parameters.AddWithValue("usuario", "")
                cmd.Parameters.AddWithValue("contrasena", "")
                cmd.Parameters.AddWithValue("valido", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el asesor profesional")
        End Try
        Return False
    End Function

    Public Function ModificoAsesorProfesional(ByVal nodo As Encapsuladoras.AsesoresProfesionales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_AP", nodo.IDAsesorProfesional)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreAsesorProfesional)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoAsesorProfesional)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoAsesorProfesional)
                cmd.Parameters.AddWithValue("mail", nodo.MailAsesorProfesional)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaAsesorProfesional)
                cmd.Parameters.AddWithValue("tipo", nodo.TipoAsesorProfesional)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalAsesorProfesional)
                cmd.Parameters.AddWithValue("usuario", nodo.UsuarioAsesorProfesional)
                cmd.Parameters.AddWithValue("contrasena", nodo.ContrasenaAsesorProfesional)
                cmd.Parameters.AddWithValue("valido", 0)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el asesor profesional")
        End Try
        Return False
    End Function

    Public Function ValidoUW_AP(ByVal nodo As Encapsuladoras.AsesoresProfesionales) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 5)
                cmd.Parameters.AddWithValue("ID_AP", nodo.IDAsesorProfesional)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("apellido", "")
                cmd.Parameters.AddWithValue("telefono", 0)
                cmd.Parameters.AddWithValue("mail", "")
                cmd.Parameters.AddWithValue("cedula", 0)
                cmd.Parameters.AddWithValue("tipo", "")
                cmd.Parameters.AddWithValue("sucursal", "")
                cmd.Parameters.AddWithValue("usuario", "")
                cmd.Parameters.AddWithValue("contrasena", "")
                cmd.Parameters.AddWithValue("valido", nodo.ValidoAsesorProfesional)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al validar el asesor profesional")
        End Try
        Return False
    End Function

End Class
