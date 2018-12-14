Imports WinOakChildren

Public Class Person
    Public SQLCode As New SQLQueries
    Public sqlUpdate As New SQLUpdateQueries
    Public sqldelete As New SQLDeleteQueries
    Public sqladd As New SQLAddQueries
    Public Structure PersonDetails
        'Names/FK's
        Dim one, two, three As String
        'table details
        Dim table, columns As String

    End Structure

    Public Overridable Function GetNameInsert(details As PersonDetails)
        Return ("'" & details.one & "','" & details.two & "'")
    End Function
    Public Overridable Function AddPerson(Details As PersonDetails) As String
        Return sqladd.add(("INSERT INTO " & Details.table & "(" & Details.columns & ") VALUES(" & GetNameInsert(Details) & ");"), Details.table)
    End Function
End Class

Public Class childClass
    Inherits Person
    Public Overrides Function GetNameInsert(details As PersonDetails)
        Return MyBase.GetNameInsert(details) & (",'" & details.three & "'")
    End Function

End Class
