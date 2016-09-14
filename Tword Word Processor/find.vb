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

Public Class find

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Form2.txtContent.Find(txtString.Text)
    End Sub
End Class