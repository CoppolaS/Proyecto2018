Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class Conexion
    Public cn1 As OdbcConnection
    Public cn2 As MySqlConnection

    Sub New()
        cn1 = New OdbcConnection("UID=root" & _
            ";PWD=root" & _
            ";DATABASE=proyecto" & _
            ";SERVER=127.0.0.1" & _
            ";DRIVER={MySQL ODBC 5.3 ANSI Driver};")

        cn2 = New MySqlConnection("Data Source=127.0.0.1;Database=proyecto;User ID=root; Password=root; Allow Zero Datetime=True; CHARSET=latin1")
    End Sub

End Class
