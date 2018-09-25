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
        sql = "CALL `proyecto`.`LABM_TiposAP`(?opcion,?ID_TAP,?nombre,?alarmas);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_TAP", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?alarmas", MySqlDbType.Int32).Value = 0
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_TiposAP (?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_TAP", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreTipoAP)
                cmd.Parameters.AddWithValue("alarmas", nodo.AlarmasTipoAP)
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_TiposAP (?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_TAP", nodo.IDTipoAP)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("alarmas", False)
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_TiposAP (?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_TAP", nodo.IDTipoAP)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreTipoAP)
                cmd.Parameters.AddWithValue("alarmas", nodo.AlarmasTipoAP)
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
    Public Function ListaFuncionarios(Optional ByVal Sucursal As String = "0") As DataSet
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
            cm.Parameters.Add("?sucursal", MySqlDbType.VarChar).Value = Sucursal
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
    Public Function ListaAsesoresProfesionales(Optional ByVal Sucursal As String = "0") As DataSet
        sql = "CALL `proyecto`.`LABM_AsesoresProfesionales`(?opcion,?ID_AP,?nombre,?apellido,?telefono,?mail,?cedula,?tipo,?sucursal);"
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
            cm.Parameters.Add("?tipo", MySqlDbType.Int32).Value = "0"
            cm.Parameters.Add("?sucursal", MySqlDbType.VarChar).Value = Sucursal
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?)}", Con.cn1)
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_F", nodo.IDAsesorProfesional)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreAsesorProfesional)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoAsesorProfesional)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoAsesorProfesional)
                cmd.Parameters.AddWithValue("mail", nodo.MailAsesorProfesional)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaAsesorProfesional)
                cmd.Parameters.AddWithValue("tipo", nodo.TipoAsesorProfesional)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalAsesorProfesional)
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
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_AsesoresProfesionales (?,?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_F", nodo.IDAsesorProfesional)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreAsesorProfesional)
                cmd.Parameters.AddWithValue("apellido", nodo.ApellidoAsesorProfesional)
                cmd.Parameters.AddWithValue("telefono", nodo.TelefonoAsesorProfesional)
                cmd.Parameters.AddWithValue("mail", nodo.MailAsesorProfesional)
                cmd.Parameters.AddWithValue("cedula", nodo.CedulaAsesorProfesional)
                cmd.Parameters.AddWithValue("tipo", nodo.TipoAsesorProfesional)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalAsesorProfesional)
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

End Class
