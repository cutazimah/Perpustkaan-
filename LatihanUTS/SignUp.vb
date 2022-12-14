Public Class SignUp
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        If TxtUserName.Text.Length > 0 And TxtPassword.Text.Length > 0 Then

            Login.Users.AddUsersDatabase(TxtUserName.Text, TxtPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class