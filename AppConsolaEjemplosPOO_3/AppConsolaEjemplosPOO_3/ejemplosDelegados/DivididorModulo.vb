Module DivididorModulo

    Sub Main()
        Dim divAvan = New DivididorAvanzado() With {
            .dividendo = 10,
            .divisor = 3}

        divAvan.DivisionAvanzada(AddressOf SubrutinaCuandoCorrecto,
                                 AddressOf SubtutinaCuandoError)
        Console.ReadKey()
    End Sub

    Sub SubrutinaCuandoCorrecto(textDiv As String)
        Console.WriteLine("Resultado es " & textDiv)
    End Sub
    Sub SubtutinaCuandoError()
        Console.WriteLine("No se puede dividir")
    End Sub
End Module
