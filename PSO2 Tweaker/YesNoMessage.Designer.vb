<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YesNoMessage
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
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.message_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.White
        Me.cancel_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources.blankBTN
        Me.cancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancel_btn.FlatAppearance.BorderSize = 0
        Me.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_btn.Font = New System.Drawing.Font("Tahoma", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.cancel_btn.Location = New System.Drawing.Point(276, 97)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(155, 26)
        Me.cancel_btn.TabIndex = 6
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'ok_btn
        '
        Me.ok_btn.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._139EN
        Me.ok_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ok_btn.FlatAppearance.BorderSize = 0
        Me.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok_btn.Location = New System.Drawing.Point(86, 97)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(155, 26)
        Me.ok_btn.TabIndex = 5
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'message_txt
        '
        Me.message_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.message_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.message_txt.Cursor = System.Windows.Forms.Cursors.Default
        Me.message_txt.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_txt.ForeColor = System.Drawing.Color.Cyan
        Me.message_txt.Location = New System.Drawing.Point(29, 20)
        Me.message_txt.Multiline = True
        Me.message_txt.Name = "message_txt"
        Me.message_txt.ReadOnly = True
        Me.message_txt.ShortcutsEnabled = False
        Me.message_txt.Size = New System.Drawing.Size(462, 71)
        Me.message_txt.TabIndex = 4
        Me.message_txt.Text = "The messages will appear here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.message_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'YesNoMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PSO2_Tweaker.My.Resources.Resources._198
        Me.ClientSize = New System.Drawing.Size(520, 150)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.message_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "YesNoMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YesNoMessage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cancel_btn As Button
    Private WithEvents ok_btn As Button
    Friend WithEvents message_txt As TextBox
End Class
