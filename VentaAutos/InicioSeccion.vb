Imports System.Data.SqlClient
Imports System.Web
Imports System.Xml
Imports Microsoft.SqlServer.Server

Public Class InicioSeccion
    'Public autoriza As Integer = 0
    Public pantallabienvenida As Boolean
    Dim query As String
    Public idusuario, nombreusuario, username, password As String
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub InicioSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picno.Visible = False
        txtcontra.UseSystemPasswordChar = True

        Connection.VisibleoNo(Panel2, False)
        Connection.VisibleoNo(Panel1, True)
    End Sub

    Private Sub txtNotengo_Click(sender As Object, e As EventArgs) Handles txtNotengo.Click
        Connection.VisibleoNo(Panel1, False)
        Connection.VisibleoNo(Panel2, True)
        txtNotengo.Visible = False
    End Sub

    Private Sub txtcrear_Click(sender As Object, e As EventArgs) Handles txtcrear.Click
        If txtcreacontra.Text = "" Or txtcreanombre.Text = "" Or txtcreausername.Text = "" Then
            MsgBox("Faltan Campor por llenar")
            Exit Sub
        End If

        query = "SELECT COUNT(username) FROM usuario WHERE username = '" & txtcreausername.Text & "'"
        dt = Connection.SelectQuery(query)

        If (dt(0)(0) = "1") Then
            MsgBox("Usuario Ya existente")
            txtcreausername.Clear()
            Exit Sub
        End If


        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtcreanombre.Text
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtcreausername.Text
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtcreacontra.Text

            Connection.ExecuteStoreProcedure(cmd, "SpagregarUsuario")

            MsgBox("Usuario Creado")
            txtNotengo.Visible = True
            Connection.VisibleoNo(Panel1, True)

            txtusuario.Text = txtcreausername.Text
            txtcontra.Text = txtcreacontra.Text
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub picsi_Click_1(sender As Object, e As EventArgs) Handles picsi.Click
        picno.Visible = True
        picsi.Visible = False
        txtcontra.UseSystemPasswordChar = False
    End Sub

    Private Sub picno_Click_1(sender As Object, e As EventArgs) Handles picno.Click
        picsi.Visible = True
        picno.Visible = False
        txtcontra.UseSystemPasswordChar = True
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        query = "select convert(nvarchar(50),hashbytes('SHA1','" & txtcontra.Text & "'),2) from usuario
                where username = '" & txtusuario.Text & "'"

        Dim dt As DataTable
        Try
            dt = Connection.SelectQuery(query)
            Dim contrausuario As Object = dt.Rows(0)(0)

            query = "select id, nombre,password,username from usuario where username ='" & txtusuario.Text & "' and estatus = 1"
            dt = Connection.SelectQuery(query)
            Dim contrabase As Object = dt.Rows(0)(2)

            If contrabase = contrausuario Then
                idusuario = dt.Rows(0)(0)
                nombreusuario = dt(0)(1)
                password = dt(0)(2)
                username = dt(0)(3)
                pantallabienvenida = True
                Carga.Show()

            Else
                MsgBox("Contra incorrecta")
            End If

        Catch ex As Exception
            MsgBox("Usuario No existe")
        End Try
    End Sub

End Class