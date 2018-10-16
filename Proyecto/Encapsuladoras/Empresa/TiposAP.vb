Public Class TiposAP
    Private ID_TipoAP As Integer
    Private Nombre As String
    Private Alarmas As Boolean
    Private Cosechas As Boolean
    Private MateriaPrima As Boolean
    Private ProductoIntermedio As Boolean

    Public Sub New(ByVal ID_TipoAP As Integer, ByVal Nombre As String, ByVal Alarmas As Boolean, ByVal Cosechas As Boolean, ByVal MateriaPrima As Boolean, ByVal ProductoIntermedio As Boolean)
        Me.ID_TipoAP = ID_TipoAP
        Me.Nombre = Nombre
        Me.Alarmas = Alarmas
        Me.Cosechas = Cosechas
        Me.MateriaPrima = MateriaPrima
        Me.ProductoIntermedio = ProductoIntermedio
    End Sub

    Public Sub New()

    End Sub

    Public Property IDTipoAP() As Integer
        Get
            Return Me.ID_TipoAP
        End Get
        Set(ByVal value As Integer)
            Me.ID_TipoAP = value
        End Set
    End Property

    Public Property NombreTipoAP() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property AlarmasTipoAP() As Boolean
        Get
            Return Me.Alarmas
        End Get
        Set(ByVal value As Boolean)
            Me.Alarmas = value
        End Set
    End Property

    Public Property CosechasTipoAP() As Boolean
        Get
            Return Me.Cosechas
        End Get
        Set(ByVal value As Boolean)
            Me.Cosechas = value
        End Set
    End Property

    Public Property MateriaPrimaTipoAP() As Boolean
        Get
            Return Me.MateriaPrima
        End Get
        Set(ByVal value As Boolean)
            Me.MateriaPrima = value
        End Set
    End Property

    Public Property ProductoIntermedioTipoAP() As Boolean
        Get
            Return Me.ProductoIntermedio
        End Get
        Set(ByVal value As Boolean)
            Me.ProductoIntermedio = value
        End Set
    End Property
End Class
