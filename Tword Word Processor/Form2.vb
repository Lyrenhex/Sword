Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing.Printing
Imports NHunspell
Imports MaterialSkin

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

Public Class Form2
    Dim fileToOpen As String

    Private Sub print(ByVal box As RichTextBox,
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
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        tacNav.SelectedTab = tabFile
        Me.Text = "Sword Word Processor - Unnamed File"
        lblDict.Text = "Dictionary: " & My.Settings.Dictionary

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
        txtContent.SpellCheck.IsEnabled = True

        chkIndent.Checked = My.Settings.Indents
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        tacNav.SelectedTab = tabFile
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        tacNav.SelectedTab = tabHome
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtContent.Text = ""
        Me.Text = "Sword Word Processor - Unnamed File"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        SaveDialog.Filter = "Sword Document|*.sdc|Microsoft Word Document 97 - 2003|*.doc|Rich Text File Format|*.rtf|All File Types|*.*"
        SaveDialog.FilterIndex = 1
        SaveDialog.ShowDialog()
        Try
            txtContent.SaveFile(SaveDialog.FileName)
            Me.Text = "Sword Word Processor - " & SaveDialog.FileName
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        txtContent.Paste()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        txtContent.Cut()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        txtContent.Copy()
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        FontDialog.ShowDialog()
        txtContent.SelectionFont = FontDialog.Font
    End Sub

    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click
        If txtContent.SelectionFont.Bold = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Bold)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub btnItalics_Click(sender As Object, e As EventArgs) Handles btnItalics.Click
        If txtContent.SelectionFont.Italic = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Italic)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub btnUnderline_Click(sender As Object, e As EventArgs) Handles btnUnderline.Click
        If txtContent.SelectionFont.Underline = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Underline)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub btnStrikeout_Click(sender As Object, e As EventArgs) Handles btnStrikeout.Click
        If txtContent.SelectionFont.Strikeout = False Then
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style Or FontStyle.Strikeout)
        Else
            txtContent.SelectionFont = New Font(txtContent.SelectionFont, txtContent.SelectionFont.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
        ColourDialog.ShowDialog()
        txtContent.SelectionColor = ColourDialog.Color
    End Sub

    Private Sub btnHighlight_Click(sender As Object, e As EventArgs) Handles btnHighlight.Click
        ColourDialog.ShowDialog()
        txtContent.SelectionBackColor = ColourDialog.Color
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        txtContent.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        txtContent.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        txtContent.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If txtContent.SelectionBullet = True Then
            txtContent.SelectionBullet = False
        Else
            txtContent.SelectionBullet = True
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        find.Show()
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        replace.Show()
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
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

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
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

    Private Sub btnWebImg_Click(sender As Object, e As EventArgs) Handles btnWebImg.Click
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

    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        txtContent.AppendText(Environment.NewLine)
        txtContent.AppendText("_______________________________________________")
        txtContent.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        tacNav.SelectedTab = tabInsert
    End Sub

    Private Sub trackMargin_Scroll(sender As Object, e As EventArgs) Handles trackMargin.Scroll
        txtContent.RightMargin = trackMargin.Value * 100
    End Sub

    Private Sub txtContent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContent.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If chkIndent.Checked Then
                txtContent.AppendText("    ")
            End If
            'For indent As Integer = 1 To trackIndent.Value
            '    txtContent.AppendText(" ")
            'Next
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        tacNav.SelectedTab = tabLayout
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        tacNav.SelectedTab = tabHelp
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        tacNav.SelectedTab = tabReview
    End Sub

    Private Sub btnCheckSpell_Click(sender As Object, e As EventArgs) Handles btnCheckSpell.Click
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

    Private Sub btnDict_Click(sender As Object, e As EventArgs) Handles btnDict.Click
        seldict.Show()
    End Sub

    Private Sub btnAddToDict_Click(sender As Object, e As EventArgs) Handles btnAddToDict.Click
        Using writer As New StreamWriter(My.Settings.Dictionary + ".dic", True) 'True for append mode
            writer.Write(txtContent.SelectedText + Environment.NewLine)
        End Using
        MsgBox("Selected text added to Dictionary.", MsgBoxStyle.Information, "Data Saved")
    End Sub

    Private Sub btnEULA_Click(sender As Object, e As EventArgs) Handles btnEULA.Click
        txtContent.LoadFile(Application.StartupPath & "\eula.sdc")
        Me.Text = "Sword Word Processor - End-User License Agreement"
    End Sub

    Private Sub chkIndent_Click(sender As Object, e As EventArgs) Handles chkIndent.Click
        My.Settings.Indents = chkIndent.Checked
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PPDialog.Document = PrintDoc
        PPDialog.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim pd As New PrintDialog()
        If (pd.ShowDialog() = True) Then
            'use either one of the below      
            pd.PrintDocument(((CType(txtContent.Document, IDocumentPaginatorSource)).DocumentPaginator), "printing as paginator")
        End If
    End Sub
End Class