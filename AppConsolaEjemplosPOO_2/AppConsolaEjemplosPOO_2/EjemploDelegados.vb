Module EjemploDelegados

    Public Delegate Function OperacionMatematica(op_1 As Double, op_2 As Double) As Double

    Sub Main()

        EjecutarOperacionMatematica(AddressOf Sumar, 7, 5)

        EjecutarOperacionMatematica(AddressOf Restar, 7, 5)

        Console.ReadKey()


    End Sub

    Public Function EjecutarOperacionMatematica(
        operacionaARealizar As OperacionMatematica,
        oper_1 As Double, oper_2 As Double) As Double

        Dim resultado = operacionaARealizar(oper_1, oper_2)

        Console.WriteLine("Operando con " & oper_1 & " y " & oper_2 & " = " & resultado)
        Return resultado

    End Function

    Function Sumar(operando_1 As Double, operando_2 As Double) As Double
        Console.WriteLine("Empezando a sumar: ")
        Return operando_1 + operando_2
    End Function

    Function Restar(operando_1 As Double, operando_2 As Double) As Double
        Console.WriteLine("Empezando a restar: ")
        Return operando_1 - operando_2
    End Function

End Module
