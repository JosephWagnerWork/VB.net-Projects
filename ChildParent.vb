Imports System.Data.SQLite
Imports System.Threading
Public Class ChildParent
    Public SQLCode As New SQLQueries
    Public sqlUpdate As New SQLUpdateQueries
    Public sqldelete As New SQLDeleteQueries
    Public sqladd As New SQLAddQueries
    Public PersonADD As New Person
    Public childADD As New childClass
    Private conectionstring As String = "Data Source=oakchildren.db"
    Private ParChldTable(2) As String
    Private Sub Child_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'performing a search with no search perameters
        BtnSearch.PerformClick()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        DGVChild.DataSource = SQLCode.Load(("SELECT * FROM Child, Parent WHERE (Child.c_fname LIKE '" & TxtSearch.Text & "%' or Child.c_sname LIKE '" & TxtSearch.Text & "%'or Parent.P_sname LIKE '" & TxtSearch.Text & "%'or Parent.P_sname LIKE '" & TxtSearch.Text & "%') AND Child.parent_ID_fk = parent.parent_ID;"), "Child, Parent")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'calls through selection tables
        callChildID()
        callParentID()
        MsgBox(sqlUpdate.update(("UPDATE Child SET c_fname ='" & TxtFname.Text & "', c_sname = '" & TxtSname.Text & "', parent_ID_fk = " & ParChldTable(1) & " WHERE Child.child_ID = " & ParChldTable(2) & " ;"), "Child, Parent"))
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        callParentID()
        Dim childDetails As Person.PersonDetails
        childDetails.one = TxtFname.Text
        childDetails.two = TxtSname.Text
        childDetails.table = "Child"
        childDetails.columns = "c_fname, c_sname, parent_ID_fk"
        childDetails.three = ParChldTable(1)
        MsgBox(childADD.AddPerson(childDetails))
        BtnSearch.PerformClick()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        callChildID()
        MsgBox(sqldelete.Delete(("DELETE FROM Child WHERE Child.child_ID = " & ParChldTable(2) & ";"), "Child"))
    End Sub

    Private Sub BtnParentAdd_Click(sender As Object, e As EventArgs) Handles BtnParentAdd.Click
        Dim parentdetails As Person.PersonDetails
        parentdetails.one = TxtParentFname.Text
        parentdetails.two = TxtParentSname.Text
        parentdetails.table = "parent"
        parentdetails.columns = "p_fname, p_sname"
        parentdetails.three = 0
        MsgBox(PersonADD.AddPerson(parentdetails))
        BtnSearch.PerformClick()
    End Sub

    Private Sub BtnParentUpdate_Click(sender As Object, e As EventArgs) Handles BtnParentUpdate.Click
        callParentID()
        MsgBox(sqlUpdate.update(("UPDATE Parent SET p_fname ='" & TxtParentFname.Text & "', p_sname = '" & TxtParentSname.Text & "' WHERE Parent.parent_ID = " & ParChldTable(1) & ";"), "Parent"))
    End Sub

    Private Sub BtnDeleteParents_Click(sender As Object, e As EventArgs) Handles BtnDeleteParents.Click
        callParentID()
        MsgBox(sqldelete.Delete(("DELETE FROM Parent WHERE Parent.parent_ID = " & ParChldTable(1) & ";"), "Parent"))
    End Sub

    Private Sub callParentID()
        ParChldTable(1) = SQLCode.ForeignKeyDelayer("parent", "*", "")
    End Sub

    Private Sub callChildID()
        ParChldTable(2) = SQLCode.ForeignKeyDelayer("Child", "*", "")
    End Sub
End Class

