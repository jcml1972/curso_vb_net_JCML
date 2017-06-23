Delegate Sub TipoFuncionCalcular(o1 As Single, o2 As Single)

Module SistemaEventos
    Public Event Evento_RestarConEventos As EventHandler
    Public Event Evento_RestarConsola As EventHandler

    Public Class ObjetoResta
        Public op_1 As Integer
        Public op_2 As Integer
    End Class

    Sub Main()
        'SumarConDelegados(AddressOf Calculadora_1.Sumar)
        'SumarConDelegados(AddressOf Calculadora_2.Sumar)
        'SumarConsola(AddressOf Calculadora_1.Sumar)
        'SumarConsola(AddressOf Calculadora_2.Sumar)

        AddHandler Evento_RestarConEventos, AddressOf Calculadora_1.Restar
        RestarConEventos()
        RemoveHandler Evento_RestarConEventos, AddressOf Calculadora_1.Restar
        AddHandler Evento_RestarConEventos, AddressOf Calculadora_2.Restar
        RestarConEventos()
        RemoveHandler Evento_RestarConEventos, AddressOf Calculadora_2.Restar
        AddHandler Evento_RestarConsola, AddressOf Calculadora_1.Restar
        RestarConsola()
        RemoveHandler Evento_RestarConsola, AddressOf Calculadora_1.Restar
        AddHandler Evento_RestarConsola, AddressOf Calculadora_2.Restar
        RestarConsola()
        RemoveHandler Evento_RestarConsola, AddressOf Calculadora_2.Restar
    End Sub
    Sub SumarConDelegados(funSumar As TipoFuncionCalcular)
        Dim op_1 As Single = 10.2
        Dim op_2 As Single = 10.3
        ' DATOS OBTENIDOS
        funSumar(op_1, op_2)
    End Sub
    Sub SumarConsola(funSumar As TipoFuncionCalcular)
        Dim op_1 = Console.ReadLine()
        Dim op_2 = Console.ReadLine()

        ' DATOS OBTENIDOS
        funSumar(Integer.Parse(op_1), Integer.Parse(op_2))
    End Sub
    Sub RestarConEventos()
        Dim op As ObjetoResta
        op = New ObjetoResta() With {.op_1 = 10, .op_2 = 7}

        ' DATOS OBTENIDOS
        RaiseEvent Evento_RestarConEventos(op, New EventArgs)
    End Sub
    Sub RestarConsola()
        Dim op_1 = Console.ReadLine()
        Dim op_2 = Console.ReadLine()

        Dim op As ObjetoResta
        op = New ObjetoResta() With {.op_1 = Integer.Parse(op_1), .op_2 = Integer.Parse(op_2)}

        ' DATOS OBTENIDOS
        RaiseEvent Evento_RestarConsola(op, New EventArgs)
    End Sub
End Module
