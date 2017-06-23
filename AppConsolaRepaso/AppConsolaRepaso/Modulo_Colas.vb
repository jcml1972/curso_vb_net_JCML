Module Modulo_Colas

    Dim cola As Queue(Of Persona)

    Sub main()
        cola = New Queue(Of Persona)

        Dim p1 As Persona = New Persona("Juan", 30)
        Dim p2 As Persona = New Empleado("Luís", 40, 55000)
        Dim p3 As Empleado = New Empleado("Miguel", 50, 30000)
        Dim yo As Empleado = New Persona("Juan Carlos", 44)

        cola.Enqueue(p1)
        cola.Enqueue(p2)
        cola.Enqueue(p3)
        cola.Enqueue(yo)

        cola.Reverse

        Console.WriteLine("1º en salir es " & cola.Dequeue().ToString)
        Console.WriteLine("2º en salir es " & cola.Dequeue().ToString)
        Console.WriteLine("3º en salir es " & cola.Dequeue().ToString)
        Console.WriteLine("4º en salir es " & cola.Peek().ToString)
        Console.WriteLine("4º en salir es " & cola.ElementAt(0).ToString)




        Console.ReadKey()


    End Sub

End Module
