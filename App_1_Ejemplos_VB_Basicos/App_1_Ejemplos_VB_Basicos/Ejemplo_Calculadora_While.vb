Module Ejemplo_Calculadora_While

    Sub main()
        Dim opcion As Char = "X"
        Dim operador As Char
        Dim operando_1, operando_2, resultado As Single

        opcion = "c"
        While opcion = "c"
            Console.WriteLine("Introduzca operando 1")
            operando_1 = Console.ReadLine
            Console.WriteLine("Operador")
            operador = Console.ReadLine
            Console.WriteLine("Introduzca operando 1")
            operando_2 = Console.ReadLine

            Select Case operador
                Case "*"
                    resultado = operando_1 * operando_2
                Case "/"
                    resultado = operando_1 / operando_2
                Case "+"
                    resultado = operando_1 + operando_2
                Case "-"
                    resultado = operando_1 - operando_2
            End Select
            Console.WriteLine("El resultado es " & resultado)
            Console.WriteLine("Calcular (c), Salir (s)?")
            opcion = Console.ReadLine
        End While


    End Sub



End Module
