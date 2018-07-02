<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ScreenText
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ScreenText))
        Me.CON_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StandartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuchhaltungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinkaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerkaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeschäftsleitungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuftragsbearbeitungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechnungsprüfungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarketingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControllingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DispoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoststelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManuelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarbeÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnsichtbarMachenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchlissenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tim_full = New System.Windows.Forms.Timer(Me.components)
        Me.NI_stseuerung = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer_time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ping = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_hidden = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_text = New System.Windows.Forms.Label()
        Me.Lab_ipadress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lab_pcname = New System.Windows.Forms.Label()
        Me.Lab_ping = New System.Windows.Forms.Label()
        Me.Lab_time = New System.Windows.Forms.Label()
        Me.Lab_pingadress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CON_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'CON_menu
        '
        Me.CON_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandartToolStripMenuItem, Me.ManuelToolStripMenuItem, Me.FarbeÄndernToolStripMenuItem, Me.UnsichtbarMachenToolStripMenuItem, Me.TerminalTSM, Me.SchlissenToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.CON_menu.Name = "CON_menu"
        Me.CON_menu.Size = New System.Drawing.Size(178, 158)
        Me.CON_menu.Text = "Menü"
        '
        'StandartToolStripMenuItem
        '
        Me.StandartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuchhaltungToolStripMenuItem, Me.EinkaufToolStripMenuItem, Me.VerkaufToolStripMenuItem, Me.ITToolStripMenuItem, Me.GeschäftsleitungToolStripMenuItem, Me.LagerToolStripMenuItem, Me.AuftragsbearbeitungToolStripMenuItem, Me.RechnungsprüfungToolStripMenuItem, Me.MarketingToolStripMenuItem, Me.ControllingToolStripMenuItem, Me.DispoToolStripMenuItem, Me.PoststelleToolStripMenuItem})
        Me.StandartToolStripMenuItem.Name = "StandartToolStripMenuItem"
        Me.StandartToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.StandartToolStripMenuItem.Text = "Standard"
        '
        'BuchhaltungToolStripMenuItem
        '
        Me.BuchhaltungToolStripMenuItem.Name = "BuchhaltungToolStripMenuItem"
        Me.BuchhaltungToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.BuchhaltungToolStripMenuItem.Text = "Buchhaltung"
        '
        'EinkaufToolStripMenuItem
        '
        Me.EinkaufToolStripMenuItem.Name = "EinkaufToolStripMenuItem"
        Me.EinkaufToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EinkaufToolStripMenuItem.Text = "Einkauf"
        '
        'VerkaufToolStripMenuItem
        '
        Me.VerkaufToolStripMenuItem.Name = "VerkaufToolStripMenuItem"
        Me.VerkaufToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.VerkaufToolStripMenuItem.Text = "Verkauf"
        '
        'ITToolStripMenuItem
        '
        Me.ITToolStripMenuItem.Name = "ITToolStripMenuItem"
        Me.ITToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ITToolStripMenuItem.Text = "IT"
        '
        'GeschäftsleitungToolStripMenuItem
        '
        Me.GeschäftsleitungToolStripMenuItem.Name = "GeschäftsleitungToolStripMenuItem"
        Me.GeschäftsleitungToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.GeschäftsleitungToolStripMenuItem.Text = "Geschäftsleitung"
        '
        'LagerToolStripMenuItem
        '
        Me.LagerToolStripMenuItem.Name = "LagerToolStripMenuItem"
        Me.LagerToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LagerToolStripMenuItem.Text = "Lager"
        '
        'AuftragsbearbeitungToolStripMenuItem
        '
        Me.AuftragsbearbeitungToolStripMenuItem.Name = "AuftragsbearbeitungToolStripMenuItem"
        Me.AuftragsbearbeitungToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AuftragsbearbeitungToolStripMenuItem.Text = "Auftragsbearbeitung"
        '
        'RechnungsprüfungToolStripMenuItem
        '
        Me.RechnungsprüfungToolStripMenuItem.Name = "RechnungsprüfungToolStripMenuItem"
        Me.RechnungsprüfungToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RechnungsprüfungToolStripMenuItem.Text = "Rechnungsprüfung"
        '
        'MarketingToolStripMenuItem
        '
        Me.MarketingToolStripMenuItem.Name = "MarketingToolStripMenuItem"
        Me.MarketingToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MarketingToolStripMenuItem.Text = "Marketing"
        '
        'ControllingToolStripMenuItem
        '
        Me.ControllingToolStripMenuItem.Name = "ControllingToolStripMenuItem"
        Me.ControllingToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ControllingToolStripMenuItem.Text = "Controlling"
        '
        'DispoToolStripMenuItem
        '
        Me.DispoToolStripMenuItem.Name = "DispoToolStripMenuItem"
        Me.DispoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DispoToolStripMenuItem.Text = "Dispo"
        '
        'PoststelleToolStripMenuItem
        '
        Me.PoststelleToolStripMenuItem.Name = "PoststelleToolStripMenuItem"
        Me.PoststelleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PoststelleToolStripMenuItem.Text = "Poststelle"
        '
        'ManuelToolStripMenuItem
        '
        Me.ManuelToolStripMenuItem.Name = "ManuelToolStripMenuItem"
        Me.ManuelToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ManuelToolStripMenuItem.Text = "Manuel"
        '
        'FarbeÄndernToolStripMenuItem
        '
        Me.FarbeÄndernToolStripMenuItem.Name = "FarbeÄndernToolStripMenuItem"
        Me.FarbeÄndernToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FarbeÄndernToolStripMenuItem.Text = "Farbe ändern"
        '
        'UnsichtbarMachenToolStripMenuItem
        '
        Me.UnsichtbarMachenToolStripMenuItem.Name = "UnsichtbarMachenToolStripMenuItem"
        Me.UnsichtbarMachenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UnsichtbarMachenToolStripMenuItem.Text = "Unsichtbar machen"
        '
        'TerminalTSM
        '
        Me.TerminalTSM.Name = "TerminalTSM"
        Me.TerminalTSM.Size = New System.Drawing.Size(177, 22)
        Me.TerminalTSM.Text = "Terminal"
        '
        'SchlissenToolStripMenuItem
        '
        Me.SchlissenToolStripMenuItem.Name = "SchlissenToolStripMenuItem"
        Me.SchlissenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SchlissenToolStripMenuItem.Text = "Schließen"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'Tim_full
        '
        '
        'NI_stseuerung
        '
        Me.NI_stseuerung.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NI_stseuerung.BalloonTipText = "Steuerung des Programmes"
        Me.NI_stseuerung.BalloonTipTitle = "Steuerung"
        Me.NI_stseuerung.ContextMenuStrip = Me.CON_menu
        Me.NI_stseuerung.Icon = CType(resources.GetObject("NI_stseuerung.Icon"), System.Drawing.Icon)
        Me.NI_stseuerung.Text = "NI_steuerung"
        Me.NI_stseuerung.Visible = True
        '
        'Timer_time
        '
        Me.Timer_time.Interval = 1
        '
        'Timer_ping
        '
        Me.Timer_ping.Interval = 240000
        '
        'Timer_hidden
        '
        Me.Timer_hidden.Interval = 5000
        '
        'Lab_text
        '
        Me.Lab_text.AutoSize = True
        Me.Lab_text.BackColor = System.Drawing.Color.Transparent
        Me.Lab_text.ContextMenuStrip = Me.CON_menu
        Me.Lab_text.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Lab_text.Location = New System.Drawing.Point(3, 1)
        Me.Lab_text.Name = "Lab_text"
        Me.Lab_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lab_text.Size = New System.Drawing.Size(235, 111)
        Me.Lab_text.TabIndex = 6
        Me.Lab_text.Text = "Text"
        '
        'Lab_ipadress
        '
        Me.Lab_ipadress.AutoSize = True
        Me.Lab_ipadress.ContextMenuStrip = Me.CON_menu
        Me.Lab_ipadress.Location = New System.Drawing.Point(14, 113)
        Me.Lab_ipadress.Name = "Lab_ipadress"
        Me.Lab_ipadress.Size = New System.Drawing.Size(17, 13)
        Me.Lab_ipadress.TabIndex = 7
        Me.Lab_ipadress.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 11
        '
        'Lab_pcname
        '
        Me.Lab_pcname.AutoSize = True
        Me.Lab_pcname.ContextMenuStrip = Me.CON_menu
        Me.Lab_pcname.Location = New System.Drawing.Point(14, 133)
        Me.Lab_pcname.Name = "Lab_pcname"
        Me.Lab_pcname.Size = New System.Drawing.Size(78, 13)
        Me.Lab_pcname.TabIndex = 8
        Me.Lab_pcname.Text = "Computername"
        '
        'Lab_ping
        '
        Me.Lab_ping.AutoSize = True
        Me.Lab_ping.ContextMenuStrip = Me.CON_menu
        Me.Lab_ping.Location = New System.Drawing.Point(14, 156)
        Me.Lab_ping.Name = "Lab_ping"
        Me.Lab_ping.Size = New System.Drawing.Size(28, 13)
        Me.Lab_ping.TabIndex = 10
        Me.Lab_ping.Text = "Ping"
        '
        'Lab_time
        '
        Me.Lab_time.AutoSize = True
        Me.Lab_time.ContextMenuStrip = Me.CON_menu
        Me.Lab_time.Location = New System.Drawing.Point(92, 156)
        Me.Lab_time.Name = "Lab_time"
        Me.Lab_time.Size = New System.Drawing.Size(40, 13)
        Me.Lab_time.TabIndex = 9
        Me.Lab_time.Text = "Uhrzeit"
        '
        'Lab_pingadress
        '
        Me.Lab_pingadress.AutoSize = True
        Me.Lab_pingadress.Location = New System.Drawing.Point(173, 160)
        Me.Lab_pingadress.Name = "Lab_pingadress"
        Me.Lab_pingadress.Size = New System.Drawing.Size(0, 13)
        Me.Lab_pingadress.TabIndex = 12
        Me.Lab_pingadress.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 13
        '
        'Form_ScreenText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(241, 178)
        Me.ContextMenuStrip = Me.CON_menu
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lab_pingadress)
        Me.Controls.Add(Me.Lab_text)
        Me.Controls.Add(Me.Lab_ipadress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lab_pcname)
        Me.Controls.Add(Me.Lab_ping)
        Me.Controls.Add(Me.Lab_time)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_ScreenText"
        Me.Opacity = 0.4R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScreenText"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.CON_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CON_menu As ContextMenuStrip
    Friend WithEvents StandartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuchhaltungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinkaufToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerkaufToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeschäftsleitungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuftragsbearbeitungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechnungsprüfungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarketingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControllingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DispoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoststelleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManuelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarbeÄndernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnsichtbarMachenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchlissenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tim_full As Timer
    Friend WithEvents NI_stseuerung As NotifyIcon
    Friend WithEvents Timer_time As Timer
    Friend WithEvents TerminalTSM As ToolStripMenuItem
    Friend WithEvents Timer_ping As Timer
    Friend WithEvents Timer_hidden As Timer
    Friend WithEvents Lab_text As Label
    Friend WithEvents Lab_ipadress As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lab_pcname As Label
    Friend WithEvents Lab_ping As Label
    Friend WithEvents Lab_time As Label
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lab_pingadress As Label
    Friend WithEvents Label1 As Label
End Class
