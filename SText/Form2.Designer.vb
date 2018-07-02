<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.CB_standart = New System.Windows.Forms.ComboBox()
        Me.Lab_Standart = New System.Windows.Forms.Label()
        Me.But_auswahl = New System.Windows.Forms.Button()
        Me.CB_farbe = New System.Windows.Forms.ColorDialog()
        Me.But_farb = New System.Windows.Forms.Button()
        Me.Lab_schliessen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CB_standart
        '
        Me.CB_standart.FormattingEnabled = True
        Me.CB_standart.Items.AddRange(New Object() {"Buchhaltung", "Einkauf", "Verkauf", "IT", "Geschäftsleitung", "Lager", "Auftragsbearbeitung", "Rechnungsprüfung", "Marketing", "Controlling", "Dispo", "Versand", "Poststelle"})
        Me.CB_standart.Location = New System.Drawing.Point(118, 9)
        Me.CB_standart.Name = "CB_standart"
        Me.CB_standart.Size = New System.Drawing.Size(154, 21)
        Me.CB_standart.TabIndex = 1
        '
        'Lab_Standart
        '
        Me.Lab_Standart.AutoSize = True
        Me.Lab_Standart.Location = New System.Drawing.Point(12, 9)
        Me.Lab_Standart.Name = "Lab_Standart"
        Me.Lab_Standart.Size = New System.Drawing.Size(96, 13)
        Me.Lab_Standart.TabIndex = 3
        Me.Lab_Standart.Text = "Standard / Manuel"
        '
        'But_auswahl
        '
        Me.But_auswahl.Location = New System.Drawing.Point(12, 65)
        Me.But_auswahl.Name = "But_auswahl"
        Me.But_auswahl.Size = New System.Drawing.Size(260, 23)
        Me.But_auswahl.TabIndex = 4
        Me.But_auswahl.Text = "Auswählen"
        Me.But_auswahl.UseVisualStyleBackColor = True
        '
        'CB_farbe
        '
        Me.CB_farbe.Color = System.Drawing.Color.White
        '
        'But_farb
        '
        Me.But_farb.Location = New System.Drawing.Point(12, 36)
        Me.But_farb.Name = "But_farb"
        Me.But_farb.Size = New System.Drawing.Size(260, 23)
        Me.But_farb.TabIndex = 5
        Me.But_farb.Text = "Farbe ändern"
        Me.But_farb.UseVisualStyleBackColor = True
        '
        'Lab_schliessen
        '
        Me.Lab_schliessen.AutoSize = True
        Me.Lab_schliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_schliessen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lab_schliessen.Location = New System.Drawing.Point(278, 68)
        Me.Lab_schliessen.Name = "Lab_schliessen"
        Me.Lab_schliessen.Size = New System.Drawing.Size(21, 20)
        Me.Lab_schliessen.TabIndex = 6
        Me.Lab_schliessen.Text = "X"
        '
        'Form2
        '
        Me.AcceptButton = Me.But_auswahl
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 91)
        Me.Controls.Add(Me.Lab_schliessen)
        Me.Controls.Add(Me.But_farb)
        Me.Controls.Add(Me.But_auswahl)
        Me.Controls.Add(Me.Lab_Standart)
        Me.Controls.Add(Me.CB_standart)
        Me.Name = "Form2"
        Me.Text = "NiborScreenText"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_standart As ComboBox
    Friend WithEvents Lab_Standart As Label
    Friend WithEvents But_auswahl As Button
    Friend WithEvents CB_farbe As ColorDialog
    Friend WithEvents But_farb As Button
    Friend WithEvents Lab_schliessen As Label
End Class
