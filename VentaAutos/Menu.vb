Imports System.Reflection.Emit

Public Class MenuOpciones
    Public pantallaventas As Boolean
    Public Boton As Integer
    Public cargarvehiculos As Boolean
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Boton = 3
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Boton = 2
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub MenuOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        txtsaludo.Text = "Hola de nuevo, " & InicioSeccion.nombreusuario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pantallaventas = True
        Form1.Show()
        Carga.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Boton = 1
        VendedorAgenciaEstados.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Boton = 4
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Boton = 5
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Boton = 6
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Boton = 7
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Boton = 8
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Boton = 9
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cargarvehiculos = True
        busquedavehiculo.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txthoraactual.Text = "Hora : " & DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpcUsuarios.Show()
    End Sub
End Class