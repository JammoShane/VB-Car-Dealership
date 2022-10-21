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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMenu.Font = New System.Drawing.Font("Consolas", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblMenu.Location = New System.Drawing.Point(612, 84)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(118, 51)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackgroundImage = Global.CarDatabase.My.Resources.Resources.Screenshot_2022_10_14_122540
        Me.btnDisplay.Location = New System.Drawing.Point(618, 159)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(135, 52)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = Global.CarDatabase.My.Resources.Resources.Screenshot_2022_10_14_122829
        Me.btnInsert.Location = New System.Drawing.Point(618, 217)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(112, 45)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.CarDatabase.My.Resources.Resources.Screenshot_2022_10_14_123204
        Me.btnAdd.Location = New System.Drawing.Point(618, 268)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 46)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.CarDatabase.My.Resources.Resources.Screenshot_2022_10_14_123406
        Me.btnUpdate.Location = New System.Drawing.Point(618, 333)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 47)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.CarDatabase.My.Resources.Resources.Screenshot_2022_10_21_134127
        Me.btnExit.Location = New System.Drawing.Point(621, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 44)
        Me.btnExit.TabIndex = 5
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Car_Database_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CarDatabase.My.Resources.Resources.car_database_menu_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1332, 690)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblMenu)
        Me.Name = "Car_Database_Menu"
        Me.Text = "Car_Database_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
End Class
