Imports AppGestionEmpleados_Consola.Modelo


Namespace Menu
        Module MenuEmpleado
            Dim titulo As String = "GESTION DE EMPLEADOS"
            Dim textosOpciones() As String = New String() {
            "Salir", "Alta", "Lista", "Busqueda",
            "Modificar", "Borrar"
        }

            Sub Iniciar()
                EmpleadosCRUD.Restaurar()

                Dim codigoOpcion As Integer
                Do
                codigoOpcion = Utilidades.UtilidadesMenu.SeleccionarOpcion(titulo, textosOpciones)

                Select Case codigoOpcion
                        Case 1
                            Alta()
                        Case 2
                            Listar()
                        Case 3
                            Busqueda()
                        Case 4
                            Modificar()
                        Case 5
                            Eliminar()
                    End Select
                Loop Until codigoOpcion = 0
            End Sub
            Sub Alta()
            Utilidades.UtilidadesMenu.MostrarTitulo("Alta de empleados")

            Dim nuevoEmpleado As Empleado = New Empleado()

            ' Asignamos valores
            nuevoEmpleado.nombre = Utilidades.UtilidadesMenu.PedirCampo("nombre")
            nuevoEmpleado.apellidos = Utilidades.UtilidadesMenu.PedirCampo("apellidos")
            nuevoEmpleado.genero = Utilidades.UtilidadesMenu.PedirGenero()
            nuevoEmpleado.categoria = Utilidades.UtilidadesMenu.PedirCategoria()

            EmpleadosCRUD.Crear(nuevoEmpleado)
            End Sub

            Sub Listar()
            Utilidades.UtilidadesMenu.MostrarTitulo("Lista de empleados")

            For index = 0 To EmpleadosCRUD.Cantidad() - 1
                    MostrarEmpleado(EmpleadosCRUD.Leer(index))
                Next
            End Sub
            Private Sub MostrarEmpleado(Empleado As Empleado)
                Console.WriteLine(Empleado.NombreCompleto() & ", " & Empleado.genero.ToString() & ", " & Empleado.categoria.ToString())
            End Sub
            Function Busqueda() As Integer
            Utilidades.UtilidadesMenu.MostrarTitulo("Busqueda de empleados")
            Console.WriteLine("Introduzca los campos por los que quiera buscar. Deje vacios los que no")
            Dim nombre_a_buscar As String = Utilidades.UtilidadesMenu.PedirCampo("nombre")
            Dim apellidos_a_buscar As String = Utilidades.UtilidadesMenu.PedirCampo("apellidos")
            Dim indiceEmpleado As Integer

                If nombre_a_buscar = "" And apellidos_a_buscar = "" Then
                    indiceEmpleado = -1
                    Console.WriteLine("Por favor, introduzca un campo")
                ElseIf nombre_a_buscar <> "" Then
                    indiceEmpleado = EmpleadosCRUD.BuscarPorCampoEmpleado(nombre_a_buscar)
                ElseIf apellidos_a_buscar <> "" Then
                    indiceEmpleado = EmpleadosCRUD.BuscarPorCampoEmpleado(apellidos_a_buscar, TipoCampoEmpleado.Apellidos)
                End If

                If indiceEmpleado >= 0 Then
                    Console.Write("Se ha encontrado ")
                    MostrarEmpleado(Leer(indiceEmpleado))
                Else
                    Console.WriteLine("No se ha encontrado Nombre: " & nombre_a_buscar & " Apellidos: " & apellidos_a_buscar)
                End If
                Return indiceEmpleado
            End Function
            Sub Modificar()
            Utilidades.UtilidadesMenu.MostrarTitulo("Modificación de empleado")
            Dim index As Integer = Busqueda()
                Dim empleado_para_actualizar As Empleado

                If index >= 0 Then
                    Console.WriteLine("Introduzca lo nuevos valores")
                ' Asignamos valores
                empleado_para_actualizar.nombre = Utilidades.UtilidadesMenu.PedirCampo("nombre")
                empleado_para_actualizar.apellidos = Utilidades.UtilidadesMenu.PedirCampo("apellidos")
                empleado_para_actualizar.genero = Utilidades.UtilidadesMenu.PedirGenero()
                empleado_para_actualizar.categoria = Utilidades.UtilidadesMenu.PedirCategoria()

                EmpleadosCRUD.Actualizar(index, empleado_para_actualizar)
                End If
            End Sub
            Sub Eliminar()
            Utilidades.UtilidadesMenu.MostrarTitulo("Eliminacion de empleado")

            Dim index = Busqueda()
                If index <> -1 Then
                    EmpleadosCRUD.Eliminar(index)
                End If
            End Sub
        End Module
    End Namespace
