Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numbers As Integer() = {500, 700, 100, 200, 400, 600, 900, 300, 800}
        For Each num In numbers
            ListBox1.Items.Add(num.ToString())
        Next num

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers(8) As Integer
        For index = 0 To 8
            numbers(index) = ListBox1.Items(index)
        Next
        Dim sorting = From num In numbers Order By num
                      Select num
        ListBox1.Items.Clear()
        For Each s In sorting
            ListBox1.Items.Add(s.ToString())
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numbers(8) As Integer
        For index = 0 To 8
            numbers(index) = ListBox1.Items(index)
        Next
        Dim sorting = From num In numbers Order By num
        Descending Select num
        ListBox1.Items.Clear()
        For Each s In sorting
            ListBox1.Items.Add(s.ToString())
        Next
    End Sub
End Class
