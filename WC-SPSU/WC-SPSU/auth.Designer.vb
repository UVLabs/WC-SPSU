<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auth
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
        Me.tb_dbHost = New System.Windows.Forms.TextBox()
        Me.tb_dbPassword = New System.Windows.Forms.TextBox()
        Me.tb_dbUsername = New System.Windows.Forms.TextBox()
        Me.lbl_host = New System.Windows.Forms.Label()
        Me.lbl_db_usr_name = New System.Windows.Forms.Label()
        Me.lbl_db_name = New System.Windows.Forms.Label()
        Me.tb_dbName = New System.Windows.Forms.TextBox()
        Me.lbl_db_pw = New System.Windows.Forms.Label()
        Me.btn_saveCreds = New System.Windows.Forms.Button()
        Me.btn_testCreds = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_dbHost
        '
        Me.tb_dbHost.Location = New System.Drawing.Point(135, 30)
        Me.tb_dbHost.Name = "tb_dbHost"
        Me.tb_dbHost.Size = New System.Drawing.Size(193, 20)
        Me.tb_dbHost.TabIndex = 0
        '
        'tb_dbPassword
        '
        Me.tb_dbPassword.Location = New System.Drawing.Point(135, 82)
        Me.tb_dbPassword.Name = "tb_dbPassword"
        Me.tb_dbPassword.Size = New System.Drawing.Size(193, 20)
        Me.tb_dbPassword.TabIndex = 1
        '
        'tb_dbUsername
        '
        Me.tb_dbUsername.Location = New System.Drawing.Point(135, 56)
        Me.tb_dbUsername.Name = "tb_dbUsername"
        Me.tb_dbUsername.Size = New System.Drawing.Size(193, 20)
        Me.tb_dbUsername.TabIndex = 2
        '
        'lbl_host
        '
        Me.lbl_host.AutoSize = True
        Me.lbl_host.Location = New System.Drawing.Point(25, 33)
        Me.lbl_host.Name = "lbl_host"
        Me.lbl_host.Size = New System.Drawing.Size(32, 13)
        Me.lbl_host.TabIndex = 3
        Me.lbl_host.Text = "Host:"
        '
        'lbl_db_usr_name
        '
        Me.lbl_db_usr_name.AutoSize = True
        Me.lbl_db_usr_name.Location = New System.Drawing.Point(25, 59)
        Me.lbl_db_usr_name.Name = "lbl_db_usr_name"
        Me.lbl_db_usr_name.Size = New System.Drawing.Size(107, 13)
        Me.lbl_db_usr_name.TabIndex = 4
        Me.lbl_db_usr_name.Text = "Database Username:"
        '
        'lbl_db_name
        '
        Me.lbl_db_name.AutoSize = True
        Me.lbl_db_name.Location = New System.Drawing.Point(25, 111)
        Me.lbl_db_name.Name = "lbl_db_name"
        Me.lbl_db_name.Size = New System.Drawing.Size(87, 13)
        Me.lbl_db_name.TabIndex = 6
        Me.lbl_db_name.Text = "Database Name:"
        '
        'tb_dbName
        '
        Me.tb_dbName.Location = New System.Drawing.Point(135, 108)
        Me.tb_dbName.Name = "tb_dbName"
        Me.tb_dbName.Size = New System.Drawing.Size(193, 20)
        Me.tb_dbName.TabIndex = 5
        '
        'lbl_db_pw
        '
        Me.lbl_db_pw.AutoSize = True
        Me.lbl_db_pw.Location = New System.Drawing.Point(25, 85)
        Me.lbl_db_pw.Name = "lbl_db_pw"
        Me.lbl_db_pw.Size = New System.Drawing.Size(105, 13)
        Me.lbl_db_pw.TabIndex = 7
        Me.lbl_db_pw.Text = "Database Password:"
        '
        'btn_saveCreds
        '
        Me.btn_saveCreds.Location = New System.Drawing.Point(253, 134)
        Me.btn_saveCreds.Name = "btn_saveCreds"
        Me.btn_saveCreds.Size = New System.Drawing.Size(75, 23)
        Me.btn_saveCreds.TabIndex = 8
        Me.btn_saveCreds.Text = "Save"
        Me.btn_saveCreds.UseVisualStyleBackColor = True
        '
        'btn_testCreds
        '
        Me.btn_testCreds.Location = New System.Drawing.Point(135, 134)
        Me.btn_testCreds.Name = "btn_testCreds"
        Me.btn_testCreds.Size = New System.Drawing.Size(75, 23)
        Me.btn_testCreds.TabIndex = 9
        Me.btn_testCreds.Text = "Test"
        Me.btn_testCreds.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 175)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_testCreds)
        Me.Controls.Add(Me.btn_saveCreds)
        Me.Controls.Add(Me.lbl_db_pw)
        Me.Controls.Add(Me.lbl_db_name)
        Me.Controls.Add(Me.tb_dbName)
        Me.Controls.Add(Me.lbl_db_usr_name)
        Me.Controls.Add(Me.lbl_host)
        Me.Controls.Add(Me.tb_dbUsername)
        Me.Controls.Add(Me.tb_dbPassword)
        Me.Controls.Add(Me.tb_dbHost)
        Me.Name = "auth"
        Me.Text = "auth"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_dbHost As TextBox
    Friend WithEvents tb_dbPassword As TextBox
    Friend WithEvents tb_dbUsername As TextBox
    Friend WithEvents lbl_host As Label
    Friend WithEvents lbl_db_usr_name As Label
    Friend WithEvents lbl_db_name As Label
    Friend WithEvents tb_dbName As TextBox
    Friend WithEvents lbl_db_pw As Label
    Friend WithEvents btn_saveCreds As Button
    Friend WithEvents btn_testCreds As Button
    Friend WithEvents Button1 As Button
End Class
