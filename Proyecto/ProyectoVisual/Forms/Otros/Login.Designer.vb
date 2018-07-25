<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.userTB = New System.Windows.Forms.TextBox()
        Me.passTB = New System.Windows.Forms.TextBox()
        Me.iniciarsesion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userlabel = New System.Windows.Forms.Label()
        Me.passlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'userTB
        '
        Me.userTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTB.Location = New System.Drawing.Point(110, 245)
        Me.userTB.Name = "userTB"
        Me.userTB.Size = New System.Drawing.Size(192, 26)
        Me.userTB.TabIndex = 2
        '
        'passTB
        '
        Me.passTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTB.Location = New System.Drawing.Point(110, 277)
        Me.passTB.Name = "passTB"
        Me.passTB.Size = New System.Drawing.Size(192, 26)
        Me.passTB.TabIndex = 3
        Me.passTB.UseSystemPasswordChar = True
        '
        'iniciarsesion
        '
        Me.iniciarsesion.Enabled = False
        Me.iniciarsesion.Location = New System.Drawing.Point(12, 314)
        Me.iniciarsesion.Name = "iniciarsesion"
        Me.iniciarsesion.Size = New System.Drawing.Size(290, 26)
        Me.iniciarsesion.TabIndex = 4
        Me.iniciarsesion.Text = "Iniciar sesión"
        Me.iniciarsesion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 233)
        Me.Label1.TabIndex = 1
        '
        'userlabel
        '
        Me.userlabel.AutoSize = True
        Me.userlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlabel.Location = New System.Drawing.Point(36, 245)
        Me.userlabel.Name = "userlabel"
        Me.userlabel.Size = New System.Drawing.Size(68, 20)
        Me.userlabel.TabIndex = 5
        Me.userlabel.Text = "Usuario:"
        '
        'passlabel
        '
        Me.passlabel.AutoSize = True
        Me.passlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passlabel.Location = New System.Drawing.Point(8, 277)
        Me.passlabel.Name = "passlabel"
        Me.passlabel.Size = New System.Drawing.Size(96, 20)
        Me.passlabel.TabIndex = 6
        Me.passlabel.Text = "Contraseña:"
        '
        'Login
        '
        Me.AcceptButton = Me.iniciarsesion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 352)
        Me.Controls.Add(Me.passlabel)
        Me.Controls.Add(Me.userlabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iniciarsesion)
        Me.Controls.Add(Me.passTB)
        Me.Controls.Add(Me.userTB)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión / SI.GES.VI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userTB As System.Windows.Forms.TextBox
    Friend WithEvents passTB As System.Windows.Forms.TextBox
    Friend WithEvents iniciarsesion As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents userlabel As System.Windows.Forms.Label
    Friend WithEvents passlabel As System.Windows.Forms.Label

End Class
