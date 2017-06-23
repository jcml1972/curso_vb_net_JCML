Public Interface IConAreaCalculable
    ReadOnly Property Area As Single
    Function CalculaArea() As Single

End Interface

Public Interface IConPerimetroCalculable
    ReadOnly Property Perimetro As Single
    Function CalculaPerimetro() As Single


End Interface

Public Interface ICalculable
    Inherits IConAreaCalculable, IConPerimetroCalculable
End Interface