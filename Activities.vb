Public Class Activities
    Public SQLCode As New SQLQueries
    Public sqlUpdate As New SQLUpdateQueries
    Public sqldelete As New SQLDeleteQueries
    Public sqladd As New SQLAddQueries
    Private TableFK(4) As String
    Private Sub Activties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnSearch.PerformClick()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        DGVChild.DataSource = SQLCode.Load(("SELECT Activity.activity_date_time, Child.c_fname, Child.c_sname, Activity.activity_type, Activity.items_needed, Staff.s_fname, Staff.s_sname FROM Activity, ActivityParticipents, Child, ChildProgression, Staff  WHERE (Activity.activity_type LIKE '" & TxtSearch.Text & "%' or Activity.items_needed LIKE '" & TxtSearch.Text & "%'or Activity.activity_date_time LIKE '" & TxtSearch.Text & "%' or Child.c_fname LIKE '" & TxtSearch.Text & "%' or Child.c_sname LIKE '" & TxtSearch.Text & "%') AND Child.child_ID = ChildProgression.child_ID_fk AND ChildProgression.child_progression_ID = ActivityParticipents.CProgression_ID_fk AND  Staff.staff_ID = ActivityParticipents.staff_ID_fk AND ActivityParticipents.Activity_ID_fk = Activity.activity_ID ORDER BY Activity.activity_date_time;"), "Activity, ActivityParticipents, child, ChildProgression")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        callTableFKActivity()
        MsgBox(sqlUpdate.update(("UPDATE Activity SET activity_type ='" & TxtActType.Text & "', items_needed = '" & TxtItemsNeeded.Text & "',  Activity_date_time = '" & CALActivityType.Value.ToString & "' WHERE activity.activity_ID = " & TableFK(1) & ";"), "Activity"))
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        MsgBox(sqladd.add(("INSERT INTO Activity(activity_type, items_needed, Activity_date_time) VALUES('" & TxtActType.Text & "','" & TxtItemsNeeded.Text & "' ,'" & CALActivityType.Value.ToString & "');"), "Activity"))
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        callTableActivityParticipent()
        MsgBox(sqldelete.Delete(("DELETE FROM activityparticipents WHERE ActivityParticipents.AParticitpents_ID = " & TableFK(4) & ";"), "activities"))
    End Sub

    Private Sub BtnUpdateParticipent_Click(sender As Object, e As EventArgs) Handles BtnUpdateParticipent.Click
        callTableActivityParticipent()
        callTableFK()
        MsgBox(sqlUpdate.update(("UPDATE ActivityParticipents SET Activity_ID_fk =" & TableFK(1) & ", CProgression_ID_fk = " & TableFK(2) & ", Staff_ID_fk = " & TableFK(3) & " WHERE ActivityParticipents.AParticitpents_ID = " & TableFK(4)), "Activity, ActivityParticipents, child, ChildProgression, Staff"))
    End Sub



    Private Sub BtnAddParticipent_Click(sender As Object, e As EventArgs) Handles BtnAddParticipent.Click
        callTableFK()
        MsgBox(sqladd.add(("INSERT INTO ActivityParticipents(Activity_ID_fk, CProgression_ID_fk, Staff_ID_fk) VALUES('" & TableFK(1) & "','" & TableFK(2) & "' ,'" & TableFK(3) & "');"), "ActivityParticipents"))
    End Sub
    Private Sub callTableFKActivity()
        TableFK(1) = SQLCode.ForeignKeyDelayer("Activity", "*", "")
    End Sub
    Private Sub callTableFK()
        TableFK(1) = SQLCode.ForeignKeyDelayer("Activity", "*", "")
        TableFK(2) = SQLCode.ForeignKeyDelayer("ChildProgression, Child", "childprogression.child_progression_ID, child.c_fname, child.c_Sname ", "WHERE childprogression.child_ID_fk = child.child_ID")
        TableFK(3) = SQLCode.ForeignKeyDelayer("Staff", "*", "")
    End Sub

    Private Sub callTableActivityParticipent()
        TableFK(4) = SQLCode.ForeignKeyDelayer("Activity, ActivityParticipents, child, childprogression, staff, parent, progressionNote", "DISTINCT ActivityParticipents.AParticitpents_ID, Child.c_fname, Child.c_sname, Activity.activity_type, Activity.items_needed, Staff.s_fname, Staff.s_sname ", "WHERE Child.child_ID = ChildProgression.child_ID_fk AND ChildProgression.child_progression_ID = ActivityParticipents.CProgression_ID_fk AND  Staff.staff_ID = ActivityParticipents.staff_ID_fk AND ActivityParticipents.Activity_ID_fk = Activity.activity_ID")
    End Sub
End Class