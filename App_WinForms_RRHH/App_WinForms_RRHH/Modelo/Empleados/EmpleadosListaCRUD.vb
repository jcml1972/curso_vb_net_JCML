Namespace Modelo
    ' CRUD: Create, Read, Update, Delete
    ' Crear, Leer, Actualizar, Eliminar
    Class EmpleadosListaCRUD
        Implements IEmpleadosCRUD
        Private listaEmpleados As List(Of Empleado)
        Public avisarEnModificacion As TipoDelAvisarEnModificacion

        Private ReadOnly Property IEmpledosCRUD_Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Return listaEmpleados.Count
            End Get
        End Property

        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IEmpleadosCRUD.EstablecerAvisarEnModificacion
            avisarEnModificacion = funcionDelegada
        End Sub

        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar
            listaEmpleados = New List(Of Empleado)()
            ' EmpleadosFichero.LeerFichero(listaEmpleados.ToArray())
            Dim arrayEmpleados() As Empleado
            arrayEmpleados = listaEmpleados.ToArray()
            persistenciaEmpleados.Importar(arrayEmpleados)
            listaEmpleados = arrayEmpleados.ToList()
            avisarEnModificacion(True)
        End Sub
        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            persistenciaEmpleados.Exportar(listaEmpleados.ToArray())
            avisarEnModificacion(False)
        End Sub
        Sub Crear(nuevoEmpleado As Empleado) Implements IEmpleadosCRUD.Crear
            ' Asignamos nuevo empleado
            listaEmpleados.Add(nuevoEmpleado)
            avisarEnModificacion(True)
        End Sub

        Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados
            nombre = nombre.ToUpper()
            apellido = apellido.ToUpper()
            BuscarEmpleados = New List(Of Empleado)()

            For index = 0 To listaEmpleados.Count - 1
                Dim encontradoNombre As Boolean = False
                Dim encontradoApellido As Boolean = False
                If nombre = "" Or
                    (nombre <> "" And listaEmpleados(index).nombre.ToUpper().Contains(nombre)) Then
                    encontradoNombre = True
                End If
                If apellido = "" Or
                    (apellido <> "" And listaEmpleados(index).apellidos.ToUpper().Contains(apellido)) Then
                    encontradoApellido = True
                End If
                If encontradoApellido And encontradoNombre Then
                    BuscarEmpleados.Add(listaEmpleados(index))
                End If
            Next
        End Function
        Sub Actualizar(indice As Integer, empleado As Empleado)
            listaEmpleados(indice) = empleado
            avisarEnModificacion(True)
        End Sub
        Sub Actualizar(empleado As Empleado, empleadoModif As Empleado) Implements IEmpleadosCRUD.Actualizar
            Dim i = listaEmpleados.IndexOf(empleado)
            Actualizar(i, empleadoModif)
        End Sub
        '' Para eliminar
        '' 1 2 3 4 5 6 7 8 9 10
        '' posicion:
        '' 0 1 2 3 4
        Sub Eliminar(indice As Integer)
            listaEmpleados.RemoveAt(indice)
            avisarEnModificacion(True)
        End Sub
        Sub Eliminar(empleado As Empleado) Implements IEmpleadosCRUD.Eliminar
            listaEmpleados.Remove(empleado)
            avisarEnModificacion(True)
        End Sub
        Sub Eliminar(empleados As List(Of Empleado)) Implements IEmpleadosCRUD.Eliminar
            For Each empleado In empleados
                Eliminar(empleado)
            Next
            avisarEnModificacion(True)
        End Sub

    End Class
End Namespace