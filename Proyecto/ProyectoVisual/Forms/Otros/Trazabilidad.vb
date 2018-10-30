Imports Negocio

Public Class Trazabilidad
    Dim Verif As New Negocio.VerificarOtros
    Dim dv As New DataView

    Private Sub Trazabilidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarTablaPF()
    End Sub

    Private Sub CargarTablaPF()
        dv = Verif.Trazabilidad(1, 0)
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTablaPI() Handles Tabla1.ClickCelda
        dv = Verif.Trazabilidad(2, Tabla.ID)
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTablaMP() Handles Tabla2.ClickCelda
        dv = Verif.Trazabilidad(3, Tabla.ID)
        Tabla3.DataGridView1.DataSource = dv
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTablaPPC() Handles Tabla3.ClickCelda
        dv = Verif.Trazabilidad(4, Tabla.ID)
        Tabla4.DataGridView1.DataSource = dv
        Tabla4.DataGridView1.ClearSelection()
    End Sub

End Class