'
' Created by SharpDevelop.
' User: S1015
' Date: 28/03/2023
' Time: 05:41 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AltaProveedor
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.idProv = New System.Windows.Forms.TextBox()
		Me.nomProv = New System.Windows.Forms.TextBox()
		Me.dirProv = New System.Windows.Forms.TextBox()
		Me.CorreoProv = New System.Windows.Forms.TextBox()
		Me.GiroProv = New System.Windows.Forms.TextBox()
		Me.btnVaciar = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.btnBorrar = New System.Windows.Forms.Button()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(43, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(118, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Id del proveedor:"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(43, 40)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(118, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Nombre:"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(43, 67)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(118, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Direccion:"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(43, 94)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(118, 23)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Correo:"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(43, 121)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(118, 23)
		Me.label5.TabIndex = 4
		Me.label5.Text = "Giro:"
		'
		'idProv
		'
		Me.idProv.Location = New System.Drawing.Point(186, 13)
		Me.idProv.Name = "idProv"
		Me.idProv.Size = New System.Drawing.Size(323, 20)
		Me.idProv.TabIndex = 5
		AddHandler Me.idProv.TextChanged, AddressOf Me.IdProvTextChanged
		'
		'nomProv
		'
		Me.nomProv.Location = New System.Drawing.Point(186, 40)
		Me.nomProv.Name = "nomProv"
		Me.nomProv.Size = New System.Drawing.Size(323, 20)
		Me.nomProv.TabIndex = 6
		AddHandler Me.nomProv.TextChanged, AddressOf Me.NomProvTextChanged
		'
		'dirProv
		'
		Me.dirProv.Location = New System.Drawing.Point(186, 67)
		Me.dirProv.Name = "dirProv"
		Me.dirProv.Size = New System.Drawing.Size(323, 20)
		Me.dirProv.TabIndex = 7
		'
		'CorreoProv
		'
		Me.CorreoProv.Location = New System.Drawing.Point(186, 94)
		Me.CorreoProv.Name = "CorreoProv"
		Me.CorreoProv.Size = New System.Drawing.Size(323, 20)
		Me.CorreoProv.TabIndex = 8
		'
		'GiroProv
		'
		Me.GiroProv.Location = New System.Drawing.Point(186, 121)
		Me.GiroProv.Name = "GiroProv"
		Me.GiroProv.Size = New System.Drawing.Size(323, 20)
		Me.GiroProv.TabIndex = 9
		'
		'btnVaciar
		'
		Me.btnVaciar.Location = New System.Drawing.Point(24, 168)
		Me.btnVaciar.Name = "btnVaciar"
		Me.btnVaciar.Size = New System.Drawing.Size(122, 23)
		Me.btnVaciar.TabIndex = 10
		Me.btnVaciar.Text = "VACIAR"
		Me.btnVaciar.UseVisualStyleBackColor = true
		AddHandler Me.btnVaciar.Click, AddressOf Me.BtnVaciarClick
		'
		'btnAgregar
		'
		Me.btnAgregar.Location = New System.Drawing.Point(221, 168)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(122, 23)
		Me.btnAgregar.TabIndex = 11
		Me.btnAgregar.Text = "AGREGAR"
		Me.btnAgregar.UseVisualStyleBackColor = true
		AddHandler Me.btnAgregar.Click, AddressOf Me.BtnAgregarClick
		'
		'btnBorrar
		'
		Me.btnBorrar.Location = New System.Drawing.Point(415, 168)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(122, 23)
		Me.btnBorrar.TabIndex = 12
		Me.btnBorrar.Text = "BORRAR"
		Me.btnBorrar.UseVisualStyleBackColor = true
		AddHandler Me.btnBorrar.Click, AddressOf Me.BtnBorrarClick
		'
		'dgvDatos
		'
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(12, 211)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.Size = New System.Drawing.Size(545, 120)
		Me.dgvDatos.TabIndex = 13
		'
		'AltaProveedor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(569, 343)
		Me.Controls.Add(Me.dgvDatos)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.btnVaciar)
		Me.Controls.Add(Me.GiroProv)
		Me.Controls.Add(Me.CorreoProv)
		Me.Controls.Add(Me.dirProv)
		Me.Controls.Add(Me.nomProv)
		Me.Controls.Add(Me.idProv)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "AltaProveedor"
		Me.Text = "AltaProveedor"
		AddHandler Load, AddressOf Me.AltaProveedorLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private dgvDatos As System.Windows.Forms.DataGridView
	Private btnBorrar As System.Windows.Forms.Button
	Private btnAgregar As System.Windows.Forms.Button
	Private btnVaciar As System.Windows.Forms.Button
	Private GiroProv As System.Windows.Forms.TextBox
	Private CorreoProv As System.Windows.Forms.TextBox
	Private dirProv As System.Windows.Forms.TextBox
	Private nomProv As System.Windows.Forms.TextBox
	Private idProv As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
