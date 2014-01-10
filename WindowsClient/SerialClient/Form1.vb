Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Arduino.PortName = "COM4"
        'Arduino.BaudRate = "9600"
        'Arduino.Open()

        txtdir.Text = "90"
        txtlsr.Text = "5"

    End Sub

    Private Sub btRight_Click(sender As Object, e As EventArgs) Handles btRight.Click
        txtresult.Text = "Right"
        'Arduino.WriteLine("3;1")
    End Sub

    Private Sub btLeft_Click(sender As Object, e As EventArgs) Handles btLeft.Click
        txtresult.Text = "Left"
        'Arduino.WriteLine("3;2")
    End Sub

    Private Sub btshoot_Click(sender As Object, e As EventArgs) Handles btshoot.Click
        txtresult.Text = "Shoot"
        'Arduino.WriteLine("5;1")
    End Sub

    Private Sub btUp_Click(sender As Object, e As EventArgs) Handles btUp.Click
        txtresult.Text = "Up"
        'Arduino.WriteLine("4;1")
    End Sub

    Private Sub btDown_Click(sender As Object, e As EventArgs) Handles btDown.Click
        txtresult.Text = "Down"
        'Arduino.WriteLine("4;2")
    End Sub

    Private Sub BtResetDir_Click(sender As Object, e As EventArgs) Handles BtResetDir.Click
        'Arduino.WriteLine("3;0")
    End Sub

    Private Sub btRstLsrPos_Click(sender As Object, e As EventArgs) Handles btRstLsrPos.Click
        'Arduino.WriteLine("4;0")
    End Sub

    Private Sub btDirAn_Click(sender As Object, e As EventArgs) Handles btDirAn.Click
        txtresult.Text = "2;" & txtdir.Text

    End Sub

    Private Sub btlsran_Click(sender As Object, e As EventArgs) Handles btlsran.Click
        txtresult.Text = "1;" & txtlsr.Text

    End Sub
End Class
