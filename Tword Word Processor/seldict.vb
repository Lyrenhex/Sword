Public Class seldict

    Private Sub listDicts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listDicts.SelectedIndexChanged
        My.Settings.Dictionary = listDicts.SelectedItem.ToString()
        MsgBox("Switched Dictionary to " & My.Settings.Dictionary & ".", MsgBoxStyle.Information)
        Form2.Label3.Text = "Dictionary: " & My.Settings.Dictionary
        Me.Hide()
    End Sub
End Class