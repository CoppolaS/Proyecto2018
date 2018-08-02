Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class DatosEmpresa
    Dim sql As String
    Dim cn As MySqlConnection
    Dim cm As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Public Function poronga() As DataSet
        sql = "CALL `proyecto_s.i.ges.vi`.`LABM_Sucursales`(?opcion,?ID_S,?nombre,?direccion);"
        cn = New MySqlConnection("Data source =127.0.0.1;Database=proyecto_s.i.ges.vi;User ID=root; Password=root; Allow Zero Datetime=True; CHARSET=latin1")
        cn.Open()
        cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = cn
        cm.Parameters.Add("?opcion", MySqlDbType.Int32)
        cm.Parameters.Add("?ID_S", MySqlDbType.Int32)
        cm.Parameters.Add("?nombre", MySqlDbType.VarChar)
        cm.Parameters.Add("?direccion", MySqlDbType.VarChar)
        cm.Parameters("?opcion").Value = 1
        cm.Parameters("?ID_S").Value = 0
        cm.Parameters("?nombre").Value = "a"
        cm.Parameters("?direccion").Value = "b"
        da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)
        Return ds
    End Function

End Class
