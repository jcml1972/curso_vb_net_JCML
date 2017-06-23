Module EjemploArrayList

    Sub main()

        Dim listaempleados As List(Of String) = New List(Of String)

        listaempleados.Add("pepe")
        listaempleados.Add("paco")
        listaempleados.Add("peepon")
        listaempleados.Add("pepito")


        For Each elemento As String In listaempleados
            Console.WriteLine(" - " & elemento.ToString)
        Next

        Console.ReadKey()

    End Sub

End Module
