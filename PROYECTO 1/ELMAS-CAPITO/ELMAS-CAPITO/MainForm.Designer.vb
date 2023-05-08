'
' Created by SharpDevelop.
' User: S1015
' Date: 16/02/2023
' Time: 12:36 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.personalMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarPersonal = New System.Windows.Forms.ToolStripMenuItem()
		Me.altasPersonal = New System.Windows.Forms.ToolStripMenuItem()
		Me.buscarPersonal = New System.Windows.Forms.ToolStripMenuItem()
		Me.borrarPersonal = New System.Windows.Forms.ToolStripMenuItem()
		Me.dEPARTAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarDepartamento = New System.Windows.Forms.ToolStripMenuItem()
		Me.altasDepartamento = New System.Windows.Forms.ToolStripMenuItem()
		Me.pRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarProductos = New System.Windows.Forms.ToolStripMenuItem()
		Me.altaProducto = New System.Windows.Forms.ToolStripMenuItem()
		Me.pROVEEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarProveedor = New System.Windows.Forms.ToolStripMenuItem()
		Me.altasProveedor = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.personalMenu, Me.dEPARTAMENTOSToolStripMenuItem, Me.pRODUCTOSToolStripMenuItem, Me.pROVEEDORESToolStripMenuItem, Me.toolStripMenuItem1, Me.toolStripMenuItem2})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(428, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'personalMenu
		'
		Me.personalMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mostrarPersonal, Me.altasPersonal, Me.buscarPersonal, Me.borrarPersonal})
		Me.personalMenu.Name = "personalMenu"
		Me.personalMenu.Size = New System.Drawing.Size(77, 20)
		Me.personalMenu.Text = "PERSONAL"
		'
		'mostrarPersonal
		'
		Me.mostrarPersonal.Name = "mostrarPersonal"
		Me.mostrarPersonal.Size = New System.Drawing.Size(128, 22)
		Me.mostrarPersonal.Text = "MOSTRAR"
		AddHandler Me.mostrarPersonal.Click, AddressOf Me.MostrarPersonalClick
		'
		'altasPersonal
		'
		Me.altasPersonal.Name = "altasPersonal"
		Me.altasPersonal.Size = New System.Drawing.Size(128, 22)
		Me.altasPersonal.Text = "ALTAS"
		AddHandler Me.altasPersonal.Click, AddressOf Me.AltasPersonalClick
		'
		'buscarPersonal
		'
		Me.buscarPersonal.Name = "buscarPersonal"
		Me.buscarPersonal.Size = New System.Drawing.Size(128, 22)
		Me.buscarPersonal.Text = "BUSCAR"
		AddHandler Me.buscarPersonal.Click, AddressOf Me.BuscarPersonalClick
		'
		'borrarPersonal
		'
		Me.borrarPersonal.Name = "borrarPersonal"
		Me.borrarPersonal.Size = New System.Drawing.Size(128, 22)
		Me.borrarPersonal.Text = "BORRAR"
		AddHandler Me.borrarPersonal.Click, AddressOf Me.BorrarPersonalClick
		'
		'dEPARTAMENTOSToolStripMenuItem
		'
		Me.dEPARTAMENTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mostrarDepartamento, Me.altasDepartamento})
		Me.dEPARTAMENTOSToolStripMenuItem.Name = "dEPARTAMENTOSToolStripMenuItem"
		Me.dEPARTAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
		Me.dEPARTAMENTOSToolStripMenuItem.Text = "DEPARTAMENTOS"
		'
		'mostrarDepartamento
		'
		Me.mostrarDepartamento.Name = "mostrarDepartamento"
		Me.mostrarDepartamento.Size = New System.Drawing.Size(128, 22)
		Me.mostrarDepartamento.Text = "MOSTRAR"
		AddHandler Me.mostrarDepartamento.Click, AddressOf Me.MostrarDepartamentoClick
		'
		'altasDepartamento
		'
		Me.altasDepartamento.Name = "altasDepartamento"
		Me.altasDepartamento.Size = New System.Drawing.Size(128, 22)
		Me.altasDepartamento.Text = "ALTAS"
		AddHandler Me.altasDepartamento.Click, AddressOf Me.AltasDepartamentoClick
		'
		'pRODUCTOSToolStripMenuItem
		'
		Me.pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mostrarProductos, Me.altaProducto})
		Me.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem"
		Me.pRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
		Me.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
		'
		'mostrarProductos
		'
		Me.mostrarProductos.Name = "mostrarProductos"
		Me.mostrarProductos.Size = New System.Drawing.Size(128, 22)
		Me.mostrarProductos.Text = "MOSTRAR"
		AddHandler Me.mostrarProductos.Click, AddressOf Me.MostrarProductosClick
		'
		'altaProducto
		'
		Me.altaProducto.Name = "altaProducto"
		Me.altaProducto.Size = New System.Drawing.Size(128, 22)
		Me.altaProducto.Text = "ALTAS"
		AddHandler Me.altaProducto.Click, AddressOf Me.AltaProductoClick
		'
		'pROVEEDORESToolStripMenuItem
		'
		Me.pROVEEDORESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mostrarProveedor, Me.altasProveedor})
		Me.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem"
		Me.pROVEEDORESToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
		Me.pROVEEDORESToolStripMenuItem.Text = "PROVEEDORES"
		'
		'mostrarProveedor
		'
		Me.mostrarProveedor.Name = "mostrarProveedor"
		Me.mostrarProveedor.Size = New System.Drawing.Size(152, 22)
		Me.mostrarProveedor.Text = "MOSTRAR"
		AddHandler Me.mostrarProveedor.Click, AddressOf Me.MostrarProveedorClick
		'
		'altasProveedor
		'
		Me.altasProveedor.Name = "altasProveedor"
		Me.altasProveedor.Size = New System.Drawing.Size(152, 22)
		Me.altasProveedor.Text = "ALTAS"
		AddHandler Me.altasProveedor.Click, AddressOf Me.AltasProveedorClick
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
		'
		'toolStripMenuItem2
		'
		Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
		Me.toolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(428, 261)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "ELMAS-CAPITO"
		AddHandler Load, AddressOf Me.MainFormLoad
		AddHandler Click, AddressOf Me.MainFormClick
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private altasProveedor As System.Windows.Forms.ToolStripMenuItem
	Private altaProducto As System.Windows.Forms.ToolStripMenuItem
	Private altasDepartamento As System.Windows.Forms.ToolStripMenuItem
	Private borrarPersonal As System.Windows.Forms.ToolStripMenuItem
	Private buscarPersonal As System.Windows.Forms.ToolStripMenuItem
	Private altasPersonal As System.Windows.Forms.ToolStripMenuItem
	Private mostrarProveedor As System.Windows.Forms.ToolStripMenuItem
	Private pROVEEDORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mostrarProductos As System.Windows.Forms.ToolStripMenuItem
	Private pRODUCTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private mostrarDepartamento As System.Windows.Forms.ToolStripMenuItem
	Private dEPARTAMENTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mostrarPersonal As System.Windows.Forms.ToolStripMenuItem
	Private personalMenu As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
