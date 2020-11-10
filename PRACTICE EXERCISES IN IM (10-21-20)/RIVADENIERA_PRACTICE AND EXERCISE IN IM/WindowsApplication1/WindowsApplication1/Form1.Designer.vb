<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(78, 142)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(103, 43)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "&Test "
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Computer Generated Number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'txtNumber
        '
        Me.txtNumber.AutoSize = True
        Me.txtNumber.Location = New System.Drawing.Point(106, 92)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(0, 13)
        Me.txtNumber.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTest)
        Me.Name = "Form1"
        Me.Text = "Ramdom Generator "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.Label

End Class
