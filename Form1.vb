Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call ok()
    End Sub
    Private Sub ok()
        Call constring()
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dr As OleDb.OleDbDataReader
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()

            cmd.CommandText = "Select * from tbllogin where Username ='" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "' "
            da.SelectCommand = cmd

            dr = cmd.ExecuteReader
            If dr.HasRows Then


                frmMain.Show()
                Me.Hide()

                dr.Close()
            Else
                MsgBox("Invalid Username and Password", vbOK + vbInformation, "Admin")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
            dr.Close()
            cmd.Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
        Application.Exit()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
