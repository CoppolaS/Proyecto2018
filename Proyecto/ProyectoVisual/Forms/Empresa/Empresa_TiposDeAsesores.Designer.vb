<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa_TiposDeAsesores
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
        Me.Menu1 = New Proyecto.Menu()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buscador = New System.Windows.Forms.TextBox()
        Me.Tabla1 = New Proyecto.Tabla()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ingresar_BTN = New System.Windows.Forms.Button()
        Me.ingresar_nombreTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.administrar_nombreTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.modificar_BTN = New System.Windows.Forms.Button()
        Me.eliminar_BTN = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.Location = New System.Drawing.Point(12, 7)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(1240, 32)
        Me.Menu1.TabIndex = 15
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(476, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(187, 17)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Mostrar tipos de asesor eliminados"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Columna: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(326, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Buscar en la tabla: "
        '
        'buscador
        '
        Me.buscador.Location = New System.Drawing.Point(116, 46)
        Me.buscador.Name = "buscador"
        Me.buscador.Size = New System.Drawing.Size(144, 20)
        Me.buscador.TabIndex = 32
        '
        'Tabla1
        '
        Me.Tabla1.Location = New System.Drawing.Point(12, 70)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(761, 599)
        Me.Tabla1.TabIndex = 31
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(779, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(477, 624)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox6)
        Me.TabPage1.Controls.Add(Me.CheckBox5)
        Me.TabPage1.Controls.Add(Me.CheckBox4)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.ingresar_BTN)
        Me.TabPage1.Controls.Add(Me.ingresar_nombreTB)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage1.Size = New System.Drawing.Size(469, 596)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ingresar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Location = New System.Drawing.Point(78, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(172, 19)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "¿Puede ingresar alarmas?"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ingresar_BTN
        '
        Me.ingresar_BTN.Enabled = False
        Me.ingresar_BTN.Location = New System.Drawing.Point(13, 560)
        Me.ingresar_BTN.Name = "ingresar_BTN"
        Me.ingresar_BTN.Size = New System.Drawing.Size(443, 23)
        Me.ingresar_BTN.TabIndex = 3
        Me.ingresar_BTN.Text = "Ingresar"
        Me.ingresar_BTN.UseVisualStyleBackColor = True
        '
        'ingresar_nombreTB
        '
        Me.ingresar_nombreTB.Location = New System.Drawing.Point(78, 13)
        Me.ingresar_nombreTB.Name = "ingresar_nombreTB"
        Me.ingresar_nombreTB.Size = New System.Drawing.Size(378, 21)
        Me.ingresar_nombreTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBox7)
        Me.TabPage2.Controls.Add(Me.CheckBox8)
        Me.TabPage2.Controls.Add(Me.CheckBox9)
        Me.TabPage2.Controls.Add(Me.CheckBox3)
        Me.TabPage2.Controls.Add(Me.administrar_nombreTB)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.modificar_BTN)
        Me.TabPage2.Controls.Add(Me.eliminar_BTN)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage2.Size = New System.Drawing.Size(469, 596)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Administrar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(76, 75)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(172, 19)
        Me.CheckBox3.TabIndex = 33
        Me.CheckBox3.Text = "¿Puede ingresar alarmas?"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'administrar_nombreTB
        '
        Me.administrar_nombreTB.Enabled = False
        Me.administrar_nombreTB.Location = New System.Drawing.Point(78, 48)
        Me.administrar_nombreTB.Name = "administrar_nombreTB"
        Me.administrar_nombreTB.Size = New System.Drawing.Size(378, 21)
        Me.administrar_nombreTB.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Nombre"
        '
        'modificar_BTN
        '
        Me.modificar_BTN.Enabled = False
        Me.modificar_BTN.Location = New System.Drawing.Point(13, 531)
        Me.modificar_BTN.Name = "modificar_BTN"
        Me.modificar_BTN.Size = New System.Drawing.Size(443, 23)
        Me.modificar_BTN.TabIndex = 34
        Me.modificar_BTN.Text = "Modificar fila seleccionada"
        Me.modificar_BTN.UseVisualStyleBackColor = True
        '
        'eliminar_BTN
        '
        Me.eliminar_BTN.Enabled = False
        Me.eliminar_BTN.Location = New System.Drawing.Point(13, 560)
        Me.eliminar_BTN.Name = "eliminar_BTN"
        Me.eliminar_BTN.Size = New System.Drawing.Size(443, 23)
        Me.eliminar_BTN.TabIndex = 35
        Me.eliminar_BTN.Text = "Eliminar fila seleccionada"
        Me.eliminar_BTN.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Seleccionar una celda de la tabla primero"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox4.Location = New System.Drawing.Point(78, 65)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(188, 19)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "¿Puede acceder a cosechas?"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox5.Location = New System.Drawing.Point(78, 90)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(213, 19)
        Me.CheckBox5.TabIndex = 5
        Me.CheckBox5.Text = "¿Puede acceder a materia prima?"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox6.Location = New System.Drawing.Point(78, 115)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(246, 19)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.Text = "¿Puede acceder a producto intermedio?"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox7.Location = New System.Drawing.Point(78, 150)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(246, 19)
        Me.CheckBox7.TabIndex = 38
        Me.CheckBox7.Text = "¿Puede acceder a producto intermedio?"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox8.Location = New System.Drawing.Point(78, 125)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(213, 19)
        Me.CheckBox8.TabIndex = 37
        Me.CheckBox8.Text = "¿Puede acceder a materia prima?"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox9.Location = New System.Drawing.Point(78, 100)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(188, 19)
        Me.CheckBox9.TabIndex = 36
        Me.CheckBox9.Text = "¿Puede acceder a cosechas?"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'Empresa_TiposDeAsesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buscador)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Menu1)
        Me.MaximizeBox = False
        Me.Name = "Empresa_TiposDeAsesores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa - Tipos de asesores profesionales / SI.GES.VI"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu1 As Proyecto.Menu
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents buscador As System.Windows.Forms.TextBox
    Friend WithEvents Tabla1 As Proyecto.Tabla
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ingresar_BTN As System.Windows.Forms.Button
    Friend WithEvents ingresar_nombreTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents administrar_nombreTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents modificar_BTN As System.Windows.Forms.Button
    Friend WithEvents eliminar_BTN As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
End Class
