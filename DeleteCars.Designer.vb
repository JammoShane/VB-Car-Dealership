﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCars
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeleteData = New System.Windows.Forms.TextBox()
        Me.txtDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter car ID:"
        '
        'txtDeleteData
        '
        Me.txtDeleteData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeleteData.Location = New System.Drawing.Point(256, 62)
        Me.txtDeleteData.Name = "txtDeleteData"
        Me.txtDeleteData.Size = New System.Drawing.Size(197, 22)
        Me.txtDeleteData.TabIndex = 1
        '
        'txtDelete
        '
        Me.txtDelete.BackColor = System.Drawing.SystemColors.Control
        Me.txtDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelete.Location = New System.Drawing.Point(104, 323)
        Me.txtDelete.Name = "txtDelete"
        Me.txtDelete.Size = New System.Drawing.Size(115, 47)
        Me.txtDelete.TabIndex = 2
        Me.txtDelete.Text = "Delete"
        Me.txtDelete.UseVisualStyleBackColor = False
        '
        'DeleteCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.CarDatabase.My.Resources.Resources.vb_bg_transformed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDelete)
        Me.Controls.Add(Me.txtDeleteData)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeleteCars"
        Me.Text = "DeleteCars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeleteData As TextBox
    Friend WithEvents txtDelete As Button
End Class
