Public Class Alert_box

    Private accion As Action

    Public Sub Alertar(Mensaje As String, cosa As Action)

        accion = cosa
        RichTextBox1.Text = Mensaje
        Me.Show()


    End Sub

    Private Sub si(sender As Object, e As EventArgs) Handles Button1.Click
        accion()
        Me.Hide()

    End Sub

    Private Sub no(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Alert_box_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
End Class