Public Class Form3
    Private Sub LOGOUTLBL_GROUP7_Click(sender As Object, e As EventArgs) Handles LOGOUTLBL_GROUP7.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub GradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradesToolStripMenuItem.Click
    End Sub

    Private Sub CalendarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalendarToolStripMenuItem.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class
