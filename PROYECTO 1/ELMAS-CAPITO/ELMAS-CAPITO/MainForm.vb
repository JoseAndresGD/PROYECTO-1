'
' Created by SharpDevelop.
' User: S1015
' Date: 16/02/2023
' Time: 12:36 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MostrarPersonalClick(sender As Object, e As EventArgs)
		My.Forms.MostrarPersonal.ShowDialog
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub MostrarDepartamentoClick(sender As Object, e As EventArgs)
		My.Forms.MostrarDepartamento.ShowDialog
	End Sub
	
	Sub MostrarProductosClick(sender As Object, e As EventArgs)
		My.Forms.MostrarProducto.ShowDialog
	End Sub
	
	Sub MostrarProveedorClick(sender As Object, e As EventArgs)
		My.Forms.MostrarProveedor.ShowDialog
	End Sub
	
	Sub MainFormClick(sender As Object, e As EventArgs)
		
	End Sub
	
	
	Sub AltasPersonalClick(sender As Object, e As EventArgs)
		My.Forms.AltasPersonal.ShowDialog
	End Sub
	
	
	Sub BuscarPersonalClick(sender As Object, e As EventArgs)
		My.Forms.BuscarPersonal.ShowDialog
	End Sub
	
	Sub BorrarPersonalClick(sender As Object, e As EventArgs)
		My.Forms.BorrarPersonal.ShowDialog
	End Sub
	
	Sub AltasDepartamentoClick(sender As Object, e As EventArgs)
		My.Forms.AltasDepartamento.ShowDialog
	End Sub
	
	Sub AltaProductoClick(sender As Object, e As EventArgs)
		My.Forms.AltasProductos.ShowDialog
	End Sub
	
	Sub AltasProveedorClick(sender As Object, e As EventArgs)
		My.Forms.AltaProveedor.ShowDialog
	End Sub
End Class
