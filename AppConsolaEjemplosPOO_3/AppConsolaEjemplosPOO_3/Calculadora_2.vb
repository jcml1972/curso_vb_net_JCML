
Module Calculadora_2

    Sub Sumar(op_1 As Single, op_2 As Single)
        Console.WriteLine("Calcular 2: " & op_1 &
                          " + " & op_2)
        Console.WriteLine("Resultado : " & " = " &
                          (op_1 + op_2))
        Console.WriteLine("Pulse una tecla")
        Console.ReadKey()
        Console.WriteLine("Listo")
    End Sub
    Sub Restar(sender As Object, e As EventArgs)

        Dim op As ObjetoResta
        op = CType(sender, ObjetoResta)

        Console.WriteLine("Calcular 2: " & op.op_1 &
                          " - " & op.op_2)
        Console.WriteLine("Resultado : " & " = " &
                          (op.op_1 - op.op_2))
        Console.WriteLine("Pulse una tecla")
        Console.ReadKey()
        Console.WriteLine("Listo")

    End Sub
End Module
