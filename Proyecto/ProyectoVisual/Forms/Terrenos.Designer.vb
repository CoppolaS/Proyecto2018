<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terrenos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSucursales1 = New Proyecto.ComboBoxSucursales()
        Me.Tabla2 = New Proyecto.Tabla()
        Me.Tabla1 = New Proyecto.Tabla()
        Me.Menu1 = New Proyecto.Menu()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(685, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 72)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parcelas"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(192, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(61, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(384, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Eliminar parcela seleccionada"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(298, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Ingresar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "M²"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "M² restantes de la hectárea seleccionada: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxSucursales1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 72)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hectáreas"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(287, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(495, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Eliminar hectárea seleccionada"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(421, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sucursal"
        '
        'ComboBoxSucursales1
        '
        Me.ComboBoxSucursales1.Location = New System.Drawing.Point(60, 41)
        Me.ComboBoxSucursales1.Name = "ComboBoxSucursales1"
        Me.ComboBoxSucursales1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxSucursales1.TabIndex = 8
        '
        'Tabla2
        '
        Me.Tabla2.Location = New System.Drawing.Point(685, 129)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.Size = New System.Drawing.Size(567, 540)
        Me.Tabla2.TabIndex = 10
        '
        'Tabla1
        '
        Me.Tabla1.Location = New System.Drawing.Point(12, 129)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(667, 540)
        Me.Tabla1.TabIndex = 5
        '
        'Menu1
        '
        Me.Menu1.Location = New System.Drawing.Point(12, 12)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(1240, 32)
        Me.Menu1.TabIndex = 0
        '
        'Terrenos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.Menu1)
        Me.MaximizeBox = False
        Me.Name = "Terrenos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terrenos / SI.GES.VI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menu1 As Proyecto.Menu
    Friend WithEvents Tabla1 As Proyecto.Tabla
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tabla2 As Proyecto.Tabla
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSucursales1 As Proyecto.ComboBoxSucursales
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
