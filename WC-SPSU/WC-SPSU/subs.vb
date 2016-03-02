Imports MySql.Data.MySqlClient
Module subs
    Public dgv_main = main.dgv_main
    Dim last_row_product_ID_value As Integer
    Dim id As Integer 'Get ID user inputted
    Dim amount As String 'Get amount of stock pull user entered




    Public Sub load_stock()
        'Get Table Prefix
        Dim prefix As String = My.Settings.TablePrefix

        'Connect To DB
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

	" & prefix & "_posts P
	
		Inner JOIN
	" & prefix & "_term_relationships O on
		(P.ID  = O.object_id)
		Inner JOIN
	" & prefix & "_terms T on
		(T.term_id  = O.term_taxonomy_id) AND
		(T.name = 'simple')
		Inner JOIN
	" & prefix & "_postmeta PM1 on
		(PM1.post_id  = P.ID) AND
		(PM1.meta_key = '_sku')
		Inner JOIN
	" & prefix & "_postmeta PM2 on
		(PM2.post_id  = P.ID) AND
		(PM2.meta_key = '_stock_status')

where P.post_type = 'product' ORDER BY P.ID desc limit 5"
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
        'Get Table Prefix
        Dim prefix As String = My.Settings.TablePrefix

        'last_row_product_ID()
        'Get user input for stock pull

        get_new_prods()

        'Connect To DB

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
     P.ID As Product_ID, P.post_title As Product_Name, PM1.meta_value As SKU, PM2.meta_value As Stock

FROM

	" & prefix & "_posts P
	
		Inner JOIN
	" & prefix & "_term_relationships O on
		(P.ID  = O.object_id)
		Inner JOIN
	" & prefix & "_terms T on
		(T.term_id  = O.term_taxonomy_id) AND
		(T.name = 'simple')
		Inner JOIN
	" & prefix & "_postmeta PM1 on
		(PM1.post_id  = P.ID) AND
		(PM1.meta_key = '_sku')
		Inner JOIN
	" & prefix & "_postmeta PM2 on
		(PM2.post_id  = P.ID) AND
		(PM2.meta_key = '_stock_status')

where P.post_type = 'product' AND P.ID < '" & id & "' order by P.ID desc limit " & amount & ""

            SDA.SelectCommand = cmd

            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgv_main.DataSource = bSource
            SDA.Update(dbDataSet)


            dgv_main.Columns("Product_ID").HeaderText = "Product ID"
            dgv_main.Columns("Product_Name").HeaderText = "Title"
            dgv_main.Columns("Product_ID").ReadOnly = True
            dgv_main.Columns("Product_Name").ReadOnly = True

            'weird stuff going on below, look into this

            'Dim stock_change As New DataGridViewComboBoxColumn()

            ''stock_change.DataPropertyName = "Stock Status"
            'stock_change.HeaderText = "Stock Status"
            'stock_change.Name = "Stock Status"
            'stock_change.ReadOnly = False
            'stock_change.Items.Add("In Stock")
            'stock_change.Items.Add("Out Of Stock")
            'dgv_main.Columns.Add(stock_change)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()

        End Try

        'last_row_product_ID_value = 0


    End Sub

    Public Sub get_new_prods()

        id = main.tb_ld_frm_id.Text
        amount = main.tb_ld_quantity.Text

    End Sub

    Public Sub last_row_product_ID()
        Try

            'Dim cellvalue As String
            'With dgv_main
            '    cellvalue = .Rows(.RowCount - 1).Cells(.ColumnCount - 1).value
            'End With
            'last_row_product_ID_value = cellvalue
            'main.Label2.Text = cellvalue


            'For Each item In dgv_main.rows()
            '    last_row_product_ID_value = dgv_main.Rows(dgv_main.RowCount - 1).Cells(0).value.ToString()
            '    main.Label1.Text = last_row_product_ID_value
            'Next
            dgv_main.Refresh()
            last_row_product_ID_value = dgv_main.Rows(dgv_main.rowcount - 1).Cells(0).value
            ' main.Label2.Text = last_row_product_ID_value
            main.tb_ld_frm_id.Text = dgv_main.rowcount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Module
