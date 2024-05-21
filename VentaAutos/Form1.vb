Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Web

Public Class Form1
    Public rows As String
    Dim query As String
    Private auto, filtradoFecha As Boolean
    Dim min, max, primero, segundo As Integer
    Public pantallamasinfo, NuevaVenta As Boolean

    Public Sub New()

        ' This call is required by the designer.
        auto = True
        InitializeComponent()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240)

        query = "select id, nombreestado from estado order by nombreestado"
        CboEdo.DataSource = Connection.SelectQuery(query)
        CboEdo.DisplayMember = "NombreEstado"
        CboEdo.ValueMember = "id"
        auto = False

    End Sub

    Private Sub CboEdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEdo.SelectedIndexChanged
        If auto Then
            Exit Sub
        End If
        query = "SELECT * FROM vwbuscaedo WHERE idestado = " & CboEdo.SelectedValue

        CboAgen.DataSource = Connection.SelectQuery(query)
        CboAgen.DisplayMember = "nombre"
        CboAgen.ValueMember = "id"
        filtrar()
        actualizayear()

        filtradoFecha = False

    End Sub

    Private Sub CboAgen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAgen.SelectedIndexChanged
        If auto Then
            Exit Sub
        End If
        If CboEdo.Text Is Nothing Then
            Exit Sub
        End If
        query = "select * from VWBusquedaCarro where [Nombre Agencia] = '" & CboAgen.Text & "' and [Estado De Venta] = '" & CboEdo.Text & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)
        llenadoyear()
        filtrar()

    End Sub
    Private Sub filtrar()

        If filtradoFecha And R1.Checked Then
            query = "select * from VWBusquedaCarro where [Nombre De carro] like '%" & txtbuscar.Text & "%' and [Estado De Venta]  = '" & CboEdo.Text & "' and [Año de carro] BETWEEN " & primero.ToString & " And " & segundo.ToString & " order by [Año de carro] asc"
            DataGridView1.DataSource = Connection.SelectQuery(query)
            '''''''''''''''''''
            actualizayear()

        Else
            If txtbuscar.Text = "" Then
                Exit Sub
            End If
            query = "select * from VWBusquedaCarro where [Nombre De carro] like '%" & txtbuscar.Text & "%' and [Estado De Venta]  = '" & CboEdo.Text & "'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
            '''''''''''''''''''
            actualizayear()
        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If auto Or CboAgen.Text Is Nothing Then
            Exit Sub
        End If
        filtrar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboYear.DropDownStyle = ComboBoxStyle.DropDownList
        CboEdo.DropDownStyle = ComboBoxStyle.DropDownList
        CboAgen.DropDownStyle = ComboBoxStyle.DropDownList
        R1.Checked = True
    End Sub
    Private Sub llenadoyear()
        actualizayear()
        CboYear.Items.Clear()
        Dim vueltas As Double = Math.Ceiling((max - min) / 5)
        Dim temporal = min

        For h = 1 To vueltas
            CboYear.Items.Add(temporal & " - " & temporal + 5)
            temporal += 5
        Next h
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Infor.Show()
    End Sub

    Private Sub d_Click(sender As Object, e As EventArgs) Handles d.Click

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NuevaVenta = True
        Infor.Show()
        tip.Show()
    End Sub

    Private Sub actualizayear()
        Try
            query = "select min([Año de carro]) as [AñoMinimo], max([Año de carro]) as [AñoMaximo] from VWBusquedaCarro where [Nombre De carro] like '%" & txtbuscar.Text & "%' and [Estado De Venta]  = '" & CboEdo.Text & "'"
            Dim dt As DataTable
            dt = Connection.SelectQuery(query)

            If dt.Rows.Count > 0 Then
                min = dt.Rows(0)(0).ToString()
                max = dt.Rows(0)(1).ToString()
            End If
        Catch ex As Exception
            'MsgBox("Error al ejecutar la consulta: " & ex.Message)
            min = 0
            max = 0
        End Try

    End Sub

    Private Sub CboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboYear.SelectedIndexChanged
        Try
            filtradoFecha = True

            primero = (CboYear.SelectedItem).substring(0, 4)
            segundo = (CboYear.SelectedItem).substring(7, 4)

            filtrar()
        Catch ex As Exception
            MsgBox("Error al localizar las fechas")
        End Try

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        pantallamasinfo = True
        Try
            rows = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            Carga.Show()
        Catch ex As Exception
            MsgBox("Si deseas conocer mas informacion de la venta, Double Click sobre el modelo del carro")
        End Try

    End Sub
End Class
