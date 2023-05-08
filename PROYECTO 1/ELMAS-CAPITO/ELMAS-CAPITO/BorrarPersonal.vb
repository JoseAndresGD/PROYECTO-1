﻿'
' Created by SharpDevelop.
' User: S1015
' Date: 28/03/2023
' Time: 01:55 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
Imports MySql.Data.MySqlClient
Public Partial Class BorrarPersonal
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BorrarPersonalLoad(sender As Object, e As EventArgs)
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
	
	Private Sub personalBorrarId()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim t As New Data.DataTable("miTabla")
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		Dim da As New MySqlDataAdapter("SELECT* FROM PERSONAL WHERE IDPERSONAL LIKE'%" & Me.BorrarIdPersonal.Text & "%'", conn)
    	da.Fill(t)
    	Me.dgvDatos.DataSource= t
	End Sub
	
	Sub BorrarIdPersonalTextChanged(sender As Object, e As EventArgs)
		Call personalBorrarId()
	End Sub
	
	Private Sub Borrado()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim da As New MySqlCommand("DELETE FROM PERSONAL WHERE IDPERSONAL LIKE'%" & Me.BorrarIdPersonal.Text & "%'",conn)
	 	da.ExecuteNonQuery
	 	MsgBox("Datos Borrados Correctamente")
	 	conn.Close
	End Sub
	
	Private Sub vaciar()
		BorrarIdPersonal.ResetText
	End Sub
	
	Sub BtnBorrarClick(sender As Object, e As EventArgs)
		If (BorrarIdPersonal.Text<>"") Then
			Call Borrado()
			Call vaciar()
		Else 	
		MsgBox("FAVOR de no dejar campos vacios")
		End If
	End Sub
End Class
