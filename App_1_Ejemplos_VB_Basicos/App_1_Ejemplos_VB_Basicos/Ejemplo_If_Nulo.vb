Module Ejemplo_If_Nulo

    Sub main()
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


End Module
