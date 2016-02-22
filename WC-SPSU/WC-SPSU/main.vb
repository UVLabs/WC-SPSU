Public Class main
    Public changelist As New List(Of stock_status_changes)

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.DatabaseConnection = ""
        ' My.Settings.Save()

        If String.IsNullOrEmpty(My.Settings.DatabaseConnection) Then

            auth.Show()

            'MessageBox.Show("server=" & host & ";user id=" & user & ";database=" & database & ";password=" & password)
        Else

            load_stock()
            Me.dgv_main.Columns("Product_ID").HeaderText = "Product ID"
            Me.dgv_main.Columns("Product_Name").HeaderText = "Title"
            ' dgv_main.Columns(1).Width = 500
            dgv_main.AutoResizeColumns()
        End If

        Label1.Text = My.Settings.DatabaseConnection
    End Sub


End Class
