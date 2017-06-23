Namespace AppEmpleados
    Namespace Menu
        Module MenuAplicacion
            Dim titulo As String = "MENU PRINCIPAL"
            Dim textosOpciones() As String = New String() {"Salir", "Gestion empleados", "Valoracion de empleados"}

            Sub Main()
                Dim codigoOpcion As Integer

                Do
                    codigoOpcion = UtilidadesMenu.SeleccionarOpcion(titulo, textosOpciones)

                    Select Case codigoOpcion
                        Case 1
                            MenuEmpleado.Iniciar()
                        Case 2
                            MenuValoracion.Iniciar()
                    End Select
                Loop Until codigoOpcion = 0
            End Sub

        End Module
    End Namespace
End Namespace