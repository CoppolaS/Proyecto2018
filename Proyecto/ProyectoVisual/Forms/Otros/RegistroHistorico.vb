Imports Negocio

Public Class RegistroHistorico
    Dim VerifE As New Negocio.VerificarEmpresa
    Dim VerifP As New Negocio.VerificarParametros
    Dim VerifO As New Negocio.VerificarOtros
    Dim GPDF As New Negocio.GenerarPDF
    Dim dv As New DataView

    Private Sub RegistroHistorico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla() Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                dv = VerifO.ValidoListaMateriasPrimas
            Case 1
                dv = VerifO.ValidoListaProductosIntermedios
            Case 2
                dv = VerifO.ValidoListaProductosFinales
            Case 3
                dv = VerifO.ValidoListaHectareas
                dv.Table.Columns.Remove("Nombre")
            Case 4
                dv = VerifE.ValidoListaSucursales
            Case 5
                dv = VerifE.ValidoListaClientes
            Case 6
                dv = VerifE.ValidoListaVendedores
            Case 7
                dv = VerifE.ValidoListaCargos
            Case 8
                dv = VerifE.ValidoListaTiposAP
            Case 9
                dv = VerifE.ValidoListaFuncionarios
            Case 10
                dv = VerifE.ValidoListaAsesoresProfesionales
            Case 11
                dv = VerifP.ValidoListaBarricas
            Case 12
                dv = VerifP.ValidoListaTanques
            Case 13
                dv = VerifP.ValidoListaProcesos
            Case 14
                dv = VerifP.ValidoListaTratamientos
            Case 15
                dv = VerifP.ValidoListaDatos
            Case 16
                dv = VerifP.ValidoListaCepas
            Case 17
                dv = VerifP.ValidoListaBotellas
            Case 18
                dv = VerifP.ValidoListaVinos
            Case 19
                dv = VerifP.ValidoListaTransportes
        End Select
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim NombreTabla As String = ComboBox1.SelectedItem.ToString()
        GPDF.Generopdf(Tabla1.DataGridView1, NombreTabla, NombreTabla)
    End Sub

End Class