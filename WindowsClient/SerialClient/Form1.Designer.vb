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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nuplsr = New System.Windows.Forms.NumericUpDown()
        Me.nupdir = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btshoot = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.bttest = New System.Windows.Forms.Button()
        Me.txttest = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nuplsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupdir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btLeft
        '
        Me.btLeft.Location = New System.Drawing.Point(73, 74)
        Me.btLeft.Name = "btLeft"
        Me.btLeft.Size = New System.Drawing.Size(75, 23)
        Me.btLeft.TabIndex = 5
        Me.btLeft.Text = "&Left"
        Me.btLeft.UseVisualStyleBackColor = True
        '
        'btRight
        '
        Me.btRight.Location = New System.Drawing.Point(265, 74)
        Me.btRight.Name = "btRight"
        Me.btRight.Size = New System.Drawing.Size(75, 23)
        Me.btRight.TabIndex = 6
        Me.btRight.Text = "&Right"
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
        Me.btUp.Text = "&Up"
        Me.btUp.UseVisualStyleBackColor = True
        '
        'btDown
        '
        Me.btDown.Location = New System.Drawing.Point(169, 115)
        Me.btDown.Name = "btDown"
        Me.btDown.Size = New System.Drawing.Size(75, 23)
        Me.btDown.TabIndex = 10
        Me.btDown.Text = "&Down"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nuplsr)
        Me.GroupBox1.Controls.Add(Me.nupdir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 124)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debug / test"
        '
        'nuplsr
        '
        Me.nuplsr.Location = New System.Drawing.Point(90, 81)
        Me.nuplsr.Name = "nuplsr"
        Me.nuplsr.Size = New System.Drawing.Size(120, 20)
        Me.nuplsr.TabIndex = 21
        '
        'nupdir
        '
        Me.nupdir.Location = New System.Drawing.Point(90, 42)
        Me.nupdir.Name = "nupdir"
        Me.nupdir.Size = New System.Drawing.Size(120, 20)
        Me.nupdir.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Laser Pos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Direction"
        '
        'btshoot
        '
        Me.btshoot.Location = New System.Drawing.Point(429, 40)
        Me.btshoot.Name = "btshoot"
        Me.btshoot.Size = New System.Drawing.Size(109, 91)
        Me.btshoot.TabIndex = 17
        Me.btshoot.Text = "&Shoot"
        Me.btshoot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 78)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Keyboard Shotcut :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shoot : s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Up : u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Down : d" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right : r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left : l"
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(460, 336)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(91, 20)
        Me.txtresult.TabIndex = 19
        '
        'bttest
        '
        Me.bttest.Location = New System.Drawing.Point(443, 203)
        Me.bttest.Name = "bttest"
        Me.bttest.Size = New System.Drawing.Size(75, 23)
        Me.bttest.TabIndex = 20
        Me.bttest.Text = "&Test"
        Me.bttest.UseVisualStyleBackColor = True
        '
        'txttest
        '
        Me.txttest.Location = New System.Drawing.Point(443, 233)
        Me.txttest.Name = "txttest"
        Me.txttest.Size = New System.Drawing.Size(75, 20)
        Me.txttest.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 428)
        Me.Controls.Add(Me.txttest)
        Me.Controls.Add(Me.bttest)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btshoot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btRstLsrPos)
        Me.Controls.Add(Me.btDown)
        Me.Controls.Add(Me.btUp)
        Me.Controls.Add(Me.BtResetDir)
        Me.Controls.Add(Me.btRight)
        Me.Controls.Add(Me.btLeft)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nuplsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupdir, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btshoot As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtresult As System.Windows.Forms.TextBox
    Friend WithEvents nupdir As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuplsr As System.Windows.Forms.NumericUpDown
    Friend WithEvents bttest As System.Windows.Forms.Button
    Friend WithEvents txttest As System.Windows.Forms.TextBox

End Class
