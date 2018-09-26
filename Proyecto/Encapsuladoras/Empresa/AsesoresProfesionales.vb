Public Class AsesoresProfesionales
    Private ID_AsesorProfesional As Integer
    Private Nombre As String
    Private Apellido As String
    Private Telefono As Integer
    Private Mail As String
    Private Cedula As Integer
    Private Eliminado As Boolean
    Private Tipo As String
    Private Alarmas As Boolean
    Private Sucursal As String
    Private Usuario As String
    Private Contrasena As String

    Public Sub New(ByVal ID_AsesorProfesional As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As Integer, ByVal Mail As String, ByVal Cedula As Integer, ByVal Eliminado As Boolean, ByVal Tipo As String, ByVal Alarmas As Boolean, ByVal Sucursal As String, ByVal Usuario As String, ByVal Contrasena As String)
        Me.ID_AsesorProfesional = ID_AsesorProfesional
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.Telefono = Telefono
        Me.Mail = Mail
        Me.Cedula = Cedula
        Me.Eliminado = Eliminado
        Me.Tipo = Tipo
        Me.Alarmas = Alarmas
        Me.Sucursal = Sucursal
        Me.Usuario = Usuario
        Me.Contrasena = Contrasena
    End Sub

    Public Sub New()

    End Sub

    Public Property IDAsesorProfesional() As Integer
        Get
            Return Me.ID_AsesorProfesional
        End Get
        Set(ByVal value As Integer)
            Me.ID_AsesorProfesional = value
        End Set
    End Property

    Public Property NombreAsesorProfesional() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property ApellidoAsesorProfesional() As String
        Get
            Return Me.Apellido
        End Get
        Set(ByVal value As String)
            Me.Apellido = value
        End Set
    End Property

    Public Property TelefonoAsesorProfesional() As Integer
        Get
            Return Me.Telefono
        End Get
        Set(ByVal value As Integer)
            Me.Telefono = value
        End Set
    End Property

    Public Property MailAsesorProfesional() As String
        Get
            Return Me.Mail
        End Get
        Set(ByVal value As String)
            Me.Mail = value
        End Set
    End Property

    Public Property CedulaAsesorProfesional() As Integer
        Get
            Return Me.Cedula
        End Get
        Set(ByVal value As Integer)
            Me.Cedula = value
        End Set
    End Property

    Public Property EliminadoAsesorProfesional() As Boolean
        Get
            Return Me.Eliminado
        End Get
        Set(ByVal value As Boolean)
            Me.Eliminado = value
        End Set
    End Property

    Public Property TipoAsesorProfesional() As String
        Get
            Return Me.Tipo
        End Get
        Set(ByVal value As String)
            Me.Tipo = value
        End Set
    End Property

    Public Property SucursalAsesorProfesional() As String
        Get
            Return Me.Sucursal
        End Get
        Set(ByVal value As String)
            Me.Sucursal = value
        End Set
    End Property

    Public Property UsuarioAsesorProfesional() As String
        Get
            Return Me.Usuario
        End Get
        Set(ByVal value As String)
            Me.Usuario = value
        End Set
    End Property

    Public Property ContrasenaAsesorProfesional() As String
        Get
            Return Me.Contrasena
        End Get
        Set(ByVal value As String)
            Me.Contrasena = value
        End Set
    End Property

End Class
