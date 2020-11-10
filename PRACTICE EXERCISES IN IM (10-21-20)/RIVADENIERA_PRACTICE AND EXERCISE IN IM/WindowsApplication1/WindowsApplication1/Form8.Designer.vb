<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Items.AddRange(New Object() {"Richard", "Noli", "Lester", "Val"})
        Me.lstNames.Location = New System.Drawing.Point(21, 24)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(171, 160)
        Me.lstNames.TabIndex = 0
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Items.AddRange(New Object() {"100", "80", "70", "95"})
        Me.lstScores.Location = New System.Drawing.Point(224, 24)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(113, 160)
        Me.lstScores.TabIndex = 1
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(36, 229)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(88, 23)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "ViewData"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 229)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Scores"
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(234, 197)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(39, 13)
        Me.lblAve.TabIndex = 7
        Me.lblAve.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Average Scores: "
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.lstNames)
        Me.Name = "Form8"
        Me.Text = "Sample Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents lstScores As System.Windows.Forms.ListBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAve As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
