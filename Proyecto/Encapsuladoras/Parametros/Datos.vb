Public Class Datos
    Private ID_Dato As Integer
    Private Nombre As String
    Private Unidad As String
    Private Descripcion As String

    Public Sub New(ByVal ID_Dato As Integer, ByVal Nombre As String, ByVal Unidad As String, ByVal Descripcion As String)
        Me.ID_Dato = ID_Dato
        Me.Nombre = Nombre
        Me.Unidad = Unidad
        Me.Descripcion = Descripcion
    End Sub

    Public Sub New()

    End Sub

    Public Property IDDato() As Integer
        Get
            Return Me.ID_Dato
        End Get
        Set(ByVal value As Integer)
            Me.ID_Dato = value
        End Set
    End Property

    Public Property NombreDato() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property UnidadDato() As String
        Get
            Return Me.Unidad
        End Get
        Set(ByVal value As String)
            Me.Unidad = value
        End Set
    End Property

    Public Property DescripcionDato() As String
        Get
            Return Me.Descripcion
        End Get
        Set(ByVal value As String)
            Me.Descripcion = value
        End Set
    End Property
End Class
