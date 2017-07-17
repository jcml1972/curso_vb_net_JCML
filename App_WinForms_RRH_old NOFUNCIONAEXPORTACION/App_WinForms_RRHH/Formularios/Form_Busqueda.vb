Imports App_WinForms_RRHH.Modelo


Public Class Form_Busqueda

    Public listaEmpleados As List(Of Empleado)

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        BuscarEmpleado()
    End Sub

    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        BuscarEmpleado()
    End Sub

    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) _
        Handles cmbNombre.TextChanged, cmbApellidos.TextChanged
        BuscarEmpleado()
    End Sub

    Private Sub BuscarEmpleado()
        lstListaEmpleados.Items.Clear()
        listaEmpleados = EmpleadosCRUD.BuscarEmpleados(cmbNombre.Text, cmbApellidos.Text)
        For Each empleado As Empleado In listaEmpleados
            lstListaEmpleados.Items.Add(empleado.nombre & " " & empleado.apellidos)
        Next
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim listaEliminar As New List(Of Empleado)
        For i = 0 To lstListaEmpleados.SelectedIndices.Count - 1
            Dim indexEmpleado = lstListaEmpleados.SelectedIndices(i)
            Dim empleado As Empleado
            empleado = listaEmpleados(indexEmpleado)
            listaEliminar.Add(empleado)
        Next
        While lstListaEmpleados.SelectedItems.Count > 0
            lstListaEmpleados.Items.Remove(lstListaEmpleados.SelectedItems(0))
        End While
        EmpleadosCRUD.Eliminar(listaEliminar)
        MessageBox.Show("¡¡Se ha eliminado el empleado!!")
        Me.Close()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim mdiPrincipal As MDI_Principal
        mdiPrincipal = CType(Me.MdiParent, MDI_Principal)
        MDI_Principal.AbrirAlta()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim listaModificar As New List(Of Empleado)
        For i = 0 To lstListaEmpleados.SelectedIndices.Count - 1
            Dim indexEmpleado = lstListaEmpleados.SelectedIndices(i)
            Dim frmModificar = New Form_Modificacion()
            frmModificar.MdiParent = Me.MdiParent
            frmModificar.Empleado = listaEmpleados(indexEmpleado)
            frmModificar.Show()
        Next



    End Sub
End Class