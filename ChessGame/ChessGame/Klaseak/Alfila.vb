Public Class Alfila
    Inherits XakePieza

    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing

        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, 1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, 1))

        Return gelaxkaPosibleak

    End Function

End Class