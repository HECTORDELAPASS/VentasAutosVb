Imports System.Data.SqlClient
Public Class Infor
	Dim query, s As String
	Dim temporal, permiso, cliks As Integer
	Dim Entro As Integer = 1
	Dim procedimiento As String
	Dim cmd As SqlCommand
	Dim dt As DataTable
	Public pantallaupdate, nuevaventa As Boolean
	Public idvendedor As Integer = 0, idcarro As Integer = 0, idedoventa As Integer = 0
	Private Sub NuevoRegistro()
		Label13.Text = "Registro de Nueva Venta"
		bloqueoinicio()

		BtnNuevaVenta.Visible = True
		piclogo.Visible = False
		PictureBox2.Visible = False
		PictureBox1.Visible = False
		lbagregar.Visible = True
		picbuscar.Visible = True
		nuevaventa = True
		btnbuscaredo.Visible = True
		btbuscarvendedor.Visible = True
		btnbuscarcarro.Visible = True


		query = "SELECT IDENT_CURRENT('venta')+1"
		dt = Connection.SelectQuery(query)
		idtxt.Text = dt(0)(0)

		bloqueo()
		fechventxt.Enabled = Enabled
		mmrtxt.ReadOnly = False
		Ventatxt.ReadOnly = False
		conditxt.ReadOnly = False
		kmtxt.ReadOnly = False
	End Sub
	Private Sub limpiar()
		modelotxt.Clear()
		agentxt.Clear()
		yeartxt.Clear()
		txtcarroceria.Clear()
		Variatxt.Clear()
		colortxt.Clear()
		inttxt.Clear()
		trastxt.Clear()
		fechventxt.Value = Today
		Ventatxt.Clear()
		mmrtxt.Clear()
		vendedortxt.Clear()
		Edtxt.Clear()
		vintxt.Clear()
		conditxt.Clear()
		kmtxt.Clear()

		idvendedor = 0
		idcarro = 0
		idedoventa = 0

	End Sub
	Private Sub bloqueoinicio()
		Label4.Visible = False
		cboventa.Visible = False
		pic1.Visible = False
		lab1.Visible = False
		btnbuscarcarro.Visible = False
		btnbuscaredo.Visible = False
		btbuscarvendedor.Visible = False
		BtnNuevaVenta.Visible = False
		lbagregar.Visible = False
		picbuscar.Visible = False
	End Sub
	Private Sub Infor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Form1.NuevaVenta Then
			Form1.NuevaVenta = False
			NuevoRegistro()
		Else
			nuevaventa = False
			cliks = 0
			cboventa.DropDownStyle = ComboBoxStyle.DropDownList
			bloqueoinicio()
			s = Form1.rows
			query = "select carro.codigovehiculo, count(carro.codigovehiculo)
				from venta
				inner join carro on venta.idcarro = carro.id
				where carro.codigovehiculo ='" & s & "' and venta.estatus = 1
				group by carro.codigovehiculo"
			dt = Connection.SelectQuery(query)
			temporal = dt.Rows(0)(1)
			Try
				llenado()
				bloqueo()
				valorespordefecto()
			Catch ex As Exception
			End Try
		End If
	End Sub
	Private Sub bloqueo()
		idtxt.ReadOnly = True
		fechventxt.Enabled = False
		mmrtxt.ReadOnly = True
		Ventatxt.ReadOnly = True
		vendedortxt.ReadOnly = True
		modelotxt.ReadOnly = True
		yeartxt.ReadOnly = True
		conditxt.ReadOnly = True
		kmtxt.ReadOnly = True
		agentxt.ReadOnly = True
		Variatxt.ReadOnly = True
		txtcarroceria.ReadOnly = True
		trastxt.ReadOnly = True
		colortxt.ReadOnly = True
		inttxt.ReadOnly = True
		Edtxt.ReadOnly = True
		vintxt.ReadOnly = True
	End Sub
	Private Sub cboventa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboventa.SelectedIndexChanged
		If Entro = 1 Then
			llenado()
		End If
	End Sub
	Public Sub valorespordefecto()
		query = "select idvendedor, idcarro, idestado from venta inner join carro on carro.id = venta.idcarro
				 where venta.id = '" & idtxt.Text & "'"
		dt = Connection.SelectQuery(query)


		idvendedor = dt(0)(0)
		idcarro = dt(0)(1)
		idedoventa = dt(0)(2)

	End Sub
Private Sub llenado()
		If cboventa.SelectedItem Is Nothing Then
			query = "select * from VWInfoCarro WHERE [Codigovehiculo] = '" & s & " '"
		Else
			query = "Select * From VWInfoCarro Where [id] = '" & (cboventa.SelectedItem) & "'"
		End If
		dt = Connection.SelectQuery(query)
		Dim fila As Integer = dt.Rows.Count
		Dim columna As Integer = dt.Columns.Count

		Dim matriz(fila - 1, columna - 1) As Object
		For i As Integer = 0 To fila - 1
			For j As Integer = 0 To columna - 1
				matriz(i, j) = dt.Rows(i)(j)
			Next
		Next
		If temporal > 1 And cboventa.SelectedItem Is Nothing Then
			MsgBox("Existe mas de una venta, para mas informacion " & vbCrLf & "ir a esquina superior derecha")
			Label4.Visible = True
			cboventa.Visible = True
			pic1.Visible = True
			lab1.Visible = True
			For h = 0 To temporal - 1
				cboventa.Items.Add(matriz(h, 0)).ToString()
			Next
		End If
		idtxt.Text = dt.Rows(0)(0)
		fechventxt.Text = dt.Rows(0)(1)
		mmrtxt.Text = dt.Rows(0)(2)
		Ventatxt.Text = dt.Rows(0)(3)
		vendedortxt.Text = dt.Rows(0)(4)
		modelotxt.Text = dt.Rows(0)(5)
		yeartxt.Text = dt.Rows(0)(6)
		conditxt.Text = dt.Rows(0)(7)
		kmtxt.Text = dt.Rows(0)(8)
		agentxt.Text = dt.Rows(0)(9)
		Variatxt.Text = dt.Rows(0)(10)
		txtcarroceria.Text = dt.Rows(0)(11)
		trastxt.Text = dt.Rows(0)(12)
		colortxt.Text = dt.Rows(0)(13)
		inttxt.Text = dt.Rows(0)(14)
		Edtxt.Text = dt.Rows(0)(15)
		vintxt.Text = dt.Rows(0)(16)
		Dim url As String = "https://logo.clearbit.com/" & agentxt.Text & ".com"

		If LogoExists(url) Then
			piclogo.Load(url)
		End If
	End Sub
	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		eliminar()
	End Sub

	Private Sub btnbuscarcarro_Click(sender As Object, e As EventArgs) Handles btnbuscarcarro.Click
		busquedavehiculo.Show()
	End Sub

	Private Sub BtnNuevaVenta_Click(sender As Object, e As EventArgs) Handles BtnNuevaVenta.Click
		Dim respuesta As MsgBoxResult
		respuesta = MsgBox("Se agregará una nueva venta vinculada a tu cuenta." & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

		If respuesta = MsgBoxResult.Yes Then
			Try
				cmd = New SqlCommand()
				cmd.Parameters.Add("@fechaventa", SqlDbType.DateTime).Value = fechventxt.Text
				cmd.Parameters.Add("@mmr", SqlDbType.Int).Value = mmrtxt.Text
				cmd.Parameters.Add("@precioventa", SqlDbType.Int).Value = Ventatxt.Text
				cmd.Parameters.Add("@condicion", SqlDbType.Int).Value = conditxt.Text
				cmd.Parameters.Add("@kilometraje", SqlDbType.Int).Value = kmtxt.Text
				cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = idvendedor
				cmd.Parameters.Add("@idcarro", SqlDbType.Int).Value = idcarro
				cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idedoventa
				cmd.Parameters.Add("@idusuariocrea", SqlDbType.Int).Value = InicioSeccion.idusuario
				Connection.ExecuteStoreProcedure(cmd, "SpAgregarVenta")

				query = "select max(id) from venta"
				dt = Connection.SelectQuery(query)
				Dim comprobacion = dt(0)(0)

				If comprobacion = idtxt.Text Then
					MsgBox("Nueva Venta Registrada Correctamente")
				Else
					MsgBox("Error al agregar la venta")
				End If
				limpiar()
			Catch ex As Exception
				MsgBox("Error al agregar la venta: " & ex.Message)
			End Try
		End If

		query = "SELECT IDENT_CURRENT('venta')+1"
		dt = Connection.SelectQuery(query)
		idtxt.Text = dt(0)(0)
	End Sub

	Private Sub picbuscar_Click(sender As Object, e As EventArgs) Handles picbuscar.Click
		busquedavehiculo.Show()
	End Sub

	Private Sub btbuscarvendedor_Click(sender As Object, e As EventArgs) Handles btbuscarvendedor.Click
		busquedavendedor.Show()
	End Sub

	Private Sub btnbuscaredo_Click(sender As Object, e As EventArgs) Handles btnbuscaredo.Click
		busquedaedoventa.Show()
	End Sub

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
		cliks += 1
		btnbuscarcarro.Visible = True
		btnbuscaredo.Visible = True
		btbuscarvendedor.Visible = True

		If cliks = 1 Then
			pantallaupdate = True
			Carga.Show()
			fechventxt.Enabled = True
			mmrtxt.ReadOnly = False
			Ventatxt.ReadOnly = False
			conditxt.ReadOnly = False
			kmtxt.ReadOnly = False
			valorespordefecto()
			cboventa.Visible = False
		ElseIf cliks >= 2 Then
			Dim horaHoy As String = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")

			If (idvendedor <> 0 And idcarro <> 0 And idedoventa <> 0) Then
				cmd = New SqlCommand()
				cmd.Parameters.Add("@idventa", SqlDbType.Int).Value = idtxt.Text
				cmd.Parameters.Add("@fechaventa", SqlDbType.DateTime).Value = fechventxt.Text
				cmd.Parameters.Add("@mmr", SqlDbType.Int).Value = mmrtxt.Text
				cmd.Parameters.Add("@precioventa", SqlDbType.Int).Value = Ventatxt.Text
				cmd.Parameters.Add("@condicion", SqlDbType.Int).Value = conditxt.Text
				cmd.Parameters.Add("@kilometraje", SqlDbType.Int).Value = kmtxt.Text
				cmd.Parameters.Add("@idvendedor", SqlDbType.Int).Value = idvendedor
				cmd.Parameters.Add("@idcarro", SqlDbType.Int).Value = idcarro
				cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
				cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = horaHoy
				cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idedoventa
				Connection.ExecuteStoreProcedure(cmd, "spactualizarventa")
				cliks = 0

				query = "select fechamodifica from venta where id = '" & idtxt.Text & "'"
				dt = Connection.SelectQuery(query)
				Dim comprobacion As String = dt(0)(0)

				If horahoy = comprobacion Then
					MsgBox("Actualizacion realizada correctamente")
				Else
					MsgBox("Error al actulizar " & vbCrLf & "Revisa los campos")
				End If

				btnbuscarcarro.Visible = False
				btnbuscaredo.Visible = False
				btbuscarvendedor.Visible = False
				bloqueo()
			Else
				MsgBox("Inserta el vendedor desde la busqueda avanzada" & vbCrLf & "Inserta el Vin de carro desde la busqueda avanzada" & vbCrLf & "Inserta el Estado de venta desde la busqueda avanzada")
			End If
			cboventa.Visible = True
		End If
	End Sub
	Public Sub eliminar()
		Entro = 0
		Dim respuesta As MsgBoxResult
		respuesta = MsgBox("Vas a borrar la venta seleccionada " & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

		If respuesta = MsgBoxResult.Yes Then
			Try
				cmd = New SqlCommand()
				cmd.Parameters.Add("@idventa", SqlDbType.Int).Value = idtxt.Text
				cmd.Parameters.Add("@idusuariomodifica", SqlDbType.Int).Value = InicioSeccion.idusuario
				cmd.Parameters.Add("@fechamodifica", SqlDbType.DateTime).Value = DateTime.Now

				Connection.ExecuteStoreProcedure(cmd, "spborrarventa")

				query = "select estatus from venta where id = '" & idtxt.Text & "'"
				dt = Connection.SelectQuery(query)

				If dt(0)(0) = 0 Then
					MsgBox("Venta borrada. No podras acceder mas a esta venta")
					cboventa.Items.Remove(cboventa.SelectedItem)
					limpiar()
				Else
					MsgBox("Error al borrar venta" & vbCrLf & "Intentar mas tarde")
				End If
			Catch ex As Exception
			End Try
		End If
		Entro = 1
	End Sub
	Private Function LogoExists(url As String) As Boolean
		Dim request As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(url), System.Net.HttpWebRequest)
		request.Method = "HEAD"
		Try
			Using response As System.Net.HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
				Return (response.StatusCode = System.Net.HttpStatusCode.OK)
			End Using
		Catch ex As System.Net.WebException
			Return False
		End Try
	End Function
End Class