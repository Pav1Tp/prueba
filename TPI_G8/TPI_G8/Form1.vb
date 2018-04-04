Public Class Form1
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If True Then

        Else
            MsgBox("Nombre de Usuario o Contraseña incorrector")
            txt_nroAfiliado.Focus()
        End If
    End Sub
End Class
