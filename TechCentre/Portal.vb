Public Class Portal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HQ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Franchise.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Corporate.Show()
    End Sub

    Private Sub HQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HQToolStripMenuItem.Click
        HQ.Show()
    End Sub

    Private Sub CorporateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorporateToolStripMenuItem.Click
        Corporate.Show()
    End Sub

    Private Sub FranchiseB2CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FranchiseB2CToolStripMenuItem.Click
        Franchise.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub
End Class
