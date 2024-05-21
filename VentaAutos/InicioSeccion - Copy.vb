Imports System.Data.SqlClient
Imports System.Web
Imports System.Xml
Imports Microsoft.SqlServer.Server

Public Class InicioSeccion
    'Public autoriza As Integer = 0
    Public pantallabienvenida As Boolean
    Dim query As String
    Public idusuario, nombreusuario As String
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query = "select convert(nvarchar(50),hashbytes('SHA1','" & txtcontra.Text & "'),2) from usuario
                where username = '" & txtusuario.Text & "'"

        Dim dt As DataTable
        Try
            dt = Connection.SelectQuery(query)
            Dim contrausuario As Object = dt.Rows(0)(0)

            query = "select id, nombre,password from usuario where username ='" & txtusuario.Text & "' and estatus = 1"
            dt = Connection.SelectQuery(query)
            Dim contrabase As Object = dt.Rows(0)(2)

            If contrabase = contrausuario Then
                idusuario = dt.Rows(0)(0)
                nombreusuario = dt(0)(1)
                pantallabienvenida = True
                Carga.Show()

            Else
                MsgBox("Contra incorrecta")
            End If

        Catch ex As Exception
            MsgBox("Usuario No existe")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub InicioSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picno.Visible = False
        txtcontra.UseSystemPasswordChar = True
        Connection.VisibleoNo(panelactualizar, False)

        txtcontra2.UseSystemPasswordChar = True
        picno2.Visible = False

        txtcontra3.UseSystemPasswordChar = True
        picno3.Visible = False
    End Sub

    Private Sub picsi_Click(sender As Object, e As EventArgs) Handles picsi.Click
        picno.Visible = True
        picsi.Visible = False
        txtcontra.UseSystemPasswordChar = False
    End Sub

    Private Sub btnbuscar2_Click(sender As Object, e As EventArgs) Handles btnbuscar2.Click
        query = "select convert(nvarchar(50),hashbytes('SHA1','" & txtcontra2.Text & "'),2) from usuario
                where username = '" & txtusuario2.Text & "'"

        Dim dt As DataTable
        Try
            dt = Connection.SelectQuery(query)
            Dim contrausuario As Object = dt.Rows(0)(0)

            query = "select id, nombre,password from usuario where username ='" & txtusuario2.Text & "' and estatus = 1"
            dt = Connection.SelectQuery(query)
            Dim contrabase As Object = dt.Rows(0)(2)

            If contrabase = contrausuario Then
                Connection.VisibleoNo(panelactualizar, True)
                Connection.VisibleoNo(panelbuscar, False)

                txtusernameactualizar2.Text = txtusuario2.Text
                txtnombreactualizar2.Text = dt(0)(1)
                txtcontractualizar2.Text = txtcontra2.Text
                idusuario = dt(0)(0)

            Else
                MsgBox("Contra incorrecta")
            End If

        Catch ex As Exception
            MsgBox("Usuario No existe")
        End Try
    End Sub

    Private Sub txtnombreactualizar2_TextChanged(sender As Object, e As EventArgs) Handles txtnombreactualizar2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtnombreactualizar2.Text = "" Or txtcontractualizar2.Text = "" Or
                txtusernameactualizar2.Text = "" Then

            MsgBox("Faltan campor por rellenar")
            Exit Sub

        End If

        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de modificar los datos del usuario" & vbCrLf & "Deseas Continuar ?" & vbCrLf, MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()

                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombreactualizar2.Text
                cmd.Parameters.Add("@usarname", SqlDbType.VarChar).Value = txtusernameactualizar2.Text
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtcontractualizar2.Text
                cmd.Parameters.Add("@passwordUsuario", SqlDbType.VarChar).Value = txtcontra2.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarUsuario")

                MsgBox("Usuario Actualizado Correctamente")
                Connection.VisibleoNo(panelactualizar, False)
                Connection.VisibleoNo(panelbuscar, True)

            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub picno2_Click(sender As Object, e As EventArgs) Handles picno2.Click
        picsi2.Visible = True
        picno2.Visible = False
        txtcontra2.UseSystemPasswordChar = True
    End Sub

    Private Sub picsi2_Click(sender As Object, e As EventArgs) Handles picsi2.Click
        picno2.Visible = True
        picsi2.Visible = False
        txtcontra2.UseSystemPasswordChar = False
    End Sub

    Private Sub picno3_Click(sender As Object, e As EventArgs) Handles picno3.Click
        picsi3.Visible = True
        picno3.Visible = False
        txtcontra3.UseSystemPasswordChar = True
    End Sub

    Private Sub picsi3_Click(sender As Object, e As EventArgs) Handles picsi3.Click
        picno3.Visible = True
        picsi3.Visible = False
        txtcontra3.UseSystemPasswordChar = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        query = "select convert(nvarchar(50),hashbytes('SHA1','" & txtcontra3.Text & "'),2) from usuario
                where username = '" & txtusuario3.Text & "'"

        Dim dt As DataTable
        Try
            dt = Connection.SelectQuery(query)
            Dim contrausuario As Object = dt.Rows(0)(0)

            query = "select id, nombre,password from usuario where username ='" & txtusuario3.Text & "' and estatus = 1"
            dt = Connection.SelectQuery(query)
            Dim contrabase As Object = dt.Rows(0)(2)

            If contrabase = contrausuario Then
                idusuario = dt.Rows(0)(0)
                nombreusuario = dt(0)(1)

            Else
                MsgBox("Contra incorrecta")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Usuario No existe")
            Exit Sub
        End Try

        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar el usuario: " & nombreusuario.ToString & vbCrLf & "Deseas Continuar ?" & vbCrLf, MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()

                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario

                Connection.ExecuteStoreProcedure(cmd, "SpborrarUsuario")

                MsgBox("Usuario Eliminado")

                txtcontra3.Clear()
                txtusuario3.Clear()

            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub picno_Click(sender As Object, e As EventArgs) Handles picno.Click
        picsi.Visible = True
        picno.Visible = False
        txtcontra.UseSystemPasswordChar = True
    End Sub
End Class