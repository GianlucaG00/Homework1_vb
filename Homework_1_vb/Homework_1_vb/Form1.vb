Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Id.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Surname.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear text fields
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        'Clear the progress bar
        ProgressBar1.Value = 0

        'Clear the info 
        info.Text = "---"

        'Show the panel
        Dim m As msg = New msg()
        m.Show()


    End Sub

    Private Sub Label2_Click_2(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Informations
        Dim name As String = TextBox1.Text
        Dim surname As String = TextBox2.Text
        Dim id As String = TextBox3.Text

        ' Progress bar
        ProgressBar1.Value = 100

        ' Print the informations
        info.Text = "Welcome " + name + " " + surname + " " + "(" + id + ")"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
