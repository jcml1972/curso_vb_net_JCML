Imports AppConsolaEjemplosGenericos

Public Class ListaFIFO(Of TElemento)

    Implements IListaFIFO(Of TElemento)

    Private arrayInterno(-1) As TElemento



    Public Sub AgregarElemento(elemento As TElemento) Implements IListaFIFO(Of TElemento).AgregarElemento

        Dim arrayTemporal As TElemento()
        ReDim arrayTemporal(arrayInterno.Length)
        arrayInterno.CopyTo(arrayTemporal, 0)
        arrayTemporal(arrayInterno.Length) = elemento
        arrayInterno = arrayTemporal

    End Sub

    Public Sub Imprimir()
        Console.WriteLine("Lista de elementos")
        For Each elem As TElemento In arrayInterno
            Console.WriteLine(" - " & elem.ToString())
        Next
    End Sub

    Public Function SacarElemento() As TElemento Implements IListaFIFO(Of TElemento).SacarElemento
        Throw New NotImplementedException()
    End Function

End Class
