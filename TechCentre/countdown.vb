Public Class countdown
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As Integer
        Dim b As Integer
        Dim d As Integer
        a = Label2.Text
        d = Label1.Text
        b = 1
        Label2.Text = a - b
        If Label2.Text = "0" Then
            Label1.Text = d - b
            Label2.Text = "60"
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox1.Text = Label1.Text
        TextBox2.Text = Label2.Text
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If TextBox1.Text = "0" And TextBox2.Text = "1" Then
            Timer1.Enabled = False
            Timer4.Enabled = False
            Label3.Visible = True

            Label1.Text = "0"
            Label2.Text = "0"
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Label3.Visible = True Then
            Label3.Visible = False
        Else
            Label3.Visible = True
        End If
    End Sub
End Class