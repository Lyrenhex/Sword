Imports NHunspell
Imports System.IO
Imports System
Imports System.Drawing.Text
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class Form1

    'Dim bold As Boolean = False
    'Dim italic As Boolean = False
    'Dim under As Boolean = False
    'Dim strike As Boolean = False
    Dim fileToOpen As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fileToOpen = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(0)
        Catch ex As NullReferenceException
            fileToOpen = ""
        End Try
        If fileToOpen = "" Then
            Me.Text = "Tword Word Processor"
            txtInput.LoadFile("welcome.twd")
        Else
            fileToOpen = Regex.Replace(fileToOpen, "file:///", "")
            fileToOpen = Regex.Replace(fileToOpen, "%20", " ")
            Me.Text = "Tword Word Processor - " + fileToOpen
            txtInput.LoadFile(fileToOpen)
            Save.FileName = fileToOpen
        End If
        txtInput.EnableAutoDragDrop = True

        ' ToolTips
        Dim tooltip As ToolTip = New ToolTip(components)
        tooltip.SetToolTip(btnBold, "Makes your selected text bold.")
        tooltip.SetToolTip(btnItalic, "Makes your selected text oblique.")
        tooltip.SetToolTip(btnUnderline, "Underlines your selected text.")
        tooltip.SetToolTip(btnColour, "Changes the colour of the selected text.")
        tooltip.SetToolTip(btnStrike, "Adds a strikethrough in your selected text.")
        tooltip.SetToolTip(btnSelFont, "Changes the font of the selected text.")
        tooltip.SetToolTip(btnLeft, "Aligns the selected text left.")
        tooltip.SetToolTip(btnCenter, "Aligns the selected text center.")
        tooltip.SetToolTip(btnRight, "Aligns the selected text right.")
        tooltip.SetToolTip(btnHighlight, "Changes the text's background colour, similar to a highlighter.")
    End Sub

    'Private Sub tmrSpellCheck_Tick(sender As Object, e As EventArgs) Handles tmrSpellCheck.Tick
    '    ' Process all your words here, don't create the Hunspell object for every word.
    '    txtInput.Text = txtInput.Text + " "
    '    frmSpellCheck.tabSpellCheck.TabPages.Clear()
    '    Dim suggestionspell As Integer = 0
    '    For Each stringy In Split(txtInput.Text, " ")
    '        Dim nghunspell As New Hunspell(dict + ".aff", dict + ".dic")
    '        Dim correct As Boolean = nghunspell.Spell(stringy)
    '        If stringy <> "" Then
    '            If correct = False Then
    '                txtInput.Select(InStr(txtInput.Text, stringy) - 1, stringy.Length())
    '                txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Underline)
    '                txtInput.SelectionColor = Color.Red
    '                Dim suggestions As List(Of String) = nghunspell.Suggest(stringy)
    '                Dim suggestionstr As String = ""
    '                For Each suggestion In suggestions
    '                    suggestionstr = suggestionstr + suggestion + Environment.NewLine
    '                Next
    '                frmSpellCheck.tabSpellCheck.TabPages.Add(stringy)
    '                frmSpellCheck.tabSpellCheck.SelectTab(suggestionspell)
    '                suggestionspell = suggestionspell + 1
    '                Dim txtSpelling As New TextBox
    '                txtSpelling.Parent = frmSpellCheck.tabSpellCheck.SelectedTab
    '                txtSpelling.Multiline = True
    '                txtSpelling.Size = frmSpellCheck.tabSpellCheck.Size
    '                txtSpelling.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
    '                txtSpelling.ReadOnly = True
    '                txtSpelling.Text = "Suggestions for the word '" + stringy + "' are: " + Environment.NewLine + suggestionstr
    '                frmSpellCheck.Show()
    '            Else
    '                txtInput.Select(InStr(txtInput.Text, stringy) - 1, stringy.Length())
    '                If txtInput.SelectionColor = Color.Red Then
    '                    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Regular)
    '                    txtInput.SelectionColor = Color.White
    '                End If
    '            End If
    '        End If
    '    Next
    '    txtInput.Select(0 + txtInput.Text.Length, 0)
    '    Me.Select()
    'End Sub

    Private Sub CheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckToolStripMenuItem.Click
        ' Process all your words here, don't create the Hunspell object for every word.
        frmSpellCheck.tabSpellCheck.TabPages.Clear()
        Dim suggestionspell As Integer = 0
        Dim txtSplit = Regex.Replace(txtInput.Text, "[^A-Za-z']+", " ")
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

    Private Sub AddSelectionToDictionaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSelectionToDictionaryToolStripMenuItem.Click
        Using writer As New StreamWriter(My.Settings.Dictionary + ".dic", True) 'True for append mode
            writer.Write(txtInput.SelectedText + Environment.NewLine)
        End Using
        MsgBox("Selected text added to Dictionary", MsgBoxStyle.Information, "Data Saved")
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog.Font = txtInput.Font
        FontDialog.ShowDialog()
        txtInput.Font = FontDialog.Font
    End Sub

    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click
        If txtInput.SelectionFont.Style = FontStyle.Italic Then
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Regular)
        Else
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Bold)
        End If
    End Sub

    Private Sub btnItalic_Click(sender As Object, e As EventArgs) Handles btnItalic.Click
        If txtInput.SelectionFont.Style = FontStyle.Italic Then
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Regular)
            'italic = False
        Else
            'If bold And under And strike Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Bold + FontStyle.Underline + FontStyle.Strikeout + FontStyle.Italic)
            'ElseIf bold And under Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Bold + FontStyle.Underline + FontStyle.Italic)
            'ElseIf bold And strike Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Bold + FontStyle.Strikeout + FontStyle.Italic)
            'ElseIf under And strike Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Underline + FontStyle.Strikeout + FontStyle.Italic)
            'ElseIf bold Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Bold + FontStyle.Italic)
            'ElseIf under Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Underline + FontStyle.Italic)
            'ElseIf strike Then
            '    txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Strikeout + FontStyle.Italic)
            'Else
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Italic)
            'End If
            'italic = True
        End If
    End Sub

    Private Sub btnUnderline_Click(sender As Object, e As EventArgs) Handles btnUnderline.Click
        If txtInput.SelectionFont.Style = FontStyle.Underline Then
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Regular)
        Else
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Underline)
        End If
    End Sub

    Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
        ColorDialog.Color = txtInput.SelectionColor
        ColorDialog.ShowDialog()
        txtInput.SelectionColor = ColorDialog.Color
    End Sub

    Private Sub btnStrike_Click(sender As Object, e As EventArgs) Handles btnStrike.Click
        If txtInput.SelectionFont.Style = FontStyle.Strikeout Then
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Regular)
        Else
            txtInput.SelectionFont = New Font(txtInput.SelectionFont, FontStyle.Strikeout)
        End If
    End Sub

    Private Sub BritishEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BritishEnglishToolStripMenuItem.Click
        My.Settings.Dictionary = "en_GB"
        MsgBox("Switched Dictionary to British English.", MsgBoxStyle.Information)
    End Sub

    Private Sub AmericanEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmericanEnglishToolStripMenuItem.Click
        My.Settings.Dictionary = "en_US"
        MsgBox("Switched Dictionary to American English.", MsgBoxStyle.Information)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        txtInput.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtInput.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtInput.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtInput.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        txtInput.SelectedText = ""
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        find.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        replace.Show()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtInput.SelectAll()
    End Sub

    Private Sub TimedateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimedateToolStripMenuItem.Click
        txtInput.Text = txtInput.Text + TimeOfDay.ToString()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtInput.Text = ""
        Me.Text = "Tword Word Processor - Untitled"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Open.ShowDialog()
        Try
            txtInput.LoadFile(Open.FileName)
            Me.Text = "Tword Word Processor - " + Open.FileName
        Catch
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Save.Filter = "Tword Document|*.twd|Microsoft Word Document|*.docx|Microsoft Word 97 - 2003 Doc|*.doc|Rich Text File Format|*.rtf|All File Types|*.*"
        Save.FilterIndex = 1
        Save.ShowDialog()
        Try
            txtInput.SaveFile(Save.FileName)
            Me.Text = "Tword Word Processor - " + Save.FileName
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        Open.ShowDialog()
        Try
            Dim img As Image = Image.FromFile(Open.FileName)
            Dim orgData = Clipboard.GetDataObject
            Clipboard.SetImage(img)
            txtInput.Paste()
            MsgBox("Image added to clipboard. Please paste where you wish for the image to appear.", MsgBoxStyle.Information)
        Catch
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ' Process all your words here, don't create the Hunspell object for every word.
        Dim suggestionspell As Integer = 0
        Dim txtSplit = Regex.Replace(txtInput.Text, "[^A-Za-z']+", " ")
        For Each stringy In Split(txtSplit, " ")
            txtInput.Select(txtInput.Text.IndexOf(stringy), stringy.Length)
            If txtInput.SelectionColor = Color.White Then
                txtInput.SelectionColor = Color.Black
            End If
        Next
        btnPrintComp.Visible = True
        PrintDialog.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelFont.Click
        FontDialog.Font = txtInput.SelectionFont
        FontDialog.ShowDialog()
        txtInput.SelectionFont = FontDialog.Font
    End Sub

    Private Sub AustralianEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AustralianEnglishToolStripMenuItem.Click
        My.Settings.Dictionary = "en_AU"
        MsgBox("Switched Dictionary to Australian English.", MsgBoxStyle.Information)
    End Sub

    Private Sub CanadianEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanadianEnglishToolStripMenuItem.Click
        My.Settings.Dictionary = "en_CA"
        MsgBox("Switched Dictionary to Canadian English.", MsgBoxStyle.Information)
    End Sub

    Private Sub SouthAfricanEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SouthAfricanEnglishToolStripMenuItem.Click
        My.Settings.Dictionary = "en_ZA"
        MsgBox("Switched Dictionary to South African English.", MsgBoxStyle.Information)
    End Sub

    Private Sub tmrDict_Tick(sender As Object, e As EventArgs) Handles tmrDict.Tick
        ' British English in use?
        If My.Settings.Dictionary = "en_GB" Then
            BritishEnglishToolStripMenuItem.Checked = True
        Else
            BritishEnglishToolStripMenuItem.Checked = False
        End If

        ' American English in use?
        If My.Settings.Dictionary = "en_US" Then
            AmericanEnglishToolStripMenuItem.Checked = True
        Else
            AmericanEnglishToolStripMenuItem.Checked = False
        End If

        ' Australian English in use?
        If My.Settings.Dictionary = "en_AU" Then
            AustralianEnglishToolStripMenuItem.Checked = True
        Else
            AustralianEnglishToolStripMenuItem.Checked = False
        End If

        ' Canadian English in use?
        If My.Settings.Dictionary = "en_CA" Then
            CanadianEnglishToolStripMenuItem.Checked = True
        Else
            CanadianEnglishToolStripMenuItem.Checked = False
        End If

        ' South African English in use?
        If My.Settings.Dictionary = "en_ZA" Then
            SouthAfricanEnglishToolStripMenuItem.Checked = True
        Else
            SouthAfricanEnglishToolStripMenuItem.Checked = False
        End If

        ' Swedish in use?
        If My.Settings.Dictionary = "sv_SE" Then
            SwedishToolStripMenuItem.Checked = True
        Else
            SwedishToolStripMenuItem.Checked = False
        End If

        ' Lithuanian in use?
        If My.Settings.Dictionary = "lt_LT" Then
            LithuanianToolStripMenuItem.Checked = True
        Else
            LithuanianToolStripMenuItem.Checked = False
        End If

        ' Korean in use?
        If My.Settings.Dictionary = "ko_KR" Then
            KoreanToolStripMenuItem.Checked = True
        Else
            KoreanToolStripMenuItem.Checked = False
        End If

        ' Greek in use?
        If My.Settings.Dictionary = "el_GR" Then
            GreekToolStripMenuItem.Checked = True
        Else
            GreekToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub SwedishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwedishToolStripMenuItem.Click
        My.Settings.Dictionary = "sv_SE"
        MsgBox("Switched Dictionary to Swedish.", MsgBoxStyle.Information)
    End Sub

    Private Sub LithuanianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LithuanianToolStripMenuItem.Click
        My.Settings.Dictionary = "lt_LT"
        MsgBox("Switched Dictionary to Lithuanian.", MsgBoxStyle.Information)
    End Sub

    Private Sub KoreanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoreanToolStripMenuItem.Click
        My.Settings.Dictionary = "ko_KR"
        MsgBox("Switched Dictionary to Korean.", MsgBoxStyle.Information)
    End Sub

    Private Sub GreekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreekToolStripMenuItem.Click
        My.Settings.Dictionary = "el_GR"
        MsgBox("Switched Dictionary to Greek (Hellenic - Ελληνικα).", MsgBoxStyle.Information)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            txtInput.SaveFile(Save.FileName)
            Me.Text = "Tword Word Processor - " + Save.FileName
        Catch ex As Exception
            Try
                txtInput.SaveFile(Open.FileName)
                Me.Text = "Tword Word Processor - " + Open.FileName
            Catch ex2 As Exception
                MsgBox("Consider using Save As... or opening a file first.")
            End Try
        End Try
    End Sub

    Private Sub EULAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EULAToolStripMenuItem.Click
        txtInput.LoadFile("eula.twd")
        Me.Text = "Tword Word Processor - End-User License Agreement"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLeft.Click
        txtInput.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        txtInput.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        txtInput.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub btnPrintComp_Click(sender As Object, e As EventArgs) Handles btnPrintComp.Click
        Dim suggestionspell As Integer = 0
        Dim txtSplit = Regex.Replace(txtInput.Text, "[^A-Za-z']+", " ")
        For Each stringy In Split(txtSplit, " ")
            txtInput.Select(txtInput.Text.IndexOf(stringy), stringy.Length)
            If txtInput.SelectionColor = Color.Black Then
                txtInput.SelectionColor = Color.White
            End If
        Next
        btnPrintComp.Visible = False
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Process.Start("http://www.Icronium.net/#contact")
    End Sub

    Private Sub txtInput_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles txtInput.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnHighlight.Click
        'ColorDialog.CustomColors.SetValue(Color.FromArgb(64, 64, 64), 1)
        ColorDialog.CustomColors = New Integer() {Color.FromArgb(64, 64, 64).GetHashCode}
        ColorDialog.Color = txtInput.SelectionColor
        ColorDialog.ShowDialog()
        txtInput.SelectionBackColor = ColorDialog.Color
    End Sub

    Private Sub DictionaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripMenuItem.Click

    End Sub
End Class
