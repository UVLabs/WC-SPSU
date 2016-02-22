Imports MySql.Data.MySqlClient
Module subs
    Public dgv_main = main.dgv_main
    Public Sub load_stock()
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand


        conn = New MySqlConnection
        conn.ConnectionString = My.Settings.DatabaseConnection



        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim bSource As New BindingSource
        cmd.Connection = conn


        Try
            conn.Open()
            cmd.CommandText = "SELECT
	 T.name, O.object_id, P.ID AS Product_id, P.post_title AS Product_name, PM1.meta_value AS SKU, PM2.meta_value AS STOCK

FROM

	wp_posts P
	
		Inner JOIN
	wp_term_relationships O on
		(P.ID  = O.object_id)
		Inner JOIN
	wp_terms T on
		(T.term_id  = O.term_taxonomy_id) AND
		(T.name = 'simple')
		Inner JOIN
	wp_postmeta PM1 on
		(PM1.post_id  = P.ID) AND
		(PM1.meta_key = '_sku')
		Inner JOIN
	wp_postmeta PM2 on
		(PM2.post_id  = P.ID) AND
		(PM2.meta_key = '_stock_status')


		
where P.post_type = 'product'"
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgv_main.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub
End Module
