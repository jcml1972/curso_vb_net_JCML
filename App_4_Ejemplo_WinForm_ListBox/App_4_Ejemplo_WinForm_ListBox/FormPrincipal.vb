Public Class FormPrincipal

    Private nuevoFormComboListas As FormComboListas

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevoFormComboListas = New FormComboListas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Longitud de texto multilínea: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf &
                         "longitud de texto 2: " & txtDiezCaracteres.TextLength.ToString())
    End Sub

    Private Sub TextBox1y2_TextChanged(sender As Object, e As EventArgs) Handles txtMultilinea.TextChanged, txtDiezCaracteres.TextChanged

        lblLongitudes.Text = "Longitud de texto multilínea: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf &
                         "longitud de texto 2: " & txtDiezCaracteres.TextLength.ToString()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstListaDatos.Items.Add(txtMultilinea.Text)
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        lstListaDatos.Items.Add(txtDiezCaracteres.Text)
        txtDiezCaracteres.Clear()
    End Sub

    Private Sub btnEliminardelaLista_Click(sender As Object, e As EventArgs) Handles btnElminardelaLista.Click
        lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex)
    End Sub

    Private Sub lstListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListaDatos.SelectedIndexChanged
        If lstListaDatos.Items.Count = 0 Then
            btnElminardelaLista.Enabled = False
        ElseIf lstListaDatos.Items.Count > 0 Then
            btnElminardelaLista.Enabled = True
        End If
    End Sub

    Private Sub btnAbrirForm_Click(sender As Object, e As EventArgs) Handles btnAbrirForm.Click
        If nuevoFormComboListas Is Nothing Or nuevoFormComboListas.IsDisposed Then
            nuevoFormComboListas = New FormComboListas()
        End If
        nuevoFormComboListas.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        nuevoFormComboListas.Hide()
    End Sub


End Class
