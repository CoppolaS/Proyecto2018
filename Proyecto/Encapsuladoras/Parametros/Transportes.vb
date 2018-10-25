Public Class Transportes
    Private ID_Transporte As Integer
    Private Capacidad As Integer
    Private Producto As String
    Private Tipo As String
    Private Nombre As String
    Private Ocupados As Integer
    Private Cantidad As Integer

    Public Sub New(ByVal ID_Transporte As Integer, ByVal Capacidad As Integer, ByVal Producto As String, ByVal Tipo As String, ByVal Nombre As String, ByVal Ocupados As Integer, ByVal Cantidad As Integer)
        Me.ID_Transporte = ID_Transporte
        Me.Capacidad = Capacidad
        Me.Producto = Producto
        Me.Tipo = Tipo
        Me.Nombre = Nombre
        Me.Ocupados = Ocupados
        Me.Cantidad = Cantidad
    End Sub

    Public Sub New()

    End Sub

    Public Property IDTransporte() As Integer
        Get
            Return Me.ID_Transporte
        End Get
        Set(ByVal value As Integer)
            Me.ID_Transporte = value
        End Set
    End Property

    Public Property CapacidadTransporte() As Integer
        Get
            Return Me.Capacidad
        End Get
        Set(ByVal value As Integer)
            Me.Capacidad = value
        End Set
    End Property

    Public Property ProductoTransporte() As String
        Get
            Return Me.Producto
        End Get
        Set(ByVal value As String)
            Me.Producto = value
        End Set
    End Property

    Public Property TipoTransporte() As String
        Get
            Return Me.Tipo
        End Get
        Set(ByVal value As String)
            Me.Tipo = value
        End Set
    End Property

    Public Property NombreTransporte() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property OcupadosTransporte() As Integer
        Get
            Return Me.Ocupados
        End Get
        Set(ByVal value As Integer)
            Me.Ocupados = value
        End Set
    End Property

    Public Property CantidadTransporte() As Integer
        Get
            Return Me.Cantidad
        End Get
        Set(ByVal value As Integer)
            Me.Cantidad = value
        End Set
    End Property

End Class
