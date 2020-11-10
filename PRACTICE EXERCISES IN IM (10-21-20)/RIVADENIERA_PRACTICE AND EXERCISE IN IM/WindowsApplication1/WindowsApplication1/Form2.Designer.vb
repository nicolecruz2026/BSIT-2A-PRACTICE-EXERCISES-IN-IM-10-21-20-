<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(51, 53)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(2, 33)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(139, 53)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(2, 33)
        Me.lblNum2.TabIndex = 1
        Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.Location = New System.Drawing.Point(231, 53)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(2, 33)
        Me.lblNum3.TabIndex = 2
        Me.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(99, 159)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(88, 39)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "&SPIN"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 261)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "Form2"
        Me.Text = "Lucky Seven Program "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents btnSpin As System.Windows.Forms.Button
End Class
