Public Class Plantilla_preview

    Public Shared ContadorInstancias As Integer = -1

    Public Property current_id As Integer
    Private color_plantilla As String


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
        Dim valores() As String = rgb.Split(","c)

        Dim rojo As Integer = Convert.ToInt32(valores(0))
        Dim verde As Integer = Convert.ToInt32(valores(1))
        Dim azul As Integer = Convert.ToInt32(valores(2))


        Dim miColor As Color = Color.FromArgb(rojo, verde, azul)
        CambiarColorControles(Me, miColor)
        Id_TextBox.Text = Me.PersonajesTableAdapter1.get_id(current_id)
        name_textBox.Text = Me.PersonajesTableAdapter1.get_nombre(current_id)
        saga_TextBox.Text = Me.PersonajesTableAdapter1.get_saga(current_id)
        year_TextBox.Text = Me.PersonajesTableAdapter1.get_year(current_id)
        Peso_TextBox.Text = Me.PersonajesTableAdapter1.get_peso(current_id)
        high_TextBox.Text = Me.PersonajesTableAdapter1.get_altura(current_id)

    End Sub
End Class