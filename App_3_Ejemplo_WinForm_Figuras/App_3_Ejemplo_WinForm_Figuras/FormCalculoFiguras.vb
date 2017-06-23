Public Class FormCalculoFiguras
    Private Sub ValoresRectangulo(sender As Object, e As EventArgs) Handles numAncho.ValueChanged, numAlto.ValueChanged
        Dim rectangulo As Rectangulo = New Rectangulo(numAlto.Value, numAncho.Value)

        numArea.Value = rectangulo.CalculaArea()
        numPerimetro.Value = rectangulo.CalculaPerimetro()

    End Sub

    Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadRectangulo.CheckedChanged, RadCirculo.CheckedChanged

        GrupoRectangulo.Visible = RadRectangulo.Checked
        numArea.Value = 0
        numPerimetro.Value = 0
        numRadioCirculo.Value = 0
        numAlto.Value = 0
        numAncho.Value = 0
        GrupoCirculo.Visible = RadCirculo.Checked

    End Sub

    Private Sub numRadio_ValueChanged(sender As Object, e As EventArgs) Handles numRadioCirculo.ValueChanged

        Dim circulo As Circulo = New Circulo(numRadioCirculo.Value, Nothing)

        numArea.Value = circulo.CalculaArea()
        numPerimetro.Value = circulo.CalculaPerimetro()

    End Sub

    Private Sub numRadio2_ValueChanged(sender As Object, e As EventArgs) Handles numRadio2.ValueChanged, cbxTipoCalculo.SelectedIndexChanged

        Dim circulo As Circulo = New Circulo(numRadio2.Value, Nothing)
        If cbxTipoCalculo.SelectedIndex = 0 Then
            numResultado.Value = circulo.CalculaArea()
        Else
            numResultado.Value = circulo.CalculaPerimetro()
        End If

    End Sub
End Class
