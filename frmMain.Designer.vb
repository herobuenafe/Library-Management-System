<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblreturnbooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarySystemDBDataSet = New LibrarySystem.LibrarySystemDBDataSet()
        Me.tblborrowbooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewbookdetails = New System.Windows.Forms.DataGridView()
        Me.txtsearchbookdetails = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvborrowlistoutput = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbostatusBL = New System.Windows.Forms.ComboBox()
        Me.txtreturndateBL = New System.Windows.Forms.TextBox()
        Me.txtborrowdateBL = New System.Windows.Forms.TextBox()
        Me.DateTimePickerreturn = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerborrow = New System.Windows.Forms.DateTimePicker()
        Me.txtlrnBL = New System.Windows.Forms.TextBox()
        Me.txtfullnameBL = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.btnborrow = New System.Windows.Forms.Button()
        Me.txtbookidBL = New System.Windows.Forms.TextBox()
        Me.txttitleBL = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtsearchreturnlist = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvreturnlistoutput = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.dgvmembershipoutput = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndeletemembership = New System.Windows.Forms.Button()
        Me.btnupdatemembership = New System.Windows.Forms.Button()
        Me.btneditmembership = New System.Windows.Forms.Button()
        Me.btnsavemembership = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtyearsection = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.txtlrn = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtstatus = New System.Windows.Forms.ComboBox()
        Me.DataGridViewaddbooks = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblborrowbooksTableAdapter = New LibrarySystem.LibrarySystemDBDataSetTableAdapters.tblborrowbooksTableAdapter()
        Me.tblreturnbooksTableAdapter = New LibrarySystem.LibrarySystemDBDataSetTableAdapters.tblreturnbooksTableAdapter()
        CType(Me.tblreturnbooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarySystemDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblborrowbooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewbookdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvborrowlistoutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvreturnlistoutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvmembershipoutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewaddbooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblreturnbooksBindingSource
        '
        Me.tblreturnbooksBindingSource.DataMember = "tblreturnbooks"
        Me.tblreturnbooksBindingSource.DataSource = Me.LibrarySystemDBDataSet
        '
        'LibrarySystemDBDataSet
        '
        Me.LibrarySystemDBDataSet.DataSetName = "LibrarySystemDBDataSet"
        Me.LibrarySystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblborrowbooksBindingSource
        '
        Me.tblborrowbooksBindingSource.DataMember = "tblborrowbooks"
        Me.tblborrowbooksBindingSource.DataSource = Me.LibrarySystemDBDataSet
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-11, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 122)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1081, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(279, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(668, 77)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Library Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 139)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1158, 425)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewbookdetails)
        Me.TabPage1.Controls.Add(Me.txtsearchbookdetails)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1150, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Book Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewbookdetails
        '
        Me.DataGridViewbookdetails.AllowUserToAddRows = False
        Me.DataGridViewbookdetails.AllowUserToDeleteRows = False
        Me.DataGridViewbookdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewbookdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewbookdetails.Location = New System.Drawing.Point(31, 69)
        Me.DataGridViewbookdetails.Name = "DataGridViewbookdetails"
        Me.DataGridViewbookdetails.ReadOnly = True
        Me.DataGridViewbookdetails.Size = New System.Drawing.Size(1089, 296)
        Me.DataGridViewbookdetails.TabIndex = 2
        '
        'txtsearchbookdetails
        '
        Me.txtsearchbookdetails.Location = New System.Drawing.Point(91, 20)
        Me.txtsearchbookdetails.Name = "txtsearchbookdetails"
        Me.txtsearchbookdetails.Size = New System.Drawing.Size(208, 32)
        Me.txtsearchbookdetails.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvborrowlistoutput)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1150, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Borrow List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvborrowlistoutput
        '
        Me.dgvborrowlistoutput.AllowUserToAddRows = False
        Me.dgvborrowlistoutput.AllowUserToDeleteRows = False
        Me.dgvborrowlistoutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvborrowlistoutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvborrowlistoutput.Location = New System.Drawing.Point(6, 6)
        Me.dgvborrowlistoutput.Name = "dgvborrowlistoutput"
        Me.dgvborrowlistoutput.ReadOnly = True
        Me.dgvborrowlistoutput.Size = New System.Drawing.Size(804, 375)
        Me.dgvborrowlistoutput.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbostatusBL)
        Me.GroupBox3.Controls.Add(Me.txtreturndateBL)
        Me.GroupBox3.Controls.Add(Me.txtborrowdateBL)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerreturn)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerborrow)
        Me.GroupBox3.Controls.Add(Me.txtlrnBL)
        Me.GroupBox3.Controls.Add(Me.txtfullnameBL)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.btnreturn)
        Me.GroupBox3.Controls.Add(Me.btnborrow)
        Me.GroupBox3.Controls.Add(Me.txtbookidBL)
        Me.GroupBox3.Controls.Add(Me.txttitleBL)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(816, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 353)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Borrow"
        '
        'cbostatusBL
        '
        Me.cbostatusBL.FormattingEnabled = True
        Me.cbostatusBL.Items.AddRange(New Object() {"Borrowed", "Returned", "Returned Late"})
        Me.cbostatusBL.Location = New System.Drawing.Point(101, 260)
        Me.cbostatusBL.Name = "cbostatusBL"
        Me.cbostatusBL.Size = New System.Drawing.Size(206, 33)
        Me.cbostatusBL.TabIndex = 35
        '
        'txtreturndateBL
        '
        Me.txtreturndateBL.Location = New System.Drawing.Point(101, 221)
        Me.txtreturndateBL.Name = "txtreturndateBL"
        Me.txtreturndateBL.Size = New System.Drawing.Size(181, 32)
        Me.txtreturndateBL.TabIndex = 34
        '
        'txtborrowdateBL
        '
        Me.txtborrowdateBL.Location = New System.Drawing.Point(101, 181)
        Me.txtborrowdateBL.Name = "txtborrowdateBL"
        Me.txtborrowdateBL.Size = New System.Drawing.Size(181, 32)
        Me.txtborrowdateBL.TabIndex = 33
        '
        'DateTimePickerreturn
        '
        Me.DateTimePickerreturn.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePickerreturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerreturn.Location = New System.Drawing.Point(288, 221)
        Me.DateTimePickerreturn.Name = "DateTimePickerreturn"
        Me.DateTimePickerreturn.Size = New System.Drawing.Size(19, 32)
        Me.DateTimePickerreturn.TabIndex = 32
        '
        'DateTimePickerborrow
        '
        Me.DateTimePickerborrow.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePickerborrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerborrow.Location = New System.Drawing.Point(288, 181)
        Me.DateTimePickerborrow.Name = "DateTimePickerborrow"
        Me.DateTimePickerborrow.Size = New System.Drawing.Size(19, 32)
        Me.DateTimePickerborrow.TabIndex = 31
        '
        'txtlrnBL
        '
        Me.txtlrnBL.Location = New System.Drawing.Point(101, 31)
        Me.txtlrnBL.Name = "txtlrnBL"
        Me.txtlrnBL.Size = New System.Drawing.Size(206, 32)
        Me.txtlrnBL.TabIndex = 29
        '
        'txtfullnameBL
        '
        Me.txtfullnameBL.Location = New System.Drawing.Point(101, 68)
        Me.txtfullnameBL.Name = "txtfullnameBL"
        Me.txtfullnameBL.Size = New System.Drawing.Size(206, 32)
        Me.txtfullnameBL.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(58, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 25)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "LRN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Fullname"
        '
        'btnreturn
        '
        Me.btnreturn.Location = New System.Drawing.Point(218, 299)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(89, 33)
        Me.btnreturn.TabIndex = 2
        Me.btnreturn.Text = "&Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'btnborrow
        '
        Me.btnborrow.Location = New System.Drawing.Point(101, 299)
        Me.btnborrow.Name = "btnborrow"
        Me.btnborrow.Size = New System.Drawing.Size(89, 33)
        Me.btnborrow.TabIndex = 1
        Me.btnborrow.Text = "&Borrow"
        Me.btnborrow.UseVisualStyleBackColor = True
        '
        'txtbookidBL
        '
        Me.txtbookidBL.Location = New System.Drawing.Point(101, 105)
        Me.txtbookidBL.Name = "txtbookidBL"
        Me.txtbookidBL.Size = New System.Drawing.Size(206, 32)
        Me.txtbookidBL.TabIndex = 21
        '
        'txttitleBL
        '
        Me.txttitleBL.Location = New System.Drawing.Point(101, 143)
        Me.txttitleBL.Name = "txttitleBL"
        Me.txttitleBL.Size = New System.Drawing.Size(206, 32)
        Me.txttitleBL.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(37, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 25)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Book ID"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(57, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 25)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Title"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 25)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Borrow Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 25)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Return Date"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtsearchreturnlist)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.dgvreturnlistoutput)
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1150, 387)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Return List"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtsearchreturnlist
        '
        Me.txtsearchreturnlist.Location = New System.Drawing.Point(91, 20)
        Me.txtsearchreturnlist.Name = "txtsearchreturnlist"
        Me.txtsearchreturnlist.Size = New System.Drawing.Size(208, 32)
        Me.txtsearchreturnlist.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Search"
        '
        'dgvreturnlistoutput
        '
        Me.dgvreturnlistoutput.AllowUserToAddRows = False
        Me.dgvreturnlistoutput.AllowUserToDeleteRows = False
        Me.dgvreturnlistoutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvreturnlistoutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreturnlistoutput.Location = New System.Drawing.Point(28, 70)
        Me.dgvreturnlistoutput.Name = "dgvreturnlistoutput"
        Me.dgvreturnlistoutput.ReadOnly = True
        Me.dgvreturnlistoutput.Size = New System.Drawing.Size(1089, 296)
        Me.dgvreturnlistoutput.TabIndex = 29
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtbirthdate)
        Me.TabPage3.Controls.Add(Me.dgvmembershipoutput)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.txtaddress)
        Me.TabPage3.Controls.Add(Me.txtyearsection)
        Me.TabPage3.Controls.Add(Me.txtfullname)
        Me.TabPage3.Controls.Add(Me.txtlrn)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.label)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1150, 387)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Membership"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtbirthdate
        '
        Me.txtbirthdate.CustomFormat = "MM / dd / yyyy"
        Me.txtbirthdate.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtbirthdate.Location = New System.Drawing.Point(160, 225)
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.Size = New System.Drawing.Size(243, 33)
        Me.txtbirthdate.TabIndex = 31
        '
        'dgvmembershipoutput
        '
        Me.dgvmembershipoutput.AllowUserToAddRows = False
        Me.dgvmembershipoutput.AllowUserToDeleteRows = False
        Me.dgvmembershipoutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmembershipoutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmembershipoutput.Location = New System.Drawing.Point(552, 47)
        Me.dgvmembershipoutput.Name = "dgvmembershipoutput"
        Me.dgvmembershipoutput.ReadOnly = True
        Me.dgvmembershipoutput.Size = New System.Drawing.Size(573, 276)
        Me.dgvmembershipoutput.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndeletemembership)
        Me.GroupBox2.Controls.Add(Me.btnupdatemembership)
        Me.GroupBox2.Controls.Add(Me.btneditmembership)
        Me.GroupBox2.Controls.Add(Me.btnsavemembership)
        Me.GroupBox2.Location = New System.Drawing.Point(410, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 276)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'btndeletemembership
        '
        Me.btndeletemembership.Location = New System.Drawing.Point(20, 210)
        Me.btndeletemembership.Name = "btndeletemembership"
        Me.btndeletemembership.Size = New System.Drawing.Size(89, 52)
        Me.btndeletemembership.TabIndex = 3
        Me.btndeletemembership.Text = "Delete"
        Me.btndeletemembership.UseVisualStyleBackColor = True
        '
        'btnupdatemembership
        '
        Me.btnupdatemembership.Location = New System.Drawing.Point(20, 146)
        Me.btnupdatemembership.Name = "btnupdatemembership"
        Me.btnupdatemembership.Size = New System.Drawing.Size(89, 52)
        Me.btnupdatemembership.TabIndex = 2
        Me.btnupdatemembership.Text = "Update"
        Me.btnupdatemembership.UseVisualStyleBackColor = True
        '
        'btneditmembership
        '
        Me.btneditmembership.Location = New System.Drawing.Point(20, 83)
        Me.btneditmembership.Name = "btneditmembership"
        Me.btneditmembership.Size = New System.Drawing.Size(89, 52)
        Me.btneditmembership.TabIndex = 1
        Me.btneditmembership.Text = "Edit"
        Me.btneditmembership.UseVisualStyleBackColor = True
        '
        'btnsavemembership
        '
        Me.btnsavemembership.Location = New System.Drawing.Point(20, 25)
        Me.btnsavemembership.Name = "btnsavemembership"
        Me.btnsavemembership.Size = New System.Drawing.Size(89, 52)
        Me.btnsavemembership.TabIndex = 0
        Me.btnsavemembership.Text = "&Save"
        Me.btnsavemembership.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(160, 285)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(243, 32)
        Me.txtaddress.TabIndex = 26
        '
        'txtyearsection
        '
        Me.txtyearsection.Location = New System.Drawing.Point(160, 168)
        Me.txtyearsection.Name = "txtyearsection"
        Me.txtyearsection.Size = New System.Drawing.Size(243, 32)
        Me.txtyearsection.TabIndex = 24
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(160, 109)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(243, 32)
        Me.txtfullname.TabIndex = 23
        '
        'txtlrn
        '
        Me.txtlrn.Location = New System.Drawing.Point(160, 50)
        Me.txtlrn.Name = "txtlrn"
        Me.txtlrn.Size = New System.Drawing.Size(243, 32)
        Me.txtlrn.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(87, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 25)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(83, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 25)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Birthdate"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(38, 171)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(113, 25)
        Me.label.TabIndex = 17
        Me.label.Text = "Year and Section"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(87, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Fullname"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(117, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 25)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "LRN"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtstatus)
        Me.TabPage4.Controls.Add(Me.DataGridViewaddbooks)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.txtpublisher)
        Me.TabPage4.Controls.Add(Me.txtsubject)
        Me.TabPage4.Controls.Add(Me.txtauthor)
        Me.TabPage4.Controls.Add(Me.txttitle)
        Me.TabPage4.Controls.Add(Me.txtbookid)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1150, 387)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Add Books"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtstatus
        '
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"Available", "For library only", "others"})
        Me.txtstatus.Location = New System.Drawing.Point(98, 294)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(294, 33)
        Me.txtstatus.TabIndex = 16
        '
        'DataGridViewaddbooks
        '
        Me.DataGridViewaddbooks.AllowUserToAddRows = False
        Me.DataGridViewaddbooks.AllowUserToDeleteRows = False
        Me.DataGridViewaddbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewaddbooks.Location = New System.Drawing.Point(546, 17)
        Me.DataGridViewaddbooks.Name = "DataGridViewaddbooks"
        Me.DataGridViewaddbooks.ReadOnly = True
        Me.DataGridViewaddbooks.Size = New System.Drawing.Size(586, 358)
        Me.DataGridViewaddbooks.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Location = New System.Drawing.Point(408, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 283)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(15, 210)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(89, 52)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(15, 146)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(89, 52)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(15, 83)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(89, 52)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(15, 25)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(89, 52)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtpublisher
        '
        Me.txtpublisher.Location = New System.Drawing.Point(97, 242)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(295, 32)
        Me.txtpublisher.TabIndex = 11
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(97, 189)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(295, 32)
        Me.txtsubject.TabIndex = 10
        '
        'txtauthor
        '
        Me.txtauthor.Location = New System.Drawing.Point(97, 140)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(295, 32)
        Me.txtauthor.TabIndex = 9
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(97, 94)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(295, 32)
        Me.txttitle.TabIndex = 8
        '
        'txtbookid
        '
        Me.txtbookid.Location = New System.Drawing.Point(97, 43)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(295, 32)
        Me.txtbookid.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Publisher"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Subject"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Book ID"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReportViewer2)
        Me.TabPage6.Controls.Add(Me.ReportViewer1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 34)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1150, 387)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Reports"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSetreturnbooks"
        ReportDataSource1.Value = Me.tblreturnbooksBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "LibrarySystem.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(586, 28)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(524, 333)
        Me.ReportViewer2.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSetborrowbooks"
        ReportDataSource2.Value = Me.tblborrowbooksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LibrarySystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(28, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(514, 333)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblborrowbooksTableAdapter
        '
        Me.tblborrowbooksTableAdapter.ClearBeforeFill = True
        '
        'tblreturnbooksTableAdapter
        '
        Me.tblreturnbooksTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 586)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.tblreturnbooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarySystemDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblborrowbooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewbookdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvborrowlistoutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvreturnlistoutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvmembershipoutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewaddbooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewbookdetails As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearchbookdetails As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtpublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtsubject As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btndeletemembership As System.Windows.Forms.Button
    Friend WithEvents btnupdatemembership As System.Windows.Forms.Button
    Friend WithEvents btneditmembership As System.Windows.Forms.Button
    Friend WithEvents btnsavemembership As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtyearsection As System.Windows.Forms.TextBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents txtlrn As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgvborrowlistoutput As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtlrnBL As System.Windows.Forms.TextBox
    Friend WithEvents txtfullnameBL As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnborrow As System.Windows.Forms.Button
    Friend WithEvents txtbookidBL As System.Windows.Forms.TextBox
    Friend WithEvents txttitleBL As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewaddbooks As System.Windows.Forms.DataGridView
    Friend WithEvents dgvmembershipoutput As System.Windows.Forms.DataGridView
    Friend WithEvents txtbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerreturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerborrow As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtreturndateBL As System.Windows.Forms.TextBox
    Friend WithEvents txtborrowdateBL As System.Windows.Forms.TextBox
    Friend WithEvents cbostatusBL As System.Windows.Forms.ComboBox
    Friend WithEvents btnreturn As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgvreturnlistoutput As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearchreturnlist As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblborrowbooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibrarySystemDBDataSet As LibrarySystem.LibrarySystemDBDataSet
    Friend WithEvents tblborrowbooksTableAdapter As LibrarySystem.LibrarySystemDBDataSetTableAdapters.tblborrowbooksTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblreturnbooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblreturnbooksTableAdapter As LibrarySystem.LibrarySystemDBDataSetTableAdapters.tblreturnbooksTableAdapter
End Class
