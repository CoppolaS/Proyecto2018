Public Class Login
    Private ID_UsuarioPrograma As Integer
    Private Usuario As String
    Private Contrasena As String
    Private Cargo As String

    Public Sub New(ByVal ID_UsuarioPrograma As Integer, ByVal Usuario As String, ByVal Contrasena As String, ByVal Cargo As String)
        Me.ID_UsuarioPrograma = ID_UsuarioPrograma
        Me.Usuario = Usuario
        Me.Contrasena = Contrasena
        Me.Cargo = Cargo
    End Sub

    Public Sub New()

    End Sub

    Public Property ID_UsuarioProgramaLogin() As Integer
        Get
            Return ID_UsuarioPrograma
        End Get
        Set(ByVal value As Integer)
            ID_UsuarioPrograma = value
        End Set
    End Property

    Public Property UsuarioLogin() As String
        Get
            Return Me.Usuario
        End Get

        Set(ByVal value As String)
            Me.Usuario = value
        End Set

    End Property

    Public Property ContrasenaLogin() As String
        Get
            Return Me.Contrasena
        End Get

        Set(ByVal value As String)
            Me.Contrasena = value
        End Set

    End Property

    Public Property CargoLogin() As String
        Get
            Return Me.Cargo
        End Get

        Set(ByVal value As String)
            Me.Cargo = value
        End Set

    End Property

End Class
