<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
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
        Me.But_IPv6 = New System.Windows.Forms.Button()
        Me.But_IPv4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_pingserver = New System.Windows.Forms.TextBox()
        Me.But_sp = New System.Windows.Forms.Button()
        Me.Lab_padress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'But_IPv6
        '
        Me.But_IPv6.Location = New System.Drawing.Point(84, 12)
        Me.But_IPv6.Name = "But_IPv6"
        Me.But_IPv6.Size = New System.Drawing.Size(75, 23)
        Me.But_IPv6.TabIndex = 0
        Me.But_IPv6.Text = "IPv6"
        Me.But_IPv6.UseVisualStyleBackColor = True
        '
        'But_IPv4
        '
        Me.But_IPv4.Enabled = False
        Me.But_IPv4.Location = New System.Drawing.Point(12, 12)
        Me.But_IPv4.Name = "But_IPv4"
        Me.But_IPv4.Size = New System.Drawing.Size(75, 23)
        Me.But_IPv4.TabIndex = 1
        Me.But_IPv4.Text = "IPv4"
        Me.But_IPv4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'TB_pingserver
        '
        Me.TB_pingserver.Location = New System.Drawing.Point(74, 49)
        Me.TB_pingserver.Name = "TB_pingserver"
        Me.TB_pingserver.Size = New System.Drawing.Size(85, 20)
        Me.TB_pingserver.TabIndex = 3
        Me.TB_pingserver.Text = "www.google.de"
        Me.TB_pingserver.WordWrap = False
        '
        'But_sp
        '
        Me.But_sp.Location = New System.Drawing.Point(12, 78)
        Me.But_sp.Name = "But_sp"
        Me.But_sp.Size = New System.Drawing.Size(147, 23)
        Me.But_sp.TabIndex = 4
        Me.But_sp.Text = "Speichern"
        Me.But_sp.UseVisualStyleBackColor = True
        '
        'Lab_padress
        '
        Me.Lab_padress.AutoSize = True
        Me.Lab_padress.Location = New System.Drawing.Point(0, 52)
        Me.Lab_padress.Name = "Lab_padress"
        Me.Lab_padress.Size = New System.Drawing.Size(68, 13)
        Me.Lab_padress.TabIndex = 5
        Me.Lab_padress.Text = "Pingadresse:"
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(172, 113)
        Me.Controls.Add(Me.Lab_padress)
        Me.Controls.Add(Me.But_sp)
        Me.Controls.Add(Me.TB_pingserver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.But_IPv4)
        Me.Controls.Add(Me.But_IPv6)
        Me.Name = "Einstellungen"
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But_IPv6 As Button
    Friend WithEvents But_IPv4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_pingserver As TextBox
    Friend WithEvents But_sp As Button
    Friend WithEvents Lab_padress As Label
End Class
