Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form1 As New Form1()
        form1.FormBorderStyle = FormBorderStyle.None
        form1.TopLevel = False
        form1.Dock = DockStyle.Fill
        MAIN_GROUP7.Controls.Add(form1)
        form1.Show()
    End Sub
End Class

