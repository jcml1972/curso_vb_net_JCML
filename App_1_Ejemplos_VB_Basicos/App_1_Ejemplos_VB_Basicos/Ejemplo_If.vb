Module Ejemplo_If

    Sub Main()



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
