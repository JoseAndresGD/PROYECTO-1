'
' Created by SharpDevelop.
' User: S1015
' Date: 28/03/2023
' Time: 04:24 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AltasProductos
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
		Me.codigoProd = New System.Windows.Forms.TextBox()
		Me.descripProd = New System.Windows.Forms.TextBox()
		Me.precioProd = New System.Windows.Forms.TextBox()
		Me.existProd = New System.Windows.Forms.TextBox()
		Me.idDeptoProd = New System.Windows.Forms.TextBox()
		Me.btnVaciar = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.btnBorrar = New System.Windows.Forms.Button()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(13, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "SKU:"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(13, 39)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "DESCRIPCION"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(13, 67)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "PRECIO"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(13, 94)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 3
		Me.label4.Text = "EXISTENCIA"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(13, 121)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(149, 23)
		Me.label5.TabIndex = 4
		Me.label5.Text = "ID DEL DEPARTAMENTO"
		'
		'codigoProd
		'
		Me.codigoProd.Location = New System.Drawing.Point(155, 10)
		Me.codigoProd.Name = "codigoProd"
		Me.codigoProd.Size = New System.Drawing.Size(205, 20)
		Me.codigoProd.TabIndex = 5
		AddHandler Me.codigoProd.TextChanged, AddressOf Me.CodigoProdTextChanged
		'
		'descripProd
		'
		Me.descripProd.Location = New System.Drawing.Point(155, 36)
		Me.descripProd.Name = "descripProd"
		Me.descripProd.Size = New System.Drawing.Size(205, 20)
		Me.descripProd.TabIndex = 6
		AddHandler Me.descripProd.TextChanged, AddressOf Me.DescripProdTextChanged
		'
		'precioProd
		'
		Me.precioProd.Location = New System.Drawing.Point(155, 62)
		Me.precioProd.Name = "precioProd"
		Me.precioProd.Size = New System.Drawing.Size(205, 20)
		Me.precioProd.TabIndex = 7
		'
		'existProd
		'
		Me.existProd.Location = New System.Drawing.Point(155, 88)
		Me.existProd.Name = "existProd"
		Me.existProd.Size = New System.Drawing.Size(205, 20)
		Me.existProd.TabIndex = 8
		'
		'idDeptoProd
		'
		Me.idDeptoProd.Location = New System.Drawing.Point(155, 114)
		Me.idDeptoProd.Name = "idDeptoProd"
		Me.idDeptoProd.Size = New System.Drawing.Size(205, 20)
		Me.idDeptoProd.TabIndex = 9
		'
		'btnVaciar
		'
		Me.btnVaciar.Location = New System.Drawing.Point(13, 165)
		Me.btnVaciar.Name = "btnVaciar"
		Me.btnVaciar.Size = New System.Drawing.Size(107, 23)
		Me.btnVaciar.TabIndex = 10
		Me.btnVaciar.Text = "VACIAR"
		Me.btnVaciar.UseVisualStyleBackColor = true
		AddHandler Me.btnVaciar.Click, AddressOf Me.BtnVaciarClick
		'
		'btnAgregar
		'
		Me.btnAgregar.Location = New System.Drawing.Point(155, 165)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(107, 23)
		Me.btnAgregar.TabIndex = 11
		Me.btnAgregar.Text = "AGREGAR"
		Me.btnAgregar.UseVisualStyleBackColor = true
		AddHandler Me.btnAgregar.Click, AddressOf Me.BtnAgregarClick
		'
		'btnBorrar
		'
		Me.btnBorrar.Location = New System.Drawing.Point(293, 165)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(107, 23)
		Me.btnBorrar.TabIndex = 12
		Me.btnBorrar.Text = "BORRAR"
		Me.btnBorrar.UseVisualStyleBackColor = true
		AddHandler Me.btnBorrar.Click, AddressOf Me.BtnBorrarClick
		'
		'dgvDatos
		'
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(13, 213)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.Size = New System.Drawing.Size(548, 128)
		Me.dgvDatos.TabIndex = 13
		'
		'AltasProductos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(573, 353)
		Me.Controls.Add(Me.dgvDatos)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.btnVaciar)
		Me.Controls.Add(Me.idDeptoProd)
		Me.Controls.Add(Me.existProd)
		Me.Controls.Add(Me.precioProd)
		Me.Controls.Add(Me.descripProd)
		Me.Controls.Add(Me.codigoProd)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "AltasProductos"
		Me.Text = "AltasProductos"
		AddHandler Load, AddressOf Me.AltasProductosLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private dgvDatos As System.Windows.Forms.DataGridView
	Private btnBorrar As System.Windows.Forms.Button
	Private btnAgregar As System.Windows.Forms.Button
	Private btnVaciar As System.Windows.Forms.Button
	Private idDeptoProd As System.Windows.Forms.TextBox
	Private existProd As System.Windows.Forms.TextBox
	Private precioProd As System.Windows.Forms.TextBox
	Private descripProd As System.Windows.Forms.TextBox
	Private codigoProd As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
