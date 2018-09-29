Public Class Parcelas
    Private Cantidad As Integer
    Private ID_Parcela As Integer
    Private Numero As Integer
    Private MetrosCuadrados As Integer
    Private ID_Hectarea As Integer

    Public Sub New(ByVal Cantidad As Integer, ByVal ID_Parcela As Integer, ByVal Numero As Integer, ByVal MetrosCuadrados As Integer, ByVal ID_Hectarea As Integer)
        Me.Cantidad = Cantidad
        Me.ID_Parcela = ID_Parcela
        Me.Numero = Numero
        Me.MetrosCuadrados = MetrosCuadrados
        Me.ID_Hectarea = ID_Hectarea
    End Sub

    Public Sub New()

    End Sub

    Public Property CantidadParcelas() As Integer
        Get
            Return Me.Cantidad
        End Get
        Set(ByVal value As Integer)
            Me.Cantidad = value
        End Set
    End Property

    Public Property IDParcela() As Integer
        Get
            Return Me.ID_Parcela
        End Get
        Set(ByVal value As Integer)
            Me.ID_Parcela = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return Me.Numero
        End Get
        Set(ByVal value As Integer)
            Me.Numero = value
        End Set
    End Property

    Public Property MetrosCuadradosParcela() As Integer
        Get
            Return Me.MetrosCuadrados
        End Get
        Set(ByVal value As Integer)
            Me.MetrosCuadrados = value
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

End Class
