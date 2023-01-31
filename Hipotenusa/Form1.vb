Public Class Form1


    Private Sub BTNcalcular_Click(sender As Object, e As EventArgs) Handles BTNcalcular.Click
        Dim X1, X2, Y1, Y2 As Double
        X1 = TXTx1.Text
        Y1 = TXTy1.Text
        X2 = TXTx2.Text
        Y2 = TXTy2.Text

        Dim puntoF As Punto = New Punto()

        TXTresultado.Text = Math.Round(puntoF.Operacion(X1, Y1, X2, Y2), 4)
    End Sub

    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        TXTx1.Clear()
        TXTy1.Clear()
        TXTx2.Clear()
        TXTy2.Clear()
        TXTresultado.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTresultado.Enabled = False
    End Sub
End Class
