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
	 P.ID AS Product_ID, P.post_title AS Product_Name, PM1.meta_value AS SKU, PM2.meta_value AS Stock

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

where P.post_type = 'product' ORDER BY P.ID desc"
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgv_main.DataSource = bSource
            SDA.Update(dbDataSet)


            dgv_main.Columns("Product_ID").HeaderText = "Product ID"
            dgv_main.Columns("Product_Name").HeaderText = "Title"
            dgv_main.Columns("Product_ID").ReadOnly = True
            dgv_main.Columns("Product_Name").ReadOnly = True

            Dim stock_change As New DataGridViewComboBoxColumn()

            'stock_change.DataPropertyName = "Stock Status"
            stock_change.HeaderText = "Stock Status"
            stock_change.Name = "Stock Status"
            stock_change.ReadOnly = False
            stock_change.Items.Add("In Stock")
            stock_change.Items.Add("Out Of Stock")
            dgv_main.Columns.Add(stock_change)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub


    Public Sub load_more_stock()
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
	 P.ID AS Product_ID, P.post_title AS Product_Name, PM1.meta_value AS SKU, PM2.meta_value AS Stock

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

where P.post_type = 'product' AND P.ID < 80 order by P.ID desc limit 2"
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgv_main.DataSource = bSource
            SDA.Update(dbDataSet)


            dgv_main.Columns("Product_ID").HeaderText = "Product ID"
            dgv_main.Columns("Product_Name").HeaderText = "Title"
            dgv_main.Columns("Product_ID").ReadOnly = True
            dgv_main.Columns("Product_Name").ReadOnly = True

            Dim stock_change As New DataGridViewComboBoxColumn()

            'stock_change.DataPropertyName = "Stock Status"
            stock_change.HeaderText = "Stock Status"
            stock_change.Name = "Stock Status"
            stock_change.ReadOnly = False
            stock_change.Items.Add("In Stock")
            stock_change.Items.Add("Out Of Stock")
            dgv_main.Columns.Add(stock_change)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub

    Public Sub last_row()
        Dim last_row_product_ID As String = dgv_main.Rows(dgv_main.RowCount - 1).Cells(0).value.ToString()
        main.Label1.Text = last_row_product_ID
    End Sub


End Module
