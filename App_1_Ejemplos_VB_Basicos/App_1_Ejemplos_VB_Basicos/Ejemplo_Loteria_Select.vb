Module Ejemplo_Loteria_Select

    Sub main()

        Dim Premio As Integer = 25
        Dim Lotería As Integer

        Console.WriteLine("Teclea un número entre 0 y 100, a ver si adivinas el que estoy pensando" + vbCrLf & "Tienes 5 intentos")



        For i = 1 To 5
            Lotería = Console.ReadLine
            Select Case Lotería

                Case = Premio
                    Console.WriteLine("Enhorabuena, has acertado, pero el premio no tenía dotación")
                    Exit For
                Case > Premio
                    Console.WriteLine("Te has pasado, lo siento")
                    Continue For
                Case < Premio
                    Console.WriteLine("Te has quedado corto")
                    Continue For

            End Select
            i = i + 1

        Next

        Console.Read()

    End Sub

End Module
