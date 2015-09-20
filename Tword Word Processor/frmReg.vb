Public Class frmReg
    Dim network As Boolean = True

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            My.Computer.Network.DownloadFile("http://www.icronium.com", Application.StartupPath & "\test.txt")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\test.txt")
        Catch ex As System.Net.WebException
            network = False
        Catch ex As System.IO.FileNotFoundException
            network = False
        End Try

        If My.Settings.TID = "" Then
            If network Then
                Try
                    My.Computer.Network.DownloadFile("http://www.icronium.com/accounts/twordid.php", Application.StartupPath & "\id.txt")
                Catch ex As Exception
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\id.txt")
                    My.Computer.Network.DownloadFile("http://www.icronium.com/accounts/twordid.php", Application.StartupPath & "\id.txt")
                End Try
            Else
                MsgBox("Sorry, but you must have an internet connection when registering for your first time.")
                Me.Close()
            End If
            My.Settings.TID = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\id.txt")
        End If

        If network Then
            Try
                My.Computer.Network.DownloadFile("http://www.icronium.com/api/getUserInfo.php?un=" & txtUser.Text, Application.StartupPath & "\data.txt")
            Catch ex As IO.IOException
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\data.txt")
                My.Computer.Network.DownloadFile("http://www.icronium.com/api/getUserInfo.php?un=" & txtUser.Text, Application.StartupPath & "\data.txt")
            End Try
        End If

        Dim userInfo As String
        userInfo = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\data.txt")

        Dim userInfo2 As Array
        userInfo = Split(userInfo, "{")(1)
        userInfo = Split(userInfo, "}")(0)
        userInfo2 = Split(userInfo, ",")
        Dim status As String
        status = Split(userInfo2(0), ":")(1).Split(ControlChars.Quote)(1)
        If status = "error" Then
            MsgBox("User does not exist.")
        Else
            Dim userid As String
            userid = Split(userInfo2(1), ":")(1).Split(ControlChars.Quote)(1)
            If userid <> txtPass.Text Then
                MsgBox("Customer ID is incorrect.")
            Else
                If network Then
                    Try
                        My.Computer.Network.DownloadFile("http://www.icronium.com/api/getOpinion.php?un=" & txtUser.Text, Application.StartupPath & "\opinion.txt")
                    Catch ex As IO.IOException
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\opinion.txt")
                        My.Computer.Network.DownloadFile("http://www.icronium.com/api/getOpinion.php?un=" & txtUser.Text, Application.StartupPath & "\opinion.txt")
                    Catch ex As Exception
                    End Try
                End If

                Dim opinion As String
                opinion = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\opinion.txt")

                opinion = Split(opinion, "{")(1)
                opinion = Split(opinion, "}")(0)
                opinion = Split(opinion, ",")(1)
                opinion = Split(opinion, ":")(1).Split(ControlChars.Quote)(1)

                If opinion = "bad" Then
                    MsgBox("YOUR USE OF THIS SOFTWARE IS NOT PERMITTED!" & Environment.NewLine & Environment.NewLine & "We apologise for the inconvenience however Icronium have a bad reputation with your account. You may contact a member of management for assistance by using the form on the site contact page. You may not be allowed to use this software. Thank you.", MsgBoxStyle.Critical, "Software Usage Declined")
                Else
                    My.Settings.Username = txtUser.Text
                    My.Settings.ID = txtPass.Text
                    If network Then
                        Process.Start("http://www.icronium.com/accounts/twordreg.php?id=" & My.Settings.TID & "&un=" & My.Settings.Username & "&uid=" & My.Settings.ID)
                    End If
                    Form2.Show()
                    Me.Close()
                    End If
                End If
        End If
    End Sub

    Private Sub frmReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Username <> "" Then
            txtUser.Text = My.Settings.Username
            txtPass.Text = My.Settings.ID
            btnRegister_Click(sender, e)
        End If
    End Sub
End Class