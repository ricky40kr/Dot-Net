Public Class DataGrid
    Private Sub DataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub DataGrid_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Form1.Show()
    End Sub
End Class