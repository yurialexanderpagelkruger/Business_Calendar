<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        labelMes = New Label()
        comboMes = New ComboBox()
        textBoxAño = New TextBox()
        panelDias = New Panel()
        btnAnterior = New Button()
        btnSiguiente = New Button()
        btnIr = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' labelMes
        ' 
        labelMes.AutoSize = True
        labelMes.BackColor = Color.Transparent
        labelMes.Font = New Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelMes.Location = New Point(447, 168)
        labelMes.Name = "labelMes"
        labelMes.Size = New Size(131, 35)
        labelMes.TabIndex = 0
        labelMes.Text = "Mes y Año"
        ' 
        ' comboMes
        ' 
        comboMes.BackColor = SystemColors.ControlLight
        comboMes.Font = New Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        comboMes.FormattingEnabled = True
        comboMes.Location = New Point(294, 123)
        comboMes.Name = "comboMes"
        comboMes.Size = New Size(121, 31)
        comboMes.TabIndex = 1
        ' 
        ' textBoxAño
        ' 
        textBoxAño.BackColor = SystemColors.ControlLight
        textBoxAño.Font = New Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        textBoxAño.Location = New Point(542, 123)
        textBoxAño.Name = "textBoxAño"
        textBoxAño.Size = New Size(48, 28)
        textBoxAño.TabIndex = 2
        ' 
        ' panelDias
        ' 
        panelDias.BackColor = Color.Transparent
        panelDias.Location = New Point(227, 221)
        panelDias.Name = "panelDias"
        panelDias.Size = New Size(581, 218)
        panelDias.TabIndex = 3
        ' 
        ' btnAnterior
        ' 
        btnAnterior.BackColor = SystemColors.ControlLightLight
        btnAnterior.Font = New Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAnterior.Location = New Point(227, 171)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(120, 32)
        btnAnterior.TabIndex = 4
        btnAnterior.Text = "Anterior"
        btnAnterior.UseVisualStyleBackColor = False
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.BackColor = SystemColors.ControlLightLight
        btnSiguiente.Font = New Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSiguiente.Location = New Point(687, 167)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(121, 32)
        btnSiguiente.TabIndex = 5
        btnSiguiente.Text = "Siguiente"
        btnSiguiente.UseVisualStyleBackColor = False
        ' 
        ' btnIr
        ' 
        btnIr.BackColor = SystemColors.ControlLightLight
        btnIr.Font = New Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIr.Location = New Point(687, 119)
        btnIr.Name = "btnIr"
        btnIr.Size = New Size(120, 32)
        btnIr.TabIndex = 6
        btnIr.Text = "Aplicar"
        btnIr.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(301, 479)
        Label1.Name = "Label1"
        Label1.Size = New Size(450, 23)
        Label1.TabIndex = 7
        Label1.Text = "© All rights reserved by Yuri Alexander Pagel Krüger"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(314, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(446, 61)
        Label2.TabIndex = 8
        Label2.Text = "Business Calendar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(227, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 35)
        Label3.TabIndex = 9
        Label3.Text = "Mes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(478, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 35)
        Label4.TabIndex = 10
        Label4.Text = "Año"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1008, 537)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSiguiente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnIr)
        Controls.Add(btnAnterior)
        Controls.Add(panelDias)
        Controls.Add(textBoxAño)
        Controls.Add(comboMes)
        Controls.Add(labelMes)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents labelMes As Label
    Friend WithEvents comboMes As ComboBox
    Friend WithEvents textBoxAño As TextBox
    Friend WithEvents panelDias As Panel
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnIr As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
