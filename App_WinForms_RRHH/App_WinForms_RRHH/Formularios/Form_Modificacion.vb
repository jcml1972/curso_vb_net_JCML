Imports App_WinForms_RRHH.Modelo

Public Class Form_Modificacion

    Public EmpleadoModificado, empleadoAModificar As Empleado

    Private Sub Form_Modificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombre.Text = empleadoAModificar.nombre
        txtApellidos.Text = empleadoAModificar.apellidos
        cmbGenero.SelectedIndex = empleadoAModificar.genero
        domCategoria.SelectedIndex = empleadoAModificar.categoria
        numRetribFija.Value = CType(empleadoAModificar.retribucionFija, Decimal)

        btnGuardar.Enabled = True

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        EmpleadoModificado = New Empleado()

        EmpleadoModificado.nombre = txtNombre.Text
        EmpleadoModificado.apellidos = txtApellidos.Text
        EmpleadoModificado.genero = CType(cmbGenero.SelectedIndex, TipoGenero)
        EmpleadoModificado.categoria = CType(domCategoria.SelectedIndex, TipoCategoria)
        EmpleadoModificado.retribucionFija = numRetribFija.Value

        EmpleadosCRUD.Actualizar(empleadoAModificar, EmpleadoModificado)
        MessageBox.Show("Se ha modificado al empleado: " & EmpleadoModificado.nombre & " " & EmpleadoModificado.apellidos)
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim mdiPrincipal As MDI_Principal
        mdiPrincipal = CType(Me.MdiParent, MDI_Principal)
        MDI_Principal.AbrirBusqueda()
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
        Me.MdiParent.Text = "Modificación de Empleado"
    End Sub
    Private Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub

End Class