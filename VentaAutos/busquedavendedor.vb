Imports System.Data.SqlClient

Public Class busquedavendedor
    Dim query As String
    Public idvendedor, nombrevendedor As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged

        If Rdid.Checked Then
            query = "select id, nombre from vendedor where id like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        ElseIf RdNombre.Checked Then
            query = "select id, nombre from vendedor where nombre like '%" & txtbuscar.Text & "%'"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        End If
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

    End Sub
    Private Sub busquedavendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RdNombre.Checked = True
        txtbuscar.Text = Infor.vendedortxt.Text
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            idvendedor = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            nombrevendedor = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Infor.vendedortxt.Text = nombrevendedor
            Infor.idvendedor = idvendedor
            Me.Close()
        Catch ex As Exception
            MsgBox("Si deseas seleccionar el vendedor, Double Click sobre la fila")
        End Try
    End Sub
End Class