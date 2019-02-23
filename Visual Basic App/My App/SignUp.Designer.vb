<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.grpHead = New System.Windows.Forms.GroupBox()
        Me.lblDone = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblPassWarn = New System.Windows.Forms.Label()
        Me.lblNameWarn = New System.Windows.Forms.Label()
        Me.lblEmailWarn = New System.Windows.Forms.Label()
        Me.lblPhoneWarn = New System.Windows.Forms.Label()
        Me.lblSorry = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtApt = New System.Windows.Forms.TextBox()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.grpHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpHead
        '
        Me.grpHead.Controls.Add(Me.lblDone)
        Me.grpHead.Controls.Add(Me.lblTitle)
        Me.grpHead.Controls.Add(Me.lblBack)
        Me.grpHead.Location = New System.Drawing.Point(-2, -6)
        Me.grpHead.Name = "grpHead"
        Me.grpHead.Size = New System.Drawing.Size(489, 57)
        Me.grpHead.TabIndex = 14
        Me.grpHead.TabStop = False
        '
        'lblDone
        '
        Me.lblDone.AutoSize = True
        Me.lblDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDone.Location = New System.Drawing.Point(418, 23)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(51, 20)
        Me.lblDone.TabIndex = 1
        Me.lblDone.Text = "NEXT"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(213, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 16)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "SIGN UP"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(21, 19)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(24, 25)
        Me.lblBack.TabIndex = 0
        Me.lblBack.Text = "<"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(152, 275)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(180, 20)
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.Text = "phone number"
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(152, 135)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "full name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLocation
        '
        Me.btnLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocation.Location = New System.Drawing.Point(-3, 663)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(125, 100)
        Me.btnLocation.TabIndex = 10
        Me.btnLocation.Text = "Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivery.Location = New System.Drawing.Point(120, 663)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(125, 100)
        Me.btnDelivery.TabIndex = 11
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Location = New System.Drawing.Point(240, 663)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(125, 100)
        Me.btnProducts.TabIndex = 12
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMore.Location = New System.Drawing.Point(362, 663)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(125, 100)
        Me.btnMore.TabIndex = 13
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(152, 170)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.Text = "email"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Location = New System.Drawing.Point(152, 205)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(180, 20)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Text = "password"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtConfirm
        '
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirm.Location = New System.Drawing.Point(152, 240)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(180, 20)
        Me.txtConfirm.TabIndex = 3
        Me.txtConfirm.Text = "password confirmation"
        Me.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassWarn
        '
        Me.lblPassWarn.Location = New System.Drawing.Point(338, 240)
        Me.lblPassWarn.Name = "lblPassWarn"
        Me.lblPassWarn.Size = New System.Drawing.Size(129, 23)
        Me.lblPassWarn.TabIndex = 18
        '
        'lblNameWarn
        '
        Me.lblNameWarn.Location = New System.Drawing.Point(338, 135)
        Me.lblNameWarn.Name = "lblNameWarn"
        Me.lblNameWarn.Size = New System.Drawing.Size(129, 23)
        Me.lblNameWarn.TabIndex = 16
        '
        'lblEmailWarn
        '
        Me.lblEmailWarn.Location = New System.Drawing.Point(338, 170)
        Me.lblEmailWarn.Name = "lblEmailWarn"
        Me.lblEmailWarn.Size = New System.Drawing.Size(129, 23)
        Me.lblEmailWarn.TabIndex = 17
        '
        'lblPhoneWarn
        '
        Me.lblPhoneWarn.Location = New System.Drawing.Point(338, 275)
        Me.lblPhoneWarn.Name = "lblPhoneWarn"
        Me.lblPhoneWarn.Size = New System.Drawing.Size(129, 23)
        Me.lblPhoneWarn.TabIndex = 19
        '
        'lblSorry
        '
        Me.lblSorry.Location = New System.Drawing.Point(178, 544)
        Me.lblSorry.Name = "lblSorry"
        Me.lblSorry.Size = New System.Drawing.Size(129, 23)
        Me.lblSorry.TabIndex = 20
        Me.lblSorry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStreet
        '
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreet.Location = New System.Drawing.Point(152, 345)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(180, 20)
        Me.txtStreet.TabIndex = 5
        Me.txtStreet.Text = "street"
        Me.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(152, 415)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(180, 20)
        Me.txtCity.TabIndex = 7
        Me.txtCity.Text = "city"
        Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Location = New System.Drawing.Point(152, 450)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(180, 20)
        Me.txtState.TabIndex = 8
        Me.txtState.Text = "state"
        Me.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtZip
        '
        Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZip.Location = New System.Drawing.Point(152, 485)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(180, 20)
        Me.txtZip.TabIndex = 9
        Me.txtZip.Text = "zip"
        Me.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtApt
        '
        Me.txtApt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApt.Location = New System.Drawing.Point(152, 380)
        Me.txtApt.Name = "txtApt"
        Me.txtApt.Size = New System.Drawing.Size(180, 20)
        Me.txtApt.TabIndex = 6
        Me.txtApt.Text = "apt"
        Me.txtApt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Location = New System.Drawing.Point(176, 310)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(133, 13)
        Me.lblDelivery.TabIndex = 15
        Me.lblDelivery.Text = "-------------- delivery --------------"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 761)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.txtApt)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.lblSorry)
        Me.Controls.Add(Me.lblPhoneWarn)
        Me.Controls.Add(Me.lblEmailWarn)
        Me.Controls.Add(Me.lblNameWarn)
        Me.Controls.Add(Me.lblPassWarn)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.grpHead)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.btnDelivery)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnMore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.grpHead.ResumeLayout(False)
        Me.grpHead.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpHead As System.Windows.Forms.GroupBox
    Friend WithEvents lblDone As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnLocation As System.Windows.Forms.Button
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnMore As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblPassWarn As System.Windows.Forms.Label
    Friend WithEvents lblNameWarn As System.Windows.Forms.Label
    Friend WithEvents lblEmailWarn As System.Windows.Forms.Label
    Friend WithEvents lblPhoneWarn As System.Windows.Forms.Label
    Friend WithEvents lblSorry As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtApt As System.Windows.Forms.TextBox
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
End Class
