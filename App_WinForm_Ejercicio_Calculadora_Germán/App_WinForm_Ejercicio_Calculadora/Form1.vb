Public Class Form1
    Private Sub numOperando_ValueChanged(senderNumOperador As NumericUpDown, e As EventArgs) Handles numOperando1.ValueChanged, numOperando2.ValueChanged

        If senderNumOperador.Equals(numOperando1) Then
            txtOperando1.Text = senderNumOperador.Value.ToString()
        ElseIf senderNumOperador.Equals(numOperando2) Then
            txtOperando2.Text = senderNumOperador.Value.ToString()
        End If

    End Sub

    'Private Sub numOperando2_ValueChanged(sender As Object, e As EventArgs) Handles numOperando2.ValueChanged
    '    txtOperando2.Text = numOperando2.Value
    'End Sub


    Private Sub AlPulsarBotonCalculo(btnCalc As Button, e As EventArgs) Handles btnSuma.Click, btnRestar.Click, btnMultiplicar.Click, btnDividir.Click

        Dim valor_A As Single
        Dim valor_B As Single

        If Single.TryParse(txtOperando1.Text, valor_A) Then
            If Single.TryParse(txtOperando2.Text, valor_B) Then
                If btnCalc.Equals(btnSuma) Then
                    lblResultado.Text = valor_A + valor_B
                ElseIf btnCalc.Equals(btnRestar) Then
                    lblResultado.Text = valor_A - valor_B
                ElseIf btnCalc.Equals(btnMultiplicar) Then
                    lblResultado.Text = valor_A * valor_B
                ElseIf btnCalc.Equals(btnDividir) Then
                    lblResultado.Text = valor_A / valor_B
                End If
            Else
                txtOperando2.Text = "0"
            End If
        Else
            txtOperando1.Text = "0"
        End If

    End Sub



    'Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
    '    lblResultado.Text = "La suma es " & CType(txtOperando1.Text, Integer) + CType(txtOperando2.Text, Integer)
    'End Sub

    'Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
    '    lblResultado.Text = "La resta es " & CType(txtOperando1.Text, Integer) - CType(txtOperando2.Text, Integer)
    'End Sub

    'Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
    '    lblResultado.Text = "La multiplicación es " & CType(txtOperando1.Text, Integer) * CType(txtOperando2.Text, Integer)
    'End Sub

    'Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
    '    lblResultado.Text = "La división es " & CType(txtOperando1.Text, Integer) / CType(txtOperando2.Text, Integer)
    'End Sub
End Class
