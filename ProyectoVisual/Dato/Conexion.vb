﻿Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Conexion
    Public cn As OdbcConnection
    Sub New()
        cn = New OdbcConnection("UID=jpacheco" & _
            ";PWD=142857" & _
            ";DATABASE=proyecto_s.i.ges.vi" & _
            ";SERVER=192.168.0.201" & _
            ";DRIVER={MySQL ODBC 5.3 ANSI Driver};")
    End Sub
End Class

