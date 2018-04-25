Public Enum Koloreak
    Beltza
    Txuria
End Enum
Public Enum PartidarenEgoera
    TxurieiItxoiten
    BeltzeiItxoiten
    TxuriakMugitzen
    BeltzakMugitzen
    TxuriakWin
    BeltzakWin
End Enum
Public Structure Mugimendua
    ''' <summary>
    ''' Número de posiciones a avanzar hacia adelante
    ''' Si se mueve hacia atrás el valor será negativo
    ''' El movimiento se realizará hacia arriba o haciaa abajo en función
    ''' del color de la pieza a la que se aplica
    ''' </summary>
    Public Aurrera As Integer
    ''' <summary>
    ''' Número de posiciones a mover hacia la derecha
    ''' Si el movimiento es hacia la izquierda el valor será negativo
    ''' </summary>
    Public Eskubira As Integer
End Structure
Public Class XakePartida
    Private _Taula As XakeTaula
    Private _Egoera As PartidarenEgoera
    Public Sub New()
        _Taula = New XakeTaula
    End Sub


    Public Property Taula() As XakeTaula
        Get
            Return _Taula
        End Get
        Private Set(ByVal value As XakeTaula)
            _Taula = value
        End Set
    End Property


    Public Property Egoera() As PartidarenEgoera
        Get
            Return _Egoera
        End Get
        Private Set(ByVal value As PartidarenEgoera)
            _Egoera = value
        End Set
    End Property
    'ALDATU BEHAR DA
    Private _selectedSquare As Gelaxka
    ''' <summary>
    ''' Devuelve la celda seleccionada por el usuario
    ''' </summary>
    Public Property SelectedSquare() As Gelaxka
        Get
            Return _selectedSquare
        End Get
        Set(ByVal value As Gelaxka)
            _selectedSquare = value
        End Set
    End Property

    ''' <summary>
    ''' Inicia un nuevo juego disponiendo las piezas del color indicado
    ''' en la parte superior del tablero
    ''' </summary>
    ''' <param name="playerOnTop">Color de las piezas de la parte superior del tablero</param>
    Public Sub Start(playerOnTop As Koloreak)
        Taula.Init(playerOnTop)
        ' Se establece el estado a través de la variable privada para que no se genere
        ' el evento StateChanged ya que lo lanzamos manualmente
        Egoera = PartidarenEgoera.TxurieiItxoiten
    End Sub

    Public Function GetSquaresThatCanBeSelected() As List(Of Gelaxka)
        If Egoera <> PartidarenEgoera.TxurieiItxoiten And Egoera <> PartidarenEgoera.BeltzeiItxoiten Then
            Return Nothing
        Else
            Dim itzuli As New List(Of Gelaxka)
            For Each s As Gelaxka In Taula
                If s.Pieza IsNot Nothing AndAlso s.Pieza.Kolorea = IIf(Egoera = PartidarenEgoera.TxurieiItxoiten, Koloreak.Txuria, Koloreak.Beltza) Then
                    itzuli.Add(s)
                End If
            Next
            Return itzuli
        End If
    End Function

    ''' <summary>
    ''' Selecciona la celda indicada como celda inicio del movimiento
    ''' </summary>
    ''' <param name="squareToSelect">Celda a seleccionar</param>
    ''' <returns>true o false indicando si se ha realizado la selección
    ''' El juego debe estar pendiente de iniciar un movimiento y la celda ser una de
    ''' las celdas seleccionables</returns>
    Public Function SelectPiece(squareToSelect As Gelaxka) As Boolean
        If squareToSelect Is Nothing OrElse squareToSelect.Pieza Is Nothing Then Return False
        If Egoera = PartidarenEgoera.TxurieiItxoiten AndAlso squareToSelect.Pieza.Kolorea = Koloreak.Txuria _
            OrElse Egoera = PartidarenEgoera.BeltzeiItxoiten AndAlso squareToSelect.Pieza.Kolorea = Koloreak.Beltza Then
            SelectedSquare = squareToSelect
            _Egoera = IIf(_Egoera = PartidarenEgoera.TxurieiItxoiten, PartidarenEgoera.TxuriakMugitzen, PartidarenEgoera.BeltzakMugitzen)
            Console.WriteLine(Egoera)
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Deselecciona la celda actualmente seleccionada
    ''' </summary>
    ''' <returns>true o false indicando si se ha realizado la deselección
    ''' Para que exista celda seleccionada el juego debe estar pediente de finalizar movimiento</returns>
    Public Function UnselectPiece() As Boolean
        If Egoera = PartidarenEgoera.TxuriakMugitzen OrElse Egoera = PartidarenEgoera.BeltzakMugitzen Then
            SelectedSquare = Nothing
            Egoera = IIf(Egoera = PartidarenEgoera.TxuriakMugitzen,
                PartidarenEgoera.TxurieiItxoiten, PartidarenEgoera.BeltzeiItxoiten)
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Devuelve las celdas que pueden ser destino del movimiento en función
    ''' de la celda actualmente seleccionada.
    ''' Los posibles destinos dependen de la pieza contenida en la celda seleccionada.
    ''' </summary>
    ''' <returns>Las celdas que pueden ser destino del movimiento</returns>
    Public Function PosibleDestinationSquares(square As Gelaxka) As List(Of Gelaxka)
        Dim list As New List(Of Gelaxka)
        Console.WriteLine(1234)
        list = square.Pieza.HelburuGelaxkak(square)
        Return list
    End Function

    ''' <summary>
    ''' Ejecuta el movimiento desde la celda seleccionada a la 
    ''' celda indicada
    ''' </summary>
    ''' <param name="squareToMove">Celda destino del movimiento</param>
    ''' <returns>true o false en función de si se ha podido realizar
    ''' el movimiento</returns>
    Public Function MoveToSquare(squareToMove As Gelaxka) As Boolean
        If SelectedSquare Is Nothing Then Return False

        If Taula.Move(SelectedSquare, squareToMove) Then
            SelectedSquare = Nothing
            ' Una vez realizado el movimiento se comprueba si ha finalizado
            ' (si hay ganador)
            If Not CheckForWin() Then
                Egoera = IIf(Egoera = PartidarenEgoera.TxuriakMugitzen _
                          , PartidarenEgoera.BeltzeiItxoiten, PartidarenEgoera.TxurieiItxoiten)
            End If
            Return True
        Else
            Return False
        End If
    End Function



    ''' <returns>true o false indicando si el juego ha finalizado</returns>
    Private Function CheckForWin() As Boolean
        ' Si únicamente queda un rey el juego ha terminado
        Dim kings As List(Of XakePieza) = Taula.Select(Function(s) s.Pieza) _
            .Where(Function(p) p IsNot Nothing AndAlso TypeOf p Is Erregea)
        If kings.Count() = 1 Then
            Egoera = IIf(kings.First().Kolorea = Koloreak.Txuria _
                      , PartidarenEgoera.TxuriakWin, PartidarenEgoera.BeltzakWin)
            Return True
        Else
            Return False
        End If
    End Function
End Class
