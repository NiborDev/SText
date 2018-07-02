Imports System.ComponentModel

Public Class Form2
    Private Sub But_auswahl_Click(sender As Object, e As EventArgs) Handles But_auswahl.Click
        Form_ScreenText.Lab_text.Text = CB_standart.Text
        Form_ScreenText.Show()
        Form_ScreenText.Location = New Point(Screen.FromPoint(Form_ScreenText.Location).WorkingArea.Right - Form_ScreenText.Width, 0)
        Me.Hide()
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Form_ScreenText.Location = New Point(Screen.FromPoint(Form_ScreenText.Location).WorkingArea.Right - Form_ScreenText.Width, 0)
        Form_ScreenText.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.FromPoint(Me.Location).WorkingArea.Right - Me.Width, 0)
    End Sub

    Private Sub But_farb_Click(sender As Object, e As EventArgs) Handles But_farb.Click
        CB_farbe.ShowDialog()
        Form_ScreenText.Lab_text.ForeColor = CB_farbe.Color
    End Sub

    Private Sub Lab_schliessen_Click(sender As Object, e As EventArgs) Handles Lab_schliessen.Click
        Form_ScreenText.Close()
        Form_ScreenText.NI_stseuerung.Visible = False
    End Sub
End Class