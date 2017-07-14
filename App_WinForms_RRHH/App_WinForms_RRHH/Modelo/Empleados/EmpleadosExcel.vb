Imports System.Data.OleDb

Namespace Modelo

    Public Class EmpleadosExcel
        Inherits EmpleadosBaseImportador
        Implements IPersistenciaEmpleados

        'Private _nombreFichero As String

        'Public Property NombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
        '    Get
        '        Return _nombreFichero
        '    End Get
        '    Set(value As String)
        '        If (value = "") Then
        '            Throw New Exception("No se ha establecido el nombre del fichero")
        '        Else
        '            _nombreFichero = value
        '        End If
        '    End Set
        'End Property

        Public Overrides Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            Dim listaEmpleados As New List(Of Empleado)
            Dim cadena_conexion As String = CADENA_CONEX_EXCEL & NombreFichero

            Using conexionXLS As New OleDbConnection(cadena_conexion)
                Dim consultaSQL = "SELECT * FROM [Hoja1$A2:E65535]"

                Console.WriteLine(consultaSQL)

                Dim comando As New OleDbCommand(consultaSQL, conexionXLS)
                Try
                    conexionXLS.Open()
                    Dim dataReader As OleDbDataReader = comando.ExecuteReader()

                    Do While dataReader.Read()
                        Dim nuevoeEmpleado As New Empleado()
                        nuevoeEmpleado.nombre = CType(dataReader(0), String)
                        nuevoeEmpleado.apellidos = CType(dataReader(1), String)
                        nuevoeEmpleado.genero = CType(dataReader(2), TipoGenero)
                        nuevoeEmpleado.categoria = CType(dataReader(3), TipoCategoria)
                        nuevoeEmpleado.retribucionFija = CSng(dataReader(4))
                        listaEmpleados.Add(nuevoeEmpleado)
                    Loop

                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al exportar Excel " & ex.Message)
                    Return False
                End Try
                Dim comandoContar As OleDbCommand = conexionXLS.CreateCommand()
                comandoContar.CommandText = "SELECT COUNT(*) FROM [Hoja1$A2:A65535]"
                Dim numEmpleados As Integer = CInt(comandoContar.ExecuteScalar())
                MessageBox.Show("Se han importado " & numEmpleados & " empleados")
            End Using

            'Dim fila As Integer = 2
            'Dim valorNombre As String = DameValorCelda(NombreFichero, "Hoja1", "A", fila)

            'While valorNombre <> ""
            '    ' AQUÍ NUEVO EMPLEADO, RELLENARLO CON VALORES, Y A LA LISTA
            '    Dim nuevoEmpleado As Empleado
            '    nuevoEmpleado.nombre = valorNombre
            '    nuevoEmpleado.apellidos = DameValorCelda(NombreFichero, "Hoja1", "B", fila)
            '    nuevoEmpleado.genero = CType(DameValorCelda(NombreFichero, "Hoja1", "C", fila), TipoGenero)
            '    nuevoEmpleado.categoria = CType(DameValorCelda(NombreFichero, "Hoja1", "D", fila), TipoCategoria)
            '    nuevoEmpleado.retribucionFija = CSng(DameValorCelda(NombreFichero, "Hoja1", "E", fila))
            '    listaEmpleados.Add(nuevoEmpleado)
            '    fila = fila + 1
            '    valorNombre = DameValorCelda(NombreFichero, "Hoja1", "A", fila)
            'End While

            arrayEmpleados = listaEmpleados.ToArray()
            MessageBox.Show("Importado " & NombreFichero)
            Return True
        End Function

        'Public Shared Function DameValorCelda(nombreFichero As String,
        '                                  hoja As String,
        '                                  columna As String,
        '                                  fila As Integer) As String

        '    If (Not (IO.File.Exists(nombreFichero))) Then
        '        Throw New IO.FileNotFoundException("No existe el archivo de Excel indicado")
        '    End If
        '    If (String.IsNullOrEmpty(hoja) OrElse
        '    String.IsNullOrEmpty(columna) OrElse
        '    fila < 1 OrElse fila > 65536) Then
        '        Throw New ArgumentException("Argumentos/valores no válidos")
        '    End If
        '    Dim cadenaConexion As String = CADENA_CONEX_EXCEL & nombreFichero
        '    ' Configurar la conexión
        '    Using conex As New OleDbConnection(cadenaConexion)
        '        ' Creamos un objeto Command
        '        Dim cmd As OleDbCommand = conex.CreateCommand()
        '        Dim celda As String = columna & fila
        '        ' Formatear la consulta SQL
        '        cmd.CommandText = String.Format("SELECT F1 FROM [{0}${1}:{2}]", hoja, celda, celda)

        '        'MessageBox.Show(cmd.CommandText)
        '        ' Abrir la conexión
        '        conex.Open()
        '        ' Ejecutar la consulta SQL
        '        Dim valor As Object
        '        Try
        '            valor = cmd.ExecuteScalar()
        '        Catch ex As Exception
        '            valor = ""
        '        End Try
        '        ' Devolver el valor convertido a String
        '        Return Convert.ToString(valor)
        '    End Using
        'End Function

        Public Overrides Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Dim oExcel As Object
            Dim oLibro As Object
            Dim oHoja As Object
            Try
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
                oHoja.Range("A2").resize(arrayEmpleados.Length, 5).value = ArrayDatos

                ' Guardar el libro y salir de Excel
                oLibro.saveas(NombreFichero)
                oExcel.Quit()

                MessageBox.Show("Exportado " & NombreFichero)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
                Return False
            End Try
            Return True
        End Function

    End Class

End Namespace
