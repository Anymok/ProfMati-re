<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matière
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.ltxMatiere = New System.Windows.Forms.ListBox()
        Me.lblMatiere = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.txtAjoutMatiere = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Enabled = False
        Me.btnSupprimer.Location = New System.Drawing.Point(351, 288)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(167, 23)
        Me.btnSupprimer.TabIndex = 32
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'ltxMatiere
        '
        Me.ltxMatiere.FormattingEnabled = True
        Me.ltxMatiere.Location = New System.Drawing.Point(341, 161)
        Me.ltxMatiere.Name = "ltxMatiere"
        Me.ltxMatiere.Size = New System.Drawing.Size(187, 121)
        Me.ltxMatiere.TabIndex = 31
        '
        'lblMatiere
        '
        Me.lblMatiere.AutoSize = True
        Me.lblMatiere.Location = New System.Drawing.Point(31, 210)
        Me.lblMatiere.Name = "lblMatiere"
        Me.lblMatiere.Size = New System.Drawing.Size(42, 13)
        Me.lblMatiere.TabIndex = 34
        Me.lblMatiere.Text = "Matière"
        '
        'btnAjouter
        '
        Me.btnAjouter.Enabled = False
        Me.btnAjouter.Location = New System.Drawing.Point(79, 287)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(167, 23)
        Me.btnAjouter.TabIndex = 30
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'txtAjoutMatiere
        '
        Me.txtAjoutMatiere.Location = New System.Drawing.Point(79, 207)
        Me.txtAjoutMatiere.Name = "txtAjoutMatiere"
        Me.txtAjoutMatiere.Size = New System.Drawing.Size(192, 20)
        Me.txtAjoutMatiere.TabIndex = 27
        '
        'Matière
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.ltxMatiere)
        Me.Controls.Add(Me.lblMatiere)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.txtAjoutMatiere)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Matière"
        Me.ShowIcon = False
        Me.Text = "Ajouter/Supprimer une matière"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSupprimer As Button
    Friend WithEvents ltxMatiere As ListBox
    Friend WithEvents lblMatiere As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents txtAjoutMatiere As TextBox
End Class
