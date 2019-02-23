<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.grpHead = New System.Windows.Forms.GroupBox()
        Me.lblDone = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.btnFacebook = New System.Windows.Forms.Button()
        Me.lblSignup = New System.Windows.Forms.Label()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.lblWarn = New System.Windows.Forms.Label()
        Me.grpHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLocation
        '
        Me.btnLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocation.Location = New System.Drawing.Point(-3, 663)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(125, 100)
        Me.btnLocation.TabIndex = 6
        Me.btnLocation.Text = "Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivery.Location = New System.Drawing.Point(120, 663)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(125, 100)
        Me.btnDelivery.TabIndex = 7
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Location = New System.Drawing.Point(240, 663)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(125, 100)
        Me.btnProducts.TabIndex = 8
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMore.Location = New System.Drawing.Point(362, 663)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(125, 100)
        Me.btnMore.TabIndex = 9
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Location = New System.Drawing.Point(152, 110)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(180, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.Text = "password"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(152, 75)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.Text = "email"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpHead
        '
        Me.grpHead.Controls.Add(Me.lblDone)
        Me.grpHead.Controls.Add(Me.lblX)
        Me.grpHead.Controls.Add(Me.lblTitle)
        Me.grpHead.Location = New System.Drawing.Point(-2, -6)
        Me.grpHead.Name = "grpHead"
        Me.grpHead.Size = New System.Drawing.Size(489, 57)
        Me.grpHead.TabIndex = 10
        Me.grpHead.TabStop = False
        '
        'lblDone
        '
        Me.lblDone.AutoSize = True
        Me.lblDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDone.Location = New System.Drawing.Point(418, 23)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(55, 20)
        Me.lblDone.TabIndex = 0
        Me.lblDone.Text = "DONE"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(21, 19)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(26, 25)
        Me.lblX.TabIndex = 1
        Me.lblX.Text = "X"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(216, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(56, 16)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "SIGN IN"
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgot.Location = New System.Drawing.Point(198, 145)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(88, 13)
        Me.lblForgot.TabIndex = 2
        Me.lblForgot.Text = "forgot password?"
        '
        'btnFacebook
        '
        Me.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacebook.Location = New System.Drawing.Point(163, 210)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.Size = New System.Drawing.Size(158, 23)
        Me.btnFacebook.TabIndex = 4
        Me.btnFacebook.Text = "facebook"
        Me.btnFacebook.UseVisualStyleBackColor = True
        '
        'lblSignup
        '
        Me.lblSignup.AutoSize = True
        Me.lblSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignup.Location = New System.Drawing.Point(222, 255)
        Me.lblSignup.Name = "lblSignup"
        Me.lblSignup.Size = New System.Drawing.Size(41, 13)
        Me.lblSignup.TabIndex = 5
        Me.lblSignup.Text = "sign up"
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(171, 175)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(142, 13)
        Me.lblOr.TabIndex = 3
        Me.lblOr.Text = "-------------------- or --------------------"
        '
        'lblWarn
        '
        Me.lblWarn.Location = New System.Drawing.Point(338, 75)
        Me.lblWarn.Name = "lblWarn"
        Me.lblWarn.Size = New System.Drawing.Size(123, 54)
        Me.lblWarn.TabIndex = 11
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 761)
        Me.Controls.Add(Me.lblWarn)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.lblSignup)
        Me.Controls.Add(Me.btnFacebook)
        Me.Controls.Add(Me.lblForgot)
        Me.Controls.Add(Me.grpHead)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.btnDelivery)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnMore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.grpHead.ResumeLayout(False)
        Me.grpHead.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLocation As System.Windows.Forms.Button
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnMore As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents grpHead As System.Windows.Forms.GroupBox
    Friend WithEvents lblDone As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblForgot As System.Windows.Forms.Label
    Friend WithEvents btnFacebook As System.Windows.Forms.Button
    Friend WithEvents lblSignup As System.Windows.Forms.Label
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents lblWarn As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
