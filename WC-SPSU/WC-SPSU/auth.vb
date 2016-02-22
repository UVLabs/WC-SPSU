Imports MySql.Data.MySqlClient

Public Class auth
    Dim host As String
    Dim user As String
    Dim password As String
    Dim database As String
    Private Sub auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_saveCreds_Click(sender As Object, e As EventArgs) Handles btn_saveCreds.Click
        ' get_values()
        host = tb_dbHost.Text
        user = tb_dbUsername.Text
        password = tb_dbPassword.Text
        database = tb_dbName.Text


        My.Settings.DatabaseConnection = "server=" & host & ";user id=" & user & ";database=" & database & ";Password=" & password
        My.Settings.Save()
        'Beep()
        ' My.Settings.Reload()
        ' Me.Hide()
        'main.Show()
    End Sub

    Private Sub btn_testCreds_Click(sender As Object, e As EventArgs) Handles btn_testCreds.Click
        ' get_values()

        host = tb_dbHost.Text
        user = tb_dbUsername.Text
        password = tb_dbPassword.Text
        database = tb_dbName.Text

        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString = "server=" & host & ";user id=" & user & ";database=" & database & ";Password=" & password
        MsgBox(mysqlconn.ConnectionString)
        Try
            mysqlconn.Open()
            MsgBox("Connection Successful")
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox("Cannot connect to database: " & ex.Message)
        End Try


    End Sub

    Public Sub get_values()
        Dim host As String = tb_dbHost.Text
        Dim user As String = tb_dbUsername.Text
        Dim password As String = tb_dbPassword.Text
        Dim database As String = tb_dbName.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(My.Settings.DatabaseConnection)
    End Sub
End Class