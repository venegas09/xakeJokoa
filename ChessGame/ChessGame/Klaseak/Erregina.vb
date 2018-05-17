Public Class Erregina
    Inherits XakePieza

    'Eraikitzailea.
    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    'Erreginaren helburu gelaxkak lortzen ditu 
    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing

        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, 0))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 1, 1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 0, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, 0, 1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, -1))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, 0))
        gelaxkaPosibleak.AddRange(MugimenduPosibleakNorabidekin(BereGelaxka, -1, 1))

        Return gelaxkaPosibleak

    End Function
    Public Overrides Function Erasotutakoak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing

        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 1, -1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 1, 0))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 1, 1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 0, -1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, 0, 1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, -1, -1))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, -1, 0))
        gelaxkaPosibleak.AddRange(ErasotutakoakNorabidekin(BereGelaxka, -1, 1))

        Return gelaxkaPosibleak

    End Function
End Class