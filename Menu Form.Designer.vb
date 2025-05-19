<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Form
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtSpaceRaiderZ = New System.Windows.Forms.TextBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnNarrative = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(310, 158)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(163, 56)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(310, 220)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(163, 53)
        Me.btnInstructions.TabIndex = 1
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(310, 409)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(162, 62)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtSpaceRaiderZ
        '
        Me.txtSpaceRaiderZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSpaceRaiderZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpaceRaiderZ.Location = New System.Drawing.Point(158, 72)
        Me.txtSpaceRaiderZ.Name = "txtSpaceRaiderZ"
        Me.txtSpaceRaiderZ.Size = New System.Drawing.Size(436, 80)
        Me.txtSpaceRaiderZ.TabIndex = 3
        Me.txtSpaceRaiderZ.Text = "Space RaiderZ"
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(310, 279)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(163, 60)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnNarrative
        '
        Me.btnNarrative.Location = New System.Drawing.Point(310, 345)
        Me.btnNarrative.Name = "btnNarrative"
        Me.btnNarrative.Size = New System.Drawing.Size(162, 58)
        Me.btnNarrative.TabIndex = 5
        Me.btnNarrative.Text = "Narrative"
        Me.btnNarrative.UseVisualStyleBackColor = True
        '
        'Menu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 580)
        Me.Controls.Add(Me.btnNarrative)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.txtSpaceRaiderZ)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Menu_Form"
        Me.Text = "Menu_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtSpaceRaiderZ As System.Windows.Forms.TextBox
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnNarrative As System.Windows.Forms.Button
End Class
