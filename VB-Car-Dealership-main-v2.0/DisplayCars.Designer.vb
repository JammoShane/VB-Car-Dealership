<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayCars
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorsepowerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarInformationDataSet = New CarDatabase.CarInformationDataSet()
        Me.CarsTableAdapter = New CarDatabase.CarInformationDataSetTableAdapters.CarsTableAdapter()
        Me.btnMenu = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.EngineDataGridViewTextBoxColumn, Me.HorsepowerDataGridViewTextBoxColumn, Me.ImageDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.CarsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(193, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(939, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CarIdDataGridViewTextBoxColumn
        '
        Me.CarIdDataGridViewTextBoxColumn.DataPropertyName = "CarId"
        Me.CarIdDataGridViewTextBoxColumn.HeaderText = "CarId"
        Me.CarIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CarIdDataGridViewTextBoxColumn.Name = "CarIdDataGridViewTextBoxColumn"
        Me.CarIdDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.Width = 125
        '
        'EngineDataGridViewTextBoxColumn
        '
        Me.EngineDataGridViewTextBoxColumn.DataPropertyName = "Engine"
        Me.EngineDataGridViewTextBoxColumn.HeaderText = "Engine"
        Me.EngineDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EngineDataGridViewTextBoxColumn.Name = "EngineDataGridViewTextBoxColumn"
        Me.EngineDataGridViewTextBoxColumn.Width = 125
        '
        'HorsepowerDataGridViewTextBoxColumn
        '
        Me.HorsepowerDataGridViewTextBoxColumn.DataPropertyName = "Horsepower"
        Me.HorsepowerDataGridViewTextBoxColumn.HeaderText = "Horsepower"
        Me.HorsepowerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HorsepowerDataGridViewTextBoxColumn.Name = "HorsepowerDataGridViewTextBoxColumn"
        Me.HorsepowerDataGridViewTextBoxColumn.Width = 125
        '
        'ImageDataGridViewImageColumn
        '
        Me.ImageDataGridViewImageColumn.DataPropertyName = "Image"
        Me.ImageDataGridViewImageColumn.HeaderText = "Image"
        Me.ImageDataGridViewImageColumn.MinimumWidth = 6
        Me.ImageDataGridViewImageColumn.Name = "ImageDataGridViewImageColumn"
        Me.ImageDataGridViewImageColumn.Width = 125
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.CarInformationDataSet
        '
        'CarInformationDataSet
        '
        Me.CarInformationDataSet.DataSetName = "CarInformationDataSet"
        Me.CarInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'btnMenu
        '
        Me.btnMenu.BackgroundImage = Global.CarDatabase.My.Resources.Resources.Screenshot_2022_10_21_135108
        Me.btnMenu.Location = New System.Drawing.Point(1214, 403)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(98, 35)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'DisplayCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CarDatabase.My.Resources.Resources.car_database_display_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1355, 450)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DisplayCars"
        Me.Text = "DisplayCars"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CarInformationDataSet As CarInformationDataSet
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents CarsTableAdapter As CarInformationDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents CarIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EngineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorsepowerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents btnMenu As Button
End Class
