Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Longitud de texto multilínea: " & TextBox1.TextLength.ToString() &
                        vbCrLf &
                         "longitud de texto 2: " & TextBox2.TextLength.ToString())
    End Sub

    Private Sub TextBox1y2_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged

        lblLongitudes.Text = "Longitud de texto multilínea: " & TextBox1.TextLength.ToString() &
                        vbCrLf &
                         "longitud de texto 2: " & TextBox2.TextLength.ToString()

    End Sub

End Class
