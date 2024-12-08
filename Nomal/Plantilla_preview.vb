Imports FontAwesome.Sharp

Public Class Plantilla_preview

    Public Shared ContadorInstancias As Integer = -1

    Public Property current_id As Integer
    Private color_plantilla As String
    Private rojo As Integer
    Private verde As Integer
    Private azul As Integer

    Private miColor As Color = Color.FromArgb(rojo, verde, azul)


    Public Sub New()
        InitializeComponent()

        ' Incrementar el contador al crear una nueva instancia
        ContadorInstancias += 1
        current_id = ContadorInstancias

    End Sub
    Private Sub CambiarColorControles(control As Control, color As Color)
        ' Cambiar el color del fondo del control actual
        control.BackColor = color

        ' Iterar a través de los controles hijos si los tiene
        For Each hijo As Control In control.Controls
            CambiarColorControles(hijo, color)
        Next
    End Sub


    Private Sub Plantilla_preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rgb As String = Me.PersonajesTableAdapter1.get_color(current_id)
        Dim valores() As String
        If Not rgb = "" Then
            valores = rgb.Split(","c)
            rojo = Convert.ToInt32(valores(0))
            verde = Convert.ToInt32(valores(1))
            azul = Convert.ToInt32(valores(2))
        Else
            rojo = 0
            verde = 0
            azul = 0
        End If


        miColor = Color.FromArgb(rojo, verde, azul)

        CambiarColorControles(Me, miColor)

        asignar_val()

        Label1.Text = ""

    End Sub
    Private Sub asignar_val()
        Id_TextBox.Text = Me.PersonajesTableAdapter1.get_id(current_id)
        name_textBox.Text = Me.PersonajesTableAdapter1.get_nombre(current_id)
        saga_TextBox.Text = Me.PersonajesTableAdapter1.get_saga(current_id)
        year_TextBox.Text = Me.PersonajesTableAdapter1.get_year(current_id)
        Peso_TextBox.Text = Me.PersonajesTableAdapter1.get_peso(current_id)
        high_TextBox.Text = Me.PersonajesTableAdapter1.get_altura(current_id)
    End Sub

    Public Shared Sub ReiniciarContador()
        ContadorInstancias = 0 ' Reinicia a 0, eliminando el estado nulo
    End Sub

    Private Sub Plantilla_preview_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Label1.Text = "Seleccionado"
        Administrado_1.form_selec_id = current_id
        Administrado_1.nom_selec_id = name_textBox.Text
        Administrado_1.saga_selec_id = saga_TextBox.Text
        Administrado_1.year_selec_id = Val(year_TextBox.Text)
        Administrado_1.peso_selec_id = Val(Peso_TextBox.Text)
        Administrado_1.altura_selec_id = Val(high_TextBox.Text)
        Administrado_1.color_selec_id = miColor
        Console.WriteLine(current_id)

    End Sub

    Private Sub Plantilla_preview_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Label1.Text = ""

    End Sub
End Class