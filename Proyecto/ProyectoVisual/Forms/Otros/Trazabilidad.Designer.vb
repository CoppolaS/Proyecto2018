<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trazabilidad
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
        Me.Tabla1 = New Proyecto.Tabla()
        Me.Tabla2 = New Proyecto.Tabla()
        Me.Tabla3 = New Proyecto.Tabla()
        Me.Tabla4 = New Proyecto.Tabla()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.Location = New System.Drawing.Point(12, 12)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(1240, 32)
        Me.Menu1.TabIndex = 0
        '
        'Tabla1
        '
        Me.Tabla1.Location = New System.Drawing.Point(12, 90)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(1112, 126)
        Me.Tabla1.TabIndex = 1
        '
        'Tabla2
        '
        Me.Tabla2.Location = New System.Drawing.Point(54, 238)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.Size = New System.Drawing.Size(1112, 126)
        Me.Tabla2.TabIndex = 25
        '
        'Tabla3
        '
        Me.Tabla3.Location = New System.Drawing.Point(96, 386)
        Me.Tabla3.Name = "Tabla3"
        Me.Tabla3.Size = New System.Drawing.Size(1112, 126)
        Me.Tabla3.TabIndex = 26
        '
        'Tabla4
        '
        Me.Tabla4.Location = New System.Drawing.Point(139, 534)
        Me.Tabla4.Name = "Tabla4"
        Me.Tabla4.Size = New System.Drawing.Size(1112, 127)
        Me.Tabla4.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Producto final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Producto intermedio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Materia prima"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 518)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Parcela / Plantacion / Cosecha"
        '
        'Trazabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tabla4)
        Me.Controls.Add(Me.Tabla3)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.Menu1)
        Me.MaximizeBox = False
        Me.Name = "Trazabilidad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trazabilidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu1 As Proyecto.Menu
    Friend WithEvents Tabla1 As Proyecto.Tabla
    Friend WithEvents Tabla2 As Proyecto.Tabla
    Friend WithEvents Tabla3 As Proyecto.Tabla
    Friend WithEvents Tabla4 As Proyecto.Tabla
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
