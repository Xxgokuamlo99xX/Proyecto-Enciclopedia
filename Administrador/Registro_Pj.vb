Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Registro_Pj
    Private imagen_nombre As String
    Private info_man As New Info_manager
    Private color As String
    Private Sub accept_Click(sender As Object, e As EventArgs) Handles accept.Click
        If null_confirm() Then
            If id_confirm() Then
                Alert_box.Alertar(
                    "Vas a crear un nuevo registro." & vbCrLf & "Estas seguro?",
                    Sub()
                        Plantilla_preview.PersonajesTableAdapter1.Agregar_Pj(
                            Plantilla_preview.PersonajesTableAdapter1.get_cant_id() + 1,
                            nombre.Text,
                            saga.Text,
                            Val(year.Text),
                            Val(peso.Text),
                            Val(alt.Text),
                            color)

                        info_man.guarda_imagen(imagen_nombre, Panel2.BackgroundImage)
                        Me.Hide()

                    End Sub
                )
            End If
        End If

    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs) Handles no.Click
        Me.Hide()
    End Sub

    Private Function id_confirm() As Boolean
        For i As Integer = Plantilla_preview.PersonajesTableAdapter1.get_cant_id() To 1 Step -1
            If Val(nombre.Text) = i Then
                MsgBox("Este id ya se encuentra en uso.")
                Console.WriteLine("id_confirm")
                Return False

            End If
        Next
        Return True

    End Function
    Private Function null_confirm() As Boolean
        For Each hijo As Control In Me.Controls
            If TypeOf hijo Is TextBox Then
                If hijo.Text = "" Then
                    MsgBox("Porfavor rellena todos los campos.")
                    Console.WriteLine("null_confirm")
                    Return False
                End If
            End If
        Next
        Return True

    End Function

    Private Sub cambiar_color(sender As Object, e As EventArgs) Handles Panel1.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ' Obtén el color seleccionado
            Dim colorSeleccionado As Color = ColorDialog1.Color

            ' Convierte los valores RGB a una cadena
            Dim rgbString As String = $"{colorSeleccionado.R},{colorSeleccionado.G},{colorSeleccionado.B}"

            color = rgbString
            ' Muestra la cadena
            Console.WriteLine(rgbString)
            Panel1.BackColor = colorSeleccionado
        End If

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Mostrar la imagen seleccionada en un PictureBox
            Dim extension As String = Path.GetExtension(OpenFileDialog1.FileName).ToLower()
            If extension <> ".png" AndAlso extension <> ".jpg" Then
                MessageBox.Show("Por favor, seleccione un archivo de imagen válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Panel2.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            imagen_nombre = "img_" & Administrado_1.form_selec_id & ".png"

        Else
            MessageBox.Show("No se seleccionó ninguna imagen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub Registro_Pj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackgroundImage = Image.FromFile("e: \Oscar Alvarado 510\Visual Studio\Proyecto Enciclopedia\Resources\Unknown_person.jpg")
    End Sub
End Class