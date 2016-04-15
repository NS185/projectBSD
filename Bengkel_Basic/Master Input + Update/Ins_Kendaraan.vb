Public Class Ins_Kendaraan

    Private Sub Ins_Kendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub

    Private Sub btnEsc_KeyDown(sender As Object, e As KeyEventArgs) Handles btnEsc.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Dispose()
    End Sub
End Class