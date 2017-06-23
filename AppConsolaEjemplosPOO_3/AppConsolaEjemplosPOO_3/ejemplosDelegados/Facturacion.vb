Public Class Facturacion
    Public Event CalculoFacturasTerminado As EventHandler

    Public Sub CalculoFacturas()

        For i = 1 To 1000
            i = i + 1
        Next

        Dim argumentos As EventArgs = New EventArgs()
        Console.WriteLine("CALCULO FINALIZADO")
        RaiseEvent CalculoFacturasTerminado(Me, argumentos)
    End Sub
End Class
