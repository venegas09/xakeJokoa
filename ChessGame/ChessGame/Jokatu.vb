Public Class Jokatu
    Private Partida As New XakePartida()
    Private MarraztutakoGelaxkak As New List(Of Gelaxka)
    Private AukeratutakoBox As New Object()
    Private Sub Jokatu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Hasteko botoia
    Private Sub btnHasi_Click(sender As Object, e As EventArgs) Handles btnHasi.Click
        LaukiakGarbitu()
        If rbTxuria.Checked Then
            Partida.Start(Koloreak.Txuria)
            Hasieratu(Koloreak.Txuria)
            pTableroa.BackgroundImage = My.Resources.XakeTaula
        Else
            Partida.Start(Koloreak.Beltza)
            Hasieratu(Koloreak.Beltza)
            pTableroa.BackgroundImage = My.Resources.XakeTaula2
        End If
        btnHasi.Enabled = False
        btnTablas.Enabled = True
        btnErrenditu.Enabled = True
    End Sub
    'Tableroaren irudiak hasieratzen ditu.
    Public Sub Hasieratu(Kolorea As Koloreak)
        a3.Image = Nothing
        b4.Image = Nothing
        c3.Image = Nothing
        d3.Image = Nothing
        e3.Image = Nothing
        h3.Image = Nothing
        g3.Image = Nothing
        f3.Image = Nothing
        a4.Image = Nothing
        b4.Image = Nothing
        c4.Image = Nothing
        d4.Image = Nothing
        e4.Image = Nothing
        f4.Image = Nothing
        g4.Image = Nothing
        h4.Image = Nothing
        a5.Image = Nothing
        b5.Image = Nothing
        c5.Image = Nothing
        d5.Image = Nothing
        e5.Image = Nothing
        h5.Image = Nothing
        g5.Image = Nothing
        f5.Image = Nothing
        a6.Image = Nothing
        b6.Image = Nothing
        c6.Image = Nothing
        d6.Image = Nothing
        e6.Image = Nothing
        f6.Image = Nothing
        g6.Image = Nothing
        h6.Image = Nothing
        If Kolorea = Koloreak.Txuria Then
            a1.Image = My.Resources.Dorrea_T
            b1.Image = My.Resources.Zaldia_T
            c1.Image = My.Resources.Alfila_T
            d1.Image = My.Resources.Erregina_T
            e1.Image = My.Resources.Erregea_T
            h1.Image = My.Resources.Dorrea_T
            g1.Image = My.Resources.Zaldia_T
            f1.Image = My.Resources.Alfila_T
            a2.Image = My.Resources.Peoia_T
            b2.Image = My.Resources.Peoia_T
            c2.Image = My.Resources.Peoia_T
            d2.Image = My.Resources.Peoia_T
            e2.Image = My.Resources.Peoia_T
            f2.Image = My.Resources.Peoia_T
            g2.Image = My.Resources.Peoia_T
            h2.Image = My.Resources.Peoia_T
            a8.Image = My.Resources.Dorrea_B
            b8.Image = My.Resources.Zaldia_B
            c8.Image = My.Resources.Alfila_B
            d8.Image = My.Resources.Erregina_B
            e8.Image = My.Resources.Erregea_B
            h8.Image = My.Resources.Dorrea_B
            g8.Image = My.Resources.Zaldia_B
            f8.Image = My.Resources.Alfila_B
            a7.Image = My.Resources.Peoia_B
            b7.Image = My.Resources.Peoia_B
            c7.Image = My.Resources.Peoia_B
            d7.Image = My.Resources.Peoia_B
            e7.Image = My.Resources.Peoia_B
            f7.Image = My.Resources.Peoia_B
            g7.Image = My.Resources.Peoia_B
            h7.Image = My.Resources.Peoia_B
        Else
            a1.Image = My.Resources.Dorrea_B
            b1.Image = My.Resources.Zaldia_B
            c1.Image = My.Resources.Alfila_B
            d1.Image = My.Resources.Erregea_B
            e1.Image = My.Resources.Erregina_B
            h1.Image = My.Resources.Dorrea_B
            g1.Image = My.Resources.Zaldia_B
            f1.Image = My.Resources.Alfila_B
            a2.Image = My.Resources.Peoia_B
            b2.Image = My.Resources.Peoia_B
            c2.Image = My.Resources.Peoia_B
            d2.Image = My.Resources.Peoia_B
            e2.Image = My.Resources.Peoia_B
            f2.Image = My.Resources.Peoia_B
            g2.Image = My.Resources.Peoia_B
            h2.Image = My.Resources.Peoia_B
            a8.Image = My.Resources.Dorrea_T
            b8.Image = My.Resources.Zaldia_T
            c8.Image = My.Resources.Alfila_T
            d8.Image = My.Resources.Erregea_T
            e8.Image = My.Resources.Erregina_T
            h8.Image = My.Resources.Dorrea_T
            g8.Image = My.Resources.Zaldia_T
            f8.Image = My.Resources.Alfila_T
            a7.Image = My.Resources.Peoia_T
            b7.Image = My.Resources.Peoia_T
            c7.Image = My.Resources.Peoia_T
            d7.Image = My.Resources.Peoia_T
            e7.Image = My.Resources.Peoia_T
            f7.Image = My.Resources.Peoia_T
            g7.Image = My.Resources.Peoia_T
            h7.Image = My.Resources.Peoia_T
        End If

    End Sub
    'MarraztutakoGelaxka listan dauden gelaxkak margotzen ditu.
    Public Sub Marraztu()
        For Each laukia As Gelaxka In MarraztutakoGelaxkak
            '1 ILARA
            If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
                a1.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
                b1.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
                c1.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
                d1.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
                e1.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
                f1.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
                g1.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
                h1.BackgroundImage = My.Resources.posibleT
            End If
            '2 ILARA
            If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
                a2.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
                b2.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
                c2.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
                d2.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
                e2.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
                f2.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
                g2.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
                h2.BackgroundImage = My.Resources.posibleB
            End If
            '3 ILARA
            If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
                a3.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
                b3.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
                c3.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
                d3.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
                e3.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
                f3.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
                g3.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
                h3.BackgroundImage = My.Resources.posibleT
            End If
            '4ILARA
            If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
                a4.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
                b4.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
                c4.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
                d4.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
                e4.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
                f4.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
                g4.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
                h4.BackgroundImage = My.Resources.posibleB
            End If
            '5 ILARA
            If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
                a5.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
                b5.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
                c5.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
                d5.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
                e5.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
                f5.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
                g5.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
                h5.BackgroundImage = My.Resources.posibleT
            End If
            '6 ILARA
            If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
                a6.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
                b6.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
                c6.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
                d6.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
                e6.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
                f6.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
                g6.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
                h6.BackgroundImage = My.Resources.posibleB
            End If
            '7 ILARA
            If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
                a7.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
                b7.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
                c7.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
                d7.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
                e7.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
                f7.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
                g7.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
                h7.BackgroundImage = My.Resources.posibleT
            End If
            '8 ILARA
            If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
                a8.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
                b8.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
                c8.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
                d8.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
                e8.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
                f8.BackgroundImage = My.Resources.posibleB
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
                g8.BackgroundImage = My.Resources.posibleT
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
                h8.BackgroundImage = My.Resources.posibleB
            End If
        Next
    End Sub
    'Marraztuta dauden gelaxkak margotzen ditu.
    Public Sub MarrazkiaKendu()
        For Each laukia As Gelaxka In MarraztutakoGelaxkak
            '1 ILARA
            If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
                a1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
                b1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
                c1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
                d1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
                e1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
                f1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
                g1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
                h1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '2 ILARA
            If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
                a2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
                b2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
                c2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
                d2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
                e2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
                f2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
                g2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
                h2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            '3 ILARA
            If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
                a3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
                b3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
                c3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
                d3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
                e3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
                f3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
                g3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
                h3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '4ILARA
            If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
                a4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
                b4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
                c4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
                d4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
                e4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
                f4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
                g4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
                h4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            '5 ILARA
            If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
                a5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
                b5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
                c5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
                d5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
                e5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
                f5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
                g5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
                h5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '6 ILARA
            If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
                a6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
                b6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
                c6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
                d6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
                e6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
                f6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
                g6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
                h6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            '7 ILARA
            If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
                a7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
                b7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
                c7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
                d7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
                e7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
                f7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
                g7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
                h7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '8 ILARA
            If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
                a8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
                b8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
                c8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
                d8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
                e8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
                f8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
                g8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
                h8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
        Next
    End Sub
    'Laukiak hasierako egoeran margotuta uzten ditu
    Public Sub LaukiakGarbitu()
        For Each laukia As Gelaxka In Partida.Taula
            '1 ILARA
            If laukia.Ilara = 1 And laukia.Zutabea = 1 Then
                a1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 2 Then
                b1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
                c1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
                d1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
                e1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
                f1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 7 Then
                g1.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 1 And laukia.Zutabea = 8 Then
                h1.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '2 ILARA
            If laukia.Ilara = 2 And laukia.Zutabea = 1 Then
                a2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 2 Then
                b2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 3 Then
                c2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 4 Then
                d2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 5 Then
                e2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 6 Then
                f2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 7 Then
                g2.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 2 And laukia.Zutabea = 8 Then
                h2.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            '3 ILARA
            If laukia.Ilara = 3 And laukia.Zutabea = 1 Then
                a3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 2 Then
                b3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 3 Then
                c3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 4 Then
                d3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 5 Then
                e3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 6 Then
                f3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 7 Then
                g3.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 3 And laukia.Zutabea = 8 Then
                h3.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '4ILARA
            If laukia.Ilara = 4 And laukia.Zutabea = 1 Then
                a4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 2 Then
                b4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 3 Then
                c4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 4 Then
                d4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 5 Then
                e4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 6 Then
                f4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 7 Then
                g4.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 4 And laukia.Zutabea = 8 Then
                h4.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            '5 ILARA
            If laukia.Ilara = 5 And laukia.Zutabea = 1 Then
                a5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 2 Then
                b5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 3 Then
                c5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 4 Then
                d5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 5 Then
                e5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 6 Then
                f5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 7 Then
                g5.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 5 And laukia.Zutabea = 8 Then
                h5.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '6 ILARA
            If laukia.Ilara = 6 And laukia.Zutabea = 1 Then
                a6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 2 Then
                b6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 3 Then
                c6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 4 Then
                d6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 5 Then
                e6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 6 Then
                f6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 7 Then
                g6.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 6 And laukia.Zutabea = 8 Then
                h6.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            '7 ILARA
            If laukia.Ilara = 7 And laukia.Zutabea = 1 Then
                a7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 2 Then
                b7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 3 Then
                c7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 4 Then
                d7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 5 Then
                e7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 6 Then
                f7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 7 Then
                g7.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 7 And laukia.Zutabea = 8 Then
                h7.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            '8 ILARA
            If laukia.Ilara = 8 And laukia.Zutabea = 1 Then
                a8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 2 Then
                b8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
                c8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
                d8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
                e8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
                f8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 7 Then
                g8.BackgroundImage = My.Resources.gelaxkaTxuria
            End If
            If laukia.Ilara = 8 And laukia.Zutabea = 8 Then
                h8.BackgroundImage = My.Resources.gelaxkaBeltza
            End If
        Next
    End Sub
    'Dorrea dagokion tokian jartzen du
    Public Sub DorreaJarri(laukia As Gelaxka)
        If laukia.Ilara = 1 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            c1.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            d1.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            e1.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 1 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            f1.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        '8 ILARA
        If laukia.Ilara = 8 And laukia.Zutabea = 3 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            c8.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 4 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            d8.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 5 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            e8.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
        If laukia.Ilara = 8 And laukia.Zutabea = 6 Then
            Dim irudia As String = String.Format("{0}_{1}", "Dorrea", IIf([Enum].GetName(GetType(Koloreak), laukia.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
            f8.Image = My.Resources.ResourceManager.GetObject(irudia)
        End If
    End Sub
    'Dorrea dagoen tokitik kentzen du
    Public Sub DorreaKendu(Ilara As Integer, Zutabea As Integer)
        '1 ILARA
        If Ilara = 1 And Zutabea = 1 Then
            a1.Image = Nothing
        End If
        If Ilara = 1 And Zutabea = 8 Then
            h1.Image = Nothing
        End If

        '8 ILARA
        If Ilara = 8 And Zutabea = 1 Then
            a8.Image = Nothing
        End If
        If Ilara = 8 And Zutabea = 8 Then
            h8.Image = Nothing
        End If
    End Sub
    'Pieza mugitu egiten du tableroan
    Public Sub PiezaMugitu(sender As Object, aukeratutakoGelaxka As Gelaxka)
        Dim irudia As String = String.Format("{0}_{1}", aukeratutakoGelaxka.Pieza.GetType().Name, IIf([Enum].GetName(GetType(Koloreak), aukeratutakoGelaxka.Pieza.Kolorea) = [Enum].GetName(GetType(Koloreak), Koloreak.Txuria), "T", "B"))
        sender.Image = My.Resources.ResourceManager.GetObject(irudia)
        AukeratutakoBox.Image = Nothing
    End Sub
    'Enrokeko dorrea mugitzen du
    Public Sub DorreaMugitu(aukeratutakoGelaxka As Gelaxka)
        Dim taula = aukeratutakoGelaxka.Taula
        If aukeratutakoGelaxka.Ilara = 1 Then
            If aukeratutakoGelaxka.Zutabea = 2 Then
                DorreaJarri(taula.gelaxkaLortu(1, 3))
                DorreaKendu(1, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 3 Then
                DorreaJarri(taula.gelaxkaLortu(1, 4))
                DorreaKendu(1, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 6 Then
                DorreaJarri(taula.gelaxkaLortu(1, 5))
                DorreaKendu(1, 8)
            End If
            If aukeratutakoGelaxka.Zutabea = 7 Then
                DorreaJarri(taula.gelaxkaLortu(1, 6))
                DorreaKendu(1, 8)
            End If
        End If
        If aukeratutakoGelaxka.Ilara = 8 Then
            If aukeratutakoGelaxka.Zutabea = 2 Then
                DorreaJarri(taula.gelaxkaLortu(8, 3))
                DorreaKendu(8, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 3 Then
                DorreaJarri(taula.gelaxkaLortu(8, 4))
                DorreaKendu(8, 1)
            End If
            If aukeratutakoGelaxka.Zutabea = 6 Then
                DorreaJarri(taula.gelaxkaLortu(8, 5))
                DorreaKendu(8, 8)
            End If
            If aukeratutakoGelaxka.Zutabea = 7 Then
                DorreaJarri(taula.gelaxkaLortu(8, 6))
                DorreaKendu(8, 8)
            End If
        End If
    End Sub
    'Dagokion gelaxka tratatzen du partidaren egoeraren arabera
    Public Sub Tratatu(i As Integer, z As Integer, sender As Object)
        Dim aukeratutakoGelaxka As Gelaxka = Partida.Taula.gelaxkaLortu(i, z)
        If Partida.Egoera = PartidarenEgoera.TxuriakWin Or Partida.Egoera = PartidarenEgoera.BeltzakWin Or Partida.Egoera = PartidarenEgoera.Berdinketa Then
            txtTxanda.Text = "Hasi partida berri bat"
            btnHasi.Enabled = True
        End If
        If Partida.Egoera = PartidarenEgoera.TxurieiItxoiten Or Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten Then
            If Partida.GetSquaresThatCanBeSelected().Contains(aukeratutakoGelaxka) Then
                Partida.SelectPiece(aukeratutakoGelaxka)
                AukeratutakoBox = sender
                MarraztuAukeratutakoGelaxka()
                MarraztutakoGelaxkak = Partida.PosibleDestinationSquares(Partida.SelectedSquare)
                Marraztu()
            End If
        Else
            If Partida.Egoera = PartidarenEgoera.TxuriakWin Or Partida.Egoera = PartidarenEgoera.BeltzakWin Or Partida.Egoera = PartidarenEgoera.Berdinketa Then
                txtTxanda.Text = "Hasi partida berri bat"
                btnHasi.Enabled = True
            Else
                If MarraztutakoGelaxkak.Contains(aukeratutakoGelaxka) Then
                    EzabatuAukeratutakoGelaxka()
                    MarrazkiaKendu()
                    If (Partida.SelectedSquare.Pieza.GetType().Name = "Peoia" And (aukeratutakoGelaxka.Ilara = 1 Or aukeratutakoGelaxka.Ilara = 8)) Then
                        Partida.SelectedSquare.Pieza = New Erregina(Partida.SelectedSquare.Pieza.Kolorea)
                    End If
                    Dim Enroke As Boolean
                    Enroke = Partida.MoveToSquare(aukeratutakoGelaxka)
                    If Enroke Then
                        DorreaMugitu(aukeratutakoGelaxka)
                    End If
                    PiezaMugitu(sender, aukeratutakoGelaxka)
                    txtTxanda.Text = ""
                    If Partida.Taula.XakeaDa(Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                        txtTxanda.Text = "Xake"
                        If Partida.Taula.MugimendurikEz(Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                            btnHasi.Enabled = True
                            If Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea = Koloreak.Txuria Then
                                Partida.Egoera = PartidarenEgoera.TxuriakWin
                                txtTxanda.Text = "Txuriak Irabazi du"
                                btnTablas.Enabled = False
                                btnErrenditu.Enabled = False
                            Else
                                Partida.Egoera = PartidarenEgoera.BeltzakWin
                                txtTxanda.Text = "Beltzak irabazi du"
                                btnTablas.Enabled = False
                                btnErrenditu.Enabled = False
                            End If
                        End If
                    Else
                        If Partida.Taula.MugimendurikEz(Partida.Taula.gelaxkaLortu(i, z).Pieza.Kolorea) Then
                            Partida.Egoera = PartidarenEgoera.Berdinketa
                            txtTxanda.Text = "Erregea itota dago"
                        End If
                    End If

                Else
                    EzabatuAukeratutakoGelaxka()
                    MarrazkiaKendu()
                    MarraztutakoGelaxkak.Clear()
                    Partida.UnselectPiece()
                End If
            End If
        End If
    End Sub
    'Aukeratu den gelaxka horiz margotzen du.
    Public Sub MarraztuAukeratutakoGelaxka()
        If ((Partida.SelectedSquare.Ilara + Partida.SelectedSquare.Zutabea) Mod 2 = 0) Then
            AukeratutakoBox.BackgroundImage = My.Resources.AukeratuB
        Else
            AukeratutakoBox.BackgroundImage = My.Resources.AukeratuT
        End If
    End Sub
    'Aukeratuta zegoen gelaxkari kolore horia kentzen dio
    Public Sub EzabatuAukeratutakoGelaxka()
        If ((Partida.SelectedSquare.Ilara + Partida.SelectedSquare.Zutabea) Mod 2 = 0) Then
            AukeratutakoBox.BackgroundImage = My.Resources.gelaxkaBeltza
        Else
            AukeratutakoBox.BackgroundImage = My.Resources.gelaxkaTxuria
        End If
    End Sub

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        Tratatu(1, 1, sender)
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Tratatu(1, 2, sender)
    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        Tratatu(1, 3, sender)
    End Sub

    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click
        Tratatu(1, 4, sender)
    End Sub

    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        Tratatu(1, 5, sender)
    End Sub

    Private Sub f1_Click(sender As Object, e As EventArgs) Handles f1.Click
        Tratatu(1, 6, sender)
    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        Tratatu(1, 7, sender)
    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click
        Tratatu(1, 8, sender)
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        Tratatu(2, 1, sender)
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Tratatu(2, 2, sender)
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        Tratatu(2, 3, sender)
    End Sub

    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click
        Tratatu(2, 4, sender)
    End Sub
    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click
        Tratatu(2, 5, sender)
    End Sub
    Private Sub f2_Click(sender As Object, e As EventArgs) Handles f2.Click
        Tratatu(2, 6, sender)
    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        Tratatu(2, 7, sender)
    End Sub

    Private Sub h2_Click(sender As Object, e As EventArgs) Handles h2.Click
        Tratatu(2, 8, sender)
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        Tratatu(3, 1, sender)
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Tratatu(3, 2, sender)
    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click
        Tratatu(3, 3, sender)
    End Sub

    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click
        Tratatu(3, 4, sender)
    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        Tratatu(3, 5, sender)
    End Sub

    Private Sub f3_Click(sender As Object, e As EventArgs) Handles f3.Click
        Tratatu(3, 6, sender)
    End Sub

    Private Sub g3_Click(sender As Object, e As EventArgs) Handles g3.Click
        Tratatu(3, 7, sender)
    End Sub

    Private Sub h3_Click(sender As Object, e As EventArgs) Handles h3.Click
        Tratatu(3, 8, sender)
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        Tratatu(4, 1, sender)
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Tratatu(4, 2, sender)
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        Tratatu(4, 3, sender)
    End Sub

    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click
        Tratatu(4, 4, sender)
    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        Tratatu(4, 5, sender)
    End Sub

    Private Sub f4_Click(sender As Object, e As EventArgs) Handles f4.Click
        Tratatu(4, 6, sender)
    End Sub

    Private Sub g4_Click(sender As Object, e As EventArgs) Handles g4.Click
        Tratatu(4, 7, sender)
    End Sub

    Private Sub h4_Click(sender As Object, e As EventArgs) Handles h4.Click
        Tratatu(4, 8, sender)
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        Tratatu(5, 1, sender)
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Tratatu(5, 2, sender)
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        Tratatu(5, 3, sender)
    End Sub

    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click
        Tratatu(5, 4, sender)
    End Sub

    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        Tratatu(5, 5, sender)
    End Sub

    Private Sub f5_Click(sender As Object, e As EventArgs) Handles f5.Click
        Tratatu(5, 6, sender)
    End Sub

    Private Sub g5_Click(sender As Object, e As EventArgs) Handles g5.Click
        Tratatu(5, 7, sender)
    End Sub

    Private Sub h5_Click(sender As Object, e As EventArgs) Handles h5.Click
        Tratatu(5, 8, sender)
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        Tratatu(6, 1, sender)
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        Tratatu(6, 2, sender)
    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click
        Tratatu(6, 3, sender)
    End Sub

    Private Sub d6_Click(sender As Object, e As EventArgs) Handles d6.Click
        Tratatu(6, 4, sender)
    End Sub

    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click
        Tratatu(6, 5, sender)
    End Sub

    Private Sub f6_Click(sender As Object, e As EventArgs) Handles f6.Click
        Tratatu(6, 6, sender)
    End Sub

    Private Sub g6_Click(sender As Object, e As EventArgs) Handles g6.Click
        Tratatu(6, 7, sender)
    End Sub

    Private Sub h6_Click(sender As Object, e As EventArgs) Handles h6.Click
        Tratatu(6, 8, sender)
    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        Tratatu(7, 1, sender)
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        Tratatu(7, 2, sender)
    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click
        Tratatu(7, 3, sender)
    End Sub

    Private Sub d7_Click(sender As Object, e As EventArgs) Handles d7.Click
        Tratatu(7, 4, sender)
    End Sub

    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click
        Tratatu(7, 5, sender)
    End Sub

    Private Sub f7_Click(sender As Object, e As EventArgs) Handles f7.Click
        Tratatu(7, 6, sender)
    End Sub

    Private Sub g7_Click(sender As Object, e As EventArgs) Handles g7.Click
        Tratatu(7, 7, sender)
    End Sub

    Private Sub h7_Click(sender As Object, e As EventArgs) Handles h7.Click
        Tratatu(7, 8, sender)
    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        Tratatu(8, 1, sender)
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        Tratatu(8, 2, sender)
    End Sub

    Private Sub c8_Click(sender As Object, e As EventArgs) Handles c8.Click
        Tratatu(8, 3, sender)
    End Sub

    Private Sub d8_Click(sender As Object, e As EventArgs) Handles d8.Click
        Tratatu(8, 4, sender)
    End Sub

    Private Sub e8_Click(sender As Object, e As EventArgs) Handles e8.Click
        Tratatu(8, 5, sender)
    End Sub

    Private Sub f8_Click(sender As Object, e As EventArgs) Handles f8.Click
        Tratatu(8, 6, sender)
    End Sub

    Private Sub g8_Click(sender As Object, e As EventArgs) Handles g8.Click
        Tratatu(8, 7, sender)
    End Sub

    Private Sub h8_Click(sender As Object, e As EventArgs) Handles h8.Click
        Tratatu(8, 8, sender)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles txtTxanda.Click

    End Sub
    'Tablas botoia sakatzean partida amaituko da berdinketa emaitzarekin
    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        Partida.Egoera = PartidarenEgoera.Berdinketa
        btnHasi.Enabled = True
        txtTxanda.Text = "Tablas adostu da"
        btnTablas.Enabled = False
        btnErrenditu.Enabled = False
    End Sub
    'Errenditzeko aukera eskaintzen du.
    Private Sub btnErrenditu_Click(sender As Object, e As EventArgs) Handles btnErrenditu.Click

        btnHasi.Enabled = True
        If Partida.Egoera = PartidarenEgoera.BeltzakMugitzen Or Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten Then
            txtTxanda.Text = "Txuriek irabazi dute"
            Partida.Egoera = PartidarenEgoera.TxuriakWin

        Else
            txtTxanda.Text = "Beltzek irabazi dute"
            Partida.Egoera = PartidarenEgoera.BeltzakWin
        End If
        btnTablas.Enabled = False
        btnErrenditu.Enabled = False
    End Sub

End Class