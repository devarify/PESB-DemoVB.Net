<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tampil_data_siswa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoformulirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempatlahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggallahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatsiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasiswalulusDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasiswalulusDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSet()
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSetTableAdapters.Tdata_siswaTableAdapter()
        Me.FillBylulusToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBylulusToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasiswalulusDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasiswalulusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBylulusToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cari"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(60, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoformulirDataGridViewTextBoxColumn, Me.NamasiswaDataGridViewTextBoxColumn, Me.TempatlahirDataGridViewTextBoxColumn, Me.TanggallahirDataGridViewTextBoxColumn, Me.UmurDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.AgamaDataGridViewTextBoxColumn, Me.AlamatsiswaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TdatasiswaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'NoformulirDataGridViewTextBoxColumn
        '
        Me.NoformulirDataGridViewTextBoxColumn.DataPropertyName = "no_formulir"
        Me.NoformulirDataGridViewTextBoxColumn.HeaderText = "no_formulir"
        Me.NoformulirDataGridViewTextBoxColumn.Name = "NoformulirDataGridViewTextBoxColumn"
        Me.NoformulirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamasiswaDataGridViewTextBoxColumn
        '
        Me.NamasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.HeaderText = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.Name = "NamasiswaDataGridViewTextBoxColumn"
        Me.NamasiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TempatlahirDataGridViewTextBoxColumn
        '
        Me.TempatlahirDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.HeaderText = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.Name = "TempatlahirDataGridViewTextBoxColumn"
        Me.TempatlahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TanggallahirDataGridViewTextBoxColumn
        '
        Me.TanggallahirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.HeaderText = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.Name = "TanggallahirDataGridViewTextBoxColumn"
        Me.TanggallahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UmurDataGridViewTextBoxColumn
        '
        Me.UmurDataGridViewTextBoxColumn.DataPropertyName = "umur"
        Me.UmurDataGridViewTextBoxColumn.HeaderText = "umur"
        Me.UmurDataGridViewTextBoxColumn.Name = "UmurDataGridViewTextBoxColumn"
        Me.UmurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        Me.JeniskelaminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgamaDataGridViewTextBoxColumn
        '
        Me.AgamaDataGridViewTextBoxColumn.DataPropertyName = "agama"
        Me.AgamaDataGridViewTextBoxColumn.HeaderText = "agama"
        Me.AgamaDataGridViewTextBoxColumn.Name = "AgamaDataGridViewTextBoxColumn"
        Me.AgamaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatsiswaDataGridViewTextBoxColumn
        '
        Me.AlamatsiswaDataGridViewTextBoxColumn.DataPropertyName = "alamat_siswa"
        Me.AlamatsiswaDataGridViewTextBoxColumn.HeaderText = "alamat_siswa"
        Me.AlamatsiswaDataGridViewTextBoxColumn.Name = "AlamatsiswaDataGridViewTextBoxColumn"
        Me.AlamatsiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TdatasiswaBindingSource
        '
        Me.TdatasiswaBindingSource.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource.DataSource = Me.DatasiswalulusDataSetBindingSource
        '
        'DatasiswalulusDataSetBindingSource
        '
        Me.DatasiswalulusDataSetBindingSource.DataSource = Me.DatasiswalulusDataSet
        Me.DatasiswalulusDataSetBindingSource.Position = 0
        '
        'DatasiswalulusDataSet
        '
        Me.DatasiswalulusDataSet.DataSetName = "datasiswalulusDataSet"
        Me.DatasiswalulusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
        '
        'FillBylulusToolStrip
        '
        Me.FillBylulusToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBylulusToolStripButton})
        Me.FillBylulusToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBylulusToolStrip.Name = "FillBylulusToolStrip"
        Me.FillBylulusToolStrip.Size = New System.Drawing.Size(262, 28)
        Me.FillBylulusToolStrip.TabIndex = 6
        Me.FillBylulusToolStrip.Text = "FillBylulusToolStrip"
        '
        'FillBylulusToolStripButton
        '
        Me.FillBylulusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBylulusToolStripButton.Name = "FillBylulusToolStripButton"
        Me.FillBylulusToolStripButton.Size = New System.Drawing.Size(71, 25)
        Me.FillBylulusToolStripButton.Text = "FillBylulus"
        '
        'tampil_data_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 207)
        Me.Controls.Add(Me.FillBylulusToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "tampil_data_siswa"
        Me.Text = "tampil_data_siswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasiswalulusDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasiswalulusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBylulusToolStrip.ResumeLayout(False)
        Me.FillBylulusToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatasiswalulusDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatasiswalulusDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSet
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSetTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents NoformulirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamasiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempatlahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggallahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatsiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillBylulusToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBylulusToolStripButton As System.Windows.Forms.ToolStripButton
End Class
