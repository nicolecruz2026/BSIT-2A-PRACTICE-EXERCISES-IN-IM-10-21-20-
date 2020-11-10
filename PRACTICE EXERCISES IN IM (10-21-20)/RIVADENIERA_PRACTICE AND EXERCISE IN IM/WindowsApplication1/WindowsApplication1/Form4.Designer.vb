<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstTerms = New System.Windows.Forms.ListBox()
        Me.rchMeaning = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstTerms)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 188)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Internet Topologies"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rchMeaning)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 188)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Meaning "
        '
        'lstTerms
        '
        Me.lstTerms.FormattingEnabled = True
        Me.lstTerms.Items.AddRange(New Object() {"Packet ", "Router ", "Firewall ", "Telnet ", "Protocol "})
        Me.lstTerms.Location = New System.Drawing.Point(14, 40)
        Me.lstTerms.Name = "lstTerms"
        Me.lstTerms.Size = New System.Drawing.Size(108, 121)
        Me.lstTerms.TabIndex = 0
        '
        'rchMeaning
        '
        Me.rchMeaning.Location = New System.Drawing.Point(11, 40)
        Me.rchMeaning.Name = "rchMeaning"
        Me.rchMeaning.Size = New System.Drawing.Size(122, 120)
        Me.rchMeaning.TabIndex = 0
        Me.rchMeaning.Text = ""
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 284)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "List Box & RichTextBox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTerms As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rchMeaning As System.Windows.Forms.RichTextBox
End Class
