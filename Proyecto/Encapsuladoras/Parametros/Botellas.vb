Public Class Botellas
    Private ID_Botella As Integer
    Private Capacidad As Integer
    Private Foto As Array
    Private Precio As Double
    Private ID_Vino As Integer

    Public Sub New(ByVal ID_Botella As Integer, ByVal Capacidad As Integer, ByVal Foto As Array, ByVal Precio As Double, ByVal ID_Vino As Integer)
        Me.ID_Botella = ID_Botella
        Me.Capacidad = Capacidad
        Me.Foto = Foto
        Me.Precio = Precio
        Me.ID_Vino = ID_Vino
    End Sub

    Public Sub New()

    End Sub

    Public Property IDBotella() As Integer
        Get
            Return Me.ID_Botella
        End Get
        Set(ByVal value As Integer)
            Me.ID_Botella = value
        End Set
    End Property

    Public Property CapacidadBotella() As Integer
        Get
            Return Me.Capacidad
        End Get
        Set(ByVal value As Integer)
            Me.Capacidad = value
        End Set
    End Property

    Public Property FotoBotella() As Array
        Get
            Return Me.Foto
        End Get
        Set(ByVal value As Array)
            Me.Foto = value
        End Set
    End Property

    Public Property PrecioBotella() As Double
        Get
            Return Me.Precio
        End Get
        Set(ByVal value As Double)
            Me.Precio = value
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
