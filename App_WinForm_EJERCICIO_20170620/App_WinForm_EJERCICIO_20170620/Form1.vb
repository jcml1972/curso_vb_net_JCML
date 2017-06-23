Public Class Ventana_Principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblInfo.Text = My.Application.Culture.ToString()
        lblInfo.Text += vbCrLf & My.Application.Info.Title &
            vbCrLf & My.Application.Info.Version.ToString()
        lblInfo.Text += vbCrLf & My.Computer.Clock.LocalTime.ToString()
        lblInfo.Text += vbCrLf & My.User.Name.ToString
        lblInfo.Text += vbCrLf & My.Forms.Ventana_Principal.Name



    End Sub

    Public Sub AlPulsarPrimerBotón(sender As Button, e As EventArgs)

        btnDos.Enabled = True
        MessageBox.Show("ACABAS DE ACTIVAR EL SEGUNDO BOTÓN, PÚLSALO")
        AddHandler btnDos.Click, AddressOf AlPulsarSegundoBotón

        Dim controlAlPulsar As EventHandler
        controlAlPulsar = AddressOf AlPulsarPrimerBotón
        RemoveHandler btnUno.Click, controlAlPulsar
        AddHandler btnUno.Click, AddressOf AlHaberseActivado

    End Sub

    Public Sub AlPulsarSegundoBotón(sender As Button, e As EventArgs)

        btnTres.Enabled = True
        MessageBox.Show("ACABAS DE ACTIVAR EL TERCER BOTÓN, PÚLSALO")

        AddHandler btnTres.Click, AddressOf AlPulsarTercerBotón

        Dim controlAlPulsar As EventHandler
        controlAlPulsar = AddressOf AlPulsarSegundoBotón
        RemoveHandler btnDos.Click, controlAlPulsar
        AddHandler btnDos.Click, AddressOf AlHaberseActivado

    End Sub

    Public Sub AlPulsarTercerBotón(sender As Button, e As EventArgs)

        MessageBox.Show("EL EJERCICIO HA TERMINADO")

        Dim controlAlPulsar As EventHandler
        controlAlPulsar = AddressOf AlPulsarTercerBotón
        RemoveHandler btnTres.Click, controlAlPulsar
        AddHandler btnTres.Click, AddressOf AlHaberseActivado


    End Sub

    Private Sub ckbComenzar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbComenzar.CheckedChanged
        If (ckbComenzar.Checked) Then

            btnUno.Enabled = True
            AddHandler btnUno.Click, AddressOf AlPulsarPrimerBotón

        End If
    End Sub

    Public Sub AlHaberseActivado(sender As Button, es As EventArgs)

        MessageBox.Show("ES LA SEGUNDA VEZ QUE PULSAS, YA NO HACE NADA")

    End Sub

    Private Sub btnMostrarMensake_Click(sender As Object, e As EventArgs) Handles btnMostrarMensake.Click
        MessageBox.Show(txtMensaje.Text & ", " & NumNumero.Value)
    End Sub
End Class
