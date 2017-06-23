
' Tipos de datos
Delegate Function TipoFuncionQueDevuelveInteger() As Integer
Delegate Function TipoFuncionQueDevuelveSINGLE(x As Single) As Single

Enum TipoDatoEnum
    Valor_1
    Valor_2
End Enum

Module Module1

    ' Variables:
    Dim valorDato As TipoDatoEnum
    Dim referenciaAFuncion As TipoFuncionQueDevuelveInteger
    Dim referenciaAFuncionSingle As TipoFuncionQueDevuelveSINGLE
    Dim A, B As Integer

    Sub Main()
        ' asignaciones
        A = 10
        B = 20
        valorDato = TipoDatoEnum.Valor_2
        referenciaAFuncion = AddressOf Devolver_A

        Console.WriteLine("Valor: " & referenciaAFuncion()) ' Llamando a Devolver_A

        referenciaAFuncion = AddressOf Devolver_B
        Console.WriteLine("Valor: " & referenciaAFuncion()) ' Llamando a Devolver_B

        Pedir_A(AddressOf Devolver_A)

        Pedir_A(AddressOf Devolver_B)

        Console.ReadKey()
    End Sub

    Function Devolver_A() As Integer
        Return 10
    End Function

    Function Devolver_B() As Integer
        Return 20
    End Function
    Function Pedir_A(parametroQueEsUnaFuncion As TipoFuncionQueDevuelveInteger) As Single
        Console.WriteLine(parametroQueEsUnaFuncion())
        Return 10.5234343
    End Function
End Module
