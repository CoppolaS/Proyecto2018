Imports Negocio
Imports System.IO
Imports System.Drawing.Imaging

Public Class Parametros_Vinos
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Vinos
    Dim encapsuladoraB As New Encapsuladoras.Botellas
    Dim encapsuladoraC As New Encapsuladoras.Cepas
    Dim dv As New DataView
    Dim imgpath As String
    Dim arrImage() As Byte

    Private Sub Parametros_Cepas_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox3.Items.Add("Nombre")
        ComboBox3.Items.Add("Descripción")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.SelectedIndex() = 0
        dv = Verif.ValidoListaBotellas
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox1.Items.Add(dv(i).Item("ID").ToString())
        Next
        dv = Verif.ValidoListaCepas
        dv.RowFilter = "Eliminado = 0"
        For i As Integer = 0 To dv.Count - 1
            ComboBox2.Items.Add(dv(i).Item("ID").ToString())
        Next
        CargarTabla1()
    End Sub

    Private Sub CargarTabla1() Handles buscador.TextChanged, ComboBox3.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaVinos()
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox3.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox3.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(3).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla2()
        dv = Verif.ValidoListaBotellas(Tabla1.DataGridView1.Item(0, Tabla1.DataGridView1.CurrentRow.Index).Value)
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla3()
        dv = Verif.ValidoListaCepas(Tabla1.DataGridView1.Item(0, Tabla1.DataGridView1.CurrentRow.Index).Value)
        Tabla3.DataGridView1.DataSource = dv
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            Button2.Enabled = True
            ComboBox1.Enabled = True
            Button1.Enabled = True
            TextBox3.Enabled = True
            ComboBox2.Enabled = True
            CargarTabla2()
            CargarTabla3()
        Else
            Button2.Enabled = False
            ComboBox1.Enabled = False
            Button1.Enabled = False
            TextBox3.Enabled = False
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub CeldaSeleccionada2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla2.ClickCelda
        If Tabla2.DataGridView1.CurrentCell.ColumnIndex = 2 Then
            Dim mybyte As Byte() = Tabla2.DataGridView1.CurrentCell.Value
            Dim img As Image
            Dim ms As MemoryStream = New MemoryStream(mybyte)
            img = Drawing.Image.FromStream(ms)
            Imagen.Show()
            Imagen.PictureBox1.Image = img
        End If

        If Tabla2.DataGridView1.SelectedRows.Count > 0 Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub

    Private Sub CeldaSeleccionada3(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla3.ClickCelda
        If Tabla3.DataGridView1.SelectedRows.Count > 0 Then
            Button5.Enabled = True
        Else
            Button5.Enabled = False
        End If
    End Sub

    Private Sub IngresarVino(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        encapsuladora.NombreVino = TextBox1.Text
        encapsuladora.DescripcionVino = TextBox2.Text
        Verif.ValidoIngresoVinos(encapsuladora)
        TextBox1.Clear()
        TextBox2.Clear()
        CargarTabla1()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        encapsuladora.IDVino = Tabla1.DataGridView1.Item(0, Tabla1.DataGridView1.CurrentRow.Index).Value
        Verif.ValidoEliminarVinos(encapsuladora)
        CargarTabla1()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged, Button2.Click, TextBox3.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If

        If ComboBox1.SelectedIndex <> -1 And TextBox3.TextLength > 0 Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If

        If ComboBox2.SelectedIndex <> -1 Then
            Button7.Enabled = True
        Else
            Button7.Enabled = False
        End If
    End Sub

    Private Sub GuardarImagen(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()
            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Label11.Text = OFD.FileName
                PictureBox1.ImageLocation = imgpath
            End If
            OFD = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub AsignarBotella(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim mstream As New MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()
        encapsuladoraB.IDBotella = Integer.Parse(ComboBox1.SelectedItem.ToString)
        encapsuladoraB.IDVino = Tabla.ID
        encapsuladoraB.FotoBotella = arrImage
        encapsuladoraB.PrecioBotella = Double.Parse(TextBox3.Text)
        Verif.ValidoIngresoBotellasVinos(encapsuladoraB)
        ComboBox1.SelectedIndex = -1
        PictureBox1.Image = Nothing
        TextBox3.Clear()
        Label11.Text = "Ruta de la imagen"
        CargarTabla1()
        CargarTabla2()
    End Sub

    Private Sub AsignarCepa(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        encapsuladoraC.IDCepa = Integer.Parse(ComboBox2.SelectedItem.ToString)
        encapsuladoraC.IDVino = Tabla1.DataGridView1.Item(0, Tabla1.DataGridView1.CurrentRow.Index).Value
        Verif.ValidoIngresoCepasVinos(encapsuladoraC)
        ComboBox2.SelectedIndex = -1
        CargarTabla1()
        CargarTabla3()
    End Sub

    Private Sub EiminarBotella(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        encapsuladoraB.IDBotella = Tabla2.DataGridView1.Item(0, Tabla2.DataGridView1.CurrentRow.Index).Value
        encapsuladoraB.IDVino = Tabla1.DataGridView1.Item(0, Tabla1.DataGridView1.CurrentRow.Index).Value
        Verif.ValidoEliminarBotellasVinos(encapsuladoraB)
        CargarTabla1()
        CargarTabla2()
    End Sub

    Private Sub EliminarCepa(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        encapsuladoraC.IDCepa = Tabla3.DataGridView1.Item(0, Tabla3.DataGridView1.CurrentRow.Index).Value
        encapsuladoraC.IDVino = Tabla1.DataGridView1.Item(0, Tabla1.DataGridView1.CurrentRow.Index).Value
        Verif.ValidoEliminarCepasVinos(encapsuladoraC)
        CargarTabla1()
        CargarTabla3()
    End Sub
End Class