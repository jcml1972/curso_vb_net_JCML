Imports AppConsolaEjemplosGenericos

Public Interface IListaFIFO(Of TElemento)

    Sub AgregarElemento(elemento As TElemento)

    Function SacarElemento() As TElemento

End Interface

