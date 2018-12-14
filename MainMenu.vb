Public Class MainMenu
    Dim admin As Boolean = False
    Private Sub BtnActivities_Click(sender As Object, e As EventArgs) Handles BtnActivities.Click
        Activities.Show()
    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaff.Click
        Staff.Show()
    End Sub

    Private Sub BtnChildParticipation_Click(sender As Object, e As EventArgs) Handles BtnChildParticipation.Click
        ChildParent.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnStaff.Enabled = admin
    End Sub

    Private Sub BtnChildProgression_Click(sender As Object, e As EventArgs) Handles BtnChildProgression.Click
        ChildProgression.Show()
    End Sub
End Class