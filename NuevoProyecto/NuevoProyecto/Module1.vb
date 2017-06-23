Module Module1




    Sub Main()
        Dim numeroOpcionSel As Integer
        Console.WriteLine("Iniciando App Banco curso VB")
        Do
            MENU.Mostrar()

            numeroOpcionSel = MENU.PedirOpcion()

            Select Case numeroOpcionSel
                Case "1"
                    Console.WriteLine("EJECUTANDO ""Añadir empleado"" ")
                Case "2"
                    Console.WriteLine("EJECUTANDO ""Seleccionar empleado"" ")
                Case "3"
                    CalcularIVA()
                Case Else
                    Console.WriteLine("No ha seleccionado una opción válida ")
            End Select

        Loop While numeroOpcionSel <> "0"
    End Sub



End Module
