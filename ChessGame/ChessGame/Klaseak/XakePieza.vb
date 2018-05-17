Public MustInherit Class XakePieza

    Public Sub New(PiezaKolorea As Koloreak)
        Kolorea = PiezaKolorea
        Mugituta = False
    End Sub

    Property Kolorea As Koloreak
    Private _Mugituta As Boolean
    Public Property Mugituta() As Boolean
        Get
            Return _Mugituta
        End Get
        Set(ByVal value As Boolean)
            _Mugituta = value
        End Set
    End Property

    Public MustOverride Function HelburuGelaxkak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
    Public MustOverride Function Erasotutakoak(BereGelaxka As Gelaxka) As List(Of Gelaxka)
    Public Function gelaxkaLibreDago(helburuGelaxka As Gelaxka) As Boolean
        If helburuGelaxka Is Nothing Then Return False
        If helburuGelaxka.Pieza Is Nothing OrElse helburuGelaxka.Pieza.Kolorea <> Kolorea Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function gelaxkaLibreDagoErasotzean(helburuGelaxka As Gelaxka) As Boolean
        If helburuGelaxka Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Protected Function MugimenduPosibleak(mugimenduak As IEnumerable(Of Mugimendua), BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim taula As XakeTaula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        For Each mugimendua As Mugimendua In mugimenduak
            Dim helburuGelaxka As Gelaxka = taula.gelaxkaLortu(BereGelaxka, mugimendua)
            If gelaxkaLibreDago(helburuGelaxka) Then
                Dim gorde
                If helburuGelaxka.Pieza IsNot Nothing Then
                    gorde = helburuGelaxka.Pieza
                End If
                helburuGelaxka.Pieza = BereGelaxka.Pieza
                BereGelaxka.Pieza = Nothing
                Console.WriteLine(BereGelaxka.Taula.XakeaDa(helburuGelaxka.Pieza.Kolorea))
                If Not BereGelaxka.Taula.XakeaDaPiezaKentzean(helburuGelaxka.Pieza.Kolorea) Then
                    Console.WriteLine(BereGelaxka.Taula.XakeaDa(helburuGelaxka.Pieza.Kolorea))
                    gelaxkaPosibleak.Add(helburuGelaxka)
                End If
                BereGelaxka.Pieza = helburuGelaxka.Pieza
                If gorde IsNot Nothing Then
                    helburuGelaxka.Pieza = gorde
                Else
                    helburuGelaxka.Pieza = Nothing
                End If
                gorde = Nothing
            End If
        Next
        Return gelaxkaPosibleak
    End Function

    Protected Function MugimenduPosibleakNorabidekin(BereGelaxka As Gelaxka, aurreraJarraitu As Integer, eskubiraJarraitu As Integer) As IEnumerable(Of Gelaxka)

        Dim taula As XakeTaula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        Dim Txanda As Koloreak
        Txanda = IIf(Kolorea = Koloreak.Txuria, Koloreak.Beltza, Koloreak.Txuria)
        Dim Aurrera As Integer = aurreraJarraitu
        Dim Eskubira As Integer = eskubiraJarraitu
        Dim Jarraitu As Boolean = False
        Dim helburuGelaxka As Gelaxka
        Do While Not Jarraitu
            helburuGelaxka = taula.gelaxkaLortu(BereGelaxka, New Mugimendua() With {.Aurrera = Aurrera, .Eskubira = Eskubira})
            If gelaxkaLibreDago(helburuGelaxka) Then
                Dim gorde
                If helburuGelaxka.Pieza IsNot Nothing Then
                    gorde = helburuGelaxka.Pieza
                End If
                helburuGelaxka.Pieza = BereGelaxka.Pieza
                BereGelaxka.Pieza = Nothing
                Console.WriteLine(BereGelaxka.Taula.XakeaDa(helburuGelaxka.Pieza.Kolorea))
                If Not BereGelaxka.Taula.XakeaDaPiezaKentzean(helburuGelaxka.Pieza.Kolorea) Then
                    Console.WriteLine(BereGelaxka.Taula.XakeaDa(helburuGelaxka.Pieza.Kolorea))
                    gelaxkaPosibleak.Add(helburuGelaxka)
                End If
                BereGelaxka.Pieza = helburuGelaxka.Pieza
                If gorde IsNot Nothing Then
                    helburuGelaxka.Pieza = gorde
                Else
                    helburuGelaxka.Pieza = Nothing
                End If
            End If
            Jarraitu = helburuGelaxka Is Nothing OrElse helburuGelaxka.Pieza IsNot Nothing
            Aurrera += aurreraJarraitu
            Eskubira += eskubiraJarraitu
        Loop
        Return gelaxkaPosibleak
    End Function
    Protected Function ErasotutakoakNorabidekin(BereGelaxka As Gelaxka, aurreraJarraitu As Integer, eskubiraJarraitu As Integer) As IEnumerable(Of Gelaxka)

        Dim taula As XakeTaula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        Dim Aurrera As Integer = aurreraJarraitu
        Dim Eskubira As Integer = eskubiraJarraitu
        Dim Jarraitu As Boolean = False
        Dim helburuGelaxka As Gelaxka
        Do While Not Jarraitu
            helburuGelaxka = taula.gelaxkaLortu(BereGelaxka, New Mugimendua() With {.Aurrera = Aurrera, .Eskubira = Eskubira})
            If gelaxkaLibreDagoErasotzean(helburuGelaxka) Then
                gelaxkaPosibleak.Add(helburuGelaxka)
            End If
            Jarraitu = helburuGelaxka Is Nothing OrElse helburuGelaxka.Pieza IsNot Nothing
            Aurrera += aurreraJarraitu
            Eskubira += eskubiraJarraitu
        Loop
        Return gelaxkaPosibleak
    End Function

    Protected Function ErasoPosibleak(mugimenduak As IEnumerable(Of Mugimendua), BereGelaxka As Gelaxka) As List(Of Gelaxka)
        Dim taula As XakeTaula = BereGelaxka.Taula
        Dim gelaxkaPosibleak As New List(Of Gelaxka)
        For Each mugimendua As Mugimendua In mugimenduak
            Dim helburuGelaxka As Gelaxka = taula.gelaxkaLortu(BereGelaxka, mugimendua)
            If gelaxkaLibreDagoErasotzean(helburuGelaxka) Then
                gelaxkaPosibleak.Add(helburuGelaxka)
            End If
        Next
        Return gelaxkaPosibleak
    End Function
End Class
