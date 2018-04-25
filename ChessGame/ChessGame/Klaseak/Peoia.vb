Public Class Peoia
    Inherits XakePieza

    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        'If BereGelaxka Is Nothing Then Return Nothing
        Dim taula As New XakeTaula
        taula = BereGelaxka.Taula
        Dim HasieraPosizioan As Boolean = taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = -2, .Eskubira = 0}) Is Nothing
        Console.WriteLine(HasieraPosizioan)

        Dim gelaxkaPosibleak As New List(Of Gelaxka)

        Dim gelaxkaHelburuak = taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 1, .Eskubira = 0})
        If (gelaxkaHelburuak IsNot Nothing And gelaxkaHelburuak.Pieza Is Nothing) Then
            gelaxkaPosibleak.Add(gelaxkaHelburuak)
            If HasieraPosizioan Then
                gelaxkaHelburuak =
                    taula.gelaxkaLortu(BereGelaxka, New Mugimendua With {.Aurrera = 2, .Eskubira = 0})
                If (gelaxkaHelburuak IsNot Nothing And gelaxkaHelburuak.Pieza Is Nothing) Then
                    gelaxkaPosibleak.Add(gelaxkaHelburuak)
                End If
            End If
        End If
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

End Class
