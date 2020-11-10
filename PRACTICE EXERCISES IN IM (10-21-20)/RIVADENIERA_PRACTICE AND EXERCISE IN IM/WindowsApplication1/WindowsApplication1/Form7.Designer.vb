<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.picBaby = New System.Windows.Forms.PictureBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        CType(Me.picBaby, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBaby
        '
        Me.picBaby.Image = CType(resources.GetObject("picBaby.Image"), System.Drawing.Image)
        Me.picBaby.Location = New System.Drawing.Point(21, 19)
        Me.picBaby.Name = "picBaby"
        Me.picBaby.Size = New System.Drawing.Size(285, 158)
        Me.picBaby.TabIndex = 0
        Me.picBaby.TabStop = False
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(29, 190)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(81, 28)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Show "
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(185, 190)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(81, 28)
        Me.btnHide.TabIndex = 2
        Me.btnHide.Text = "Hide "
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(29, 224)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(81, 28)
        Me.btnEnable.TabIndex = 3
        Me.btnEnable.Text = "Enable"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(185, 221)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(81, 28)
        Me.btnDisable.TabIndex = 4
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 261)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.picBaby)
        Me.Name = "Form7"
        Me.Text = "PictureBox"
        CType(Me.picBaby, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBaby As System.Windows.Forms.PictureBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button
End Class
