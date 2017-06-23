Module Calculadora_1
    Sub Sumar(op_1 As Single, op_2 As Single)
        Console.WriteLine("Calcular 1: " & op_1 &
                          " + " & op_2 & " = " & (op_1 + op_2))
    End Sub

    Sub Restar(sender As Object, e As EventArgs)

        Dim op As ObjetoResta
        op = CType(sender, ObjetoResta)

        Console.WriteLine("Calcular 1: " & op.op_1 &
                          " - " & op.op_2 & " = " & (op.op_1 - op.op_2))
    End Sub
End Module
