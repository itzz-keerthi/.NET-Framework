Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim words() As String = {"apple", "banana", "cherry", "pineapple", "apricot",
             "papaya", "blueberry", "abascus", "parrot", "black"}
        For Each w In words
            ListBox1.Items.Add(w.ToString())
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim words(9) As String
        For index = 0 To 9
            words(index) = ListBox1.Items(index)
        Next
        Dim query = From w In words Group By w.First() Into Group
        ListBox1.Items.Clear()
        For Each group In query
            ListBox1.Items.Add("Words beginning with letter: " & group.First.ToString())
            For Each w In group.Group
                ListBox1.Items.Add(w)
            Next
        Next
    End Sub
End Class
