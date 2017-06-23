Public Class Calculo_2

    Public Event CalculoTerminado2 As EventHandler
    Sub Restar(op_1 As Integer, op_2 As Integer)

        Dim argumentos As EventArgs = New EventArgs
        Console.WriteLine("Calcular 2: " & op_1 &
                          " - " & op_2)
        Console.WriteLine("Resultado : " & " = " &
                          (op_1 - op_2))
        Console.WriteLine("Pulse una tecla")
        Console.ReadKey()
        Console.WriteLine("Listo")
        RaiseEvent CalculoTerminado2(Me, argumentos)

    End Sub

End Class
