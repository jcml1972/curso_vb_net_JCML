Namespace Modelo

    Public Class EmpleadosGenerador
        Implements IPersistenciaEmpleados

        Public Property nombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            ReDim arrayEmpleados(10000)

            For num = 0 To 10000
                Dim nuevoEmpl As New Empleado()
                nuevoEmpl.nombre = dameNombreAleatorio()
                nuevoEmpl.apellidos = dameApellidoAleatorio() & " " & dameApellidoAleatorio()
                nuevoEmpl.genero = Rnd() * 3 + 1
                nuevoEmpl.categoria = Rnd() * 3 + 1
                nuevoEmpl.retribucionFija = CInt(Rnd() * 20 + 1) * 1000 + 15000

                arrayEmpleados(num) = nuevoEmpl
            Next
        End Function

        Function dameNombreAleatorio() As String
            Dim nombres() = New String() {"Juan", "Pepe", "Víctor", "Germán", "Óscar", "Sara", "Lucía", "Juan Carlos", "Sergi"}
            Return nombres(Rnd() * (nombres.Length - 1))
        End Function

        Function dameApellidoAleatorio() As String
            Dim apellidos() = New String() {"Martín", "Gómez", "Pelayo", "Escobedo", "Pérez", "Escolar", "Garrido", "Forero", "Arrizabalaga", "Ruiz", "Encabo", "Alarcón", "Ariza", "Torrent", "López"}
            Return apellidos(Rnd() * (apellidos.Length - 1))
        End Function

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Throw New NotImplementedException()
        End Function
    End Class


End Namespace