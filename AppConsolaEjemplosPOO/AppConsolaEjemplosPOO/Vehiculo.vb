Public Class Vehiculo
    'Variables compartidas o estáticas
    Public Shared kmGlobales As Integer

    ' Variables miembro o de instancia
    Protected _kilometraje As Integer
    Protected _modelo As String
    Protected _carburante As Single ' 0 % al 100 %

    ' Metodos estaticos
    Public Shared Sub LavarVehiculo(vehiculo As Vehiculo)
        Console.WriteLine("Lavadero Vehiculo: " & vehiculo._modelo &
                          " está limpio")
    End Sub

    ' Propiedades:
    Public Property Color() As String = "Negro"
    ' Carburante
    Public ReadOnly Property Carburante() As Single
        Get
            Return _carburante
        End Get
    End Property
    Public Sub LlenarDeposito()
        _carburante = 100
    End Sub

    ' Metodo de acceso a variables de solo lectura
    Public Function DameKm()
        Return _kilometraje
    End Function
    Public Function DameModelo()
        Return _modelo
    End Function

    ' Metodos de la clase Coche
    Public Sub EsteblecerModelo(modelo As String)
        If modelo <> "" Then
            Me._modelo = modelo
        Else
            Console.WriteLine("Modelo no puede ser vacio")
        End If
    End Sub
    ' Crear subrutina que sea aunmentar 
    ' un KM y hacer privado el kilometraje
    Public Function RecorrerUnKM()
        _kilometraje = _kilometraje + 1
        _carburante = _carburante - 0.25
        kmGlobales = kmGlobales + 1
        Return _kilometraje
    End Function
    ' NuevO método para recorrer KM de ESTE coche
    Public Sub RecorrerKM(km As Integer)
        For km = 1 To km
            RecorrerUnKM()
        Next
    End Sub
    Public Overrides Function ToString() As String
        Return "Vehiculo " & Me._modelo &
            " con " & Me._kilometraje & " km, " &
            _carburante & " % de carburante"
    End Function

    Public Sub Acelerar()
        Console.WriteLine("Acelerando VEHÍCULO")

    End Sub
    Public Overridable Sub Acelerar_Overrides()
        Console.WriteLine("Acelerando VEHÍCULO con Overrides")
    End Sub

    Public Sub Acelerar_Shadows()
        Console.WriteLine("Acelerando VEHÍCULO con Shadows")
    End Sub

    Public Overridable Sub Frenar_Overrides()
        Console.WriteLine("Frenando VEHÍCULO con Overrides")
    End Sub

End Class
