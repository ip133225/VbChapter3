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
        Me.lblActualValue = New System.Windows.Forms.Label()
        Me.lblAssessmentTax = New System.Windows.Forms.Label()
        Me.txtBoxOne = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblActualValue
        '
        Me.lblActualValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualValue.Location = New System.Drawing.Point(21, 39)
        Me.lblActualValue.Name = "lblActualValue"
        Me.lblActualValue.Size = New System.Drawing.Size(162, 16)
        Me.lblActualValue.TabIndex = 10
        Me.lblActualValue.Text = "Actual Property Value"
        '
        'lblAssessmentTax
        '
        Me.lblAssessmentTax.AutoSize = True
        Me.lblAssessmentTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssessmentTax.Location = New System.Drawing.Point(174, 39)
        Me.lblAssessmentTax.Name = "lblAssessmentTax"
        Me.lblAssessmentTax.Size = New System.Drawing.Size(138, 15)
        Me.lblAssessmentTax.TabIndex = 11
        Me.lblAssessmentTax.Text = "Assessment and Tax"
        '
        'txtBoxOne
        '
        Me.txtBoxOne.Location = New System.Drawing.Point(24, 83)
        Me.txtBoxOne.Name = "txtBoxOne"
        Me.txtBoxOne.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxOne.TabIndex = 16
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(177, 80)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 17
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(24, 140)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 41)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(128, 140)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(237, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 209)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtBoxOne)
        Me.Controls.Add(Me.lblAssessmentTax)
        Me.Controls.Add(Me.lblActualValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblActualValue As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentTax As System.Windows.Forms.Label
    Friend WithEvents txtBoxOne As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
