Imports System.Net.NetworkInformation

Public Class Form_ScreenText
    Private Sub Form_ScreenText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startpositon()
        Lab_ipadress.Text = ("IP:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(1).ToString)
        Lab_ipadress.ForeColor = Color.Red
        Lab_ipadress.Font = New Font(Lab_ipadress.Font, FontStyle.Bold)

        Lab_pcname.Text = System.Environment.MachineName


        Dim pingSender As Ping = New Ping()
        Dim reply As PingReply = pingSender.Send(My.Settings.pingadresse, 3000)
        Lab_ping.Text = "Ping: " & reply.RoundtripTime & "/ms"

        Timer_time.Start()

        If My.Settings.ipswitch = "IPv4" Then
            Einstellungen.But_IPv4.Enabled = False
            Einstellungen.But_IPv6.Enabled = True
            Lab_ipadress.Text = ("IPv4:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(1).ToString)
        Else
            Einstellungen.But_IPv6.Enabled = False
            Einstellungen.But_IPv4.Enabled = True
            Lab_ipadress.Text = ("IPv6:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(0).ToString)
        End If

    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Lab_text_DoubleClick(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Tim_full_Tick(sender As Object, e As EventArgs) Handles Tim_full.Tick
        If Me.WindowState = FormWindowState.Normal Then
            Me.ShowInTaskbar = False
        End If
    End Sub
    Private Sub SchlissenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchlissenToolStripMenuItem.Click
        NI_stseuerung.Visible = False
        Me.Close()
    End Sub
    Private Sub FarbeÄndernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarbeÄndernToolStripMenuItem.Click
        Form2.CB_farbe.ShowDialog()
        Lab_text.ForeColor = Form2.CB_farbe.Color
    End Sub
    Private Sub BuchhaltungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuchhaltungToolStripMenuItem.Click
        Lab_text.Text = ("Buchhaltung")
        startpositon()
    End Sub

    Private Sub EinkaufToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinkaufToolStripMenuItem.Click
        Lab_text.Text = ("Einkauf")
        startpositon()
    End Sub

    Private Sub VerkaufToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerkaufToolStripMenuItem.Click
        Lab_text.Text = ("Verkauf")
        startpositon()
    End Sub

    Private Sub ITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITToolStripMenuItem.Click
        Lab_text.Text = ("IT")
        startpositon()
    End Sub

    Private Sub GeschäftsleitungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeschäftsleitungToolStripMenuItem.Click
        Lab_text.Text = ("Geschäftsleitung")
        startpositon()
    End Sub

    Private Sub LagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LagerToolStripMenuItem.Click
        Lab_text.Text = ("Lager")
        startpositon()
    End Sub

    Private Sub AuftragsbearbeitungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuftragsbearbeitungToolStripMenuItem.Click
        Lab_text.Text = ("Auftragsbearbeitung")
        startpositon()
    End Sub

    Private Sub RechnungsprüfungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechnungsprüfungToolStripMenuItem.Click
        Lab_text.Text = ("Rechnungsbearbeitung")
        startpositon()
    End Sub

    Private Sub MarketingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarketingToolStripMenuItem.Click
        Lab_text.Text = ("Marketing")
        startpositon()
    End Sub

    Private Sub ControllingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControllingToolStripMenuItem.Click
        Lab_text.Text = ("Controlling")
        startpositon()
    End Sub

    Private Sub DispoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispoToolStripMenuItem.Click
        Lab_text.Text = ("Dispo")
        startpositon()
    End Sub

    Private Sub PoststelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoststelleToolStripMenuItem.Click
        Lab_text.Text = ("Poststelle")
        startpositon()
    End Sub

    Private Sub ManuelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManuelToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub UnsichtbarMachenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnsichtbarMachenToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = True
    End Sub

    Private Function startpositon()
        Me.Location = New Point(Screen.FromPoint(Me.Location).WorkingArea.Right - Me.Width, 0)
    End Function

    Private Sub Timer_time_Tick(sender As Object, e As EventArgs) Handles Timer_time.Tick
        Lab_time.Text = ("Uhrzeit:" & System.DateTime.Now.ToString("T"))
    End Sub

    Private Sub TerminalTSM_Click(sender As Object, e As EventArgs) Handles TerminalTSM.Click
        Dim Terminalp As New ProcessStartInfo("cmd.exe")
        Terminalp.Arguments = "/c echo SText start cmd.exe"
        Terminalp.Arguments = "/c start cmd.exe"
        Terminalp.WindowStyle = ProcessWindowStyle.Normal
        Process.Start(Terminalp)
    End Sub

    Private Sub Timer_ping_Tick(sender As Object, e As EventArgs) Handles Timer_ping.Tick
        Dim pingSender As Ping = New Ping()
        Dim reply As PingReply = pingSender.Send(My.Settings.pingadresse, 3000)
        Lab_ping.Text = "Ping: " & reply.RoundtripTime & "/ms"
    End Sub

    Private Sub Form_ScreenText_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover, Label2.MouseHover, Lab_time.MouseHover, Lab_text.MouseHover, Lab_ping.MouseHover, Lab_pcname.MouseHover, Lab_ipadress.MouseHover
        Me.Hide()

        Timer_hidden.Start()
    End Sub

    Private Sub Timer_hidden_Tick(sender As Object, e As EventArgs) Handles Timer_hidden.Tick
        Me.Show()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Einstellungen.Show()

    End Sub

    Private Sub Lab_text_Click(sender As Object, e As EventArgs) Handles Lab_text.Click

    End Sub
End Class
