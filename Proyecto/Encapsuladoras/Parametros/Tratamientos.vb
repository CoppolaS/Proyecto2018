Public Class Tratamientos
    Private ID_Tratamiento As Integer
    Private Nombre As String
    Private Descripcion As String

    Public Sub New(ByVal ID_Tratamiento As Integer, ByVal Nombre As String, ByVal Descripcion As String)
        Me.ID_Tratamiento = ID_Tratamiento
        Me.Nombre = Nombre
        Me.Descripcion = Descripcion
    End Sub

    Public Sub New()

    End Sub

    Public Property IDTratamiento() As Integer
        Get
            Return Me.ID_Tratamiento
        End Get
        Set(ByVal value As Integer)
            Me.ID_Tratamiento = value
        End Set
    End Property

    Public Property NombreTratamiento() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property DescripcionTratamiento() As String
        Get
            Return Me.Descripcion
        End Get
        Set(ByVal value As String)
            Me.Descripcion = value
        End Set
    End Property
End Class
