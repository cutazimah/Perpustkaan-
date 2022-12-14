
Imports System.Data.Common

Public Class Login

    Public Shared Perpustakaan As Form_Perpustakaan
    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New Form_Perpustakaan()
        Users = New Users()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPass.Text
        'Dim Encrypted As String = USers.EncryptData(plain Password)
        'MessaggeBox.Show(Encrypted)
        'Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)
        'MessageBox.Show(AuthStatus)
        'If AuthStatus Then
        '    Form_Perpustakaan.Show()
        'Else
        '    MessageBox.Show("Wrong Password")
        'End If
        Dim data_user As List(Of String) = Users.ChechkAuthDatabase(plainUsername, plainPassword)
        If data_user.Count > 0 Then
            Users.UsernameProperty = data_user(1)
            Form_Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If
    End Sub
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim enter = New SignUp()
        enter.Show()
    End Sub
End Class