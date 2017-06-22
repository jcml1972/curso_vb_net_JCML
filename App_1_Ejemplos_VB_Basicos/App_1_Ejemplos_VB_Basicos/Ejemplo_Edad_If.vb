Module Ejemplo_Edad_If

    Sub main()

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


End Module
