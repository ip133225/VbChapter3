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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.decTotal = New System.Windows.Forms.Label()
        Me.decTax = New System.Windows.Forms.Label()
        Me.decSubtotal = New System.Windows.Forms.Label()
        Me.lblTwelve = New System.Windows.Forms.Label()
        Me.decAddCharges = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMisc = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.Label()
        Me.txtRoomService = New System.Windows.Forms.Label()
        Me.txtBoxFive = New System.Windows.Forms.TextBox()
        Me.txtBoxFour = New System.Windows.Forms.TextBox()
        Me.decRoomCharges = New System.Windows.Forms.TextBox()
        Me.btnChanges = New System.Windows.Forms.Button()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblNine = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblAddCharges)
        Me.GroupBox1.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox1.Controls.Add(Me.decTotal)
        Me.GroupBox1.Controls.Add(Me.decTax)
        Me.GroupBox1.Controls.Add(Me.decSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblTwelve)
        Me.GroupBox1.Controls.Add(Me.decAddCharges)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Charges"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(180, 108)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 16)
        Me.lblTotal.TabIndex = 9
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(180, 86)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(87, 16)
        Me.lblTax.TabIndex = 8
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(180, 64)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(87, 16)
        Me.lblSubtotal.TabIndex = 7
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddCharges.Location = New System.Drawing.Point(180, 40)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(87, 16)
        Me.lblAddCharges.TabIndex = 6
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomCharges.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRoomCharges.Location = New System.Drawing.Point(180, 16)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(87, 16)
        Me.lblRoomCharges.TabIndex = 5
        '
        'decTotal
        '
        Me.decTotal.AutoSize = True
        Me.decTotal.Location = New System.Drawing.Point(89, 108)
        Me.decTotal.Name = "decTotal"
        Me.decTotal.Size = New System.Drawing.Size(76, 13)
        Me.decTotal.TabIndex = 4
        Me.decTotal.Text = "Total Charges:"
        '
        'decTax
        '
        Me.decTax.AutoSize = True
        Me.decTax.Location = New System.Drawing.Point(137, 86)
        Me.decTax.Name = "decTax"
        Me.decTax.Size = New System.Drawing.Size(28, 13)
        Me.decTax.TabIndex = 3
        Me.decTax.Text = "Tax:"
        '
        'decSubtotal
        '
        Me.decSubtotal.AutoSize = True
        Me.decSubtotal.Location = New System.Drawing.Point(116, 64)
        Me.decSubtotal.Name = "decSubtotal"
        Me.decSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.decSubtotal.TabIndex = 2
        Me.decSubtotal.Text = "Subtotal:"
        '
        'lblTwelve
        '
        Me.lblTwelve.AutoSize = True
        Me.lblTwelve.Location = New System.Drawing.Point(66, 40)
        Me.lblTwelve.Name = "lblTwelve"
        Me.lblTwelve.Size = New System.Drawing.Size(101, 13)
        Me.lblTwelve.TabIndex = 1
        Me.lblTwelve.Text = "Additional Charges :"
        '
        'decAddCharges
        '
        Me.decAddCharges.Location = New System.Drawing.Point(89, 16)
        Me.decAddCharges.Name = "decAddCharges"
        Me.decAddCharges.Size = New System.Drawing.Size(96, 24)
        Me.decAddCharges.TabIndex = 0
        Me.decAddCharges.Text = "Room Charges:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox2.Controls.Add(Me.txtNights)
        Me.GroupBox2.Controls.Add(Me.lblFive)
        Me.GroupBox2.Controls.Add(Me.lblFour)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 105)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Information"
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(87, 46)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(81, 20)
        Me.txtNightlyCharge.TabIndex = 3
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(87, 20)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(81, 20)
        Me.txtNights.TabIndex = 2
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(2, 48)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(79, 13)
        Me.lblFive.TabIndex = 1
        Me.lblFive.Text = "Nightly Charge:"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Location = New System.Drawing.Point(41, 20)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(40, 13)
        Me.lblFour.TabIndex = 0
        Me.lblFour.Text = "Nights:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMisc)
        Me.GroupBox3.Controls.Add(Me.txtTelephone)
        Me.GroupBox3.Controls.Add(Me.txtRoomService)
        Me.GroupBox3.Controls.Add(Me.txtBoxFive)
        Me.GroupBox3.Controls.Add(Me.txtBoxFour)
        Me.GroupBox3.Controls.Add(Me.decRoomCharges)
        Me.GroupBox3.Location = New System.Drawing.Point(192, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 104)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Charges"
        '
        'txtMisc
        '
        Me.txtMisc.AutoSize = True
        Me.txtMisc.Location = New System.Drawing.Point(51, 78)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(32, 13)
        Me.txtMisc.TabIndex = 13
        Me.txtMisc.Text = "Misc:"
        '
        'txtTelephone
        '
        Me.txtTelephone.AutoSize = True
        Me.txtTelephone.Location = New System.Drawing.Point(22, 48)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(61, 13)
        Me.txtTelephone.TabIndex = 12
        Me.txtTelephone.Text = "Telephone:"
        '
        'txtRoomService
        '
        Me.txtRoomService.AutoSize = True
        Me.txtRoomService.Location = New System.Drawing.Point(6, 22)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(77, 13)
        Me.txtRoomService.TabIndex = 11
        Me.txtRoomService.Text = "Room Service:"
        '
        'txtBoxFive
        '
        Me.txtBoxFive.Location = New System.Drawing.Point(89, 78)
        Me.txtBoxFive.Name = "txtBoxFive"
        Me.txtBoxFive.Size = New System.Drawing.Size(81, 20)
        Me.txtBoxFive.TabIndex = 10
        '
        'txtBoxFour
        '
        Me.txtBoxFour.Location = New System.Drawing.Point(89, 48)
        Me.txtBoxFour.Name = "txtBoxFour"
        Me.txtBoxFour.Size = New System.Drawing.Size(81, 20)
        Me.txtBoxFour.TabIndex = 4
        '
        'decRoomCharges
        '
        Me.decRoomCharges.Location = New System.Drawing.Point(89, 19)
        Me.decRoomCharges.Name = "decRoomCharges"
        Me.decRoomCharges.Size = New System.Drawing.Size(81, 20)
        Me.decRoomCharges.TabIndex = 3
        '
        'btnChanges
        '
        Me.btnChanges.Location = New System.Drawing.Point(36, 349)
        Me.btnChanges.Name = "btnChanges"
        Me.btnChanges.Size = New System.Drawing.Size(104, 21)
        Me.btnChanges.TabIndex = 4
        Me.btnChanges.Text = "Calculate Changes"
        Me.btnChanges.UseVisualStyleBackColor = True
        '
        'lblOne
        '
        Me.lblOne.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.Location = New System.Drawing.Point(103, 0)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(200, 34)
        Me.lblOne.TabIndex = 7
        Me.lblOne.Text = "Highlander Hotel"
        Me.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(46, 36)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(73, 13)
        Me.lblTwo.TabIndex = 8
        Me.lblTwo.Text = "Today's Date:"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(84, 66)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(33, 13)
        Me.lblThree.TabIndex = 9
        Me.lblThree.Text = "Time:"
        '
        'lblNine
        '
        Me.lblNine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNine.Location = New System.Drawing.Point(125, 35)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(218, 22)
        Me.lblNine.TabIndex = 0
        '
        'lblTen
        '
        Me.lblTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTen.Location = New System.Drawing.Point(123, 66)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(221, 24)
        Me.lblTen.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 21)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 21)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(373, 382)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTen)
        Me.Controls.Add(Me.lblNine)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.btnChanges)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents lblFour As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMisc As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.Label
    Friend WithEvents txtRoomService As System.Windows.Forms.Label
    Friend WithEvents txtBoxFive As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFour As System.Windows.Forms.TextBox
    Friend WithEvents decRoomCharges As System.Windows.Forms.TextBox
    Friend WithEvents btnChanges As System.Windows.Forms.Button
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents decTotal As System.Windows.Forms.Label
    Friend WithEvents decTax As System.Windows.Forms.Label
    Friend WithEvents decSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTwelve As System.Windows.Forms.Label
    Friend WithEvents decAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblNine As System.Windows.Forms.Label
    Friend WithEvents lblTen As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
