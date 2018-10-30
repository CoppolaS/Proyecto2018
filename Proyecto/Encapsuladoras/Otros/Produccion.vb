Public Class Produccion
    Private ID_Parcela As Integer
    Private FechaCosechado As Date
    Private Cantidad As Integer
    Private EstadoSanitario As Integer
    Private ID_PI As Integer
    Private ID_MP As Integer
    Private FechaProceso As Date
    Private Proceso As Integer
    Private FechaAvance As Date
    Private CantidadLitros As Integer
    Private ID_Tanque As Integer
    Private ID_Barrica As Integer
    Private ID_Vino As Integer
    Private ID_Botella As Integer

    Public Sub New(ByVal ID_Parcela As Integer, ByVal FechaCosechado As Date, ByVal Cantidad As Integer, ByVal EstadoSanitario As Integer, ByVal ID_PI As Integer, ByVal ID_MP As Integer, ByVal FechaProceso As Date, ByVal Proceso As Integer, ByVal FechaAvance As Date, ByVal CantidadLitros As Integer, ByVal ID_Tanque As Integer, ByVal ID_Barrica As Integer, ByVal ID_Vino As Integer, ByVal ID_Botella As Integer)
        Me.ID_Parcela = ID_Parcela
        Me.FechaCosechado = FechaCosechado
        Me.Cantidad = Cantidad
        Me.EstadoSanitario = EstadoSanitario
        Me.ID_MP = ID_MP
        Me.ID_MP = ID_MP
        Me.FechaProceso = FechaProceso
        Me.Proceso = Proceso
        Me.FechaAvance = FechaAvance
        Me.CantidadLitros = CantidadLitros
        Me.ID_Tanque = ID_Tanque
        Me.ID_Barrica = ID_Barrica
        Me.ID_Vino = ID_Vino
        Me.ID_Botella = ID_Botella
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

    Public Property IDProductoIntermedioP() As Integer
        Get
            Return Me.ID_PI
        End Get
        Set(ByVal value As Integer)
            Me.ID_PI = value
        End Set
    End Property

    Public Property IDMateriaPrimaP() As Integer
        Get
            Return Me.ID_MP
        End Get
        Set(ByVal value As Integer)
            Me.ID_MP = value
        End Set
    End Property

    Public Property FechaProcesoP() As Date
        Get
            Return Me.FechaProceso
        End Get
        Set(ByVal value As Date)
            Me.FechaProceso = value
        End Set
    End Property

    Public Property ID_ProcesoP() As Integer
        Get
            Return Me.Proceso
        End Get
        Set(ByVal value As Integer)
            Me.Proceso = value
        End Set
    End Property

    Public Property FechaAvanceP() As Date
        Get
            Return Me.FechaAvance
        End Get
        Set(ByVal value As Date)
            Me.FechaAvance = value
        End Set
    End Property

    Public Property CantidadLitrosP() As Integer
        Get
            Return Me.CantidadLitros
        End Get
        Set(ByVal value As Integer)
            Me.CantidadLitros = value
        End Set
    End Property

    Public Property ID_TanqueP() As Integer
        Get
            Return Me.ID_Tanque
        End Get
        Set(ByVal value As Integer)
            Me.ID_Tanque = value
        End Set
    End Property

    Public Property ID_BarricaP() As Integer
        Get
            Return Me.ID_Barrica
        End Get
        Set(ByVal value As Integer)
            Me.ID_Barrica = value
        End Set
    End Property

    Public Property ID_VinoP() As Integer
        Get
            Return Me.ID_Vino
        End Get
        Set(ByVal value As Integer)
            Me.ID_Vino = value
        End Set
    End Property

    Public Property ID_BotellaP() As Integer
        Get
            Return Me.ID_Botella
        End Get
        Set(ByVal value As Integer)
            Me.ID_Botella = value
        End Set
    End Property

End Class
