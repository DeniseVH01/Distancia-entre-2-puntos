Public Class PuntoXYZ
    Inherits PuntoXY

    Protected z As Double

    Public Property _Z As Double
        Get
            Return z
        End Get
        Set(ByVal value As Double)
            z = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        z = 0
    End Sub

    Public Sub New(ByVal _X As Double, ByVal _Y As Double, ByVal _Z As Double)
        MyBase.New(_X, _Y)
        Me.z = _Z
    End Sub

    Public Function CalcularDistancia(ByVal a As PuntoXYZ) As Double
        Return Math.Sqrt(Math.Pow((x - a._X), 2) + Math.Pow((y - a._Y), 2) + Math.Pow((z - a._Z), 2))
    End Function

    Public Overrides Function ToString() As String
        Return x & " ," + y & " , " + z
    End Function
End Class
