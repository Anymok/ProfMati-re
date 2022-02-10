'On importe les méthodes SQL
Imports MySql.Data.MySqlClient

' Module de connexion, il permettra de demander les informations de connexion à l'utilisateur sans afficher la fênetre principale.
Module ModuleConnection
    Dim username As String = InputBox("Saisir votre identifiant")
    Dim password As String = InputBox("Saisir votre mots de passe")
    Dim connect As String = "Server=localhost;Database=profmatiere;Uid=" & username & ";pwd=" & password & ";"
    Public MaConnection As New MySqlConnection(connect)
    Public MonReader As MySqlDataReader
End Module

Public Class Application1

    ' Cette méthode se charge en tout premier lors du chargement de mon index et permet d'initialiser la fenêtre princiapl.
    Private Sub Application_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualiserIndex()
    End Sub


    ' La méthode correspondant à chaque bouton, par exemple pour le bouton AjoutProf, lors de l'event Click (donc quand quelqu'un click) la méthode s'éxécute et affiche la fenêtre Professeur.
    ' Ainsi de suite pour chaque bouton.
    Private Sub cmdAjoutProf_Click(sender As Object, e As EventArgs) Handles cmdAjoutProf.Click
        Professeur.Show()

    End Sub
    Private Sub cmdAjoutMatiere_Click(sender As Object, e As EventArgs) Handles cmdAjoutMatiere.Click
        Matière.Show()
    End Sub
    Private Sub cmdLink_Click(sender As Object, e As EventArgs) Handles cmdLink.Click
        Link.Show()

    End Sub



    ' Ma procédure ActualiserIndex, elle permet d'afficher les données dans les listbox
    Public Sub ActualiserIndex()
        Try
            ltxProf.Items.Clear()
            ltxMatiere.Items.Clear()

            MaConnection.Open()

            Dim CommandSQLMatiere As New MySqlCommand("SELECT NomMatiere FROM Matiere", MaConnection)
            MonReader = CommandSQLMatiere.ExecuteReader()
            While (MonReader.Read())
                ltxMatiere.Items.Add(MonReader.GetString(0))
            End While
            MonReader.Close()

            Dim CommandSQLProfesseur As New MySqlCommand("SELECT NomProf, PrenomProf FROM prof", MaConnection)
            MonReader = CommandSQLProfesseur.ExecuteReader()
            While (MonReader.Read())
                ltxProf.Items.Add(MonReader.GetString(0) + " " + MonReader.GetString(1))
            End While
            MonReader.Close()

            MaConnection.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            MaConnection.Close()
            Application.Exit()

        End Try

    End Sub
End Class
