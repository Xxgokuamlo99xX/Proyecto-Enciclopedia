Public Class Registro_Pj
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
                            "0,0,0")

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
End Class