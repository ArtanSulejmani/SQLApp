Public Class Form1
    Dim SQL As New SQLControl

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub cmdQuery_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuery.Click
        If txtQuery.Text <> "" Then
            If SQL.HasConnection = True Then
                SQL.RunQuery(txtQuery.Text)

                If SQL.SQLDataset.Tables.Count > 0 Then
                    DGVData.DataSource = SQL.SQLDataset.Tables(0)
                End If
            End If
        End If
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        ' QUERY FOR USER
        SQL.RunQuery("SELECT * FROM members WHERE members.username = '" & txtUser.Text & "' ")

        If SQL.SQLDataset.Tables(0).Rows.Count > 0 Then
            MsgBox("User already exists!")
            Exit Sub
        Else
            CreateUser()

            ' CLEAN UP FIELDS
            txtUser.Clear()
            txtPass.Clear()
            txtEmail.Clear()
            txtWebsite.Clear()
            cbActive.Checked = True
            cbAdmin.Checked = False
        End If
    End Sub

    Public Sub CreateUser()
        If Len(txtUser.Text) >= 6 And Len(txtPass.Text) >= 8 Then
            ' Get Checkbox Values
            Dim intActive As Integer
            Dim intAdmin As Integer
            If cbActive.Checked = True Then intActive = 1 Else intActive = 0
            If cbAdmin.Checked = True Then intAdmin = 1 Else intAdmin = 0

            ' ADD MEMBER TO DATABASE
            SQL.AddMember(txtUser.Text, txtPass.Text, txtEmail.Text, txtWebsite.Text, intActive, intAdmin)

        Else
            MsgBox("Username or Password is too short!")
            Exit Sub
        End If
    End Sub

    Private Sub cmdRun_Click(sender As System.Object, e As System.EventArgs) Handles cmdRun.Click
        SQL.RunQuery("SELECT username FROM members")
        If SQL.SQLDataset.Tables.Count > 0 Then

            'MsgBox(SQL.SQLDataset.Tables(0).Rows(0).Item("username"))

            For i = 0 To SQL.SQLDataset.Tables(0).Rows.Count - 1
                cbxUsers.Items.Add(SQL.SQLDataset.Tables(0).Rows(i).Item("username"))
            Next
        End If
    End Sub

    Private Sub cbxUsers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxUsers.SelectedIndexChanged
        cbxThreads.Items.Clear()

        SQL.RunQuery("SELECT forumThreads.topic FROM members INNER JOIN forumThreads ON members.username = forumThreads.author WHERE members.username = '" & cbxUsers.SelectedItem & "' ")

        MsgBox("SELECT forumThreads.topic FROM members INNER JOIN forumThreads ON members.username = forumThreads.author WHERE members.username = '" & cbxUsers.SelectedItem & "' ")

        If SQL.SQLDataset.Tables.Count > 0 Then
            For i = 0 To SQL.SQLDataset.Tables(0).Rows.Count - 1
                cbxThreads.Items.Add(SQL.SQLDataset.Tables(0).Rows(i).Item("topic"))
            Next
        End If
    End Sub

    Private Sub tcSQL_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcSQL.SelectedIndexChanged
        If tcSQL.SelectedIndex = 3 Then
            If SQL.HasConnection = True Then
                SQL.RunQuery("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ")

                lvTables.Columns.Add("Tables")
                For r = 0 To SQL.SQLDataset.Tables(0).Rows.Count - 1
                    lvTables.Items.Add(SQL.SQLDataset.Tables(0).Rows(r).Item("TABLE_NAME"))
                Next
            End If
        End If
    End Sub

    Private Sub cmdBackup_Click(sender As System.Object, e As System.EventArgs) Handles cmdBackup.Click
        If SQL.HasConnection = True Then
            SQL.DataUpdate("BACKUP DATABASE SQLApps " & _
                           "TO DISK = 'C:\" & txtBakFile.Text & "' " & _
                           "   WITH FORMAT," & _
                           "   MEDIANAME = 'SQLAppsBackups'," & _
                           "   NAME = 'Full Backup of SQLApps';")
        End If
    End Sub
End Class
