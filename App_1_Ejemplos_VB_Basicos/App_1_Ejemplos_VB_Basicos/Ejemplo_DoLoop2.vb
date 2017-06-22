Module Ejemplo_DoLoop2
    Sub Main()
        Dim opcion As Char
        Dim metros As Single
        Do
            Console.WriteLine("Opciones: " + vbCrLf & " (E)uropa" + vbCrLf &
                              " (U)SA" + vbCrLf & " (M)ar" + vbCrLf & " (S)alir")

            opcion = Console.ReadKey().KeyChar

            If opcion <> "s" And opcion <> "S" Then
                Console.WriteLine("Indique los metros por segundo:")
                metros = Console.ReadLine()
                Select Case opcion
                    Case "E", "e"
                        Console.WriteLine("Km/h " & metros * 3.6)
                    Case "U", "u"
                        Console.WriteLine("Millas " & metros * 4)
                    Case "M", "m"
                        Console.WriteLine("Nudos " & metros * 5)
                End Select
            End If
        Loop Until opcion = "s" Or opcion = "S"
    End Sub

End Module
