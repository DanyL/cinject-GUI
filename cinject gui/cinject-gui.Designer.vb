<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cinjectgui
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
        Me.jailbreak = New System.Windows.Forms.Button()
        Me.credit = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.cmd = New System.Windows.Forms.TextBox()
        Me.nextb = New System.Windows.Forms.Button()
        Me.finish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'jailbreak
        '
        Me.jailbreak.Location = New System.Drawing.Point(153, 73)
        Me.jailbreak.Name = "jailbreak"
        Me.jailbreak.Size = New System.Drawing.Size(129, 23)
        Me.jailbreak.TabIndex = 0
        Me.jailbreak.Text = "Jailbreak"
        Me.jailbreak.UseVisualStyleBackColor = True
        '
        'credit
        '
        Me.credit.AutoSize = True
        Me.credit.Location = New System.Drawing.Point(12, 9)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(154, 26)
        Me.credit.TabIndex = 1
        Me.credit.Text = "cinject 0.4.3 by Dev-Team" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GUI by DanyL (Dany Lisiansky)"
        '
        'info
        '
        Me.info.Location = New System.Drawing.Point(12, 99)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(408, 31)
        Me.info.TabIndex = 2
        Me.info.Text = "Connect your iDevice and hit the jailbreak button"
        Me.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd
        '
        Me.cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmd.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd.Location = New System.Drawing.Point(12, 133)
        Me.cmd.Multiline = True
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(408, 117)
        Me.cmd.TabIndex = 3
        '
        'nextb
        '
        Me.nextb.Location = New System.Drawing.Point(153, 73)
        Me.nextb.Name = "nextb"
        Me.nextb.Size = New System.Drawing.Size(129, 23)
        Me.nextb.TabIndex = 4
        Me.nextb.Text = "Next"
        Me.nextb.UseVisualStyleBackColor = True
        Me.nextb.Visible = False
        '
        'finish
        '
        Me.finish.Location = New System.Drawing.Point(153, 73)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(129, 23)
        Me.finish.TabIndex = 5
        Me.finish.Text = "Finish"
        Me.finish.UseVisualStyleBackColor = True
        Me.finish.Visible = False
        '
        'cinjectgui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(432, 262)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.nextb)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.jailbreak)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "cinjectgui"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cinject 0.4.3 GUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jailbreak As System.Windows.Forms.Button
    Friend WithEvents credit As System.Windows.Forms.Label
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents cmd As System.Windows.Forms.TextBox
    Friend WithEvents nextb As System.Windows.Forms.Button
    Friend WithEvents finish As System.Windows.Forms.Button

End Class
