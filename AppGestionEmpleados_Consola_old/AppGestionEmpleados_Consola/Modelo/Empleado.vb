Namespace AppEmpleados
    Namespace Modelo
        ' Nuevo tipo de variable, inventado por nosotros. 
        Public Structure Empleado
            Public nombre As String
            Public apellidos As String
            Public genero As TipoGenero
            Public categoria As TipoCategoria
            ' Constructor
            Public Sub New(nuevoNombre As String, nuevoApell As String, nuevoGenero As TipoGenero, nuevaCategoria As TipoCategoria)
                nombre = nuevoNombre
                apellidos = nuevoApell
                genero = nuevoGenero
                categoria = nuevaCategoria
                Console.Write("Se ha creado el nuevo empleado " + nombre)
            End Sub
            Function NombreCompleto() As String
                Return nombre & " " & apellidos
            End Function
            Function RellenarConRegistroInStr(ByVal textoRegistro As String) As Boolean
                Dim valorCampo As String = ""
                Dim posInicioCampo As Integer = 1
                Dim posFinCampo As Integer = 1
                textoRegistro = textoRegistro & ","
                ' AQUI RECORRER EL REGISTRO PARA EXTRAER LOS CAMPOS
                While posInicioCampo >= 0 And posInicioCampo < textoRegistro.Length
                    posFinCampo = Strings.InStr(posInicioCampo, textoRegistro, ",")
                    valorCampo = Strings.Mid(textoRegistro, posInicioCampo, posFinCampo - posInicioCampo)
                    posInicioCampo = posFinCampo + 1
                    Console.WriteLine("valorCampo = " & valorCampo)
                End While
                'valorCampo = Strings.Mid(textoRegistro, textoRegistro.Length, 1)
                'Console.WriteLine("últimoCampo = " & valorCampo)
                Return True
            End Function
            Function RellenarConRegistroSPLIT(ByVal textoRegistro As String) As Boolean

                Dim arrayCampos() As String = textoRegistro.Split(",")

                If arrayCampos.Length = 4 Then
                    nombre = arrayCampos(0)
                    apellidos = arrayCampos(1)
                    genero = Integer.Parse(arrayCampos(2))
                    categoria = Integer.Parse(arrayCampos(3))
                    Console.WriteLine(ToString())
                    Return True
                Else
                    Console.WriteLine("Error al leer empleado " & textoRegistro)
                    Return False
                End If
            End Function

            Overrides Function ToString() As String
                Return NombreCompleto() & " " & genero.ToString() & " " & categoria.ToString
            End Function
        End Structure

    End Namespace
End Namespace
