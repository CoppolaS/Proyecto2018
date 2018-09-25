Public Class Barricas
    Private ID_Barrica As Integer
    Private Numero As Integer
    Private Disponible As Boolean
    Private Capacidad As Integer
    Private Material As String
    Private Usos As Integer
    Private Sucursal As String

    Public Sub New(ByVal ID_Barrica As Integer, ByVal Numero As Integer, ByVal Disponible As Boolean, ByVal Capacidad As Integer, ByVal Material As String, ByVal Usos As Integer, ByVal Sucursal As String)
        Me.ID_Barrica = ID_Barrica
        Me.Numero = Numero
        Me.Disponible = Disponible
        Me.Capacidad = Capacidad
        Me.Material = Material
        Me.Usos = Usos
        Me.Sucursal = Sucursal
    End Sub

    Public Sub New()

    End Sub

    Public Property IDBarrica() As Integer
        Get
            Return Me.ID_Barrica
        End Get
        Set(ByVal value As Integer)
            Me.ID_Barrica = value
        End Set
    End Property

    Public Property NumeroBarrica() As Integer
        Get
            Return Me.Numero
        End Get
        Set(ByVal value As Integer)
            Me.Numero = value
        End Set
    End Property

    Public Property DisponibleBarrica() As Boolean
        Get
            Return Me.Disponible
        End Get
        Set(ByVal value As Boolean)
            Me.Disponible = value
        End Set
    End Property

    Public Property CapacidadBarrica() As Integer
        Get
            Return Me.Capacidad
        End Get
        Set(ByVal value As Integer)
            Me.Capacidad = value
        End Set
    End Property

    Public Property MaterialBarrica() As String
        Get
            Return Me.Material
        End Get
        Set(ByVal value As String)
            Me.Material = value
        End Set
    End Property

    Public Property UsosBarrica() As Integer
        Get
            Return Me.Usos
        End Get
        Set(ByVal value As Integer)
            Me.Usos = value
        End Set
    End Property

    Public Property SucursalBarrica() As String
        Get
            Return Me.Sucursal
        End Get
        Set(ByVal value As String)
            Me.Sucursal = value
        End Set
    End Property

End Class
