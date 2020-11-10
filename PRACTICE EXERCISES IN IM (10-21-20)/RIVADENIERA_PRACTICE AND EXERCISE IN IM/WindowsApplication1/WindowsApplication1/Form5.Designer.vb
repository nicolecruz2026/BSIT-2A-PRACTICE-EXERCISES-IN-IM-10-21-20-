<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lst2 = New System.Windows.Forms.ListBox()
        Me.bntClearAll = New System.Windows.Forms.Button()
        Me.bntClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Underwear"
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Items.AddRange(New Object() {"Bra", "Panty ", "Brief", "Sando"})
        Me.lst1.Location = New System.Drawing.Point(17, 36)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(97, 108)
        Me.lst1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst2)
        Me.GroupBox2.Location = New System.Drawing.Point(178, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected Underwear"
        '
        'lst2
        '
        Me.lst2.FormattingEnabled = True
        Me.lst2.Location = New System.Drawing.Point(13, 38)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(101, 108)
        Me.lst2.TabIndex = 0
        '
        'bntClearAll
        '
        Me.bntClearAll.Location = New System.Drawing.Point(25, 214)
        Me.bntClearAll.Name = "bntClearAll"
        Me.bntClearAll.Size = New System.Drawing.Size(91, 31)
        Me.bntClearAll.TabIndex = 2
        Me.bntClearAll.Text = "Clear All"
        Me.bntClearAll.UseVisualStyleBackColor = True
        '
        'bntClear
        '
        Me.bntClear.Location = New System.Drawing.Point(140, 214)
        Me.bntClear.Name = "bntClear"
        Me.bntClear.Size = New System.Drawing.Size(152, 31)
        Me.bntClear.TabIndex = 3
        Me.bntClear.Text = "Clear Selected Item "
        Me.bntClear.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 261)
        Me.Controls.Add(Me.bntClear)
        Me.Controls.Add(Me.bntClearAll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "2 List Box "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lst2 As System.Windows.Forms.ListBox
    Friend WithEvents bntClearAll As System.Windows.Forms.Button
    Friend WithEvents bntClear As System.Windows.Forms.Button
End Class
