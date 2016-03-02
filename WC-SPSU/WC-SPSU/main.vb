Public Class main
    Public changelist As New List(Of stock_status_changes)

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.DatabaseConnection = ""
        My.Settings.TablePrefix = ""
        My.Settings.Save()

        If String.IsNullOrEmpty(My.Settings.DatabaseConnection) Or String.IsNullOrEmpty(My.Settings.TablePrefix) Then

            auth.Show()

            'MessageBox.Show("server=" & host & ";user id=" & user & ";database=" & database & ";password=" & password)
        Else
            'add try statement
            'Me.dgv_main.Rows[0]
            load_stock()
            'dgv_main.AutoGenerateColumns = False

            ' dgv_main.Columns(1).Width = 500
            dgv_main.AutoResizeColumns()
        End If

        'Label1.Text = My.Settings.DatabaseConnection
    End Sub



    Private Sub dgv_main_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_main.CellEnter
        'ref= http://www.vbforums.com/showthread.php?476221-RESOLVED-2005-combobox-in-datagridview-single-click

        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv(e.ColumnIndex, e.RowIndex).EditType IsNot Nothing Then

            If dgv(e.ColumnIndex, e.RowIndex).EditType.ToString() = "System.Windows.Forms.DataGridViewComboBoxEditingControl" Then

                SendKeys.Send("{F4}")

            End If

        End If

    End Sub

    Private Sub btn_load_more_stock_Click(sender As Object, e As EventArgs) Handles btn_pull_stock.Click
        Try
            load_more_stock()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Label1.Text = last_row()
        load_stock()
        'last_row_product_ID()
    End Sub
End Class
