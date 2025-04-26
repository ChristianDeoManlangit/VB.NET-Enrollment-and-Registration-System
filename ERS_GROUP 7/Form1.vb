Public Class Form1
    Dim correctUsername As String = "TUPT-24-0000"
    Dim correctPassword As String = "HATDOG123"
    Dim correctBirthdate As String = "01/01/2006"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        USERNAMEBOX_GROUP7.Focus()
    End Sub

    Private Sub USERNAMEBOX_GROUP7_KeyDown(sender As Object, e As KeyEventArgs) Handles USERNAMEBOX_GROUP7.KeyDown
        If e.KeyCode = Keys.Enter Then
            PASSWORDBOX_GROUP7.Focus()
        End If
    End Sub

    Private Sub PASSWORDBOX_GROUP7_KeyDown(sender As Object, e As KeyEventArgs) Handles PASSWORDBOX_GROUP7.KeyDown
        If e.KeyCode = Keys.Enter Then
            BIRTHDATEBOX_GROUP7.Focus()
        End If
    End Sub

    Private Sub BIRTHDATEBOX_GROUP7_KeyDown(sender As Object, e As KeyEventArgs) Handles BIRTHDATEBOX_GROUP7.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOGINBUT_GROUP7.PerformClick()
        End If
    End Sub

    Private Sub CLEARBUT_GROUP7_Click(sender As Object, e As EventArgs) Handles CLEARBUT_GROUP7.Click
        USERNAMEBOX_GROUP7.Clear()
        PASSWORDBOX_GROUP7.Clear()
        BIRTHDATEBOX_GROUP7.Clear()
        USERNAMEBOX_GROUP7.Focus()
    End Sub

    Private Sub LOGINBUT_GROUP7_Click(sender As Object, e As EventArgs) Handles LOGINBUT_GROUP7.Click
        If USERNAMEBOX_GROUP7.Text = correctUsername AndAlso PASSWORDBOX_GROUP7.Text = correctPassword AndAlso BIRTHDATEBOX_GROUP7.Text = correctBirthdate Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter the correct details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub LOGINBUT_GROUP7_MouseHover(sender As Object, e As EventArgs) Handles LOGINBUT_GROUP7.MouseHover
        TOOLTIP1_GROUP7.ToolTipIcon = ToolTipIcon.Info
        TOOLTIP1_GROUP7.ToolTipTitle = "Login Information"
        TOOLTIP1_GROUP7.SetToolTip(LOGINBUT_GROUP7, "Click this button to log in to your account.")
    End Sub

    Private Sub CLEARBUT_GROUP7_MouseHover(sender As Object, e As EventArgs) Handles CLEARBUT_GROUP7.MouseHover
        TOOLTIP2_GROUP7.ToolTipIcon = ToolTipIcon.Info
        TOOLTIP2_GROUP7.ToolTipTitle = "Clear Information"
        TOOLTIP2_GROUP7.SetToolTip(CLEARBUT_GROUP7, "Click this button to clear the information you've entered.")
    End Sub
End Class
