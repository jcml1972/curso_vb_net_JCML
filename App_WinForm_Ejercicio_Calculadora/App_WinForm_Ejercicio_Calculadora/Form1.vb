Public Class Form1
    Private Sub numOperando1_ValueChanged(sender As Object, e As EventArgs) Handles numOperando1.ValueChanged
        txtOperando1.Text = numOperando1.Value
    End Sub

    Private Sub numOperando2_ValueChanged(sender As Object, e As EventArgs) Handles numOperando2.ValueChanged
        txtOperando2.Text = numOperando2.Value
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        lblResultado.Text = "La suma es " & CType(txtOperando1.Text, Integer) + CType(txtOperando2.Text, Integer)

    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        lblResultado.Text = "La resta es " & CType(txtOperando1.Text, Integer) - CType(txtOperando2.Text, Integer)
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        lblResultado.Text = "La multiplicación es " & CType(txtOperando1.Text, Integer) * CType(txtOperando2.Text, Integer)
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        lblResultado.Text = "La división es " & CType(txtOperando1.Text, Integer) / CType(txtOperando2.Text, Integer)
    End Sub
End Class
