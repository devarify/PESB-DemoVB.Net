Imports System.Data
Imports System.Data.SqlClient
Public Class Form_admin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Public Function computeHash(ByVal textToHash As String) As String
        '//dibawah ini adalah sebuah fungsi untuk mengenkripsi text dengan metode MD5
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Bytes() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(textToHash))
        Dim s As String = Nothing
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function

    Private Sub InputData()

        Module_koneksiSQL.setconnection()
        da = New SqlClient.SqlDataAdapter("select username from Tlogin where username='" & txtUser.Text & "'", Module_koneksiSQL.sqlConn)
        Dim tbuser As New DataTable
        tbuser.Clear()
        da.Fill(tbuser)
        Module_koneksiSQL.setconnection()
        If txtnamauser.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong", MsgBoxStyle.Information, "Warning")
            txtnamauser.Focus()
        ElseIf txtUser.Text = "" Then
            MsgBox("Username Tidak Boleh Kosong", MsgBoxStyle.Information, "Warning")
            txtUser.Focus()
        ElseIf txtPass.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong", MsgBoxStyle.Information, "Warning")
            txtPass.Focus()
        ElseIf tbuser.Rows.Count > 0 Then
            MsgBox("username sudah ada harap masukkan username yang baru", MsgBoxStyle.OkOnly, "Save Record Gagal")
            txtUser.Focus()
        Else
            'Try
            '    Module_koneksiSQL.setconnection()
            '    sqlcmd = New SqlCommand()
            '    sqlcmd.CommandText = String.Format("INSERT INTO Tlogin (nama, username, password) values ('{0}','{1}','{2}')", _
            '                                     txtnamauser.Text, txtUser.Text, computeHash(txtPass.Text), sqlConn)
            '    sqlcmd.Connection = sqlConn
            '    sqlcmd.ExecuteNonQuery()
            '    MsgBox(" Data siswa yang bernama " & txtnamauser.Text & " Berhasil Disimpan")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        InputData()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Form_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
