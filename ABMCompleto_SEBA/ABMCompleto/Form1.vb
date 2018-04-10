Public Class Form1
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim _VentanaAlta As New AltaAlumno
        _VentanaAlta.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim _VentanaConsulta As New Consulta
        _VentanaConsulta.Show()
    End Sub
End Class
