Public Class DatosCultivos
    Private Fecha As Date
    Private Dato As Integer
    Private Valor As Integer
    Private ID As Integer

    Public Sub New(ByVal Fecha As Date, ByVal Dato As Integer, ByVal Valor As Integer, ByVal ID As Integer)
        Me.Fecha = Fecha
        Me.Dato = Dato
        Me.Valor = Valor
        Me.ID = ID
    End Sub

    Public Sub New()

    End Sub

    Public Property FechaDato() As Date
        Get
            Return Me.Fecha
        End Get
        Set(ByVal value As Date)
            Me.Fecha = value
        End Set
    End Property

    Public Property NroDato() As Integer
        Get
            Return Me.Dato
        End Get
        Set(ByVal value As Integer)
            Me.Dato = value
        End Set
    End Property

    Public Property ValorDato() As Integer
        Get
            Return Me.Valor
        End Get
        Set(ByVal value As Integer)
            Me.Valor = value
        End Set
    End Property

    Public Property IDDato() As Integer
        Get
            Return Me.ID
        End Get
        Set(ByVal value As Integer)
            Me.ID = value
        End Set
    End Property

End Class
