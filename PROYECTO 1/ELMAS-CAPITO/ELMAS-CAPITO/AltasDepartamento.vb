
Imports MySql.Data.MySqlClient
Public Partial Class AltasDepartamento
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub AltasDepartamentoLoad(sender As Object, e As EventArgs)
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		Dim da As MySqlDataAdapter
		Dim sql As String="select * from departamentos;"
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
	'---------------------------------------------------------------------------------------------
	Private Sub Insertar()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim cmd As New MySqlCommand("INSERT INTO DEPARTAMENTOS(IDDEPARTAMENTO,DESCRIPCION)VALUES('"&Me.departamentoId.Text &"','"&Me.departamentoDescripcion.Text &"')",conn)
		cmd.ExecuteNonQuery()
		MsgBox("Datos insertados correctamente")
		conn.Close
	End Sub
	
	Sub BtnnAgregarClick(sender As Object, e As EventArgs)
		If (departamentoId.Text<>"") And (departamentoDescripcion.Text<>"") Then
			Call Insertar()
			Call vaciar()
		Else 	
		MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
	'---------------------------------------------------------------------------------------------
	Private Sub vaciar()
		departamentoId.ResetText
		departamentoDescripcion.ResetText
	End Sub
	Sub BtnnVaciarClick(sender As Object, e As EventArgs)
		Call vaciar()
	End Sub
	'-----------------------------------------------------------------------------------------------
	Private Sub buscarIdDepto()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM DEPARTAMENTOS WHERE IDDEPARTAMENTO LIKE'%" & Me.departamentoId.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t	
	End Sub
	
	Private Sub buscarDescripDepto()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM DEPARTAMENTOS WHERE DESCRIPCION LIKE'%" & Me.departamentoDescripcion.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t
	End Sub
	'--------------------------------------------------------------------------------------------------
	Sub DepartamentoIdTextChanged(sender As Object, e As EventArgs)
		Call buscarIdDepto()
	End Sub
	
	Sub DepartamentoDescripcionTextChanged(sender As Object, e As EventArgs)
		Call buscarDescripDepto()
	End Sub
	'---------------------------------------------------------------------------------------------------
	Private Sub BorrarId()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM DEPARTAMENTOS WHERE IDDEPARTAMENTO LIKE'%" & Me.departamentoId.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Private Sub BorrarDescrip()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM DEPARTAMENTOS WHERE DESCRIPCION LIKE'%" & Me.departamentoDescripcion.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Sub BntBorrarClick(sender As Object, e As EventArgs)
		If (departamentoId.Text<>"") And (departamentoDescripcion.Text = "" ) Then
			Call BorrarId()
			Call vaciar()
		Else If (departamentoDescripcion.Text<>"") And (departamentoId.Text = "") Then	
			Call BorrarDescrip()
			Call vaciar()
		Else
			MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
	
End Class
