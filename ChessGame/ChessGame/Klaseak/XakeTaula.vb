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

    Public Function gelaxkaLortu(ilara As Integer, zutabea As Integer) As Gelaxka
        Return Me.FirstOrDefault(Function(s) s.Ilara = ilara And s.Zutabea = zutabea)
    End Function
    Public Function gelaxkaLortu(fromGelaxka As Gelaxka, move As Mugimendua) As Gelaxka
        Dim pieza = fromGelaxka.Pieza
        If pieza Is Nothing Then
            Return Nothing
        End If
        Return gelaxkaLortu(fromGelaxka.Ilara + IIf(pieza.Kolorea = Rotazioa, move.Aurrera, -move.Aurrera), fromGelaxka.Zutabea + move.Eskubira)
    End Function
    'HAU ALDATU

    Public Sub Init()
        ClearPieces()
        Dim bottomColor As Koloreak =
            IIf(Rotazioa = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        ' Kings
        Dim column As Integer = IIf(Rotazioa = Koloreak.Txuria, 5, 4)
        gelaxkaLortu(1, column).Pieza = New Erregea(Rotazioa)
        gelaxkaLortu(8, column).Pieza = New Erregea(bottomColor)
        ' Queens
        column = IIf(column = 5, 4, 5)
        gelaxkaLortu(1, column).Pieza = New Erregina(Rotazioa)
        gelaxkaLortu(8, column).Pieza = New Erregina(bottomColor)
        ' Rooks
        gelaxkaLortu(1, 1).Pieza = New Dorrea(Rotazioa)
        gelaxkaLortu(1, 8).Pieza = New Dorrea(Rotazioa)
        gelaxkaLortu(8, 1).Pieza = New Dorrea(bottomColor)
        gelaxkaLortu(8, 8).Pieza = New Dorrea(bottomColor)
        ' Knights
        gelaxkaLortu(1, 2).Pieza = New Zaldia(Rotazioa)
        gelaxkaLortu(1, 7).Pieza = New Zaldia(Rotazioa)
        gelaxkaLortu(8, 2).Pieza = New Zaldia(bottomColor)
        gelaxkaLortu(8, 7).Pieza = New Zaldia(bottomColor)
        ' Bishops
        gelaxkaLortu(1, 3).Pieza = New Alfila(Rotazioa)
        gelaxkaLortu(1, 3).Pieza = New Alfila(Rotazioa)
        gelaxkaLortu(8, 6).Pieza = New Alfila(bottomColor)
        gelaxkaLortu(8, 6).Pieza = New Alfila(bottomColor)
        ' Pawns
        For i = 1 To 8
            gelaxkaLortu(2, i).Pieza = New Peoia(Rotazioa)
            gelaxkaLortu(7, i).Pieza = New Peoia(bottomColor)
        Next
    End Sub

    ''' <summary>
    ''' Inicializa el tablero de juego colocando las piezas en su posición inicial
    ''' </summary>
    ''' <param name="colorOfTopPlayer">Color de las piezas a colocar en la parte
    ''' superior del tablero</param>
    Public Sub Init(colorOfTopPlayer As Koloreak)
        Rotazioa = colorOfTopPlayer
        Init()
    End Sub

    ''' <summary>
    ''' Mueve una pieza de una celda a otra
    ''' </summary>
    ''' <param name="fromSquare">Celda desde la que se realiza el movimiento</param>
    ''' <param name="toSquare">Celda destino del movimiento</param>
    ''' <returns>true o false indicando si el movimiento se ha realizado</returns>
    Public Function Move(fromSquare As Gelaxka, toSquare As Gelaxka) As Boolean
        If fromSquare IsNot Nothing AndAlso toSquare IsNot Nothing _
            AndAlso fromSquare.Pieza IsNot Nothing Then
            toSquare.Pieza = fromSquare.Pieza
            fromSquare.Pieza = Nothing
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Elimmina todas las piezas del tablero
    ''' </summary>
    Private Sub ClearPieces()
        For Each item As Gelaxka In Me
            item.Pieza = Nothing
        Next
    End Sub
End Class
