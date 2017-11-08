<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtOne
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
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTen = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(9, 25)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(120, 13)
        Me.lblOne.TabIndex = 0
        Me.lblOne.Text = "Enter A Number or Date"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(12, 65)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(51, 13)
        Me.lblTwo.TabIndex = 1
        Me.lblTwo.Text = "Fomatted"
        '
        'lblThree
        '
        Me.lblThree.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThree.Location = New System.Drawing.Point(69, 53)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(181, 25)
        Me.lblThree.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTen)
        Me.GroupBox1.Controls.Add(Me.btnNine)
        Me.GroupBox1.Controls.Add(Me.btnEight)
        Me.GroupBox1.Controls.Add(Me.btnSeven)
        Me.GroupBox1.Controls.Add(Me.btnSix)
        Me.GroupBox1.Controls.Add(Me.btnFive)
        Me.GroupBox1.Controls.Add(Me.btnFour)
        Me.GroupBox1.Controls.Add(Me.btnThree)
        Me.GroupBox1.Controls.Add(Me.btnTwo)
        Me.GroupBox1.Controls.Add(Me.btnOne)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 179)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select A Format"
        '
        'btnTen
        '
        Me.btnTen.Location = New System.Drawing.Point(132, 137)
        Me.btnTen.Name = "btnTen"
        Me.btnTen.Size = New System.Drawing.Size(120, 23)
        Me.btnTen.TabIndex = 9
        Me.btnTen.Text = "Full Date/Time (F)"
        Me.btnTen.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Location = New System.Drawing.Point(132, 108)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(120, 23)
        Me.btnNine.TabIndex = 8
        Me.btnNine.Text = "Long Time (T)"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Location = New System.Drawing.Point(132, 77)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(120, 23)
        Me.btnEight.TabIndex = 7
        Me.btnEight.Text = "Short Time (t)"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Location = New System.Drawing.Point(132, 48)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(120, 23)
        Me.btnSeven.TabIndex = 6
        Me.btnSeven.Text = "Long Date (D)"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Location = New System.Drawing.Point(132, 19)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(120, 23)
        Me.btnSix.TabIndex = 5
        Me.btnSix.Text = "Show Date (d)"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(6, 137)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(120, 23)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "Percent format (p)"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(6, 108)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(120, 23)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "Currency Format (c)"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(6, 77)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(120, 23)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "Exponential Format (e)"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(6, 48)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(120, 23)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "Fixed-Point Format (f)"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(6, 19)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(120, 23)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "Number Format (n)"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(150, 25)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntry.TabIndex = 4
        '
        'txtOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(270, 315)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Name = "txtOne"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTen As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox

End Class
