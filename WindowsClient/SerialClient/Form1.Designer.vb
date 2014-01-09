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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btLeft
        '
        Me.btLeft.Location = New System.Drawing.Point(225, 97)
        Me.btLeft.Name = "btLeft"
        Me.btLeft.Size = New System.Drawing.Size(75, 23)
        Me.btLeft.TabIndex = 5
        Me.btLeft.Text = "Left"
        Me.btLeft.UseVisualStyleBackColor = True
        '
        'btRight
        '
        Me.btRight.Location = New System.Drawing.Point(464, 97)
        Me.btRight.Name = "btRight"
        Me.btRight.Size = New System.Drawing.Size(75, 23)
        Me.btRight.TabIndex = 6
        Me.btRight.Text = "Right"
        Me.btRight.UseVisualStyleBackColor = True
        '
        'BtResetDir
        '
        Me.BtResetDir.Location = New System.Drawing.Point(315, 97)
        Me.BtResetDir.Name = "BtResetDir"
        Me.BtResetDir.Size = New System.Drawing.Size(112, 23)
        Me.BtResetDir.TabIndex = 7
        Me.BtResetDir.Text = "Reset Direction"
        Me.BtResetDir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 216)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(409, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 428)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
