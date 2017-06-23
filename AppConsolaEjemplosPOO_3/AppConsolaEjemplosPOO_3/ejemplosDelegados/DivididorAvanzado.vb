Public Class DivididorAvanzado

    Public dividendo As Single
    Public divisor As Single

    Function DivisionAvanzada(funcionCuandoCorrecto As TipoFuncionCuandoCorrecto,
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

End Class
