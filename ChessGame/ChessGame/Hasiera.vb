Public Class Hasiera
    Private Sub Hasiera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnJokatu_Click(sender As Object, e As EventArgs) Handles btnJokatu.Click
        Dim f2 As New Jokatu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btnIrekierak_Click(sender As Object, e As EventArgs) Handles btnIrekierak.Click
        Dim f2 As New PartidaIrekierak
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btnErronkak_Click(sender As Object, e As EventArgs) Handles btnErronkak.Click
        Dim f2 As New Erronkak
        f2.Show()
        Me.Hide()
    End Sub
End Class
