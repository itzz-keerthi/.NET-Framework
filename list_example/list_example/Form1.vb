Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim words() As String = {"red", "blue", "white", "yellow", "green"}
        For Each w In words
            ListBox1.Items.Add(w.ToString())
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim words(4) As String
        For index = 0 To 4
            words(index) = ListBox1.Items(index)
        Next
        Dim query = From word In words Select word.Substring(0, 1)
        For Each letter In query
            ListBox2.Items.Add(letter.ToString())
        Next
    End Sub
End Class
