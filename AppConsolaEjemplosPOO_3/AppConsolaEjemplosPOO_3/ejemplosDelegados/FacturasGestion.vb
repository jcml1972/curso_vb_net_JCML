Public Module FacturasGestion
    Sub Main()
        Dim miFacturacion As Facturacion
        miFacturacion = New Facturacion()

        AddHandler miFacturacion.CalculoFacturasTerminado, AddressOf ControladorFinCalculoFacturas
        AddHandler miFacturacion.CalculoFacturasTerminado, AddressOf OtroControlador

        miFacturacion.CalculoFacturas()

        Console.ReadKey()
    End Sub

    Sub ControladorFinCalculoFacturas(sender As Object, args As EventArgs)
        ' Cuando se produce evento CalculoFacturasTerminado
        Console.WriteLine("EL CALCULO HA TERMINADO!!")
    End Sub
    Sub OtroControlador(sender As Object, args As EventArgs)
        ' Cuando se produce evento CalculoFacturasTerminado
        Console.WriteLine("Vaya, se acabó el cálculo!!")
    End Sub
End Module
