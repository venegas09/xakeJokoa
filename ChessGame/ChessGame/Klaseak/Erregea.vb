Public Class Erregea
    Inherits XakePieza
    Public Sub New(kolorea As Koloreak)
        MyBase.New(kolorea)
    End Sub

    Private mugimenduak As Mugimendua() = {
            New Mugimendua() With {.Aurrera = 1, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = 1, .Eskubira = 0},
            New Mugimendua() With {.Aurrera = 1, .Eskubira = 1},
            New Mugimendua() With {.Aurrera = 0, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = 0, .Eskubira = 1},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = -1},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = 0},
            New Mugimendua() With {.Aurrera = -1, .Eskubira = 1}
        }

    Public Overrides Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
        If BereGelaxka Is Nothing Then Return Nothing
        Return MugimenduPosibleak(mugimenduak, BereGelaxka)
    End Function

End Class
