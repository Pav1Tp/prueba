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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_usuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tb_password)
        Me.GroupBox1.Controls.Add(Me.tb_usuario)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 141)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(56, 62)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(100, 20)
        Me.tb_password.TabIndex = 2
        Me.tb_password.Tag = ""
        Me.tb_password.Text = "Contraseña"
        '
        'tb_usuario
        '
        Me.tb_usuario.Location = New System.Drawing.Point(56, 36)
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.Size = New System.Drawing.Size(100, 20)
        Me.tb_usuario.TabIndex = 1
        Me.tb_usuario.Tag = ""
        Me.tb_usuario.Text = "Nombre de usuario"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_usuario As TextBox
End Class
