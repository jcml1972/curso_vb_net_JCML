Public Class Objetivo

    Public descripcion As String
    Public peso As Single ' Porcentaje sobre la valoración
    Public consecucion As Single ' Porcentaje de lo conseguido sobre el valor

    Public Function DameResultado() As Single

        Return peso * consecucion

    End Function

    Public Overrides Function ToString() As String

        Return "Objetivo " & descripcion &
        ", peso =" & peso &
        ", consecucion =" & consecucion &
        ", resultado =" & DameResultado()

    End Function

End Class
