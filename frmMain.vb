Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibrarySystemDBDataSet.tblreturnbooks' table. You can move, or remove it, as needed.
        Me.tblreturnbooksTableAdapter.Fill(Me.LibrarySystemDBDataSet.tblreturnbooks)
        'TODO: This line of code loads data into the 'LibrarySystemDBDataSet.tblborrowbooks' table. You can move, or remove it, as needed.
        Me.tblborrowbooksTableAdapter.Fill(Me.LibrarySystemDBDataSet.tblborrowbooks)
        Call constring()
        Call datagridviewforaddbook()
        Call datagridviewforbookdetails()
        Call dgvmembership()
        Call dgvborrowlist()
        Call addbook_disable_function()
        Call membership_disable_function()
        Call dgvreturnlist()
        btnborrow.Enabled = False
        btnreturn.Enabled = False
        DateTimePickerborrow.Text = ""
        DateTimePickerreturn.Text = ""


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtbookid.Text = "" Or txttitle.Text = "" Or txtauthor.Text = "" Or txtsubject.Text = "" Or txtpublisher.Text = "" Or txtstatus.Text = "" Then
                MsgBox("All fields required!", vbOK + vbInformation, "Library System")
            Else
                Dim cmd As New OleDb.OleDbCommand
                Dim da As New OleDb.OleDbDataAdapter
                Dim dr As OleDb.OleDbDataReader
                cmd.Connection = New OleDb.OleDbConnection(cs)
                cmd.Connection.Open()
                cmd.CommandText = "Select * from tblbooks where bookID = '" & txtbookid.Text & "'"
                da.SelectCommand = cmd
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Book ID already exist!", vbOK + vbInformation, "Library System")
                    txtbookid.Text = ""
                    txttitle.Text = ""
                    txtauthor.Text = ""
                    txtsubject.Text = ""
                    txtpublisher.Text = ""
                    txtstatus.Text = ""

                Else
                    Call ok()
                End If
                dr.Close()
                cmd.Connection.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try
    End Sub


    Private Sub ok()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "INSERT INTO [tblbooks] ([bookID],[title],[author],[subject],[publisher],[status]) VALUES ('" & txtbookid.Text & "','" & txttitle.Text & "','" & txtauthor.Text & "','" & txtsubject.Text & "','" & txtpublisher.Text & "', '" & txtstatus.Text & "')"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Saved!", vbOKOnly + vbInformation, "Library System")
        txtbookid.Text = ""
        txttitle.Text = ""
        txtauthor.Text = ""
        txtsubject.Text = ""
        txtpublisher.Text = ""
        txtstatus.Text = ""
        Call datagridviewforaddbook()
        Call datagridviewforbookdetails()
    End Sub
    Private Sub datagridviewforaddbook()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "Select * from tblbooks"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        Dim cb = New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Fill(dt)
        DataGridViewaddbooks.DataSource = dt.DefaultView
        DataGridViewaddbooks.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        cmd.Connection.Close()

    End Sub
    Private Sub datagridviewforbookdetails()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "Select * from tblbooks"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        Dim cb = New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Fill(dt)
        DataGridViewbookdetails.DataSource = dt.DefaultView
        DataGridViewbookdetails.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        cmd.Connection.Close()

    End Sub
    Private Sub dgvmembership()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "Select * from tblmembership"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        Dim cb = New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Fill(dt)
        dgvmembershipoutput.DataSource = dt.DefaultView
        dgvmembershipoutput.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        cmd.Connection.Close()

    End Sub
    Private Sub dgvborrowlist()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "Select * from tblborrowbooks"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        Dim cb = New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Fill(dt)
        dgvborrowlistoutput.DataSource = dt.DefaultView
        dgvborrowlistoutput.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        cmd.Connection.Close()

    End Sub
    Private Sub dgvreturnlist()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "Select * from tblreturnbooks"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        Dim cb = New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Fill(dt)
        dgvreturnlistoutput.DataSource = dt.DefaultView
        dgvreturnlistoutput.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        cmd.Connection.Close()

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnsavemembership.Click
        Try
            If txtlrn.Text = "" Or txtfullname.Text = "" Or txtyearsection.Text = "" Or txtbirthdate.Text = "" Or txtaddress.Text = "" Then
                MsgBox("All fields required!", vbOK + vbInformation, "Library System")
            Else

                Dim cmd As New OleDb.OleDbCommand
                Dim da As New OleDb.OleDbDataAdapter
                Dim dr As OleDb.OleDbDataReader
                cmd.Connection = New OleDb.OleDbConnection(cs)
                cmd.Connection.Open()

                cmd.CommandText = "Select * from tblmembership where LRN = '" & txtlrn.Text & "'"
                da.SelectCommand = cmd

                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("LRN already exist!", vbOK + vbInformation, "Library System")
                    txtlrn.Text = ""
                    txtfullname.Text = ""
                    txtyearsection.Text = ""
                    txtbirthdate.Text = ""
                    txtaddress.Text = ""

                    dr.Close()
                    cmd.Connection.Close()
                Else
                    Call ok_for_membership()
                End If
                dr.Close()
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try
    End Sub
    Private Sub ok_for_membership()
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "INSERT INTO [tblmembership] ([lrn],[member_name],[yearsection],[birthdate],[address]) VALUES ('" & txtlrn.Text & "','" & txtfullname.Text & "','" & txtyearsection.Text & "','" & txtbirthdate.Text & "','" & txtaddress.Text & "')"
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Saved!", vbOKOnly + vbInformation, "Library System")

        txtlrn.Text = ""
        txtfullname.Text = ""
        txtyearsection.Text = ""
        txtbirthdate.Text = ""
        txtaddress.Text = ""

        Call dgvmembership()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbookdetails.TextChanged
        Try


            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()
            cmd.CommandText = "Select * from tblbooks where (bookID LIKE '%" & txtsearchbookdetails.Text & "%')" &
                        "OR (title LIKE '%" & txtsearchbookdetails.Text & "%')" &
                      "OR (author LIKE '%" & txtsearchbookdetails.Text & "%')" &
                       "OR (subject LIKE '%" & txtsearchbookdetails.Text & "%')" &
                       "OR (publisher LIKE '%" & txtsearchbookdetails.Text & "%')" &
                    "OR (status LIKE '%" & txtsearchbookdetails.Text & "%')"
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            dt = New DataTable
            da.Fill(dt)
            DataGridViewbookdetails.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Private Sub addbook_disable_function()
        btnsave.Enabled = True
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub
    Private Sub membership_disable_function()
        btnsavemembership.Enabled = True
        btneditmembership.Enabled = True
        btnupdatemembership.Enabled = False
        btndeletemembership.Enabled = False
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dr As OleDb.OleDbDataReader

            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()

            cmd.CommandText = "Select * from tblbooks where bookID = '" & txtbookid.Text & "' "
            da.SelectCommand = cmd

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    txttitle.Text = dr.Item("title")
                    txtauthor.Text = dr.Item("author")
                    txtsubject.Text = dr.Item("subject")
                    txtpublisher.Text = dr.Item("publisher")
                    txtstatus.Text = dr.Item("status")
                    btnsave.Enabled = False
                    btnedit.Enabled = False
                    btnupdate.Enabled = True
                    btndelete.Enabled = True

                End While

            Else
                MsgBox("Please Input valid Book ID!", vbOK + vbInformation, "Library System")
            End If
            dr.Close()
            cmd.Connection.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "UPDATE tblbooks SET title ='" & txttitle.Text & "', author ='" & txtauthor.Text & "',subject='" & txtsubject.Text & "', publisher ='" & txtpublisher.Text & "', status='" & txtstatus.Text & "' WHERE  bookID ='" & txtbookid.Text & "' "
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        MsgBox("Book information updated!", vbOK + vbInformation, "Library System")
        txtbookid.Text = ""
        txttitle.Text = ""
        txtauthor.Text = ""
        txtsubject.Text = ""
        txtpublisher.Text = ""
        txtstatus.Text = ""
        Call addbook_disable_function()
        Call datagridviewforaddbook()
        cmd.Connection.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim confirm As String
            confirm = MsgBox("Are you sure you want to delete records?", vbYesNo + vbInformation, "Deletion")

            If confirm = vbYes Then


                Dim cmd As New OleDb.OleDbCommand
                Dim da As New OleDb.OleDbDataAdapter
                cmd.Connection = New OleDb.OleDbConnection(cs)
                cmd.Connection.Open()
                cmd.CommandText = "Delete from tblbooks where bookID = '" & txtbookid.Text & "' "
                da.SelectCommand = cmd
                cmd.ExecuteNonQuery()
                MsgBox("Records Deleted!", vbOK + vbInformation, "Library System")
                txtbookid.Text = ""
                txttitle.Text = ""
                txtauthor.Text = ""
                txtsubject.Text = ""
                txtpublisher.Text = ""
                txtstatus.Text = ""
                Call datagridviewforaddbook()
                Call addbook_disable_function()
                cmd.Connection.Close()
            Else
                txtbookid.Text = ""
                txttitle.Text = ""
                txtauthor.Text = ""
                txtsubject.Text = ""
                txtpublisher.Text = ""
                txtstatus.Text = ""
                Call datagridviewforaddbook()
                Call addbook_disable_function()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btneditmembership_Click(sender As Object, e As EventArgs) Handles btneditmembership.Click

        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dr As OleDb.OleDbDataReader

            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()

            cmd.CommandText = "Select * from tblmembership where lrn = '" & txtlrn.Text & "' "
            da.SelectCommand = cmd
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    txtlrn.Text = dr.Item("lrn")
                    txtfullname.Text = dr.Item("member_name")
                    txtyearsection.Text = dr.Item("yearsection")
                    txtbirthdate.Text = dr.Item("birthdate")
                    txtaddress.Text = dr.Item("address")

                    btnsavemembership.Enabled = False

                    btnupdatemembership.Enabled = True
                    btndeletemembership.Enabled = True

                End While

            Else
                MsgBox("Please Input valid LRN!", vbOK + vbInformation, "Library System")
            End If
            dr.Close()
            cmd.Connection.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdatemembership_Click(sender As Object, e As EventArgs) Handles btnupdatemembership.Click
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        cmd.Connection = New OleDb.OleDbConnection(cs)
        cmd.Connection.Open()
        cmd.CommandText = "UPDATE tblmembership SET member_name ='" & txtfullname.Text & "', yearsection ='" & txtyearsection.Text & "',birthdate='" & txtbirthdate.Text & "', address ='" & txtaddress.Text & "' WHERE  lrn ='" & txtlrn.Text & "' "
        da.SelectCommand = cmd
        cmd.ExecuteNonQuery()
        MsgBox("Membership information updated!", vbOK + vbInformation, "Library System")
        txtlrn.Text = ""
        txtfullname.Text = ""
        txtyearsection.Text = ""
        txtbirthdate.Text = ""
        txtaddress.Text = ""

        Call dgvmembership()
        Call membership_disable_function()

        cmd.Connection.Close()
    End Sub

    Private Sub btndeletemembership_Click(sender As Object, e As EventArgs) Handles btndeletemembership.Click
        Try
            Dim confirm As String
            confirm = MsgBox("Are you sure you want to delete records?", vbYesNo + vbInformation, "Library System")

            If confirm = vbYes Then


                Dim cmd As New OleDb.OleDbCommand
                Dim da As New OleDb.OleDbDataAdapter
                cmd.Connection = New OleDb.OleDbConnection(cs)
                cmd.Connection.Open()
                cmd.CommandText = "Delete from tblmembership where lrn = '" & txtlrn.Text & "' "
                da.SelectCommand = cmd
                cmd.ExecuteNonQuery()
                MsgBox("Records Deleted!", vbOK + vbInformation, "Library System")
                txtlrn.Text = ""
                txtfullname.Text = ""
                txtyearsection.Text = ""
                txtbirthdate.Text = ""
                txtaddress.Text = ""
                Call dgvmembership()
                Call membership_disable_function()
                cmd.Connection.Close()
            Else
                txtlrn.Text = ""
                txtfullname.Text = ""
                txtyearsection.Text = ""
                txtbirthdate.Text = ""
                txtaddress.Text = ""
                Call dgvmembership()
                Call membership_disable_function()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePickerborrow_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerborrow.ValueChanged
        txtborrowdateBL.Text = DateTimePickerborrow.Text
    End Sub

    Private Sub DateTimePickerreturn_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerreturn.ValueChanged
        txtreturndateBL.Text = DateTimePickerreturn.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostatusBL.SelectedIndexChanged

        If txtlrnBL.Text = "" Or txtbookidBL.Text = "" Then
            MsgBox("All fields required", vbOK + vbInformation, "Library System")
        Else
            If cbostatusBL.Text = "Borrowed" Then
                btnborrow.Enabled = True
                btnreturn.Enabled = False
            Else
                txtreturndateBL.Text = ""
                btnborrow.Enabled = False
                btnreturn.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnborrow_Click(sender As Object, e As EventArgs) Handles btnborrow.Click
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()
            cmd.CommandText = "INSERT INTO [tblborrowbooks] ([LRN],[fullname],[bookID],[title],[borrow_date],[return_date],[status]) VALUES ('" & txtlrnBL.Text & "','" & txtfullnameBL.Text & "','" & txtbookidBL.Text & "','" & txttitleBL.Text & "','" & txtborrowdateBL.Text & "','" & txtreturndateBL.Text & "','" & cbostatusBL.Text & "')"
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MsgBox("Please return the book on or before the return date. Thank you and enjoy reading!", vbOK + vbInformation, "Library System")
            txtlrnBL.Text = ""
            txtfullnameBL.Text = ""
            txtbookidBL.Text = ""
            txttitleBL.Text = ""
            txtborrowdateBL.Text = ""
            txtreturndateBL.Text = ""
            cbostatusBL.Text = ""

            Call dgvborrowlist()
            cmd.Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try
        'TODO: This line of code loads data into the 'LibrarySystemDBDataSet.tblreturnbooks' table. You can move, or remove it, as needed.
        Me.tblreturnbooksTableAdapter.Fill(Me.LibrarySystemDBDataSet.tblreturnbooks)
        'TODO: This line of code loads data into the 'LibrarySystemDBDataSet.tblborrowbooks' table. You can move, or remove it, as needed.
        Me.tblborrowbooksTableAdapter.Fill(Me.LibrarySystemDBDataSet.tblborrowbooks)
    End Sub

    Private Sub txtlrnBL_TextChanged(sender As Object, e As EventArgs) Handles txtlrnBL.TextChanged
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dr As OleDb.OleDbDataReader

            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()

            cmd.CommandText = "Select * from tblmembership where lrn = '" & txtlrnBL.Text & "' "
            da.SelectCommand = cmd

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    txtfullnameBL.Text = dr.Item("member_name")


                End While

            Else
                txtfullnameBL.Text = ""
            End If
            dr.Close()
            cmd.Connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()
            cmd.CommandText = "Select * from tblborrowbooks where (lrn LIKE '%" & txtlrnBL.Text & "%')"
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            dt = New DataTable
            da.Fill(dt)
            dgvborrowlistoutput.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dr As OleDb.OleDbDataReader

            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()

            cmd.CommandText = "Select * from tblborrowbooks where lrn = '" & txtlrnBL.Text & "' "
            da.SelectCommand = cmd

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    txtfullnameBL.Text = dr.Item("fullname")
                    txtbookidBL.Text = dr.Item("bookID")
                    txttitleBL.Text = dr.Item("title")
                    txtborrowdateBL.Text = dr.Item("borrow_date")
                    txtreturndateBL.Text = dr.Item("return_date")

                End While

            Else

            End If
            dr.Close()
            cmd.Connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtbookidBL_TextChanged(sender As Object, e As EventArgs) Handles txtbookidBL.TextChanged
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dr As OleDb.OleDbDataReader

            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()

            cmd.CommandText = "Select * from tblbooks where bookID = '" & txtbookidBL.Text & "' "
            da.SelectCommand = cmd

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    txttitleBL.Text = dr.Item("title")


                End While

            Else
                txttitleBL.Text = ""
            End If
            dr.Close()
            cmd.Connection.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()
            cmd.CommandText = "INSERT INTO [tblreturnbooks] ([LRN],[fullname],[bookID],[title],[borrow_date],[return_date],[status]) VALUES ('" & txtlrnBL.Text & "','" & txtfullnameBL.Text & "','" & txtbookidBL.Text & "','" & txttitleBL.Text & "','" & txtborrowdateBL.Text & "','" & txtreturndateBL.Text & "','" & cbostatusBL.Text & "')"
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MsgBox("Thank you for returning the book. Please Come again!", vbOK + vbInformation, "Library System")
            Call dgvreturnlist()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()
            cmd.CommandText = "Delete from tblborrowbooks where lrn = '" & txtlrnBL.Text & "' and bookid ='" & txtbookidBL.Text & "'  "
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            txtlrnBL.Text = ""
            txtfullnameBL.Text = ""
            txtbookidBL.Text = ""
            txttitleBL.Text = ""
            txtborrowdateBL.Text = ""
            txtreturndateBL.Text = ""
            cbostatusBL.Text = ""
            cmd.Connection.Close()
            Call dgvborrowlist()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'TODO: This line of code loads data into the 'LibrarySystemDBDataSet.tblreturnbooks' table. You can move, or remove it, as needed.
        Me.tblreturnbooksTableAdapter.Fill(Me.LibrarySystemDBDataSet.tblreturnbooks)
        'TODO: This line of code loads data into the 'LibrarySystemDBDataSet.tblborrowbooks' table. You can move, or remove it, as needed.
        Me.tblborrowbooksTableAdapter.Fill(Me.LibrarySystemDBDataSet.tblborrowbooks)
    End Sub

    Private Sub txtsearchreturnlist_TextChanged(sender As Object, e As EventArgs) Handles txtsearchreturnlist.TextChanged
        Try


            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            cmd.Connection = New OleDb.OleDbConnection(cs)
            cmd.Connection.Open()
            cmd.CommandText = "Select * from tblreturnbooks where (lrn LIKE '%" & txtsearchreturnlist.Text & "%')" &
                        "OR (title LIKE '%" & txtsearchreturnlist.Text & "%')" &
                      "OR (fullname LIKE '%" & txtsearchreturnlist.Text & "%')" &
                       "OR (bookID LIKE '%" & txtsearchreturnlist.Text & "%')"
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            dt = New DataTable
            da.Fill(dt)
            dgvreturnlistoutput.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtbirthdate_ValueChanged(sender As Object, e As EventArgs) Handles txtbirthdate.ValueChanged

    End Sub

    Private Sub DataGridViewbookdetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewbookdetails.CellContentClick

    End Sub
End Class