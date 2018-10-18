Public Class Cepas
    Private ID_Cepa As Integer
    Private Nombre As String
    Private ImagenUva As Array
    Private ImagenMosto As Array
    Private DescripcionUva As String
    Private DescripcionMosto As String
    Private PrecioUva As Double
    Private PrecioMosto As Double
    Private ID_Vino As Integer

    Public Sub New(ByVal ID_Cepa As Integer, ByVal Nombre As String, ByVal ImagenUva As Array, ByVal ImagenMosto As Array, ByVal DescripcionUva As String, ByVal DescripcionMosto As String, ByVal PrecioUva As Double, ByVal PrecioMosto As Double, ByVal ID_Vino As Integer)
        Me.ID_Cepa = ID_Cepa
        Me.Nombre = Nombre
        Me.ImagenUva = ImagenUva
        Me.ImagenMosto = ImagenMosto
        Me.DescripcionUva = DescripcionUva
        Me.DescripcionMosto = DescripcionMosto
        Me.PrecioUva = PrecioUva
        Me.PrecioMosto = PrecioMosto
        Me.ID_Vino = ID_Vino
    End Sub

    Public Sub New()

    End Sub

    Public Property IDCepa() As Integer
        Get
            Return Me.ID_Cepa
        End Get
        Set(ByVal value As Integer)
            Me.ID_Cepa = value
        End Set
    End Property

    Public Property NombreCepa() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property ImagenUvaCepa() As Array
        Get
            Return Me.ImagenUva
        End Get
        Set(ByVal value As Array)
            Me.ImagenUva = value
        End Set
    End Property

    Public Property ImagenMostoCepa() As Array
        Get
            Return Me.ImagenMosto
        End Get
        Set(ByVal value As Array)
            Me.ImagenMosto = value
        End Set
    End Property

    Public Property DescripcionUvaCepa() As String
        Get
            Return Me.DescripcionUva
        End Get
        Set(ByVal value As String)
            Me.DescripcionUva = value
        End Set
    End Property

    Public Property DescripcionMostoCepa() As String
        Get
            Return Me.DescripcionMosto
        End Get
        Set(ByVal value As String)
            Me.DescripcionMosto = value
        End Set
    End Property

    Public Property PrecioUvaCepa() As Double
        Get
            Return Me.PrecioUva
        End Get
        Set(ByVal value As Double)
            Me.PrecioUva = value
        End Set
    End Property

    Public Property PrecioMostoCepa() As Double
        Get
            Return Me.PrecioMosto
        End Get
        Set(ByVal value As Double)
            Me.PrecioMosto = value
        End Set
    End Property

    Public Property IDVino() As Integer
        Get
            Return Me.ID_Vino
        End Get
        Set(ByVal value As Integer)
            Me.ID_Vino = value
        End Set
    End Property

End Class

