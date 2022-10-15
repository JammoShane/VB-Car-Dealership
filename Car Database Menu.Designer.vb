<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_Database_Menu
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnCars = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(467, 50)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(121, 50)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        '
        'btnCars
        '
        Me.btnCars.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCars.BackgroundImage = Global.Car_Database_Log_In_Page.My.Resources.Resources.Screenshot_2022_10_14_122540
        Me.btnCars.Location = New System.Drawing.Point(467, 103)
        Me.btnCars.Name = "btnCars"
        Me.btnCars.Size = New System.Drawing.Size(114, 48)
        Me.btnCars.TabIndex = 1
        Me.btnCars.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = Global.Car_Database_Log_In_Page.My.Resources.Resources.Screenshot_2022_10_14_122950
        Me.btnInsert.Location = New System.Drawing.Point(467, 169)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(114, 42)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.Car_Database_Log_In_Page.My.Resources.Resources.Screenshot_2022_10_14_123204
        Me.btnAdd.Location = New System.Drawing.Point(467, 229)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 39)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Image = Global.Car_Database_Log_In_Page.My.Resources.Resources.Screenshot_2022_10_14_123406
        Me.btnUpdate.Location = New System.Drawing.Point(467, 286)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 40)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.Image = Global.Car_Database_Log_In_Page.My.Resources.Resources.Screenshot_2022_10_14_123538
        Me.btnDelete.Location = New System.Drawing.Point(467, 345)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 36)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Car_Database_Menu
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Car_Database_Log_In_Page.My.Resources.Resources.car_database_menu_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1017, 459)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnCars)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "Car_Database_Menu"
        Me.Text = "Car Databse Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnCars As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
