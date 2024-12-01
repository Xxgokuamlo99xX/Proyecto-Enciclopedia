Public Class Alert_box

    Private accion As Action

    Public Sub Alertar(Mensaje As String, cosa As Action)

        accion = cosa
        Label1.Text = Mensaje
        Me.Show()

    End Sub

    Private Sub si(sender As Object, e As EventArgs) Handles Button1.Click
        accion()
        Me.Hide()

    End Sub

    Private Sub no(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
End Class