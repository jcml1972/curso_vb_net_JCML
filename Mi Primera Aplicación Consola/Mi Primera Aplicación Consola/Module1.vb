Module Module1

    Sub Main()

        'Const PI As Single = 3.1415927
        'Dim operador1 = 3
        'Dim operador2 = 3 * PI
        'Const PI2 As Double = 2 * Math.PI

        'Dim resultado = operador1 <> operador2
        'Dim cadena = "otra caden"
        'Dim resultado2 As Boolean = TypeOf cadena Is String

        'resultado2 = False



        'If operador1 = 4 Then
        '    Console.WriteLine("Resultado: " & operador1)
        'ElseIf cadena = "otra cadena" Then
        '    Console.WriteLine("Otra cadena es igual")
        'ElseIf cadena = "otra cadena 2" Then
        '    Console.WriteLine("Otra cadena2 es igual")
        'Else
        '    Console.WriteLine("Cuando es falso")

        'End If


        'Console.Read()

        Const OPERADOR As Char = "u"c

        Dim operador1 As Single = 5
        Dim operador2 As Single = 7



        Dim Resultado As Single

        If OPERADOR = "+" Then

            Resultado = operador1 + operador2
        ElseIf OPERADOR = "-" Then
            Resultado = operador1 - operador2
        ElseIf OPERADOR = "/" Then
            Resultado = operador1 / operador2
        ElseIf OPERADOR = "*" Then
            Resultado = operador1 * operador2
        Else
            Resultado = "No has puesto un operador válido"

        End If

        Console.WriteLine("El resultado es " & Resultado)
        Console.Read()

    End Sub

End Module
