﻿Public Class Frm_Mekanik

    Private Sub Frm_Mekanik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PanelMid.Top = (GroupBox1.Height - PanelMid.Height) / 2
        PanelMid.Left = (GroupBox1.Width - PanelMid.Width) / 2
    End Sub

    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Dispose()
    End Sub

   
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Ins_Mekanik.Show()
    End Sub
End Class