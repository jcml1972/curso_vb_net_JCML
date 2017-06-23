<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculoFiguras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadCirculo = New System.Windows.Forms.RadioButton()
        Me.RadRectangulo = New System.Windows.Forms.RadioButton()
        Me.GrupoRectangulo = New System.Windows.Forms.GroupBox()
        Me.numPerimetroRectangulo = New System.Windows.Forms.NumericUpDown()
        Me.PerimetroRectangulo = New System.Windows.Forms.Label()
        Me.numArea = New System.Windows.Forms.NumericUpDown()
        Me.numAlto = New System.Windows.Forms.NumericUpDown()
        Me.numAncho = New System.Windows.Forms.NumericUpDown()
        Me.AreaRectangulo = New System.Windows.Forms.Label()
        Me.AltoRectangulo = New System.Windows.Forms.Label()
        Me.AnchoRectangulo = New System.Windows.Forms.Label()
        Me.GrupoCirculo = New System.Windows.Forms.GroupBox()
        Me.numPerimetroCirculo = New System.Windows.Forms.NumericUpDown()
        Me.PerimetroCirculo = New System.Windows.Forms.Label()
        Me.numAreaCirculo = New System.Windows.Forms.NumericUpDown()
        Me.numRadioCirculo = New System.Windows.Forms.NumericUpDown()
        Me.AreaCirculo = New System.Windows.Forms.Label()
        Me.RadioCirculo = New System.Windows.Forms.Label()
        Me.GrupoResultado = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GrupoRectangulo.SuspendLayout()
        CType(Me.numPerimetroRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAlto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoCirculo.SuspendLayout()
        CType(Me.numPerimetroCirculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAreaCirculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRadioCirculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadCirculo)
        Me.GroupBox1.Controls.Add(Me.RadRectangulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una figura"
        '
        'RadCirculo
        '
        Me.RadCirculo.AutoSize = True
        Me.RadCirculo.Location = New System.Drawing.Point(15, 70)
        Me.RadCirculo.Name = "RadCirculo"
        Me.RadCirculo.Size = New System.Drawing.Size(91, 24)
        Me.RadCirculo.TabIndex = 1
        Me.RadCirculo.TabStop = True
        Me.RadCirculo.Text = "Círculos"
        Me.RadCirculo.UseVisualStyleBackColor = True
        '
        'RadRectangulo
        '
        Me.RadRectangulo.AutoSize = True
        Me.RadRectangulo.Location = New System.Drawing.Point(15, 30)
        Me.RadRectangulo.Name = "RadRectangulo"
        Me.RadRectangulo.Size = New System.Drawing.Size(128, 24)
        Me.RadRectangulo.TabIndex = 0
        Me.RadRectangulo.TabStop = True
        Me.RadRectangulo.Text = "Rectángulos"
        Me.RadRectangulo.UseVisualStyleBackColor = True
        '
        'GrupoRectangulo
        '
        Me.GrupoRectangulo.Controls.Add(Me.numPerimetroRectangulo)
        Me.GrupoRectangulo.Controls.Add(Me.PerimetroRectangulo)
        Me.GrupoRectangulo.Controls.Add(Me.numArea)
        Me.GrupoRectangulo.Controls.Add(Me.numAlto)
        Me.GrupoRectangulo.Controls.Add(Me.numAncho)
        Me.GrupoRectangulo.Controls.Add(Me.AreaRectangulo)
        Me.GrupoRectangulo.Controls.Add(Me.AltoRectangulo)
        Me.GrupoRectangulo.Controls.Add(Me.AnchoRectangulo)
        Me.GrupoRectangulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoRectangulo.Location = New System.Drawing.Point(112, 161)
        Me.GrupoRectangulo.Name = "GrupoRectangulo"
        Me.GrupoRectangulo.Size = New System.Drawing.Size(267, 181)
        Me.GrupoRectangulo.TabIndex = 1
        Me.GrupoRectangulo.TabStop = False
        Me.GrupoRectangulo.Text = "Rectángulo"
        '
        'numPerimetroRectangulo
        '
        Me.numPerimetroRectangulo.DecimalPlaces = 2
        Me.numPerimetroRectangulo.Location = New System.Drawing.Point(127, 137)
        Me.numPerimetroRectangulo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numPerimetroRectangulo.Name = "numPerimetroRectangulo"
        Me.numPerimetroRectangulo.ReadOnly = True
        Me.numPerimetroRectangulo.Size = New System.Drawing.Size(105, 26)
        Me.numPerimetroRectangulo.TabIndex = 7
        '
        'PerimetroRectangulo
        '
        Me.PerimetroRectangulo.AutoSize = True
        Me.PerimetroRectangulo.Location = New System.Drawing.Point(20, 143)
        Me.PerimetroRectangulo.Name = "PerimetroRectangulo"
        Me.PerimetroRectangulo.Size = New System.Drawing.Size(86, 20)
        Me.PerimetroRectangulo.TabIndex = 6
        Me.PerimetroRectangulo.Text = "Perímetro"
        '
        'numArea
        '
        Me.numArea.DecimalPlaces = 2
        Me.numArea.Location = New System.Drawing.Point(127, 104)
        Me.numArea.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numArea.Name = "numArea"
        Me.numArea.ReadOnly = True
        Me.numArea.Size = New System.Drawing.Size(105, 26)
        Me.numArea.TabIndex = 5
        '
        'numAlto
        '
        Me.numAlto.DecimalPlaces = 2
        Me.numAlto.Location = New System.Drawing.Point(127, 69)
        Me.numAlto.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numAlto.Name = "numAlto"
        Me.numAlto.Size = New System.Drawing.Size(105, 26)
        Me.numAlto.TabIndex = 4
        '
        'numAncho
        '
        Me.numAncho.DecimalPlaces = 2
        Me.numAncho.Location = New System.Drawing.Point(127, 33)
        Me.numAncho.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numAncho.Name = "numAncho"
        Me.numAncho.Size = New System.Drawing.Size(105, 26)
        Me.numAncho.TabIndex = 3
        '
        'AreaRectangulo
        '
        Me.AreaRectangulo.AutoSize = True
        Me.AreaRectangulo.Location = New System.Drawing.Point(20, 110)
        Me.AreaRectangulo.Name = "AreaRectangulo"
        Me.AreaRectangulo.Size = New System.Drawing.Size(47, 20)
        Me.AreaRectangulo.TabIndex = 2
        Me.AreaRectangulo.Text = "Área"
        '
        'AltoRectangulo
        '
        Me.AltoRectangulo.AutoSize = True
        Me.AltoRectangulo.Location = New System.Drawing.Point(20, 75)
        Me.AltoRectangulo.Name = "AltoRectangulo"
        Me.AltoRectangulo.Size = New System.Drawing.Size(41, 20)
        Me.AltoRectangulo.TabIndex = 1
        Me.AltoRectangulo.Text = "Alto"
        '
        'AnchoRectangulo
        '
        Me.AnchoRectangulo.AutoSize = True
        Me.AnchoRectangulo.Location = New System.Drawing.Point(19, 39)
        Me.AnchoRectangulo.Name = "AnchoRectangulo"
        Me.AnchoRectangulo.Size = New System.Drawing.Size(60, 20)
        Me.AnchoRectangulo.TabIndex = 0
        Me.AnchoRectangulo.Text = "Ancho"
        '
        'GrupoCirculo
        '
        Me.GrupoCirculo.Controls.Add(Me.numPerimetroCirculo)
        Me.GrupoCirculo.Controls.Add(Me.PerimetroCirculo)
        Me.GrupoCirculo.Controls.Add(Me.numAreaCirculo)
        Me.GrupoCirculo.Controls.Add(Me.numRadioCirculo)
        Me.GrupoCirculo.Controls.Add(Me.AreaCirculo)
        Me.GrupoCirculo.Controls.Add(Me.RadioCirculo)
        Me.GrupoCirculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoCirculo.Location = New System.Drawing.Point(112, 158)
        Me.GrupoCirculo.Name = "GrupoCirculo"
        Me.GrupoCirculo.Size = New System.Drawing.Size(267, 181)
        Me.GrupoCirculo.TabIndex = 9
        Me.GrupoCirculo.TabStop = False
        Me.GrupoCirculo.Text = "Círculo"
        Me.GrupoCirculo.Visible = False
        '
        'numPerimetroCirculo
        '
        Me.numPerimetroCirculo.DecimalPlaces = 2
        Me.numPerimetroCirculo.Location = New System.Drawing.Point(136, 110)
        Me.numPerimetroCirculo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numPerimetroCirculo.Name = "numPerimetroCirculo"
        Me.numPerimetroCirculo.ReadOnly = True
        Me.numPerimetroCirculo.Size = New System.Drawing.Size(105, 26)
        Me.numPerimetroCirculo.TabIndex = 7
        '
        'PerimetroCirculo
        '
        Me.PerimetroCirculo.AutoSize = True
        Me.PerimetroCirculo.Location = New System.Drawing.Point(29, 116)
        Me.PerimetroCirculo.Name = "PerimetroCirculo"
        Me.PerimetroCirculo.Size = New System.Drawing.Size(86, 20)
        Me.PerimetroCirculo.TabIndex = 6
        Me.PerimetroCirculo.Text = "Perímetro"
        '
        'numAreaCirculo
        '
        Me.numAreaCirculo.DecimalPlaces = 2
        Me.numAreaCirculo.Location = New System.Drawing.Point(136, 77)
        Me.numAreaCirculo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numAreaCirculo.Name = "numAreaCirculo"
        Me.numAreaCirculo.ReadOnly = True
        Me.numAreaCirculo.Size = New System.Drawing.Size(105, 26)
        Me.numAreaCirculo.TabIndex = 5
        '
        'numRadioCirculo
        '
        Me.numRadioCirculo.DecimalPlaces = 2
        Me.numRadioCirculo.Location = New System.Drawing.Point(136, 42)
        Me.numRadioCirculo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numRadioCirculo.Name = "numRadioCirculo"
        Me.numRadioCirculo.Size = New System.Drawing.Size(105, 26)
        Me.numRadioCirculo.TabIndex = 4
        '
        'AreaCirculo
        '
        Me.AreaCirculo.AutoSize = True
        Me.AreaCirculo.Location = New System.Drawing.Point(29, 83)
        Me.AreaCirculo.Name = "AreaCirculo"
        Me.AreaCirculo.Size = New System.Drawing.Size(47, 20)
        Me.AreaCirculo.TabIndex = 2
        Me.AreaCirculo.Text = "Área"
        '
        'RadioCirculo
        '
        Me.RadioCirculo.AutoSize = True
        Me.RadioCirculo.Location = New System.Drawing.Point(29, 48)
        Me.RadioCirculo.Name = "RadioCirculo"
        Me.RadioCirculo.Size = New System.Drawing.Size(56, 20)
        Me.RadioCirculo.TabIndex = 1
        Me.RadioCirculo.Text = "Radio"
        '
        'GrupoResultado
        '
        Me.GrupoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoResultado.Location = New System.Drawing.Point(115, 371)
        Me.GrupoResultado.Name = "GrupoResultado"
        Me.GrupoResultado.Size = New System.Drawing.Size(257, 116)
        Me.GrupoResultado.TabIndex = 10
        Me.GrupoResultado.TabStop = False
        Me.GrupoResultado.Text = "RESULTADOS"
        '
        'FormCalculoFiguras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 547)
        Me.Controls.Add(Me.GrupoResultado)
        Me.Controls.Add(Me.GrupoCirculo)
        Me.Controls.Add(Me.GrupoRectangulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCalculoFiguras"
        Me.Text = "Cálculo Áreas y Perímetros de Figuras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrupoRectangulo.ResumeLayout(False)
        Me.GrupoRectangulo.PerformLayout()
        CType(Me.numPerimetroRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAlto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAncho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoCirculo.ResumeLayout(False)
        Me.GrupoCirculo.PerformLayout()
        CType(Me.numPerimetroCirculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAreaCirculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRadioCirculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadCirculo As RadioButton
    Friend WithEvents RadRectangulo As RadioButton
    Friend WithEvents GrupoRectangulo As GroupBox
    Friend WithEvents numArea As NumericUpDown
    Friend WithEvents numAlto As NumericUpDown
    Friend WithEvents numAncho As NumericUpDown
    Friend WithEvents AreaRectangulo As Label
    Friend WithEvents AltoRectangulo As Label
    Friend WithEvents AnchoRectangulo As Label
    Friend WithEvents numPerimetroRectangulo As NumericUpDown
    Friend WithEvents PerimetroRectangulo As Label
    Friend WithEvents GrupoCirculo As GroupBox
    Friend WithEvents numPerimetroCirculo As NumericUpDown
    Friend WithEvents PerimetroCirculo As Label
    Friend WithEvents numAreaCirculo As NumericUpDown
    Friend WithEvents numRadioCirculo As NumericUpDown
    Friend WithEvents AreaCirculo As Label
    Friend WithEvents RadioCirculo As Label
    Friend WithEvents GrupoResultado As GroupBox
End Class
