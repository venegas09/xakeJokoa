Public MustInherit Class XakePieza

    Public Sub New(PiezaKolorea As Koloreak)
        Kolorea = PiezaKolorea
    End Sub

    Property Kolorea As Koloreak

    Property BereGelaxka As Gelaxka

    Public MustOverride Function HelburuGelaxkak() As IEnumerable(Of Gelaxka)

    Public Function gelaxkaLibreDago(helburuGelaxka As Gelaxka) As Boolean
        If helburuGelaxka Is Nothing Then Return False
        If helburuGelaxka.Pieza Is Nothing Or helburuGelaxka.Pieza.Kolorea <> Kolorea Then
            Return True
        End If
    End Function

    Protected Function MugimenduPosibleak(
        mugimenduak As IEnumerable(Of Mugimendua)) As IEnumerable(Of Gelaxka)
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

    Protected IEnumerable<Gelaxka> MugimenduPosibleakNorabideekin(
            int forwardIncrement, int rightIncrement)
        {
            Chessboard board = BoardSquare.Board;

            List<Square> squares = New List<Square>();
            int forward = forwardIncrement;
            int right = rightIncrement;
            bool pieceOrEndFounded = False;
            While (!pieceOrEndFounded)
            {
                Square destination = board.GetSquare(BoardSquare, New Movement { Forward = forward, ToRight = right });
                If (CanBeDestination(destination))
                    squares.Add(destination);
                pieceOrEndFounded = (destination == null || destination.Piece != null);
                forward += forwardIncrement;
                right += rightIncrement;
            }
            Return squares;
        }

End Class
