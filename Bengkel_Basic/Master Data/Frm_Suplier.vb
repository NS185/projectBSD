Public Class Frm_Suplier

    Private Sub Frm_Suplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PanelMid.Top = (GroupBox1.Height - PanelMid.Height) / 2
        PanelMid.Left = (GroupBox1.Width - PanelMid.Width) / 2
    End Sub

    Private Sub btnClosed_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Ins_Suplier.Show()
    End Sub
End Class