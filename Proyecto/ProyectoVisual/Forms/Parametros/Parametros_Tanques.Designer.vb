<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametros_Tanques
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxSucursales1 = New Proyecto.ComboBoxSucursales()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buscador = New System.Windows.Forms.TextBox()
        Me.Tabla1 = New Proyecto.Tabla()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ingresar_BTN = New System.Windows.Forms.Button()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.modificar_BTN = New System.Windows.Forms.Button()
        Me.eliminar_BTN = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Sucursales"
        '
        'ComboBoxSucursales1
        '
        Me.ComboBoxSucursales1.Location = New System.Drawing.Point(77, 43)
        Me.ComboBoxSucursales1.Name = "ComboBoxSucursales1"
        Me.ComboBoxSucursales1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxSucursales1.TabIndex = 53
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(713, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(154, 17)
        Me.CheckBox1.TabIndex = 52
        Me.CheckBox1.Text = "Mostrar tanques eliminados"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Columna: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(563, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Buscar en la tabla: "
        '
        'buscador
        '
        Me.buscador.Location = New System.Drawing.Point(353, 44)
        Me.buscador.Name = "buscador"
        Me.buscador.Size = New System.Drawing.Size(144, 20)
        Me.buscador.TabIndex = 48
        '
        'Tabla1
        '
        Me.Tabla1.Location = New System.Drawing.Point(12, 70)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(761, 599)
        Me.Tabla1.TabIndex = 47
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(779, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(477, 600)
        Me.TabControl1.TabIndex = 46
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ingresar_BTN)
        Me.TabPage1.Controls.Add(Me.TextBox0)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage1.Size = New System.Drawing.Size(469, 572)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ingresar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(320, 21)
        Me.TextBox2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Material"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Capacidad"
        '
        'ingresar_BTN
        '
        Me.ingresar_BTN.Enabled = False
        Me.ingresar_BTN.Location = New System.Drawing.Point(13, 536)
        Me.ingresar_BTN.Name = "ingresar_BTN"
        Me.ingresar_BTN.Size = New System.Drawing.Size(443, 23)
        Me.ingresar_BTN.TabIndex = 4
        Me.ingresar_BTN.Text = "Ingresar"
        Me.ingresar_BTN.UseVisualStyleBackColor = True
        '
        'TextBox0
        '
        Me.TextBox0.Location = New System.Drawing.Point(136, 13)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(320, 21)
        Me.TextBox0.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de tanque"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.modificar_BTN)
        Me.TabPage2.Controls.Add(Me.eliminar_BTN)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage2.Size = New System.Drawing.Size(469, 572)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Administrar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(136, 93)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(320, 21)
        Me.TextBox5.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Material"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(136, 66)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(320, 21)
        Me.TextBox6.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Capacidad"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(136, 39)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(320, 21)
        Me.TextBox7.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 15)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Número de tanque"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(136, 120)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(99, 19)
        Me.CheckBox2.TabIndex = 39
        Me.CheckBox2.Text = "¿Disponible?"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'modificar_BTN
        '
        Me.modificar_BTN.Enabled = False
        Me.modificar_BTN.Location = New System.Drawing.Point(13, 507)
        Me.modificar_BTN.Name = "modificar_BTN"
        Me.modificar_BTN.Size = New System.Drawing.Size(443, 23)
        Me.modificar_BTN.TabIndex = 40
        Me.modificar_BTN.Text = "Modificar fila seleccionada"
        Me.modificar_BTN.UseVisualStyleBackColor = True
        '
        'eliminar_BTN
        '
        Me.eliminar_BTN.Enabled = False
        Me.eliminar_BTN.Location = New System.Drawing.Point(13, 536)
        Me.eliminar_BTN.Name = "eliminar_BTN"
        Me.eliminar_BTN.Size = New System.Drawing.Size(443, 23)
        Me.eliminar_BTN.TabIndex = 41
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
        'Parametros_Tanques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxSucursales1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buscador)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Menu1)
        Me.MaximizeBox = False
        Me.Name = "Parametros_Tanques"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros - Tanques / SI.GES.VI"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu1 As Proyecto.Menu
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSucursales1 As Proyecto.ComboBoxSucursales
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents buscador As System.Windows.Forms.TextBox
    Friend WithEvents Tabla1 As Proyecto.Tabla
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ingresar_BTN As System.Windows.Forms.Button
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents modificar_BTN As System.Windows.Forms.Button
    Friend WithEvents eliminar_BTN As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
