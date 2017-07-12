Imports System.Data.OleDb

Namespace Modelo

    Public Class EmpleadosAccess
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
            Dim listaEmpleados As New List(Of Empleado)
            Dim cadena_conexion As String = Constantes.CADENA_CONEX_ACCESS & NombreFichero

            Using conexionDB As New OleDbConnection(cadena_conexion)
                Dim consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " & "FROM Empleado ORDER BY Nombre, Apellidos ASC; "
                Console.WriteLine(consultaSQL)

                Dim comando As New OleDbCommand(consultaSQL, conexionDB)
                Try
                    conexionDB.Open()
                    Dim dataReader As OleDbDataReader = comando.ExecuteReader()

                    Do While dataReader.Read()
                        Dim nuevoeEmpleado As New Empleado()
                        nuevoeEmpleado.nombre = dataReader(0)
                        nuevoeEmpleado.apellidos = dataReader(1)
                        nuevoeEmpleado.genero = dataReader(2)
                        nuevoeEmpleado.categoria = dataReader(3)
                        nuevoeEmpleado.retribucionFija = dataReader(4)
                        listaEmpleados.Add(nuevoeEmpleado)
                    Loop

                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al exportar Access " & ex.Message)
                    Return False
                End Try
            End Using
            arrayEmpleados = listaEmpleados.ToArray
            Return True
            MessageBox.Show("Importado de " & NombreFichero)
        End Function

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Dim cadena_conexion As String = Constantes.CADENA_CONEX_ACCESS & NombreFichero
            ' Si la BD tuviera password habría que añadir, añadir separado por punto y coma, usuario y password
            ' TODO: Añadir ";User Id=admin;Password=Contraseña_1234"
            Using conexionDB As New OleDbConnection(cadena_conexion)
                Try
                    conexionDB.Open()

                    For Each empleado As Empleado In arrayEmpleados
                        ' INSERT TO empleado(Nombre, Apellidos, Genero) VALUES('Juan', 'López', 2)
                        Dim sql As String
                        sql = "INSERT INTO Empleado ( Nombre, Apellidos, Genero, Categoria, " _
                            & "Retribucion_Fija) VALUES ('" _
                            & empleado.nombre & "', '" & empleado.apellidos & "', " _
                            & empleado.genero & ", " & empleado.categoria & ", " _
                            & empleado.retribucionFija & " ) "

                        Console.WriteLine(sql)
                        Dim comando As OleDbCommand = New OleDbCommand(sql, conexionDB)
                        comando.ExecuteNonQuery()
                    Next

                Catch ex As Exception
                    MessageBox.Show("Error al exportar Access " & ex.Message)
                    Return False
                End Try
                conexionDB.Close() ' Es redundante con Using
                conexionDB.Dispose()
            End Using
            Return True
            MessageBox.Show("Exportado a " & NombreFichero)
        End Function
    End Class

End Namespace
