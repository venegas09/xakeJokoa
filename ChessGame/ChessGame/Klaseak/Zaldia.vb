Class Zaldia
    Inherits XakePieza

    Public Sub New(Kolorea As Koloreak)
        MyBase.New(Kolorea)
    End Sub

    Private mugimenduak As Mugimendua() = {
            New Mugimendua() With {.Aurrera = 1, .Eskubira = -2},
            New Mugimendua() With {.Aurrera = 2, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = 2, .Eskubira = 1},
            New Mugimendua() With {.Aurrera = 1, .Eskubira = 2},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = -2},
            New Mugimendua() With {.Aurrera = -2, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = -2, .Eskubira = 1},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = 2}
        }

    Public Overrides Function HelburuGelaxkak() As IEnumerable(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing
        Return MugimenduPosibleak(mugimenduak)
    End Function
End Class