Public Class Login
    Private Sub tb_blank_if_GotFocus(sender As Object, e As EventArgs) Handles tb_usuario.GotFocus, tb_password.GotFocus
        If sender.Text = "Nombre de usuario" Or sender.Text = "Contraseña" Then
            sender.Text = ""
            If sender.name = "tb_password" Then
                sender.passwordchar = "*"
            End If
        End If
    End Sub
    Private Sub tb_fill_if_LostFocus(sender As Object, e As EventArgs) Handles tb_usuario.LostFocus, tb_password.LostFocus
        If sender.Text = "" Then
            If sender.name = "tb_usuario" Then
                sender.Text = "Nombre de usuario"
            End If
            If sender.name = "tb_password" Then
                sender.passwordchar = ""
                sender.Text = "Contraseña"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (tb_usuario.Text <> "" Or tb_password.Text <> "") And (tb_usuario.Text <> "Nombre de usuario" Or tb_password.Text <> "Contraseña") Then
            Me.Hide()
            Dim _home As New Home(Me)
            _home.Show(Me)
        Else
            MsgBox("Ingrese nombre de usuario y contraseña")
        End If
    End Sub





    
End Class
