Module SistemaEventos_2


    Sub main()

        Dim miCalculo1 As Calculo_1
        miCalculo1 = New Calculo_1

        Dim miCalculo2 As Calculo_1
        miCalculo2 = New Calculo_1

        AddHandler miCalculo1.CalculoTerminado1, AddressOf ControladorFinCalculo1
        AddHandler miCalculo2.CalculoTerminado1, AddressOf ControladorFinCalculo2

        miCalculo1.Restar(10, 5)
        miCalculo2.Restar(20, 5)

        Console.ReadKey()


    End Sub

    Sub ControladorFinCalculo1(sender As Object, args As EventArgs)
        Console.WriteLine("SE HA HECHO EL CALCULO 1")

    End Sub

    Sub ControladorFinCalculo2(sender As Object, args As EventArgs)
        Console.WriteLine("SE HA HECHO EL CALCULO 2")

    End Sub

End Module
