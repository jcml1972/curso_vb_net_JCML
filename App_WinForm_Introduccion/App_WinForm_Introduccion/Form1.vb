Public Class VentanaPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHolaMundo.Click, BtnTercerBoton.Click, BtnOtroBotón.Click

        If (sender.GetType().ToString() = "System.Windows.Forms.Button") Then
            Dim botonPulsado As Button
            botonPulsado = CType(sender, Button)
            lblEtiqueta.Text = "Has pulsado " & botonPulsado.Name &
                            vbCrLf & "Con el texto " & botonPulsado.Text

        Else
            lblEtiqueta.Text = "Ey! Hola Mundo mundial!" & vbCrLf & sender.GetType().ToString()
        End If
    End Sub

    Private Sub AlPulsarUnBoton(sender As Object, e As EventArgs) ' Handles BtnHolaMundo.Click, BtnOtroBotón.Click
        MessageBox.Show("Controlador AlPulsarUnBotón() desde " & sender.name)
    End Sub

    Private Sub AlSalirDelBoton(sender As Object, e As EventArgs)
        MessageBox.Show("3 - Controlador AlSalirDelBotón() desde " & sender.name)
    End Sub

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnHolaMundo.Text = "¡¡¡¡PÚLSAME YA!!!!"
        AddHandler BtnHolaMundo.Click, AddressOf AlPulsarUnBoton
        AddHandler BtnOtroBotón.Click, AddressOf AlPulsarUnBoton
        AddHandler BtnHolaMundo.Leave, AddressOf AlSalirDelBoton
        AddHandler BtnOtroBotón.Leave, AddressOf AlSalirDelBoton
        AddHandler BtnTercerBoton.Leave, AddressOf AlSalirDelBoton



    End Sub
End Class
