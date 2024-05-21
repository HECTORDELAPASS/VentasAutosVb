Public Class Carga
    Dim query As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgressBar1.Value += 2
        CircularProgressBar1.Text += 2

        If Opacity < 1 Then
            Me.Opacity += 0.1

        End If
        If CircularProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario = InicioSeccion.idusuario
        query = "select nombre,username from usuario where id = '" & usuario & "'"
        Dim dt As DataTable = Connection.SelectQuery(query)
        dt = Connection.SelectQuery(query)
        CircularProgressBar1.OuterColor = Color.Black
        CircularProgressBar1.ProgressColor = Color.BlanchedAlmond

        If InicioSeccion.pantallabienvenida Then
            lb1.Text = "Bienvenido. " & dt.Rows(0)(0) & " , " & dt.Rows(0)(1)
            CircularProgressBar1.OuterColor = Color.FromArgb(0, 64, 0)
            CircularProgressBar1.ProgressColor = Color.Green
        ElseIf Form1.pantallamasinfo Then
            lb1.Text = "Cargando Informacion del vehiculo, Espera"
            CircularProgressBar1.OuterColor = Color.Maroon
            CircularProgressBar1.ProgressColor = Color.Red
        ElseIf Infor.pantallaupdate Then
            lb1.Text = "Agregando Permisos, Espera"
            CircularProgressBar1.OuterColor = Color.DarkGoldenrod
            CircularProgressBar1.ProgressColor = Color.Yellow
        ElseIf MenuOpciones.pantallaventas Then
            lb1.Text = "Cargando informacion de Ventas, Espera"
        End If


        CircularProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()

            If InicioSeccion.pantallabienvenida Then
                MenuOpciones.Show()
            ElseIf Form1.pantallamasinfo Then
                Infor.Show()
            ElseIf Infor.pantallaupdate Then
                tip.Show()
            End If


            InicioSeccion.pantallabienvenida = False
            Form1.pantallamasinfo = False
            Infor.pantallaupdate = False
            Me.Close()
        End If
    End Sub

End Class