Public Class Administrado_1
    Private currentchildform As Form

    Private Sub OpenChildForm(childForm As Form)
        ' Open only form
        ' If currentchildform IsNot Nothing Then
        '     currentchildform.Close()
        ' End If
        'currentchildform = childForm
        ' End

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Left
        Panel_plantilla.Controls.Add(childForm)
        Panel_plantilla.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Administrado_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_plantilla.AutoScroll = True
        OpenChildForm(New Plantilla_preview)
        OpenChildForm(New Plantilla_preview)
        OpenChildForm(New Plantilla_preview)
    End Sub
End Class
