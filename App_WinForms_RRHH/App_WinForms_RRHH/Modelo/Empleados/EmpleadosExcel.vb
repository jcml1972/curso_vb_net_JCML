Namespace Modelo

    Public Class EmpleadosExcel
        Implements IPersistenciaEmpleados

        Private _nombreFichero As String

        Public Property NombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Return _nombreFichero
            End Get
            Set(value As String)
                If (value = "") Then
                    Throw New Exception("No se ha establecido el nombre del fichero")
                Else
                    _nombreFichero = value
                End If
            End Set
        End Property

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            MessageBox.Show("Importar " & NombreFichero)
            'Throw New NotImplementedException()
        End Function

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Dim oExcel As Object
            Dim oLibro As Object
            Dim oHoja As Object
            ' Creamos un objeto cuyo contenido es una instancia de Excel
            oExcel = CreateObject("Excel.Application")
            ' Comenzar nuevo libro de excel
            oLibro = oExcel.Workbooks.Add
            oHoja = oLibro.Worksheets(1)

            Dim ArrayDatos(arrayEmpleados.Length - 1, 5)
            Dim i As Integer
            For i = 0 To arrayEmpleados.Length - 1
                ArrayDatos(i, 0) = arrayEmpleados(i).nombre
                ArrayDatos(i, 1) = arrayEmpleados(i).apellidos
                ArrayDatos(i, 2) = arrayEmpleados(i).genero
                ArrayDatos(i, 3) = arrayEmpleados(i).categoria
                ArrayDatos(i, 4) = arrayEmpleados(i).retribucionFija
            Next
            oHoja.range("A1:E1").value = New String() {"NOMBRE", "APELLIDOS", "GÉNERO", "CATEGORÍA", "RETRIBUCIÓN FIJA"}
            oHoja.Range("A2").resize(arrayEmpleados.Length - 1, 5).value = ArrayDatos

            ' Guardar el libro y salir de Excel
            oLibro.saveas(NombreFichero)
            oExcel.Quit()

            MessageBox.Show("Exportado " & NombreFichero)
            'Throw New NotImplementedException()
        End Function

    End Class

End Namespace
