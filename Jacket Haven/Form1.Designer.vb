<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtNavy = New System.Windows.Forms.TextBox()
        Me.txtBlack = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.lblOrdered = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.chkCreditCard = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRed)
        Me.GroupBox1.Controls.Add(Me.txtNavy)
        Me.GroupBox1.Controls.Add(Me.txtBlack)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordered"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(51, 102)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(78, 20)
        Me.txtRed.TabIndex = 6
        '
        'txtNavy
        '
        Me.txtNavy.Location = New System.Drawing.Point(51, 59)
        Me.txtNavy.Name = "txtNavy"
        Me.txtNavy.Size = New System.Drawing.Size(78, 20)
        Me.txtNavy.TabIndex = 5
        '
        'txtBlack
        '
        Me.txtBlack.Location = New System.Drawing.Point(51, 19)
        Me.txtBlack.Name = "txtBlack"
        Me.txtBlack.Size = New System.Drawing.Size(78, 20)
        Me.txtBlack.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Red:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Navy:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Black:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblSaved)
        Me.GroupBox2.Controls.Add(Me.lblOrdered)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 83)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(240, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Saved:"
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSaved.Location = New System.Drawing.Point(240, 50)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(75, 30)
        Me.lblSaved.TabIndex = 7
        '
        'lblOrdered
        '
        Me.lblOrdered.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblOrdered.Location = New System.Drawing.Point(13, 50)
        Me.lblOrdered.Name = "lblOrdered"
        Me.lblOrdered.Size = New System.Drawing.Size(75, 30)
        Me.lblOrdered.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Due:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Ordered:"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPrice.Location = New System.Drawing.Point(121, 50)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(75, 30)
        Me.lblPrice.TabIndex = 1
        '
        'chkCreditCard
        '
        Me.chkCreditCard.AutoSize = True
        Me.chkCreditCard.Location = New System.Drawing.Point(238, 28)
        Me.chkCreditCard.Name = "chkCreditCard"
        Me.chkCreditCard.Size = New System.Drawing.Size(113, 17)
        Me.chkCreditCard.TabIndex = 2
        Me.chkCreditCard.Text = "&Jacket Credit Card"
        Me.chkCreditCard.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(258, 80)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(258, 118)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Jacket_Haven.My.Resources.Resources.sportswear_storm_fit_windrunner_mens_hooded_jacket_1XlGm6_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(152, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 251)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkCreditCard)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Jacket Haven"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkCreditCard As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtNavy As TextBox
    Friend WithEvents txtBlack As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOrdered As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSaved As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
