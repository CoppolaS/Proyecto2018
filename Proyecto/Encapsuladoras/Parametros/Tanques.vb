Public Class Tanques
    Private ID_Tanque As Integer
    Private Numero As Integer
    Private Disponible As Boolean
    Private Capacidad As Integer
    Private Material As String
    Private Sucursal As String

    Public Sub New(ByVal ID_Tanque As Integer, ByVal Numero As Integer, ByVal Disponible As Boolean, ByVal Capacidad As Integer, ByVal Material As String, ByVal Sucursal As String)
        Me.ID_Tanque = ID_Tanque
        Me.Numero = Numero
        Me.Disponible = Disponible
        Me.Capacidad = Capacidad
        Me.Material = Material
        Me.Sucursal = Sucursal
    End Sub

    Public Sub New()

    End Sub

    Public Property IDTanque() As Integer
        Get
            Return Me.ID_Tanque
        End Get
        Set(ByVal value As Integer)
            Me.ID_Tanque = value
        End Set
    End Property

    Public Property NumeroTanque() As Integer
        Get
            Return Me.Numero
        End Get
        Set(ByVal value As Integer)
            Me.Numero = value
        End Set
    End Property

    Public Property DisponibleTanque() As Boolean
        Get
            Return Me.Disponible
        End Get
        Set(ByVal value As Boolean)
            Me.Disponible = value
        End Set
    End Property

    Public Property CapacidadTanque() As Integer
        Get
            Return Me.Capacidad
        End Get
        Set(ByVal value As Integer)
            Me.Capacidad = value
        End Set
    End Property

    Public Property MaterialTanque() As String
        Get
            Return Me.Material
        End Get
        Set(ByVal value As String)
            Me.Material = value
        End Set
    End Property

    Public Property SucursalTanque() As String
        Get
            Return Me.Sucursal
        End Get
        Set(ByVal value As String)
            Me.Sucursal = value
        End Set
    End Property
End Class
