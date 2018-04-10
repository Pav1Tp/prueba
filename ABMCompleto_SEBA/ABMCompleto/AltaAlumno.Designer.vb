<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaAlumno
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumDocumento = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNroCalle = New System.Windows.Forms.TextBox()
        Me.chkActividad = New System.Windows.Forms.CheckBox()
        Me.chkCasado = New System.Windows.Forms.CheckBox()
        Me.chkHijos = New System.Windows.Forms.CheckBox()
        Me.txtCantHijos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(54, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos Alumno"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(112, 114)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtApellido.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo documento:"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(112, 150)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoDocumento.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "N° Documento:"
        '
        'txtNumDocumento
        '
        Me.txtNumDocumento.Location = New System.Drawing.Point(112, 188)
        Me.txtNumDocumento.Name = "txtNumDocumento"
        Me.txtNumDocumento.Size = New System.Drawing.Size(170, 20)
        Me.txtNumDocumento.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbFemenino)
        Me.Panel1.Controls.Add(Me.rdbMasculino)
        Me.Panel1.Location = New System.Drawing.Point(112, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 46)
        Me.Panel1.TabIndex = 9
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(100, 13)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rdbFemenino.TabIndex = 1
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(17, 13)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdbMasculino.TabIndex = 0
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sexo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Calle:"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(112, 266)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(170, 20)
        Me.txtCalle.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "N° Calle:"
        '
        'txtNroCalle
        '
        Me.txtNroCalle.Location = New System.Drawing.Point(112, 301)
        Me.txtNroCalle.Name = "txtNroCalle"
        Me.txtNroCalle.Size = New System.Drawing.Size(170, 20)
        Me.txtNroCalle.TabIndex = 13
        '
        'chkActividad
        '
        Me.chkActividad.AutoSize = True
        Me.chkActividad.Location = New System.Drawing.Point(112, 343)
        Me.chkActividad.Name = "chkActividad"
        Me.chkActividad.Size = New System.Drawing.Size(70, 17)
        Me.chkActividad.TabIndex = 15
        Me.chkActividad.Text = "Actividad"
        Me.chkActividad.UseVisualStyleBackColor = True
        '
        'chkCasado
        '
        Me.chkCasado.AutoSize = True
        Me.chkCasado.Location = New System.Drawing.Point(112, 366)
        Me.chkCasado.Name = "chkCasado"
        Me.chkCasado.Size = New System.Drawing.Size(62, 17)
        Me.chkCasado.TabIndex = 16
        Me.chkCasado.Text = "Casado"
        Me.chkCasado.UseVisualStyleBackColor = True
        '
        'chkHijos
        '
        Me.chkHijos.AutoSize = True
        Me.chkHijos.Location = New System.Drawing.Point(112, 389)
        Me.chkHijos.Name = "chkHijos"
        Me.chkHijos.Size = New System.Drawing.Size(49, 17)
        Me.chkHijos.TabIndex = 17
        Me.chkHijos.Text = "Hijos"
        Me.chkHijos.UseVisualStyleBackColor = True
        '
        'txtCantHijos
        '
        Me.txtCantHijos.Enabled = False
        Me.txtCantHijos.Location = New System.Drawing.Point(232, 387)
        Me.txtCantHijos.Name = "txtCantHijos"
        Me.txtCantHijos.Size = New System.Drawing.Size(53, 20)
        Me.txtCantHijos.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Cant. hijos:"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(112, 432)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarrera.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 435)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Carrera:"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(208, 482)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 22
        Me.btnAlta.Text = "Agregar"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(112, 482)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 23
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'AltaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 517)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.cmbCarrera)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCantHijos)
        Me.Controls.Add(Me.chkHijos)
        Me.Controls.Add(Me.chkCasado)
        Me.Controls.Add(Me.chkActividad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNroCalle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumDocumento)
        Me.Controls.Add(Me.cmbTipoDocumento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de alumnos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumDocumento As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNroCalle As TextBox
    Friend WithEvents chkActividad As CheckBox
    Friend WithEvents chkCasado As CheckBox
    Friend WithEvents chkHijos As CheckBox
    Friend WithEvents txtCantHijos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCarrera As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnLimpiar As Button
End Class
