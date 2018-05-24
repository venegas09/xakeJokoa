Imports System.Math
Public Class XakeTaula
    Inherits List(Of Gelaxka)
    Public Sub New()
        For ilara = 1 To 8
            For zutabea = 1 To 8
                Add(New Gelaxka(Me, ilara, zutabea))
            Next
        Next
        Rotazioa = Koloreak.Txuria
    End Sub

    Property Rotazioa As Koloreak

    'Ilara eta zutabe bat emanda gelaxka bat itzultzen du
    Public Function gelaxkaLortu(ilara As Integer, zutabea As Integer) As Gelaxka
        Return Me.FirstOrDefault(Function(s) s.Ilara = ilara And s.Zutabea = zutabea)
    End Function

    'Gelaxka bat eta mugimendu bat emanda, gelaxka bat itzultzen du
    Public Function gelaxkaLortu(fromGelaxka As Gelaxka, move As Mugimendua) As Gelaxka
        Dim pieza = fromGelaxka.Pieza
        If pieza Is Nothing Then
            Return Nothing
        End If
        Return gelaxkaLortu(fromGelaxka.Ilara + IIf(pieza.Kolorea = Rotazioa, move.Aurrera, -move.Aurrera), fromGelaxka.Zutabea + move.Eskubira)
    End Function


    Public Sub Init()
        TaulaGarbitu()
        Dim behekoKolorea As Koloreak =
            IIf(Rotazioa = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        ' Erregeak
        Dim column As Integer = IIf(Rotazioa = Koloreak.Txuria, 5, 4)
        gelaxkaLortu(1, column).Pieza = New Erregea(Rotazioa)
        gelaxkaLortu(8, column).Pieza = New Erregea(behekoKolorea)

        ' Damak
        column = IIf(column = 5, 4, 5)
        gelaxkaLortu(1, column).Pieza = New Erregina(Rotazioa)
        gelaxkaLortu(8, column).Pieza = New Erregina(behekoKolorea)
        ' Dorreak
        gelaxkaLortu(1, 1).Pieza = New Dorrea(Rotazioa)
        gelaxkaLortu(1, 8).Pieza = New Dorrea(Rotazioa)
        gelaxkaLortu(8, 1).Pieza = New Dorrea(behekoKolorea)
        gelaxkaLortu(8, 8).Pieza = New Dorrea(behekoKolorea)
        ' Zaldiak
        gelaxkaLortu(1, 2).Pieza = New Zaldia(Rotazioa)
        gelaxkaLortu(1, 7).Pieza = New Zaldia(Rotazioa)
        gelaxkaLortu(8, 2).Pieza = New Zaldia(behekoKolorea)
        gelaxkaLortu(8, 7).Pieza = New Zaldia(behekoKolorea)
        ' Alfila
        gelaxkaLortu(1, 3).Pieza = New Alfila(Rotazioa)
        gelaxkaLortu(1, 6).Pieza = New Alfila(Rotazioa)
        gelaxkaLortu(8, 3).Pieza = New Alfila(behekoKolorea)
        gelaxkaLortu(8, 6).Pieza = New Alfila(behekoKolorea)
        ' Peoiak
        For i = 1 To 8
            gelaxkaLortu(2, i).Pieza = New Peoia(Rotazioa)
            gelaxkaLortu(7, i).Pieza = New Peoia(behekoKolorea)
        Next
    End Sub

    'Taula hasieratzen du pasatutako kolorearekin.
    Public Sub Init(colorOfTopPlayer As Koloreak)
        Rotazioa = colorOfTopPlayer
        Init()
    End Sub

    'Kolore bat emanda, erasotzen dituen gelaxka guztiak itzultzen ditu.
    Public Function LortuErasotutakoGelaxkaGuztiak(BereKolorea As Koloreak) As List(Of Gelaxka)
        Dim list As New List(Of Gelaxka)
        For Each laukia As Gelaxka In Me
            If laukia.Pieza IsNot Nothing AndAlso laukia.Pieza.Kolorea = BereKolorea Then
                If laukia.Pieza.Erasotutakoak(laukia) IsNot Nothing Then
                    For Each la As Gelaxka In laukia.Pieza.Erasotutakoak(laukia)
                        list.Add(la)
                    Next
                End If
            End If
        Next
        Return list
    End Function

    'Gelaxka bat emanda kolore horrek erasotzen duen itzultzen du
    Public Function ErasotutaDago(g As Gelaxka, k As Koloreak) As Boolean
        For Each laukia As Gelaxka In LortuErasotutakoGelaxkaGuztiak(k)
            If laukia.Ilara = g.Ilara And laukia.Zutabea = g.Zutabea Then
                Return True
            End If
        Next
        Return False
    End Function

    'Xakea den itzultzen du, kolorea da mugitu egin duena eta xakea geratu den kolorea kontrakoa izan behar da.
    Public Function XakeaDa(k As Koloreak) As Boolean
        Dim Txanda As Koloreak
        Txanda = IIf(k = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        For Each laukia As Gelaxka In LortuErasotutakoGelaxkaGuztiak(k)
            If laukia.Pieza IsNot Nothing AndAlso laukia.Pieza.GetType.Name = "Erregea" AndAlso laukia.Pieza.Kolorea = Txanda Then
                Return True
            End If
        Next
        Return False
    End Function

    'Pieza kentzean Erregea xakean geratzen den itzultzen du.
    Public Function XakeaDaPiezaKentzean(k As Koloreak) As Boolean
        Dim Txanda As Koloreak
        Txanda = IIf(k = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        For Each laukia As Gelaxka In LortuErasotutakoGelaxkaGuztiak(Txanda)
            If laukia.Pieza IsNot Nothing AndAlso laukia.Pieza.GetType.Name = "Erregea" AndAlso laukia.Pieza.Kolorea = k Then
                Return True
            End If
        Next
        Return False
    End Function

    'Pasatako koloreak mugimendurik duen itzultzen du.
    Public Function MugimendurikEz(k As Koloreak) As Boolean
        Dim kol As Koloreak
        kol = IIf(k = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        Dim list As New List(Of Gelaxka)
        For Each laukia As Gelaxka In Me
            If laukia.Pieza IsNot Nothing AndAlso laukia.Pieza.Kolorea = kol Then
                If laukia.Pieza.HelburuGelaxkak(laukia) IsNot Nothing Then
                    For Each la As Gelaxka In laukia.Pieza.HelburuGelaxkak(laukia)
                        list.Add(la)
                    Next
                End If
            End If
        Next
        If list.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    'Pieza bat gelaxka batetik bestera mugitzen du.
    Public Function Move(fromSquare As Gelaxka, toSquare As Gelaxka) As Boolean
        If fromSquare IsNot Nothing AndAlso toSquare IsNot Nothing _
            AndAlso fromSquare.Pieza IsNot Nothing Then
            toSquare.Pieza = fromSquare.Pieza
            toSquare.Pieza.Mugituta = True
            fromSquare.Pieza = Nothing
            'Enroke egon den aztertu
            If toSquare.Pieza.GetType.Name = "Erregea" AndAlso Math.Abs(fromSquare.Zutabea - toSquare.Zutabea) = 2 Then
                Console.WriteLine("Enroke egin da")
                Dim taula = fromSquare.Taula
                If toSquare.Ilara = 1 Then
                    If toSquare.Zutabea = 2 Then
                        Move(taula.gelaxkaLortu(1, 1), taula.gelaxkaLortu(1, 3))
                    End If
                    If toSquare.Zutabea = 3 Then
                        Move(taula.gelaxkaLortu(1, 1), taula.gelaxkaLortu(1, 4))
                    End If
                    If toSquare.Zutabea = 6 Then
                        Move(taula.gelaxkaLortu(1, 8), taula.gelaxkaLortu(1, 5))
                    End If
                    If toSquare.Zutabea = 7 Then
                        Move(taula.gelaxkaLortu(1, 8), taula.gelaxkaLortu(1, 6))
                    End If
                End If
                If toSquare.Ilara = 8 Then
                    If toSquare.Zutabea = 2 Then
                        Move(taula.gelaxkaLortu(8, 1), taula.gelaxkaLortu(8, 3))
                    End If
                    If toSquare.Zutabea = 3 Then
                        Move(taula.gelaxkaLortu(8, 1), taula.gelaxkaLortu(8, 4))
                    End If
                    If toSquare.Zutabea = 6 Then
                        Move(taula.gelaxkaLortu(8, 8), taula.gelaxkaLortu(8, 5))
                    End If
                    If toSquare.Zutabea = 7 Then
                        Move(taula.gelaxkaLortu(8, 8), taula.gelaxkaLortu(8, 6))
                    End If
                End If
                Return True
            End If
            Return False
        End If
    End Function

    'Taulatik piezak kendu
    Private Sub TaulaGarbitu()
        For Each item As Gelaxka In Me
            item.Pieza = Nothing
        Next
    End Sub
End Class
