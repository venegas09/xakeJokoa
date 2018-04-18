Public Enum Koloreak
    Beltza
    Txuria
End Enum
Public Enum PartidarenEgoera
    TxurieiItxoiten
    BeltzeiItxoiten
    TxuriekMugitu
    BeltzakMugitu
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

End Class
