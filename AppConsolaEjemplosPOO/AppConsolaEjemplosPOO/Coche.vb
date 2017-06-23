Partial Public Class Coche
    Inherits Vehiculo
    'Variables compartidas o estáticas
    Public Shared numeroCoches As Integer

    ' Variables miembro o de instancia
    Protected _puertas As Integer
    Protected _ruedas(3) As Integer  ' 0 % al 100 %

    Public Shared ReadOnly Property NumRuedas = 4
    Public Shared Sub LavarCoche(coche As Coche)
        Console.WriteLine("Lavadero coche: " & coche._modelo &
                          " está limpio")
    End Sub

    Public Function Ruedas() As Integer()
        Return _ruedas
    End Function
    Public ReadOnly Property RuedasP(numRueda As Integer)
        Get
            Return _ruedas(numRueda)
        End Get
    End Property

    ' Propiedades:
    Property Puertas() As Integer
        Get
            If _puertas > 0 Then
                Return _puertas
            Else
                Console.WriteLine(_modelo & ": No hay puertas!")
                Return 0
            End If
        End Get
        Set(value As Integer)
            If value > 0 And value Mod 2 = 0 Then
                _puertas = value
            Else
                Console.WriteLine(_modelo & ": No hay puertas que asignar!")
            End If
        End Set
    End Property
    Public Overrides Function tostring() As String
        Dim texto = "Coche " & Me._modelo &
            " con " & Me._kilometraje & " km, " &
            _carburante & " % de carburante"
        Return texto
    End Function

    Public Function Es4x4() As Boolean
        Return transmision.delantera And transmision.trasera
    End Function

    Public Sub Acelerar()
        MyBase.Acelerar()
        Console.WriteLine("Pisando el acelerador del COCHE")
    End Sub

    Public Overrides Sub Acelerar_Overrides()
        Console.WriteLine("Pisando el acelerador del COCHE con Overrides")
    End Sub

    Public Shadows Sub Acelerar_Shadows()
        Console.WriteLine("Pisando el acelerador del COCHE con Shadows")
    End Sub

    Public Overrides Sub Frenar_Overrides()
        Console.WriteLine("Frenando el COCHE con Overrides")
    End Sub
End Class
