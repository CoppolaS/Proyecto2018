Public Class Sucursales
    Private ID_Sucursal As Integer
    Private Nombre As String
    Private Direccion As String

    Public Sub New(ByVal ID_Sucursal As Integer, ByVal Nombre As String, ByVal Direccion As String)
        Me.ID_Sucursal = ID_Sucursal
        Me.Nombre = Nombre
        Me.Direccion = Direccion
    End Sub

    Public Sub New()

    End Sub

    Public Property IDSucursal() As Integer
        Get
            Return Me.ID_Sucursal
        End Get
        Set(ByVal value As Integer)
            Me.ID_Sucursal = value
        End Set
    End Property

    Public Property NombreSucursal() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property

    Public Property DireccionSucursal() As String
        Get
            Return Me.Direccion
        End Get
        Set(ByVal value As String)
            Me.Direccion = value
        End Set
    End Property


End Class
