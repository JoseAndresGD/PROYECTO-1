'
' Created by SharpDevelop.
' User: S1015
' Date: 28/03/2023
' Time: 01:15 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AltasDepartamento
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
		Me.departamentoId = New System.Windows.Forms.TextBox()
		Me.departamentoDescripcion = New System.Windows.Forms.TextBox()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		Me.btnnVaciar = New System.Windows.Forms.Button()
		Me.bntBorrar = New System.Windows.Forms.Button()
		Me.btnnAgregar = New System.Windows.Forms.Button()
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(26, 26)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(126, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Id del departamento:"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(26, 72)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Descripcion:"
		'
		'departamentoId
		'
		Me.departamentoId.Location = New System.Drawing.Point(170, 26)
		Me.departamentoId.Name = "departamentoId"
		Me.departamentoId.Size = New System.Drawing.Size(168, 20)
		Me.departamentoId.TabIndex = 3
		AddHandler Me.departamentoId.TextChanged, AddressOf Me.DepartamentoIdTextChanged
		'
		'departamentoDescripcion
		'
		Me.departamentoDescripcion.Location = New System.Drawing.Point(170, 69)
		Me.departamentoDescripcion.Name = "departamentoDescripcion"
		Me.departamentoDescripcion.Size = New System.Drawing.Size(168, 20)
		Me.departamentoDescripcion.TabIndex = 4
		AddHandler Me.departamentoDescripcion.TextChanged, AddressOf Me.DepartamentoDescripcionTextChanged
		'
		'dgvDatos
		'
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(12, 191)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.Size = New System.Drawing.Size(388, 150)
		Me.dgvDatos.TabIndex = 5
		'
		'btnnVaciar
		'
		Me.btnnVaciar.Location = New System.Drawing.Point(12, 140)
		Me.btnnVaciar.Name = "btnnVaciar"
		Me.btnnVaciar.Size = New System.Drawing.Size(104, 23)
		Me.btnnVaciar.TabIndex = 6
		Me.btnnVaciar.Text = "VACIAR"
		Me.btnnVaciar.UseVisualStyleBackColor = true
		AddHandler Me.btnnVaciar.Click, AddressOf Me.BtnnVaciarClick
		'
		'bntBorrar
		'
		Me.bntBorrar.Location = New System.Drawing.Point(296, 140)
		Me.bntBorrar.Name = "bntBorrar"
		Me.bntBorrar.Size = New System.Drawing.Size(104, 23)
		Me.bntBorrar.TabIndex = 8
		Me.bntBorrar.Text = "BORRAR"
		Me.bntBorrar.UseVisualStyleBackColor = true
		AddHandler Me.bntBorrar.Click, AddressOf Me.BntBorrarClick
		'
		'btnnAgregar
		'
		Me.btnnAgregar.Location = New System.Drawing.Point(150, 140)
		Me.btnnAgregar.Name = "btnnAgregar"
		Me.btnnAgregar.Size = New System.Drawing.Size(104, 23)
		Me.btnnAgregar.TabIndex = 9
		Me.btnnAgregar.Text = "AGREGAR"
		Me.btnnAgregar.UseVisualStyleBackColor = true
		AddHandler Me.btnnAgregar.Click, AddressOf Me.BtnnAgregarClick
		'
		'AltasDepartamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(412, 353)
		Me.Controls.Add(Me.btnnAgregar)
		Me.Controls.Add(Me.bntBorrar)
		Me.Controls.Add(Me.btnnVaciar)
		Me.Controls.Add(Me.dgvDatos)
		Me.Controls.Add(Me.departamentoDescripcion)
		Me.Controls.Add(Me.departamentoId)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "AltasDepartamento"
		Me.Text = "AltasDepartamento"
		AddHandler Load, AddressOf Me.AltasDepartamentoLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnnAgregar As System.Windows.Forms.Button
	Private bntBorrar As System.Windows.Forms.Button
	Private btnnVaciar As System.Windows.Forms.Button
	Private dgvDatos As System.Windows.Forms.DataGridView
	Private departamentoDescripcion As System.Windows.Forms.TextBox
	Private departamentoId As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
