Public Class Form1
    Public rowNum As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
        ComboBox1.Items.Add("BCA")
        ComboBox1.Items.Add("BBA")
        ComboBox1.Items.Add("BJMC")
        ComboBox1.Items.Add("HM")

        Timer1.Start()
    End Sub

    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form2.Show()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("English")
        ListBox1.Items.Add("Enviroment")
        ListBox1.Items.Add("Management")
        ListBox1.Items.Add("French")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
        Label6.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        ComboBox1.ResetText()
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGrid.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim thisdate As Date
        thisdate = Today
        DataGrid.DataGridView1.Rows.Add(rowNum, TextBox1.Text, ComboBox1.Text, TimeOfDay.ToShortDateString, TimeOfDay.ToShortTimeString)
        MsgBox(rowNum,, "Number of Students")
        rowNum += 1
    End Sub
End Class
