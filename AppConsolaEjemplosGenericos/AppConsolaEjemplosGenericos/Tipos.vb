
Public Structure Empleado
        Public nombre As String
    Public codEmpleado As Integer

    Public Overrides Function tostring() As String
        Return "Empleado " & nombre & " (" & codEmpleado & ")"
    End Function
End Structure

    Public Structure Estudiante
        Public nombre As String
    Public notaFinal As Integer

    Public Overrides Function tostring() As String
        Return "Estudiante " & nombre & " [" & notaFinal & "] "
    End Function
End Structure

