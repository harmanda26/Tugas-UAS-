Imports System.IO

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Mywriter As StreamWriter
        Dim dialog As SaveFileDialog
        Dim selected As Boolean
        Dim filename As String

        dialog = New SaveFileDialog()
        selected = dialog.ShowDialog
        If selected = True Then
            filename = dialog.FileName
            Mywriter = File.CreateText(filename)
            Mywriter.WriteLine(txtData.Text)
            Mywriter.Close()
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim MyReader As StreamReader
        Dim dialog As OpenFileDialog
        Dim selected As Boolean
        Dim filename As String

        dialog = New OpenFileDialog
        selected = dialog.ShowDialog
        If selected = True Then
            filename = dialog.FileName
            If File.Exists(filename) Then
                MyReader = File.OpenText(filename)
                txtData.Text = MyReader.ReadToEnd
                MyReader.Close()
            End If
        Else
            MsgBox("Tidak ada file yang dipilih")
        End If
    End Sub
End Class
