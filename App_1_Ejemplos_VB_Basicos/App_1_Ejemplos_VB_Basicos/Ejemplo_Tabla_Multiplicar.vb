Module Ejemplo_Tabla_Multiplicar

    Sub main()

        Console.WriteLine("Introduce un número: ")
        Dim número As Integer = Console.ReadLine


        For i As Integer = 1 To 10
            Console.WriteLine(número & " x " & i & " = " & número * i)
        Next

        Console.Read()


    End Sub


End Module
