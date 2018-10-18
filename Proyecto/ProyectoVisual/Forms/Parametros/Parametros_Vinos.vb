Imports Negocio
Imports System.IO
Imports System.Drawing.Imaging

Public Class Parametros_Vinos
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Vinos
    Dim dv As New DataView
    Dim imgpath As String
    Dim arrImage1() As Byte

    Private Sub Parametros_Cepas_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        ComboBox3.Items.Add("Nombre")
        ComboBox3.Items.Add("Descripción")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.SelectedIndex() = 0
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
        dv = Verif.ValidoListaBotellas(Tabla.ID)
        Tabla2.DataGridView1.DataSource = dv
        Tabla2.DataGridView1.ClearSelection()
    End Sub

    Private Sub CargarTabla3()
        dv = Verif.ValidoListaCepas(Tabla.ID)
        Tabla3.DataGridView1.DataSource = dv
        Tabla3.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda, Tabla2.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            Button2.Enabled = True
            CargarTabla2()
            CargarTabla3()
        Else
            Button2.Enabled = False
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
    End Sub

    Private Sub IngresarVino(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        encapsuladora.NombreVino = TextBox1.Text
        encapsuladora.DescripcionVino = TextBox2.Text
        Verif.ValidoIngresoVinos(encapsuladora)
        TextBox1.Clear()
        TextBox2.Clear()
        CargarTabla1()
    End Sub

    'ingresarfoto
    'Dim mstream1 As New MemoryStream()
    '    PictureBox1.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
    '    arrImage1 = mstream1.GetBuffer()
    'Dim FileSize1 As UInt32
    '    FileSize1 = mstream1.Length
    '    mstream1.Close()
    '    encapsuladora.NombreCepa = TextBox0.Text
    '    encapsuladora.ImagenUvaCepa = arrImage1
    '    encapsuladora.ImagenMostoCepa = arrImage2
    '    encapsuladora.DescripcionUvaCepa = TextBox1.Text
    '    encapsuladora.DescripcionMostoCepa = TextBox2.Text
    '    encapsuladora.PrecioUvaCepa = TextBox3.Text
    '    encapsuladora.PrecioMostoCepa = TextBox4.Text
    '    Verif.ValidoIngresoCepas(encapsuladora)
    '    TextBox0.Clear()
    '    TextBox1.Clear()
    '    TextBox2.Clear()
    '    TextBox3.Clear()
    '    TextBox4.Clear()
    '    Label2.Text = "Imagen 1"
    '    Label5.Text = "Imagen 2"
    '    Pic1.Image = Nothing
    '    Pic2.Image = Nothing
    '    CargarTabla()


    'Private Sub Imagen1(sender As System.Object, e As System.EventArgs)
    '    Try
    '        Dim OFD As FileDialog = New OpenFileDialog()
    '        OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
    '        If OFD.ShowDialog() = DialogResult.OK Then
    '            imgpath = OFD.FileName
    '            Label2.Text = OFD.FileName
    '            Pic1.ImageLocation = imgpath
    '        End If
    '        OFD = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString())
    '    End Try
    'End Sub

    'Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
    '    encapsuladora.IDCepa = Tabla.ID
    '    Verif.ValidoEliminarCepas(encapsuladora)
    '    CargarTabla()
    'End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

End Class