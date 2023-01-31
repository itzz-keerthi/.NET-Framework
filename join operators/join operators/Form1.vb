Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Customers = New List(Of Customer)(New Customer() {New Customer With {.Key = 1,
                                            .Name = "Keerthi"}, New Customer With {.Key = 2,
                                            .Name = "Jothi"}, New Customer With {.Key = 3,
                                            .Name = "Banu"}, New Customer With {.Key = 4,
                                            .Name = "Lathi"}, New Customer With {.Key = 5,
                                            .Name = "Muthu"}})
        Dim Orders = New List(Of Order)(New Order() {New Order With {.Key = 1,
                                            .Order = "Order 1"}, New Order With {.Key = 2,
                                            .Order = "Order 2"}, New Order With {.Key = 3,
                                            .Order = "Order 3"}, New Order With {.Key = 4,
                                            .Order = "Order 4"}, New Order With {.Key = 5,
                                            .Order = "Order 5"}})
        Dim query = From c In Customers Join o In Orders On c.Key Equals o.Key
                    Select New With {Key c.Name, Key o.Order}
        For Each q In query
            ListBox1.Items.Add(q.Order.ToString() & "-->" & q.Name)
        Next q

    End Sub

End Class
Public Class Customer
    Public Key As Integer
    Public Name As String
End Class
Public Class Order
    Public Key As Integer
    Public Order As String
End Class

