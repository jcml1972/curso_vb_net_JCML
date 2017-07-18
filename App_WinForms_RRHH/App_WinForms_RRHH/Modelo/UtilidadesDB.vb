﻿Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Namespace Modelo
    Module UtilidadesDB
        <Extension()>
        Public Sub AñadirParametro(ByRef comando As OleDbCommand,
                                   clave As String,
                                   valor As String,
                                   Optional direccion As ParameterDirection = ParameterDirection.Input,
                                   Optional tipo As DbType = DbType.String,
                                   Optional tamaño As Integer = 50)

            If clave.Substring(0, 1) <> "@" Then
                clave = "@" + clave
            End If
            ' comando.CreateParameter()
            Dim parametro As OleDbParameter = New OleDbParameter(clave, valor)
            parametro.Direction = direccion
            parametro.DbType = tipo
            parametro.Size = tamaño
            comando.Parameters.Add(parametro)
        End Sub

        <Extension()>
        Public Sub Cerrar(comando As OleDbCommand)
            comando.Connection.Close()
            comando.Connection.Dispose()
        End Sub

        Public Function CrearCadenaConexion(proveedor As String, fuente_datos As String) As String
            Dim constructor As New OleDbConnectionStringBuilder()
            constructor.Provider = proveedor
            constructor.DataSource = fuente_datos
            Return constructor.ConnectionString
        End Function

        Public Function ComandoConConexion(cadena_conexion As String, consultaSQL As String) As OleDbCommand
            Dim conexionDB As New OleDbConnection(cadena_conexion)
            Dim comando As New OleDbCommand(consultaSQL, conexionDB)
            conexionDB.Open()
            Return comando
        End Function

    End Module
End Namespace