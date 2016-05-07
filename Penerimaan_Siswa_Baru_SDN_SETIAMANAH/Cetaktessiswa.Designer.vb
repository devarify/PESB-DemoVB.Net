<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetaktessiswa
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TdatatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatatesDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TdatatesTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TdatatesTableAdapter()
        Me.txtcarinopend = New System.Windows.Forms.TextBox()
        Me.txtcarinama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TdatatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TdatatesBindingSource
        '
        Me.TdatatesBindingSource.DataMember = "Tdatates"
        Me.TdatatesBindingSource.DataSource = Me.DatatesDataSet
        '
        'DatatesDataSet
        '
        Me.DatatesDataSet.DataSetName = "DatatesDataSet"
        Me.DatatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.TdatatesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Penerimaan_Siswa_Baru_SDN_SETIAMANAH.ReportTessiswa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 16)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(646, 303)
        Me.ReportViewer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 322)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Tes"
        '
        'TdatatesTableAdapter
        '
        Me.TdatatesTableAdapter.ClearBeforeFill = True
        '
        'txtcarinopend
        '
        Me.txtcarinopend.Location = New System.Drawing.Point(113, 11)
        Me.txtcarinopend.Name = "txtcarinopend"
        Me.txtcarinopend.Size = New System.Drawing.Size(100, 20)
        Me.txtcarinopend.TabIndex = 2
        '
        'txtcarinama
        '
        Me.txtcarinama.Location = New System.Drawing.Point(113, 37)
        Me.txtcarinama.Name = "txtcarinama"
        Me.txtcarinama.Size = New System.Drawing.Size(100, 20)
        Me.txtcarinama.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No Pendaftaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Siswa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtcarinama)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtcarinopend)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 64)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cetaktessiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 416)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cetaktessiswa"
        Me.Text = "Cetaktessiswa"
        CType(Me.TdatatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TdatatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatatesDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet
    Friend WithEvents TdatatesTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TdatatesTableAdapter
    Friend WithEvents txtcarinopend As System.Windows.Forms.TextBox
    Friend WithEvents txtcarinama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
