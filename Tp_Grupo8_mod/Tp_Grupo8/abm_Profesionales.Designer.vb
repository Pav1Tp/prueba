<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_Profesionales
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idBarrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 288)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del profesional"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(159, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(159, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(91, 198)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mail:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefono:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(91, 145)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Localidad:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Barrio:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(91, 224)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Calle:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(91, 250)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Numero:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 306)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Agregar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matricula, Me.apellido, Me.nombre, Me.idBarrio, Me.idLocalidad, Me.telefono, Me.mail, Me.calle, Me.numero})
        Me.DataGridView1.Location = New System.Drawing.Point(226, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 426)
        Me.DataGridView1.TabIndex = 8
        '
        'matricula
        '
        Me.matricula.HeaderText = "matricula"
        Me.matricula.Name = "matricula"
        '
        'apellido
        '
        Me.apellido.HeaderText = "apellido"
        Me.apellido.Name = "apellido"
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'idBarrio
        '
        Me.idBarrio.HeaderText = "idBarrio"
        Me.idBarrio.Name = "idBarrio"
        '
        'idLocalidad
        '
        Me.idLocalidad.HeaderText = "idLocalidad"
        Me.idLocalidad.Name = "idLocalidad"
        '
        'telefono
        '
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        '
        'mail
        '
        Me.mail.HeaderText = "mail"
        Me.mail.Name = "mail"
        '
        'calle
        '
        Me.calle.HeaderText = "calle"
        Me.calle.Name = "calle"
        '
        'numero
        '
        Me.numero.HeaderText = "numero"
        Me.numero.Name = "numero"
        '
        'abm_Profesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "abm_Profesionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abm_Profesionales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents matricula As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents idBarrio As DataGridViewTextBoxColumn
    Friend WithEvents idLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents calle As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
End Class
