Module Module1

    Sub MAIN()

        Dim OPERANDO1 As Integer
        Dim OPERANDO2 As Integer
        Dim OPERADOR As Char
        Dim RESULTADO As Single


        Console.WriteLine("Introduce el primer operando: ")
        OPERANDO1 = Console.ReadLine
        Console.WriteLine("Introduce el OPERADOR: ")
        OPERADOR = Console.ReadLine
        Console.WriteLine("Introduce el segundo operando: ")
        OPERANDO2 = Console.ReadLine

        Select Case OPERADOR
            Case "+"
                RESULTADO = OPERANDO1 + OPERANDO2
            Case "-"
                RESULTADO = OPERANDO1 - OPERANDO2
            Case "*"
                RESULTADO = OPERANDO1 * OPERANDO2
            Case "/"
                RESULTADO = OPERANDO1 / OPERANDO2
        End Select

        Console.WriteLine("El resultado es " & RESULTADO)

        Console.Read()


    End Sub



    Sub mainTABLAMULTFORNEXT()

        Console.WriteLine("Introduce un número: ")
        Dim número As Integer

        For número = 1 To 10

            número = Console.ReadLine
            Dim i As Integer = 1
            Do
                Console.WriteLine(número & " x " & i & " = " & número * i)
                i = i + 1
            Loop Until i = 10

        Next

        Console.ReadLine()



    End Sub


    Sub maincalcuDoLoop()

        Dim opcion As Char = "X"
        Dim operador As Char
        Dim operando_1, operando_2, resultado As Single

        Do
            Console.WriteLine("Introduzca operando 1")
            operando_1 = Console.ReadLine
            Console.WriteLine("Operador")
            operador = Console.ReadLine
            Console.WriteLine("Introduzca operando 2")
            operando_2 = Console.ReadLine

            Select Case operador
                Case "*"
                    resultado = operando_1 * operando_2
                Case "/"
                    resultado = operando_1 / operando_2
                Case "+"
                    resultado = operando_1 + operando_2
                Case "-"
                    resultado = operando_1 - operando_2
            End Select
            Console.WriteLine("El resultado es " & resultado)
            Console.WriteLine("Calcular (c), Salir (s)?")
            opcion = Console.ReadLine
        Loop While opcion = "c"



    End Sub


    Sub maincalcuWhile2()
        Dim opcion As Char = "X"
        Dim operador As Char
        Dim operando_1, operando_2, resultado As Single

        opcion = "c"
        While opcion = "c"
            Console.WriteLine("Introduzca operando 1")
            operando_1 = Console.ReadLine
            Console.WriteLine("Operador")
            operador = Console.ReadLine
            Console.WriteLine("Introduzca operando 1")
            operando_2 = Console.ReadLine

            Select Case operador
                Case "*"
                    resultado = operando_1 * operando_2
                Case "/"
                    resultado = operando_1 / operando_2
                Case "+"
                    resultado = operando_1 + operando_2
                Case "-"
                    resultado = operando_1 - operando_2
            End Select
            Console.WriteLine("El resultado es " & resultado)
            Console.WriteLine("Calcular (c), Salir (s)?")
            opcion = Console.ReadLine
        End While


    End Sub


    Sub mainTablaMultiplWhile()

        Console.WriteLine("Introduce un número: ")
        Dim número As Integer = Console.ReadLine

        While número > 0 And número < 10

            For i As Integer = 1 To 10
                Console.WriteLine(número & " x " & i & " = " & número * i)
            Next
            número = Console.ReadLine

        End While
        Console.ReadLine()


    End Sub

    Sub maintablamultiplicar()

        Console.WriteLine("Introduce un número: ")
        Dim número As Integer = Console.ReadLine


        For i As Integer = 1 To 10
            Console.WriteLine(número & " x " & i & " = " & número * i)
        Next

        Console.Read()


    End Sub


    Sub mainARCOTAN()
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

    Sub mainCirculo1()

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


    Sub mainedadCase2()

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

    Sub mainedadCase()

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


    Sub mainEdadIf()

        Dim edad As Integer = 65


        If edad < 12 Then
            Console.WriteLine("Niño")
        ElseIf edad >= 12 And edad <= 17 Then
            Console.WriteLine("Adolescente")
        ElseIf edad = 18 Then
            Console.WriteLine("Por fin adulto")
        ElseIf edad > 18 And edad <= 20 Then
            Console.WriteLine("Universitario")
        ElseIf edad > 20 And edad < 65 Then
            Console.WriteLine("Adulto")
        Else
            Console.WriteLine("Me jubilo")
        End If

        Console.Read()


    End Sub


    Sub mainIfNulo()
        Dim ciudad As String
        Dim etiqueta As String = If(ciudad, "indefinida")

        'Muestra "indefinida" 
        Console.WriteLine(etiqueta)

        ciudad = "VALENCIA"
        etiqueta = If(ciudad, "indefinida")

        'Muestra "VALENCIA" 
        Console.WriteLine(etiqueta)
        Console.Read()



    End Sub
    Sub mainEjemploIfString()
        Dim numClientes As Integer = 98
        Dim etiqueta As String = If(numClientes <= 100, "Menos de 100 clientes", "Al menos 100 clientes")
        'Muestra "Menos de 100 clientes" 
        Console.WriteLine(etiqueta)


        numClientes = 120
        etiqueta = If(numClientes <= 100, "Menos de 100 clientes", "Al menos 100 clientes")

        'Muestra "Al menos 100 clientes" 
        Console.WriteLine(etiqueta)
        Console.Read()


    End Sub
    Sub MainEjemploIf()



        Const OPERADOR As Char = "-"c

        Dim operador1 As Single = 5
        Dim operador2 As Single = 0
        Dim Resultado As Single
        Dim operadorValido As Boolean = True


        If OPERADOR = "+" Then

            Resultado = operador1 + operador2
        ElseIf OPERADOR = "-" Then
            Resultado = operador1 - operador2
        ElseIf OPERADOR = "/" Then
            Resultado = If(operador2 = 0, 0, operador1 / operador2)
            operadorValido = (operador2 <> 0)
        ElseIf OPERADOR = "*" Then
            Resultado = operador1 * operador2
        Else
            operadorValido = False
        End If

        If operadorValido Then
            Console.WriteLine("El resultado de " & operador1 & " " & OPERADOR & " " & operador2 & "=" & Resultado)
        Else
            Console.WriteLine("El operador no es válido")
        End If

        Console.Read()

    End Sub

End Module
