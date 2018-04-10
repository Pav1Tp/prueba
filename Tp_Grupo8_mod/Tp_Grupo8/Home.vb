Public Class Home
    Dim _ventLogin As Form
    Private Sub GestionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem.Click
        Dim _abm_Centros As New abm_Centros
        _abm_Centros.Show()
    End Sub

    Private Sub GestionarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem1.Click
        Dim _abm_Profesionales As New abm_Profesionales
        _abm_Profesionales.Show()
    End Sub

    Private Sub GestionarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem3.Click
        Dim _abm_Afiliados As New abm_Afiliados
        _abm_Afiliados.Show()
    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _ventLogin.Show()
    End Sub

    Public Sub New(ByVal _ventanaLogin As Form)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _ventLogin = _ventanaLogin
    End Sub

End Class