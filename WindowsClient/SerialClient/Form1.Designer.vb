<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Arduino = New System.IO.Ports.SerialPort(Me.components)
        Me.btLeft = New System.Windows.Forms.Button()
        Me.btRight = New System.Windows.Forms.Button()
        Me.BtResetDir = New System.Windows.Forms.Button()
        Me.btUp = New System.Windows.Forms.Button()
        Me.btDown = New System.Windows.Forms.Button()
        Me.btRstLsrPos = New System.Windows.Forms.Button()
        Me.btshoot = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.bttest = New System.Windows.Forms.Button()
        Me.txttest = New System.Windows.Forms.TextBox()
        Me.btlsroff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btLeft
        '
        Me.btLeft.Location = New System.Drawing.Point(73, 74)
        Me.btLeft.Name = "btLeft"
        Me.btLeft.Size = New System.Drawing.Size(75, 23)
        Me.btLeft.TabIndex = 5
        Me.btLeft.Text = "Left &q"
        Me.btLeft.UseVisualStyleBackColor = True
        '
        'btRight
        '
        Me.btRight.Location = New System.Drawing.Point(265, 74)
        Me.btRight.Name = "btRight"
        Me.btRight.Size = New System.Drawing.Size(75, 23)
        Me.btRight.TabIndex = 6
        Me.btRight.Text = "Right &d"
        Me.btRight.UseVisualStyleBackColor = True
        '
        'BtResetDir
        '
        Me.BtResetDir.Location = New System.Drawing.Point(73, 188)
        Me.BtResetDir.Name = "BtResetDir"
        Me.BtResetDir.Size = New System.Drawing.Size(112, 23)
        Me.BtResetDir.TabIndex = 7
        Me.BtResetDir.Text = "Reset Direction"
        Me.BtResetDir.UseVisualStyleBackColor = True
        '
        'btUp
        '
        Me.btUp.Location = New System.Drawing.Point(169, 29)
        Me.btUp.Name = "btUp"
        Me.btUp.Size = New System.Drawing.Size(75, 23)
        Me.btUp.TabIndex = 9
        Me.btUp.Text = "Up &z"
        Me.btUp.UseVisualStyleBackColor = True
        '
        'btDown
        '
        Me.btDown.Location = New System.Drawing.Point(169, 115)
        Me.btDown.Name = "btDown"
        Me.btDown.Size = New System.Drawing.Size(75, 23)
        Me.btDown.TabIndex = 10
        Me.btDown.Text = "Down &s"
        Me.btDown.UseVisualStyleBackColor = True
        '
        'btRstLsrPos
        '
        Me.btRstLsrPos.Location = New System.Drawing.Point(225, 188)
        Me.btRstLsrPos.Name = "btRstLsrPos"
        Me.btRstLsrPos.Size = New System.Drawing.Size(112, 23)
        Me.btRstLsrPos.TabIndex = 11
        Me.btRstLsrPos.Text = "Reset Laser Pos"
        Me.btRstLsrPos.UseVisualStyleBackColor = True
        '
        'btshoot
        '
        Me.btshoot.Location = New System.Drawing.Point(429, 40)
        Me.btshoot.Name = "btshoot"
        Me.btshoot.Size = New System.Drawing.Size(109, 91)
        Me.btshoot.TabIndex = 17
        Me.btshoot.Text = "Shoot &m"
        Me.btshoot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 78)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Keyboard Shotcut :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shoot : m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Up : z" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Down : s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right : d" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left : q"
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(191, 306)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(91, 20)
        Me.txtresult.TabIndex = 19
        '
        'bttest
        '
        Me.bttest.Location = New System.Drawing.Point(399, 273)
        Me.bttest.Name = "bttest"
        Me.bttest.Size = New System.Drawing.Size(75, 23)
        Me.bttest.TabIndex = 20
        Me.bttest.Text = "&Test"
        Me.bttest.UseVisualStyleBackColor = True
        '
        'txttest
        '
        Me.txttest.Location = New System.Drawing.Point(399, 306)
        Me.txttest.Name = "txttest"
        Me.txttest.Size = New System.Drawing.Size(75, 20)
        Me.txttest.TabIndex = 21
        '
        'btlsroff
        '
        Me.btlsroff.Location = New System.Drawing.Point(446, 158)
        Me.btlsroff.Name = "btlsroff"
        Me.btlsroff.Size = New System.Drawing.Size(75, 23)
        Me.btlsroff.TabIndex = 22
        Me.btlsroff.Text = "lsr off"
        Me.btlsroff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 428)
        Me.Controls.Add(Me.btlsroff)
        Me.Controls.Add(Me.txttest)
        Me.Controls.Add(Me.bttest)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btshoot)
        Me.Controls.Add(Me.btRstLsrPos)
        Me.Controls.Add(Me.btDown)
        Me.Controls.Add(Me.btUp)
        Me.Controls.Add(Me.BtResetDir)
        Me.Controls.Add(Me.btRight)
        Me.Controls.Add(Me.btLeft)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Arduino As System.IO.Ports.SerialPort
    Friend WithEvents btLeft As System.Windows.Forms.Button
    Friend WithEvents btRight As System.Windows.Forms.Button
    Friend WithEvents BtResetDir As System.Windows.Forms.Button
    Friend WithEvents btUp As System.Windows.Forms.Button
    Friend WithEvents btDown As System.Windows.Forms.Button
    Friend WithEvents btRstLsrPos As System.Windows.Forms.Button
    Friend WithEvents btshoot As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtresult As System.Windows.Forms.TextBox
    Friend WithEvents bttest As System.Windows.Forms.Button
    Friend WithEvents txttest As System.Windows.Forms.TextBox
    Friend WithEvents btlsroff As System.Windows.Forms.Button

End Class
