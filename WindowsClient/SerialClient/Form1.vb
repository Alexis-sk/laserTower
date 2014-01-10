Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Arduino.PortName = "COM4"
        'Arduino.BaudRate = "9600"
        'Arduino.Open()

        nupdir.Value = 90
        nupdir.Maximum = 180
        nupdir.Minimum = 5

        nuplsr.Value = 5
        nuplsr.Maximum = 20
        nuplsr.Minimum = 0

        txttest.Text = "no test"

    End Sub

    Private Sub btRight_Click(sender As Object, e As EventArgs) Handles btRight.Click
        txtresult.Text = "Right - 3;1"
        'Arduino.WriteLine("3;1")
    End Sub

    Private Sub btLeft_Click(sender As Object, e As EventArgs) Handles btLeft.Click
        txtresult.Text = "Left - 3.2"
        'Arduino.WriteLine("3;2")
    End Sub

    Private Sub btshoot_Click(sender As Object, e As EventArgs) Handles btshoot.Click
        txtresult.Text = "Shoot - 5;1"
        'Arduino.WriteLine("5;1")
    End Sub

    Private Sub btUp_Click(sender As Object, e As EventArgs) Handles btUp.Click
        txtresult.Text = "Up - 4;1"
        'Arduino.WriteLine("4;1")
    End Sub

    Private Sub btDown_Click(sender As Object, e As EventArgs) Handles btDown.Click
        txtresult.Text = "Down - 4;2"
        'Arduino.WriteLine("4;2")
    End Sub

    Private Sub BtResetDir_Click(sender As Object, e As EventArgs) Handles BtResetDir.Click
        txtresult.Text = "Reset Dir - 3;0"
        'Arduino.WriteLine("3;0")
    End Sub

    Private Sub btRstLsrPos_Click(sender As Object, e As EventArgs) Handles btRstLsrPos.Click
        txtresult.Text = "Reset lsr - 4;0"
        'Arduino.WriteLine("4;0")
    End Sub


    Private Sub nupdir_ValueChanged(sender As Object, e As EventArgs) Handles nupdir.ValueChanged
        txtresult.Text = "2;" & nupdir.Value
        'Arduino.WriteLine("2;" & nupdir.Value)
    End Sub

    Private Sub nuplsr_ValueChanged(sender As Object, e As EventArgs) Handles nuplsr.ValueChanged
        txtresult.Text = "1;" & nuplsr.Value
        'Arduino.WriteLine("1;" & nuplsr.Value)
    End Sub

    Private Sub bttest_KeyDown(sender As Object, e As KeyEventArgs) Handles bttest.KeyDown
        txttest.Text = "Key Down"
    End Sub

    Private Sub bttest_KeyUp(sender As Object, e As KeyEventArgs) Handles bttest.KeyUp
        txttest.Text = "Key Up"
    End Sub
End Class

