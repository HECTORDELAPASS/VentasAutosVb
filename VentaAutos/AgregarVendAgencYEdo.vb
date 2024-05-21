Imports System.Data.SqlClient

Public Class AgregarVendAgencYEdo
    Dim cmd As SqlCommand
    Dim query As String
    Dim dt As DataTable
    Private Sub AgregarVendAgencYEdo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtid.ReadOnly = True

        If VendedorAgenciaEstados.eleccion = 1 Then
            Label2.Text = "Agregar Nuevo Vendedor"
            query = "SELECT IDENT_CURRENT('vendedor')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 2 Then
            Label2.Text = "Agregar Nueva Agencia"
            query = "SELECT IDENT_CURRENT('agencia')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 3 Then
            Label2.Text = "Agregar Nuevo Estado"
            query = "SELECT IDENT_CURRENT('estado')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 4 Then
            Label2.Text = "Agregar Nueva Carroceria"
            query = "SELECT IDENT_CURRENT('carroceria')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 5 Then
            Label2.Text = "Agregar Nuevo Modelo de auto"
            query = "SELECT IDENT_CURRENT('modelo')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 6 Then
            Label2.Text = "Agregar Nueva variante"
            query = "SELECT IDENT_CURRENT('variante')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 7 Then
            Label2.Text = "Agregar Nueva Transmisión"
            query = "SELECT IDENT_CURRENT('trasmicion')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 8 Then
            Label2.Text = "Agregar Nuevo Interior de auto"
            query = "SELECT IDENT_CURRENT('interior')+1"

        ElseIf VendedorAgenciaEstados.eleccion = 9 Then
            Label2.Text = "Agregar Nuevo Color"
            query = "SELECT IDENT_CURRENT('colores')+1"
        End If
        dt = Connection.SelectQuery(query)
        txtid.Text = dt(0)(0)
    End Sub
    Private Sub vendedoresagregar()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "SpAgregarVendedor")

            query = "select max(id) from vendedor"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nuevo Vendedor Registrado Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub AgenciaAgregar()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spagregaragencia")

            query = "select max(id) from agencia"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nueva Agencia Registrada Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar Nueva Agencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar la Agencia: " & ex.Message)

        End Try
    End Sub
    Private Sub agregaredo()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spagregarEstado")

            query = "select max(id) from estado"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nuevo Estado Registrado Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar Estado")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el Estado: " & ex.Message)

        End Try
    End Sub
    Private Sub agregarcarrroceria()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spAgregarCarroceria")

            query = "select max(id) from carroceria"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nueva Carroceria Registrada Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub agregarmodelo()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spAgregarModelo")

            query = "select max(id) from modelo"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nuevo modelo Registrado Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub agregarvariante()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spAgregarVariantes")

            query = "select max(id) from variante"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nueva Variante Registrada Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub agregarTransmisión()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spAgregarTransmision")

            query = "select max(id) from trasmicion"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nueva Transmision Registrada Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub agregarinterior()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spAgregarInterior")

            query = "select max(id) from interior"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nuevo Interior Registrado Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub agregarcolores()
        Try
            cmd = New SqlCommand()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text
            cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
            Connection.ExecuteStoreProcedure(cmd, "spAgregarColores")

            query = "select max(id) from colores"
            dt = Connection.SelectQuery(query)
            Dim comprobacion = dt(0)(0)

            If comprobacion = txtid.Text Then
                MsgBox("Nuevo Color Registrado Correctamente")
                VendedorAgenciaEstados.filtro()
                Me.Close()
            Else
                MsgBox("Error al agregar el registro")
            End If
        Catch ex As Exception
            MsgBox("Error al el registro:" & ex.Message)

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If VendedorAgenciaEstados.eleccion = 1 Then
            vendedoresagregar()
        ElseIf VendedorAgenciaEstados.eleccion = 2 Then
            AgenciaAgregar()
        ElseIf VendedorAgenciaEstados.eleccion = 3 Then
            agregaredo()
        ElseIf VendedorAgenciaEstados.eleccion = 4 Then
            agregarcarrroceria()
        ElseIf VendedorAgenciaEstados.eleccion = 5 Then
            agregarmodelo()
        ElseIf VendedorAgenciaEstados.eleccion = 6 Then
            agregarvariante()
        ElseIf VendedorAgenciaEstados.eleccion = 7 Then
            agregarTransmisión()
        ElseIf VendedorAgenciaEstados.eleccion = 8 Then
            agregarinterior()
        ElseIf VendedorAgenciaEstados.eleccion = 9 Then
            agregarcolores()
        End If
    End Sub
End Class