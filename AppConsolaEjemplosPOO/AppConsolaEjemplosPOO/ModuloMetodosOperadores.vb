Module ModuloMetodosOperadores
    Structure ColeccionCoches
        Public numero As Integer
        Public precio As Integer

        Sub Mostrar()
            Console.WriteLine("Num: " & numero & ", precio: " &
                              precio)
        End Sub
        Function Sumar(otraColeccCoche As ColeccionCoches) As ColeccionCoches
            Sumar.numero = Me.numero + otraColeccCoche.numero
            Sumar.precio = Me.precio + otraColeccCoche.precio
        End Function
        Public Shared Operator +(col_1 As ColeccionCoches, col_2 As ColeccionCoches)
            Dim resSuma As ColeccionCoches
            resSuma.numero = col_1.numero + col_2.numero
            resSuma.precio = col_1.precio + col_2.precio
            Return resSuma
        End Operator
    End Structure
    Public Sub IniciarEjemplosOperadores()
        Dim C_1, C_2, C_suma As ColeccionCoches

        C_1.numero = 5
        C_2.numero = 15
        C_1.precio = 100000
        C_2.precio = 200000
        ' C_suma.numero = C_1.numero + C_2.numero
        ' C_suma.precio = C_1.precio + C_2.precio
        'C_suma = C_1.Sumar(C_2)
        C_suma = C_1 + C_2

        C_suma.Mostrar()
    End Sub
End Module
