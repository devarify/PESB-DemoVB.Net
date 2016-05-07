Imports System.Data.SqlClient

Module Module_koneksiSQL
    Public sqlConn As SqlConnection
    Public sqlcmd As SqlCommand
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public rd As SqlDataReader
    Public sql As String '=nothing

    Public Sub setconnection()
        sqlConn = New SqlConnection("integrated security=SSPI;persist security info=false;Initial Catalog=db_PSB_Setiamanah;Data Source=PC-1056\SQLEXPRESS")
        Try
            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
            End If

        Catch ex As Exception
            sqlConn.Close()

        End Try

    End Sub
    Public Sub CloseConn()
        If Not IsNothing(sqlConn) Then
            sqlConn.Close()
            sqlConn = Nothing
        End If
    End Sub

End Module