<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_bantuan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_bantuan))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 82)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(563, 173)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Aplikasi Penerimaan Siswa Baru" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "-Menu Utama" & Global.Microsoft.VisualBasic.ChrW(10) & "-Menu Login" & Global.Microsoft.VisualBasic.ChrW(10) & "-Menu Admin" & Global.Microsoft.VisualBasic.ChrW(10) & "-Menu Sekolah" & _
    "" & Global.Microsoft.VisualBasic.ChrW(10) & "-Menu Data Siswa" & Global.Microsoft.VisualBasic.ChrW(10) & "-Menu Laporan"
        Me.RichTextBox1.WordWrap = False
        Me.RichTextBox1.ZoomFactor = 2.0!
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(563, 48)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Bantuan"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form_bantuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 311)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RichTextBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_bantuan"
        Me.Text = "Form_bantuan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
