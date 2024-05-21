Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class OpcUsuarios
    Dim cmd As SqlCommand
    Dim query As String
    Dim dt As DataTable
    Dim idusuario As Integer
    Private Sub OpcUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idusuario = InicioSeccion.idusuario

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridView1.BackgroundColor = Color.FromArgb(255, 240, 240, 240)
        DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 13.8)

        txtusuario2.Text = InicioSeccion.nombreusuario
        txtusuario2.ReadOnly = True
        txtnombre.ReadOnly = True
        txtusername.ReadOnly = True

        If InicioSeccion.idusuario = 1 Then
            txtnombre.Text = InicioSeccion.nombreusuario
            txtusername.Text = InicioSeccion.username
            DataGridView1.Visible = True
            actualizar()
        Else
            txtnombre.Text = InicioSeccion.nombreusuario
            txtusername.Text = InicioSeccion.username
            DataGridView1.Visible = False
        End If
    End Sub
    Private Sub actualizar()
        query = "select id,nombre,username from usuario where id <> 1 and estatus =1"
        DataGridView1.DataSource = Connection.SelectQuery(query)
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
                cmd.Parameters.Add("@passwordUsuario", SqlDbType.VarChar).Value = InicioSeccion.password

                Connection.ExecuteStoreProcedure(cmd, "SpActualizarUsuario")

                MsgBox("Usuario Actualizado Correctamente")

            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtusername.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtnombre.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            idusuario = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Estas a punto de borrar el usuario: " & txtusername.Text & vbCrLf & "Deseas Continuar ?" & vbCrLf, MsgBoxStyle.YesNo)
        If idusuario = 1 Then
            MsgBox("ERROR NO PUEDES BORRAR EL USUARIO ADMINISTRADOR")
            Exit Sub
        End If
        If respuesta = MsgBoxResult.Yes Then
            Try
                cmd = New SqlCommand()

                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = idusuario

                Connection.ExecuteStoreProcedure(cmd, "SpborrarUsuario")

                MsgBox("Usuario Eliminado")
                actualizar()

                txtusername.Clear()
                txtnombre.Clear()

                If Not InicioSeccion.idusuario = 1 Then
                    Dim numForms = Application.OpenForms.Count - 1
                    For i As Integer = numForms To 0 Step -1
                        If Not Application.OpenForms(i).Name = "InicioSeccion" Then
                            Application.OpenForms(i).Close()
                        End If
                    Next
                End If

            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class