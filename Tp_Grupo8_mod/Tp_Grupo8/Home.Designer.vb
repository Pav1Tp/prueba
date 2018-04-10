<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CentrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfiliadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EspecialidadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeAfiliadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentrosToolStripMenuItem, Me.ProfesionalesToolStripMenuItem, Me.AfiliadosToolStripMenuItem, Me.MasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CentrosToolStripMenuItem
        '
        Me.CentrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem, Me.EspecialidadesToolStripMenuItem1})
        Me.CentrosToolStripMenuItem.Name = "CentrosToolStripMenuItem"
        Me.CentrosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CentrosToolStripMenuItem.Text = "Centros"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'ProfesionalesToolStripMenuItem
        '
        Me.ProfesionalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem1})
        Me.ProfesionalesToolStripMenuItem.Name = "ProfesionalesToolStripMenuItem"
        Me.ProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ProfesionalesToolStripMenuItem.Text = "Profesionales"
        '
        'GestionarToolStripMenuItem1
        '
        Me.GestionarToolStripMenuItem1.Name = "GestionarToolStripMenuItem1"
        Me.GestionarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.GestionarToolStripMenuItem1.Text = "Gestionar"
        '
        'AfiliadosToolStripMenuItem
        '
        Me.AfiliadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem3, Me.TipoDeAfiliadosToolStripMenuItem})
        Me.AfiliadosToolStripMenuItem.Name = "AfiliadosToolStripMenuItem"
        Me.AfiliadosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AfiliadosToolStripMenuItem.Text = "Afiliados"
        '
        'GestionarToolStripMenuItem3
        '
        Me.GestionarToolStripMenuItem3.Name = "GestionarToolStripMenuItem3"
        Me.GestionarToolStripMenuItem3.Size = New System.Drawing.Size(161, 22)
        Me.GestionarToolStripMenuItem3.Text = "Gestionar"
        '
        'MasToolStripMenuItem
        '
        Me.MasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbicacionesToolStripMenuItem, Me.EstadisticasToolStripMenuItem})
        Me.MasToolStripMenuItem.Name = "MasToolStripMenuItem"
        Me.MasToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.MasToolStripMenuItem.Text = "Mas"
        '
        'UbicacionesToolStripMenuItem
        '
        Me.UbicacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarriosToolStripMenuItem, Me.LocalidadesToolStripMenuItem})
        Me.UbicacionesToolStripMenuItem.Name = "UbicacionesToolStripMenuItem"
        Me.UbicacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UbicacionesToolStripMenuItem.Text = "Ubicaciones"
        '
        'BarriosToolStripMenuItem
        '
        Me.BarriosToolStripMenuItem.Name = "BarriosToolStripMenuItem"
        Me.BarriosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarriosToolStripMenuItem.Text = "Barrios"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Atencion Afiliado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Afiliado"
        '
        'EspecialidadesToolStripMenuItem1
        '
        Me.EspecialidadesToolStripMenuItem1.Name = "EspecialidadesToolStripMenuItem1"
        Me.EspecialidadesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EspecialidadesToolStripMenuItem1.Text = "Especialidades"
        '
        'TipoDeAfiliadosToolStripMenuItem
        '
        Me.TipoDeAfiliadosToolStripMenuItem.Name = "TipoDeAfiliadosToolStripMenuItem"
        Me.TipoDeAfiliadosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TipoDeAfiliadosToolStripMenuItem.Text = "Tipo de afiliados"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CentrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AfiliadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EspecialidadesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeAfiliadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
