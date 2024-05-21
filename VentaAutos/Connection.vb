Imports System.Data.SqlClient
Public Class Connection
    Shared cnx As New SqlConnection
    Private Shared Sub connect()
        Try
            cnx.ConnectionString = "Data Source=DESKTOP-3AGDMLR\SQLEXPRESS; Initial Catalog=ventasautos;Integrated Security=True"
            cnx.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub
    Private Shared Sub disconect()
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar la base de datos" & ex.Message)
        End Try
    End Sub
    Public Shared Function SelectQuery(ByVal query As String) As DataTable
        Dim dt As New DataTable
        Try
            connect()
            Dim cmd As New SqlCommand(query, cnx)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            disconect()
        End Try
        Return dt
    End Function
    Public Shared Sub Deletedata(ByVal deleteQuery As String)
        Try
            connect()
            Dim cmd As New SqlCommand(deleteQuery, cnx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta de eliminación: " & ex.Message)
        Finally
            disconect()
        End Try
    End Sub
    Public Shared Sub ExecuteStoreProcedure(cmd As SqlCommand, spName As String)
        Try
            connect()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = spName

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar el stored procedure: " & ex.Message)
        Finally
            disconect()
        End Try
    End Sub

    Public Shared Sub VisibleoNo(p As Panel, estado As Boolean)
        'For Each c As TextBox In
        '    p.Controls.OfType(Of TextBox)
        '    c.Visible = estado
        'Next

        For Each c In p.Controls
            If TypeOf c Is TextBox OrElse TypeOf c Is Button OrElse TypeOf c Is Label OrElse TypeOf c Is PictureBox Then
                c.Visible = estado
            End If
        Next

        If estado = True Then
            p.BringToFront()
        End If
    End Sub

End Class


