Public Class ChildProgression
    Private SQLCode As New SQLQueries
    Private sqlUpdate As New SQLUpdateQueries
    Private sqldelete As New SQLDeleteQueries
    Private sqladd As New SQLAddQueries
    Private TableFK(5) As String
    Private Sub ChildProgression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnSearch.PerformClick()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        DGVChild.DataSource = SQLCode.Load(("SELECT ProgressionNote.p_date, Child.c_fname, Child.c_sname, ProgressionNote.p_notes, Staff.s_fname, Staff.s_sname FROM Child, ChildProgression, ProgressionNote, Staff  WHERE (ProgressionNote.p_notes LIKE '" & TxtSearch.Text & "%' or Staff.s_fname LIKE '" & TxtSearch.Text & "%'or Staff.s_sname LIKE '" & TxtSearch.Text & "%' or Child.c_fname LIKE '" & TxtSearch.Text & "%' or Child.c_sname LIKE '" & TxtSearch.Text & "%') AND Child.child_ID = ChildProgression.child_ID_fk AND  Staff.staff_ID = ChildProgression.Staff_ID_fk AND ChildProgression.progression_note_ID_fk = ProgressionNote.progression_note_ID  ORDER BY ProgressionNote.p_date;"), "Staff, ProgressionNote, child, ChildProgression")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        callTableProgressionNote()
        MsgBox(sqlUpdate.update(("UPDATE ProgressionNote SET p_notes = '" & TxtP_Notes.Text & "', p_date = '" & CALP_Date.Value.ToString & "' WHERE Progression_Note_ID = " & TableFK(3) & ";"), "ProgressionNote"))
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        MsgBox(sqladd.add(("INSERT INTO ProgressionNote(p_notes, p_date) VALUES('" & TxtP_Notes.Text & "' ,'" & CALP_Date.Value.ToString & "');"), "ProgressionNote"))
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        callTableChildProgression()
        MsgBox(sqldelete.Delete(("DELETE FROM ChildProgression WHERE ChildProgression.Child_Progression_ID = " & TableFK(4) & ";"), "ChildProgression"))
    End Sub

    Private Sub BtnUpdateParticipent_Click(sender As Object, e As EventArgs) Handles BtnUpdateProgression.Click
        callTableChildProgression()
        callTableProgressionNote()
        callTableFK()
        MsgBox(sqlUpdate.update(("UPDATE ChildProgression SET child_ID_fk =" & TableFK(1) & ", progression_note_ID_fk = " & TableFK(3) & ", Staff_ID_fk = " & TableFK(2) & " WHERE ChildProgression.Child_Progression_ID = " & TableFK(4)), " child, ChildProgression, Staff"))
    End Sub

    Private Sub BtnAddProgression_Click(sender As Object, e As EventArgs) Handles BtnAddProgression.Click
        callTableProgressionNote()
        callTableFK()
        MsgBox(sqladd.add(("INSERT INTO ChildProgression(child_ID_fk, progression_note_ID_fk, Staff_ID_fk) VALUES('" & TableFK(1) & "','" & TableFK(3) & "' ,'" & TableFK(2) & "');"), "ChildProgression"))
    End Sub

    Private Sub callTableFK()
        TableFK(1) = SQLCode.ForeignKeyDelayer("Child", "*", "")
        TableFK(2) = SQLCode.ForeignKeyDelayer("Staff", "*", "")
    End Sub

    Private Sub callTableProgressionNote()
        TableFK(3) = SQLCode.ForeignKeyDelayer("ProgressionNote", "ProgressionNote.progression_note_ID, ProgressionNote.p_notes, ProgressionNote.p_date ", "")
    End Sub

    Private Sub callTableChildProgression()
        TableFK(4) = SQLCode.ForeignKeyDelayer("child, childprogression, staff, progressionNote", "DISTINCT ChildProgression.child_progression_ID, Child.c_fname, Child.c_sname, ProgressionNote.p_notes, ProgressionNote.p_date, Staff.s_fname, Staff.s_sname ", "WHERE Child.child_ID = ChildProgression.child_ID_fk AND ChildProgression.Progression_note_ID_fk = ProgressionNote.progression_note_ID AND Staff.staff_ID = ChildProgression.Staff_ID_fk")
    End Sub
End Class