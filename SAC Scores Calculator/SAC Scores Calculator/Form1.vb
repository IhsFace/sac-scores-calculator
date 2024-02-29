﻿Imports System.IO

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intSacScore As Integer
        Dim SacScoresFile As StreamReader = File.OpenText("SacScores.txt")

        lstDisplay.Items.Clear()

        Do While SacScoresFile.Peek <> -1
            intSacScore = SacScoresFile.ReadLine()
            lstDisplay.Items.Add(intSacScore)
        Loop

        SacScoresFile.Close()
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim SacScoresFile As StreamWriter = File.AppendText("SacScores.txt")
        Dim strSacScore As String = InputBox("Enter the score to add", "Add score")

        If Val(strSacScore) >= 0 AndAlso Val(strSacScore) <= 100 Then
            SacScoresFile.WriteLine(strSacScore)
            MessageBox.Show("The name and score has been added to the text file")
        Else
            MessageBox.Show("The score must be between 0 and 100.")
        End If

        SacScoresFile.Close()
    End Sub
End Class
