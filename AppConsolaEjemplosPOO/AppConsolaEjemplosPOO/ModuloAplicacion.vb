Module ModuloAplicacion
    Dim miFerrari, miSinca1000, miSEAT As Coche

    Sub Main()
        Instanciacion()
        GestionarFerrari()
        ' GestionarSinca1000()
        ' MiembrosEstaticos()
        ' ClasesAnonimas()
        ' ModuloMetodosOperadores.Iniciar()
        Console.ReadKey()
    End Sub

    Sub Instanciacion()
        miFerrari = New Coche("Ferrari")
        miSinca1000 = New Coche(400000, "Sinca 1000")

        'Dim otroCoche = New Coche() ' NO SE PUEDE

        miSEAT = New Coche("Seat Ibiza") With {
            .Color = "Rojo",
            .Puertas = 2}
    End Sub
    Sub GestionarFerrari()

        miFerrari.Ruedas()(2) = 10
        For numRueda = 0 To 3
            Console.WriteLine("Rueda " & numRueda & ": " &
                              miFerrari.RuedasP(numRueda))

        Next
        miFerrari.EsteblecerModelo("Ferrari Testarrosa")

        Console.WriteLine("Puertas de ferrari: " &
                          miFerrari.Puertas) ' GET
        miFerrari.Color = "Rojo"
        Console.WriteLine("Puertas de ferrari: " &
                          miFerrari.Puertas) ' GET

        ' miFerrari.Carburante = 10

        miFerrari.LlenarDeposito()
        miFerrari.RecorrerKM(10)
        Console.WriteLine("Carburante del ferrari: " &
                          miFerrari.Carburante)

        MostrarInfoCoche(miFerrari)


        Dim vehiculoFerrari As Vehiculo = miFerrari


        Console.WriteLine("Como Coche: ")
        miFerrari.Acelerar()
        miFerrari.Acelerar_Overrides()
        miFerrari.Acelerar_Shadows()
        miFerrari.Frenar_Overrides()

        Console.WriteLine("Como Vehículo: ")
        vehiculoFerrari.Acelerar()
        vehiculoFerrari.Acelerar_Overrides()
        vehiculoFerrari.Acelerar_Shadows()
        vehiculoFerrari.Frenar_Overrides()

        Dim ferrariObjeto As Object
        ferrariObjeto = miFerrari
        ferrariObjeto.ToString()


    End Sub

    Sub GestionarSinca1000()

        miSinca1000.EsteblecerModelo("")
        miSinca1000.Puertas = 1 ' SET
        miSinca1000.RecorrerKM(30)

        Console.WriteLine("Puertas de Sinca: " &
                          miSinca1000.Puertas) ' GET

        miSEAT.MostrarInfoCoche()

        'Mostrar resultados:
        miSinca1000.MostrarInfoCoche()
    End Sub
    Sub MiembrosEstaticos()


        Console.WriteLine("Coches totales " &
                          Coche.numeroCoches)
        Console.WriteLine("KM totales " &
                          Vehiculo.kmGlobales)

        Console.WriteLine("NumRuedas " &
                          Coche.NumRuedas)
        Coche.LavarCoche(miFerrari)
        Vehiculo.LavarVehiculo(miSinca1000)
    End Sub
    Sub ProbarPropiedades()

        miFerrari.Puertas = 2 ' SET

        miFerrari.Ruedas()(1) = 10
    End Sub
    Sub EjemploCadena()
        Console.WriteLine("A B C D es palindromo = " &
                          "A B C D".EsPalindromo())

        Console.WriteLine("A B B A es palindromo = " &
                          "A B B A".EsPalindromo())
    End Sub
    Sub ClasesAnonimas()

        Dim barbacoa = New With {
            .mazorcas = 2,
            .sardinas = 30,
            .alitas = 10,
            .pancetas = 4
            }
        barbacoa.mazorcas = 4
        Console.WriteLine("mazorcas = " & barbacoa.mazorcas)
        Console.WriteLine("sardinas = " & barbacoa.sardinas)
        Console.WriteLine("alitas = " & barbacoa.alitas)
        Console.WriteLine("pancetas = " & barbacoa.pancetas)

        Console.ReadLine()
    End Sub
End Module
