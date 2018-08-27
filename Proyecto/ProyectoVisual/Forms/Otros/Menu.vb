Imports Datos.UsuarioLogeado

Public Class Menu
    'debajo: eventos de los botones del menustrip1

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = Datos.UsuarioLogeado.User & vbNewLine & Datos.UsuarioLogeado.Cargo
        Dim cargo As String = Datos.UsuarioLogeado.Cargo
        Select Case cargo
            Case "Técnico"
                'MsgBox("tecnico")
            Case "Gerente general"
                'MsgBox("gerente general")
            Case "Administrativo"
                PersonalToolStripMenuItem.Enabled = False
                CargosToolStripMenuItem.Enabled = False
                CompradoresToolStripMenuItem.Enabled = False
                CargosToolStripMenuItem.Enabled = False
                SucursalesToolStripMenuItem.Enabled = False
                TiposDeAsesoresToolStripMenuItem.Enabled = False
                VendedoresToolStripMenuItem.Enabled = False
        End Select
    End Sub

    Private Sub InicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        If (ParentForm.Name = "Inicio") Then
            Exit Sub
        Else
            Inicio.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub CepasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CepasToolStripMenuItem.Click
        If (ParentForm.Name = "Plantaciones_Cepas") Then
            Exit Sub
        Else
            Plantaciones_Cepas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub DatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem.Click
        If (ParentForm.Name = "Plantaciones_Datos") Then
            Exit Sub
        Else
            Plantaciones_Datos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub HectáreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HectáreasToolStripMenuItem.Click
        If (ParentForm.Name = "Plantaciones_Hectareas") Then
            Exit Sub
        Else
            Plantaciones_Hectareas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ParcelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParcelasToolStripMenuItem.Click
        If (ParentForm.Name = "Plantaciones_Parcelas") Then
            Exit Sub
        Else
            Plantaciones_Parcelas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem.Click
        If (ParentForm.Name = "MateriaPrima_Reservas") Then
            Exit Sub
        Else
            MateriaPrima_Reservas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransaccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionesToolStripMenuItem.Click
        If (ParentForm.Name = "MateriaPrima_Transacciones") Then
            Exit Sub
        Else
            MateriaPrima_Transacciones.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportesToolStripMenuItem.Click
        If (ParentForm.Name = "MateriaPrima_Transportes") Then
            Exit Sub
        Else
            MateriaPrima_Transportes.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub DatosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem1.Click
        If (ParentForm.Name = "MateriaPrima_Datos") Then
            Exit Sub
        Else
            MateriaPrima_Datos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónToolStripMenuItem.Click
        If (ParentForm.Name = "MateriaPrima_Produccion") Then
            Exit Sub
        Else
            MateriaPrima_Produccion.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ReservasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem1.Click
        If (ParentForm.Name = "ProductoIntermedio_Reservas") Then
            Exit Sub
        Else
            ProductoIntermedio_Reservas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransaccionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionesToolStripMenuItem1.Click
        If (ParentForm.Name = "ProductoIntermedio_Transacciones") Then
            Exit Sub
        Else
            ProductoIntermedio_Transacciones.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransportesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportesToolStripMenuItem1.Click
        If (ParentForm.Name = "ProductoIntermedio_Transportes") Then
            Exit Sub
        Else
            ProductoIntermedio_Transportes.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub DatosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem2.Click
        If (ParentForm.Name = "ProductoIntermedio_Datos") Then
            Exit Sub
        Else
            ProductoIntermedio_Datos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ProducciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónToolStripMenuItem1.Click
        If (ParentForm.Name = "ProductoIntermedio_Produccion") Then
            Exit Sub
        Else
            ProductoIntermedio_Produccion.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ReservasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem2.Click
        If (ParentForm.Name = "ProductoIntermedio_Reservas") Then
            Exit Sub
        Else
            ProductoFinal_Reservas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransaccionesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionesToolStripMenuItem2.Click
        If (ParentForm.Name = "ProductoFinal_Transacciones") Then
            Exit Sub
        Else
            ProductoFinal_Transacciones.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransportesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportesToolStripMenuItem2.Click
        If (ParentForm.Name = "ProductoFinal_Transportes") Then
            Exit Sub
        Else
            ProductoFinal_Transportes.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub VinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VinosToolStripMenuItem.Click
        If (ParentForm.Name = "ProductoFinal_Vinos") Then
            Exit Sub
        Else
            ProductoFinal_Vinos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub BarricasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarricasToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Barricas") Then
            Exit Sub
        Else
            Parametros_Barricas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub DatosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem3.Click
        If (ParentForm.Name = "Parametros_Datos") Then
            Exit Sub
        Else
            Parametros_Datos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesosToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Procesos") Then
            Exit Sub
        Else
            Parametros_Procesos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TanquesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TanquesToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Tanques") Then
            Exit Sub
        Else
            Parametros_Tanques.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransportesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportesToolStripMenuItem3.Click
        If (ParentForm.Name = "Parametros_Transportes") Then
            Exit Sub
        Else
            Parametros_Transportes.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Personal") Then
            Exit Sub
        Else
            Empresa_Funcionarios.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub AsesoresProfesionalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsesoresProfesionalesToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_AsesoresProfesionales") Then
            Exit Sub
        Else
            Empresa_AsesoresProfesionales.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Cargos") Then
            Exit Sub
        Else
            Empresa_Cargos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub CompradoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompradoresToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Compradores") Then
            Exit Sub
        Else
            Empresa_Compradores.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucursalesToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Sucursales") Then
            Exit Sub
        Else
            Empresa_Sucursales.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TiposDeAsesoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeAsesoresToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_TiposDeAsesores") Then
            Exit Sub
        Else
            Empresa_TiposDeAsesores.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Vendedores") Then
            Exit Sub
        Else
            Empresa_Vendedores.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadísticasToolStripMenuItem.Click
        If (ParentForm.Name = "Estadisticas") Then
            Exit Sub
        Else
            Estadisticas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub RegistroHistóricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroHistóricoToolStripMenuItem.Click
        If (ParentForm.Name = "RegistroHistorico") Then
            Exit Sub
        Else
            RegistroHistorico.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Login.Show()
        ParentForm.Close()
    End Sub

    'Private Sub ReportarUnErrorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarUnErrorToolStripMenuItem.Click

    'End Sub

    'Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click

    'End Sub

End Class
