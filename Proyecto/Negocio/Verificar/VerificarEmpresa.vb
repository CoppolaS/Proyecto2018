﻿Imports Datos

Public Class VerificarEmpresa
    Dim DatosE As New Datos.DatosEmpresa
    Dim dv As New DataView
    Dim ds As New DataSet

    'sucursales
    Public Function ValidoListaSucursales() As DataView
        ds = DatosE.ListaSucursales
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Dirección"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoSucursales(ByVal encapsuladora As Encapsuladoras.Sucursales)
        DatosE.IngresoSucursal(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarSucursales(ByVal encapsuladora As Encapsuladoras.Sucursales)
        DatosE.EliminoSucursal(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarSucursales(ByVal encapsuladora As Encapsuladoras.Sucursales)
        DatosE.ModificoSucursal(encapsuladora)
        Return Nothing
    End Function

    'cargos
    Public Function ValidoListaCargos() As DataView
        ds = DatosE.ListaCargos
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoCargos(ByVal encapsuladora As Encapsuladoras.Cargos)
        DatosE.IngresoCargo(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarCargos(ByVal encapsuladora As Encapsuladoras.Cargos)
        DatosE.EliminoCargo(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarCargos(ByVal encapsuladora As Encapsuladoras.Cargos)
        DatosE.ModificoCargo(encapsuladora)
        Return Nothing
    End Function

    'tiposap
    Public Function ValidoListaTiposAP() As DataView
        ds = DatosE.ListaTiposAP
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Alarmas"
        ds.Tables(0).Columns(3).ColumnName = "Eliminado"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoTiposAP(ByVal encapsuladora As Encapsuladoras.TiposAP)
        DatosE.IngresoTipoAP(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarTiposAP(ByVal encapsuladora As Encapsuladoras.TiposAP)
        DatosE.EliminoTipoAP(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarTiposAP(ByVal encapsuladora As Encapsuladoras.TiposAP)
        DatosE.ModificoTipoAP(encapsuladora)
        Return Nothing
    End Function

    'funcionarios
    Public Function ValidoListaFuncionarios(Optional ByVal Sucursal As String = "0") As DataView
        ds = DatosE.ListaFuncionarios(Sucursal)
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Apellido"
        ds.Tables(0).Columns(3).ColumnName = "Teléfono"
        ds.Tables(0).Columns(4).ColumnName = "Mail"
        ds.Tables(0).Columns(5).ColumnName = "Cédula"
        ds.Tables(0).Columns(6).ColumnName = "Usuario"
        ds.Tables(0).Columns(7).ColumnName = "Contraseña"
        ds.Tables(0).Columns(8).ColumnName = "Cargo"
        ds.Tables(0).Columns(9).ColumnName = "Privilegios"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoFuncionarios(ByVal encapsuladora As Encapsuladoras.Funcionarios)
        DatosE.IngresoFuncionario(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarFuncionarios(ByVal encapsuladora As Encapsuladoras.Funcionarios)
        DatosE.EliminoFuncionario(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarFuncionarios(ByVal encapsuladora As Encapsuladoras.Funcionarios)
        DatosE.ModificoFuncionario(encapsuladora)
        Return Nothing
    End Function

    'asesores profesionales
    Public Function ValidoListaAsesoresProfesionales(Optional ByVal Sucursal As String = "0") As DataView
        ds = DatosE.ListaAsesoresProfesionales(Sucursal)
        ds.Tables(0).Columns(0).ColumnName = "ID"
        ds.Tables(0).Columns(1).ColumnName = "Nombre"
        ds.Tables(0).Columns(2).ColumnName = "Apellido"
        ds.Tables(0).Columns(3).ColumnName = "Teléfono"
        ds.Tables(0).Columns(4).ColumnName = "Mail"
        ds.Tables(0).Columns(5).ColumnName = "Cédula"
        ds.Tables(0).Columns(6).ColumnName = "Eliminado"
        ds.Tables(0).Columns(7).ColumnName = "Tipo"
        ds.Tables(0).Columns(8).ColumnName = "Alarmas"
        ds.Tables(0).Columns(9).ColumnName = "Sucursal"
        dv = ds.Tables(0).DefaultView
        Return dv
    End Function

    Public Function ValidoIngresoAsesoresProfesionales(ByVal encapsuladora As Encapsuladoras.AsesoresProfesionales)
        DatosE.IngresoAsesorProfesional(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoEliminarAsesoresProfesionales(ByVal encapsuladora As Encapsuladoras.AsesoresProfesionales)
        DatosE.EliminoAsesorProfesional(encapsuladora)
        Return Nothing
    End Function

    Public Function ValidoModificarAsesoresProfesionales(ByVal encapsuladora As Encapsuladoras.AsesoresProfesionales)
        DatosE.ModificoAsesorProfesional(encapsuladora)
        Return Nothing
    End Function

End Class
