'    Sword Material Design Word Processor
'    Copyright (c) 2016  Damian Heaton <dh64784@gmail.com>
'
'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.
'
'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.
'
'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see < http: //www.gnu.org/licenses/>.

Public Class seldict

    Private Sub listDicts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listDicts.SelectedIndexChanged
        My.Settings.Dictionary = listDicts.SelectedItem.ToString()
        MsgBox("Switched Dictionary to " & My.Settings.Dictionary & ".", MsgBoxStyle.Information)
        Form2.lblDict.Text = "Dictionary: " & My.Settings.Dictionary
        Me.Hide()
    End Sub

    Private Sub seldict_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class