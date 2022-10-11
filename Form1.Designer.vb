<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpbxLogIn = New System.Windows.Forms.GroupBox()
        Me.grpbxLogIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtUserName.Location = New System.Drawing.Point(241, 54)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(172, 36)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(241, 103)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(172, 36)
        Me.txtPassword.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(32, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogIn.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogIn.Location = New System.Drawing.Point(319, 268)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(94, 32)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Location = New System.Drawing.Point(178, 268)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 32)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'grpbxLogIn
        '
        Me.grpbxLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.grpbxLogIn.Controls.Add(Me.txtUserName)
        Me.grpbxLogIn.Controls.Add(Me.btnExit)
        Me.grpbxLogIn.Controls.Add(Me.btnReset)
        Me.grpbxLogIn.Controls.Add(Me.Label1)
        Me.grpbxLogIn.Controls.Add(Me.btnLogIn)
        Me.grpbxLogIn.Controls.Add(Me.Label2)
        Me.grpbxLogIn.Controls.Add(Me.txtPassword)
        Me.grpbxLogIn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpbxLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpbxLogIn.Location = New System.Drawing.Point(30, 35)
        Me.grpbxLogIn.Name = "grpbxLogIn"
        Me.grpbxLogIn.Size = New System.Drawing.Size(433, 320)
        Me.grpbxLogIn.TabIndex = 7
        Me.grpbxLogIn.TabStop = False
        Me.grpbxLogIn.Text = "Log In"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Car_Database_Log_In_Page.My.Resources.Resources.car_database_log_in_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1083, 487)
        Me.Controls.Add(Me.grpbxLogIn)
        Me.Name = "Form1"
        Me.Text = "Car Database Log In"
        Me.grpbxLogIn.ResumeLayout(False)
        Me.grpbxLogIn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grpbxLogIn As GroupBox
End Class
