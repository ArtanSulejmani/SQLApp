Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=MINECRAFT\SQLEXPRESS;Database=SQLApps;User=sa;Pwd=Password1;"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()

            SQLCmd = New SqlCommand(Query, SQLCon)

            ' LOAD SQL RECORDS FOR DATAGRID
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)

            ' READ DIRECTLY FROM THE DATABASE
            'Dim R As SqlDataReader = SQLCmd.ExecuteReader

            'While R.Read
            'MsgBox(R.GetName(0) & ": " & R(0))
            'End While

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub

    Public Sub AddMember(Username As String, Password As String, Email As String, Website As String, IsActive As Integer, IsAdmin As Integer)
        Try
            Dim strInsert As String = "INSERT INTO MEMBERS (username,password,email,website,active,admin) " & _
                                      "VALUES (" & _
                                      "'" & Username & "'," & _
                                      "'" & Password & "'," & _
                                      "'" & Email & "'," & _
                                      "'" & Website & "'," & _
                                      "'" & IsActive & "'," & _
                                      "'" & IsAdmin & "') "

            SQLCon.Open()
            SQLCmd = New SqlCommand(strInsert, SQLCon)

            SQLCmd.ExecuteNonQuery()

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function DataUpdate(Command As String) As Integer
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Command, SQLCon)

            Dim ChangeCount As Integer = SQLCmd.ExecuteNonQuery()

            SQLCon.Close()

            Return ChangeCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function
End Class
