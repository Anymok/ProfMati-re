' Importe les méthodes MySQL
Imports MySql.Data.MySqlClient
Public Class Matière

    ' Lors du lancement de la fenêtre matière, cette méthode s'éxécute et appelle la méthode Actualiser(), il s'agit de l'initialisation de ma fenêtre
    Private Sub AjoutMatiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualiser()
    End Sub

    ' Cette méthode permet d'ajouter une matière
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Try

            MaConnection.Open()
            Dim CommandSQLMatiereAjout As New MySqlCommand("INSERT INTO `matiere` (`NomMatiere`) VALUES ('" & txtAjoutMatiere.Text & "');", MaConnection)
            CommandSQLMatiereAjout.ExecuteNonQuery()
            MaConnection.Close()
            Actualiser()
            txtAjoutMatiere.Clear()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    ' Cette méthode permet de supprimer une matière existante
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try

            Dim ValeurRetournee As String = ltxMatiere.SelectedItem.ToString
            Dim Valeur As String = InStr(ltxMatiere.SelectedItem, " ")
            Dim ID_Matiere As Int32 = ValeurRetournee.Substring(0, Convert.ToInt16(Valeur) - 1)
            MaConnection.Open()
            Dim CommandSQLLinkDEL As New MySqlCommand("DELETE FROM link WHERE ID_Matiere=('" & ID_Matiere & "')", MaConnection)
            Dim CommandSQLMatiereDEL As New MySqlCommand("DELETE FROM matiere WHERE NumeroMatiere=('" & ID_Matiere & "')", MaConnection)
            CommandSQLLinkDEL.ExecuteNonQuery()
            CommandSQLMatiereDEL.ExecuteNonQuery()
            MaConnection.Close()
            btnActualiser()
            Actualiser()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try

    End Sub

    ' Cette méthode permet d'actualiser les listes afin d'afficher les nouvelles matières par exemple.
    Private Sub Actualiser()
        Try

            btnSupprimer.Enabled = False
            MaConnection.Open()
            ltxMatiere.Items.Clear()
            Dim CommandSQLRefresh As New MySqlCommand("SELECT NumeroMatiere, NomMatiere FROM matiere", MaConnection)
            MonReader = CommandSQLRefresh.ExecuteReader()
            While (MonReader.Read())
                ltxMatiere.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1))
            End While
            MaConnection.Close()
            Application1.ActualiserIndex()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try

    End Sub

    Private Sub ltxMatiere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltxMatiere.SelectedIndexChanged
        btnActualiser()
    End Sub

    Private Sub btnActualiser()
        btnSupprimer.Enabled = True
    End Sub

    Private Sub txtAjoutMatiere_TextChanged(sender As Object, e As EventArgs) Handles txtAjoutMatiere.TextChanged
        If (txtAjoutMatiere.Text IsNot "") Then
            btnAjouter.Enabled = True
        Else
            btnAjouter.Enabled = False
        End If
    End Sub

End Class