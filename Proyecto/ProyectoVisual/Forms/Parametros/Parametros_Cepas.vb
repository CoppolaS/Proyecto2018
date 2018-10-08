Imports Negocio
Imports System.IO
Imports System.Drawing.Imaging

Public Class Parametros_Cepas
    Dim Verif As New Negocio.VerificarParametros
    Dim encapsuladora As New Encapsuladoras.Cepas
    Dim dv As New DataView
    Dim imgpath As String
    Dim arrImage1() As Byte
    Dim arrImage2() As Byte

    Private Sub Parametros_Cepas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nombre")
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex() = 0
        CargarTabla()
    End Sub

    Private Sub CargarTabla() Handles buscador.TextChanged, ComboBox1.SelectedValueChanged, CheckBox1.CheckedChanged
        dv = Verif.ValidoListaCepas()
        If CheckBox1.CheckState = CheckState.Checked Then
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%'"
        Else
            dv.RowFilter = "" + ComboBox1.SelectedItem.ToString + " like '%" + buscador.Text.ToString + "%' and Eliminado = 0"
        End If
        Tabla1.DataGridView1.DataSource = dv
        Tabla1.DataGridView1.Columns(8).Visible = False
        Tabla1.DataGridView1.ClearSelection()
    End Sub

    Private Sub CeldaSeleccionada(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla1.ClickCelda
        If Tabla1.DataGridView1.SelectedRows.Count > 0 Then
            eliminar_BTN.Enabled = True
        Else
            eliminar_BTN.Enabled = False
        End If
        If Tabla1.DataGridView1.CurrentCell.ColumnIndex = 2 Or Tabla1.DataGridView1.CurrentCell.ColumnIndex = 3 Then
            Dim mybyte As Byte() = Tabla1.DataGridView1.CurrentCell.Value
            Dim img As Image
            Dim ms As MemoryStream = New MemoryStream(mybyte)
            img = Drawing.Image.FromStream(ms)
            Imagen.Show()
            Imagen.PictureBox1.Image = img
        End If
    End Sub

    Private Sub Imagen1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()
            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Label2.Text = OFD.FileName
                Pic1.ImageLocation = imgpath
            End If
            OFD = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Imagen2(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()
            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Label5.Text = OFD.FileName
                Pic2.ImageLocation = imgpath
            End If
            OFD = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Ingresar(sender As System.Object, e As System.EventArgs) Handles ingresar_BTN.Click
        Dim mstream1 As New MemoryStream()
        Dim mstream2 As New MemoryStream()
        Pic1.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
        Pic2.Image.Save(mstream2, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage1 = mstream1.GetBuffer()
        arrImage2 = mstream2.GetBuffer()
        Dim FileSize1 As UInt32
        Dim FileSize2 As UInt32
        FileSize1 = mstream1.Length
        FileSize2 = mstream2.Length
        mstream1.Close()
        mstream2.Close()
        encapsuladora.NombreCepa = TextBox0.Text
        encapsuladora.ImagenUvaCepa = arrImage1
        encapsuladora.ImagenMostoCepa = arrImage2
        encapsuladora.DescripcionUvaCepa = TextBox1.Text
        encapsuladora.DescripcionMostoCepa = TextBox2.Text
        encapsuladora.PrecioUvaCepa = TextBox3.Text
        encapsuladora.PrecioMostoCepa = TextBox4.Text
        Verif.ValidoIngresoCepas(encapsuladora)
        TextBox0.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Label2.Text = "Imagen 1"
        Label5.Text = "Imagen 2"
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        CargarTabla()
    End Sub

    Private Sub Eliminar(sender As System.Object, e As System.EventArgs) Handles eliminar_BTN.Click
        encapsuladora.IDCepa = Tabla.ID
        Verif.ValidoEliminarCepas(encapsuladora)
        CargarTabla()
    End Sub

    Private Sub Habilitar_Ingreso(sender As Object, e As System.EventArgs) Handles TextBox0.TextChanged, TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged
        If TextBox0.TextLength > 0 And TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And TextBox3.TextLength > 0 And TextBox4.TextLength > 0 Then
            ingresar_BTN.Enabled = True
        Else
            ingresar_BTN.Enabled = False
        End If
    End Sub
End Class

