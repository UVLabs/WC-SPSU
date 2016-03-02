Imports MySql.Data.MySqlClient

Public Class auth
    Dim host As String
    Dim user As String
    Dim password As String
    Dim database As String
    Dim tableprefix As String


    Private Sub auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_saveCreds_Click(sender As Object, e As EventArgs) Handles btn_saveCreds.Click
        ' get_values()


        host = tb_dbHost.Text
        user = tb_dbUsername.Text
        password = tb_dbPassword.Text
        database = tb_dbName.Text
        tableprefix = tb_db_table_prefix.Text

        If String.IsNullOrEmpty(host) Or String.IsNullOrEmpty(user) Or String.IsNullOrEmpty(database) Or String.IsNullOrEmpty(tableprefix) Then

            MsgBox("Please put in your database credentials", vbInformation, "Error")

        Else

            My.Settings.DatabaseConnection = "server=" & host & ";user id=" & user & ";database=" & database & ";Password=" & password
            My.Settings.TablePrefix = tableprefix
            My.Settings.Save()
            MsgBox("Your settings have been saved", vbInformation)
            load_stock()
            main.Show()
            Me.Hide()

            'TODO clear values from textboxes which user entered
        End If

        'Beep()
        ' My.Settings.Reload()
        ' Me.Hide()
        'main.Show()
    End Sub

    Private Sub btn_testCreds_Click(sender As Object, e As EventArgs) Handles btn_testCreds.Click
        ' get_values()
        'CHECK FOR EMPTY FIELDS

        host = tb_dbHost.Text
        user = tb_dbUsername.Text
        password = tb_dbPassword.Text
        database = tb_dbName.Text

        Dim mysqlconn As MySqlConnection
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString = "server=" & host & ";user id=" & user & ";database=" & database & ";Password=" & password

        Try
            mysqlconn.Open()
            MsgBox("Connection Successful", vbInformation)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(My.Settings.DatabaseConnection)
        MsgBox(My.Settings.TablePrefix)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Settings.DatabaseConnection = ""
        My.Settings.TablePrefix = ""
        My.Settings.Save()
    End Sub

    Private Sub auth_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.Close()
    End Sub
End Class