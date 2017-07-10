Imports App_5_Ejemplo_WinForm_Threading_Y_Excel.LectorExcel
Imports App_5_Ejemplo_WinForm_Threading_Y_Excel.EscritorExcel

Public Class Form_Excel
    Private Sub btnMuestraValorCelda_Click(sender As Object, e As EventArgs) Handles btnMuestraValorCelda.Click
        Dim valorCelda As String
        valorCelda = DameValorCelda(txtRutaFichero.Text, txtNombreHoja.Text, txtColumna.Text, numFila.Value)
        lblValorCelda.Text = valorCelda

    End Sub

    Private Sub btnCreaExcel_Click(sender As Object, e As EventArgs) Handles btnCreaExcel.Click
        NuevoExcelFijo(txtRutaNuevoExcel.Text)
    End Sub
End Class