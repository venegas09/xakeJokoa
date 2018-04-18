Public MustInherit Class XakePieza

    Public Sub New(PiezaKolorea As Koloreak)
        Kolorea = PiezaKolorea
    End Sub

    Property Kolorea As Koloreak

    Property BereGelaxka As Gelaxka

    Public MustOverride Function HelburuGelaxkak() As IEnumerable(Of Gelaxka)

End Class
