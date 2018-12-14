Imports System.Threading
Public Class Splash_Screen
    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.Sleep(1000)
        Me.Hide()
        Login_Screen.Show()

    End Sub
End Class
