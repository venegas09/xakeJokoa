Public Class Erregea
    Inherits XakePieza
    'Eraikitzailea.
    Public Sub New(kolorea As Koloreak)
        MyBase.New(kolorea)
    End Sub

    'Erregeak egin ditzaken mugimenduak
    Private mugimenduak As Mugimendua() = {
            New Mugimendua() With {.Aurrera = 1, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = 1, .Eskubira = 0},
            New Mugimendua() With {.Aurrera = 1, .Eskubira = 1},
            New Mugimendua() With {.Aurrera = 0, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = 0, .Eskubira = 1},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = 0},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = 1}
        }


    'Aurreko mugimenduak kontuan hartuz, bere helburu gelaxkak lortu
    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim taula = BereGelaxka.Taula
        Dim Txanda As Koloreak
        Txanda = IIf(Kolorea = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        For Each la As Gelaxka In MugimenduPosibleak(mugimenduak, BereGelaxka)
            If Not taula.ErasotutaDago(la, Txanda) Then
                gelaxkaPosibleak.Add(la)
            End If
        Next
        'Enrokea, hau egiteko hainbat kondizio bete behar dira.
        If Not Mugituta Then
            Dim DorreaNon As Gelaxka
            If Kolorea = Koloreak.Txuria Then
                'Enroke motza txuria
                If taula.Rotazioa = Koloreak.Txuria Then
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 6), Txanda) AndAlso taula.gelaxkaLortu(1, 6).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 7), Txanda) AndAlso taula.gelaxkaLortu(1, 7).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(1, 8)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(1, 7))
                        End If
                    End If
                Else
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 3), Txanda) AndAlso taula.gelaxkaLortu(8, 3).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 2), Txanda) AndAlso taula.gelaxkaLortu(8, 2).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(8, 1)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(8, 2))
                        End If
                    End If
                End If
                'Enroke luzea txuria
                If taula.Rotazioa = Koloreak.Txuria Then
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 4), Txanda) AndAlso taula.gelaxkaLortu(1, 4).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 3), Txanda) AndAlso taula.gelaxkaLortu(1, 3).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(1, 1)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(1, 3))
                        End If
                    End If
                Else
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 5), Txanda) AndAlso taula.gelaxkaLortu(8, 5).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 6), Txanda) AndAlso taula.gelaxkaLortu(8, 6).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(8, 8)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(8, 6))
                        End If
                    End If
                End If
            Else
                'Enroke motza beltza
                If taula.Rotazioa = Koloreak.Txuria Then
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 6), Txanda) AndAlso taula.gelaxkaLortu(8, 6).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 7), Txanda) AndAlso taula.gelaxkaLortu(8, 7).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(8, 8)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(8, 7))
                        End If
                    End If
                Else
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 2), Txanda) AndAlso taula.gelaxkaLortu(1, 2).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 3), Txanda) AndAlso taula.gelaxkaLortu(1, 3).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(1, 1)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(1, 2))
                        End If
                    End If
                End If
                'Enroke luzea beltza
                If taula.Rotazioa = Koloreak.Txuria Then
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 4), Txanda) AndAlso taula.gelaxkaLortu(8, 4).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(8, 3), Txanda) AndAlso taula.gelaxkaLortu(8, 3).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(8, 1)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(8, 3))
                        End If
                    End If
                Else
                    If Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 5), Txanda) AndAlso taula.gelaxkaLortu(1, 5).Pieza Is Nothing AndAlso Not taula.ErasotutaDago(taula.gelaxkaLortu(1, 6), Txanda) AndAlso taula.gelaxkaLortu(1, 6).Pieza Is Nothing Then
                        DorreaNon = taula.gelaxkaLortu(1, 8)
                        If DorreaNon.Pieza IsNot Nothing AndAlso DorreaNon.Pieza.Kolorea = Kolorea AndAlso DorreaNon.Pieza.GetType().Name = "Dorrea" AndAlso Not DorreaNon.Pieza.Mugituta Then
                            gelaxkaPosibleak.Add(taula.gelaxkaLortu(1, 6))
                        End If
                    End If
                End If

            End If
        End If
        Return gelaxkaPosibleak
    End Function
    'Erregeak erasotzen dituen gelaxkak lortzen dira.
    Public Overrides Function Erasotutakoak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        For Each la As Gelaxka In ErasoPosibleak(mugimenduak, BereGelaxka)
            gelaxkaPosibleak.Add(la)
        Next
        Return gelaxkaPosibleak
    End Function
End Class
