Public Class PuntoX
    Protected x As Double

    Public Property _X As Double
        Get
            Return x
        End Get
        Set(ByVal value As Double)
            x = value
        End Set
    End Property

    Public Sub New()
        x = 0
    End Sub

    Public Sub New(ByVal _X As Double)
        Me.x = _X
    End Sub

    Public Function CalcularDistancia(ByVal a As PuntoX) As Double
        Return Math.Abs(x - a._X)
    End Function

    Public Overrides Function ToString() As String
        Return x & " "
    End Function
End Class
