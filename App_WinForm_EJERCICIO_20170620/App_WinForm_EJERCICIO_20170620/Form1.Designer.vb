<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Principal
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
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.ckbComenzar = New System.Windows.Forms.CheckBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnMostrarMensake = New System.Windows.Forms.Button()
        Me.NumNumero = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUno
        '
        Me.btnUno.Enabled = False
        Me.btnUno.Location = New System.Drawing.Point(31, 133)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(200, 49)
        Me.btnUno.TabIndex = 0
        Me.btnUno.Text = "PRIMER BOTÓN"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Enabled = False
        Me.btnDos.Location = New System.Drawing.Point(32, 193)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(200, 49)
        Me.btnDos.TabIndex = 1
        Me.btnDos.Text = "SEGUNDO BOTÓN"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Enabled = False
        Me.btnTres.Location = New System.Drawing.Point(31, 258)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(200, 49)
        Me.btnTres.TabIndex = 2
        Me.btnTres.Text = "TERCER BOTÓN"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'ckbComenzar
        '
        Me.ckbComenzar.AutoSize = True
        Me.ckbComenzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbComenzar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ckbComenzar.Location = New System.Drawing.Point(34, 94)
        Me.ckbComenzar.Name = "ckbComenzar"
        Me.ckbComenzar.Size = New System.Drawing.Size(246, 28)
        Me.ckbComenzar.TabIndex = 3
        Me.ckbComenzar.Text = "Comienza la secuencia"
        Me.ckbComenzar.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(35, 332)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(39, 13)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "Label1"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(31, 13)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(237, 20)
        Me.txtMensaje.TabIndex = 5
        '
        'btnMostrarMensake
        '
        Me.btnMostrarMensake.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnMostrarMensake.Location = New System.Drawing.Point(332, 10)
        Me.btnMostrarMensake.Name = "btnMostrarMensake"
        Me.btnMostrarMensake.Size = New System.Drawing.Size(120, 25)
        Me.btnMostrarMensake.TabIndex = 6
        Me.btnMostrarMensake.Text = "Mostrar"
        Me.btnMostrarMensake.UseVisualStyleBackColor = True
        '
        'NumNumero
        '
        Me.NumNumero.Hexadecimal = True
        Me.NumNumero.Location = New System.Drawing.Point(34, 54)
        Me.NumNumero.Name = "NumNumero"
        Me.NumNumero.Size = New System.Drawing.Size(144, 20)
        Me.NumNumero.TabIndex = 7
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 384)
        Me.Controls.Add(Me.NumNumero)
        Me.Controls.Add(Me.btnMostrarMensake)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.ckbComenzar)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.btnUno)
        Me.Name = "Ventana_Principal"
        Me.Text = "Ventana Principal"
        CType(Me.NumNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUno As Button
    Friend WithEvents btnDos As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents ckbComenzar As CheckBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnMostrarMensake As Button
    Friend WithEvents NumNumero As NumericUpDown
End Class
