Public Class Produccion
    Private ID_Parcela As Integer
    Private FechaCosechado As Date
    Private Cantidad As Integer
    Private EstadoSanitario As Integer
    Private FechaInicioProceso As Date
    Private Proceso As Integer

    Public Sub New(ByVal ID_Parcela As Integer, ByVal FechaCosechado As Date, ByVal Cantidad As Integer, ByVal EstadoSanitario As Integer, ByVal FechaInicioProceso As Date, ByVal Proceso As Integer)
        Me.ID_Parcela = ID_Parcela
        Me.FechaCosechado = FechaCosechado
        Me.Cantidad = Cantidad
        Me.EstadoSanitario = EstadoSanitario
        Me.FechaInicioProceso = FechaInicioProceso
        Me.Proceso = Proceso
    End Sub

    Public Sub New()

    End Sub

    Public Property ID_ParcelaP() As Integer
        Get
            Return Me.ID_Parcela
        End Get
        Set(ByVal value As Integer)
            Me.ID_Parcela = value
        End Set
    End Property

    Public Property FechaCosechadoP() As Date
        Get
            Return Me.FechaCosechado
        End Get
        Set(ByVal value As Date)
            Me.FechaCosechado = value
        End Set
    End Property

    Public Property CantidadP() As Integer
        Get
            Return Me.Cantidad
        End Get
        Set(ByVal value As Integer)
            Me.Cantidad = value
        End Set
    End Property

    Public Property EstadoSanitarioP() As Integer
        Get
            Return Me.EstadoSanitario
        End Get
        Set(ByVal value As Integer)
            Me.EstadoSanitario = value
        End Set
    End Property

    Public Property FechaInicioProcesoP() As Date
        Get
            Return Me.FechaInicioProceso
        End Get
        Set(ByVal value As Date)
            Me.FechaInicioProceso = value
        End Set
    End Property

    Public Property ID_ProcesoP() As Integer
        Get
            Return Me.EstadoSanitario
        End Get
        Set(ByVal value As Integer)
            Me.EstadoSanitario = value
        End Set
    End Property

End Class
