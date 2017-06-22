Module Ejemplo_Edad_Case2

    Sub main()

        Dim edad As Integer
        Dim contador As Integer

        For contador = 1 To 10

            Console.WriteLine("Introduce Edad: ")
            edad = Console.ReadLine
            Console.WriteLine("Persona " & contador & " , edad=" & edad)

            Select Case edad
                Case < 12
                    Console.WriteLine("Niño")
                Case 12 To 17
                    Console.WriteLine("Adolescente")
                Case 18
                    Console.WriteLine("Por fin adulto")
                Case 19 To 20
                    Console.WriteLine("Universitario")
                Case 21 To 64
                    Console.WriteLine("Adulto, ¡todavía {0} años hasta la jubilación!", 65 - edad)
                Case Else
                    Console.WriteLine("Me jubilo")
            End Select
        Next

        Console.Read()


    End Sub




End Module
