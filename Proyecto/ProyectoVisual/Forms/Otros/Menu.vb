Imports Datos.UsuarioLogeado

Public Class Menu
    'rehacer menu cuando tengamos el definitivo
    Private Sub InicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        If (ParentForm.Name = "Inicio") Then
            Exit Sub
        Else
            Inicio.Show()
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
        If (ParentForm.Name = "Empresa_Funcionarios") Then
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
        If (ParentForm.Name = "Empresa_Clientes") Then
            Exit Sub
        Else
            Empresa_Clientes.Show()
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

    Private Sub TerrenosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TerrenosToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Terrenos") Then
            Exit Sub
        Else
            Empresa_Terrenos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub BotellasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BotellasToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Botellas") Then
            Exit Sub
        Else
            Parametros_Botellas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub CepasToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles CepasToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Cepas") Then
            Exit Sub
        Else
            Parametros_Cepas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TratamientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TratamientosToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Tratamientos") Then
            Exit Sub
        Else
            Parametros_Tratamientos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub VinosToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles VinosToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Vinos") Then
            Exit Sub
        Else
            Parametros_Vinos.Show()
            ParentForm.Close()
        End If
    End Sub
End Class
