<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan_Data_Siswa_Baru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Laporan_Data_Siswa_Baru))
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no_induk_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_formulir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_diterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datasiswabaru = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaru()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TsiswabaruBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsiswabaruTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaruTableAdapters.TsiswabaruTableAdapter()
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaruTableAdapters.Tdata_siswaTableAdapter()
        Me.NoinduksiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoformulirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalditerimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKTsiswabaruTdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsiswabaruBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datasiswabaru, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsiswabaruBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTsiswabaruTdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsiswabaruBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(410, 299)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(126, 47)
        Me.btnKembali.TabIndex = 7
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(31, 299)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(126, 47)
        Me.btnCetak.TabIndex = 6
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 242)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tampilan Data Siswa Baru"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_induk_siswa, Me.no_formulir, Me.tanggal_diterima, Me.kelas, Me.NoinduksiswaDataGridViewTextBoxColumn, Me.NoformulirDataGridViewTextBoxColumn, Me.TanggalditerimaDataGridViewTextBoxColumn, Me.KelasDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TsiswabaruBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(502, 223)
        Me.DataGridView1.TabIndex = 0
        '
        'no_induk_siswa
        '
        Me.no_induk_siswa.DataPropertyName = "no_induk_siswa"
        Me.no_induk_siswa.HeaderText = "no_induk_siswa"
        Me.no_induk_siswa.Name = "no_induk_siswa"
        Me.no_induk_siswa.ReadOnly = True
        '
        'no_formulir
        '
        Me.no_formulir.DataPropertyName = "no_formulir"
        Me.no_formulir.HeaderText = "no_formulir"
        Me.no_formulir.Name = "no_formulir"
        Me.no_formulir.ReadOnly = True
        '
        'tanggal_diterima
        '
        Me.tanggal_diterima.DataPropertyName = "tanggal_diterima"
        Me.tanggal_diterima.HeaderText = "tanggal_diterima"
        Me.tanggal_diterima.Name = "tanggal_diterima"
        Me.tanggal_diterima.ReadOnly = True
        '
        'kelas
        '
        Me.kelas.DataPropertyName = "kelas"
        Me.kelas.HeaderText = "kelas"
        Me.kelas.Name = "kelas"
        Me.kelas.ReadOnly = True
        '
        'TdatasiswaBindingSource
        '
        Me.TdatasiswaBindingSource.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource.DataSource = Me.Datasiswabaru
        '
        'Datasiswabaru
        '
        Me.Datasiswabaru.DataSetName = "datasiswabaru"
        Me.Datasiswabaru.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(497, 48)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Siswa Baru"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TsiswabaruBindingSource
        '
        Me.TsiswabaruBindingSource.DataMember = "Tsiswabaru"
        Me.TsiswabaruBindingSource.DataSource = Me.Datasiswabaru
        '
        'TsiswabaruTableAdapter
        '
        Me.TsiswabaruTableAdapter.ClearBeforeFill = True
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
        '
        'NoinduksiswaDataGridViewTextBoxColumn
        '
        Me.NoinduksiswaDataGridViewTextBoxColumn.DataPropertyName = "no_induk_siswa"
        Me.NoinduksiswaDataGridViewTextBoxColumn.HeaderText = "no_induk_siswa"
        Me.NoinduksiswaDataGridViewTextBoxColumn.Name = "NoinduksiswaDataGridViewTextBoxColumn"
        Me.NoinduksiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoformulirDataGridViewTextBoxColumn
        '
        Me.NoformulirDataGridViewTextBoxColumn.DataPropertyName = "no_formulir"
        Me.NoformulirDataGridViewTextBoxColumn.HeaderText = "no_formulir"
        Me.NoformulirDataGridViewTextBoxColumn.Name = "NoformulirDataGridViewTextBoxColumn"
        Me.NoformulirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TanggalditerimaDataGridViewTextBoxColumn
        '
        Me.TanggalditerimaDataGridViewTextBoxColumn.DataPropertyName = "tanggal_diterima"
        Me.TanggalditerimaDataGridViewTextBoxColumn.HeaderText = "tanggal_diterima"
        Me.TanggalditerimaDataGridViewTextBoxColumn.Name = "TanggalditerimaDataGridViewTextBoxColumn"
        Me.TanggalditerimaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KelasDataGridViewTextBoxColumn
        '
        Me.KelasDataGridViewTextBoxColumn.DataPropertyName = "kelas"
        Me.KelasDataGridViewTextBoxColumn.HeaderText = "kelas"
        Me.KelasDataGridViewTextBoxColumn.Name = "KelasDataGridViewTextBoxColumn"
        Me.KelasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FKTsiswabaruTdatasiswaBindingSource
        '
        Me.FKTsiswabaruTdatasiswaBindingSource.DataMember = "FK_Tsiswabaru_Tdata_siswa"
        Me.FKTsiswabaruTdatasiswaBindingSource.DataSource = Me.TdatasiswaBindingSource
        '
        'TsiswabaruBindingSource1
        '
        Me.TsiswabaruBindingSource1.DataMember = "Tsiswabaru"
        Me.TsiswabaruBindingSource1.DataSource = Me.Datasiswabaru
        '
        'Form_Laporan_Data_Siswa_Baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(562, 355)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Laporan_Data_Siswa_Baru"
        Me.Text = "Form_Laporan_Data_Siswa_Baru"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datasiswabaru, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsiswabaruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTsiswabaruTdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsiswabaruBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Datasiswabaru As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaru
    Friend WithEvents TsiswabaruBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TsiswabaruTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaruTableAdapters.TsiswabaruTableAdapter
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaruTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents no_induk_siswa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_formulir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_diterima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKTsiswabaruTdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NoinduksiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoformulirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalditerimaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TsiswabaruBindingSource1 As System.Windows.Forms.BindingSource
End Class
