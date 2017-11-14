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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtBoxOne = New System.Windows.Forms.TextBox()
        Me.txtBoxTwo = New System.Windows.Forms.TextBox()
        Me.txtBoxThree = New System.Windows.Forms.TextBox()
        Me.txtBoxFour = New System.Windows.Forms.TextBox()
        Me.txtBoxFive = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(28, 227)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(75, 41)
        Me.btnOne.TabIndex = 1
        Me.btnOne.Text = "Calculate Average"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 227)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(32, 50)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(71, 13)
        Me.lblOne.TabIndex = 8
        Me.lblOne.Text = "Test Score 1:"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(32, 74)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(71, 13)
        Me.lblTwo.TabIndex = 9
        Me.lblTwo.Text = "Test Score 2:"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(32, 100)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(71, 13)
        Me.lblThree.TabIndex = 10
        Me.lblThree.Text = "Test Score 3:"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Location = New System.Drawing.Point(32, 127)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(71, 13)
        Me.lblFour.TabIndex = 11
        Me.lblFour.Text = "Test Score 4:"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(32, 156)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(71, 13)
        Me.lblFive.TabIndex = 12
        Me.lblFive.Text = "Test Score 5:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(53, 180)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(50, 13)
        Me.lblAverage.TabIndex = 13
        Me.lblAverage.Text = "Average:"
        '
        'txtBoxOne
        '
        Me.txtBoxOne.Location = New System.Drawing.Point(120, 50)
        Me.txtBoxOne.Name = "txtBoxOne"
        Me.txtBoxOne.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxOne.TabIndex = 14
        '
        'txtBoxTwo
        '
        Me.txtBoxTwo.Location = New System.Drawing.Point(120, 76)
        Me.txtBoxTwo.Name = "txtBoxTwo"
        Me.txtBoxTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTwo.TabIndex = 15
        '
        'txtBoxThree
        '
        Me.txtBoxThree.Location = New System.Drawing.Point(120, 102)
        Me.txtBoxThree.Name = "txtBoxThree"
        Me.txtBoxThree.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxThree.TabIndex = 16
        '
        'txtBoxFour
        '
        Me.txtBoxFour.Location = New System.Drawing.Point(120, 128)
        Me.txtBoxFour.Name = "txtBoxFour"
        Me.txtBoxFour.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxFour.TabIndex = 17
        '
        'txtBoxFive
        '
        Me.txtBoxFive.Location = New System.Drawing.Point(120, 156)
        Me.txtBoxFive.Name = "txtBoxFive"
        Me.txtBoxFive.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxFive.TabIndex = 18
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(120, 180)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 306)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtBoxFive)
        Me.Controls.Add(Me.txtBoxFour)
        Me.Controls.Add(Me.txtBoxThree)
        Me.Controls.Add(Me.txtBoxTwo)
        Me.Controls.Add(Me.txtBoxOne)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents lblFour As System.Windows.Forms.Label
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents txtBoxOne As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxThree As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFour As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFive As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
