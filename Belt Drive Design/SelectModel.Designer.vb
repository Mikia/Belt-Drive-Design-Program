<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectModel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Ymg = New System.Windows.Forms.DataGridView()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatedPowerKWDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullloadSpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartupTorqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxTorqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SynchronousSpeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShaftDiameterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SS750BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Y_MotorDataSet1 = New Belt_Drive_Design.Y_MotorDataSet1()
        Me.SS750TableAdapter = New Belt_Drive_Design.Y_MotorDataSet1TableAdapters.SS750TableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Ymg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SS750BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Y_MotorDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ymg
        '
        Me.Ymg.AllowUserToAddRows = False
        Me.Ymg.AllowUserToDeleteRows = False
        Me.Ymg.AutoGenerateColumns = False
        Me.Ymg.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.Ymg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ymg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModelDataGridViewTextBoxColumn, Me.RatedPowerKWDataGridViewTextBoxColumn, Me.FullloadSpeedDataGridViewTextBoxColumn, Me.StartupTorqueDataGridViewTextBoxColumn, Me.MaxTorqueDataGridViewTextBoxColumn, Me.SynchronousSpeedDataGridViewTextBoxColumn, Me.ShaftDiameterDataGridViewTextBoxColumn})
        Me.Ymg.DataSource = Me.SS750BindingSource
        Me.Ymg.Location = New System.Drawing.Point(-1, -1)
        Me.Ymg.Name = "Ymg"
        Me.Ymg.ReadOnly = True
        Me.Ymg.RowTemplate.Height = 24
        Me.Ymg.Size = New System.Drawing.Size(1236, 786)
        Me.Ymg.TabIndex = 0
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RatedPowerKWDataGridViewTextBoxColumn
        '
        Me.RatedPowerKWDataGridViewTextBoxColumn.DataPropertyName = "Rated Power(KW)"
        Me.RatedPowerKWDataGridViewTextBoxColumn.HeaderText = "Rated Power(KW)"
        Me.RatedPowerKWDataGridViewTextBoxColumn.Name = "RatedPowerKWDataGridViewTextBoxColumn"
        Me.RatedPowerKWDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullloadSpeedDataGridViewTextBoxColumn
        '
        Me.FullloadSpeedDataGridViewTextBoxColumn.DataPropertyName = "Full-load Speed"
        Me.FullloadSpeedDataGridViewTextBoxColumn.HeaderText = "Full-load Speed"
        Me.FullloadSpeedDataGridViewTextBoxColumn.Name = "FullloadSpeedDataGridViewTextBoxColumn"
        Me.FullloadSpeedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartupTorqueDataGridViewTextBoxColumn
        '
        Me.StartupTorqueDataGridViewTextBoxColumn.DataPropertyName = "Start-up Torque"
        Me.StartupTorqueDataGridViewTextBoxColumn.HeaderText = "Start-up Torque"
        Me.StartupTorqueDataGridViewTextBoxColumn.Name = "StartupTorqueDataGridViewTextBoxColumn"
        Me.StartupTorqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaxTorqueDataGridViewTextBoxColumn
        '
        Me.MaxTorqueDataGridViewTextBoxColumn.DataPropertyName = "Max Torque"
        Me.MaxTorqueDataGridViewTextBoxColumn.HeaderText = "Max Torque"
        Me.MaxTorqueDataGridViewTextBoxColumn.Name = "MaxTorqueDataGridViewTextBoxColumn"
        Me.MaxTorqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SynchronousSpeedDataGridViewTextBoxColumn
        '
        Me.SynchronousSpeedDataGridViewTextBoxColumn.DataPropertyName = "Synchronous Speed"
        Me.SynchronousSpeedDataGridViewTextBoxColumn.HeaderText = "Synchronous Speed"
        Me.SynchronousSpeedDataGridViewTextBoxColumn.Name = "SynchronousSpeedDataGridViewTextBoxColumn"
        Me.SynchronousSpeedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShaftDiameterDataGridViewTextBoxColumn
        '
        Me.ShaftDiameterDataGridViewTextBoxColumn.DataPropertyName = "Shaft Diameter"
        Me.ShaftDiameterDataGridViewTextBoxColumn.HeaderText = "Shaft Diameter"
        Me.ShaftDiameterDataGridViewTextBoxColumn.Name = "ShaftDiameterDataGridViewTextBoxColumn"
        Me.ShaftDiameterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SS750BindingSource
        '
        Me.SS750BindingSource.DataMember = "SS750"
        Me.SS750BindingSource.DataSource = Me.Y_MotorDataSet1
        '
        'Y_MotorDataSet1
        '
        Me.Y_MotorDataSet1.DataSetName = "Y_MotorDataSet1"
        Me.Y_MotorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SS750TableAdapter
        '
        Me.SS750TableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SelectModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1235, 785)
        Me.Controls.Add(Me.Ymg)
        Me.Name = "SelectModel"
        Me.Text = "SelectModel"
        CType(Me.Ymg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SS750BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Y_MotorDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ymg As DataGridView
    Friend WithEvents Y_MotorDataSet1 As Y_MotorDataSet1
    Friend WithEvents SS750BindingSource As BindingSource
    Friend WithEvents SS750TableAdapter As Y_MotorDataSet1TableAdapters.SS750TableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatedPowerKWDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullloadSpeedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartupTorqueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxTorqueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SynchronousSpeedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShaftDiameterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
