Public Class Pizza
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If lsttaille.SelectedItem Is Nothing Then
            MessageBox.Show("Veuillez sélectionner une taille.")
            Return
        End If

        Dim taille = lsttaille.SelectedItem.ToString()
        Dim ingredient As String = ""

        If rb1.Checked Then
            ingredient = "croûte fine"
        ElseIf rb2.Checked Then
            ingredient = "croûte classique"
        ElseIf rb3.Checked Then
            ingredient = "croûte épaisse"
        Else
            MessageBox.Show("Veuillez sélectionner un type de croûte.")
            Return
        End If

        Dim ingrsupp As String = ""
        If cb1.Checked Then ingrsupp += "Champignons "
        If cb2.Checked Then ingrsupp += "Olives "
        If cb3.Checked Then ingrsupp += "Poivrons "
        If cb4.Checked Then ingrsupp += "Fromage "

        Dim msg As String = "Taille : " & taille & Environment.NewLine &
                            "Croûte : " & ingredient & Environment.NewLine &
                            "Ingrédients supplémentaires : " & If(String.IsNullOrWhiteSpace(ingrsupp), "Aucun", ingrsupp.Trim())

        MessageBox.Show(msg)
    End Sub
End Class
