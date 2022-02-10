<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Application1
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
        Me.ltxMatiere = New System.Windows.Forms.ListBox()
        Me.ltxProf = New System.Windows.Forms.ListBox()
        Me.cmdLink = New System.Windows.Forms.Button()
        Me.cmdAjoutMatiere = New System.Windows.Forms.Button()
        Me.cmdAjoutProf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltxMatiere
        '
        Me.ltxMatiere.FormattingEnabled = True
        Me.ltxMatiere.Location = New System.Drawing.Point(335, 73)
        Me.ltxMatiere.Name = "ltxMatiere"
        Me.ltxMatiere.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ltxMatiere.Size = New System.Drawing.Size(187, 121)
        Me.ltxMatiere.TabIndex = 36
        '
        'ltxProf
        '
        Me.ltxProf.FormattingEnabled = True
        Me.ltxProf.Location = New System.Drawing.Point(69, 73)
        Me.ltxProf.Name = "ltxProf"
        Me.ltxProf.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ltxProf.Size = New System.Drawing.Size(187, 121)
        Me.ltxProf.TabIndex = 35
        '
        'cmdLink
        '
        Me.cmdLink.Location = New System.Drawing.Point(174, 317)
        Me.cmdLink.Name = "cmdLink"
        Me.cmdLink.Size = New System.Drawing.Size(238, 33)
        Me.cmdLink.TabIndex = 34
        Me.cmdLink.Text = "Ajouter/Retirer une matière à un professeur"
        Me.cmdLink.UseVisualStyleBackColor = True
        '
        'cmdAjoutMatiere
        '
        Me.cmdAjoutMatiere.Location = New System.Drawing.Point(335, 211)
        Me.cmdAjoutMatiere.Name = "cmdAjoutMatiere"
        Me.cmdAjoutMatiere.Size = New System.Drawing.Size(187, 33)
        Me.cmdAjoutMatiere.TabIndex = 33
        Me.cmdAjoutMatiere.Text = "Ajouter/Supprimer une matière"
        Me.cmdAjoutMatiere.UseVisualStyleBackColor = True
        '
        'cmdAjoutProf
        '
        Me.cmdAjoutProf.Location = New System.Drawing.Point(69, 211)
        Me.cmdAjoutProf.Name = "cmdAjoutProf"
        Me.cmdAjoutProf.Size = New System.Drawing.Size(187, 33)
        Me.cmdAjoutProf.TabIndex = 32
        Me.cmdAjoutProf.Text = "Ajouter/Supprimer un professeur"
        Me.cmdAjoutProf.UseVisualStyleBackColor = True
        '
        'Application1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.ltxMatiere)
        Me.Controls.Add(Me.ltxProf)
        Me.Controls.Add(Me.cmdLink)
        Me.Controls.Add(Me.cmdAjoutMatiere)
        Me.Controls.Add(Me.cmdAjoutProf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Application1"
        Me.ShowIcon = False
        Me.Text = "Application"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ltxMatiere As ListBox
    Friend WithEvents ltxProf As ListBox
    Friend WithEvents cmdLink As Button
    Friend WithEvents cmdAjoutMatiere As Button
    Friend WithEvents cmdAjoutProf As Button
End Class
