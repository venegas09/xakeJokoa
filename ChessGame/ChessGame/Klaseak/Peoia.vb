Public Class Peoia
    Inherits XakePieza

    'Eraikitzailea.
    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    'Peoiaren helburu gelaxkak lortzen ditu.
    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim taula = BereGelaxka.Taula
        'Peoia hasierako posizioan dago?
        Dim HasieraPosizioan As Boolean = taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = -2, .Eskubira = 0}) Is Nothing
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        'Aurrera bat mugitu
        Dim gelaxkaHelburuak = taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 1, .Eskubira = 0})
        If (gelaxkaHelburuak IsNot Nothing And gelaxkaHelburuak.Pieza Is Nothing) Then
            gelaxkaPosibleak.Add(gelaxkaHelburuak)
            'Hasierako posizioan baldin badago, aurrera bi mugitu.
            If HasieraPosizioan Then
                gelaxkaHelburuak =
                    taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 2, .Eskubira = 0})
                If (gelaxkaHelburuak IsNot Nothing And gelaxkaHelburuak.Pieza Is Nothing) Then
                    gelaxkaPosibleak.Add(gelaxkaHelburuak)
                End If
            End If
        End If
        'Peoia amaierako posizioan dago

        'Peoiak jateko diagonalean bat aurrera mugitzen da.
        gelaxkaHelburuak = taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 1, .Eskubira = -1})
        If (gelaxkaHelburuak IsNot Nothing AndAlso gelaxkaHelburuak.Pieza IsNot Nothing _
            AndAlso gelaxkaHelburuak.Pieza.Kolorea <> Kolorea) Then
            gelaxkaPosibleak.Add(gelaxkaHelburuak)
        End If
        gelaxkaHelburuak =
            taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 1, .Eskubira = 1})
        If gelaxkaHelburuak IsNot Nothing AndAlso gelaxkaHelburuak.Pieza IsNot Nothing _
            AndAlso gelaxkaHelburuak.Pieza.Kolorea <> Kolorea Then
            gelaxkaPosibleak.Add(gelaxkaHelburuak)
        End If

        Return gelaxkaPosibleak

    End Function

    Public Overrides Function Erasotutakoak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim taula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        Dim gelaxkaHelburuak = taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 1, .Eskubira = -1})
        If (gelaxkaHelburuak IsNot Nothing) Then
            gelaxkaPosibleak.Add(gelaxkaHelburuak)
        End If
        gelaxkaHelburuak =
            taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 1, .Eskubira = 1})
        If gelaxkaHelburuak IsNot Nothing Then
            gelaxkaPosibleak.Add(gelaxkaHelburuak)
        End If
        Return gelaxkaPosibleak
    End Function
End Class
