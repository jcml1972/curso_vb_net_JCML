Imports AppConsolaEjemplosPOO_2

Public MustInherit Class Figura

    Implements ICalculable

    'Public Delegate Sub funcionAviso(numero As Integer)


    Protected _Area As Single
    Protected _Perimetro As Single
    Public ReadOnly Property Area As Single Implements ICalculable.Area
        Get
            Return _Area
        End Get
    End Property

    Public ReadOnly Property Perimetro As Single Implements ICalculable.Perimetro
        Get
            Return _Perimetro
        End Get
    End Property

    Public MustOverride Function CalculaArea() As Single Implements ICalculable.CalculaArea

    Public MustOverride Function CalculaPerimetro() As Single Implements ICalculable.CalculaPerimetro

    Public Overridable Sub Mostrar()
        Console.WriteLine("Mostrando figura")
    End Sub

    'Public Sub AvisameCuandoPerimetro(funAviso As FuncionAviso)
    '    funAviso = funAviso
    'End Sub

End Class
