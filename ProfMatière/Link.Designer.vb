<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Link
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxChoixProf1 = New System.Windows.Forms.ComboBox()
        Me.ltxMatierenull = New System.Windows.Forms.ListBox()
        Me.ltxMatiereAdd = New System.Windows.Forms.ListBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnRetirer = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxChoixProf1
        '
        Me.cbxChoixProf1.FormattingEnabled = True
        Me.cbxChoixProf1.Location = New System.Drawing.Point(231, 101)
        Me.cbxChoixProf1.Name = "cbxChoixProf1"
        Me.cbxChoixProf1.Size = New System.Drawing.Size(121, 21)
        Me.cbxChoixProf1.TabIndex = 1
        '
        'ltxMatierenull
        '
        Me.ltxMatierenull.FormattingEnabled = True
        Me.ltxMatierenull.Location = New System.Drawing.Point(38, 206)
        Me.ltxMatierenull.Name = "ltxMatierenull"
        Me.ltxMatierenull.Size = New System.Drawing.Size(173, 173)
        Me.ltxMatierenull.TabIndex = 2
        '
        'ltxMatiereAdd
        '
        Me.ltxMatiereAdd.FormattingEnabled = True
        Me.ltxMatiereAdd.Location = New System.Drawing.Point(376, 206)
        Me.ltxMatiereAdd.Name = "ltxMatiereAdd"
        Me.ltxMatiereAdd.Size = New System.Drawing.Size(173, 173)
        Me.ltxMatiereAdd.TabIndex = 5
        '
        'btnAjouter
        '
        Me.btnAjouter.Enabled = False
        Me.btnAjouter.Location = New System.Drawing.Point(253, 249)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter -->"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnRetirer
        '
        Me.btnRetirer.Enabled = False
        Me.btnRetirer.Location = New System.Drawing.Point(253, 316)
        Me.btnRetirer.Name = "btnRetirer"
        Me.btnRetirer.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirer.TabIndex = 4
        Me.btnRetirer.Text = "<-- Retirer"
        Me.btnRetirer.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(241, 73)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(100, 13)
        Me.lblText.TabIndex = 8
        Me.lblText.Text = "Choix du professeur"
        '
        'Link
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnRetirer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.ltxMatiereAdd)
        Me.Controls.Add(Me.ltxMatierenull)
        Me.Controls.Add(Me.cbxChoixProf1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Link"
        Me.ShowIcon = False
        Me.Text = "Ajouter/Retirer une matière à un professeur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxChoixProf1 As ComboBox
    Friend WithEvents ltxMatierenull As ListBox
    Friend WithEvents ltxMatiereAdd As ListBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnRetirer As Button
    Friend WithEvents lblText As Label
End Class
