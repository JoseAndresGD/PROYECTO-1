Imports MySql.Data.MySqlClient
Public Partial Class AltaProveedor
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	
	Sub AltaProveedorLoad(sender As Object, e As EventArgs)
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		Dim da As MySqlDataAdapter
		Dim sql As String="select * from proveedores;"
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
	'------------------------------------------------------------------------------------------
	Private Sub Insertar()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim cmd As New MySqlCommand("INSERT INTO PROVEEDORES(IDPROVEEDOR,NOMBRE,DIRECCION,CORREO,GIRO)VALUES('"&Me.idProv.Text &"','"&Me.nomProv.Text &"','"&Me.dirProv.Text &"','"&Me.CorreoProv.Text &"','"&Me.GiroProv.Text &"')",conn)
		cmd.ExecuteNonQuery()
		MsgBox("Datos insertados correctamente")
		conn.Close
	End Sub
	
	Sub BtnAgregarClick(sender As Object, e As EventArgs)
		If (idProv.Text<>"") And (nomProv.Text<>"") And (dirProv.Text<>"") And (CorreoProv.Text<>"") And (GiroProv.Text<>"") Then
			Call Insertar()
			Call vaciar()
		Else 	
		MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
	'----------------------------------------------------------------------------------------------
	Private Sub vaciar()
		idProv.ResetText
		nomProv.ResetText
		dirProv.ResetText
		CorreoProv.ResetText
		GiroProv.ResetText
	End Sub
	
	Sub BtnVaciarClick(sender As Object, e As EventArgs)
		Call vaciar()
	End Sub
	'--------------------------------------------------------------------------------------------
	Private Sub buscarIdProv()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PROVEEDORES WHERE IDPROVEEDOR LIKE'%" & Me.idProv.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t	
	End Sub
	
	Private Sub buscarNombreProv()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PROVEEDORES WHERE NOMBRE LIKE'%" & Me.nomProv.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t
	End Sub
	'--------------------------------------------------------------------------------------------
	Sub IdProvTextChanged(sender As Object, e As EventArgs)
		Call buscarIdProv()
	End Sub

	Sub NomProvTextChanged(sender As Object, e As EventArgs)
		Call buscarNombreProv()
	End Sub
	'--------------------------------------------------------------------------------------------
	Private Sub borrarIdProv()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM PROVEEDORES WHERE IDPROVEEDOR LIKE'%" & Me.idProv.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Private Sub borrarNombreProv()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM PROVEEDORES WHERE NOMBRE LIKE'%" & Me.nomProv.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Sub BtnBorrarClick(sender As Object, e As EventArgs)
		If (idProv.Text<>"") And (nomProv.Text = "" ) Then
			Call borrarIdProv()
			Call vaciar()
		Else If (nomProv.Text<>"") And (idProv.Text = "") Then	
			Call borrarNombreProv()
			Call vaciar()
		Else
			MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
End Class
