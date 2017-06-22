Module Ejemplo_While
    Sub Main()
        Dim ubicacion As String
        Dim Velocidad As Integer

        ubicacion = ""

        While ubicacion <> "S"

            Console.WriteLine("Indique su ubicación:")
            Console.WriteLine("Europa (E)")
            Console.WriteLine("USA (U)")
            Console.WriteLine("Mar (M)")
            Console.WriteLine("Salir (S)")

            ubicacion = Console.ReadLine

            If ubicacion <> "S" Then
                Console.WriteLine("Introduzca velocidad:")

                Velocidad = Console.ReadLine

                Select Case ubicacion
                    Case "E"
                        Console.WriteLine("La velocidad es de " & Velocidad * 3.6 & "km/h")
                    Case "U"
                        Console.WriteLine("La velocidad es de " & Velocidad * 4 & "millas/h")
                    Case "M"
                        Console.WriteLine("La velocidad es de " & Velocidad * 5 & "nudos")
                    Case Else
                        Console.WriteLine("Ubicación incorrecta. Vuelva a indicar los valores")
                End Select

            Else
                Console.WriteLine("Adiós")
            End If

        End While

        Console.Read()

    End Sub

End Module
