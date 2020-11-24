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
        Me.picNYAN = New System.Windows.Forms.PictureBox()
        Me.btnSTART = New System.Windows.Forms.Button()
        Me.tmrNYAN = New System.Windows.Forms.Timer(Me.components)
        Me.lblNYAN = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tmrMusic = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picNYAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picNYAN
        '
        Me.picNYAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNYAN.Location = New System.Drawing.Point(0, -4)
        Me.picNYAN.Name = "picNYAN"
        Me.picNYAN.Size = New System.Drawing.Size(409, 366)
        Me.picNYAN.TabIndex = 0
        Me.picNYAN.TabStop = False
        '
        'btnSTART
        '
        Me.btnSTART.Location = New System.Drawing.Point(45, 12)
        Me.btnSTART.Name = "btnSTART"
        Me.btnSTART.Size = New System.Drawing.Size(97, 35)
        Me.btnSTART.TabIndex = 1
        Me.btnSTART.Text = "Start!"
        Me.btnSTART.UseVisualStyleBackColor = True
        '
        'tmrNYAN
        '
        '
        'lblNYAN
        '
        Me.lblNYAN.AutoSize = True
        Me.lblNYAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblNYAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNYAN.Location = New System.Drawing.Point(110, 64)
        Me.lblNYAN.Name = "lblNYAN"
        Me.lblNYAN.Size = New System.Drawing.Size(157, 20)
        Me.lblNYAN.TabIndex = 2
        Me.lblNYAN.Text = "You have Nyaned for"
        Me.lblNYAN.Visible = False
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(164, 84)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(45, 25)
        Me.lblCounter.TabIndex = 3
        Me.lblCounter.Text = "0.0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCounter.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seconds"
        Me.Label1.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(243, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(101, 35)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop!"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'tmrMusic
        '
        Me.tmrMusic.Interval = 200000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 363)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNYAN)
        Me.Controls.Add(Me.btnSTART)
        Me.Controls.Add(Me.picNYAN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picNYAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picNYAN As System.Windows.Forms.PictureBox
    Friend WithEvents btnSTART As System.Windows.Forms.Button
    Friend WithEvents tmrNYAN As System.Windows.Forms.Timer
    Friend WithEvents lblNYAN As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents tmrMusic As System.Windows.Forms.Timer

End Class
