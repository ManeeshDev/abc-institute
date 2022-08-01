Imports System.Data.SqlClient

Module Module1
    Private Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MP_ Works\My Dev Projects\Vb .net\abc-institute\ABC Institute\ABC_Student_System.mdf;Integrated Security=True;Connect Timeout=30"
    Public cn As SqlConnection

    Public Sub StD()
        cn = New SqlConnection(ConnectionString)
    End Sub

End Module