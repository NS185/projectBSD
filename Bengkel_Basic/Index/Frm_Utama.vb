Public Class Frm_Utama

    Private Sub Frm_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    'DISABLE DOUBLE CLICK MAXIMIZED TITLEBAR FORM
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub

    'SHOW FORM ON MIDDLE PANEL
    Private Sub M_BtnBarang_Click(sender As Object, e As EventArgs) Handles M_BtnBarang.Click
        Dim frmbrg As New Frm_Barang
        frmbrg.TopLevel = False
        MidPanel.Controls.Clear()
        MidPanel.Controls.Add(frmbrg)
        frmbrg.Show()
    End Sub

    Private Sub M_BtnPelanggan_Click(sender As Object, e As EventArgs) Handles M_BtnPelanggan.Click
        Dim frmplg As New Frm_Pelanggan
        frmplg.TopLevel = False
        MidPanel.Controls.Clear()
        MidPanel.Controls.Add(frmplg)
        frmplg.Show()
    End Sub

    Private Sub M_BtnSuplier_Click(sender As Object, e As EventArgs) Handles M_BtnSuplier.Click
        Dim frmsup As New Frm_Suplier
        frmsup.TopLevel = False
        MidPanel.Controls.Clear()
        MidPanel.Controls.Add(frmsup)
        frmsup.Show()
    End Sub

    Private Sub M_BtnUser_Click(sender As Object, e As EventArgs) Handles M_BtnUser.Click

    End Sub

    Private Sub M_BtnMekanik_Click(sender As Object, e As EventArgs) Handles M_BtnMekanik.Click
        Dim frmmk As New Frm_Mekanik
        frmmk.TopLevel = False
        MidPanel.Controls.Clear()
        MidPanel.Controls.Add(frmmk)
        frmmk.Show()
    End Sub

    Private Sub M_BtnKendaraan_Click(sender As Object, e As EventArgs) Handles M_BtnKendaraan.Click
        Dim frmken As New Frm_Kendaraan
        frmken.TopLevel = False
        MidPanel.Controls.Clear()
        MidPanel.Controls.Add(frmken)
        frmken.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Jam.Text = Format(Now, "HH:mm:ss")
        Hari.Text = Format(Now, "dddd")
        Tanggal.Text = Format(Now, "dd/MM/yyyy")
    End Sub

   
End Class