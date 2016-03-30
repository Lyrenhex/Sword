Imports System.IO
Imports System.Text.RegularExpressions
Imports NHunspell

Public Class Form2

    Dim fileToOpen As String

    Private Sub print(ByVal box As RichTextBox, _
ByVal filename As String)
        Dim rect As Rectangle = box.DisplayRectangle
        Dim bmp As New Bitmap(rect.Width, rect.Height, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim p As Point
        g.CopyFromScreen(box.PointToScreen(p), p, New Size(rect.Width, rect.Height))
        g.Dispose()
        bmp.Save(filename, Imaging.ImageFormat.Png)
        bmp.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tacNav.SelectedTab = tabFile
        Me.Text = "Sword Word Processor - Unnamed File"
        Label3.Text = "Dictionary: " & My.Settings.Dictionary

        Try
            fileToOpen = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(0)
        Catch ex As NullReferenceException
            fileToOpen = ""
        End Try
        If fileToOpen = "" Then
            Me.Text = "Sword Word Processor - Unnamed File"
            txtContent.Text = ""
        Else
            fileToOpen = Regex.Replace(fileToOpen, "file:///", "")
            fileToOpen = Regex.Replace(fileToOpen, "%20", " ")
            Me.Text = "Sword Word Processor - " + fileToOpen
            txtContent.LoadFile(fileToOpen)
            SaveDialog.FileName = fileToOpen
        End If
        txtContent.EnableAutoDragDrop = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tacNav.SelectedTab = tabFile
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tacNav.SelectedTab = tabHome
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        txtContent.Text = ""
        Me.Text = "Sword Word Processor - Unnamed File"
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Try
            txtContent.SaveFile(SaveDialog.FileName)
            Me.Text = "Sword Word Processor - " & SaveDialog.FileName
        Catch ex As Exception
            SaveDialog.Filter = "Sword Document|*.sdc|Microsoft Word Document 97 - 2003|*.doc|Rich Text File Format|*.rtf|All File Types|*.*"
            SaveDialog.FilterIndex = 1
            SaveDialog.ShowDialog()
            Try
                txtContent.SaveFile(SaveDialog.FileName)
                Me.Text = "Sword Word Processor - " & SaveDialog.FileName
            Catch ex2 As Exception
            End Try
        End Try
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        SaveDialog.Filter = "Sword Document|*.sdc|Microsoft Word Document 97 - 2003|*.doc|Rich Text File Format|*.rtf|All File Types|*.*"
        SaveDialog.FilterIndex = 1
        SaveDialog.ShowDialog()
        Try
            txtContent.SaveFile(SaveDialog.FileName)
            Me.Text = "Sword Word Processor - " & SaveDialog.FileName
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        OpenDialog.Filter = "Sword Document|*.sdc|Tword Document|*.twd; *.twde|Microsoft Word Document 97 - 2003|*.doc|Rich Text File Format|*.rtf|All File Types|*.*"
        OpenDialog.FilterIndex = 1
        OpenDialog.ShowDialog()
        Try
            txtContent.LoadFile(OpenDialog.FileName)
            Me.Text = "Sword Word Processor - " & OpenDialog.FileName
        Catch ex2 As Exception
            MsgBox(ex2.ToString())
        End Try
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        SaveDialog.Filter = "PNG Image|*.png"
        SaveDialog.FilterIndex = 1
        SaveDialog.ShowDialog()
        Threading.Thread.Sleep(500)
        Try
            print(txtContent, SaveDialog.FileName)
            MsgBox("Exported to PNG file.")
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        PrintDialog.ShowDialog()
        Try
            PrintDoc.PrinterSettings = PrintDialog.PrinterSettings
            PrintDoc.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawString(txtContent.Text, txtContent.Font, Brushes.Black, 100, 100)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        PPDialog.Document = PrintDoc
        PPDialog.ShowDialog()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim webAddress As String = "http://www.icronium.com/officet/tcloud/"
        Process.Start(webAddress)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        txtContent.Paste()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        txtContent.Cut()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        txtContent.Copy()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        FontDialog.ShowDialog()
        txtContent.SelectionFont = FontDialog.Font
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If txtContent.SelectionFont.Bold = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Bold)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If txtContent.SelectionFont.Italic = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Italic)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        If txtContent.SelectionFont.Underline = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Underline)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If txtContent.SelectionFont.Strikeout = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Strikeout)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ColourDialog.ShowDialog()
        txtContent.SelectionColor = ColourDialog.Color
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ColourDialog.ShowDialog()
        txtContent.SelectionBackColor = ColourDialog.Color
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtContent.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtContent.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtContent.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If txtContent.SelectionBullet = True Then
            txtContent.SelectionBullet = False
        Else
            txtContent.SelectionBullet = True
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        find.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        replace.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim columns As Integer = Convert.ToInt32(InputBox("How many columns?")) - 1
        Dim rows As Integer = Convert.ToInt32(InputBox("How many rows?")) - 1
        Dim sbTaRtf As New System.Text.StringBuilder
        sbTaRtf.Append("{\rtf1")
        For index As Integer = 0 To rows
            sbTaRtf.Append("\trowd")
            Dim columnindex As Integer
            For columnin As Integer = 0 To columns
                columnindex = (columnin + 1) * 1000
                sbTaRtf.Append("\cellx" & columnindex.ToString()) 'set that cell width to 1000
                'sbTaRtf.Append("\cellx2000")
                'sbTaRtf.Append("\cellx3000")
            Next
            sbTaRtf.Append("\intbl \cell \row")
        Next
        sbTaRtf.Append("\pard")
        sbTaRtf.Append("}")
        txtContent.Rtf = sbTaRtf.ToString()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        OpenDialog.ShowDialog()
        Try
            Dim img As Image = Image.FromFile(OpenDialog.FileName)
            Dim orgData = Clipboard.GetDataObject
            Clipboard.SetImage(img)
            txtContent.Paste()
            ' MsgBox("Image added to clipboard. Please paste where you wish for the image to appear.", MsgBoxStyle.Information)
        Catch
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim url As String = InputBox("Website address of image? (Direct - such as http://www.example.com/cat-image.jpg)")
        SaveDialog.ShowDialog()
        Try
            My.Computer.Network.DownloadFile(url, SaveDialog.FileName)
            Dim img As Image = Image.FromFile(SaveDialog.FileName)
            Dim orgData = Clipboard.GetDataObject
            Clipboard.SetImage(img)
            txtContent.Paste()
        Catch
        End Try
    End Sub

    Private Sub txtContent_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles txtContent.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        txtContent.AppendText(Environment.NewLine)
        txtContent.AppendText("_______________________________________________")
        txtContent.AppendText(Environment.NewLine)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim comment As String = InputBox("Comment:")
        txtContent.Select(txtContent.TextLength, 0)
        txtContent.SelectionColor = Color.Blue
        txtContent.AppendText(Environment.NewLine)
        txtContent.AppendText(Environment.NewLine)
        txtContent.AppendText("<<< DOCUMENT COMMENT: " & comment & " >>>")
        txtContent.AppendText(Environment.NewLine)
        txtContent.AppendText(Environment.NewLine)
        txtContent.SelectionColor = Color.Black
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tacNav.SelectedTab = tabInsert
    End Sub

    Private Sub trackMargin_Scroll(sender As Object, e As EventArgs) Handles trackMargin.Scroll
        txtContent.RightMargin = trackMargin.Value * 100
    End Sub

    Private Sub txtContent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContent.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            For indent As Integer = 1 To trackIndent.Value
                txtContent.AppendText(" ")
            Next
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tacNav.SelectedTab = tabLayout
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        tacNav.SelectedTab = tabHelp
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        tacNav.SelectedTab = tabReview
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Process all your words here, don't create the Hunspell object for every word.
        frmSpellCheck.tabSpellCheck.TabPages.Clear()
        Dim suggestionspell As Integer = 0
        Dim txtSplit = Regex.Replace(txtContent.Text, "[^A-Za-z']+", " ")
        For Each stringy In Split(txtSplit, " ")
            Dim nghunspell As New Hunspell(My.Settings.Dictionary + ".aff", My.Settings.Dictionary + ".dic")
            Dim correct As Boolean = nghunspell.Spell(stringy)
            If stringy <> "" Then
                If correct = False Then
                    Dim suggestions As List(Of String) = nghunspell.Suggest(stringy)
                    Dim suggestionstr As String = ""
                    For Each suggestion In suggestions
                        suggestionstr = suggestionstr + suggestion + Environment.NewLine
                    Next
                    frmSpellCheck.tabSpellCheck.TabPages.Add(stringy)
                    frmSpellCheck.tabSpellCheck.SelectTab(suggestionspell)
                    suggestionspell = suggestionspell + 1
                    Dim txtSpelling As New TextBox
                    txtSpelling.Parent = frmSpellCheck.tabSpellCheck.SelectedTab
                    txtSpelling.Multiline = True
                    txtSpelling.Size = frmSpellCheck.tabSpellCheck.Size
                    txtSpelling.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
                    txtSpelling.ReadOnly = True
                    txtSpelling.Text = "Suggestions for the word '" + stringy + "' are: " + Environment.NewLine + suggestionstr
                    frmSpellCheck.Show()
                End If
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        seldict.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Using writer As New StreamWriter(My.Settings.Dictionary + ".dic", True) 'True for append mode
            writer.Write(txtContent.SelectedText + Environment.NewLine)
        End Using
        MsgBox("Selected text added to Dictionary.", MsgBoxStyle.Information, "Data Saved")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        txtContent.LoadFile(Application.StartupPath & "\eula.sdc")
        Me.Text = "Sword Word Processor - End-User License Agreement"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        My.Settings.Username = ""
        My.Settings.ID = ""
        MsgBox("Sword has been successfully de-registered.")
    End Sub
End Class