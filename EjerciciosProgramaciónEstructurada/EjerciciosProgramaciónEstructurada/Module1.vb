Module Module1

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



    Sub mainEjemploContinue()

        Console.WriteLine("Empezando")
        For i = 0 To 20
            Console.WriteLine("Inicio del bucle")
            If i = 5 Then
                Console.WriteLine("Si el valor es igual a 5")
                Continue For

                Console.WriteLine("Si el valor es igual a 5 segunda parte")
            End If

            Console.WriteLine("Procesamientos específicos para los números diferentes a 5")

        Next

        Console.WriteLine("Fin de bucle")

        Console.Read()

    End Sub



    Sub mainVelocidades()

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



    Sub Main15()

        Dim arcoiris() As String = New String() {"rojo", "verde", "azu", "amarillo"}

        For Each color As String In arcoiris
            Console.WriteLine("Toca el color " & color)
        Next

        Console.Read()


    End Sub


    Sub MainGerman1()
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




    Sub MainFer()
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


    Sub mainOscar1()
        Dim texto, texto2 As String
        Dim valor As Integer
        Dim dato As Single
        Do
            Console.WriteLine("Donde te encuentras?")
            Console.WriteLine("E - Europa (km/h)")
            Console.WriteLine("U - USA (MILLAS/HORA)")
            Console.WriteLine("M - MAR (NUDOS)")
            Console.WriteLine("S - SALIR")
            Console.Write("opcion: ")
            texto = Console.ReadLine
            Select Case texto
                Case "E"
                    dato = 3.6
                    texto2 = "km/h"
                Case "U"
                    dato = 4
                    texto2 = "millas"
                Case "M"
                    dato = 5
                    texto2 = "nudos"
                Case "S"
                    Exit Do
            End Select
            Console.Write("dime cuantos metros por segundo: ")
            valor = Console.ReadLine()
            Console.WriteLine("Son: " & valor * dato & " " & texto2)
        Loop
    End Sub





    Sub Main1()

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
