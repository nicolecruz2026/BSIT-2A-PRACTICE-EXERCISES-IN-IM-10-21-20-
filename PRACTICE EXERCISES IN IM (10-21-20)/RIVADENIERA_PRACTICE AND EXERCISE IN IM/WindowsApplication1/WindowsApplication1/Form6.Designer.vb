<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnCompute1 = New System.Windows.Forms.Button()
        Me.btnCompute2 = New System.Windows.Forms.Button()
        Me.lblTotDays = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpOut = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(18, 41)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(99, 49)
        Me.btnIn.TabIndex = 0
        Me.btnIn.Text = "CHECK IN "
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'btnOut
        '
        Me.btnOut.Location = New System.Drawing.Point(18, 121)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(99, 49)
        Me.btnOut.TabIndex = 1
        Me.btnOut.Text = "CHECK OUT"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'btnCompute1
        '
        Me.btnCompute1.Location = New System.Drawing.Point(61, 209)
        Me.btnCompute1.Name = "btnCompute1"
        Me.btnCompute1.Size = New System.Drawing.Size(99, 49)
        Me.btnCompute1.TabIndex = 2
        Me.btnCompute1.Text = "COMPUTER 1"
        Me.btnCompute1.UseVisualStyleBackColor = True
        '
        'btnCompute2
        '
        Me.btnCompute2.Location = New System.Drawing.Point(321, 209)
        Me.btnCompute2.Name = "btnCompute2"
        Me.btnCompute2.Size = New System.Drawing.Size(99, 49)
        Me.btnCompute2.TabIndex = 3
        Me.btnCompute2.Text = "COMPUTER 2"
        Me.btnCompute2.UseVisualStyleBackColor = True
        '
        'lblTotDays
        '
        Me.lblTotDays.AutoSize = True
        Me.lblTotDays.Location = New System.Drawing.Point(215, 227)
        Me.lblTotDays.Name = "lblTotDays"
        Me.lblTotDays.Size = New System.Drawing.Size(39, 13)
        Me.lblTotDays.TabIndex = 4
        Me.lblTotDays.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpOut)
        Me.GroupBox1.Controls.Add(Me.dtpIn)
        Me.GroupBox1.Location = New System.Drawing.Point(299, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 132)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DateTimePicker "
        '
        'dtpIn
        '
        Me.dtpIn.Location = New System.Drawing.Point(11, 33)
        Me.dtpIn.Name = "dtpIn"
        Me.dtpIn.Size = New System.Drawing.Size(121, 20)
        Me.dtpIn.TabIndex = 0
        Me.dtpIn.Value = New Date(2006, 12, 3, 10, 1, 0, 0)
        '
        'dtpOut
        '
        Me.dtpOut.Location = New System.Drawing.Point(14, 85)
        Me.dtpOut.Name = "dtpOut"
        Me.dtpOut.Size = New System.Drawing.Size(117, 20)
        Me.dtpOut.TabIndex = 1
        Me.dtpOut.Value = New Date(2006, 12, 10, 10, 1, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Days"
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(149, 56)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(113, 20)
        Me.txtIn.TabIndex = 7
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(149, 125)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(113, 20)
        Me.txtOut.TabIndex = 8
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 283)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotDays)
        Me.Controls.Add(Me.btnCompute2)
        Me.Controls.Add(Me.btnCompute1)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.btnIn)
        Me.Name = "Form6"
        Me.Text = "Using DateTimePicker & DateDiff Function"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIn As System.Windows.Forms.Button
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents btnCompute1 As System.Windows.Forms.Button
    Friend WithEvents btnCompute2 As System.Windows.Forms.Button
    Friend WithEvents lblTotDays As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIn As System.Windows.Forms.TextBox
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
End Class
