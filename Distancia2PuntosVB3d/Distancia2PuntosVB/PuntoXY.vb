Public Class PuntoXY
    Inherits PuntoX

    Protected y As Double

    Public Property _Y As Double
        Get
            Return y
        End Get
        Set(ByVal value As Double)
            y = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        y = 0
    End Sub

    Public Sub New(ByVal _X As Double, ByVal _Y As Double)
        MyBase.New(_X)
        Me.y = _Y
    End Sub

    Public Function CalcularDistancia(ByVal a As PuntoXY) As Double
        Return Math.Sqrt(Math.Pow((x - a._X), 2) + Math.Pow((y - a._Y), 2))
    End Function

    Public Overrides Function ToString() As String
        Return x & "," + y
    End Function


End Class
