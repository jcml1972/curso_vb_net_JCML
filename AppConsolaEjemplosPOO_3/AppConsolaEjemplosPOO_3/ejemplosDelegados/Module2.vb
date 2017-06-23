Public Delegate Sub TipoFuncionCuandoCorrecto(textoDivision As String)
Public Delegate Sub TipoFuncionCuandoError()

Module Module2
    Sub Main()
        ' Dim subrutinaVariableCuandoCorrecto As TipoFuncionCuandoCorrecto = AddressOf SubrutinaCuandoCorrecto
        DivisionAvanzada(10, 3, AddressOf SubrutinaCuandoCorrecto, AddressOf SubtutinaCuandoError)

        DivisionAvanzada(10, 0, AddressOf SubrutinaCuandoCorrecto_B, AddressOf SubtutinaCuandoError_B) ' CON CERO
        Console.ReadKey()
    End Sub
    Function DivisionAvanzada(dividendo As Single, divisor As Single,
                              funcionCuandoCorrecto As TipoFuncionCuandoCorrecto,
                              funcionCuandoDivCero As TipoFuncionCuandoError) As Single
        If divisor = 0 Then
            funcionCuandoDivCero()
            Return 0
        Else
            Dim resultado = dividendo / divisor
            funcionCuandoCorrecto(resultado.ToString())
            Return resultado
        End If
    End Function
    Sub SubrutinaCuandoCorrecto(textDiv As String)
        Console.WriteLine("Resultado es " & textDiv)
    End Sub
    Sub SubtutinaCuandoError()
        Console.WriteLine("No se puede dividir")
    End Sub
    Sub SubrutinaCuandoCorrecto_B(textDiv As String)
        Console.WriteLine("B: Resultado es ")
        Console.WriteLine(textDiv)
    End Sub
    Sub SubtutinaCuandoError_B()
        Console.WriteLine("B: No se puede dividir")
    End Sub
End Module
