﻿
Imports System.IO
Imports Microsoft.Win32

Public Class actualizar_pj

    Private imagen_nombre As String
    Private info_man As New Info_manager
    Private color_panel As String
    Private Sub accept_Click(sender As Object, e As EventArgs) Handles accept.Click
        If null_confirm() Then
            If id_confirm() Then
                Alert_box.Alertar(
                    "Vas a sobreescribir un registro." & vbCrLf & "Estas seguro?",
                    Sub()
                        Plantilla_preview.PersonajesTableAdapter1.Actualizar_Pj(
                            nombre.Text,
                            saga.Text,
                            Val(year.Text),
                            Val(peso.Text),
                            Val(alt.Text),
                            color_panel,
                            Administrado_1.form_selec_id)

                        info_man.actualizar_img(imagen_nombre, Panel2.BackgroundImage)
                        Me.Close()
                    End Sub
                )
            End If
        End If

    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs) Handles no.Click
        Me.Close()

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

    Private Function cambiar_color() As String

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ' Obtén el color seleccionado
            Dim colorSeleccionado As Color = ColorDialog1.Color

            ' Convierte los valores RGB a una cadena
            Dim rgbString As String = $"{colorSeleccionado.R},{colorSeleccionado.G},{colorSeleccionado.B}"

            'Color = rgbString
            ' Muestra la cadena
            Console.WriteLine(rgbString)
            Panel1.BackColor = colorSeleccionado
            Return rgbString
        End If
        Return Nothing
    End Function

    Private Sub actualizar_pj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre.Text = Administrado_1.nom_selec_id
        saga.Text = Administrado_1.saga_selec_id
        year.Text = Administrado_1.year_selec_id
        peso.Text = Administrado_1.peso_selec_id
        alt.Text = Administrado_1.altura_selec_id
        Panel1.BackColor = Administrado_1.color_selec_id


    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        color_panel = cambiar_color()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
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

End Class