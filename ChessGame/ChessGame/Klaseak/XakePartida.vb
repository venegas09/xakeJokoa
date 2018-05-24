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
    Berdinketa
End Enum
Public Structure Mugimendua
    Public Aurrera As Integer
    'Aurrera joateko gelaxka, atzera juteko negatiboa bada
    'Mugimendua gora edo behera egingo da, erabiltzen den kolorearen arabera
    Public Eskubira As Integer
    'Eskubira joateko gelaxka, ezkerrera juteko negatiboa bada
    'Mugimendua eskubira edo ezkerrera egingo da, erabiltzen den kolorearen arabera
End Structure
Public Class XakePartida

    Private _Taula As XakeTaula
    Private _Egoera As PartidarenEgoera

    'Eraikitzailea
    Public Sub New()
        _Taula = New XakeTaula
    End Sub

    'Taula propietatea
    Public Property Taula() As XakeTaula
        Get
            Return _Taula
        End Get
        Private Set(ByVal value As XakeTaula)
            _Taula = value
        End Set
    End Property

    'Egoera propietatea
    Public Property Egoera() As PartidarenEgoera
        Get
            Return _Egoera
        End Get
        Set(ByVal value As PartidarenEgoera)
            _Egoera = value
        End Set
    End Property
    'Aukeratutako uneko gelaxka
    Private _selectedSquare As Gelaxka
    'Aukeratuta dagoen gelaxka itzultzen du
    Public Property SelectedSquare() As Gelaxka
        Get
            Return _selectedSquare
        End Get
        Set(ByVal value As Gelaxka)
            _selectedSquare = value
        End Set
    End Property

    'Jokua hasten du pasatako kolorea behean ipiniz
    Public Sub Start(playerOnTop As Koloreak)
        Taula.Init(playerOnTop)
        Egoera = PartidarenEgoera.TxurieiItxoiten
    End Sub
    'Aukeratu daitezken gelaxkak itzultzen ditu
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

    'Adierazitako gelaxka aukeratzen du
    Public Function SelectPiece(squareToSelect As Gelaxka) As Boolean
        If squareToSelect Is Nothing OrElse squareToSelect.Pieza Is Nothing Then Return False
        If Egoera = PartidarenEgoera.TxurieiItxoiten AndAlso squareToSelect.Pieza.Kolorea = Koloreak.Txuria _
            OrElse Egoera = PartidarenEgoera.BeltzeiItxoiten AndAlso squareToSelect.Pieza.Kolorea = Koloreak.Beltza Then
            SelectedSquare = squareToSelect
            _Egoera = IIf(_Egoera = PartidarenEgoera.TxurieiItxoiten, PartidarenEgoera.TxuriakMugitzen, PartidarenEgoera.BeltzakMugitzen)
            Return True
        Else
            Return False
        End If
    End Function

    'Aukeratutako gelaxka aukeratu gabe uzten du.
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
    ' Helburu izan daitezken gelaxkak itzultzen ditu pasatako gelaxkaren arabera
    Public Function PosibleDestinationSquares(square As Gelaxka) As List(Of Gelaxka)
        Dim list As New List(Of Gelaxka)
        list = square.Pieza.HelburuGelaxkak(square)
        Return list
    End Function

    'Mugimendua egiten du aukeratutako gelaxkatik adierazitako gelaxkara
    Public Function MoveToSquare(squareToMove As Gelaxka) As Boolean
        If SelectedSquare Is Nothing Then Return False
        Dim Enroke As Boolean
        Enroke = Taula.Move(SelectedSquare, squareToMove)
        SelectedSquare = Nothing
        Egoera = IIf(Egoera = PartidarenEgoera.TxuriakMugitzen, PartidarenEgoera.BeltzeiItxoiten, PartidarenEgoera.TxurieiItxoiten)
        Return Enroke

    End Function

End Class
