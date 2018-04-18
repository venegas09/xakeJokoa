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
    Property Pieza As XakePieza

End Class
