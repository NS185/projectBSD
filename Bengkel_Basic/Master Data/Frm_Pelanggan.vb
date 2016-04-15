Public Class Frm_Pelanggan

    Private Sub Frm_Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PanelMid.Top = (GroupBox1.Height - PanelMid.Height) / 2
        PanelMid.Left = (GroupBox1.Width - PanelMid.Width) / 2
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        Ins_Pelanggan.Show()
    End Sub

    Private Sub btnInsert_Click_1(sender As Object, e As EventArgs) Handles btnInsert.Click
        Ins_Pelanggan.Show()
    End Sub
End Class