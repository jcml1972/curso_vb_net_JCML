Imports App_WinForms_RRHH.Modelo

Public Class Form_Alta

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' TODO: Impedir duplicados
        ' TODO: Hacer las validaciones

        Try
            Dim nuevoEmpleado As Empleado = New Empleado()
            ' Asignamos valores
            nuevoEmpleado.nombre = txtNombre.Text
            nuevoEmpleado.apellidos = txtApellidos.Text
            nuevoEmpleado.genero = CType(cmbGenero.SelectedIndex + 1, TipoGenero)
            nuevoEmpleado.categoria = CType(domCategoria.SelectedIndex + 1, TipoCategoria)
            nuevoEmpleado.retribucionFija = numRetribFija.Value + 1
            EmpleadosCRUD.Crear(nuevoEmpleado)
            Me.Close()
            MessageBox.Show("Empleado creado: " & nuevoEmpleado.ToString())
        Catch ex As Exception
            MessageBox.Show("Error al guardar")
        End Try
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) _
        Handles txtNombre.TextChanged, txtApellidos.TextChanged,
        cmbGenero.SelectedValueChanged, domCategoria.SelectedItemChanged, numRetribFija.ValueChanged
        btnGuardar.Enabled = txtNombre.Text <> "" _
            And txtApellidos.Text <> "" _
            And cmbGenero.SelectedIndex >= 0 _
            And domCategoria.SelectedIndex >= 0 _
            And numRetribFija.Value > 0
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtApellidos.Clear()
        cmbGenero.SelectedIndex = -1
        domCategoria.Text = ""
        domCategoria.SelectedIndex = -1
        numRetribFija.Value = 0
    End Sub
    Private Sub AlActivarseFormulario(sender As Object, e As EventArgs) Handles Me.Activated
        Me.MdiParent.Text = "Alta Empleado"
    End Sub
    Private Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub
End Class