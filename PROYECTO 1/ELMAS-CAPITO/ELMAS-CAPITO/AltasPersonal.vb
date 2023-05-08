Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Partial Class AltasPersonal
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Private Sub Insertar()
		Dim cadCon As String=SqlConnector.cadenaConexion()
		Dim conn As MySqlConnection
		conn = New MySqlConnection(cadCon)
		conn.Open
		Dim cmd As New MySqlCommand("INSERT INTO PERSONAL(IDPERSONAL,NOMBRE,APELLIDOPATERNO,APELLIDOMATERNO,SEXO,EDAD,TELEFONO,DIRECCION,IDDEPARTAMENTO,ROL)VALUES('"&Me.idPersonalAltas.Text &"','"&Me.nombreAltas.Text &"','"&Me.apellidopAltas.Text &"','"&Me.apellidomAltas.Text &"','"&Me.sexoAltas.Text &"',"&Me.edadAltas.Text &","&Me.telefonoAltas.Text &",'"&Me.correoAltas.Text &"','"&Me.idDepartamentoAltas.Text &"','"&rolAltas.Text &"')",conn)
		cmd.ExecuteNonQuery()
		MsgBox("Datos insertados correctamente")
		conn.Close
	End Sub
	
	Private Sub borrar()
		idPersonalAltas.ResetText
		nombreAltas.ResetText
		apellidopAltas.ResetText
		apellidomAltas.ResetText
		sexoAltas.ResetText
		edadAltas.ResetText
		telefonoAltas.ResetText
		correoAltas.ResetText
		idDepartamentoAltas.ResetText
		rolAltas.ResetText
	End sub

	Sub AgregarAltasClick(sender As Object, e As EventArgs)
		If (idPersonalAltas.Text<>"") And (nombreAltas.Text<>"") And (apellidopAltas.Text<>"") And (apellidomAltas.Text<>"") And (sexoAltas.Text<>"") And (edadAltas.Text<>"") And (telefonoAltas.Text<>"") And (correoAltas.Text<>"") And (idDepartamentoAltas.Text<>"") And (rolAltas.Text<>"") Then
			Call Insertar()
			Call borrar()
		Else 	
		MsgBox("FAVOR de no dejar campos vacios")
		End If
		
	End Sub
	
	Sub BorrarAltasClick(sender As Object, e As EventArgs)
		Call borrar()
	End Sub
End Class
