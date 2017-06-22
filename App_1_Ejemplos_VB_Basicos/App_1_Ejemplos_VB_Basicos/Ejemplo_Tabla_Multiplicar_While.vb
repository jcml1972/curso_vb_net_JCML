Module Ejemplo_Tabla_Multiplicar_While

    Sub main()

        Console.WriteLine("Introduce un número: ")
        Dim número As Integer = Console.ReadLine

        While número > 0 And número < 10

            For i As Integer = 1 To 10
                Console.WriteLine(número & " x " & i & " = " & número * i)
            Next
            número = Console.ReadLine

        End While
        Console.ReadLine()


    End Sub



End Module
