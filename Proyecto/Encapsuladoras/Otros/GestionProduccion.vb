Public Class GestionProduccion
    Private ID_MP As Integer
    Private ID_PI As Integer
    Private CantidadSeleccionada As Integer
    Private Venta As Boolean

    Public Sub New(ByVal ID_MP As Integer, ByVal ID_PI As Integer, ByVal CantidadSeleccionada As Integer, ByVal Venta As Boolean)
        Me.ID_MP = ID_MP
        Me.ID_PI = ID_PI
        Me.CantidadSeleccionada = CantidadSeleccionada
        Me.Venta = Venta
    End Sub

    Public Sub New()

    End Sub

    Public Property IDMP() As Integer
        Get
            Return Me.ID_MP
        End Get
        Set(ByVal value As Integer)
            Me.ID_MP = value
        End Set
    End Property

    Public Property IDPI() As Integer
        Get
            Return Me.ID_PI
        End Get
        Set(ByVal value As Integer)
            Me.ID_PI = value
        End Set
    End Property

    Public Property Cantidad_Seleccionada() As Integer
        Get
            Return Me.CantidadSeleccionada
        End Get
        Set(ByVal value As Integer)
            Me.CantidadSeleccionada = value
        End Set
    End Property

    Public Property VentaBoolean() As Boolean
        Get
            Return Me.Venta
        End Get
        Set(ByVal value As Boolean)
            Me.Venta = value
        End Set
    End Property

End Class

