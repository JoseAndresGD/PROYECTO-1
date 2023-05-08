'
' Created by SharpDevelop.
' User: S1015
' Date: 16/02/2023
' Time: 01:44 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class SqlConnector
	Private Shared cadCon As String= _ 
		"server=localhost;user id=root; password=123456; database=ELMAS-CAPITO; pooling=false"

	public shared function cadenaConexion As string 
			return cadCon
	End function
End Class
