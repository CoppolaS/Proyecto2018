Public Class Clientes
    Private ID_Cliente As Integer
    Private Nombre As String
    Private Telefono As Integer
    Private Mail As String
    Private Direccion As String
    Private Usuario As String
    Private Contrasena As String
    Private Valido As Integer

    Public Sub New(ByVal ID_Cliente As Integer, ByVal Nombre As String, ByVal Telefono As Integer, ByVal Mail As String, ByVal Direccion As String, ByVal Usuario As String, ByVal Contrasena As String, ByVal Valido As Integer)
        Me.ID_Cliente = ID_Cliente
        Me.Nombre = Nombre
        Me.Telefono = Telefono
        Me.Mail = Mail
        Me.Direccion = Direccion
        Me.Usuario = Usuario
        Me.Contrasena = Contrasena
        Me.Valido = Valido
    End Sub

    Public Sub New()

    End Sub

    Public Property IDCliente() As Integer
        Get
            Return Me.ID_Cliente
        End Get
        Set(ByVal value As Integer)
            Me.ID_Cliente = value
        End Set
    End Property

    Public Property NombreCliente() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property TelefonoCliente() As Integer
        Get
            Return Me.Telefono
        End Get
        Set(ByVal value As Integer)
            Me.Telefono = value
        End Set
    End Property

    Public Property MailCliente() As String
        Get
            Return Me.Mail
        End Get
        Set(ByVal value As String)
            Me.Mail = value
        End Set
    End Property

    Public Property DireccionCliente() As String
        Get
            Return Me.Direccion
        End Get
        Set(ByVal value As String)
            Me.Direccion = value
        End Set
    End Property

    Public Property UsuarioCliente() As String
        Get
            Return Me.Usuario
        End Get
        Set(ByVal value As String)
            Me.Usuario = value
        End Set
    End Property

    Public Property ContrasenaCliente() As String
        Get
            Return Me.Contrasena
        End Get
        Set(ByVal value As String)
            Me.Contrasena = value
        End Set
    End Property

    Public Property ValidoCliente() As Integer
        Get
            Return Me.Valido
        End Get
        Set(ByVal value As Integer)
            Me.Valido = value
        End Set
    End Property

End Class
