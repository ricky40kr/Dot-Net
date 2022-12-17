Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.ToLower = "ricky" And TextBox2.Text.ToLower = "ricky" Then
            Form1.Show()
        Else
            MsgBox("Invalid Credential!",, "Error")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("C:\Users\rhiti\Documents\College\.NET\RegistrationApp\RegistrationApp\Jordi.jpg")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class