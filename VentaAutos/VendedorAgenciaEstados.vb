Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class VendedorAgenciaEstados
    Dim query, nombre As String
    Dim dt As DataTable
    Public EliminarActualizar As Integer = 0
    Dim cmd As SqlCommand
    Public eleccion, rows As Integer
    Private Sub VendedorAgenciaEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240)

        If MenuOpciones.Boton = 1 Then
            Lb1.Text = "Informacion Vendedores"
            lb2.Text = "Buscar Vendedor"
            filtro()
        ElseIf MenuOpciones.boton = 2 Then
            Lb1.Text = "Informacion Agencias"
            lb2.Text = "Buscar Agencia"
            filtro()
        ElseIf MenuOpciones.boton = 3 Then
            Lb1.Text = "Informacion Estados"
            lb2.Text = "Buscar Estado"
            filtro()
        ElseIf MenuOpciones.Boton = 4 Then
            Lb1.Text = "Informacion Carrocerias"
            lb2.Text = "Buscar Carroceria"
            filtro()
        ElseIf MenuOpciones.Boton = 5 Then
            Lb1.Text = "Informacion Modelos de Vehiculos"
            lb2.Text = "Buscar Modelo"
            filtro()
        ElseIf MenuOpciones.Boton = 6 Then
            Lb1.Text = "Informacion de Variantes de Vehiculos"
            lb2.Text = "Buscar Variante"
            filtro()
        ElseIf MenuOpciones.Boton = 7 Then
            Lb1.Text = "Informacion de Transmisiónes de Vehiculos"
            lb2.Text = "Buscar Transmisión"
            filtro()
        ElseIf MenuOpciones.Boton = 8 Then
            Lb1.Text = "Informacion de Interiores de Vehiculos"
            lb2.Text = "Buscar Interior de Vehiculos"
            filtro()
        ElseIf MenuOpciones.Boton = 9 Then
            Lb1.Text = "Informacion de Colores de Vehiculos"
            lb2.Text = "Buscar Colores de Vehiculos"
            filtro()
        End If


    End Sub
    Private Sub formatotabla()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Columns(0).FillWeight = 0.4
        DataGridView1.Columns(1).FillWeight = 2
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
    End Sub

    Public Sub filtro()
        If MenuOpciones.Boton = 1 Then
            query = "select id, nombre from vendedor where estatus = 1 and nombre like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 2 Then
            query = "select id, nombre from agencia where estatus = 1 and nombre like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 3 Then
            query = "select id, nombreestado as [nombre de estado] from estado where estatus = 1 and nombreestado like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 4 Then
            query = "select id, nombre from carroceria where estatus = 1 and nombre like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 5 Then
            query = "select id, nombre from modelo where estatus = 1 and nombre like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 6 Then
            query = "select id, nombre from variante where estatus = 1 and nombre like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 7 Then
            query = "select id, nombre from trasmicion where estatus = 1 and nombre like'%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 8 Then
            query = "select id, nombre from interior where estatus = 1 and nombre like'%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf MenuOpciones.Boton = 9 Then
            query = "select id, nombre from colores where estatus = 1 and nombre like'%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        End If
        formatotabla()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        filtro()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MenuOpciones.Boton = 1 Then
            agregarvendedor()
        ElseIf MenuOpciones.Boton = 2 Then
            agregaragencia()
        ElseIf MenuOpciones.Boton = 3 Then
            agregarestado()
        ElseIf MenuOpciones.Boton = 4 Then
            AgregarCarroceria()
        ElseIf MenuOpciones.Boton = 5 Then
            AgregarModelo()
        ElseIf MenuOpciones.Boton = 6 Then
            AgregarVariante()
        ElseIf MenuOpciones.Boton = 7 Then
            AgregarTransmisión()
        ElseIf MenuOpciones.Boton = 8 Then
            AgregarInterior()
        ElseIf MenuOpciones.Boton = 9 Then
            AgregarColor()
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MenuOpciones.Boton = 1 Then
            actualizarvendedor()
        ElseIf MenuOpciones.Boton = 2 Then
            actualizaragencia()
        ElseIf MenuOpciones.Boton = 3 Then
            actualizarestado()
        ElseIf MenuOpciones.Boton = 4 Then
            ActualizarCarroceria()
        ElseIf MenuOpciones.Boton = 5 Then
            ActualizarModelo()
        ElseIf MenuOpciones.Boton = 6 Then
            ActualizarVariante()
        ElseIf MenuOpciones.Boton = 7 Then
            ActualizarTransmisión()
        ElseIf MenuOpciones.Boton = 8 Then
            ActualizarInterior()
        ElseIf MenuOpciones.Boton = 9 Then
            ActualizarColor()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MenuOpciones.Boton = 1 Then
            Eliminarvendedor()
        ElseIf MenuOpciones.Boton = 2 Then
            EliminarAgencia()
        ElseIf MenuOpciones.Boton = 3 Then
            EliminarEstado()
        ElseIf MenuOpciones.Boton = 4 Then
            EliminarCarroceria()
        ElseIf MenuOpciones.Boton = 5 Then
            EliminarModelo()
        ElseIf MenuOpciones.Boton = 6 Then
            EliminarVariante()
        ElseIf MenuOpciones.Boton = 7 Then
            EliminarTransmisión()
        ElseIf MenuOpciones.Boton = 8 Then
            EliminarInterior()
        ElseIf MenuOpciones.Boton = 9 Then
            EliminarColor()
        End If
    End Sub
    Private Sub agregarvendedor()
        eleccion = 1
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub actualizarvendedor()
        If EliminarActualizar <> 0 Then
            eleccion = 1
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub Eliminarvendedor()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar al vendedor seleccionado" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "spborrarvendededor")

                query = "select estatus from vendedor where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Vendedor borrado correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar vendedor" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub agregaragencia()
        eleccion = 2
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub actualizaragencia()
        If EliminarActualizar <> 0 Then
            eleccion = 2
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarAgencia()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar la agencia seleccionada" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "spborraragencia")

                query = "select estatus from agencia where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Agencia borrada correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar la Agencia" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub agregarestado()
        eleccion = 3
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub actualizarestado()
        If EliminarActualizar <> 0 Then
            eleccion = 3
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarEstado()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar el estado seleccionado" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "spBorrarEstado")

                query = "select estatus from estado where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Estado borrado correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar el Estado" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub AgregarCarroceria()
        eleccion = 4
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub ActualizarCarroceria()
        If EliminarActualizar <> 0 Then
            eleccion = 4
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarCarroceria()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar la carroceria seleccionada" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idCarrociera", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarCarroceria")

                query = "select estatus from carroceria where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Carroceria borrada correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar la carroceria" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    ''''''''''''''''''''''
    Private Sub AgregarModelo()
        eleccion = 5
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub ActualizarModelo()
        If EliminarActualizar <> 0 Then
            eleccion = 5
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarModelo()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar el modelo seleccionado" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarModelo")

                query = "select estatus from modelo where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Modelo borrado correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar el Modelo" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    '''''''''''''''''''
    Private Sub AgregarVariante()
        eleccion = 6
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub ActualizarVariante()
        If EliminarActualizar <> 0 Then
            eleccion = 6
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarVariante()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar La variante seleccionada" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarVariante")

                query = "select estatus from variante where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Variante borrada correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar la Variante" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    '''''''''''''''''''
    Private Sub AgregarTransmisión()
        eleccion = 7
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub ActualizarTransmisión()
        If EliminarActualizar <> 0 Then
            eleccion = 7
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarTransmisión()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar La Transmision seleccionada" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idTransmision", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarTransmision")

                query = "select estatus from trasmicion where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Transmision borrada correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar la Transmision" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    '''''''''''''''''''
    Private Sub AgregarInterior()
        eleccion = 8
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub ActualizarInterior()
        If EliminarActualizar <> 0 Then
            eleccion = 8
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarInterior()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar El Interior de vehiculo seleccionado" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idInterior", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarInterior")

                query = "select estatus from interior where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Interior de vehiculo borrado correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar El Interior de vehiculo" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    '''''''''''''''''''
    Private Sub AgregarColor()
        eleccion = 9
        AgregarVendAgencYEdo.Show()
    End Sub
    Private Sub ActualizarColor()
        If EliminarActualizar <> 0 Then
            eleccion = 9
            ActualizarVendAgencEdp.Show()
        End If
    End Sub
    Private Sub EliminarColor()
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar El color de vehiculo seleccionado" & vbCrLf & "Id:" & EliminarActualizar & " Nombre:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarColores")

                query = "select estatus from colores where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Color de vehiculo borrado correctamente")
                    filtro()
                Else
                    MsgBox("Error al borrar El color de vehiculo" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            EliminarActualizar = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            nombre = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Catch ex As Exception

        End Try

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If VehiculoAgregarActualizar.busquedadevehiculos Then
            Try
                VehiculoAgregarActualizar.busquedadevehiculos = False
                rows = DataGridView1.Rows(e.RowIndex).Cells(0).Value

                If MenuOpciones.Boton = 2 Then
                    query = "select nombre from agencia where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idagencia = rows
                    VehiculoAgregarActualizar.txtagencia.Text = dt(0)(0)

                ElseIf MenuOpciones.Boton = 4 Then
                    query = "select nombre from carroceria where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idcarroceria = rows
                    VehiculoAgregarActualizar.txtcarroceria.Text = dt(0)(0)

                ElseIf MenuOpciones.Boton = 5 Then
                    query = "select nombre from modelo where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idmodelo = rows
                    VehiculoAgregarActualizar.txtModelo.Text = dt(0)(0)

                ElseIf MenuOpciones.Boton = 6 Then
                    query = "select nombre from variante where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idvariante = rows
                    VehiculoAgregarActualizar.txtvariante.Text = dt(0)(0)

                ElseIf MenuOpciones.Boton = 7 Then
                    query = "select nombre from trasmicion where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idtransmision = rows
                    VehiculoAgregarActualizar.txtTransmision.Text = dt(0)(0)

                ElseIf MenuOpciones.Boton = 8 Then
                    query = "select nombre from interior where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idinterior = rows
                    VehiculoAgregarActualizar.TxtInterior.Text = dt(0)(0)

                ElseIf MenuOpciones.Boton = 9 Then
                    query = "select nombre from colores where id = " & rows
                    dt = Connection.SelectQuery(query)

                    VehiculoAgregarActualizar.idcolor = rows
                    VehiculoAgregarActualizar.TxtColor.Text = dt(0)(0)

                End If

                Me.Close()

            Catch ex As Exception
                MsgBox("Para Extraer informacion doble click sobre celdas validas")
            End Try
        End If
    End Sub

    Private Sub VendedorAgenciaEstados_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        VehiculoAgregarActualizar.busquedadevehiculos = False
    End Sub
End Class