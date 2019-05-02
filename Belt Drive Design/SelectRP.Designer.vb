<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectRP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectRP))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Vbelt1DataSet2 = New Belt_Drive_Design.Vbelt1DataSet2()
        Me.RatingPowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rating_PowerTableAdapter = New Belt_Drive_Design.Vbelt1DataSet2TableAdapters.Rating_PowerTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeltTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DdmmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1100rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1200rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1400rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1700rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1800rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N1950rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N11200rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N11450rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N11600rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N12000rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N12400rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N12800rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N13200rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N13600rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N14000rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N14500rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N15000rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N15500rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N16000rminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vbelt1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatingPowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BeltTypeDataGridViewTextBoxColumn, Me.DdmmDataGridViewTextBoxColumn, Me.N1100rminDataGridViewTextBoxColumn, Me.N1200rminDataGridViewTextBoxColumn, Me.N1400rminDataGridViewTextBoxColumn, Me.N1700rminDataGridViewTextBoxColumn, Me.N1800rminDataGridViewTextBoxColumn, Me.N1950rminDataGridViewTextBoxColumn, Me.N11200rminDataGridViewTextBoxColumn, Me.N11450rminDataGridViewTextBoxColumn, Me.N11600rminDataGridViewTextBoxColumn, Me.N12000rminDataGridViewTextBoxColumn, Me.N12400rminDataGridViewTextBoxColumn, Me.N12800rminDataGridViewTextBoxColumn, Me.N13200rminDataGridViewTextBoxColumn, Me.N13600rminDataGridViewTextBoxColumn, Me.N14000rminDataGridViewTextBoxColumn, Me.N14500rminDataGridViewTextBoxColumn, Me.N15000rminDataGridViewTextBoxColumn, Me.N15500rminDataGridViewTextBoxColumn, Me.N16000rminDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RatingPowerBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1181, 693)
        Me.DataGridView1.TabIndex = 0
        '
        'Vbelt1DataSet2
        '
        Me.Vbelt1DataSet2.DataSetName = "Vbelt1DataSet2"
        Me.Vbelt1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RatingPowerBindingSource
        '
        Me.RatingPowerBindingSource.DataMember = "Rating Power"
        Me.RatingPowerBindingSource.DataSource = Me.Vbelt1DataSet2
        '
        'Rating_PowerTableAdapter
        '
        Me.Rating_PowerTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'BeltTypeDataGridViewTextBoxColumn
        '
        Me.BeltTypeDataGridViewTextBoxColumn.DataPropertyName = "Belt Type"
        Me.BeltTypeDataGridViewTextBoxColumn.HeaderText = "Belt Type"
        Me.BeltTypeDataGridViewTextBoxColumn.Name = "BeltTypeDataGridViewTextBoxColumn"
        Me.BeltTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BeltTypeDataGridViewTextBoxColumn.Width = 97
        '
        'DdmmDataGridViewTextBoxColumn
        '
        Me.DdmmDataGridViewTextBoxColumn.DataPropertyName = "Dd/mm"
        Me.DdmmDataGridViewTextBoxColumn.HeaderText = "Dd/mm"
        Me.DdmmDataGridViewTextBoxColumn.Name = "DdmmDataGridViewTextBoxColumn"
        Me.DdmmDataGridViewTextBoxColumn.ReadOnly = True
        Me.DdmmDataGridViewTextBoxColumn.Width = 81
        '
        'N1100rminDataGridViewTextBoxColumn
        '
        Me.N1100rminDataGridViewTextBoxColumn.DataPropertyName = "n1=100r/min"
        Me.N1100rminDataGridViewTextBoxColumn.HeaderText = "n1=100r/min"
        Me.N1100rminDataGridViewTextBoxColumn.Name = "N1100rminDataGridViewTextBoxColumn"
        Me.N1100rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N1100rminDataGridViewTextBoxColumn.Width = 116
        '
        'N1200rminDataGridViewTextBoxColumn
        '
        Me.N1200rminDataGridViewTextBoxColumn.DataPropertyName = "n1=200r/min"
        Me.N1200rminDataGridViewTextBoxColumn.HeaderText = "n1=200r/min"
        Me.N1200rminDataGridViewTextBoxColumn.Name = "N1200rminDataGridViewTextBoxColumn"
        Me.N1200rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N1200rminDataGridViewTextBoxColumn.Width = 116
        '
        'N1400rminDataGridViewTextBoxColumn
        '
        Me.N1400rminDataGridViewTextBoxColumn.DataPropertyName = "n1=400r/min"
        Me.N1400rminDataGridViewTextBoxColumn.HeaderText = "n1=400r/min"
        Me.N1400rminDataGridViewTextBoxColumn.Name = "N1400rminDataGridViewTextBoxColumn"
        Me.N1400rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N1400rminDataGridViewTextBoxColumn.Width = 116
        '
        'N1700rminDataGridViewTextBoxColumn
        '
        Me.N1700rminDataGridViewTextBoxColumn.DataPropertyName = "n1=700r/min"
        Me.N1700rminDataGridViewTextBoxColumn.HeaderText = "n1=700r/min"
        Me.N1700rminDataGridViewTextBoxColumn.Name = "N1700rminDataGridViewTextBoxColumn"
        Me.N1700rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N1700rminDataGridViewTextBoxColumn.Width = 116
        '
        'N1800rminDataGridViewTextBoxColumn
        '
        Me.N1800rminDataGridViewTextBoxColumn.DataPropertyName = "n1=800r/min"
        Me.N1800rminDataGridViewTextBoxColumn.HeaderText = "n1=800r/min"
        Me.N1800rminDataGridViewTextBoxColumn.Name = "N1800rminDataGridViewTextBoxColumn"
        Me.N1800rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N1800rminDataGridViewTextBoxColumn.Width = 116
        '
        'N1950rminDataGridViewTextBoxColumn
        '
        Me.N1950rminDataGridViewTextBoxColumn.DataPropertyName = "n1=950r/min"
        Me.N1950rminDataGridViewTextBoxColumn.HeaderText = "n1=950r/min"
        Me.N1950rminDataGridViewTextBoxColumn.Name = "N1950rminDataGridViewTextBoxColumn"
        Me.N1950rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N1950rminDataGridViewTextBoxColumn.Width = 116
        '
        'N11200rminDataGridViewTextBoxColumn
        '
        Me.N11200rminDataGridViewTextBoxColumn.DataPropertyName = "n1=1200r/min"
        Me.N11200rminDataGridViewTextBoxColumn.HeaderText = "n1=1200r/min"
        Me.N11200rminDataGridViewTextBoxColumn.Name = "N11200rminDataGridViewTextBoxColumn"
        Me.N11200rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N11200rminDataGridViewTextBoxColumn.Width = 124
        '
        'N11450rminDataGridViewTextBoxColumn
        '
        Me.N11450rminDataGridViewTextBoxColumn.DataPropertyName = "n1=1450r/min"
        Me.N11450rminDataGridViewTextBoxColumn.HeaderText = "n1=1450r/min"
        Me.N11450rminDataGridViewTextBoxColumn.Name = "N11450rminDataGridViewTextBoxColumn"
        Me.N11450rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N11450rminDataGridViewTextBoxColumn.Width = 124
        '
        'N11600rminDataGridViewTextBoxColumn
        '
        Me.N11600rminDataGridViewTextBoxColumn.DataPropertyName = "n1=1600r/min"
        Me.N11600rminDataGridViewTextBoxColumn.HeaderText = "n1=1600r/min"
        Me.N11600rminDataGridViewTextBoxColumn.Name = "N11600rminDataGridViewTextBoxColumn"
        Me.N11600rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N11600rminDataGridViewTextBoxColumn.Width = 124
        '
        'N12000rminDataGridViewTextBoxColumn
        '
        Me.N12000rminDataGridViewTextBoxColumn.DataPropertyName = "n1=2000r/min"
        Me.N12000rminDataGridViewTextBoxColumn.HeaderText = "n1=2000r/min"
        Me.N12000rminDataGridViewTextBoxColumn.Name = "N12000rminDataGridViewTextBoxColumn"
        Me.N12000rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N12000rminDataGridViewTextBoxColumn.Width = 124
        '
        'N12400rminDataGridViewTextBoxColumn
        '
        Me.N12400rminDataGridViewTextBoxColumn.DataPropertyName = "n1=2400r/min"
        Me.N12400rminDataGridViewTextBoxColumn.HeaderText = "n1=2400r/min"
        Me.N12400rminDataGridViewTextBoxColumn.Name = "N12400rminDataGridViewTextBoxColumn"
        Me.N12400rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N12400rminDataGridViewTextBoxColumn.Width = 124
        '
        'N12800rminDataGridViewTextBoxColumn
        '
        Me.N12800rminDataGridViewTextBoxColumn.DataPropertyName = "n1=2800r/min"
        Me.N12800rminDataGridViewTextBoxColumn.HeaderText = "n1=2800r/min"
        Me.N12800rminDataGridViewTextBoxColumn.Name = "N12800rminDataGridViewTextBoxColumn"
        Me.N12800rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N12800rminDataGridViewTextBoxColumn.Width = 124
        '
        'N13200rminDataGridViewTextBoxColumn
        '
        Me.N13200rminDataGridViewTextBoxColumn.DataPropertyName = "n1=3200r/min"
        Me.N13200rminDataGridViewTextBoxColumn.HeaderText = "n1=3200r/min"
        Me.N13200rminDataGridViewTextBoxColumn.Name = "N13200rminDataGridViewTextBoxColumn"
        Me.N13200rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N13200rminDataGridViewTextBoxColumn.Width = 124
        '
        'N13600rminDataGridViewTextBoxColumn
        '
        Me.N13600rminDataGridViewTextBoxColumn.DataPropertyName = "n1=3600r/min"
        Me.N13600rminDataGridViewTextBoxColumn.HeaderText = "n1=3600r/min"
        Me.N13600rminDataGridViewTextBoxColumn.Name = "N13600rminDataGridViewTextBoxColumn"
        Me.N13600rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N13600rminDataGridViewTextBoxColumn.Width = 124
        '
        'N14000rminDataGridViewTextBoxColumn
        '
        Me.N14000rminDataGridViewTextBoxColumn.DataPropertyName = "n1=4000r/min"
        Me.N14000rminDataGridViewTextBoxColumn.HeaderText = "n1=4000r/min"
        Me.N14000rminDataGridViewTextBoxColumn.Name = "N14000rminDataGridViewTextBoxColumn"
        Me.N14000rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N14000rminDataGridViewTextBoxColumn.Width = 124
        '
        'N14500rminDataGridViewTextBoxColumn
        '
        Me.N14500rminDataGridViewTextBoxColumn.DataPropertyName = "n1=4500r/min"
        Me.N14500rminDataGridViewTextBoxColumn.HeaderText = "n1=4500r/min"
        Me.N14500rminDataGridViewTextBoxColumn.Name = "N14500rminDataGridViewTextBoxColumn"
        Me.N14500rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N14500rminDataGridViewTextBoxColumn.Width = 124
        '
        'N15000rminDataGridViewTextBoxColumn
        '
        Me.N15000rminDataGridViewTextBoxColumn.DataPropertyName = "n1=5000r/min"
        Me.N15000rminDataGridViewTextBoxColumn.HeaderText = "n1=5000r/min"
        Me.N15000rminDataGridViewTextBoxColumn.Name = "N15000rminDataGridViewTextBoxColumn"
        Me.N15000rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N15000rminDataGridViewTextBoxColumn.Width = 124
        '
        'N15500rminDataGridViewTextBoxColumn
        '
        Me.N15500rminDataGridViewTextBoxColumn.DataPropertyName = "n1=5500r/min"
        Me.N15500rminDataGridViewTextBoxColumn.HeaderText = "n1=5500r/min"
        Me.N15500rminDataGridViewTextBoxColumn.Name = "N15500rminDataGridViewTextBoxColumn"
        Me.N15500rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N15500rminDataGridViewTextBoxColumn.Width = 124
        '
        'N16000rminDataGridViewTextBoxColumn
        '
        Me.N16000rminDataGridViewTextBoxColumn.DataPropertyName = "n1=6000r/min"
        Me.N16000rminDataGridViewTextBoxColumn.HeaderText = "n1=6000r/min"
        Me.N16000rminDataGridViewTextBoxColumn.Name = "N16000rminDataGridViewTextBoxColumn"
        Me.N16000rminDataGridViewTextBoxColumn.ReadOnly = True
        Me.N16000rminDataGridViewTextBoxColumn.Width = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selected P0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(120, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "From Chart Below"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(476, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "kW"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1181, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Selected Kα"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(345, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 41
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(59, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(39, 22)
        Me.TextBox3.TabIndex = 42
        '
        'SelectRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1181, 856)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SelectRP"
        Me.Text = "SelectRP"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vbelt1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatingPowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Vbelt1DataSet2 As Vbelt1DataSet2
    Friend WithEvents RatingPowerBindingSource As BindingSource
    Friend WithEvents Rating_PowerTableAdapter As Vbelt1DataSet2TableAdapters.Rating_PowerTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeltTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DdmmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1100rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1200rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1400rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1700rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1800rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N1950rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N11200rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N11450rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N11600rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N12000rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N12400rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N12800rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N13200rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N13600rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N14000rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N14500rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N15000rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N15500rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents N16000rminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
