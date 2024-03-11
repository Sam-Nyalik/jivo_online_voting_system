Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Connection String
    Dim connectionString As String = "server=localhost;user=root;password=;database=jivo_voting_system"

    ' MySQL Connection
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)

    ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Load data from MySQL database on form load
    ' LoadData()
    ' End Sub

    ' Private Sub LoadData()
    ' Try
    ' Open Connection
    ' connection.Open()

    ' SQL Query
    ' Dim query As String = "SELECT * FROM constituencies"

    ' MySQL Command
    ' Dim command As MySqlCommand = New MySqlCommand(query, connection)

    ' MySQL Data Reader
    ' Dim reader As MySqlDataReader = command.ExecuteReader()

    ' Clear any existing items in your controls (e.g., DataGridView)
    ' DataGridView1.Rows.Clear()

    ' Loop through the data and populate controls (e.g., DataGridView)
    ' While reader.Read()
    ' Example: Add data to DataGridView
    ' DataGridView1.Rows.Add(reader("column1"), reader("column2"), ...)
    '  End While

    ' Close Data Reader
    ' reader.Close()

    ' Catch ex As Exception
    ' MessageBox.Show(ex.Message)
    ' Finally
    ' Close Connection
    ' connection.Close()
    ' End Try
    ' End Sub


    ' VOTER LOGIN REDIRECT
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        openVotersLoginSection()
    End Sub

    Private Sub openVotersLoginSection()
        Dim voter_login_page As New Voter_Login()
        voter_login_page.Show()
    End Sub

    ' ADMIN LOGIN REDIRECT
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        openAdminLoginSection()
    End Sub

    Private Sub openAdminLoginSection()
        Dim admin_login_page As New Admin_Login()
        admin_login_page.Show()
    End Sub
End Class
