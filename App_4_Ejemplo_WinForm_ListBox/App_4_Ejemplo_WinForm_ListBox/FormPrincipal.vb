Public Class FormPrincipal

    Private nuevoFormComboListas As FormComboListas

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevoFormComboListas = New FormComboListas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMostrarLongitud.Click
        Dim esteBoton As Button = CType(sender, Button)
        esteBoton.Location = New Point(esteBoton.Location.X + 20, esteBoton.Location.Y)
        MessageBox.Show("Longitud de texto multilínea: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf &
                         "longitud de texto 2: " & txtDiezCaracteres.TextLength.ToString())
    End Sub

    Private Sub TextBox1y2_TextChanged(sender As Object, e As EventArgs) Handles txtMultilinea.TextChanged, txtDiezCaracteres.TextChanged

        lblLongitudes.Text = "Longitud de texto multilínea: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf &
                         "longitud de texto 2: " & txtDiezCaracteres.TextLength.ToString()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstListaDatos.Items.Add(txtMultilinea.Text)
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        lstListaDatos.Items.Add(txtDiezCaracteres.Text)
        txtDiezCaracteres.Clear()
    End Sub

    Private Sub btnEliminardelaLista_Click(sender As Object, e As EventArgs) Handles btnElminardelaLista.Click
        lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex)
    End Sub

    Private Sub lstListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListaDatos.SelectedIndexChanged
        If lstListaDatos.Items.Count = 0 Then
            btnElminardelaLista.Enabled = False
        ElseIf lstListaDatos.Items.Count > 0 Then
            btnElminardelaLista.Enabled = True
        End If
    End Sub

    Private Sub btnAbrirForm_Click(sender As Object, e As EventArgs) Handles btnAbrirForm.Click
        If nuevoFormComboListas Is Nothing Or nuevoFormComboListas.IsDisposed Then
            nuevoFormComboListas = New FormComboListas()
        End If
        nuevoFormComboListas.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        nuevoFormComboListas.Hide()
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Dim tipoFuente As Integer
        tipoFuente = System.Drawing.FontStyle.Italic + System.Drawing.FontStyle.Underline
        Me.lblLongitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, tipoFuente,
                                                        System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        ' modifica tamaño de txtMultilínea
        Dim tamañoTxtMult As Size = Me.txtMultilinea.Size
        tamañoTxtMult.Height += -10
        Me.txtMultilinea.Size = tamañoTxtMult
        ' mover a la derecha el botón pulsado
        Dim esteBoton As Button = CType(sender, Button)
        esteBoton.Location = New Point(esteBoton.Location.X + 20, esteBoton.Location.Y)

        ' Poner btnAbrirFomr a la izquierda del botón cerrar

        btnAbrirForm.Location = New Point(btnCerrar.Location.X - btnAbrirForm.Size.Width - 10,
                                          btnCerrar.Location.Y)
        ' cambiar propiedades el propio formulario
        Me.Text = "Nueva Ventana"
        Me.BackColor = Color.BurlyWood
        Me.BackColor = Color.FromArgb(255, 255, 255, 0) ' 32 bits. 8bits por color, 1 byte por color

        lstListaDatos.SetBounds(417, 45, 245, 485)
        'lstListaDatos.BringToFront()
        Label4.SendToBack()


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As Date = DateTimePicker1.Value

        fecha = fecha.AddDays(1)
        fecha.ToShortTimeString()
        Me.Text = "Ventana: " & fecha
        If fecha.Year = 2017 Then
            Me.Text += vbCr & "¡Este mismo año!"
        End If

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim nuevoBoton As Button
        nuevoBoton = New Button()
        nuevoBoton.Size = New Size(200, 200)
        nuevoBoton.Location = New Point(100, 100)
        nuevoBoton.Text = "Pulsa para eliminar"
        nuevoBoton.Parent = Me
        nuevoBoton.BringToFront()
        AddHandler nuevoBoton.Click, AddressOf EliminarComponente

    End Sub

    Private Sub EliminarComponente(sender As Button, e As EventArgs)
        sender.Dispose()
    End Sub
End Class
