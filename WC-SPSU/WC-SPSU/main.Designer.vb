<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_main = New System.Windows.Forms.DataGridView()
        Me.tb_ld_frm_id = New System.Windows.Forms.TextBox()
        Me.lbl_ld_frm_id = New System.Windows.Forms.Label()
        Me.lbl_ld_quantity = New System.Windows.Forms.Label()
        Me.btn_pull_stock = New System.Windows.Forms.Button()
        Me.tb_ld_quantity = New System.Windows.Forms.TextBox()
        Me.btn_update_stock = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_main, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(760, 416)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgv_main
        '
        Me.dgv_main.AllowUserToAddRows = False
        Me.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_main.Location = New System.Drawing.Point(3, 3)
        Me.dgv_main.Name = "dgv_main"
        Me.dgv_main.Size = New System.Drawing.Size(754, 410)
        Me.dgv_main.TabIndex = 0
        '
        'tb_ld_frm_id
        '
        Me.tb_ld_frm_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_ld_frm_id.Location = New System.Drawing.Point(680, 506)
        Me.tb_ld_frm_id.Name = "tb_ld_frm_id"
        Me.tb_ld_frm_id.Size = New System.Drawing.Size(54, 20)
        Me.tb_ld_frm_id.TabIndex = 4
        '
        'lbl_ld_frm_id
        '
        Me.lbl_ld_frm_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ld_frm_id.AutoSize = True
        Me.lbl_ld_frm_id.Location = New System.Drawing.Point(578, 509)
        Me.lbl_ld_frm_id.Name = "lbl_ld_frm_id"
        Me.lbl_ld_frm_id.Size = New System.Drawing.Size(74, 13)
        Me.lbl_ld_frm_id.TabIndex = 6
        Me.lbl_ld_frm_id.Text = "Load From ID:"
        '
        'lbl_ld_quantity
        '
        Me.lbl_ld_quantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ld_quantity.AutoSize = True
        Me.lbl_ld_quantity.Location = New System.Drawing.Point(578, 460)
        Me.lbl_ld_quantity.Name = "lbl_ld_quantity"
        Me.lbl_ld_quantity.Size = New System.Drawing.Size(89, 13)
        Me.lbl_ld_quantity.TabIndex = 7
        Me.lbl_ld_quantity.Text = "Quantity To Load"
        '
        'btn_pull_stock
        '
        Me.btn_pull_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pull_stock.Location = New System.Drawing.Point(659, 555)
        Me.btn_pull_stock.Name = "btn_pull_stock"
        Me.btn_pull_stock.Size = New System.Drawing.Size(75, 23)
        Me.btn_pull_stock.TabIndex = 3
        Me.btn_pull_stock.Text = "Pull Stock"
        Me.btn_pull_stock.UseVisualStyleBackColor = True
        '
        'tb_ld_quantity
        '
        Me.tb_ld_quantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_ld_quantity.Location = New System.Drawing.Point(680, 457)
        Me.tb_ld_quantity.Name = "tb_ld_quantity"
        Me.tb_ld_quantity.Size = New System.Drawing.Size(54, 20)
        Me.tb_ld_quantity.TabIndex = 5
        '
        'btn_update_stock
        '
        Me.btn_update_stock.Location = New System.Drawing.Point(327, 485)
        Me.btn_update_stock.Name = "btn_update_stock"
        Me.btn_update_stock.Size = New System.Drawing.Size(75, 23)
        Me.btn_update_stock.TabIndex = 8
        Me.btn_update_stock.Text = "Update Stock"
        Me.btn_update_stock.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 590)
        Me.Controls.Add(Me.btn_update_stock)
        Me.Controls.Add(Me.btn_pull_stock)
        Me.Controls.Add(Me.lbl_ld_quantity)
        Me.Controls.Add(Me.lbl_ld_frm_id)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tb_ld_frm_id)
        Me.Controls.Add(Me.tb_ld_quantity)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WooCommerce Simple Product Stock Update"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgv_main As DataGridView
    Friend WithEvents tb_ld_frm_id As TextBox
    Friend WithEvents lbl_ld_frm_id As Label
    Friend WithEvents lbl_ld_quantity As Label
    Friend WithEvents btn_pull_stock As Button
    Friend WithEvents tb_ld_quantity As TextBox
    Friend WithEvents btn_update_stock As Button
End Class
