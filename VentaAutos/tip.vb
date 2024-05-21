Public Class tip
    Public Tiempototal As Integer = 180
    Public tiemporestante As Integer = Tiempototal
    Private Sub tip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiemporestante -= 1
        'Label2.Text = tiemporestante.ToString()

        If tiemporestante = 0 Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class