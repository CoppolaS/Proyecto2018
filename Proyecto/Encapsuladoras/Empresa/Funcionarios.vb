﻿Public Class Funcionarios
    Private ID_Funcionarios As Integer
    Private Nombre As String
    Private Apellido As String
    Private Telefono As Integer
    Private Mail As String
    Private Cargo As String
    Private Usuario As String
    Private Eliminado As Boolean
    Private Cedula As Integer

    Public Sub New(ByVal ID_Funcionarios As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As Integer, ByVal Mail As String, ByVal Cargo As String, ByVal Usuario As String, ByVal Eliminado As Boolean, ByVal Cedula As Integer)
        Me.ID_Funcionarios = ID_Funcionarios
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.Telefono = Telefono
        Me.Mail = Mail
        Me.Cargo = Cargo
        Me.Usuario = Usuario
        Me.Eliminado = Eliminado
        Me.Cedula = Cedula
    End Sub

    Public Sub New()

    End Sub

    Public Property IDFuncionario() As Integer
        Get
            Return Me.ID_Funcionarios
        End Get
        Set(ByVal value As Integer)
            Me.ID_Funcionarios = value
        End Set
    End Property

    Public Property NombreFuncionario() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property ApellidoFuncionario() As String
        Get
            Return Me.Apellido
        End Get
        Set(ByVal value As String)
            Me.Apellido = value
        End Set
    End Property

    Public Property TelefonoFuncionario() As Integer
        Get
            Return Me.Telefono
        End Get
        Set(ByVal value As Integer)
            Me.Telefono = value
        End Set
    End Property

    Public Property MailFuncionario() As String
        Get
            Return Me.Mail
        End Get
        Set(ByVal value As String)
            Me.Mail = value
        End Set
    End Property

    Public Property CargoFuncionario() As String
        Get
            Return Me.Cargo
        End Get
        Set(ByVal value As String)
            Me.Cargo = value
        End Set
    End Property

    Public Property UsuarioFuncionario() As String
        Get
            Return Me.Usuario
        End Get
        Set(ByVal value As String)
            Me.Usuario = value
        End Set
    End Property

    Public Property EliminadoFuncionario() As Boolean
        Get
            Return Me.Eliminado
        End Get
        Set(ByVal value As Boolean)
            Me.Eliminado = value
        End Set
    End Property

    Public Property CedulaFuncionario() As Integer
        Get
            Return Me.Cedula
        End Get
        Set(ByVal value As Integer)
            Me.Cedula = value
        End Set
    End Property

End Class
