<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Professeur
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
        Me.lblProfAge = New System.Windows.Forms.Label()
        Me.txtAjoutProfage = New System.Windows.Forms.TextBox()
        Me.lblProfPrenom = New System.Windows.Forms.Label()
        Me.lblProfNom = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.txtAjoutProfprenom = New System.Windows.Forms.TextBox()
        Me.txtAjoutProfNom = New System.Windows.Forms.TextBox()
        Me.ltxProf = New System.Windows.Forms.ListBox()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProfAge
        '
        Me.lblProfAge.AutoSize = True
        Me.lblProfAge.Location = New System.Drawing.Point(32, 220)
        Me.lblProfAge.Name = "lblProfAge"
        Me.lblProfAge.Size = New System.Drawing.Size(26, 13)
        Me.lblProfAge.TabIndex = 26
        Me.lblProfAge.Text = "Âge"
        '
        'txtAjoutProfage
        '
        Me.txtAjoutProfage.Location = New System.Drawing.Point(64, 217)
        Me.txtAjoutProfage.Name = "txtAjoutProfage"
        Me.txtAjoutProfage.Size = New System.Drawing.Size(192, 20)
        Me.txtAjoutProfage.TabIndex = 3
        '
        'lblProfPrenom
        '
        Me.lblProfPrenom.AutoSize = True
        Me.lblProfPrenom.Location = New System.Drawing.Point(15, 148)
        Me.lblProfPrenom.Name = "lblProfPrenom"
        Me.lblProfPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblProfPrenom.TabIndex = 24
        Me.lblProfPrenom.Text = "Prénom"
        '
        'lblProfNom
        '
        Me.lblProfNom.AutoSize = True
        Me.lblProfNom.Location = New System.Drawing.Point(29, 182)
        Me.lblProfNom.Name = "lblProfNom"
        Me.lblProfNom.Size = New System.Drawing.Size(29, 13)
        Me.lblProfNom.TabIndex = 23
        Me.lblProfNom.Text = "Nom"
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(76, 260)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(167, 23)
        Me.btnAjouter.TabIndex = 4
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'txtAjoutProfprenom
        '
        Me.txtAjoutProfprenom.Location = New System.Drawing.Point(64, 145)
        Me.txtAjoutProfprenom.Name = "txtAjoutProfprenom"
        Me.txtAjoutProfprenom.Size = New System.Drawing.Size(192, 20)
        Me.txtAjoutProfprenom.TabIndex = 1
        '
        'txtAjoutProfNom
        '
        Me.txtAjoutProfNom.Location = New System.Drawing.Point(64, 179)
        Me.txtAjoutProfNom.Name = "txtAjoutProfNom"
        Me.txtAjoutProfNom.Size = New System.Drawing.Size(192, 20)
        Me.txtAjoutProfNom.TabIndex = 2
        '
        'ltxProf
        '
        Me.ltxProf.FormattingEnabled = True
        Me.ltxProf.Location = New System.Drawing.Point(334, 133)
        Me.ltxProf.Name = "ltxProf"
        Me.ltxProf.Size = New System.Drawing.Size(187, 121)
        Me.ltxProf.TabIndex = 5
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(344, 260)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(167, 23)
        Me.btnSupprimer.TabIndex = 6
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'Professeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.ltxProf)
        Me.Controls.Add(Me.lblProfAge)
        Me.Controls.Add(Me.txtAjoutProfage)
        Me.Controls.Add(Me.lblProfPrenom)
        Me.Controls.Add(Me.lblProfNom)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.txtAjoutProfprenom)
        Me.Controls.Add(Me.txtAjoutProfNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Professeur"
        Me.ShowIcon = False
        Me.Text = "Ajouter/Supprimer un professeur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProfAge As Label
    Friend WithEvents txtAjoutProfage As TextBox
    Friend WithEvents lblProfPrenom As Label
    Friend WithEvents lblProfNom As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents txtAjoutProfprenom As TextBox
    Friend WithEvents txtAjoutProfNom As TextBox
    Friend WithEvents ltxProf As ListBox
    Friend WithEvents btnSupprimer As Button
End Class
