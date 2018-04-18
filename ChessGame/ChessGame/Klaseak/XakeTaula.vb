
Public Class XakeTaula
    Inherits List(Of Gelaxka)

    Public Sub New()
        For ilara = 0 To 7
            For zutabea = 0 To 7
                Add(New Gelaxka(Me, ilara, zutabea))
            Next
        Next
        Rotazioa = Koloreak.Txuria
    End Sub

    Property Rotazioa As Koloreak

    Public Function gelaxkaLortu(ilara As Integer, zutabea As Integer) As Gelaxka
        Return Me.FirstOrDefault(Function(s) s.Ilara = ilara AndAlso s.Zutabea = zutabea)
    End Function
    Public Function gelaxkaLortu(fromGelaxka As Gelaxka, move As Mugimendua) As Gelaxka
        Dim pieza = fromGelaxka.Pieza
        If pieza Is Nothing Then
            Return Nothing
        End If
        Return gelaxkaLortu(fromGelaxka.Ilara + IIf(pieza.Kolorea = Rotazioa, move.Forward, -move.Forward), fromSquare.Column + move.ToRight)
    End Function
End Class
