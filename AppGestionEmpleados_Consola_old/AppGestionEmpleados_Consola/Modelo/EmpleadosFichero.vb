Namespace AppEmpleados
    Namespace Modelo
        Module EmpleadosFichero

            ' Graba un arrray de empleados en un fichero CSV y devuelve true si se ha grabado
            ' o devuelve false si ha habido un fallo de escritura
            Function GrabarFichero(ByVal arrayEmpleados() As Empleado, ByVal nombreFichero As String) As Boolean

                Dim fichero As System.IO.StreamWriter
                fichero = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\sinensia102\" & nombreFichero, False)

                For i = 0 To arrayEmpleados.Length - 1 Step 1
                    fichero.WriteLine(arrayEmpleados(i).nombre & "," &
                                      arrayEmpleados(i).apellidos & "," & arrayEmpleados(i).genero & "," & arrayEmpleados(i).categoria)
                Next
                fichero.Close()
                Return True
            End Function

            ' Lee un arrray de empleados desde un fichero CSV y devuelve true si se ha cargado
            ' o devuelve false si ha habido un fallo de lectura
            Function LeerFichero_Char(ByRef arrayEmpleados() As Empleado, ByVal nombreFichero As String) As Boolean
                Dim textoFichero As String
                textoFichero = My.Computer.FileSystem.ReadAllText("C:\Users\sinensia102\" & nombreFichero)

                Dim valorCampo As String = ""
                Dim empleado As Empleado = New Empleado()
                Dim contadorCampo As Integer = 0

                For i = 0 To textoFichero.Length - 1 Step 1
                    Dim caracterActual As Char = textoFichero.Chars(i)

                    If caracterActual.Equals(","c) Then
                        Console.WriteLine(valorCampo)
                        Select Case contadorCampo
                            Case 0
                                empleado.nombre = valorCampo
                            Case 1
                                empleado.apellidos = valorCampo
                            Case 2
                                empleado.genero = Integer.Parse(valorCampo)
                        End Select
                        contadorCampo = contadorCampo + 1
                        valorCampo = ""
                    ElseIf caracterActual = vbCr Then
                        Console.WriteLine("Ultimo campo " & valorCampo)
                        empleado.categoria = Integer.Parse(valorCampo)
                        valorCampo = ""
                        contadorCampo = 0
                        ' Redimensionar el array
                        ReDim Preserve arrayEmpleados(arrayEmpleados.Length)
                        ' Asignamos nuevo empleado
                        arrayEmpleados(arrayEmpleados.Length - 1) = empleado
                    ElseIf caracterActual <> vbLf Then
                        valorCampo = valorCampo & caracterActual
                    End If
                Next
            End Function
            ' Recibe un fichero concreto (el nombre)  y un array pero para almecenar los empleados
            ' Devuelve true si la operación ha sido realizada
            Function LeerFichero_VB_Instr(ByRef arrayEmpleados() As Empleado, ByVal nombreFichero As String) As Boolean

                'Microsoft.VisualBasic.Strings

                'Método Strings.Mid(Of String, Int32, Int32)
                ' Devuelve una cadena que contiene un número especificado de caracteres a partir de una posición especificada en una cadena.
                ' Devuelve un trozo de cadena que está dentro de un texto
                'Método Strings.InStr(Int32, String, String, CompareMethod)
                ' Devuelve un entero que especifica la posición inicial de la primera aparición de una cadena dentro de otra.
                ' Busca un texto dentro de otro
                Dim textoFichero As String
                textoFichero = My.Computer.FileSystem.ReadAllText("C:\Users\sinensia102\" & nombreFichero)

                Dim valorRegistro As String = ""
                Dim empleado As Empleado = New Empleado()
                Dim posInicioRegistro As Integer = 1
                Dim posFinRegistro As Integer = 1

                ' Console.WriteLine(vbCrLf & Strings.Mid(textoFichero, 5, 5))
                ' Console.WriteLine("PROBANDO: " & Strings.InStr(1, textoFichero, vbCrLf))

                ' Return False
                'Alberto, Alvarez, 1, 2[CR][LF]Borja, Baron, 1, 2[CR][LF]Carlos, Caballero, 1, 2[CR][LF]

                While posInicioRegistro > 0 And posInicioRegistro < textoFichero.Length

                    posFinRegistro = Strings.InStr(posInicioRegistro, textoFichero, vbCrLf)
                    textoFichero.IndexOf(vbCrLf, posFinRegistro)

                    valorRegistro = Strings.Mid(textoFichero, posInicioRegistro, posFinRegistro - posInicioRegistro)

                    empleado.RellenarConRegistroSPLIT(valorRegistro)

                    posInicioRegistro = posFinRegistro + 2

                    Console.WriteLine("valor Registro = " + valorRegistro)
                End While

            End Function
            Function LeerFichero_VB_Mod_JuanCarlos(ByRef arrayEmpleados() As Empleado, ByVal nombreFichero As String) As Boolean

                Dim textoFichero As String
                textoFichero = My.Computer.FileSystem.ReadAllText("C:\Users\sinensia102\" & nombreFichero)

                Dim valorCampo As String = ""
                Dim empleado As Empleado = New Empleado()
                Dim contadorCampo As Integer = 0
                Dim posicionInicial As Integer
                Dim tamañoCampo As Integer


                Console.WriteLine(Microsoft.VisualBasic.InStr(4, "ABCDEFG", "CDE"))

                For i = 0 To textoFichero.Length - 1
                    Dim caracterActual As Char = textoFichero.Chars(i)

                    If caracterActual.Equals(","c) Then
                        Console.WriteLine(valorCampo)
                        Select Case contadorCampo
                            Case 0
                                posicionInicial = 1
                                tamañoCampo = textoFichero.Length - i
                                empleado.nombre = Mid(valorCampo, posicionInicial, tamañoCampo)
                            Case 1
                                tamañoCampo = textoFichero.Length - tamañoCampo - i
                                empleado.apellidos = Mid(valorCampo, posicionInicial, tamañoCampo)
                            Case 2
                                empleado.genero = Mid(valorCampo, posicionInicial, 1)
                            Case 3
                                empleado.categoria = Mid(valorCampo, posicionInicial, 1)
                        End Select
                        contadorCampo = contadorCampo + 1
                        valorCampo = ""
                        posicionInicial = i + 1
                    ElseIf caracterActual.Equals(vbCr) Then
                        Console.WriteLine("Ultimo campo " & valorCampo)
                        valorCampo = ""
                        contadorCampo = 0
                        ' Redimensionar el array
                        ReDim Preserve arrayEmpleados(arrayEmpleados.Length)
                        ' Asignamos nuevo empleado
                        arrayEmpleados(arrayEmpleados.Length - 1) = empleado
                    End If
                Next
            End Function
            Function LeerFichero_VB_Split(ByRef arrayEmpleados() As Empleado, ByVal nombreFichero As String) As Boolean
                ' Declarar variables:
                '   arrayRegistros de tipo cadena
                Dim arrayRegistros() As String
                Dim valorRegistro As String = ""
                Dim empleado As Empleado = New Empleado()
                Dim textoFichero As String


                Try
                    '   leer todo el fichero y asignar a textoFichero
                    textoFichero = My.Computer.FileSystem.ReadAllText("C:\Users\sinensia102\" & nombreFichero)
                    '   asignar a arrayRegistros el textoFichero separado con Split
                    arrayRegistros = textoFichero.Split(vbCrLf)
                    ' Bucle Para numeroRegistro desde 0 hasta ultimo elemento de arrayRegistros
                    For i = 0 To arrayRegistros.Length - 1
                        arrayRegistros(i) = arrayRegistros(i).Replace(vbLf, "")
                        '   llamar metodo RellenarConRegistro de empleado pasando como parametro el elemento...
                        '   ...del arrayRegistros(numeroRegistro)
                        Dim siSeHaRellenadoEmpleado = empleado.RellenarConRegistroSPLIT(arrayRegistros(i))
                        If siSeHaRellenadoEmpleado Then
                            '   Redimensionar arrayEmpleados
                            ReDim Preserve arrayEmpleados(i)
                            '   Añadir empleado al final de arrayEmpleados
                            arrayEmpleados(i) = empleado
                        End If
                        ' Fin bucle
                    Next
                    ' Devolver Verdadero
                Catch ex As IndexOutOfRangeException
                    Console.WriteLine("Hay más elementos de los permitidos")
                    Console.WriteLine(ex.Message)
                    Console.WriteLine(ex.StackTrace)
                Catch ex As system.IO.FileNotFoundException

                    Console.WriteLine("No se encuentra el fichero en la ruta espcecificada C:\Users\sinensia102\" & nombreFichero)

                End Try










            End Function
            Sub ProbandoString()
                Dim texto = "    ABCDEFGHIJKLM    "

                Console.WriteLine(texto)

                Console.WriteLine("Son iguales " & texto.Equals("ABCDEFGHIJKLM"))
                Console.WriteLine("Son iguales " & (texto = "ABCDEFGHIJKLM"))

                Console.WriteLine("Longitud " & texto.Length())
                Dim textIzquierda = ""

                Console.WriteLine("Los cinco primeros " & texto)
            End Sub
        End Module
    End Namespace
End Namespace
