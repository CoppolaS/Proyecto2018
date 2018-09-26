Public Class Vendedores
    Private ID_Vendedor As Integer
    Private Nombre As String
    Private Telefono As Integer
    Private Mail As String
    Private Direccion As String

    Public Sub New(ByVal ID_Vendedor As Integer, ByVal Nombre As String, ByVal Telefono As Integer, ByVal Mail As String, ByVal Direccion As String)
        Me.ID_Vendedor = ID_Vendedor
        Me.Nombre = Nombre
        Me.Telefono = Telefono
        Me.Mail = Mail
        Me.Direccion = Direccion
    End Sub

    Public Sub New()

    End Sub

    Public Property IDVendedor() As Integer
        Get
            Return Me.ID_Vendedor
        End Get
        Set(ByVal value As Integer)
            Me.ID_Vendedor = value
        End Set
    End Property

    Public Property NombreVendedor() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property TelefonoVendedor() As Integer
        Get
            Return Me.Telefono
        End Get
        Set(ByVal value As Integer)
            Me.Telefono = value
        End Set
    End Property

    Public Property MailVendedor() As String
        Get
            Return Me.Mail
        End Get
        Set(ByVal value As String)
            Me.Mail = value
        End Set
    End Property

    Public Property DireccionVendedor() As String
        Get
            Return Me.Direccion
        End Get
        Set(ByVal value As String)
            Me.Direccion = value
        End Set
    End Property
End Class
