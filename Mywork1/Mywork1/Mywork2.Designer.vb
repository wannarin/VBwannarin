<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mywork2
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
        Me.txtvistra = New System.Windows.Forms.TextBox()
        Me.txtfrita = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lblcommit = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblvis = New System.Windows.Forms.Label()
        Me.lblfri = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtvistra
        '
        Me.txtvistra.Location = New System.Drawing.Point(214, 61)
        Me.txtvistra.Multiline = True
        Me.txtvistra.Name = "txtvistra"
        Me.txtvistra.Size = New System.Drawing.Size(115, 30)
        Me.txtvistra.TabIndex = 0
        '
        'txtfrita
        '
        Me.txtfrita.Location = New System.Drawing.Point(214, 114)
        Me.txtfrita.Multiline = True
        Me.txtfrita.Name = "txtfrita"
        Me.txtfrita.Size = New System.Drawing.Size(115, 30)
        Me.txtfrita.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(39, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ยอดขาย Vistra Gluta"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(39, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ยอดขาย Frista Gluta"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(39, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ยอดขายรวม"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(375, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ค่าคอมมิชชั้นรวม"
        '
        'lblresult
        '
        Me.lblresult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblresult.Location = New System.Drawing.Point(211, 171)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(127, 25)
        Me.lblresult.TabIndex = 2
        Me.lblresult.Text = " "
        '
        'lblcommit
        '
        Me.lblcommit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblcommit.Location = New System.Drawing.Point(533, 166)
        Me.lblcommit.Name = "lblcommit"
        Me.lblcommit.Size = New System.Drawing.Size(127, 25)
        Me.lblcommit.TabIndex = 2
        Me.lblcommit.Text = " "
        '
        'btncalculate
        '
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(244, 239)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(94, 35)
        Me.btncalculate.TabIndex = 2
        Me.btncalculate.Text = " คำนวณ"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(380, 239)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(94, 35)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "ปิดฟอร์ม"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(376, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ค่าคอมมิชช้่น 5%"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(376, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 30)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ค่าคอมมิชช้่น 10%"
        '
        'lblvis
        '
        Me.lblvis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblvis.Location = New System.Drawing.Point(533, 66)
        Me.lblvis.Name = "lblvis"
        Me.lblvis.Size = New System.Drawing.Size(127, 25)
        Me.lblvis.TabIndex = 2
        Me.lblvis.Text = " "
        '
        'lblfri
        '
        Me.lblfri.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblfri.Location = New System.Drawing.Point(533, 117)
        Me.lblfri.Name = "lblfri"
        Me.lblfri.Size = New System.Drawing.Size(127, 25)
        Me.lblfri.TabIndex = 2
        Me.lblfri.Text = " "
        '
        'Mywork2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(705, 313)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.lblfri)
        Me.Controls.Add(Me.lblvis)
        Me.Controls.Add(Me.lblcommit)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfrita)
        Me.Controls.Add(Me.txtvistra)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Mywork2"
        Me.Text = "Mywork2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtvistra As System.Windows.Forms.TextBox
    Friend WithEvents txtfrita As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lblcommit As System.Windows.Forms.Label
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblvis As System.Windows.Forms.Label
    Friend WithEvents lblfri As System.Windows.Forms.Label
End Class
