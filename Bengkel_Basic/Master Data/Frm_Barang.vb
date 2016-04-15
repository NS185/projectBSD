Public Class Frm_Barang

    Private Sub Frm_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PanelMid.Top = (GroupBox1.Height - PanelMid.Height) / 2
        PanelMid.Left = (GroupBox1.Width - PanelMid.Width) / 2
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Ins_Barang.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Dispose()
    End Sub

End Class