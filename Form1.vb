' Business Calendar v1.0.0
' Autor: Yuri Alexander Pagel Krüger
' © 2025 Yuri Alexander Pagel Krüger. Todos los derechos reservados.
Imports System.IO
Public Class Form1
    Dim mesActual As Integer = DateTime.Now.Month
    Dim añoActual As Integer = DateTime.Now.Year
    Dim rutaBase As String = Application.StartupPath
    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rutaBase As String = Application.StartupPath
        Me.Text = "Business Calendar"
        Me.Icon = New Icon(Path.Combine(rutaBase, "icon.ico"))
        Me.BackgroundImage = Image.FromFile(Path.Combine(rutaBase, "fondo.jpeg"))
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
    Sub MostrarDias(mes As Integer, año As Integer)
        labelMes.Text = MonthName(mes) & " " & año.ToString()
        panelDias.Controls.Clear()
        Dim primerDia As New DateTime(año, mes, 1)
        Dim diasEnMes As Integer = DateTime.DaysInMonth(año, mes)
        Dim diaSemanaInicio As Integer = CInt(primerDia.DayOfWeek)
        For i As Integer = 0 To diasEnMes - 1
            Dim btnDia As New Button()
            btnDia.Width = 60
            btnDia.Height = 50
            btnDia.Text = (i + 1).ToString()
            btnDia.Left = (i Mod 9) * (btnDia.Width + 5)
            btnDia.Top = (i \ 9) * (btnDia.Height + 5)
            AddHandler btnDia.Click, Sub(sender As Object, e As EventArgs)
                                         Dim diaSeleccionado As Integer = Integer.Parse(btnDia.Text)
                                         MessageBox.Show("Día seleccionado: " & diaSeleccionado & "/" & mes & "/" & año)
                                     End Sub

            panelDias.Controls.Add(btnDia)
        Next
    End Sub
    Private Sub CentrarLabelsVerticalmente()
        labelMes.Top = (Me.ClientSize.Height - labelMes.Height) \ 2
        Label1.Top = (Me.ClientSize.Height - Label1.Height) \ 2
        Label2.Top = (Me.ClientSize.Height - Label2.Height) \ 2
        Label4.Top = (Me.ClientSize.Height - Label4.Height) \ 2
    End Sub
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        mesActual -= 1
        If mesActual < 1 Then
            mesActual = 12
            añoActual -= 1
        End If
        MostrarDias(mesActual, añoActual)
    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        mesActual += 1
        If mesActual > 12 Then
            mesActual = 1
            añoActual += 1
        End If
        MostrarDias(mesActual, añoActual)
    End Sub
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        mesActual = comboMes.SelectedIndex + 1
        añoActual = Integer.Parse(textBoxAño.Text)
        labelMes.Text = MonthName(mesActual)
        MostrarDias(mesActual, añoActual)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
        comboMes.Items.AddRange(New String() {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        })
        comboMes.SelectedIndex = mesActual - 1
        textBoxAño.Text = añoActual.ToString()
        MostrarDias(mesActual, añoActual)
        Me.ActiveControl = Label1
    End Sub
End Class