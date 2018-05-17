Public Class Gelaxka

    'Eraikitzaile1
    Public Sub New(xakeTaula As XakeTaula, gelaxkaIlara As Integer, gelaxkaZutabea As Integer)
        Taula = xakeTaula
        Ilara = gelaxkaIlara
        Zutabea = gelaxkaZutabea
    End Sub

    'Eraikitzaile2
    Public Sub New(xakeTaula As XakeTaula, gelaxkaIlara As Integer, gelaxkaZutabea As Integer, pieza As XakePieza)
        Taula = xakeTaula
        Ilara = gelaxkaIlara
        Zutabea = gelaxkaZutabea
        pieza = pieza
    End Sub

    'Propietateak
    Property Taula As XakeTaula
    Property Ilara As Integer
    Property Zutabea As Integer
    Private NirePieza As XakePieza

    'NirePieza propietatea
    Public Property Pieza() As XakePieza
        Get
            Return NirePieza
        End Get
        Set(ByVal value As XakePieza)
            NirePieza = value
        End Set
    End Property

End Class
