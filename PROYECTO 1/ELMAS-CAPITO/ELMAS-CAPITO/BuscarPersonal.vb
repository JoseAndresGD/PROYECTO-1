'
' Created by SharpDevelop.
' User: S1015
' Date: 27/03/2023
' Time: 11:00 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
Imports MySql.Data.MySqlClient
Public Partial Class BuscarPersonal
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BuscarPersonalLoad(sender As Object, e As EventArgs)
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		Dim da As MySqlDataAdapter
		Dim sql As String="select * from personal;"
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
	
	Private Sub buscarId()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PERSONAL WHERE IDPERSONAL LIKE'%" & Me.idpersonalBuscar.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t	
	End Sub
	
	Private Sub buscarNombre()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PERSONAL WHERE NOMBRE LIKE '%" & Me.nombrebuscar.Text & "%' AND APELLIDOPATERNO LIKE '%" & Me.apellidopBuscar.Text & "%'"  , conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t
	End Sub
	
	Sub IdpersonalBuscarTextChanged(sender As Object, e As EventArgs)
		Call buscarId()
	End Sub
	
	Sub BtnFiltrarClick(sender As Object, e As EventArgs)
		If (nombrebuscar.text<>"") Then
			Call buscarNombre()
		Else
			MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
	
	Sub NombrebuscarTextChanged(sender As Object, e As EventArgs)
		Call buscarNombre()
	End Sub
End Class
