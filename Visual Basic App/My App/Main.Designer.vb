<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnExplore = New System.Windows.Forms.Button()
        Me.grpHead = New System.Windows.Forms.GroupBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(-4, 703)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(493, 60)
        Me.btnSign.TabIndex = 1
        Me.btnSign.Text = "SIGN IN"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnExplore
        '
        Me.btnExplore.Location = New System.Drawing.Point(-4, 645)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(493, 60)
        Me.btnExplore.TabIndex = 0
        Me.btnExplore.Text = "EXPLORE"
        Me.btnExplore.UseVisualStyleBackColor = True
        '
        'grpHead
        '
        Me.grpHead.Controls.Add(Me.lblX)
        Me.grpHead.Controls.Add(Me.lblTitle)
        Me.grpHead.Location = New System.Drawing.Point(-2, -6)
        Me.grpHead.Name = "grpHead"
        Me.grpHead.Size = New System.Drawing.Size(489, 57)
        Me.grpHead.TabIndex = 2
        Me.grpHead.TabStop = False
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(21, 19)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(26, 25)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "X"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(224, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(41, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "MAIN"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(484, 761)
        Me.Controls.Add(Me.grpHead)
        Me.Controls.Add(Me.btnExplore)
        Me.Controls.Add(Me.btnSign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.grpHead.ResumeLayout(False)
        Me.grpHead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnExplore As System.Windows.Forms.Button
    Friend WithEvents grpHead As System.Windows.Forms.GroupBox
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
