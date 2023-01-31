Public Class Punto
    Public Xpunto1 As Double
    Public Ypunto1 As Double
    Public Xpunto2 As Double
    Public Ypunto2 As Double

    Public Property Xpropiedad1() As String
        Get
            Return Xpunto1
        End Get
        Set(value As String)
            Xpunto1 = value
        End Set
    End Property

    Public Property Ypropiedad1() As String
        Get
            Return Ypunto1
        End Get
        Set(value As String)
            Ypunto1 = value
        End Set
    End Property

    Public Property Xpropiedad2() As String
        Get
            Return Xpunto2
        End Get
        Set(value As String)
            Xpunto2 = value
        End Set
    End Property

    Public Property Ypropiedad2() As String
        Get
            Return Ypunto2
        End Get
        Set(value As String)
            Ypunto2 = value
        End Set
    End Property

    Public Sub Puntos(ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double)
        Xpunto1 = X1
        Ypunto1 = Y1
        Xpunto2 = X2
        Ypunto2 = Y2
    End Sub


    Public Function Operacion(X1, Y1, X2, Y2)
        Dim distancia As Double
        distancia = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)))
        Return distancia
    End Function
End Class
