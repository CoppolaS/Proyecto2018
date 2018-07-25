Public Class Inicio

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AlertasToolStripMenuItem.Text = "3 Alertas"
        ObservacionesToolStripMenuItem1.Text = "10 Observaciones"
    End Sub

    Private Sub InicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Controls.Clear()
        InitializeComponent()
        Inicio_Load(e, e)
    End Sub

    Private Sub CepasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CepasToolStripMenuItem.Click
        Plantaciones_Cepas.Show()
        Me.Close()
    End Sub

    Private Sub DatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem.Click
        Plantaciones_Datos.Show()
        Me.Close()
    End Sub
End Class