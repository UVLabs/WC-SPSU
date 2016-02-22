Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.DatabaseConnection = ""
        My.Settings.Save()

        If String.IsNullOrEmpty(My.Settings.DatabaseConnection) Then

            auth.Show()


            'MessageBox.Show("server=" & host & ";user id=" & user & ";database=" & database & ";password=" & password)
        Else

            MsgBox("empty")
        End If
    End Sub


End Class
