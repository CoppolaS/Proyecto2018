Public Class Botellas
    Private ID_Botella As Integer
    Private Capacidad As Integer

    Public Sub New(ByVal ID_Botella As Integer, ByVal Capacidad As Integer)
        Me.ID_Botella = ID_Botella
        Me.Capacidad = Capacidad
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
End Class
