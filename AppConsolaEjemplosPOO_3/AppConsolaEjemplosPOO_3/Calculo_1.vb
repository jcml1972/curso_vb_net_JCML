Public Class Calculo_1
    Public Event CalculoTerminado1 As EventHandler

    Sub Restar(op_1 As Integer, op_2 As Integer)
        Dim argumentos As EventArgs = New EventArgs
        Console.WriteLine("Calcular 1: " & op_1 &
                          " - " & op_2 & " = " & (op_1 - op_2))
        RaiseEvent CalculoTerminado1(Me, argumentos)
    End Sub


End Class
