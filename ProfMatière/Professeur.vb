' Importe les méthodes SQL
Imports MySql.Data.MySqlClient
Public Class Professeur

    ' Initialisation de la fenêtre professeur
    Private Sub AjoutProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualiser()
    End Sub

    ' Permet d'ajouter un nouveau professeur
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Try

            MaConnection.Open()
            Dim NomProf As String = txtAjoutProfNom.Text
            Dim PrenomProf As String = txtAjoutProfprenom.Text
            Dim AgeProf As Integer = txtAjoutProfage.Text
            Dim CommandSQLProfAjout As New MySqlCommand("INSERT INTO `prof` (`NomProf`, `PrenomProf`, `Age`) VALUES (('" & NomProf & "'), ('" & PrenomProf & "'), ('" & AgeProf & "'));", MaConnection)
            CommandSQLProfAjout.ExecuteNonQuery()
            MaConnection.Close()
            Actualiser()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    ' Suppression d'un professeur
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try

            Dim ValeurRetournee As String = ltxProf.SelectedItem.ToString
            Dim Valeur As String = InStr(ltxProf.SelectedItem, " ")
            Dim ID_profselect As Int32 = ValeurRetournee.Substring(0, Convert.ToInt16(Valeur) - 1)
            MaConnection.Open()
            Dim CommandSQLLinkDel As New MySqlCommand("DELETE FROM link WHERE ID_Prof=('" & ID_profselect & "')", MaConnection)
            Dim CommandSQLProfDel As New MySqlCommand("DELETE FROM prof WHERE Numeroprof=('" & ID_profselect & "')", MaConnection)
            CommandSQLLinkDel.ExecuteNonQuery()
            CommandSQLProfDel.ExecuteNonQuery()
            MaConnection.Close()
            btnActualiser()
            Actualiser()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    ' Actualisation des listes
    Private Sub Actualiser()
        Try

            btnSupprimer.Enabled = False
            MaConnection.Open()
            ltxProf.Items.Clear()
            Dim CommandSQLRefresh As New MySqlCommand("SELECT NumeroProf, NomProf, PrenomProf FROM prof", MaConnection)
            MonReader = CommandSQLRefresh.ExecuteReader()
            While (MonReader.Read())
                ltxProf.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1) + " " + MonReader.GetString(2))
            End While
            MaConnection.Close()
            Application1.ActualiserIndex()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    Private Sub ltxProf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltxProf.SelectedIndexChanged
        btnActualiser()
    End Sub

    Private Sub btnActualiser()
        btnSupprimer.Enabled = True
    End Sub
End Class