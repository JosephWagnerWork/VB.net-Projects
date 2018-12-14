Public Class Login_Screen
    Private Sub Login_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUserName.Text = "timmy" Then
            If TxtPassword.Text = "timmy" Then
                MainMenu.Show()
                Me.Close()
            Else
                MsgBox("Incorrect password or username")
            End If
        Else
            MsgBox("Incorrect password or username")
        End If

    End Sub
End Class