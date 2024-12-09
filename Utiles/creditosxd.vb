Public Class creditosxd
    Private Sub creditosxd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class