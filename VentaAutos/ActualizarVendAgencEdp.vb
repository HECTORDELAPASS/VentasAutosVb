Imports System.Data.SqlClient

Public Class ActualizarVendAgencEdp
    Dim dt As DataTable
    Dim query As String
    Dim cmd As SqlCommand

    Private Sub ActualizarVendAgencEdp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.ReadOnly = True
        Dim id As Integer = VendedorAgenciaEstados.EliminarActualizar

        If VendedorAgenciaEstados.eleccion = 1 Then
            query = "select nombre from vendedor where id = " & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 2 Then
            query = "select nombre from agencia where id = " & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 3 Then
            query = "select nombreestado from estado where id = " & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 4 Then
            query = "select nombre from carroceria where id =" & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 5 Then
            query = "select nombre from modelo where id =" & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 6 Then
            query = "select nombre from variante where id =" & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 7 Then
            query = "select nombre from trasmicion where id =" & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 8 Then
            query = "select nombre from interior where id =" & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)

        ElseIf VendedorAgenciaEstados.eleccion = 9 Then
            query = "select nombre from colores where id =" & id
            dt = Connection.SelectQuery(query)

            txtNombre.Text = dt(0)(0)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim horaHoy As String = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")

        If VendedorAgenciaEstados.eleccion = 1 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "spactualizarvendedor")

                query = "select fechamodifica from vendedor where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 2 Then

            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "spactualizaragencia")

                query = "select fechamodifica from agencia where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 3 Then

            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idEstado", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "spActualizarEstado")

                query = "select fechamodifica from estado where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 4 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idcarroceria", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarCarroceria")

                query = "select fechamodifica from carroceria where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 5 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarModelo")

                query = "select fechamodifica from modelo where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 6 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarVariante")

                query = "select fechamodifica from variante where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 7 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idTransmision", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarTransmision")

                query = "select fechamodifica from trasmicion where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 8 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idInterior", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarInterior")

                query = "select fechamodifica from interior where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        ElseIf VendedorAgenciaEstados.eleccion = 9 Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = VendedorAgenciaEstados.EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtactualiza.Text

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarColores")

                query = "select fechamodifica from colores where id =" & VendedorAgenciaEstados.EliminarActualizar
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                    VendedorAgenciaEstados.filtro()
                    Me.Close()
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar: " & ex.Message)
            End Try

        End If


    End Sub
End Class