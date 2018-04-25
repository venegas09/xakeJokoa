Public Class Gelaxka
    Public Sub New(xakeTaula As XakeTaula, gelaxkaIlara As Integer, gelaxkaZutabea As Integer)
        Taula = xakeTaula
        Ilara = gelaxkaIlara
        Zutabea = gelaxkaZutabea
    End Sub
    Public Sub New(xakeTaula As XakeTaula, gelaxkaIlara As Integer, gelaxkaZutabea As Integer, pieza As XakePieza)
        Taula = xakeTaula
        Ilara = gelaxkaIlara
        Zutabea = gelaxkaZutabea
        pieza = pieza
    End Sub
    Property Taula As XakeTaula
    Property Ilara As Integer
    Property Zutabea As Integer
    Private XPieza As XakePieza
    Public Property Pieza() As XakePieza
        Get
            Return XPieza
        End Get
        Set(ByVal value As XakePieza)
            XPieza = value
        End Set
    End Property
End Class
