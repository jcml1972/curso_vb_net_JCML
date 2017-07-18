Imports System.Data.OleDb

Namespace Modelo

    Public Class EmpleadosAccessCRUD
        Implements IEmpleadosCRUD

        Private cadena_conexion As String
        Public avisarEnModificacion As TipoDelAvisarEnModificacion

        Public ReadOnly Property Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IEmpleadosCRUD.EstablecerAvisarEnModificacion
            avisarEnModificacion = funcionDelegada
        End Sub

        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar
            cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, persistenciaEmpleados.nombreFichero)
            avisarEnModificacion(False)
        End Sub

        Public Function BuscarEmpleados(nombre As String, apellidos As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados
            Dim consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado "

            If nombre <> "" Or apellidos <> "" Then
                consultaSQL = consultaSQL & " WHERE "
                If nombre <> "" Then
                    consultaSQL = consultaSQL & " nombre LIKE '%' + @nombre + '%' "
                End If
                If nombre <> "" And apellidos <> "" Then
                    consultaSQL = consultaSQL & " AND "
                End If
                If apellidos <> "" Then
                    consultaSQL = consultaSQL & " apellido LIKE '%' + @apellidos + '%' "
                End If
            End If
            consultaSQL = consultaSQL & " ORDER BY Nombre, Apellidos ASC;"

            BuscarEmpleados = New List(Of Empleado)

            Dim comando = ComandoConConexion(cadena_conexion, consultaSQL)
                Try
                    comando.AñadirParametro("@nombre", nombre)
                    comando.AñadirParametro("@apellidos", apellidos)

                Dim dataReader As OleDbDataReader = comando.ExecuteReader()
                    Do While dataReader.Read()
                        Dim nuevoEmpleado As New Empleado()
                        nuevoEmpleado.nombre = CType(dataReader(0), String)
                        nuevoEmpleado.apellidos = dataReader.GetString(1)
                        nuevoEmpleado.genero = CType(dataReader(2), TipoGenero)
                        nuevoEmpleado.categoria = CType(dataReader(3), TipoCategoria)
                        nuevoEmpleado.retribucionFija = CType(dataReader(4), Single)
                        BuscarEmpleados.Add(nuevoEmpleado)
                    Loop
                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al buscar " & ex.Message)
                End Try
            comando.Cerrar()
        End Function

        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            persistenciaEmpleados.Exportar(BuscarEmpleados("", "").ToArray())
            avisarEnModificacion(True)
        End Sub

        Public Sub Crear(nuevoEmpleado As Empleado) Implements IEmpleadosCRUD.Crear
            Dim consultaSQL = "INSERT INTO empleado ( Nombre, Apellidos, Genero, Categoria, " _
                            & "Retribucion_Fija ) VALUES (@nombre, @apellidos, @genero, @categoria, @retribucionFija )"
            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", nuevoEmpleado.nombre)
            comando.AñadirParametro("@apellidos", nuevoEmpleado.apellidos)
            comando.AñadirParametro("@genero", nuevoEmpleado.genero, , DbType.Int32)
            comando.AñadirParametro("@categoria", nuevoEmpleado.categoria, , DbType.Int32)
            comando.AñadirParametro("@retribucionFija", nuevoEmpleado.retribucionFija, , DbType.Single)

            comando.ExecuteNonQuery()
            comando.Cerrar()
        End Sub

        Public Sub Actualizar(empleado As Empleado, empleadoModif As Empleado) Implements IEmpleadosCRUD.Actualizar
            'BuscarEmpleados(empleado.nombre, empleado.apellidos)
        End Sub

        Public Sub Eliminar(empleado As Empleado) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub

        Public Sub Eliminar(empleados As List(Of Empleado)) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub

    End Class

End Namespace
