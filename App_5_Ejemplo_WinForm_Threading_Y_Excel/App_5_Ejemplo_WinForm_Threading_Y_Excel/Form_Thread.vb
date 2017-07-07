Imports System.Threading

Public Class Form_Thread
    Private trd As Thread

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        Dim frm As Form_Thread
        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        trd.Start()
        frm = Me
        MessageBox.Show("HA TERMINADO LOAD")
    End Sub

    Private Sub ThreadTask()
        Dim stp As Integer
        Dim newval As Integer
        Dim rnd As New Random()

        Thread.Sleep(rnd.Next(5000, 15000))

        MessageBox.Show("HAN PASADO 100 ms")

        Do
            stp = ProgressBar1.Step * rnd.Next(-1, 2)
            newval = ProgressBar1.Value + stp
            If newval > ProgressBar1.Maximum Then
                newval = ProgressBar1.Maximum
            ElseIf newval < ProgressBar1.Minimum Then
                newval = ProgressBar1.Minimum
            End If

            ProgressBar1.Value = newval

            Thread.Sleep(100)

            MessageBox.Show("HAN PASADO 100 ms")
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This is the main thread")
    End Sub
End Class
