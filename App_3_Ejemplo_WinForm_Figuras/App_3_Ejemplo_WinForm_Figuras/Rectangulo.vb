Public Class Rectangulo
    Inherits Figura

    Public alto As Single
    Public ancho As Single



    Public Sub New(alto As Single, ancho As Single)
        Me.alto = alto
        Me.ancho = ancho
    End Sub
    Public Overrides Function CalculaArea() As Single
        _Area = alto * ancho
        Return _Area
    End Function
    Public Overrides Function CalculaPerimetro() As Single
        _Perimetro = alto * 2 + ancho * 2
        Return _Perimetro
    End Function
    Public Overrides Sub Mostrar()
        Console.WriteLine("Ancho:     " & ancho & ", Alto:      " & alto)
        Console.WriteLine("Area:      " & CalculaArea())
        Console.WriteLine("Perimetro: " & CalculaPerimetro())
    End Sub
End Class
