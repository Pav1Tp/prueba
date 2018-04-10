<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_Afiliados
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.idAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTipoAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInscr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoInscr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idAfiliado, Me.apellido, Me.nombre, Me.fechaNac, Me.idTipoAfiliado, Me.fechaInscr, Me.montoInscr})
        Me.DataGridView1.Location = New System.Drawing.Point(226, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 426)
        Me.DataGridView1.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Agregar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 132)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del afiliado"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(159, 31)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo Afiliado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "fechaNacim:"
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
        Me.Label2.Text = "Nombre:"
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
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 129)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la inscripcion"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 87)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Monto:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(91, 61)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 10
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "fecha:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(91, 92)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 11
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'idAfiliado
        '
        Me.idAfiliado.HeaderText = "idAfiliado"
        Me.idAfiliado.Name = "idAfiliado"
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
        'fechaNac
        '
        Me.fechaNac.HeaderText = "fechaNac"
        Me.fechaNac.Name = "fechaNac"
        '
        'idTipoAfiliado
        '
        Me.idTipoAfiliado.HeaderText = "idTipoAfiliado"
        Me.idTipoAfiliado.Name = "idTipoAfiliado"
        '
        'fechaInscr
        '
        Me.fechaInscr.HeaderText = "fechaInscr"
        Me.fechaInscr.Name = "fechaInscr"
        '
        'montoInscr
        '
        Me.montoInscr.HeaderText = "montoInscr"
        Me.montoInscr.Name = "montoInscr"
        '
        'abm_Afiliados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "abm_Afiliados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abm_Afiliados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents idAfiliado As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents fechaNac As DataGridViewTextBoxColumn
    Friend WithEvents idTipoAfiliado As DataGridViewTextBoxColumn
    Friend WithEvents fechaInscr As DataGridViewTextBoxColumn
    Friend WithEvents montoInscr As DataGridViewTextBoxColumn
End Class
