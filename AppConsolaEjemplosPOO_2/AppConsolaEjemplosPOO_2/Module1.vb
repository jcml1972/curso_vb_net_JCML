Module Module1

    Sub Main()
        Dim rec_1 As Rectangulo = New Rectangulo(5, 6)
        rec_1.Mostrar()
        Dim circ As Circulo = New Circulo(2, AddressOf CalculandoAreaCirculo)
        circ.Mostrar()

        Dim rec_2 As Figura = New Rectangulo(2, 3)
        Dim cir_2 As Figura = New Circulo(3, AddressOf CalculandoAreaCirculo)

        rec_2.Mostrar()
        cir_2.Mostrar()
        Console.WriteLine("Perímetro Decimal cir_2 es " & cir_2.Perimetro)

        ' no se puede instanciar una clase abstracta
        ' Dim fig As Figura = New Figura()

        Try
            Dim cir_2_circ As Circulo
            cir_2_circ = CType(rec_2, Circulo)
            cir_2_circ.Mostrar()
        Catch ex As InvalidCastException
            Console.WriteLine("Conversión NO válida")
        Catch ex As Exception
            Console.WriteLine("Error de tipo " & ex.Message)
        Finally
            Console.WriteLine("SIEMPRE SE EJECUTA AL TERMINAR")

        End Try

        Dim miVinoDonSimon = New Tetrabrik(7, 15, 5)

        Dim elementosconArea() As IConAreaCalculable

        elementosconArea = New IConAreaCalculable() {rec_1, rec_2, circ, miVinoDonSimon}

        For i = 0 To 3
            Console.WriteLine("Área Calculada " & elementosconArea(i).Area)
        Next

        Console.ReadKey()

    End Sub

    Sub CalculandoAreaCirculo(cadena As String)

        Console.WriteLine("Calculando Área Círculo: " & cadena)

    End Sub

    Sub CalcularPerimetroFigura(i As Integer)

        Console.WriteLine("Calculando Perimetro de la figura: " & i)

    End Sub

End Module
