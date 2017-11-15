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
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(12, 209)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(75, 41)
        Me.btnOne.TabIndex = 2
        Me.btnOne.Text = "Calculate MPG"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(102, 209)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGallons
        '
        Me.lblGallons.Location = New System.Drawing.Point(25, 34)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(110, 46)
        Me.lblGallons.TabIndex = 9
        Me.lblGallons.Text = "Gallons of gas the car can hold:"
        '
        'lblMiles
        '
        Me.lblMiles.Location = New System.Drawing.Point(25, 99)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(110, 41)
        Me.lblMiles.TabIndex = 10
        Me.lblMiles.Text = "Number of miles it can be driven on a full tank: "
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(25, 160)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(85, 13)
        Me.lblMPG.TabIndex = 11
        Me.lblMPG.Text = "Miles per Gallon:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(152, 34)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 15
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(152, 99)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 16
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(152, 160)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.lblGallons)
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
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents lblMiles As System.Windows.Forms.Label
    Friend WithEvents lblMPG As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
