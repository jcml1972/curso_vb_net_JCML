Module MENU

    Dim textosOpciones() As String = New String() {"Salir", "Añadir empleado", "Seleccionar empleado", "Precio sin IVA"}
    Dim teclasOpciones() As Char = New Char() {"0", "1", "2", "3"}

    Sub Mostrar()
        ' Código para seleccionar una opcion
        Console.WriteLine(vbNewLine + vbNewLine + "MENU: Seleccione una opcion")

        For i As Integer = 0 To textosOpciones.Length - 1
            Console.WriteLine(teclasOpciones(i) & " - " & textosOpciones(i))
        Next
    End Sub

    Function PedirOpcion() As Integer

        Dim teclaOpcionSel As Char

        teclaOpcionSel = Console.ReadKey.KeyChar
        PedirOpcion = Integer.Parse(teclaOpcionSel)
        Console.WriteLine("Ha seleccionado (" & teclaOpcionSel & ") "" " & textosOpciones(PedirOpcion) & """")

        ' Return numeroOpcionSel

    End Function


End Module
