Module Ejemplo_Edad_Case

    Sub main()

        Dim edad As Integer = Console.ReadLine


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
                Console.WriteLine("Adulto")
            Case Else
                Console.WriteLine("Me jubilo")
        End Select

        Console.Read()


    End Sub


End Module
