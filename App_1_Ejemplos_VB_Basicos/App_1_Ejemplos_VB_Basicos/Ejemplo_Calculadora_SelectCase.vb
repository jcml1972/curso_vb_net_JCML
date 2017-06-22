Module Ejemplo_Calculadora_SelectCase

    Sub MAIN()

        Dim OPERANDO1 As Integer
        Dim OPERANDO2 As Integer
        Dim OPERADOR As Char
        Dim RESULTADO As Single


        Console.WriteLine("Introduce el primer operando: ")
        OPERANDO1 = Console.ReadLine
        Console.WriteLine("Introduce el OPERADOR: ")
        OPERADOR = Console.ReadLine
        Console.WriteLine("Introduce el segundo operando: ")
        OPERANDO2 = Console.ReadLine

        Select Case OPERADOR
            Case "+"
                RESULTADO = OPERANDO1 + OPERANDO2
            Case "-"
                RESULTADO = OPERANDO1 - OPERANDO2
            Case "*"
                RESULTADO = OPERANDO1 * OPERANDO2
            Case "/"
                RESULTADO = OPERANDO1 / OPERANDO2
        End Select

        Console.WriteLine("El resultado es " & RESULTADO)

        Console.Read()


    End Sub

End Module
