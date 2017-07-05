Imports App_WinForms_RRHH.Modelo

Public Class Form_Baja

    Private frmBusqueda As New Form_Busqueda

    Private Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated
        Me.MdiParent.Text = "Baja Empleado"
    End Sub

    Private Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        EmpleadosCRUD.Eliminar(frmBusqueda.listaEmpleados)
        MessageBox.Show("¡¡Se ha eliminado el empleado!!")
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' frmLista.MdiParent = Me.MdiParent
        frmBusqueda.ShowDialog(Me)
        lstEmpleados.Items.Clear()
        lstEmpleados.Items.AddRange(frmBusqueda.lstListaEmpleados.Items)
    End Sub
End Class