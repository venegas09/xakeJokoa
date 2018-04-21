Public Class Erregina
    Inherits XakePieza

    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    Public Overrides Function HelburuGelaxkak() As IEnumerable(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing

        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(1, 0))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(1, 1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(0, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(0, 1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(-1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(-1, 0))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(-1, 1))

        Return gelaxkaPosibleak

    End Function
End Class