﻿Public Class Text_Editor

    Public sock As Integer
    Public pathoftext As String
    Public yy As String = "||"

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "savetextfile" & yy & pathoftext & yy & TextBox1.Text)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class