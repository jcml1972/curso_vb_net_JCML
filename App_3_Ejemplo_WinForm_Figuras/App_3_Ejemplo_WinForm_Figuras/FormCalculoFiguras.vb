Public Class FormCalculoFiguras
    Private Sub ValoresRectangulo(sender As Object, e As EventArgs) Handles numAncho.ValueChanged, numAlto.ValueChanged
        Dim rectangulo As Rectangulo = New Rectangulo(numAlto.Value, numAncho.Value)

        numArea.Value = rectangulo.CalculaArea
        numPerimetroRectangulo.Value = rectangulo.CalculaPerimetro

    End Sub

    Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadRectangulo.CheckedChanged

        GrupoRectangulo.Visible = RadRectangulo.Checked
        GrupoCirculo.Visible = RadCirculo.Checked

    End Sub

    Private Sub numRadio_ValueChanged(sender As Object, e As EventArgs) Handles numRadioCirculo.ValueChanged

        Dim circulo As Circulo = New Circulo(numRadioCirculo.Value, Nothing)

        numAreaCirculo.Value = circulo.CalculaArea
        numPerimetroCirculo.Value = circulo.CalculaPerimetro

    End Sub
End Class
