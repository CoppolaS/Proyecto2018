Public Class Cargos
    Private ID_Cargo As Integer
    Private Nombre As String

    Public Sub New(ByVal ID_Cargo As Integer, ByVal Nombre As String)
        Me.ID_Cargo = ID_Cargo
        Me.Nombre = Nombre
    End Sub

    Public Sub New()

    End Sub

    Public Property IDCargo() As Integer
        Get
            Return Me.ID_Cargo
        End Get
        Set(ByVal value As Integer)
            Me.ID_Cargo = value
        End Set
    End Property

    Public Property NombreCargo() As String
        Get
            Return Me.Nombre
        End Get
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property
End Class