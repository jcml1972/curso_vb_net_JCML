Imports AppGestionEmpleados_Consola.Modelo
Namespace Utilidades
    Module UtilidadesMenu
        ' *** FUNCIONES PUBLICAS
        Public Function SeleccionarOpcion(titulo As String, textosOpciones() As String) As Integer
            Dim codigo As Integer = 0

            MostrarTitulo(titulo)
            MostrarMenu(textosOpciones)
            PedirCodigoOpcion(0, textosOpciones.Length - 1, codigo)
            Return codigo
        End Function
        Public Sub MostrarTitulo(titulo As String)
            System.Console.WriteLine(vbNewLine & " *** " & titulo & " ***" & vbNewLine)
        End Sub
        Public Function PedirCampo(nombre As String)
            Console.Write("Introduzca " & nombre & ": ")
            Dim campo As String = Console.ReadLine()
            Return campo
        End Function
        Public Function PedirGenero() As TipoGenero
            Console.WriteLine("Introduzca el género (1 = Varon, 2 = Mujer, 3 = Hermafrodita: ")
            Dim generoNumero As Integer
            PedirCodigoOpcion(3, generoNumero)
            Dim generoEnum As TipoGenero = generoNumero
            Return generoEnum
        End Function
        Public Function PedirCategoria() As TipoCategoria
            Console.WriteLine("Introduzca la categoria (1 = JefeEquipo, 2 = Tecnico, 3 = Administrativo: ")
            Dim categoriaNumero As Integer
            PedirCodigoOpcion(3, categoriaNumero)
            Dim categoriaEnum As TipoGenero = categoriaNumero
            Return categoriaEnum
        End Function

        ' *** FUNCIONES PRIVADAS
        Private Sub MostrarMenu(textosOpciones() As String)
            For numOpcion = 1 To textosOpciones.Length - 1
                Console.WriteLine(numOpcion & " - " & textosOpciones(numOpcion))
            Next
            Console.WriteLine("0 - " & textosOpciones(0))
        End Sub
        Private Sub PedirCodigoOpcion(ByVal Maximo As Integer,
                                  ByRef codigo As Integer)
            PedirCodigoOpcion(1, Maximo, codigo)
        End Sub
        Private Sub PedirCodigoOpcion(ByVal Minimo As Integer,
                                  ByVal Maximo As Integer,
                                  ByRef codigo As Integer)
            Dim tecla As Char
            Do
                tecla = Console.ReadKey.KeyChar
                If Integer.TryParse(tecla, codigo) Then
                    Return
                End If
            Loop While codigo < Minimo Or codigo > Maximo
        End Sub
    End Module
End Namespace
