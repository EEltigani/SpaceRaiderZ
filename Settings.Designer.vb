<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMusic = New System.Windows.Forms.TextBox()
        Me.rdoMusicOn = New System.Windows.Forms.RadioButton()
        Me.rdoMusicOff = New System.Windows.Forms.RadioButton()
        Me.txtSound = New System.Windows.Forms.TextBox()
        Me.RdoOn = New System.Windows.Forms.RadioButton()
        Me.rdoOff = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(557, 129)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(229, 151)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(557, 309)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(229, 150)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 73)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Settings"
        '
        'txtMusic
        '
        Me.txtMusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMusic.Location = New System.Drawing.Point(53, 244)
        Me.txtMusic.Name = "txtMusic"
        Me.txtMusic.Size = New System.Drawing.Size(79, 24)
        Me.txtMusic.TabIndex = 3
        Me.txtMusic.Text = "Music"
        '
        'rdoMusicOn
        '
        Me.rdoMusicOn.AutoSize = True
        Me.rdoMusicOn.Location = New System.Drawing.Point(162, 225)
        Me.rdoMusicOn.Name = "rdoMusicOn"
        Me.rdoMusicOn.Size = New System.Drawing.Size(70, 17)
        Me.rdoMusicOn.TabIndex = 4
        Me.rdoMusicOn.TabStop = True
        Me.rdoMusicOn.Text = "Music On"
        Me.rdoMusicOn.UseVisualStyleBackColor = True
        '
        'rdoMusicOff
        '
        Me.rdoMusicOff.AutoSize = True
        Me.rdoMusicOff.Location = New System.Drawing.Point(162, 263)
        Me.rdoMusicOff.Name = "rdoMusicOff"
        Me.rdoMusicOff.Size = New System.Drawing.Size(70, 17)
        Me.rdoMusicOff.TabIndex = 5
        Me.rdoMusicOff.TabStop = True
        Me.rdoMusicOff.Text = "Music Off"
        Me.rdoMusicOff.UseVisualStyleBackColor = True
        '
        'txtSound
        '
        Me.txtSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSound.Location = New System.Drawing.Point(53, 360)
        Me.txtSound.Name = "txtSound"
        Me.txtSound.Size = New System.Drawing.Size(79, 24)
        Me.txtSound.TabIndex = 6
        Me.txtSound.Text = "Sound"
        '
        'RdoOn
        '
        Me.RdoOn.AutoSize = True
        Me.RdoOn.Location = New System.Drawing.Point(162, 343)
        Me.RdoOn.Name = "RdoOn"
        Me.RdoOn.Size = New System.Drawing.Size(39, 17)
        Me.RdoOn.TabIndex = 7
        Me.RdoOn.TabStop = True
        Me.RdoOn.Text = "On"
        Me.RdoOn.UseVisualStyleBackColor = True
        '
        'rdoOff
        '
        Me.rdoOff.AutoSize = True
        Me.rdoOff.Location = New System.Drawing.Point(162, 389)
        Me.rdoOff.Name = "rdoOff"
        Me.rdoOff.Size = New System.Drawing.Size(39, 17)
        Me.rdoOff.TabIndex = 8
        Me.rdoOff.TabStop = True
        Me.rdoOff.Text = "Off"
        Me.rdoOff.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 588)
        Me.Controls.Add(Me.rdoOff)
        Me.Controls.Add(Me.RdoOn)
        Me.Controls.Add(Me.txtSound)
        Me.Controls.Add(Me.rdoMusicOff)
        Me.Controls.Add(Me.rdoMusicOn)
        Me.Controls.Add(Me.txtMusic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMenu)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMusic As System.Windows.Forms.TextBox
    Friend WithEvents rdoMusicOn As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMusicOff As System.Windows.Forms.RadioButton
    Friend WithEvents txtSound As System.Windows.Forms.TextBox
    Friend WithEvents RdoOn As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOff As System.Windows.Forms.RadioButton
End Class
