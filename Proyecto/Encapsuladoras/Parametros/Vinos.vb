Public Class Vinos
    Private ID_Vino As Integer
    Private Nombre As String
    Private Descripcion As String

    Public Sub New(ByVal ID_Vino As Integer, ByVal Nombre As String, ByVal Descripcion As String)
        Me.ID_Vino = ID_Vino
        Me.Nombre = Nombre
        Me.Descripcion = Descripcion
    End Sub

    Public Sub New()

    End Sub

    Public Property IDVino() As Integer
        Get
            Return Me.ID_Vino
        End Get
        Set(ByVal value As Integer)
            Me.ID_Vino = value
        End Set
    End Property

    Public Property NombreVino() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property DescripcionVino() As String
        Get
            Return Me.Descripcion
        End Get
        Set(ByVal value As String)
            Me.Descripcion = value
        End Set
    End Property
End Class
