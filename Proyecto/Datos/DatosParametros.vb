﻿Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class DatosParametros
    Public Con As Conexion = New Conexion
    Dim sql As String
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    'barricas
    Public Function ListaBarricas() As DataSet
        sql = "CALL `proyecto`.`LABM_Barricas`(?opcion,?ID_B,?numero,?disponible,?capacidad,?material,?nro_usos,?sucursal);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_B", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?numero", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?disponible", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?capacidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?material", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?nro_usos", MySqlDbType.Int32).Value = 0
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

    Public Function IngresoBarrica(ByVal nodo As Encapsuladoras.Barricas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Barricas (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_B", 0)
                cmd.Parameters.AddWithValue("numero", nodo.NumeroBarrica)
                cmd.Parameters.AddWithValue("disponible", nodo.DisponibleBarrica)
                cmd.Parameters.AddWithValue("capacidad", nodo.CapacidadBarrica)
                cmd.Parameters.AddWithValue("material", nodo.MaterialBarrica)
                cmd.Parameters.AddWithValue("nro_usos", nodo.UsosBarrica)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalBarrica)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar la barrica")
        End Try
        Return False
    End Function

    Public Function EliminoBarrica(ByVal nodo As Encapsuladoras.Barricas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Barricas (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_B", nodo.IDBarrica)
                cmd.Parameters.AddWithValue("numero", 0)
                cmd.Parameters.AddWithValue("disponible", False)
                cmd.Parameters.AddWithValue("capacidad", 0)
                cmd.Parameters.AddWithValue("material", "")
                cmd.Parameters.AddWithValue("nro_usos", 0)
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
            MsgBox("Error al eliminar la barrica")
        End Try
        Return False
    End Function

    Public Function ModificoBarrica(ByVal nodo As Encapsuladoras.Barricas) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Barricas (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_B", nodo.IDBarrica)
                cmd.Parameters.AddWithValue("numero", nodo.NumeroBarrica)
                cmd.Parameters.AddWithValue("disponible", nodo.DisponibleBarrica)
                cmd.Parameters.AddWithValue("capacidad", nodo.CapacidadBarrica)
                cmd.Parameters.AddWithValue("material", nodo.MaterialBarrica)
                cmd.Parameters.AddWithValue("nro_usos", nodo.UsosBarrica)
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
            MsgBox("Error al modificar la barrica")
        End Try
        Return False
    End Function

    'tanques
    Public Function ListaTanques() As DataSet
        sql = "CALL `proyecto`.`LABM_Tanques`(?opcion,?ID_T,?numero,?disponible,?capacidad,?material,?sucursal);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_T", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?numero", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?disponible", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?capacidad", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?material", MySqlDbType.VarChar).Value = "0"
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

    Public Function IngresoTanque(ByVal nodo As Encapsuladoras.Tanques) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Tanques (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_T", 0)
                cmd.Parameters.AddWithValue("numero", nodo.NumeroTanque)
                cmd.Parameters.AddWithValue("disponible", nodo.DisponibleTanque)
                cmd.Parameters.AddWithValue("capacidad", nodo.CapacidadTanque)
                cmd.Parameters.AddWithValue("material", nodo.MaterialTanque)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalTanque)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el tanque")
        End Try
        Return False
    End Function

    Public Function EliminoTanque(ByVal nodo As Encapsuladoras.Tanques) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Tanques (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_T", nodo.IDTanque)
                cmd.Parameters.AddWithValue("numero", 0)
                cmd.Parameters.AddWithValue("disponible", False)
                cmd.Parameters.AddWithValue("capacidad", 0)
                cmd.Parameters.AddWithValue("material", "")
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
            MsgBox("Error al eliminar el tanque")
        End Try
        Return False
    End Function

    Public Function ModificoTanque(ByVal nodo As Encapsuladoras.Tanques) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Tanques (?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_T", nodo.IDTanque)
                cmd.Parameters.AddWithValue("numero", nodo.NumeroTanque)
                cmd.Parameters.AddWithValue("disponible", nodo.DisponibleTanque)
                cmd.Parameters.AddWithValue("capacidad", nodo.CapacidadTanque)
                cmd.Parameters.AddWithValue("material", nodo.MaterialTanque)
                cmd.Parameters.AddWithValue("sucursal", nodo.SucursalTanque)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el tanque")
        End Try
        Return False
    End Function

    'procesos
    Public Function ListaProcesos() As DataSet
        sql = "CALL `proyecto`.`LABM_Procesos`(?opcion,?ID_P,?nombre,?descripcion,?materiaprima,?productointermedio,?barrica,?tanque);"
        Try
            Con.cn2.Open()
            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.Connection = Con.cn2
            cm.Parameters.Add("?opcion", MySqlDbType.Int32).Value = 1
            cm.Parameters.Add("?ID_P", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?descripcion", MySqlDbType.VarChar).Value = "0"
            cm.Parameters.Add("?materiaprima", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?productointermedio", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?barrica", MySqlDbType.Int32).Value = 0
            cm.Parameters.Add("?tanque", MySqlDbType.Int32).Value = 0
            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.cn2.Close()
        Return ds
    End Function

    Public Function IngresoProceso(ByVal nodo As Encapsuladoras.Procesos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Procesos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 2)
                cmd.Parameters.AddWithValue("ID_P", 0)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreProceso)
                cmd.Parameters.AddWithValue("descripcion", nodo.DescripcionProceso)
                cmd.Parameters.AddWithValue("materiaprima", nodo.MateriaPrimaProceso)
                cmd.Parameters.AddWithValue("productointermedio", nodo.ProductoIntermedioProceso)
                cmd.Parameters.AddWithValue("barrica", nodo.BarricaProceso)
                cmd.Parameters.AddWithValue("tanque", nodo.TanqueProceso)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al ingresar el proceso")
        End Try
        Return False
    End Function

    Public Function EliminoProceso(ByVal nodo As Encapsuladoras.Procesos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Procesos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 3)
                cmd.Parameters.AddWithValue("ID_P", nodo.IDProceso)
                cmd.Parameters.AddWithValue("nombre", "")
                cmd.Parameters.AddWithValue("descripcion", "")
                cmd.Parameters.AddWithValue("materiaprima", False)
                cmd.Parameters.AddWithValue("productointermedio", False)
                cmd.Parameters.AddWithValue("barrica", False)
                cmd.Parameters.AddWithValue("tanque", False)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el proceso")
        End Try
        Return False
    End Function

    Public Function ModificoProceso(ByVal nodo As Encapsuladoras.Procesos) As Boolean
        Try
            Try
                Dim cmd As OdbcCommand = New OdbcCommand("{call LABM_Procesos (?,?,?,?,?,?,?,?)}", Con.cn1)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("opcion", 4)
                cmd.Parameters.AddWithValue("ID_P", nodo.IDProceso)
                cmd.Parameters.AddWithValue("nombre", nodo.NombreProceso)
                cmd.Parameters.AddWithValue("descripcion", nodo.DescripcionProceso)
                cmd.Parameters.AddWithValue("materiaprima", nodo.MateriaPrimaProceso)
                cmd.Parameters.AddWithValue("productointermedio", nodo.ProductoIntermedioProceso)
                cmd.Parameters.AddWithValue("barrica", nodo.BarricaProceso)
                cmd.Parameters.AddWithValue("tanque", nodo.TanqueProceso)
                Con.cn1.Open()
                cmd.ExecuteNonQuery()
            Catch o As OdbcException
                Return False
            Finally
                Con.cn1.Close()
            End Try
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el proceso")
        End Try
        Return False
    End Function

End Class