Imports System.Data.SQLite
Public Class SQLQueries
    Public conectionstring As String = "Data Source=oakchildren.db"

    Public Function ForeignKeyDelayer(tablesource As String, tablequery As String, tablequery2 As String)
        Foreign_Key_Selector.SelectorSource = tablesource
        Foreign_Key_Selector.selectorQuery = tablequery
        Foreign_Key_Selector.selectorQuery2 = tablequery2
        Foreign_Key_Selector.ShowDialog()

        Return Foreign_Key_Selector.selectedItem
    End Function

    Public Function Load(SQLCode As String, table As String) As DataTable

        Dim newds As New DataSet
        Dim newdt As New DataTable

        Dim con As New SQLiteConnection(conectionstring)
        Dim cmd As New SQLiteCommand(SQLCode, con)

        con.Open()
        Dim da As New SQLiteDataAdapter(cmd)
        da.Fill(newds, table)
        newdt = newds.Tables(0)
        con.Close()
        Return newdt
    End Function
End Class

Public Class SQLUpdateQueries
    Inherits SQLQueries
    Public Function update(SQLCode As String, table As String) As String
        Dim DA As New SQLiteDataAdapter
        Dim DS As New DataSet

        Dim con As New SQLiteConnection(conectionstring)
        Dim cmd As New SQLiteCommand(SQLCode, con)

        con.Open()

        DA.UpdateCommand = con.CreateCommand
        DA.UpdateCommand.CommandText = SQLCode
        DA.UpdateCommand.ExecuteNonQuery()

        Return "UPDATED"
        con.Close()
    End Function
End Class

Public Class SQLDeleteQueries
    Inherits SQLQueries
    Public Function Delete(SQLCode As String, table As String) As String
        Dim DS As New DataSet
        Dim con As New SQLiteConnection(conectionstring)
        Dim DA As New SQLiteDataAdapter

        Dim cmd As New SQLiteCommand(SQLCode, con)
        con.Open()

        DA.DeleteCommand = con.CreateCommand
        DA.DeleteCommand.CommandText = SQLCode
        DA.DeleteCommand.ExecuteNonQuery()

        Return ("Deleted (They have been Terminated)")
        con.Close()
    End Function
End Class

Public Class SQLAddQueries
    Inherits SQLQueries
    Public Function add(SQLCode As String, table As String) As String
        Dim DA As New SQLiteDataAdapter
        Dim DS As New DataSet
        Dim con As New SQLiteConnection(conectionstring)
        Dim cmd As New SQLiteCommand(SQLCode, con)

        con.Open()

        DA.InsertCommand = New SQLiteCommand(SQLCode, con)
        DA.InsertCommand.ExecuteNonQuery()

        Return "Added"
        con.Close()
    End Function


End Class
