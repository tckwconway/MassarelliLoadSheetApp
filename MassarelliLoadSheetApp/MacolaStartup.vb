Imports System.Environment
Imports System.Data.SqlClient

Module MacolaStartup

    Friend cn As SqlConnection
    Public Sub MacStartup()

        Dim ConnStr As String = "Data Source=" & My.Settings.DefaultServer & ";Initial Catalog=" & My.Settings.DefaultDB & ";Persist Security Info=True;User ID=sa;Password=C@sT1nST0nE"
        cn = New SqlConnection
        cn.ConnectionString = ConnStr
        cn.Open()

    End Sub


End Module
