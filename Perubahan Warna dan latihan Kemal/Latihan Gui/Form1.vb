Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = "selamat sore " & TextBox1.Text
        Label3.Text = "Panjang kata : " & TextBox1.Text.Length
        Label3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.BackColor = Color.Yellow Then
            Me.BackColor = Color.Green
        ElseIf Me.BackColor = Color.Green Then
            Me.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Yellow
    End Sub
End Class
