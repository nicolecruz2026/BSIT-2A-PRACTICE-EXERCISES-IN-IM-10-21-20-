<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstParts = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDisc = New System.Windows.Forms.ComboBox()
        Me.lblUPrice = New System.Windows.Forms.Label()
        Me.lblSubTot = New System.Windows.Forms.Label()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.lblTotAmt = New System.Windows.Forms.Label()
        Me.nudQuan = New System.Windows.Forms.NumericUpDown()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstParts)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Parts"
        '
        'lstParts
        '
        Me.lstParts.FormattingEnabled = True
        Me.lstParts.Items.AddRange(New Object() {"Monitor ", "Keyboard ", "Mouse ", "Hard Disk ", "Disk Drive"})
        Me.lstParts.Location = New System.Drawing.Point(16, 32)
        Me.lstParts.Name = "lstParts"
        Me.lstParts.Size = New System.Drawing.Size(109, 95)
        Me.lstParts.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboDisc)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discount Rate "
        '
        'cboDisc
        '
        Me.cboDisc.FormattingEnabled = True
        Me.cboDisc.Items.AddRange(New Object() {"5%, ", "10%,", " 15% ", "&", " No Discount "})
        Me.cboDisc.Location = New System.Drawing.Point(14, 23)
        Me.cboDisc.Name = "cboDisc"
        Me.cboDisc.Size = New System.Drawing.Size(108, 21)
        Me.cboDisc.TabIndex = 0
        '
        'lblUPrice
        '
        Me.lblUPrice.AutoSize = True
        Me.lblUPrice.Location = New System.Drawing.Point(348, 40)
        Me.lblUPrice.Name = "lblUPrice"
        Me.lblUPrice.Size = New System.Drawing.Size(39, 13)
        Me.lblUPrice.TabIndex = 2
        Me.lblUPrice.Text = "Label1"
        Me.lblUPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubTot
        '
        Me.lblSubTot.AutoSize = True
        Me.lblSubTot.Location = New System.Drawing.Point(348, 142)
        Me.lblSubTot.Name = "lblSubTot"
        Me.lblSubTot.Size = New System.Drawing.Size(39, 13)
        Me.lblSubTot.TabIndex = 3
        Me.lblSubTot.Text = "Label2"
        Me.lblSubTot.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDisc
        '
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Location = New System.Drawing.Point(348, 184)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(39, 13)
        Me.lblDisc.TabIndex = 4
        Me.lblDisc.Text = "Label3"
        Me.lblDisc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotAmt
        '
        Me.lblTotAmt.AutoSize = True
        Me.lblTotAmt.Location = New System.Drawing.Point(348, 230)
        Me.lblTotAmt.Name = "lblTotAmt"
        Me.lblTotAmt.Size = New System.Drawing.Size(39, 13)
        Me.lblTotAmt.TabIndex = 5
        Me.lblTotAmt.Text = "Label4"
        Me.lblTotAmt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nudQuan
        '
        Me.nudQuan.Location = New System.Drawing.Point(341, 85)
        Me.nudQuan.Name = "nudQuan"
        Me.nudQuan.Size = New System.Drawing.Size(45, 20)
        Me.nudQuan.TabIndex = 6
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(33, 267)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(95, 27)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Compute "
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(154, 267)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 27)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(275, 267)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 27)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Unit Price :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sub-Total :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Discount :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total Amount  :"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 302)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.nudQuan)
        Me.Controls.Add(Me.lblTotAmt)
        Me.Controls.Add(Me.lblDisc)
        Me.Controls.Add(Me.lblSubTot)
        Me.Controls.Add(Me.lblUPrice)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Combo Box, List Box & NumericUpDowm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudQuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstParts As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDisc As System.Windows.Forms.ComboBox
    Friend WithEvents lblUPrice As System.Windows.Forms.Label
    Friend WithEvents lblSubTot As System.Windows.Forms.Label
    Friend WithEvents lblDisc As System.Windows.Forms.Label
    Friend WithEvents lblTotAmt As System.Windows.Forms.Label
    Friend WithEvents nudQuan As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
