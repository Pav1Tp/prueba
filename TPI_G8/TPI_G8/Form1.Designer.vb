<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_nroAfiliado = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.txt_nroAfiliado = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Obra Social OSCOR"
        '
        'lbl_nroAfiliado
        '
        Me.lbl_nroAfiliado.AutoSize = True
        Me.lbl_nroAfiliado.Location = New System.Drawing.Point(83, 145)
        Me.lbl_nroAfiliado.Name = "lbl_nroAfiliado"
        Me.lbl_nroAfiliado.Size = New System.Drawing.Size(81, 13)
        Me.lbl_nroAfiliado.TabIndex = 1
        Me.lbl_nroAfiliado.Text = "Nro de Usuario:"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(100, 192)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(64, 13)
        Me.lbl_contraseña.TabIndex = 2
        Me.lbl_contraseña.Text = "Contraseña:"
        '
        'txt_nroAfiliado
        '
        Me.txt_nroAfiliado.Location = New System.Drawing.Point(188, 145)
        Me.txt_nroAfiliado.Name = "txt_nroAfiliado"
        Me.txt_nroAfiliado.Size = New System.Drawing.Size(154, 20)
        Me.txt_nroAfiliado.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(188, 192)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(154, 20)
        Me.txt_password.TabIndex = 4
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(267, 241)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 5
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(153, 241)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 6
        Me.btn_registrar.Text = "Registrarse"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 342)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_nroAfiliado)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.lbl_nroAfiliado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nroAfiliado As Label
    Friend WithEvents lbl_contraseña As Label
    Friend WithEvents txt_nroAfiliado As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents btn_registrar As Button
End Class
