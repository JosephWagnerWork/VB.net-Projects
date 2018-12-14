Public Class Foreign_Key_Selector
    Public SQLCode As New SQLQueries
    Public SelectorSource As String = "staff"
    Public selectorQuery As String = "*"
    Public selectorQuery2 As String = ""
    Public selectedItem As String
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        selectedItem = DGVSelector.Item(0, DGVSelector.CurrentRow.Index).Value
        Me.Hide()
    End Sub

    Private Sub Foreign_Key_Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVSelector.DataSource = SQLCode.Load(("SELECT " & selectorQuery & "FROM " & SelectorSource & " " & selectorQuery2 & ";"), SelectorSource)

    End Sub
End Class