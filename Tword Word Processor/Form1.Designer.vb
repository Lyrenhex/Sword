<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInput = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimedateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EULAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpellCheckToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSelectionToDictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BritishEnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmericanEnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AustralianEnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanadianEnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SouthAfricanEnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SwedishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.LithuanianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.KoreanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.GreekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHighlight = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnSelFont = New System.Windows.Forms.Button()
        Me.btnStrike = New System.Windows.Forms.Button()
        Me.btnColour = New System.Windows.Forms.Button()
        Me.btnUnderline = New System.Windows.Forms.Button()
        Me.btnItalic = New System.Windows.Forms.Button()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Open = New System.Windows.Forms.OpenFileDialog()
        Me.Save = New System.Windows.Forms.SaveFileDialog()
        Me.tmrDict = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.btnPrintComp = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.ForeColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(13, 72)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(623, 373)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SpellCheckToolStripMenuItem1, Me.ImportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(648, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(192, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Enabled = False
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(192, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripMenuItem3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem4, Me.FindToolStripMenuItem, Me.ReplaceToolStripMenuItem, Me.ToolStripMenuItem5, Me.SelectAllToolStripMenuItem, Me.TimedateToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(161, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(161, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ReplaceToolStripMenuItem.Text = "Replace"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(161, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'TimedateToolStripMenuItem
        '
        Me.TimedateToolStripMenuItem.Name = "TimedateToolStripMenuItem"
        Me.TimedateToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TimedateToolStripMenuItem.Text = "Time/date"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem})
        Me.FormatToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EULAToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'EULAToolStripMenuItem
        '
        Me.EULAToolStripMenuItem.Name = "EULAToolStripMenuItem"
        Me.EULAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EULAToolStripMenuItem.Text = "EULA"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'SpellCheckToolStripMenuItem1
        '
        Me.SpellCheckToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckToolStripMenuItem, Me.AddSelectionToDictionaryToolStripMenuItem, Me.DictionaryToolStripMenuItem})
        Me.SpellCheckToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.SpellCheckToolStripMenuItem1.Name = "SpellCheckToolStripMenuItem1"
        Me.SpellCheckToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.SpellCheckToolStripMenuItem1.Text = "SpellCheck"
        '
        'CheckToolStripMenuItem
        '
        Me.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem"
        Me.CheckToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CheckToolStripMenuItem.Text = "Check"
        '
        'AddSelectionToDictionaryToolStripMenuItem
        '
        Me.AddSelectionToDictionaryToolStripMenuItem.Name = "AddSelectionToDictionaryToolStripMenuItem"
        Me.AddSelectionToDictionaryToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AddSelectionToDictionaryToolStripMenuItem.Text = "Add Selection to Dictionary"
        '
        'DictionaryToolStripMenuItem
        '
        Me.DictionaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BritishEnglishToolStripMenuItem, Me.AmericanEnglishToolStripMenuItem, Me.AustralianEnglishToolStripMenuItem, Me.CanadianEnglishToolStripMenuItem, Me.SouthAfricanEnglishToolStripMenuItem, Me.ToolStripMenuItem6, Me.SwedishToolStripMenuItem, Me.ToolStripMenuItem7, Me.LithuanianToolStripMenuItem, Me.ToolStripMenuItem8, Me.KoreanToolStripMenuItem, Me.ToolStripMenuItem9, Me.GreekToolStripMenuItem})
        Me.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem"
        Me.DictionaryToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DictionaryToolStripMenuItem.Text = "Dictionary"
        '
        'BritishEnglishToolStripMenuItem
        '
        Me.BritishEnglishToolStripMenuItem.Name = "BritishEnglishToolStripMenuItem"
        Me.BritishEnglishToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.BritishEnglishToolStripMenuItem.Text = "British English"
        '
        'AmericanEnglishToolStripMenuItem
        '
        Me.AmericanEnglishToolStripMenuItem.Name = "AmericanEnglishToolStripMenuItem"
        Me.AmericanEnglishToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AmericanEnglishToolStripMenuItem.Text = "American English"
        '
        'AustralianEnglishToolStripMenuItem
        '
        Me.AustralianEnglishToolStripMenuItem.Name = "AustralianEnglishToolStripMenuItem"
        Me.AustralianEnglishToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AustralianEnglishToolStripMenuItem.Text = "Australian English"
        '
        'CanadianEnglishToolStripMenuItem
        '
        Me.CanadianEnglishToolStripMenuItem.Name = "CanadianEnglishToolStripMenuItem"
        Me.CanadianEnglishToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CanadianEnglishToolStripMenuItem.Text = "Canadian English"
        '
        'SouthAfricanEnglishToolStripMenuItem
        '
        Me.SouthAfricanEnglishToolStripMenuItem.Name = "SouthAfricanEnglishToolStripMenuItem"
        Me.SouthAfricanEnglishToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SouthAfricanEnglishToolStripMenuItem.Text = "South African English"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(184, 6)
        '
        'SwedishToolStripMenuItem
        '
        Me.SwedishToolStripMenuItem.Name = "SwedishToolStripMenuItem"
        Me.SwedishToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SwedishToolStripMenuItem.Text = "Swedish"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(184, 6)
        '
        'LithuanianToolStripMenuItem
        '
        Me.LithuanianToolStripMenuItem.Name = "LithuanianToolStripMenuItem"
        Me.LithuanianToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LithuanianToolStripMenuItem.Text = "Lithuanian"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(184, 6)
        '
        'KoreanToolStripMenuItem
        '
        Me.KoreanToolStripMenuItem.Name = "KoreanToolStripMenuItem"
        Me.KoreanToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KoreanToolStripMenuItem.Text = "Korean"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(184, 6)
        '
        'GreekToolStripMenuItem
        '
        Me.GreekToolStripMenuItem.Name = "GreekToolStripMenuItem"
        Me.GreekToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GreekToolStripMenuItem.Text = "Greek"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageToolStripMenuItem})
        Me.ImportToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.btnHighlight)
        Me.GroupBox1.Controls.Add(Me.btnRight)
        Me.GroupBox1.Controls.Add(Me.btnCenter)
        Me.GroupBox1.Controls.Add(Me.btnLeft)
        Me.GroupBox1.Controls.Add(Me.btnSelFont)
        Me.GroupBox1.Controls.Add(Me.btnStrike)
        Me.GroupBox1.Controls.Add(Me.btnColour)
        Me.GroupBox1.Controls.Add(Me.btnUnderline)
        Me.GroupBox1.Controls.Add(Me.btnItalic)
        Me.GroupBox1.Controls.Add(Me.btnBold)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 38)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnHighlight
        '
        Me.btnHighlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighlight.ForeColor = System.Drawing.Color.White
        Me.btnHighlight.Location = New System.Drawing.Point(145, 10)
        Me.btnHighlight.Name = "btnHighlight"
        Me.btnHighlight.Size = New System.Drawing.Size(22, 23)
        Me.btnHighlight.TabIndex = 9
        Me.btnHighlight.Text = "H"
        Me.btnHighlight.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ForeColor = System.Drawing.Color.White
        Me.btnRight.Location = New System.Drawing.Point(347, 10)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(22, 23)
        Me.btnRight.TabIndex = 8
        Me.btnRight.Text = "R"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnCenter
        '
        Me.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCenter.ForeColor = System.Drawing.Color.White
        Me.btnCenter.Location = New System.Drawing.Point(326, 10)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(22, 23)
        Me.btnCenter.TabIndex = 7
        Me.btnCenter.Text = "C"
        Me.btnCenter.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ForeColor = System.Drawing.Color.White
        Me.btnLeft.Location = New System.Drawing.Point(305, 10)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(22, 23)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.Text = "L"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnSelFont
        '
        Me.btnSelFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFont.ForeColor = System.Drawing.Color.White
        Me.btnSelFont.Location = New System.Drawing.Point(173, 10)
        Me.btnSelFont.Name = "btnSelFont"
        Me.btnSelFont.Size = New System.Drawing.Size(126, 23)
        Me.btnSelFont.TabIndex = 5
        Me.btnSelFont.Text = "Change Selection Font"
        Me.btnSelFont.UseVisualStyleBackColor = True
        '
        'btnStrike
        '
        Me.btnStrike.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStrike.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrike.ForeColor = System.Drawing.Color.White
        Me.btnStrike.Location = New System.Drawing.Point(117, 10)
        Me.btnStrike.Name = "btnStrike"
        Me.btnStrike.Size = New System.Drawing.Size(22, 23)
        Me.btnStrike.TabIndex = 4
        Me.btnStrike.Text = "S"
        Me.btnStrike.UseVisualStyleBackColor = True
        '
        'btnColour
        '
        Me.btnColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColour.Location = New System.Drawing.Point(89, 10)
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(22, 23)
        Me.btnColour.TabIndex = 3
        Me.btnColour.Text = "C"
        Me.btnColour.UseVisualStyleBackColor = True
        '
        'btnUnderline
        '
        Me.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnderline.ForeColor = System.Drawing.Color.White
        Me.btnUnderline.Location = New System.Drawing.Point(61, 10)
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(22, 23)
        Me.btnUnderline.TabIndex = 2
        Me.btnUnderline.Text = "U"
        Me.btnUnderline.UseVisualStyleBackColor = True
        '
        'btnItalic
        '
        Me.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalic.ForeColor = System.Drawing.Color.White
        Me.btnItalic.Location = New System.Drawing.Point(33, 10)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(22, 23)
        Me.btnItalic.TabIndex = 1
        Me.btnItalic.Text = "I"
        Me.btnItalic.UseVisualStyleBackColor = True
        '
        'btnBold
        '
        Me.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBold.ForeColor = System.Drawing.Color.White
        Me.btnBold.Location = New System.Drawing.Point(5, 10)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(22, 23)
        Me.btnBold.TabIndex = 0
        Me.btnBold.Text = "B"
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'Open
        '
        Me.Open.FileName = "Open"
        '
        'tmrDict
        '
        Me.tmrDict.Enabled = True
        Me.tmrDict.Interval = 1
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'btnPrintComp
        '
        Me.btnPrintComp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrintComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintComp.Location = New System.Drawing.Point(0, 0)
        Me.btnPrintComp.Name = "btnPrintComp"
        Me.btnPrintComp.Size = New System.Drawing.Size(648, 457)
        Me.btnPrintComp.TabIndex = 5
        Me.btnPrintComp.Text = "PLEASE CLICK HERE WHEN THE PRINTING PROCESS IS COMPLETE. THANK YOU."
        Me.btnPrintComp.UseVisualStyleBackColor = True
        Me.btnPrintComp.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(648, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnPrintComp)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpellCheckToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSelectionToDictionaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DictionaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BritishEnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmericanEnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimedateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStrike As System.Windows.Forms.Button
    Friend WithEvents btnColour As System.Windows.Forms.Button
    Friend WithEvents btnUnderline As System.Windows.Forms.Button
    Friend WithEvents btnItalic As System.Windows.Forms.Button
    Friend WithEvents btnBold As System.Windows.Forms.Button
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents Open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSelFont As System.Windows.Forms.Button
    Friend WithEvents AustralianEnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanadianEnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SouthAfricanEnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrDict As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SwedishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LithuanianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KoreanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GreekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EULAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnCenter As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnPrintComp As System.Windows.Forms.Button
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHighlight As System.Windows.Forms.Button

End Class
