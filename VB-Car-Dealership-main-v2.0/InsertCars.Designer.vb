<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertCars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsertCars))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCarID = New System.Windows.Forms.TextBox()
        Me.txtCarModelName = New System.Windows.Forms.TextBox()
        Me.txtCarBrandName = New System.Windows.Forms.TextBox()
        Me.txtCarEngineSize = New System.Windows.Forms.TextBox()
        Me.txtCarHorsepower = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Car Model Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Car Brand Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter Car Engine Size:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enter Car Horsepower: "
        '
        'txtCarID
        '
        Me.txtCarID.Location = New System.Drawing.Point(325, 38)
        Me.txtCarID.Name = "txtCarID"
        Me.txtCarID.Size = New System.Drawing.Size(225, 22)
        Me.txtCarID.TabIndex = 5
        '
        'txtCarModelName
        '
        Me.txtCarModelName.Location = New System.Drawing.Point(325, 103)
        Me.txtCarModelName.Name = "txtCarModelName"
        Me.txtCarModelName.Size = New System.Drawing.Size(225, 22)
        Me.txtCarModelName.TabIndex = 6
        '
        'txtCarBrandName
        '
        Me.txtCarBrandName.Location = New System.Drawing.Point(325, 165)
        Me.txtCarBrandName.Name = "txtCarBrandName"
        Me.txtCarBrandName.Size = New System.Drawing.Size(225, 22)
        Me.txtCarBrandName.TabIndex = 7
        '
        'txtCarEngineSize
        '
        Me.txtCarEngineSize.Location = New System.Drawing.Point(325, 226)
        Me.txtCarEngineSize.Name = "txtCarEngineSize"
        Me.txtCarEngineSize.Size = New System.Drawing.Size(225, 22)
        Me.txtCarEngineSize.TabIndex = 8
        '
        'txtCarHorsepower
        '
        Me.txtCarHorsepower.Location = New System.Drawing.Point(325, 285)
        Me.txtCarHorsepower.Name = "txtCarHorsepower"
        Me.txtCarHorsepower.Size = New System.Drawing.Size(225, 22)
        Me.txtCarHorsepower.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 71)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(286, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 71)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(158, 479)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(208, 71)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 29)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Enter Car ID: "
        '
        'InsertCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1041, 618)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCarHorsepower)
        Me.Controls.Add(Me.txtCarEngineSize)
        Me.Controls.Add(Me.txtCarBrandName)
        Me.Controls.Add(Me.txtCarModelName)
        Me.Controls.Add(Me.txtCarID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InsertCars"
        Me.Text = "InsertCar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents txtCarModelName As TextBox
    Friend WithEvents txtCarBrandName As TextBox
    Friend WithEvents txtCarEngineSize As TextBox
    Friend WithEvents txtCarHorsepower As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
End Class
