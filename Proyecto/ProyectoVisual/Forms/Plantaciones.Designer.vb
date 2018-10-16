<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plantaciones
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tabla3 = New Proyecto.Tabla()
        Me.Tabla2 = New Proyecto.Tabla()
        Me.Tabla1 = New Proyecto.Tabla()
        Me.ComboBoxSucursales1 = New Proyecto.ComboBoxSucursales()
        Me.Menu1 = New Proyecto.Menu()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hectárea"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(295, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Tabla3)
        Me.GroupBox2.Location = New System.Drawing.Point(864, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 619)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cosechas"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 520)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(376, 23)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Establecer fecha de cosechado para la fila seleccionada"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(7, 494)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(375, 20)
        Me.DateTimePicker4.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 590)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(376, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Eliminar cosecha seleccionada"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 441)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(379, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Ingresar cosecha en la plantación seleccionada"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fecha de plantado"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(104, 415)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(222, 20)
        Me.DateTimePicker2.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 415)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(222, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fecha de plantado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Tabla2)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 619)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plantaciones"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 520)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(379, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Establecer fecha de desplantado para la fila seleccionada"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(7, 494)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(378, 20)
        Me.DateTimePicker3.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 590)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(379, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Eliminar plantación seleccionada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(379, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ingresar plantación en la parcela seleccionada"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabla3
        '
        Me.Tabla3.Location = New System.Drawing.Point(6, 19)
        Me.Tabla3.Name = "Tabla3"
        Me.Tabla3.Size = New System.Drawing.Size(376, 392)
        Me.Tabla3.TabIndex = 9
        '
        'Tabla2
        '
        Me.Tabla2.Location = New System.Drawing.Point(6, 19)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.Size = New System.Drawing.Size(379, 392)
        Me.Tabla2.TabIndex = 8
        '
        'Tabla1
        '
        Me.Tabla1.Location = New System.Drawing.Point(12, 77)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(449, 592)
        Me.Tabla1.TabIndex = 7
        '
        'ComboBoxSucursales1
        '
        Me.ComboBoxSucursales1.Location = New System.Drawing.Point(66, 50)
        Me.ComboBoxSucursales1.Name = "ComboBoxSucursales1"
        Me.ComboBoxSucursales1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxSucursales1.TabIndex = 1
        '
        'Menu1
        '
        Me.Menu1.Location = New System.Drawing.Point(12, 12)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(1240, 32)
        Me.Menu1.TabIndex = 0
        '
        'Plantaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxSucursales1)
        Me.Controls.Add(Me.Menu1)
        Me.MaximizeBox = False
        Me.Name = "Plantaciones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu1 As Proyecto.Menu
    Friend WithEvents ComboBoxSucursales1 As Proyecto.ComboBoxSucursales
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tabla1 As Proyecto.Tabla
    Friend WithEvents Tabla3 As Proyecto.Tabla
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tabla2 As Proyecto.Tabla
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
End Class
