Imports System.Data.SqlClient

Public Class busquedavehiculo
    Dim query, nombre As String
    Public modelo, agencias, año, carroceria, variante, colores, interior, transmicion, idcar, vincarro As String
    Dim auto As Boolean
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Public EliminarActualizar As Integer = 0
    Public seleccion As Integer

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        Dim respuesta As MsgBoxResult
        If EliminarActualizar = 0 Then
            MsgBox("Selecciona un vehiculo para eliminar")
            Exit Sub
        End If
        respuesta = MsgBox("Estas a punto de borrar El Vehiculo seleccionado" & vbCrLf & "Id:" & EliminarActualizar & vbCrLf & " Modelo:" & nombre & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()
                cmd.Parameters.Add("@idauto", SqlDbType.Int).Value = EliminarActualizar
                cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
                cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

                Connection.ExecuteStoreProcedure(cmd, "SpBorrarAutos")

                query = "select estatus from carro where id = '" & EliminarActualizar & "'"
                dt = Connection.SelectQuery(query)

                If dt(0)(0) = 0 Then
                    MsgBox("Vehiculo borrado correctamente")
                    actualizar()
                Else
                    MsgBox("Error al borrar Vehiculo" & vbCrLf & "Intentar mas tarde")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        seleccion = 1
        VehiculoAgregarActualizar.Show()
        tip.Show()
    End Sub

    Private Sub pic2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        If EliminarActualizar <> 0 Then
            seleccion = 2
            VehiculoAgregarActualizar.Show()
            tip.Show()
        Else
            MsgBox("Selecciona el vehiculo a actualizar")
        End If

    End Sub


    Public Sub New()

        ' This call is required by the designer.
        auto = True
        InitializeComponent()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

        query = "select nombre from agencia order by nombre asc"
        CboAgencia.DataSource = Connection.SelectQuery(query)
        CboAgencia.DisplayMember = "nombre"
        auto = False

    End Sub
    Private Sub busquedavehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1.Text = "Busqueda Avanzada Codigo de vehiculo"

        pic1.Visible = False
        pic2.Visible = False
        pic3.Visible = False
        lb1.Visible = False
        lb2.Visible = False
        lb3.Visible = False

        If MenuOpciones.cargarvehiculos Then
            pic1.Visible = True
            pic2.Visible = True
            pic3.Visible = True
            lb1.Visible = True
            lb2.Visible = True
            lb3.Visible = True
            txt1.Text = "Informacion de Vehiculos"
        End If

        DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240)
        rdvin.Checked = True
        cboyear.DropDownStyle = ComboBoxStyle.DropDownList
        CboAgencia.DropDownStyle = ComboBoxStyle.DropDownList
        txtvin.Text = Infor.vintxt.Text

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If auto Or cboyear.Text Is Nothing Then
            Exit Sub
        End If
        actualizar()

    End Sub
    Private Sub actualizar()
        If txtbuscar.Text <> "" And rdmodelo.Checked Then
            query = "select * from Vwcarros where [modelo] like '%" & txtbuscar.Text & "%' and [agencia] = '" & CboAgencia.Text & "' and [Año] = '" & cboyear.Text & "'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        End If
        If txtvin.Text <> "" And rdvin.Checked Then
            query = "select * from Vwcarros where [codigovehiculo] like '%" & txtvin.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        End If
    End Sub


    Private Sub CboAgencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAgencia.SelectedIndexChanged
        If auto Then
            Exit Sub
        End If
        auto = True

        query = "select distinct [Año] from Vwcarros where agencia = '" & CboAgencia.Text & "'"
        cboyear.DataSource = Connection.SelectQuery(query)
        cboyear.DisplayMember = "Año"
        auto = False
        actualizar()

    End Sub
    Private Sub cboyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboyear.SelectedIndexChanged
        If auto Then
            Exit Sub
        End If
        If CboAgencia.Text Is Nothing Then
            Exit Sub
        End If
        query = "select * from Vwcarros where [agencia] = '" & CboAgencia.Text & "' and [Año] = '" & cboyear.Text & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)

        actualizar()
    End Sub

    Private Sub txtvin_TextChanged(sender As Object, e As EventArgs) Handles txtvin.TextChanged
        If auto Then
            Exit Sub
        End If
        actualizar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If MenuOpciones.cargarvehiculos Then
            Exit Sub
        End If

        If Infor.nuevaventa Then
            Try
                modelo = DataGridView1.Rows(e.RowIndex).Cells(4).Value
                agencias = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                año = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                carroceria = DataGridView1.Rows(e.RowIndex).Cells(6).Value
                variante = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                colores = DataGridView1.Rows(e.RowIndex).Cells(8).Value
                interior = DataGridView1.Rows(e.RowIndex).Cells(9).Value
                transmicion = DataGridView1.Rows(e.RowIndex).Cells(7).Value
                vincarro = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                idcar = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                '''''''''''''''''''''''''''''''
                Infor.modelotxt.Text = modelo
                Infor.agentxt.Text = agencias
                Infor.yeartxt.Text = año
                Infor.txtcarroceria.Text = carroceria
                Infor.Variatxt.Text = variante
                Infor.colortxt.Text = colores
                Infor.inttxt.Text = interior
                Infor.trastxt.Text = transmicion
                Infor.vintxt.Text = vincarro
                Infor.idcarro = idcar
                Me.Close()
            Catch ex As Exception
                MsgBox("Si deseas seleccionar el Vehiculo, Double Click sobre la fila")
            End Try

        Else
            Try
                idcar = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                vincarro = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Infor.vintxt.Text = vincarro
                Infor.idcarro = idcar
                Me.Close()
            Catch ex As Exception
                MsgBox("Si deseas seleccionar el Vehiculo, Double Click sobre la fila")
            End Try
        End If

    End Sub

    Private Sub busquedavehiculo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuOpciones.cargarvehiculos = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            EliminarActualizar = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            nombre = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Catch ex As Exception

        End Try
    End Sub

End Class