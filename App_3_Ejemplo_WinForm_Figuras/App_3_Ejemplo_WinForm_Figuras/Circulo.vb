Public Class Circulo
    Inherits Figura

    Public Delegate Sub CuandoSeCalculaArea(texto As String)


    Public radio As Single
    Private funCuandoSeCalArea As CuandoSeCalculaArea


    Public Sub New(radio As Single, funCSCA As CuandoSeCalculaArea)
        Me.radio = radio
        Me.funCuandoSeCalArea = funCSCA
    End Sub



    Public Overrides Function CalculaArea() As Single
        _Area = CSng(radio * radio * Math.PI)
        If funCuandoSeCalArea <> Nothing Then
            Me.funCuandoSeCalArea("UN CIRCULO")
        End If
        Return _Area
    End Function
    Public Overrides Function CalculaPerimetro() As Single
        _Perimetro = radio * 2 * CSng(Math.PI)
        Return _Perimetro
    End Function
    Public Overrides Sub Mostrar()
        Console.WriteLine("Radio:     " & radio)
        Console.WriteLine("Area:      " & CalculaArea())
        Console.WriteLine("Perimetro: " & CalculaPerimetro())
    End Sub


End Class
