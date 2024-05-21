Imports System.CodeDom
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VehiculoAgregarActualizar
    Dim dt As DataTable
    Dim cmd As SqlCommand
    Dim query As String
    Public busquedadevehiculos As Boolean = False
    Public idagencia, idmodelo, idvariante, idcarroceria, idtransmision, idcolor, idinterior As Integer
    Private Sub VehiculoAgregarActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy"


        If busquedavehiculo.seleccion = 1 Then
            Lb1.Text = "Agregar Nuevo Vehiculo"
        ElseIf busquedavehiculo.seleccion = 2 Then
            Lb1.Text = "Actualizar Vehiculo"

            query = "select * from VwCarrosIds where id =" & busquedavehiculo.EliminarActualizar
            dt = Connection.SelectQuery(query)

            idmodelo = dt(0)(0)
            txtModelo.Text = dt(0)(1)
            idagencia = dt(0)(2)
            txtagencia.Text = dt(0)(3)
            idvariante = dt(0)(4)
            txtvariante.Text = dt(0)(5)
            idcarroceria = dt(0)(6)
            txtcarroceria.Text = dt(0)(7)
            idtransmision = dt(0)(8)
            txtTransmision.Text = dt(0)(9)
            idcolor = dt(0)(10)
            TxtColor.Text = dt(0)(11)

            idinterior = dt(0)(12)
            TxtInterior.Text = dt(0)(13)
            txtVin.Text = dt(0)(14)
            DateTimePicker1.Text = dt(0)(15) & "-01-01"


        End If

        txtModelo.ReadOnly = True
        txtagencia.ReadOnly = True
        txtvariante.ReadOnly = True
        txtcarroceria.ReadOnly = True
        txtTransmision.ReadOnly = True
        TxtColor.ReadOnly = True
        TxtInterior.ReadOnly = True
    End Sub

    Private Sub btbuscarvendedor_Click(sender As Object, e As EventArgs) Handles btbuscarvendedor.Click
        MenuOpciones.Boton = 5
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        MenuOpciones.Boton = 2
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        MenuOpciones.Boton = 6
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        MenuOpciones.Boton = 4
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pic4.Click
        MenuOpciones.Boton = 7
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pic5.Click
        MenuOpciones.Boton = 9
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles pic6.Click
        MenuOpciones.Boton = 8
        busquedadevehiculos = True
        VendedorAgenciaEstados.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If busquedavehiculo.seleccion = 1 Then
            agregarvehiculo()
        ElseIf busquedavehiculo.seleccion = 2 Then
            actualizarvehiculo()
        End If

    End Sub
    Private Sub agregarvehiculo()
        If txtModelo.Text = "" Or txtagencia.Text = "" Or txtvariante.Text = "" Or txtcarroceria.Text = "" Or
            txtTransmision.Text = "" Or TxtColor.Text = "" Or TxtInterior.Text = "" Or txtVin.Text = "" Or
            DateTimePicker1.Text = "" Then

            MsgBox("Faltan campor por rellenar")
            Exit Sub

        End If

        query = "SELECT IDENT_CURRENT('carro')+1"
        dt = Connection.SelectQuery(query)
        Dim siguienteid As Integer = dt(0)(0)

        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Se agregara un nuevo Vehiculo" & vbCrLf & "Deseas Continuar ?" & vbCrLf, MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@year", SqlDbType.DateTime).Value = DateTimePicker1.Text & "-01-01"
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtVin.Text
                cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = idagencia

                cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = idmodelo
                cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = idvariante
                cmd.Parameters.Add("@idcarroceria", SqlDbType.Int).Value = idcarroceria

                cmd.Parameters.Add("@idtransmicion", SqlDbType.Int).Value = idtransmision
                cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = idcolor
                cmd.Parameters.Add("@idinterior", SqlDbType.Int).Value = idinterior

                cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario

                Connection.ExecuteStoreProcedure(cmd, "spAgregarAutos")

                query = "select max(id) from carro"
                dt = Connection.SelectQuery(query)
                Dim comprobacion = dt(0)(0)

                If comprobacion = siguienteid Then
                    MsgBox("Nuevo Carro Registrado Correctamente")
                    Me.Close()
                Else
                    MsgBox("Error al agregar el registro")
                End If
            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub actualizarvehiculo()
        If txtModelo.Text = "" Or txtagencia.Text = "" Or txtvariante.Text = "" Or txtcarroceria.Text = "" Or
           txtTransmision.Text = "" Or TxtColor.Text = "" Or TxtInterior.Text = "" Or txtVin.Text = "" Or
           DateTimePicker1.Text = "" Then

            MsgBox("Faltan campor por rellenar")
            Exit Sub

        End If

        Dim horaHoy As String = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")

        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Se agregara un Actualizara El Vehiculo" & vbCrLf & "Deseas Continuar ?" & vbCrLf, MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@year", SqlDbType.DateTime).Value = DateTimePicker1.Text & "-01-01"
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtVin.Text
                cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = idagencia

                cmd.Parameters.Add("@idmodelo", SqlDbType.Int).Value = idmodelo
                cmd.Parameters.Add("@idvariante", SqlDbType.Int).Value = idvariante
                cmd.Parameters.Add("@idcarroceria", SqlDbType.Int).Value = idcarroceria

                cmd.Parameters.Add("@idtransmicion", SqlDbType.Int).Value = idtransmision
                cmd.Parameters.Add("@idcolor", SqlDbType.Int).Value = idcolor
                cmd.Parameters.Add("@idinterior", SqlDbType.Int).Value = idinterior

                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = horaHoy
                cmd.Parameters.Add("@idauto", SqlDbType.Int).Value = busquedavehiculo.EliminarActualizar

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarAutos")

                query = "select fechamodifica from carro where id ='" & busquedavehiculo.EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)
                Dim comprobacion As String = dt(0)(0)

                If horaHoy = comprobacion Then
                    MsgBox("Actualizacion realizada correctamente")
                Else
                    MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
                End If
            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtVin_TextChanged(sender As Object, e As EventArgs) Handles txtVin.TextChanged
        If txtVin.Text.Length > 50 Then

            If txtVin.Text.Length > 50 Then
                ' Truncar el texto a 50 caracteres
                txtVin.Text = txtVin.Text.Substring(0, 50)

                ' Establecer el cursor al final del texto
                txtVin.SelectionStart = 50
                txtVin.SelectionLength = 0
            End If

            txtVin.Text = txtVin.Text.Substring(0, 50)

        End If
    End Sub

End Class