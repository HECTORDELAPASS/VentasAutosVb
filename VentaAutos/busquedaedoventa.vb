Imports System.Data.SqlClient
Public Class busquedaedoventa
    Dim query As String
    Public NomEdo, IdEdo As String
    Private Sub busquedaedoventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RdNombre.Checked = True
        txtbuscar.Text = Infor.Edtxt.Text
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        ListId.Items.Clear()
        ListEdo.Items.Clear()

        If Rdid.Checked Then
            query = "select id, nombreestado from estado where id like '%" & txtbuscar.Text & "%'"

        ElseIf RdNombre.Checked Then
            query = "select id, nombreestado from estado where nombreestado  like '%" & txtbuscar.Text & "%'"
        End If
        Dim dt As DataTable = Connection.SelectQuery(query)

        For h = 0 To dt.Rows.Count - 1
            ListId.Items.Add(dt(h)(0))
            ListEdo.Items.Add(dt(h)(1))
        Next

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListId.SelectedIndexChanged
        ListEdo.SelectedIndex = ListId.SelectedIndex
    End Sub

    Private Sub ListEdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListEdo.SelectedIndexChanged
        ListId.SelectedIndex = ListEdo.SelectedIndex
    End Sub

    Private Sub ListId_DoubleClick(sender As Object, e As EventArgs) Handles ListId.DoubleClick
        NomEdo = ListEdo.SelectedItem.ToString()
        IdEdo = ListId.SelectedItem.ToString()
        Try
            Infor.Edtxt.Text = NomEdo
            Infor.idedoventa = IdEdo
            Me.Close()

        Catch ex As Exception
            MsgBox("Si deseas seleccionar el estado de venta, Double Click sobre la fila")
        End Try
    End Sub

    Private Sub ListEdo_DoubleClick(sender As Object, e As EventArgs) Handles ListEdo.DoubleClick
        NomEdo = ListEdo.SelectedItem.ToString()
        IdEdo = ListId.SelectedItem.ToString()
        Try
            Infor.Edtxt.Text = NomEdo
            Infor.idedoventa = IdEdo
            Me.Close()

        Catch ex As Exception
            MsgBox("Si deseas seleccionar el estado de venta, Double Click sobre la fila")
        End Try
    End Sub
End Class