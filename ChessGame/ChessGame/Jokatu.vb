Public Class Jokatu
    Private Partida As New XakePartida()
    Private MarraztutakoGelaxkak As New List(Of Gelaxka)
    Private Sub Jokatu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHasi_Click(sender As Object, e As EventArgs) Handles btnHasi.Click
        Hasieratu()
        Partida.Start(Koloreak.Txuria)
        btnHasi.Enabled = False
    End Sub
    Public Sub Hasieratu()
        a1.Image = My.Resources.Dorrea_T
        b1.Image = My.Resources.Zaldia_T
        c1.Image = My.Resources.Alfil_T
        d1.Image = My.Resources.Erregina_T
        e1.Image = My.Resources.Erregea_T
        h1.Image = My.Resources.Dorrea_T
        g1.Image = My.Resources.Zaldia_T
        f1.Image = My.Resources.Alfil_T
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
        c8.Image = My.Resources.Alfil_B
        d8.Image = My.Resources.Erregina_B
        e8.Image = My.Resources.Erregea_B
        h8.Image = My.Resources.Dorrea_B
        g8.Image = My.Resources.Zaldia_B
        f8.Image = My.Resources.Alfil_B
        a7.Image = My.Resources.Peoia_B
        b7.Image = My.Resources.Peoia_B
        c7.Image = My.Resources.Peoia_B
        d7.Image = My.Resources.Peoia_B
        e7.Image = My.Resources.Peoia_B
        f7.Image = My.Resources.Peoia_B
        g7.Image = My.Resources.Peoia_B
        h7.Image = My.Resources.Peoia_B
    End Sub


    Public Sub Marraztu(helburuak As List(Of Gelaxka))
        For Each laukia As Gelaxka In helburuak
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
    Public Sub MarrazkiaKendu(helburuak As List(Of Gelaxka))
        For Each laukia As Gelaxka In helburuak
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
                h5.BackgroundImage = My.Resources.gelaxkaBeltza
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
    Public Sub Tratatu(i As Integer, z As Integer)
        Dim aukeratutakoGelaxka As Gelaxka = Partida.Taula.gelaxkaLortu(i, z)
        If (Partida.Egoera = PartidarenEgoera.TxurieiItxoiten Or Partida.Egoera = PartidarenEgoera.BeltzeiItxoiten) Then
            If Partida.GetSquaresThatCanBeSelected().Contains(aukeratutakoGelaxka) Then
                Partida.SelectPiece(aukeratutakoGelaxka)
                MarraztutakoGelaxkak = Partida.PosibleDestinationSquares(Partida.SelectedSquare)
                Marraztu(MarraztutakoGelaxkak)
            End If
        Else
            Console.WriteLine("Ondo egin det")
            If MarraztutakoGelaxkak.Contains(aukeratutakoGelaxka) Then
                Console.WriteLine("Hona mugituko dut")
                'Else
                'Unselect
                'End If
            End If
        End If

    End Sub
    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        Tratatu(1, 1)
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Tratatu(1, 2)
    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        Tratatu(1, 3)
    End Sub

    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click
        Tratatu(1, 4)
    End Sub

    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        Tratatu(1, 5)
    End Sub

    Private Sub f1_Click(sender As Object, e As EventArgs) Handles f1.Click
        Tratatu(1, 6)
    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        Tratatu(1, 7)
    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click
        Tratatu(1, 8)
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        Tratatu(2, 1)
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Tratatu(2, 2)
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        Tratatu(2, 3)
    End Sub

    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click
        Tratatu(2, 4)
    End Sub
    Private Sub e2_Click(laukia As Object, e As EventArgs) Handles e2.Click
        Tratatu(2, 5)
    End Sub
    Private Sub f2_Click(sender As Object, e As EventArgs) Handles f2.Click
        Tratatu(2, 6)
    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        Tratatu(2, 7)
    End Sub

    Private Sub h2_Click(sender As Object, e As EventArgs) Handles h2.Click
        Tratatu(2, 8)
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        Tratatu(3, 1)
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Tratatu(3, 2)
    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click
        Tratatu(3, 3)
    End Sub

    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click
        Tratatu(3, 4)
    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        Tratatu(3, 5)
    End Sub

    Private Sub f3_Click(sender As Object, e As EventArgs) Handles f3.Click
        Tratatu(3, 6)
    End Sub

    Private Sub g3_Click(sender As Object, e As EventArgs) Handles g3.Click
        Tratatu(3, 7)
    End Sub

    Private Sub h3_Click(sender As Object, e As EventArgs) Handles h3.Click
        Tratatu(3, 8)
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        Tratatu(4, 1)
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Tratatu(4, 2)
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        Tratatu(4, 3)
    End Sub

    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click
        Tratatu(4, 4)
    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        Tratatu(4, 5)
    End Sub

    Private Sub f4_Click(sender As Object, e As EventArgs) Handles f4.Click
        Tratatu(4, 6)
    End Sub

    Private Sub g4_Click(sender As Object, e As EventArgs) Handles g4.Click
        Tratatu(4, 7)
    End Sub

    Private Sub h4_Click(sender As Object, e As EventArgs) Handles h4.Click
        Tratatu(4, 8)
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub f5_Click(sender As Object, e As EventArgs) Handles f5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub g5_Click(sender As Object, e As EventArgs) Handles g5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub h5_Click(sender As Object, e As EventArgs) Handles h5.Click
        Tratatu(5, 1)
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        Tratatu(6, 1)
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        Tratatu(6, 2)
    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click
        Tratatu(6, 3)
    End Sub

    Private Sub d6_Click(sender As Object, e As EventArgs) Handles d6.Click
        Tratatu(6, 4)
    End Sub

    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click
        Tratatu(6, 5)
    End Sub

    Private Sub f6_Click(sender As Object, e As EventArgs) Handles f6.Click
        Tratatu(6, 6)
    End Sub

    Private Sub g6_Click(sender As Object, e As EventArgs) Handles g6.Click
        Tratatu(6, 7)
    End Sub

    Private Sub h6_Click(sender As Object, e As EventArgs) Handles h6.Click
        Tratatu(6, 8)
    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        Tratatu(7, 1)
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        Tratatu(7, 2)
    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click
        Tratatu(7, 3)
    End Sub

    Private Sub d7_Click(sender As Object, e As EventArgs) Handles d7.Click
        Tratatu(7, 4)
    End Sub

    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click
        Tratatu(7, 5)
    End Sub

    Private Sub f7_Click(sender As Object, e As EventArgs) Handles f7.Click
        Tratatu(7, 6)
    End Sub

    Private Sub g7_Click(sender As Object, e As EventArgs) Handles g7.Click
        Tratatu(7, 7)
    End Sub

    Private Sub h7_Click(sender As Object, e As EventArgs) Handles h7.Click
        Tratatu(7, 8)
    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        Tratatu(8, 1)
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        Tratatu(8, 2)
    End Sub

    Private Sub c8_Click(sender As Object, e As EventArgs) Handles c8.Click
        Tratatu(8, 3)
    End Sub

    Private Sub d8_Click(sender As Object, e As EventArgs) Handles d8.Click
        Tratatu(8, 4)
    End Sub

    Private Sub e8_Click(sender As Object, e As EventArgs) Handles e8.Click
        Tratatu(8, 5)
    End Sub

    Private Sub f8_Click(sender As Object, e As EventArgs) Handles f8.Click
        Tratatu(8, 6)
    End Sub

    Private Sub g8_Click(sender As Object, e As EventArgs) Handles g8.Click
        Tratatu(8, 7)
    End Sub

    Private Sub h8_Click(sender As Object, e As EventArgs) Handles h8.Click
        Tratatu(8, 8)
    End Sub
End Class