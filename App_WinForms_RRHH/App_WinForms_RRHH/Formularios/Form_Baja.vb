Imports App_WinForms_RRHH.Modelo

Public Class Form_Baja

    Private frmLista As New Form_Lista

    Private Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated
        Me.MdiParent.Text = "Baja Empleado"
    End Sub

    Private Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        EmpleadosCRUD.Eliminar(frmLista.listaEmpleados)
        MessageBox.Show("¡¡Se ha eliminado el empleado!!")
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' frmLista.MdiParent = Me.MdiParent
        frmLista.ShowDialog(Me)
        lstEmpleados.Items.Clear()
        lstEmpleados.Items.AddRange(frmLista.lstListaEmpleados.Items)
    End Sub
End Class