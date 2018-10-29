Imports Datos.UsuarioLogeado

Public Class Menu
    'privilegios
    '1=Gerente general
    '2=Gerente de sucursal
    '3=Técnico
    '4=Administrativo
    Private Sub Menu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case Datos.UsuarioLogeado.Privilegios
            Case 3
                TransaccionesToolStripMenuItem.Enabled = False
                RegistroHistóricoToolStripMenuItem.Enabled = False
            Case 4
                TransaccionesToolStripMenuItem.Enabled = False
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

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Login.Show()
        ParentForm.Close()
    End Sub

    Private Sub ProducciónToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ProducciónToolStripMenuItem1.Click
        If (ParentForm.Name = "Produccion") Then
            Exit Sub
        Else
            Produccion.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub GestiónDeCultivosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestiónDeCultivosToolStripMenuItem.Click
        If (ParentForm.Name = "GestionCultivos") Then
            Exit Sub
        Else
            GestionCultivos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TrasladosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TrasladosToolStripMenuItem.Click
        If (ParentForm.Name = "Traslados") Then
            Exit Sub
        Else
            'Traslados.Show()
            'ParentForm.Close()
        End If
    End Sub

    Private Sub AsignarTratamientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarTratamientosToolStripMenuItem.Click
        If (ParentForm.Name = "AsignarTratamientos") Then
            Exit Sub
        Else
            AsignarTratamientos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FuncionariosToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Funcionarios") Then
            Exit Sub
        Else
            Empresa_Funcionarios.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub AsesoresProfesionalesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsesoresProfesionalesToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_AsesoresProfesionales") Then
            Exit Sub
        Else
            Empresa_AsesoresProfesionales.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Cargos") Then
            Exit Sub
        Else
            Empresa_Cargos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Clientes") Then
            Exit Sub
        Else
            Empresa_Clientes.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SucursalesToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Sucursales") Then
            Exit Sub
        Else
            Empresa_Sucursales.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TiposDeAsesorProfesionalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TiposDeAsesorProfesionalToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_TiposDeAsesores") Then
            Exit Sub
        Else
            Empresa_TiposDeAsesores.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Vendedores") Then
            Exit Sub
        Else
            Empresa_Vendedores.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TerrenosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TerrenosToolStripMenuItem.Click
        If (ParentForm.Name = "Empresa_Terrenos") Then
            Exit Sub
        Else
            Empresa_Terrenos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub BarricasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarricasToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Barricas") Then
            Exit Sub
        Else
            Parametros_Barricas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatosToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Datos") Then
            Exit Sub
        Else
            Parametros_Datos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcesosToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Procesos") Then
            Exit Sub
        Else
            Parametros_Procesos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TanquesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TanquesToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Tanques") Then
            Exit Sub
        Else
            Parametros_Tanques.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TransportesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransportesToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Transportes") Then
            Exit Sub
        Else
            Parametros_Transportes.Show()
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

    Private Sub CepasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CepasToolStripMenuItem.Click
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

    Private Sub VinosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VinosToolStripMenuItem.Click
        If (ParentForm.Name = "Parametros_Vinos") Then
            Exit Sub
        Else
            Parametros_Vinos.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub TrazabilidadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TrazabilidadToolStripMenuItem.Click
        If (ParentForm.Name = "Trazabilidad") Then
            Exit Sub
        Else
            'Trazabilidad.Show()
            'ParentForm.Close()
        End If
    End Sub


    Private Sub RegistroHistóricoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroHistóricoToolStripMenuItem.Click
        If (ParentForm.Name = "RegistroHistorico") Then
            Exit Sub
        Else
            RegistroHistorico.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        If (ParentForm.Name = "Ventas") Then
            Exit Sub
        Else
            'Ventas.Show()
            'ParentForm.Close()
        End If
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        If (ParentForm.Name = "Compras") Then
            Exit Sub
        Else
            'Compras.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If (ParentForm.Name = "Reservas") Then
            Exit Sub
        Else
            'Reservas.Show()
            'ParentForm.Close()
        End If
    End Sub

    Private Sub GestiónDeProducciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestiónDeProducciónToolStripMenuItem.Click
        If (ParentForm.Name = "GestionProduccion") Then
            Exit Sub
        Else
            GestionProduccion.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If (ParentForm.Name = "Estadisticas") Then
            Exit Sub
        Else
            Estadisticas.Show()
            ParentForm.Close()
        End If
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

End Class
