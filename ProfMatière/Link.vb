' Importe les méthodes SQL
Imports MySql.Data.MySqlClient
Public Class Link

    ' Liste déroulante des profs.
    Private Sub cbxChoixProf1_Click(sender As Object, e As EventArgs) Handles cbxChoixProf1.Click
        Try
            cbxChoixProf1.Items.Clear()
            MaConnection.Open()
            Dim CommandSQLListProf As New MySqlCommand("SELECT NumeroProf, NomProf, PrenomProf FROM prof ", MaConnection)
            MonReader = CommandSQLListProf.ExecuteReader()
            While (MonReader.Read())
                cbxChoixProf1.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1) + " " + MonReader.GetString(2))
            End While
            MaConnection.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub
    Private Sub cbxChoixProf1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxChoixProf1.SelectedIndexChanged
        Actualiser()
    End Sub

    ' Permet d'ajouter une matière à un prof
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Try

            Dim ValeurRetournee3 As String = cbxChoixProf1.SelectedItem.ToString
            Dim Valeur3 As String = InStr(cbxChoixProf1.SelectedItem, " ")
            Dim ID_profselecte3 As Int32 = ValeurRetournee3.Substring(0, Convert.ToInt16(Valeur3) - 1)

            Dim ValeurRetournee4 As String = ltxMatierenull.SelectedItem.ToString
            Dim Valeur4 As String = InStr(ltxMatierenull.SelectedItem, " ")
            Dim ID_matiereselect As Int32 = ValeurRetournee4.Substring(0, Convert.ToInt16(Valeur4) - 1)
            MaConnection.Open()
            Dim CommandSQLAjoutMatiereAProf As New MySqlCommand("INSERT INTO link SET ID_Prof = ('" & ID_profselecte3 & "'), ID_Matiere = ('" & ID_matiereselect & "')", MaConnection)


            CommandSQLAjoutMatiereAProf.ExecuteNonQuery()
            MaConnection.Close()
            btnActualiser(1)
            Actualiser()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    ' Permet d'actualiser les listes des matières (quand un prof est selectionner)
    Private Sub Actualiser()
        Try

            btnAjouter.Enabled = False
            btnRetirer.Enabled = False
            ltxMatierenull.Items.Clear()
            ltxMatiereAdd.Items.Clear()

            MaConnection.Open()
            Dim CommandSQLRefreshMatiereNull As New MySqlCommand("SELECT Numeromatiere, NomMatiere FROM Matiere WHERE NumeroMatiere not in (SELECT ID_matiere FROM link)", MaConnection)
            MonReader = CommandSQLRefreshMatiereNull.ExecuteReader()
            While (MonReader.Read())
                ltxMatierenull.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1))
            End While
            MonReader.Close()

            Dim ValeurRetourneee As String = cbxChoixProf1.SelectedItem.ToString
            Dim Valeure As String = InStr(cbxChoixProf1.SelectedItem, " ")
            Dim ID_profselect As Int32 = ValeurRetourneee.Substring(0, Convert.ToInt16(Valeure) - 1)
            Dim CommandSQLRefreshMatiere As New MySqlCommand("SELECT m.Numeromatiere, m.NomMatiere FROM Matiere m INNER JOIN link l ON(m.NumeroMatiere=l.ID_Matiere) WHERE ID_Prof=('" & ID_profselect & "') AND m.NumeroMatiere in (SELECT ID_matiere FROM link) ", MaConnection)
            MonReader = CommandSQLRefreshMatiere.ExecuteReader()
            While (MonReader.Read())
                ltxMatiereAdd.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1))
            End While
            MaConnection.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    ' Permet de retirer une matière à un prof
    Private Sub btnRetirer_Click(sender As Object, e As EventArgs) Handles btnRetirer.Click
        Try

            Dim ValeurRetournee As String = cbxChoixProf1.SelectedItem.ToString
            Dim Valeur As String = InStr(cbxChoixProf1.SelectedItem, " ")
            Dim ID_profselect As Int32 = ValeurRetournee.Substring(0, Convert.ToInt16(Valeur) - 1)

            Dim ValeurRetournee1 As String = ltxMatiereAdd.SelectedItem.ToString
            Dim Valeur1 As String = InStr(ltxMatiereAdd.SelectedItem, " ")
            Dim ID_matiereselect As Int32 = ValeurRetournee1.Substring(0, Convert.ToInt16(Valeur1) - 1)

            MaConnection.Open()
            Dim MaCommandeSql2 As New MySqlCommand("DELETE FROM link WHERE ID_Prof=('" & ID_profselect & "') AND ID_Matiere=('" & ID_matiereselect & "')", MaConnection)
            MaCommandeSql2.ExecuteNonQuery()
            MaConnection.Close()
            btnActualiser(2)
            Actualiser()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()

        End Try
    End Sub

    Private Sub ltxMatierenull_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltxMatierenull.SelectedIndexChanged
        btnActualiser(1)
    End Sub
    Private Sub ltxMatiereAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltxMatiereAdd.SelectedIndexChanged
        btnActualiser(2)
    End Sub
    Private Sub btnActualiser(int)
        If (int = 1) Then
            btnAjouter.Enabled = True
        End If
        If (int = 2) Then
            btnRetirer.Enabled = True
        End If
    End Sub
End Class