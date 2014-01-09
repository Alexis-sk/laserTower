Public Class Form1






   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Arduino.PortName = "COM4"
        Arduino.BaudRate = "9600"
        Arduino.Open()


    End Sub

    Private Sub btRight_Click(sender As Object, e As EventArgs) Handles btRight.Click
        Arduino.WriteLine("3;1")
    End Sub

    Private Sub btLeft_Click(sender As Object, e As EventArgs) Handles btLeft.Click
        Arduino.WriteLine("3;2")
    End Sub

    Private Sub BtResetDir_Click(sender As Object, e As EventArgs) Handles BtResetDir.Click
        Arduino.WriteLine("3;0")
    End Sub


End Class
