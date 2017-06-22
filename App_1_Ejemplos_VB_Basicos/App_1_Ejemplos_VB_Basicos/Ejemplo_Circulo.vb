Module Ejemplo_Circulo

    Sub main()

        Dim Radio, area As Single
        Dim Número_de_Círculos As Integer

        Console.WriteLine("Introduce el número de círculos: ")
        Número_de_Círculos = Console.ReadLine

        For contador = 1 To Número_de_Círculos
            Console.WriteLine("Introduce el radio en cm: ")
            Radio = Console.ReadLine
            area = Math.PI * Math.Pow(Radio, 2)
            Console.WriteLine("Él área del círculo es: " & area)

            Select Case area
                Case < 10
                    Console.WriteLine("El Círculo es pequeño")
                Case 10 To 100
                    Console.WriteLine("El Círculo es mediano")
                Case Else
                    Console.WriteLine("El Círculo es grande")
            End Select
        Next

        Console.Read()

    End Sub



End Module
