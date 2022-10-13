<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tcSQL = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVData = New System.Windows.Forms.DataGridView()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cbAdmin = New System.Windows.Forms.CheckBox()
        Me.cbActive = New System.Windows.Forms.CheckBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cbxThreads = New System.Windows.Forms.ComboBox()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvTables = New System.Windows.Forms.ListView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdBackup = New System.Windows.Forms.Button()
        Me.txtBakFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sfdBackup = New System.Windows.Forms.SaveFileDialog()
        Me.tcSQL.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcSQL
        '
        Me.tcSQL.Controls.Add(Me.TabPage1)
        Me.tcSQL.Controls.Add(Me.TabPage2)
        Me.tcSQL.Controls.Add(Me.TabPage3)
        Me.tcSQL.Controls.Add(Me.TabPage4)
        Me.tcSQL.Controls.Add(Me.TabPage5)
        Me.tcSQL.Location = New System.Drawing.Point(9, 14)
        Me.tcSQL.Name = "tcSQL"
        Me.tcSQL.SelectedIndex = 0
        Me.tcSQL.Size = New System.Drawing.Size(471, 327)
        Me.tcSQL.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVData)
        Me.TabPage1.Controls.Add(Me.cmdQuery)
        Me.TabPage1.Controls.Add(Me.txtQuery)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(463, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "QUERY"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVData
        '
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Location = New System.Drawing.Point(12, 98)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.Size = New System.Drawing.Size(439, 197)
        Me.DGVData.TabIndex = 2
        '
        'cmdQuery
        '
        Me.cmdQuery.Location = New System.Drawing.Point(379, 14)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.Size = New System.Drawing.Size(71, 77)
        Me.cmdQuery.TabIndex = 1
        Me.cmdQuery.Text = "Run Query"
        Me.cmdQuery.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(12, 13)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(356, 79)
        Me.txtQuery.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(463, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INSERT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cbAdmin)
        Me.GroupBox1.Controls.Add(Me.cbActive)
        Me.GroupBox1.Controls.Add(Me.txtWebsite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Member"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(183, 222)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cbAdmin
        '
        Me.cbAdmin.AutoSize = True
        Me.cbAdmin.Location = New System.Drawing.Point(351, 44)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(60, 17)
        Me.cbAdmin.TabIndex = 9
        Me.cbAdmin.Text = "Admin"
        Me.cbAdmin.UseVisualStyleBackColor = True
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Checked = True
        Me.cbActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbActive.Location = New System.Drawing.Point(351, 26)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(62, 17)
        Me.cbActive.TabIndex = 8
        Me.cbActive.Text = "Active"
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(31, 159)
        Me.txtWebsite.MaxLength = 255
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(396, 20)
        Me.txtWebsite.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Website:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(31, 101)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(174, 20)
        Me.txtEmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(183, 47)
        Me.txtPass.MaxLength = 30
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(144, 20)
        Me.txtPass.TabIndex = 3
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(31, 47)
        Me.txtUser.MaxLength = 30
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(144, 20)
        Me.txtUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cbxThreads)
        Me.TabPage3.Controls.Add(Me.cmdRun)
        Me.TabPage3.Controls.Add(Me.cbxUsers)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(463, 301)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "COMBO"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cbxThreads
        '
        Me.cbxThreads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxThreads.FormattingEnabled = True
        Me.cbxThreads.Location = New System.Drawing.Point(192, 35)
        Me.cbxThreads.Name = "cbxThreads"
        Me.cbxThreads.Size = New System.Drawing.Size(178, 216)
        Me.cbxThreads.TabIndex = 2
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(7, 7)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(78, 22)
        Me.cmdRun.TabIndex = 1
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'cbxUsers
        '
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(7, 35)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(178, 21)
        Me.cbxUsers.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lvTables)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(463, 301)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "LISTVIEW"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lvTables
        '
        Me.lvTables.HideSelection = False
        Me.lvTables.Location = New System.Drawing.Point(13, 15)
        Me.lvTables.MultiSelect = False
        Me.lvTables.Name = "lvTables"
        Me.lvTables.Size = New System.Drawing.Size(140, 157)
        Me.lvTables.TabIndex = 0
        Me.lvTables.UseCompatibleStateImageBehavior = False
        Me.lvTables.View = System.Windows.Forms.View.Details
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(463, 301)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "BACKUP"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmdBackup)
        Me.GroupBox2.Controls.Add(Me.txtBakFile)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 288)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Backup Database"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Backup File Name:"
        '
        'cmdBackup
        '
        Me.cmdBackup.Location = New System.Drawing.Point(181, 257)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.Size = New System.Drawing.Size(91, 25)
        Me.cmdBackup.TabIndex = 2
        Me.cmdBackup.Text = "Run Backup"
        Me.cmdBackup.UseVisualStyleBackColor = True
        '
        'txtBakFile
        '
        Me.txtBakFile.Location = New System.Drawing.Point(7, 36)
        Me.txtBakFile.Name = "txtBakFile"
        Me.txtBakFile.Size = New System.Drawing.Size(221, 20)
        Me.txtBakFile.TabIndex = 1
        Me.txtBakFile.Text = "BACKUP.BAK"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sfdBackup
        '
        Me.sfdBackup.FileName = "Backup.BAK"
        Me.sfdBackup.Filter = "BAK Files|*.BAK"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(505, 362)
        Me.Controls.Add(Me.tcSQL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tcSQL.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcSQL As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DGVData As System.Windows.Forms.DataGridView
    Friend WithEvents cmdQuery As System.Windows.Forms.Button
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cbAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents cbActive As System.Windows.Forms.CheckBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cbxThreads As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents cbxUsers As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lvTables As System.Windows.Forms.ListView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents sfdBackup As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdBackup As System.Windows.Forms.Button
    Friend WithEvents txtBakFile As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
