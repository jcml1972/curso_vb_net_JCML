<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOperando1 = New System.Windows.Forms.TextBox()
        Me.txtOperando2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.numOperando1 = New System.Windows.Forms.NumericUpDown()
        Me.numOperando2 = New System.Windows.Forms.NumericUpDown()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        CType(Me.numOperando1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOperando2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOperando1
        '
        Me.txtOperando1.Location = New System.Drawing.Point(12, 31)
        Me.txtOperando1.Name = "txtOperando1"
        Me.txtOperando1.Size = New System.Drawing.Size(102, 20)
        Me.txtOperando1.TabIndex = 0
        Me.txtOperando1.Text = "0"
        '
        'txtOperando2
        '
        Me.txtOperando2.Location = New System.Drawing.Point(120, 31)
        Me.txtOperando2.Name = "txtOperando2"
        Me.txtOperando2.Size = New System.Drawing.Size(106, 20)
        Me.txtOperando2.TabIndex = 1
        Me.txtOperando2.Text = "0"
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(14, 69)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(40, 28)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.Location = New System.Drawing.Point(65, 69)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(40, 28)
        Me.btnRestar.TabIndex = 3
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(130, 69)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(40, 28)
        Me.btnMultiplicar.TabIndex = 4
        Me.btnMultiplicar.Text = "X"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(177, 69)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(40, 28)
        Me.btnDividir.TabIndex = 5
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'numOperando1
        '
        Me.numOperando1.Location = New System.Drawing.Point(12, 5)
        Me.numOperando1.Name = "numOperando1"
        Me.numOperando1.Size = New System.Drawing.Size(102, 20)
        Me.numOperando1.TabIndex = 6
        '
        'numOperando2
        '
        Me.numOperando2.Location = New System.Drawing.Point(120, 5)
        Me.numOperando2.Name = "numOperando2"
        Me.numOperando2.Size = New System.Drawing.Size(106, 20)
        Me.numOperando2.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(14, 152)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(109, 24)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Resultado:"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(19, 184)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(21, 24)
        Me.lblResultado.TabIndex = 9
        Me.lblResultado.Text = "0"
        Me.lblResultado.UseMnemonic = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.numOperando2)
        Me.Controls.Add(Me.numOperando1)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtOperando2)
        Me.Controls.Add(Me.txtOperando1)
        Me.Name = "Form1"
        Me.Text = "CalculadoraV1"
        CType(Me.numOperando1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOperando2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperando1 As TextBox
    Friend WithEvents txtOperando2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents numOperando1 As NumericUpDown
    Friend WithEvents numOperando2 As NumericUpDown
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblResultado As Label
End Class
