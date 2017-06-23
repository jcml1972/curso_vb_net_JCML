Module Modulo_Pilas

    Dim pila As Stack(Of Persona)

    Sub main()
        pila = New Stack(Of Persona)

        Dim p1 As Persona = New Persona("Juan", 30)
        Dim p2 As Persona = New Persona("Luís", 40)
        Dim p3 As Persona = New Persona("Miguel", 50)
        Dim yo As Persona = New Persona("Juan Carlos", 44)

        pila.Push(p1)
        pila.Push(p2)
        pila.Push(p3)
        pila.Push(yo)

        pila.Reverse

        Console.WriteLine("1º en salir es " & pila.Pop().ToString)
        Console.WriteLine("2º en salir es " & pila.Pop().ToString)
        Console.WriteLine("3º en salir es " & pila.Pop().ToString)
        Console.WriteLine("4º en salir es " & pila.Peek().ToString)
        Console.WriteLine("4º en salir es " & pila.ElementAt(0).ToString)




        Console.ReadKey()


    End Sub

End Module
