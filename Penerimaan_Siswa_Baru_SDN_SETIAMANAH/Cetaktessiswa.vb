Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.Sql
Public Class Cetaktessiswa
    Private Sub Cetaktessiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatatesDataSet.Tdatates' table. You can move, or remove it, as needed.
        Me.TdatatesTableAdapter.Fill(Me.DatatesDataSet.Tdatates)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module_koneksiSQL.setconnection()
        Dim strTemp = ""
        If txtcarinopend.Text <> "" Then
            strTemp = " AND [no_formulir] LIKE '%" & txtcarinopend.Text & "%'"


        End If
        If txtcarinama.Text <> "" Then
            strTemp += " AND [nama_siswa] LIKE '%" & txtcarinama.Text & "%'"

        End If
        da = New SqlDataAdapter("Select * FROM [Tdatates] where (1=1)" & strTemp, sqlConn)
        Dim ds As DataSet = New DataSet
        DatatesDataSet.Clear()

        da.Fill(DatatesDataSet.Tdatates)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class