Public Class Form1
    Private Sub BTNcalcular_Click(sender As Object, e As EventArgs) Handles BTNcalcular.Click

        Dim X1, Y1, Z1, X2, Y2, Z2 As Double
        X1 = TXTx1.Text
        Y1 = TXTy1.Text
        Z1 = TXTz1.Text
        X2 = TXTx2.Text
        Y2 = TXTy2.Text
        Z2 = TXTz2.Text
        Dim PuntoA As PuntoXYZ = New PuntoXYZ(X1, Y1, Z1)
        Dim PuntoB As PuntoXYZ = New PuntoXYZ(X2, Y2, Z2)

        TXTresultado.Text = Math.Round(PuntoB.CalcularDistancia(PuntoA), 4)


    End Sub

    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        TXTx1.Clear()
        TXTy1.Clear()
        TXTz1.Clear()
        TXTx2.Clear()
        TXTy2.Clear()
        TXTz2.Clear()
        TXTresultado.Clear()
    End Sub
End Class
