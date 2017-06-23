Module Module1

    Sub Main()
        Dim listaTextos As ListaFIFO(Of String)
        Dim listaEmpleados As ListaFIFO(Of Empleado)
        Dim listaEstudiantes As ListaFIFO(Of Estudiante)
        Dim listaInteger As ListaFIFO(Of Integer)


        listaEmpleados = New ListaFIFO(Of Empleado)()
        listaEmpleados.AgregarElemento(
            New Empleado() With {
            .codEmpleado = 1,
            .nombre = "Pedro"})
        listaEmpleados.AgregarElemento(
           New Empleado() With {
           .codEmpleado = 2,
           .nombre = "Luís"})
        listaEmpleados.AgregarElemento(
           New Empleado() With {
           .codEmpleado = 3,
           .nombre = "Marcos"})

        listaEmpleados.Imprimir()

        Console.ReadKey()

        listaEstudiantes = New ListaFIFO(Of Estudiante)()
        listaEstudiantes.AgregarElemento(
            New Estudiante() With {
            .notaFinal = 5,
            .nombre = "Paco"})
        listaEstudiantes.AgregarElemento(
           New Estudiante() With {
           .notaFinal = 0,
           .nombre = "Juan Carlos"})
        listaEstudiantes.AgregarElemento(
           New Estudiante() With {
           .notaFinal = 10,
           .nombre = "Marcos"})

        listaEstudiantes.Imprimir()

        Console.ReadKey()

        listaTextos = New ListaFIFO(Of String)

        listaTextos.AgregarElemento("TEXTO 1")
        listaTextos.AgregarElemento("TEXTO 2")
        listaTextos.Imprimir()

        Console.ReadKey()

        listaInteger = New ListaFIFO(Of Integer)

        listaInteger.AgregarElemento(1)
        listaInteger.AgregarElemento(2)
        listaInteger.Imprimir()

        Console.ReadKey()





    End Sub

End Module
