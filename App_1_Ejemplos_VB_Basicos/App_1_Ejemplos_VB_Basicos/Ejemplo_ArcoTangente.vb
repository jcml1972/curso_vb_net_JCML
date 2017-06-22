Module Ejemplo_ArcoTangente

    Sub main()
        Dim x, y As Single
        Dim Truncado, Redondeado As Integer

        Console.WriteLine("Introduce el valor de x: ")
        x = Console.ReadLine
        Console.WriteLine("Introduce el valor de y: ")
        y = Console.ReadLine

        Console.WriteLine("Arcotan = " & Math.Atan2(y, x))

        Truncado = Math.Floor(Math.Atan2(y, x))
        Console.WriteLine("Arcotan Truncado = " & Truncado)
        Redondeado = Math.Round(Math.Atan2(y, x))
        Console.WriteLine("Arcotan Redondeado = " & Redondeado)



        Console.Read()


    End Sub


End Module
