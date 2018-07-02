Public Class Einstellungen
    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ipswitch = "IPv4" Then
            But_IPv4.Enabled = False
            But_IPv6.Enabled = True
            Form_ScreenText.Lab_ipadress.Text = ("IPv4:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(1).ToString)
        Else
            But_IPv6.Enabled = False
            But_IPv4.Enabled = True
            Form_ScreenText.Lab_ipadress.Text = ("IPv6:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(0).ToString)
        End If
        TB_pingserver.Text = My.Settings.pingadresse

    End Sub

    Private Sub But_IPv6_Click(sender As Object, e As EventArgs) Handles But_IPv6.Click
        If My.Settings.ipswitch = "IPv4" Then
            But_IPv6.Enabled = False
            My.Settings.ipswitch = "IPv6"
            My.Settings.Save()
            But_IPv4.Enabled = True
            Form_ScreenText.Lab_ipadress.Text = ("IPv6:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(0).ToString)
        Else
            But_IPv6.Enabled = True



        End If
    End Sub

    Private Sub But_IPv4_Click(sender As Object, e As EventArgs) Handles But_IPv4.Click
        If My.Settings.ipswitch = "IPv6" Then
            But_IPv4.Enabled = False
            My.Settings.ipswitch = "IPv4"
            My.Settings.Save()
            But_IPv6.Enabled = True
            Form_ScreenText.Lab_ipadress.Text = ("IPv4:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList.GetValue(1).ToString)
        Else
            But_IPv4.Enabled = True
        End If
    End Sub

    Private Sub TB_pingserver_MouseClick(sender As Object, e As MouseEventArgs) Handles TB_pingserver.MouseClick
        TB_pingserver.Text = ("")

    End Sub

    Private Sub TB_pingserver_Leave(sender As Object, e As EventArgs) Handles TB_pingserver.Leave
    End Sub

    Private Sub But_sp_Click(sender As Object, e As EventArgs) Handles But_sp.Click
        My.Settings.pingadresse = TB_pingserver.Text
        My.Settings.Save()
    End Sub
End Class