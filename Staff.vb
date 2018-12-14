Imports System.Data.SQLite
Public Class Staff
    Public SQLCode As New SQLQueries
    Public sqlUpdate As New SQLUpdateQueries
    Public sqldelete As New SQLDeleteQueries
    Public sqladd As New SQLAddQueries
    Public PersonADD As New Person
    Dim conectionstring As String = "Data Source=oakchildren.db"
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnSearch.PerformClick()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        DGVStaff.DataSource = SQLCode.Load(("SELECT * FROM Staff WHERE Staff.s_fname LIKE '" & TxtSearch.Text & "%' or Staff.s_sname LIKE '" & TxtSearch.Text & "%';"), "staff")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MsgBox(sqlUpdate.update(("UPDATE staff SET s_fname ='" & TxtFname.Text & "', s_sname = '" & TxtSname.Text & "' WHERE Staff.s_fname LIKE '" & TxtSearch.Text & "%' or Staff.s_sname LIKE '" & TxtSearch.Text & "%';"), "staff"))
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim staffdetails As Person.PersonDetails
        staffdetails.one = TxtFname.Text
        staffdetails.two = TxtSname.Text
        staffdetails.table = "staff"
        staffdetails.columns = "s_fname, s_sname"
        staffdetails.three = Nothing
        MsgBox(PersonADD.AddPerson(staffdetails))
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        MsgBox(sqldelete.Delete(("DELETE FROM staff WHERE staff.s_fname LIKE '" & TxtSearch.Text & "%' OR Staff.s_sname LIKE '" & TxtSearch.Text & "%'"), "staff"))

    End Sub
End Class