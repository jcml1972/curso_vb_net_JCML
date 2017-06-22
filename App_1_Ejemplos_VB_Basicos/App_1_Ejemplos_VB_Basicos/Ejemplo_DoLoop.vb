Module Ejemplo_DoLoop
    Sub main()

        Dim opcion As Char
        Do
            Console.WriteLine("Opciones: " + vbCrLf & " (E)uropa" + vbCrLf &
                              " (U)SA" + vbCrLf & " (M)ar" + vbCrLf & " (S)alir")

            opcion = Console.ReadKey().KeyChar

            If opcion <> "s" And opcion <> "S" Then
                Dim Velocidades() As Single = {1, 2, 5, 10, 50}
                For indice As Integer = 0 To Velocidades.Length - 1
                    Select Case opcion
                        Case "E", "e"
                            Console.WriteLine("Km/h " & Velocidades(indice) * 3.6)
                        Case "U", "u"
                            Console.WriteLine("Millas " & Velocidades(indice) * 4)
                        Case "M", "m"
                            Console.WriteLine("Nudos " & Velocidades(indice) * 5)
                    End Select
                Next
            End If
        Loop Until opcion = "s" Or opcion = "S"

    End Sub

End Module
