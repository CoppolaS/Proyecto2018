Public Class Hectareas
    Private Cantidad As Integer
    Private ID_Hectarea As Integer
    Private Numero As Integer
    Private MetrosLibres As Integer
    Private MetrosOcupados As Integer
    Private Sucursal As String

    Public Sub New(ByVal Cantidad As Integer, ByVal ID_Hectarea As Integer, ByVal Numero As Integer, ByVal MetrosLibres As Integer, ByVal MetrosOcupados As Integer, ByVal Sucursal As String)
        Me.Cantidad = Cantidad
        Me.ID_Hectarea = ID_Hectarea
        Me.Numero = Numero
        Me.MetrosLibres = MetrosLibres
        Me.MetrosOcupados = MetrosOcupados
        Me.Sucursal = Sucursal
    End Sub

    Public Sub New()

    End Sub

    Public Property CantidadHectareas() As Integer
        Get
            Return Me.Cantidad
        End Get
        Set(ByVal value As Integer)
            Me.Cantidad = value
        End Set
    End Property

    Public Property IDHectarea() As Integer
        Get
            Return Me.ID_Hectarea
        End Get
        Set(ByVal value As Integer)
            Me.ID_Hectarea = value
        End Set
    End Property

    Public Property NumeroHectarea() As Integer
        Get
            Return Me.Numero
        End Get
        Set(ByVal value As Integer)
            Me.Numero = value
        End Set
    End Property

    Public Property MLibresHectarea() As Integer
        Get
            Return Me.MetrosLibres
        End Get
        Set(ByVal value As Integer)
            Me.MetrosLibres = value
        End Set
    End Property

    Public Property MOcupadosHectarea() As Integer
        Get
            Return Me.MetrosOcupados
        End Get
        Set(ByVal value As Integer)
            Me.MetrosOcupados = value
        End Set
    End Property

    Public Property SucursalHectarea() As String
        Get
            Return Me.Sucursal
        End Get
        Set(ByVal value As String)
            Me.Sucursal = value
        End Set
    End Property

End Class
