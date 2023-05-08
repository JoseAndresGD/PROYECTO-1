'
' Created by SharpDevelop.
' User: S1015
' Date: 16/02/2023
' Time: 01:00 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Public Partial Class MostrarPersonal
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	Sub MostrarPersonalLoad(sender As Object, e As EventArgs)
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
End Class
