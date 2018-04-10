<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidadHijos = New System.Windows.Forms.TextBox()
        Me.chkHijos = New System.Windows.Forms.CheckBox()
        Me.chkCasado = New System.Windows.Forms.CheckBox()
        Me.chkActividad = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNroCalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumDocumento = New System.Windows.Forms.TextBox()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gdrAlumnos = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Casado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hijos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadHijos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gdrAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(198, 473)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 46
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(102, 423)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarrera.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Carrera:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cant. hijos:"
        '
        'txtCantidadHijos
        '
        Me.txtCantidadHijos.Enabled = False
        Me.txtCantidadHijos.Location = New System.Drawing.Point(222, 378)
        Me.txtCantidadHijos.Name = "txtCantidadHijos"
        Me.txtCantidadHijos.Size = New System.Drawing.Size(53, 20)
        Me.txtCantidadHijos.TabIndex = 42
        '
        'chkHijos
        '
        Me.chkHijos.AutoSize = True
        Me.chkHijos.Location = New System.Drawing.Point(102, 380)
        Me.chkHijos.Name = "chkHijos"
        Me.chkHijos.Size = New System.Drawing.Size(49, 17)
        Me.chkHijos.TabIndex = 41
        Me.chkHijos.Text = "Hijos"
        Me.chkHijos.UseVisualStyleBackColor = True
        '
        'chkCasado
        '
        Me.chkCasado.AutoSize = True
        Me.chkCasado.Location = New System.Drawing.Point(102, 357)
        Me.chkCasado.Name = "chkCasado"
        Me.chkCasado.Size = New System.Drawing.Size(62, 17)
        Me.chkCasado.TabIndex = 40
        Me.chkCasado.Text = "Casado"
        Me.chkCasado.UseVisualStyleBackColor = True
        '
        'chkActividad
        '
        Me.chkActividad.AutoSize = True
        Me.chkActividad.Location = New System.Drawing.Point(102, 334)
        Me.chkActividad.Name = "chkActividad"
        Me.chkActividad.Size = New System.Drawing.Size(70, 17)
        Me.chkActividad.TabIndex = 39
        Me.chkActividad.Text = "Actividad"
        Me.chkActividad.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "N° Calle:"
        '
        'txtNroCalle
        '
        Me.txtNroCalle.Location = New System.Drawing.Point(102, 292)
        Me.txtNroCalle.Name = "txtNroCalle"
        Me.txtNroCalle.Size = New System.Drawing.Size(170, 20)
        Me.txtNroCalle.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Calle:"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(102, 257)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(170, 20)
        Me.txtCalle.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Sexo:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbFemenino)
        Me.Panel1.Controls.Add(Me.rdbMasculino)
        Me.Panel1.Location = New System.Drawing.Point(102, 205)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 46)
        Me.Panel1.TabIndex = 33
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "N° Documento:"
        '
        'txtNumDocumento
        '
        Me.txtNumDocumento.Location = New System.Drawing.Point(102, 179)
        Me.txtNumDocumento.Name = "txtNumDocumento"
        Me.txtNumDocumento.Size = New System.Drawing.Size(170, 20)
        Me.txtNumDocumento.TabIndex = 31
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(102, 141)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoDocumento.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tipo documento:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(102, 105)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtApellido.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(102, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(173, -29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Datos Alumno"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(11, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 25)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Datos del Alumnos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gdrAlumnos)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 443)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de alumnos"
        '
        'gdrAlumnos
        '
        Me.gdrAlumnos.AllowUserToAddRows = False
        Me.gdrAlumnos.AllowUserToDeleteRows = False
        Me.gdrAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdrAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.ID_Documento, Me.NroDocumento, Me.Sexo, Me.Calle, Me.NroCalle, Me.Actividad, Me.Casado, Me.Hijos, Me.CantidadHijos, Me.IdCarrera})
        Me.gdrAlumnos.Location = New System.Drawing.Point(6, 19)
        Me.gdrAlumnos.Name = "gdrAlumnos"
        Me.gdrAlumnos.Size = New System.Drawing.Size(546, 418)
        Me.gdrAlumnos.TabIndex = 0
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombres"
        Me.Nombre.HeaderText = "Nombres"
        Me.Nombre.Name = "Nombre"
        '
        'ID_Documento
        '
        Me.ID_Documento.DataPropertyName = "id_tipo_documento"
        Me.ID_Documento.HeaderText = "Tipo Documento"
        Me.ID_Documento.Name = "ID_Documento"
        '
        'NroDocumento
        '
        Me.NroDocumento.DataPropertyName = "nro_documento"
        Me.NroDocumento.HeaderText = "Nro. Documento"
        Me.NroDocumento.Name = "NroDocumento"
        '
        'Sexo
        '
        Me.Sexo.DataPropertyName = "sexo"
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        '
        'Calle
        '
        Me.Calle.DataPropertyName = "calle"
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        '
        'NroCalle
        '
        Me.NroCalle.DataPropertyName = "nro_calle"
        Me.NroCalle.HeaderText = "Nro. Calle"
        Me.NroCalle.Name = "NroCalle"
        '
        'Actividad
        '
        Me.Actividad.DataPropertyName = "actividad"
        Me.Actividad.HeaderText = "Actividad"
        Me.Actividad.Name = "Actividad"
        '
        'Casado
        '
        Me.Casado.DataPropertyName = "casado"
        Me.Casado.HeaderText = "Casado"
        Me.Casado.Name = "Casado"
        '
        'Hijos
        '
        Me.Hijos.DataPropertyName = "hijos"
        Me.Hijos.HeaderText = "Hijos"
        Me.Hijos.Name = "Hijos"
        '
        'CantidadHijos
        '
        Me.CantidadHijos.DataPropertyName = "cantidad_hijos"
        Me.CantidadHijos.HeaderText = "Cantidad Hijos"
        Me.CantidadHijos.Name = "CantidadHijos"
        '
        'IdCarrera
        '
        Me.IdCarrera.DataPropertyName = "id_carrera"
        Me.IdCarrera.HeaderText = "IdCarrera"
        Me.IdCarrera.Name = "IdCarrera"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 504)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.cmbCarrera)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCantidadHijos)
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
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gdrAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents cmbCarrera As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCantidadHijos As TextBox
    Friend WithEvents chkHijos As CheckBox
    Friend WithEvents chkCasado As CheckBox
    Friend WithEvents chkActividad As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNroCalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumDocumento As TextBox
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gdrAlumnos As DataGridView
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ID_Documento As DataGridViewTextBoxColumn
    Friend WithEvents NroDocumento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents NroCalle As DataGridViewTextBoxColumn
    Friend WithEvents Actividad As DataGridViewTextBoxColumn
    Friend WithEvents Casado As DataGridViewTextBoxColumn
    Friend WithEvents Hijos As DataGridViewTextBoxColumn
    Friend WithEvents CantidadHijos As DataGridViewTextBoxColumn
    Friend WithEvents IdCarrera As DataGridViewTextBoxColumn
End Class
