Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers As Integer() = New Integer(6) {0, 1, 2, 3, 4, 5, 6}
        Dim numquery = From num In numbers Where (num Mod 2) = 0 Select num
        For Each num As Integer In numquery
            ListBox1.Items.Add(num.ToString())
        Next
    End Sub
End Class
