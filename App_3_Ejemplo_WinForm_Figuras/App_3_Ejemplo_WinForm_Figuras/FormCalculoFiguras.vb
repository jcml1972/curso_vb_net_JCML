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

    Private Sub numRadio2_ValueChanged(sender As Object, e As EventArgs) Handles numRadio2.ValueChanged, cbxTipoCalculoCirc.SelectedIndexChanged


        Dim circulo As Circulo = New Circulo(numRadio2.Value, Nothing)
        If cbxTipoCalculoCirc.SelectedIndex = 0 Then
            numResultadoCirculo.Value = circulo.CalculaArea()
        ElseIf cbxTipoCalculoCirc.SelectedIndex = 1 Then
            numResultadoCirculo.Value = circulo.CalculaPerimetro()
        Else
            numResultadoCirculo.Value = 0
        End If

    End Sub

    Private Sub valoresRectangulo_ValueChanged(sender As Object, e As EventArgs) Handles numAlto2.ValueChanged, numAncho2.ValueChanged, cbxTipoCalculoRect.SelectedIndexChanged

        Dim rectangulo As Rectangulo = New Rectangulo(numAlto2.Value, numAncho2.Value)
        If cbxTipoCalculoRect.SelectedIndex = 0 Then
            numResultadoRectangulo.Value = rectangulo.CalculaArea()
        ElseIf cbxTipoCalculoRect.SelectedIndex = 1 Then
            numResultadoRectangulo.Value = rectangulo.CalculaPerimetro()
        Else
            numResultadoRectangulo.Value = 0
        End If

    End Sub

    Private Sub FormCalculoFiguras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Evento FormCalculoFiguras_Load")
    End Sub

    Private Sub FormCalculoFiguras_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'MessageBox.Show("Evento FormCalculoFiguras_Closing")

        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Cerrar la ventana?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        If resultado = DialogResult.Cancel Then
            e.Cancel = True
        End If

    End Sub
End Class
