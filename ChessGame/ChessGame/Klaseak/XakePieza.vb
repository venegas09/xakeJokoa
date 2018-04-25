﻿Public MustInherit Class XakePieza

    Public Sub New(PiezaKolorea As Koloreak)
        Kolorea = PiezaKolorea
    End Sub

    Property Kolorea As Koloreak


    Public MustOverride Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)

    Public Function gelaxkaLibreDago(helburuGelaxka As Gelaxka) As Boolean
        If helburuGelaxka Is Nothing Then Return False
        If helburuGelaxka.Pieza Is Nothing OrElse helburuGelaxka.Pieza.Kolorea <> Kolorea Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Function MugimenduPosibleak(mugimenduak As IEnumerable(Of Mugimendua), BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim taula As XakeTaula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        For Each mugimendua As Mugimendua In mugimenduak
            Dim helburuGelaxka As Gelaxka = taula.gelaxkaLortu(BereGelaxka, mugimendua)
            If gelaxkaLibreDago(helburuGelaxka) Then
                gelaxkaPosibleak.Add(helburuGelaxka)
            End If
        Next
        Return gelaxkaPosibleak
    End Function

    Protected Function MugimenduPosibleakNorabidekin(BereGelaxka As Gelaxka, aurreraJarraitu As Integer, eskubiraJarraitu As Integer) As IEnumerable(Of Gelaxka)

        Dim taula As XakeTaula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        Dim Aurrera As Integer = aurreraJarraitu
        Dim Eskubira As Integer = eskubiraJarraitu
        Dim Jarraitu As Boolean = True

        Do While Jarraitu
            Dim helburuGelaxka As Gelaxka = taula.gelaxkaLortu(BereGelaxka,
                    New Mugimendua() With {.Aurrera = Aurrera, .Eskubira = Eskubira})
            If gelaxkaLibreDago(helburuGelaxka) Then
                gelaxkaPosibleak.Add(helburuGelaxka)
            End If
            Jarraitu = (helburuGelaxka Is Nothing Or helburuGelaxka.Pieza IsNot Nothing)
            Aurrera += aurreraJarraitu
            Eskubira += eskubiraJarraitu
        Loop
        Return gelaxkaPosibleak
    End Function

End Class
