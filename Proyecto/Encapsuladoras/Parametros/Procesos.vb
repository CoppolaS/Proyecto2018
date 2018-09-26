Public Class Procesos
    Private ID_Proceso As Integer
    Private Nombre As String
    Private Descripcion As String
    Private MateriaPrima As Boolean
    Private ProductoIntermedio As Boolean
    Private Barrica As Boolean
    Private Tanque As Boolean

    Public Sub New(ByVal ID_Proceso As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal MateriaPrima As Boolean, ByVal ProductoIntermedio As Boolean, ByVal Barrica As Boolean, ByVal Tanque As Boolean)
        Me.ID_Proceso = ID_Proceso
        Me.Nombre = Nombre
        Me.Descripcion = Descripcion
        Me.MateriaPrima = MateriaPrima
        Me.ProductoIntermedio = ProductoIntermedio
        Me.Barrica = Barrica
        Me.Tanque = Tanque
    End Sub

    Public Sub New()

    End Sub

    Public Property IDProceso() As Integer
        Get
            Return Me.ID_Proceso
        End Get
        Set(ByVal value As Integer)
            Me.ID_Proceso = value
        End Set
    End Property

    Public Property NombreProceso() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property DescripcionProceso() As String
        Get
            Return Me.Descripcion
        End Get
        Set(ByVal value As String)
            Me.Descripcion = value
        End Set
    End Property

    Public Property MateriaPrimaProceso() As Boolean
        Get
            Return Me.MateriaPrima
        End Get
        Set(ByVal value As Boolean)
            Me.MateriaPrima = value
        End Set
    End Property

    Public Property ProductoIntermedioProceso() As Boolean
        Get
            Return Me.ProductoIntermedio
        End Get
        Set(ByVal value As Boolean)
            Me.ProductoIntermedio = value
        End Set
    End Property

    Public Property BarricaProceso() As Boolean
        Get
            Return Me.Barrica
        End Get
        Set(ByVal value As Boolean)
            Me.Barrica = value
        End Set
    End Property

    Public Property TanqueProceso() As Boolean
        Get
            Return Me.Tanque
        End Get
        Set(ByVal value As Boolean)
            Me.Tanque = value
        End Set
    End Property

End Class
