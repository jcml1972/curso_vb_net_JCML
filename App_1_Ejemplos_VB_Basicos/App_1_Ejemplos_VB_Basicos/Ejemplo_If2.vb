Module Ejemplo_If2
    Sub Main()

        Dim Número1 As Single
        Dim Número2 As Single
        Dim Máximo As Single
        Dim Mínimo As Single
        Dim Signo1 As Integer
        Dim Signo2 As Integer


        Console.WriteLine("Teclea el número 1:")
        Número1 = Console.ReadLine()
        Console.WriteLine("Teclea el número 2:")
        Número2 = Console.ReadLine()
        Signo1 = Math.Sign(Número1)
        Signo2 = Math.Sign(Número2)
        Máximo = Math.Max(Número1, Número2)
        Mínimo = Math.Min(Número1, Número2)

        Console.WriteLine("El máximo es " & Máximo)
        Console.WriteLine("El mínimo es " & Mínimo)

        If Signo1 = Signo2 Then
            Console.WriteLine("El signo de los dos números es el mismo")
        Else
            Console.WriteLine("El signo de los dos números es distinto")
        End If

        Console.Read()



    End Sub

End Module
