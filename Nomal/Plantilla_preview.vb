Imports FontAwesome.Sharp

Public Class Plantilla_preview
    'Cambiar textbox por labels xdddddddddddaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    'me voy a matar si no funciona
    Public Shared ContadorInstancias As Integer = -1
    Private info_man As New Info_manager

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

        Seleccion_lbl.Text = ""
        Console.WriteLine(current_id)
    End Sub
    Private Sub asignar_val()
        Id_lbl.Text = Me.PersonajesTableAdapter1.get_id(current_id)
        name_lbl.Content = Me.PersonajesTableAdapter1.get_nombre(current_id)
        saga_lbl.Content = Me.PersonajesTableAdapter1.get_saga(current_id)
        year_lbl.Text = "Año: " & Me.PersonajesTableAdapter1.get_year(current_id)
        Peso_lbl.Text = "Peso: " & Me.PersonajesTableAdapter1.get_peso(current_id) & " Kg"
        altura_lbl.Text = "Altura: " & Me.PersonajesTableAdapter1.get_altura(current_id) & " Mts"

        info_man.cargar_imagen("img_" & current_id & ".png", Imagen, current_id)

    End Sub

    Public Shared Sub ReiniciarContador()
        ContadorInstancias = 0 ' Reinicia a 0, eliminando el estado nulo
    End Sub

    Private Sub Plantilla_preview_Enter(sender As Object, e As EventArgs) Handles Seleccion_lbl.Enter
        Seleccion_lbl.Text = "Seleccionado"
        Administrado_1.form_selec_id = current_id
        Administrado_1.nom_selec_id = name_lbl.Content
        Administrado_1.saga_selec_id = saga_lbl.Content
        Administrado_1.year_selec_id = Me.PersonajesTableAdapter1.get_year(current_id)
        Administrado_1.peso_selec_id = Me.PersonajesTableAdapter1.get_peso(current_id)
        Administrado_1.altura_selec_id = Me.PersonajesTableAdapter1.get_altura(current_id)
        Administrado_1.color_selec_id = miColor

        Console.WriteLine(current_id)

    End Sub

    Private Sub Plantilla_preview_Leave(sender As Object, e As EventArgs) Handles Seleccion_lbl.Leave
        Seleccion_lbl.Text = "Seleccionar"

    End Sub

End Class