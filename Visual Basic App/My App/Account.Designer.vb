<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.txtCardCvv = New System.Windows.Forms.TextBox()
        Me.txtCardExp = New System.Windows.Forms.TextBox()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.txtApt = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.lblSorry = New System.Windows.Forms.Label()
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
        Me.lblDone.Size = New System.Drawing.Size(55, 20)
        Me.lblDone.TabIndex = 1
        Me.lblDone.Text = "DONE"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(207, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(74, 16)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "ACCOUNT"
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
        'txtCardCvv
        '
        Me.txtCardCvv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardCvv.Location = New System.Drawing.Point(152, 240)
        Me.txtCardCvv.Name = "txtCardCvv"
        Me.txtCardCvv.Size = New System.Drawing.Size(180, 20)
        Me.txtCardCvv.TabIndex = 3
        Me.txtCardCvv.Text = "cvv"
        Me.txtCardCvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCardExp
        '
        Me.txtCardExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardExp.Location = New System.Drawing.Point(152, 205)
        Me.txtCardExp.Name = "txtCardExp"
        Me.txtCardExp.Size = New System.Drawing.Size(180, 20)
        Me.txtCardExp.TabIndex = 2
        Me.txtCardExp.Text = "expiration date"
        Me.txtCardExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCardNum
        '
        Me.txtCardNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNum.Location = New System.Drawing.Point(152, 170)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(180, 20)
        Me.txtCardNum.TabIndex = 1
        Me.txtCardNum.Text = "card number"
        Me.txtCardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCardName
        '
        Me.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardName.Location = New System.Drawing.Point(152, 135)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(180, 20)
        Me.txtCardName.TabIndex = 0
        Me.txtCardName.Text = "card name"
        Me.txtCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Location = New System.Drawing.Point(178, 275)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(129, 13)
        Me.lblDelivery.TabIndex = 15
        Me.lblDelivery.Text = "--------------- billing ---------------"
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(152, 310)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(144, 17)
        Me.chkDelivery.TabIndex = 4
        Me.chkDelivery.Text = "same as delivery address"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'lblSorry
        '
        Me.lblSorry.Location = New System.Drawing.Point(24, 542)
        Me.lblSorry.Name = "lblSorry"
        Me.lblSorry.Size = New System.Drawing.Size(443, 83)
        Me.lblSorry.TabIndex = 16
        Me.lblSorry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 761)
        Me.Controls.Add(Me.lblSorry)
        Me.Controls.Add(Me.chkDelivery)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.txtApt)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtCardCvv)
        Me.Controls.Add(Me.txtCardExp)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.btnDelivery)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.grpHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.grpHead.ResumeLayout(False)
        Me.grpHead.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpHead As System.Windows.Forms.GroupBox
    Friend WithEvents lblDone As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents btnLocation As System.Windows.Forms.Button
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnMore As System.Windows.Forms.Button
    Friend WithEvents txtCardCvv As System.Windows.Forms.TextBox
    Friend WithEvents txtCardExp As System.Windows.Forms.TextBox
    Friend WithEvents txtCardNum As System.Windows.Forms.TextBox
    Friend WithEvents txtCardName As System.Windows.Forms.TextBox
    Friend WithEvents txtApt As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents lblSorry As System.Windows.Forms.Label
End Class
