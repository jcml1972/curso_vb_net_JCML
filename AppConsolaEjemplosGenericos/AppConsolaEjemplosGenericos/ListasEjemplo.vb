
Public Class ListaEnteros

        Implements IListaFIFO(Of Integer)

        Public Sub AgregarElemento(elemento As Integer) Implements IListaFIFO(Of Integer).AgregarElemento
            Throw New NotImplementedException()
        End Sub

        Public Function SacarElemento() As Integer Implements IListaFIFO(Of Integer).SacarElemento
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class ListaEmpleados
        Implements IListaFIFO(Of Empleado)

        Public Sub AgregarElemento(elemento As Empleado) Implements IListaFIFO(Of Empleado).AgregarElemento
            Throw New NotImplementedException()
        End Sub

        Public Function SacarElemento() As Empleado Implements IListaFIFO(Of Empleado).SacarElemento
            Throw New NotImplementedException()
        End Function
    End Class
