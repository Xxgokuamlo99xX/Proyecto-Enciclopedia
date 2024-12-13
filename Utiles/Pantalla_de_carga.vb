Public Class Pantalla_de_carga
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1

        If ProgressBar1.Value = 1 Then
            Menu_inicio.Hide()
        End If

        If ProgressBar1.Value = 100 Then
            Menu_inicio.Show()
            Timer1.Stop()
            Me.Close()
        End If

    End Sub

    Private Sub Pantalla_de_carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
    End Sub

End Class