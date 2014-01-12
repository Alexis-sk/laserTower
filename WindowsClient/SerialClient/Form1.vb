Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Arduino.PortName = "COM4"
        Arduino.BaudRate = "9600"
        Arduino.Open()

        txttest.Text = "no test"

    End Sub

    Private Sub btRight_Click(sender As Object, e As EventArgs) Handles btRight.Click
        txtresult.Text = "Right - 31"
        Arduino.WriteLine("31;")
    End Sub

    Private Sub btLeft_Click(sender As Object, e As EventArgs) Handles btLeft.Click
        txtresult.Text = "Left - 32"
        Arduino.WriteLine("32;")
    End Sub

    Private Sub btlsroff_Click(sender As Object, e As EventArgs) Handles btlsroff.Click
        txtresult.Text = "Reset shoot - 50"
        Arduino.WriteLine("50;")
    End Sub

    Private Sub btshoot_Click(sender As Object, e As EventArgs) Handles btshoot.Click
        txtresult.Text = "Shoot - 51"
        Arduino.WriteLine("51;")
    End Sub

    Private Sub btUp_Click(sender As Object, e As EventArgs) Handles btUp.Click
        txtresult.Text = "Up - 42"
        Arduino.WriteLine("42;")
    End Sub

    Private Sub btDown_Click(sender As Object, e As EventArgs) Handles btDown.Click
        txtresult.Text = "Down - 41"
        Arduino.WriteLine("41;")
    End Sub

    Private Sub BtResetDir_Click(sender As Object, e As EventArgs) Handles BtResetDir.Click
        txtresult.Text = "Reset Dir - 30"
        Arduino.WriteLine("30;")
    End Sub

    Private Sub btRstLsrPos_Click(sender As Object, e As EventArgs) Handles btRstLsrPos.Click
        txtresult.Text = "Reset lsr - 40"
        Arduino.WriteLine("40;")
    End Sub


    Private Sub bttest_KeyDown(sender As Object, e As KeyEventArgs) Handles bttest.KeyDown
        txttest.Text = "Key Down"
    End Sub

    Private Sub bttest_KeyUp(sender As Object, e As KeyEventArgs) Handles bttest.KeyUp
        txttest.Text = "Key Up"
    End Sub


End Class

