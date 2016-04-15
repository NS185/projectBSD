Public Class Ins_Mekanik

    Private Sub Ins_Mekanik_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub

    Private Sub btnEsc_KeyDown(sender As Object, e As KeyEventArgs) Handles btnEsc.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub
End Class