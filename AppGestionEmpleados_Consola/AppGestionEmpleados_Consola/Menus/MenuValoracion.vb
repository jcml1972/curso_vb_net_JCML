Imports AppGestionEmpleados_Consola.Valoracion
Namespace Menu

        Module MenuValoracion

        Sub Iniciar()

            Console.WriteLine(vbNewLine & " *** VALORACION DE EMPLEADOS ***" & vbNewLine)



            Dim valoracionLuis = New Valoracion("Luis Alfonso")

            valoracionLuis.establecerVentas(300)

            valoracionLuis.Mostrar()


        End Sub
    End Module
    End Namespace

