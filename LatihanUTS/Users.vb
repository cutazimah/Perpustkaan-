Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "perpustakaann"

    Private username As String
    Private password As String
    Private TripleDes As New TripleDESCryptoServiceProvider


    Public Property UsernameProperty() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property GSUsername() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property GSPassword() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property
    Public Function EncryptData(ByVal plaintext As String) As String

        'COnvert the plaintext string to a byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'Create the stream
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write to the stream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
             System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'COnvert the encrypted stream to a printable string 
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String
        Dim ALUsername As New ArrayList
        Dim ALPassword As New ArrayList

        ALUsername.Add({"Hanifah", "Cut", "Noor"})
        ALPassword.Add({"2222", "3333", "4444"})

        For Each ArrayList In ALUsername
            For Each AL In ALPassword
                Dim ChechkString As String = EncryptData(AL(0))
                Dim ChechkString2 As String = EncryptData(AL(1))
                Dim ChechkString3 As String = EncryptData(AL(2))
                If String.Compare(username, ArrayList(0)) = 0 And String.Compare(EncryptData(plainPassword), ChechkString) = 0 Then
                    Return True
                ElseIf String.Compare(username, ArrayList(1)) = 0 And String.Compare(EncryptData(plainPassword), ChechkString2) = 0 Then
                    Return True
                ElseIf String.Compare(username, ArrayList(2)) = 0 And String.Compare(EncryptData(plainPassword), ChechkString3) = 0 Then
                    Return True
                Else
                    Return False
                End If
            Next
        Next
        'Static Password
        'Dim realPassword As String = EncryptData("1111")
        'Dim realUsername As String = "Azimah"
        'If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPassword) = 0 Then
        '    Return True
        'Else
        '    Return False
        'End If
    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString
    End Function

    Public Function AddUsersDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server = " + server + ";" + "user id =" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = " INSERT INTO USERS ( username, password, registered_at) VALUE ('" _
                    & username_regist & "', '" _
                    & EncryptMD5(password_regist) & "', '" _
                    & today.ToString("yyyy/MM/dd") & "')"
            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function ChechkAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = " SELECT id_user, username FROM users WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
