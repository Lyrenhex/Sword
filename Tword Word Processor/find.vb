Public Class find

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Form2.txtContent.Find(txtString.Text)
    End Sub
End Class