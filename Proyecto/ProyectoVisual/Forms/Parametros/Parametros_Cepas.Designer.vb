<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametros_Cepas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buscador = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.eliminar_BTN = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ingresar_BTN = New System.Windows.Forms.Button()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tabla1 = New Proyecto.Tabla()
        Me.Menu1 = New Proyecto.Menu()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(476, 52)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(145, 17)
        Me.CheckBox1.TabIndex = 69
        Me.CheckBox1.Text = "Mostrar cepas eliminadas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Columna: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(326, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Buscar en la tabla: "
        '
        'buscador
        '
        Me.buscador.Location = New System.Drawing.Point(116, 50)
        Me.buscador.Name = "buscador"
        Me.buscador.Size = New System.Drawing.Size(144, 20)
        Me.buscador.TabIndex = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.eliminar_BTN)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Pic2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Pic1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ingresar_BTN)
        Me.GroupBox1.Controls.Add(Me.TextBox0)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(779, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 599)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar y eliminar"
        '
        'eliminar_BTN
        '
        Me.eliminar_BTN.Enabled = False
        Me.eliminar_BTN.Location = New System.Drawing.Point(6, 570)
        Me.eliminar_BTN.Name = "eliminar_BTN"
        Me.eliminar_BTN.Size = New System.Drawing.Size(461, 23)
        Me.eliminar_BTN.TabIndex = 9
        Me.eliminar_BTN.Text = "Eliminar fila seleccionada"
        Me.eliminar_BTN.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(146, 285)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(321, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Precio mosto"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(146, 312)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(321, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Precio uva"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(146, 258)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(321, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Descripción mosto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Descripción uva"
        '
        'Pic2
        '
        Me.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic2.Location = New System.Drawing.Point(253, 90)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(214, 135)
        Me.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic2.TabIndex = 51
        Me.Pic2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Imagen 2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Imagen mosto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Pic1
        '
        Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic1.Location = New System.Drawing.Point(34, 90)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(213, 135)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 48
        Me.Pic1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Imagen 1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Imagen uva"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ingresar_BTN
        '
        Me.ingresar_BTN.Enabled = False
        Me.ingresar_BTN.Location = New System.Drawing.Point(6, 541)
        Me.ingresar_BTN.Name = "ingresar_BTN"
        Me.ingresar_BTN.Size = New System.Drawing.Size(461, 23)
        Me.ingresar_BTN.TabIndex = 8
        Me.ingresar_BTN.Text = "Ingresar"
        Me.ingresar_BTN.UseVisualStyleBackColor = True
        '
        'TextBox0
        '
        Me.TextBox0.Location = New System.Drawing.Point(89, 19)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(378, 20)
        Me.TextBox0.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nombre"
        '
        'Tabla1
        '
        Me.Tabla1.Location = New System.Drawing.Point(12, 75)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(761, 599)
        Me.Tabla1.TabIndex = 64
        '
        'Menu1
        '
        Me.Menu1.Location = New System.Drawing.Point(12, 12)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(1240, 32)
        Me.Menu1.TabIndex = 62
        '
        'Parametros_Cepas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buscador)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.Menu1)
        Me.MaximizeBox = False
        Me.Name = "Parametros_Cepas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros_Cepas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents buscador As System.Windows.Forms.TextBox
    Friend WithEvents Tabla1 As Proyecto.Tabla
    Friend WithEvents Menu1 As Proyecto.Menu
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents eliminar_BTN As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ingresar_BTN As System.Windows.Forms.Button
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
