Imports MySql.Data.MySqlClient
Public Partial Class AltasProductos
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub AltasProductosLoad(sender As Object, e As EventArgs)
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		Dim da As MySqlDataAdapter
		Dim sql As String="select * from productos;"
		conn = New MySqlConnection(cadCon) 
        Try
        	da = New MySqlDataAdapter(sql, conn)
        	da.Fill(t)
        	Me.dgvDatos.DataSource=t
        	conn.Close()
        Catch ex As Exception
        	msgbox("No se pudo conectar a MySql  " & ex.Message )
        End Try
	End Sub
	'-------------------------------------------------------------------------------------------
	Private Sub Insertar()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim cmd As New MySqlCommand("INSERT INTO PRODUCTOS(CODIGO,DESCRIPCION,PRECIO,EXISTENCIA,IDDEPARTAMENTO)VALUES('"&Me.codigoProd.Text &"','"&Me.descripProd.Text &"',"&Me.precioProd.Text &","&Me.existProd.Text &",'"&Me.idDeptoProd.Text &"')",conn)
		cmd.ExecuteNonQuery()
		MsgBox("Datos insertados correctamente")
		conn.Close
	End Sub
	
	Sub BtnAgregarClick(sender As Object, e As EventArgs)
		If (codigoProd.Text<>"") And (descripProd.Text<>"") And (precioProd.Text<>"") And (existProd.Text<>"") And (idDeptoProd.Text<>"") Then
			Call Insertar()
			Call vaciar()
		Else 	
		MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
	'---------------------------------------------------------------------------------------------
	Private Sub vaciar()
		codigoProd.ResetText
		descripProd.ResetText
		precioProd.ResetText
		existProd.ResetText
		idDeptoProd.ResetText
	End Sub
	
	Sub BtnVaciarClick(sender As Object, e As EventArgs)
		Call vaciar()
	End Sub
	'---------------------------------------------------------------------------------------------
	Private Sub buscarIdProd()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PRODUCTOS WHERE CODIGO LIKE'%" & Me.codigoProd.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t	
	End Sub
	
	Private Sub buscarDescripProd()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PRODUCTOS WHERE DESCRIPCION LIKE'%" & Me.descripProd.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t
	End Sub
	'---------------------------------------------------------------------------------------------
	Sub CodigoProdTextChanged(sender As Object, e As EventArgs)
		Call buscarIdProd()
	End Sub
	
	Sub DescripProdTextChanged(sender As Object, e As EventArgs)
		Call buscarDescripProd
	End Sub
	'----------------------------------------------------------------------------------------------
	Private Sub borrarIdProd()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM PRODUCTOS WHERE CODIGO LIKE'%" & Me.codigoProd.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Private Sub borrarDescripProd()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM PRODUCTOS WHERE DESCRIPCION LIKE'%" & Me.descripProd.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Sub BtnBorrarClick(sender As Object, e As EventArgs)
		If (codigoProd.Text<>"") And (descripProd.Text = "" ) Then
			Call borrarIdProd()
			Call vaciar()
		Else If (descripProd.Text<>"") And (codigoProd.Text = "") Then	
			Call borrarDescripProd()
			Call vaciar()
		Else
			MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
End Class
