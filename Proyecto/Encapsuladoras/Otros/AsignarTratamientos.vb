Public Class AsignarTratamientos
    Private FechaPlantado As Date
    Private ID_Cepa As Integer
    Private ID_Parcela As Integer
    Private ID_Hectarea As Integer

    Public Sub New(ByVal FechaPlantado As Date, ByVal ID_Cepa As Integer, ByVal ID_Parcela As Integer, ByVal ID_Hectarea As Integer)
        Me.FechaPlantado = FechaPlantado
        Me.ID_Cepa = ID_Cepa
        Me.ID_Parcela = ID_Parcela
        Me.ID_Hectarea = ID_Hectarea
    End Sub

    Public Sub New()

    End Sub

    Public Property FechaPlantadoAT() As Date
        Get
            Return Me.FechaPlantado
        End Get
        Set(ByVal value As Date)
            Me.FechaPlantado = value
        End Set
    End Property

    Public Property ID_CepaAT() As Integer
        Get
            Return Me.ID_Cepa
        End Get
        Set(ByVal value As Integer)
            Me.ID_Cepa = value
        End Set
    End Property

    Public Property ID_ParcelaAT() As Integer
        Get
            Return Me.ID_Parcela
        End Get
        Set(ByVal value As Integer)
            Me.ID_Parcela = value
        End Set
    End Property

    Public Property ID_HectareaAT() As Integer
        Get
            Return Me.ID_Hectarea
        End Get
        Set(ByVal value As Integer)
            Me.ID_Hectarea = value
        End Set
    End Property

End Class
