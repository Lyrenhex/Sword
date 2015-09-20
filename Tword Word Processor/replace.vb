Public Class replace
    Private Sub btnRep_Click(sender As Object, e As EventArgs) Handles btnRep.Click
        Form2.txtContent.Find(txtRep1.Text)
        Form2.txtContent.SelectedText = txtRep2.Text
    End Sub
End Class