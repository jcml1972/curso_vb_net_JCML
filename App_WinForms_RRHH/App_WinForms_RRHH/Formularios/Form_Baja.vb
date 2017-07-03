Public Class Form_Baja


    Private Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated
        Me.MdiParent.Text = "Baja Empleado"
    End Sub

    Private Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación Empleados"
    End Sub
End Class