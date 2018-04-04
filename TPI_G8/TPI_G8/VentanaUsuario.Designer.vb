<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaUsuario
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
        Me.ProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfiliadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarrioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoAfiliadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentrosToolStripMenuItem, Me.ProfesionalesToolStripMenuItem, Me.AfiliadosToolStripMenuItem, Me.MasToolStripMenuItem, Me.EspecialidadesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CentrosToolStripMenuItem
        '
        Me.CentrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem})
        Me.CentrosToolStripMenuItem.Name = "CentrosToolStripMenuItem"
        Me.CentrosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CentrosToolStripMenuItem.Text = "Centros"
        '
        'ProfesionalesToolStripMenuItem
        '
        Me.ProfesionalesToolStripMenuItem.Name = "ProfesionalesToolStripMenuItem"
        Me.ProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ProfesionalesToolStripMenuItem.Text = "Profesionales"
        '
        'AfiliadosToolStripMenuItem
        '
        Me.AfiliadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoAfiliadoToolStripMenuItem})
        Me.AfiliadosToolStripMenuItem.Name = "AfiliadosToolStripMenuItem"
        Me.AfiliadosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AfiliadosToolStripMenuItem.Text = "Afiliados"
        '
        'MasToolStripMenuItem
        '
        Me.MasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarrioToolStripMenuItem, Me.LocalidadesToolStripMenuItem})
        Me.MasToolStripMenuItem.Name = "MasToolStripMenuItem"
        Me.MasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.MasToolStripMenuItem.Text = "Ubicaciones"
        '
        'BarrioToolStripMenuItem
        '
        Me.BarrioToolStripMenuItem.Name = "BarrioToolStripMenuItem"
        Me.BarrioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BarrioToolStripMenuItem.Text = "Barrios"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'EspecialidadesToolStripMenuItem
        '
        Me.EspecialidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem1})
        Me.EspecialidadesToolStripMenuItem.Name = "EspecialidadesToolStripMenuItem"
        Me.EspecialidadesToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.EspecialidadesToolStripMenuItem.Text = "Especialidades"
        '
        'TipoAfiliadoToolStripMenuItem
        '
        Me.TipoAfiliadoToolStripMenuItem.Name = "TipoAfiliadoToolStripMenuItem"
        Me.TipoAfiliadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoAfiliadoToolStripMenuItem.Text = "Tipo Afiliado"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificaionToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ModificaionToolStripMenuItem
        '
        Me.ModificaionToolStripMenuItem.Name = "ModificaionToolStripMenuItem"
        Me.ModificaionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificaionToolStripMenuItem.Text = "Modificaion"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'GestionarToolStripMenuItem1
        '
        Me.GestionarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.BajaToolStripMenuItem1, Me.ModificacionToolStripMenuItem, Me.ConsultaToolStripMenuItem1})
        Me.GestionarToolStripMenuItem1.Name = "GestionarToolStripMenuItem1"
        Me.GestionarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GestionarToolStripMenuItem1.Text = "Gestionar"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'BajaToolStripMenuItem1
        '
        Me.BajaToolStripMenuItem1.Name = "BajaToolStripMenuItem1"
        Me.BajaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BajaToolStripMenuItem1.Text = "Baja"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificacionToolStripMenuItem.Text = "Modificacion"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'VentanaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaUsuario"
        Me.Text = "VentanaUsuario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CentrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfiliadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarrioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoAfiliadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecialidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As ToolStripMenuItem
End Class
