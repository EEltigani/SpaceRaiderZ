<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picshooter = New System.Windows.Forms.PictureBox()
        Me.picalien = New System.Windows.Forms.PictureBox()
        Me.picmissileshooter = New System.Windows.Forms.PictureBox()
        Me.TimerGaming = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picshooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picalien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmissileshooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picshooter
        '
        Me.picshooter.BackgroundImage = CType(resources.GetObject("picshooter.BackgroundImage"), System.Drawing.Image)
        Me.picshooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picshooter.Location = New System.Drawing.Point(381, 441)
        Me.picshooter.Name = "picshooter"
        Me.picshooter.Size = New System.Drawing.Size(94, 89)
        Me.picshooter.TabIndex = 0
        Me.picshooter.TabStop = False
        '
        'picalien
        '
        Me.picalien.BackgroundImage = CType(resources.GetObject("picalien.BackgroundImage"), System.Drawing.Image)
        Me.picalien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picalien.Location = New System.Drawing.Point(405, 39)
        Me.picalien.Name = "picalien"
        Me.picalien.Size = New System.Drawing.Size(69, 52)
        Me.picalien.TabIndex = 1
        Me.picalien.TabStop = False
        '
        'picmissileshooter
        '
        Me.picmissileshooter.BackgroundImage = CType(resources.GetObject("picmissileshooter.BackgroundImage"), System.Drawing.Image)
        Me.picmissileshooter.Location = New System.Drawing.Point(429, 354)
        Me.picmissileshooter.Name = "picmissileshooter"
        Me.picmissileshooter.Size = New System.Drawing.Size(11, 51)
        Me.picmissileshooter.TabIndex = 2
        Me.picmissileshooter.TabStop = False
        '
        'TimerGaming
        '
        Me.TimerGaming.Enabled = True
        Me.TimerGaming.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(952, 574)
        Me.Controls.Add(Me.picmissileshooter)
        Me.Controls.Add(Me.picalien)
        Me.Controls.Add(Me.picshooter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picshooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picalien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmissileshooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picshooter As System.Windows.Forms.PictureBox
    Friend WithEvents picalien As System.Windows.Forms.PictureBox
    Friend WithEvents picmissileshooter As System.Windows.Forms.PictureBox
    Friend WithEvents TimerGaming As System.Windows.Forms.Timer

End Class
