<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnHolaMundo = New System.Windows.Forms.Button()
        Me.BtnOtroBotón = New System.Windows.Forms.Button()
        Me.BtnTercerBoton = New System.Windows.Forms.Button()
        Me.lblEtiqueta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHolaMundo
        '
        Me.BtnHolaMundo.Location = New System.Drawing.Point(51, 42)
        Me.BtnHolaMundo.Name = "BtnHolaMundo"
        Me.BtnHolaMundo.Size = New System.Drawing.Size(239, 75)
        Me.BtnHolaMundo.TabIndex = 0
        Me.BtnHolaMundo.Text = "PÚLSAME POR FAVOR"
        Me.BtnHolaMundo.UseVisualStyleBackColor = True
        '
        'BtnOtroBotón
        '
        Me.BtnOtroBotón.Location = New System.Drawing.Point(51, 148)
        Me.BtnOtroBotón.Name = "BtnOtroBotón"
        Me.BtnOtroBotón.Size = New System.Drawing.Size(239, 75)
        Me.BtnOtroBotón.TabIndex = 1
        Me.BtnOtroBotón.Text = "Otro botón"
        Me.BtnOtroBotón.UseVisualStyleBackColor = True
        '
        'BtnTercerBoton
        '
        Me.BtnTercerBoton.Location = New System.Drawing.Point(51, 256)
        Me.BtnTercerBoton.Name = "BtnTercerBoton"
        Me.BtnTercerBoton.Size = New System.Drawing.Size(239, 75)
        Me.BtnTercerBoton.TabIndex = 2
        Me.BtnTercerBoton.Text = "Tercer Botón"
        Me.BtnTercerBoton.UseVisualStyleBackColor = True
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.AutoSize = True
        Me.lblEtiqueta.Location = New System.Drawing.Point(402, 57)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(39, 13)
        Me.lblEtiqueta.TabIndex = 3
        Me.lblEtiqueta.Text = "Label1"
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 415)
        Me.Controls.Add(Me.lblEtiqueta)
        Me.Controls.Add(Me.BtnTercerBoton)
        Me.Controls.Add(Me.BtnOtroBotón)
        Me.Controls.Add(Me.BtnHolaMundo)
        Me.Name = "VentanaPrincipal"
        Me.Text = "Ventana Principal de la App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHolaMundo As Button
    Friend WithEvents BtnOtroBotón As Button
    Friend WithEvents BtnTercerBoton As Button
    Friend WithEvents lblEtiqueta As Label
End Class
