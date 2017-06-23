Imports AppConsolaEjemplosPOO_2

Public Class Tetrabrik

    Implements IConAreaCalculable

    Public ancho, alto, prof As Single

    Public Sub New(an As Single, al As Single, pr As Single)
        Me.ancho = an
        Me.alto = al
        Me.prof = pr
    End Sub

    Public ReadOnly Property Area As Single Implements IConAreaCalculable.Area
        Get
            Return CalculaArea()
        End Get
    End Property

    Public Function CalculaArea() As Single Implements IConAreaCalculable.CalculaArea
        Return Me.ancho * Me.alto * 2 + Me.prof * Me.alto * 2 + Me.prof * Me.ancho * 2
    End Function
End Class
